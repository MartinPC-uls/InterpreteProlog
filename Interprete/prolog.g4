grammar prolog;

p_text locals [string l="", string r=""]:  
    c=clause{$r=$c.texto;} (clist=clause {$r=$r+"&"+$clist.texto;} )* d=directive{$l=$d.texto;} (dlist=directive{$l=$l+"&"+$dlist.texto;})* EOF 
    #prolog; 

directive returns [string texto] locals [string t=""]:
    left=term ':-' center=term {$t=$left.texto+"|"+$center.texto;} (',' right=term {$t=$t+"|"+$right.texto;} )* '.' {$texto=$t;} 
    #directiva; 

clause returns [string texto] : 
    left=term '.' {$texto=$left.texto;}
    #clausula; 

termlist returns [string texto] locals [string t=""]:
      left=atom {$t=$left.text;} (','right=atom {$t=$t+" "+$right.text;})* {$texto=$t;} # lista_term
    | left=VARIABLE {$t=$left.text;} (','right=VARIABLE {$t=$t+" "+$right.text;})* {$texto=$t;} # lista_termvar
    ;

term returns [string texto] locals [string t=""]
:left=atom '(' right=termlist ')' {$t=$left.text+"///"+$right.text; $texto=$t;}  # compound_term
;


operator_
    : ':-' | '-->'
    | '?-'
    | 'dynamic' | 'multifile' | 'discontiguous' | 'public' //TODO: move operators used in directives to "built-in" definition of dialect
    | ';'
    | '->'
    | ','
    | '\\+'
    | '=' | '\\='
    | '==' | '\\==' | '@<' | '@=<' | '@>' | '@>='
    | '=..'
    | 'is' | '=:=' | '=\\=' | '<' | '=<' | '>' | '>='
    | ':' // modules: 5.2.1
    | '+' | '-' | '/\\' | '\\/'
    | '*' | '/' | '//' | 'rem' | 'mod' | '<<' | '>>' //TODO: '/' cannot be used as atom because token here not in GRAPHIC. only works because , is operator too. example: swipl/filesex.pl:177
    | '**'
    | '^'
    | '\\'
    ;

atom // 6.4.2 and 6.1.2
    : '[' ']'           # empty_list //NOTE [] is not atom anymore in swipl 7 and later
    | '{' '}'           # empty_braces
    | LETTER_DIGIT      # name
    | GRAPHIC_TOKEN     # graphic
    | QUOTED            # quoted_string
    | DOUBLE_QUOTED_LIST# dq_string
    | BACK_QUOTED_STRING# backq_string
    | ';'               # semicolon
    | '!'               # cut
    ;


integer // 6.4.4
    : DECIMAL
    | CHARACTER_CODE_CONSTANT
    | BINARY
    | OCTAL
    | HEX
    ;


// Lexer (6.4 & 6.5): Tokens formed from Characters

LETTER_DIGIT // 6.4.2
    : SMALL_LETTER ALPHANUMERIC*
    ;

VARIABLE // 6.4.3
    : CAPITAL_LETTER ALPHANUMERIC*
    | '_' ALPHANUMERIC+
    | '_'
    ;

// 6.4.4
DECIMAL: DIGIT+ ;
BINARY: '0b' [01]+ ;
OCTAL: '0o' [0-7]+ ;
HEX: '0x' HEX_DIGIT+ ;

CHARACTER_CODE_CONSTANT: '0' '\'' SINGLE_QUOTED_CHARACTER ;

FLOAT: DECIMAL '.' [0-9]+ ( [eE] [+-] DECIMAL )? ;


GRAPHIC_TOKEN: (GRAPHIC | '\\')+ ; // 6.4.2
fragment GRAPHIC: [#$&*+./:<=>?@^~] | '-' ; // 6.5.1 graphic char

// 6.4.2.1
fragment SINGLE_QUOTED_CHARACTER: NON_QUOTE_CHAR | '\'\'' | '"' | '`' ;
fragment DOUBLE_QUOTED_CHARACTER: NON_QUOTE_CHAR | '\'' | '""' | '`' ;
fragment BACK_QUOTED_CHARACTER: NON_QUOTE_CHAR | '\'' | '"' | '``' ;
fragment NON_QUOTE_CHAR
    : GRAPHIC
    | ALPHANUMERIC
    | SOLO
    | ' ' // space char
    | META_ESCAPE
    | CONTROL_ESCAPE
    | OCTAL_ESCAPE
    | HEX_ESCAPE
    ;
fragment META_ESCAPE: '\\' [\\'"`] ; // meta char
fragment CONTROL_ESCAPE: '\\' [abrftnv] ;
fragment OCTAL_ESCAPE: '\\' [0-7]+ '\\' ;
fragment HEX_ESCAPE: '\\x' HEX_DIGIT+ '\\' ;

QUOTED:          '\'' (CONTINUATION_ESCAPE | SINGLE_QUOTED_CHARACTER )*? '\'' ; // 6.4.2
DOUBLE_QUOTED_LIST: '"' (CONTINUATION_ESCAPE | DOUBLE_QUOTED_CHARACTER )*? '"'; // 6.4.6
BACK_QUOTED_STRING: '`' (CONTINUATION_ESCAPE | BACK_QUOTED_CHARACTER )*? '`'; // 6.4.7
fragment CONTINUATION_ESCAPE: '\\\n' ;

// 6.5.2
fragment ALPHANUMERIC: ALPHA | DIGIT ;
fragment ALPHA: '_' | SMALL_LETTER | CAPITAL_LETTER ;
fragment SMALL_LETTER: [a-z_];

fragment CAPITAL_LETTER: [A-Z];

fragment DIGIT: [0-9] ;
fragment HEX_DIGIT: [0-9a-fA-F] ;

// 6.5.3
fragment SOLO: [!(),;[{}|%] | ']' ;


WS
   : [ \t\r\n]+ -> skip
   ;

COMMENT: '%' ~[\n\r]* ( [\n\r] | EOF) -> channel(HIDDEN) ;
MULTILINE_COMMENT: '/*' ( MULTILINE_COMMENT | . )*? ('*/' | EOF) -> channel(HIDDEN);