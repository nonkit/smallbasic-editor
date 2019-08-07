// <copyright file="DiagnosticCode.Generated.cs" company="MIT License">
// Licensed under the MIT License. See LICENSE file in the project root for license information.
// </copyright>

/// <summary>
/// This file is auto-generated by a build task. It shouldn't be edited by hand.
/// </summary>
namespace SmallBasic.Compiler.Diagnostics
{
    using SmallBasic.Utilities;
    using SmallBasic.Utilities.Resources;

    public enum DiagnosticCode
    {
        UnrecognizedCharacter,
        UnterminatedStringLiteral,
        UnexpectedTokenFound,
        UnexpectedEndOfStream,
        UnexpectedStatementInsteadOfNewLine,
        UnexpectedTokenInsteadOfStatement,
        TwoSubModulesWithTheSameName,
        TwoLabelsWithTheSameName,
        GoToUndefinedLabel,
        PropertyHasNoSetter,
        AssigningNonSubModuleToEvent,
        UnassignedExpressionStatement,
        InvalidExpressionStatement,
        UnsupportedArrayBaseExpression,
        ValueIsNotANumber,
        UnsupportedDotBaseExpression,
        ExpectedExpressionWithAValue,
        LibraryMemberNotFound,
        UnexpectedArgumentsCount,
        UnsupportedInvocationBaseExpression,
        LibraryMemberDeprecatedFromOlderVersion,
        LibraryMemberNeedsDesktop,
    }

    internal static partial class DiagnosticCodeExtensions
    {
        public static string ToDisplayString(this DiagnosticCode kind)
        {
            switch (kind)
            {
                case DiagnosticCode.UnrecognizedCharacter: return DiagnosticsResources.UnrecognizedCharacter;
                case DiagnosticCode.UnterminatedStringLiteral: return DiagnosticsResources.UnterminatedStringLiteral;
                case DiagnosticCode.UnexpectedTokenFound: return DiagnosticsResources.UnexpectedTokenFound;
                case DiagnosticCode.UnexpectedEndOfStream: return DiagnosticsResources.UnexpectedEndOfStream;
                case DiagnosticCode.UnexpectedStatementInsteadOfNewLine: return DiagnosticsResources.UnexpectedStatementInsteadOfNewLine;
                case DiagnosticCode.UnexpectedTokenInsteadOfStatement: return DiagnosticsResources.UnexpectedTokenInsteadOfStatement;
                case DiagnosticCode.TwoSubModulesWithTheSameName: return DiagnosticsResources.TwoSubModulesWithTheSameName;
                case DiagnosticCode.TwoLabelsWithTheSameName: return DiagnosticsResources.TwoLabelsWithTheSameName;
                case DiagnosticCode.GoToUndefinedLabel: return DiagnosticsResources.GoToUndefinedLabel;
                case DiagnosticCode.PropertyHasNoSetter: return DiagnosticsResources.PropertyHasNoSetter;
                case DiagnosticCode.AssigningNonSubModuleToEvent: return DiagnosticsResources.AssigningNonSubModuleToEvent;
                case DiagnosticCode.UnassignedExpressionStatement: return DiagnosticsResources.UnassignedExpressionStatement;
                case DiagnosticCode.InvalidExpressionStatement: return DiagnosticsResources.InvalidExpressionStatement;
                case DiagnosticCode.UnsupportedArrayBaseExpression: return DiagnosticsResources.UnsupportedArrayBaseExpression;
                case DiagnosticCode.ValueIsNotANumber: return DiagnosticsResources.ValueIsNotANumber;
                case DiagnosticCode.UnsupportedDotBaseExpression: return DiagnosticsResources.UnsupportedDotBaseExpression;
                case DiagnosticCode.ExpectedExpressionWithAValue: return DiagnosticsResources.ExpectedExpressionWithAValue;
                case DiagnosticCode.LibraryMemberNotFound: return DiagnosticsResources.LibraryMemberNotFound;
                case DiagnosticCode.UnexpectedArgumentsCount: return DiagnosticsResources.UnexpectedArgumentsCount;
                case DiagnosticCode.UnsupportedInvocationBaseExpression: return DiagnosticsResources.UnsupportedInvocationBaseExpression;
                case DiagnosticCode.LibraryMemberDeprecatedFromOlderVersion: return DiagnosticsResources.LibraryMemberDeprecatedFromOlderVersion;
                case DiagnosticCode.LibraryMemberNeedsDesktop: return DiagnosticsResources.LibraryMemberNeedsDesktop;
                default: throw ExceptionUtilities.UnexpectedValue(kind);
            }
        }
    }
}
