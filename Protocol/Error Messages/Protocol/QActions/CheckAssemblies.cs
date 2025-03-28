// <auto-generated>This is auto-generated code by Validator Management Tool. Do not modify.</auto-generated>
namespace Skyline.DataMiner.CICD.Validators.Protocol.Tests.Protocol.QActions.CheckAssemblies
{
    using System;
    using System.Collections.Generic;

    using Skyline.DataMiner.CICD.Models.Protocol.Read;
    using Skyline.DataMiner.CICD.Validators.Common.Interfaces;
    using Skyline.DataMiner.CICD.Validators.Common.Model;
    using Skyline.DataMiner.CICD.Validators.Protocol.Common;
    using Skyline.DataMiner.CICD.Validators.Protocol.Interfaces;

    internal static class Error
    {
        public static IValidationResult UnconsolidatedPackageReference(IValidate test, IReadable referenceNode, IReadable positionNode, string packageId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckAssemblies,
                ErrorId = ErrorIds.UnconsolidatedPackageReference,
                FullId = "3.38.1",
                Category = Category.QAction,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Package '{0}' has multiple versions across different QActions.", packageId),
                HowToFix = "Consolidate the package references so they have the same version across all projects.",
                ExampleCode = "",
                Details = "When multiple QActions are using different versions of a NuGet package, it can lead to runtime exceptions such as MissingMethodException or InvalidCastException." + Environment.NewLine + "To fix these issues, it is important to use the same version of a NuGet package across the entire solution." + Environment.NewLine + "" + Environment.NewLine + "'Skyline.DataMiner.Dev.*' (aka DevPacks) or 'Skyline.DataMiner.Files.*' NuGet packages should also be aligned across all projects of the solution as these packages represent the DataMiner version that is being developed against.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult UnconsolidatedPackageReference_Sub(IValidate test, IReadable referenceNode, IReadable positionNode, string qactionId, string packageId, string packageVersion)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckAssemblies,
                ErrorId = ErrorIds.UnconsolidatedPackageReference_Sub,
                FullId = "3.38.2",
                Category = Category.QAction,
                Severity = Severity.Major,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("QAction '{0}' has package '{1}' with version '{2}'.", qactionId, packageId, packageVersion),
                HowToFix = "Consolidate the package references so they have the same version across all projects.",
                ExampleCode = "",
                Details = "When multiple QActions are using different versions of a NuGet package, it can lead to runtime exceptions such as MissingMethodException or InvalidCastException." + Environment.NewLine + "To fix these issues, it is important to use the same version of a NuGet package across the entire solution." + Environment.NewLine + "" + Environment.NewLine + "'Skyline.DataMiner.Dev.*' (aka DevPacks) or 'Skyline.DataMiner.Files.*' NuGet packages should also be aligned across all projects of the solution as these packages represent the DataMiner version that is being developed against.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }

        public static IValidationResult MissingSecureCoding(IValidate test, IReadable referenceNode, IReadable positionNode, string qactionId)
        {
            return new ValidationResult
            {
                Test = test,
                CheckId = CheckId.CheckAssemblies,
                ErrorId = ErrorIds.MissingSecureCoding,
                FullId = "3.38.3",
                Category = Category.QAction,
                Severity = Severity.Critical,
                Certainty = Certainty.Certain,
                Source = Source.Validator,
                FixImpact = FixImpact.NonBreaking,
                GroupDescription = "",
                Description = String.Format("Missing Skyline.DataMiner.Utils.SecureCoding.Analyzers NuGet package. QAction ID '{0}'.", qactionId),
                HowToFix = "Include the Skyline.DataMiner.Utils.SecureCoding.Analyzers NuGet package in all projects within the solution.",
                ExampleCode = "",
                Details = "Secure Coding is a NuGet library designed to streamline secure development by minimizing the need for boilerplate code. This library offers a set of methods and functionalities aimed at enhancing the security of your applications, reducing common vulnerabilities, and promoting secure coding practices.",
                HasCodeFix = false,

                PositionNode = positionNode,
                ReferenceNode = referenceNode,
            };
        }
    }

    internal static class ErrorIds
    {
        public const uint UnconsolidatedPackageReference = 1;
        public const uint UnconsolidatedPackageReference_Sub = 2;
        public const uint MissingSecureCoding = 3;
    }

    /// <summary>
    /// Contains the identifiers of the checks.
    /// </summary>
    public static class CheckId
    {
        /// <summary>
        /// The check identifier.
        /// </summary>
        public const uint CheckAssemblies = 38;
    }
}