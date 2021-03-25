// This file is used by Code Analysis to maintain SuppressMessage
// attributes that are applied to this project.
// Project-level suppressions either have no target or are given
// a specific target and scoped to a namespace, type, member, etc.

using System.Diagnostics.CodeAnalysis;

[assembly: SuppressMessage("StyleCop.CSharp.OrderingRules", "SA1200:UsingDirectivesMustBePlacedWithinNamespace", Justification = "UsingDirectives Must Not Be Placed Within Namespace...")]
[assembly: SuppressMessage("StyleCop.CSharp.DocumentationRules", "SA1633:File should have header", Justification = "I don't need it")]
[assembly: SuppressMessage("Style", "IDE0044:Add readonly modifier", Justification = "Nope", Scope = "member", Target = "~F:Rock_Paper_Scissors.GameLogic.pickList")]
[assembly: SuppressMessage("StyleCop.CSharp.OrderingRules", "SA1201:Elements should appear in the correct order", Justification = "Nope", Scope = "member", Target = "~F:Rock_Paper_Scissors.GameLogic.pickedNumberList")]
