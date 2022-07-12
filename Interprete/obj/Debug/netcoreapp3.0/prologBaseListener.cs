//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     ANTLR Version: 4.6.6
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Generated from C:\Users\ghanv\source\repos\Interprete\Interprete\prolog.g4 by ANTLR 4.6.6

// Unreachable code detected
#pragma warning disable 0162
// The variable '...' is assigned but its value is never used
#pragma warning disable 0219
// Missing XML comment for publicly visible type or member '...'
#pragma warning disable 1591
// Ambiguous reference in cref attribute
#pragma warning disable 419

namespace Interprete {

using Antlr4.Runtime.Misc;
using IErrorNode = Antlr4.Runtime.Tree.IErrorNode;
using ITerminalNode = Antlr4.Runtime.Tree.ITerminalNode;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IprologListener"/>,
/// which can be extended to create a listener which only needs to handle a subset
/// of the available methods.
/// </summary>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class prologBaseListener : IprologListener {
	/// <summary>
	/// Enter a parse tree produced by the <c>clausula</c>
	/// labeled alternative in <see cref="prologParser.clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClausula([NotNull] prologParser.ClausulaContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>clausula</c>
	/// labeled alternative in <see cref="prologParser.clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClausula([NotNull] prologParser.ClausulaContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>lista_termvar</c>
	/// labeled alternative in <see cref="prologParser.termlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLista_termvar([NotNull] prologParser.Lista_termvarContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>lista_termvar</c>
	/// labeled alternative in <see cref="prologParser.termlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLista_termvar([NotNull] prologParser.Lista_termvarContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>lista_term</c>
	/// labeled alternative in <see cref="prologParser.termlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterLista_term([NotNull] prologParser.Lista_termContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>lista_term</c>
	/// labeled alternative in <see cref="prologParser.termlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitLista_term([NotNull] prologParser.Lista_termContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>prolog</c>
	/// labeled alternative in <see cref="prologParser.p_text"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterProlog([NotNull] prologParser.PrologContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>prolog</c>
	/// labeled alternative in <see cref="prologParser.p_text"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitProlog([NotNull] prologParser.PrologContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>compound_term</c>
	/// labeled alternative in <see cref="prologParser.term"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCompound_term([NotNull] prologParser.Compound_termContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>compound_term</c>
	/// labeled alternative in <see cref="prologParser.term"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCompound_term([NotNull] prologParser.Compound_termContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>backq_string</c>
	/// labeled alternative in <see cref="prologParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterBackq_string([NotNull] prologParser.Backq_stringContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>backq_string</c>
	/// labeled alternative in <see cref="prologParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitBackq_string([NotNull] prologParser.Backq_stringContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>cut</c>
	/// labeled alternative in <see cref="prologParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterCut([NotNull] prologParser.CutContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>cut</c>
	/// labeled alternative in <see cref="prologParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitCut([NotNull] prologParser.CutContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>empty_braces</c>
	/// labeled alternative in <see cref="prologParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEmpty_braces([NotNull] prologParser.Empty_bracesContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>empty_braces</c>
	/// labeled alternative in <see cref="prologParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEmpty_braces([NotNull] prologParser.Empty_bracesContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>dq_string</c>
	/// labeled alternative in <see cref="prologParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDq_string([NotNull] prologParser.Dq_stringContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>dq_string</c>
	/// labeled alternative in <see cref="prologParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDq_string([NotNull] prologParser.Dq_stringContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>name</c>
	/// labeled alternative in <see cref="prologParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterName([NotNull] prologParser.NameContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>name</c>
	/// labeled alternative in <see cref="prologParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitName([NotNull] prologParser.NameContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>quoted_string</c>
	/// labeled alternative in <see cref="prologParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterQuoted_string([NotNull] prologParser.Quoted_stringContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>quoted_string</c>
	/// labeled alternative in <see cref="prologParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitQuoted_string([NotNull] prologParser.Quoted_stringContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>empty_list</c>
	/// labeled alternative in <see cref="prologParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterEmpty_list([NotNull] prologParser.Empty_listContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>empty_list</c>
	/// labeled alternative in <see cref="prologParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitEmpty_list([NotNull] prologParser.Empty_listContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>graphic</c>
	/// labeled alternative in <see cref="prologParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterGraphic([NotNull] prologParser.GraphicContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>graphic</c>
	/// labeled alternative in <see cref="prologParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitGraphic([NotNull] prologParser.GraphicContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>semicolon</c>
	/// labeled alternative in <see cref="prologParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterSemicolon([NotNull] prologParser.SemicolonContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>semicolon</c>
	/// labeled alternative in <see cref="prologParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitSemicolon([NotNull] prologParser.SemicolonContext context) { }

	/// <summary>
	/// Enter a parse tree produced by the <c>directiva</c>
	/// labeled alternative in <see cref="prologParser.directive"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDirectiva([NotNull] prologParser.DirectivaContext context) { }
	/// <summary>
	/// Exit a parse tree produced by the <c>directiva</c>
	/// labeled alternative in <see cref="prologParser.directive"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDirectiva([NotNull] prologParser.DirectivaContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="prologParser.p_text"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterP_text([NotNull] prologParser.P_textContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="prologParser.p_text"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitP_text([NotNull] prologParser.P_textContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="prologParser.directive"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterDirective([NotNull] prologParser.DirectiveContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="prologParser.directive"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitDirective([NotNull] prologParser.DirectiveContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="prologParser.clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterClause([NotNull] prologParser.ClauseContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="prologParser.clause"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitClause([NotNull] prologParser.ClauseContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="prologParser.termlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTermlist([NotNull] prologParser.TermlistContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="prologParser.termlist"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTermlist([NotNull] prologParser.TermlistContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="prologParser.term"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterTerm([NotNull] prologParser.TermContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="prologParser.term"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitTerm([NotNull] prologParser.TermContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="prologParser.operator_"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterOperator_([NotNull] prologParser.Operator_Context context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="prologParser.operator_"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitOperator_([NotNull] prologParser.Operator_Context context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="prologParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterAtom([NotNull] prologParser.AtomContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="prologParser.atom"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitAtom([NotNull] prologParser.AtomContext context) { }

	/// <summary>
	/// Enter a parse tree produced by <see cref="prologParser.integer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void EnterInteger([NotNull] prologParser.IntegerContext context) { }
	/// <summary>
	/// Exit a parse tree produced by <see cref="prologParser.integer"/>.
	/// <para>The default implementation does nothing.</para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	public virtual void ExitInteger([NotNull] prologParser.IntegerContext context) { }

	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void EnterEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void ExitEveryRule([NotNull] ParserRuleContext context) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitTerminal([NotNull] ITerminalNode node) { }
	/// <inheritdoc/>
	/// <remarks>The default implementation does nothing.</remarks>
	public virtual void VisitErrorNode([NotNull] IErrorNode node) { }
}
} // namespace Interprete
