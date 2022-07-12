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
using Antlr4.Runtime.Tree;
using IToken = Antlr4.Runtime.IToken;
using ParserRuleContext = Antlr4.Runtime.ParserRuleContext;

/// <summary>
/// This class provides an empty implementation of <see cref="IprologVisitor{Result}"/>,
/// which can be extended to create a visitor which only needs to handle a subset
/// of the available methods.
/// </summary>
/// <typeparam name="Result">The return type of the visit operation.</typeparam>
[System.CodeDom.Compiler.GeneratedCode("ANTLR", "4.6.6")]
[System.CLSCompliant(false)]
public partial class prologBaseVisitor<Result> : AbstractParseTreeVisitor<Result>, IprologVisitor<Result> {
	/// <summary>
	/// Visit a parse tree produced by the <c>clausula</c>
	/// labeled alternative in <see cref="prologParser.clause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitClausula([NotNull] prologParser.ClausulaContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>lista_termvar</c>
	/// labeled alternative in <see cref="prologParser.termlist"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitLista_termvar([NotNull] prologParser.Lista_termvarContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>lista_term</c>
	/// labeled alternative in <see cref="prologParser.termlist"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitLista_term([NotNull] prologParser.Lista_termContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>prolog</c>
	/// labeled alternative in <see cref="prologParser.p_text"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitProlog([NotNull] prologParser.PrologContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>compound_term</c>
	/// labeled alternative in <see cref="prologParser.term"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCompound_term([NotNull] prologParser.Compound_termContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>backq_string</c>
	/// labeled alternative in <see cref="prologParser.atom"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitBackq_string([NotNull] prologParser.Backq_stringContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>cut</c>
	/// labeled alternative in <see cref="prologParser.atom"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitCut([NotNull] prologParser.CutContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>empty_braces</c>
	/// labeled alternative in <see cref="prologParser.atom"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitEmpty_braces([NotNull] prologParser.Empty_bracesContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>dq_string</c>
	/// labeled alternative in <see cref="prologParser.atom"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDq_string([NotNull] prologParser.Dq_stringContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>name</c>
	/// labeled alternative in <see cref="prologParser.atom"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitName([NotNull] prologParser.NameContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>quoted_string</c>
	/// labeled alternative in <see cref="prologParser.atom"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitQuoted_string([NotNull] prologParser.Quoted_stringContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>empty_list</c>
	/// labeled alternative in <see cref="prologParser.atom"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitEmpty_list([NotNull] prologParser.Empty_listContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>graphic</c>
	/// labeled alternative in <see cref="prologParser.atom"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitGraphic([NotNull] prologParser.GraphicContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>semicolon</c>
	/// labeled alternative in <see cref="prologParser.atom"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitSemicolon([NotNull] prologParser.SemicolonContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by the <c>directiva</c>
	/// labeled alternative in <see cref="prologParser.directive"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDirectiva([NotNull] prologParser.DirectivaContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="prologParser.p_text"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitP_text([NotNull] prologParser.P_textContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="prologParser.directive"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitDirective([NotNull] prologParser.DirectiveContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="prologParser.clause"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitClause([NotNull] prologParser.ClauseContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="prologParser.termlist"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTermlist([NotNull] prologParser.TermlistContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="prologParser.term"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitTerm([NotNull] prologParser.TermContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="prologParser.operator_"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitOperator_([NotNull] prologParser.Operator_Context context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="prologParser.atom"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitAtom([NotNull] prologParser.AtomContext context) { return VisitChildren(context); }

	/// <summary>
	/// Visit a parse tree produced by <see cref="prologParser.integer"/>.
	/// <para>
	/// The default implementation returns the result of calling <see cref="AbstractParseTreeVisitor{Result}.VisitChildren(IRuleNode)"/>
	/// on <paramref name="context"/>.
	/// </para>
	/// </summary>
	/// <param name="context">The parse tree.</param>
	/// <return>The visitor result.</return>
	public virtual Result VisitInteger([NotNull] prologParser.IntegerContext context) { return VisitChildren(context); }
}
} // namespace Interprete
