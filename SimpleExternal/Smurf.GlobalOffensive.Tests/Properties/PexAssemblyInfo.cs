// <copyright file="PexAssemblyInfo.cs">Copyright ©  2015</copyright>
using Microsoft.Pex.Framework.Coverage;
using Microsoft.Pex.Framework.Creatable;
using Microsoft.Pex.Framework.Instrumentation;
using Microsoft.Pex.Framework.Settings;
using Microsoft.Pex.Framework.Validation;

// Microsoft.Pex.Framework.Settings
[assembly: PexAssemblySettings(TestFramework = "VisualStudioUnitTest")]

// Microsoft.Pex.Framework.Instrumentation
[assembly: PexAssemblyUnderTest("Smurf.GlobalOffensive")]
[assembly: PexInstrumentAssembly("System.Numerics.Vectors")]
[assembly: PexInstrumentAssembly("Smurf.Common")]
[assembly: PexInstrumentAssembly("System.Core")]
[assembly: PexInstrumentAssembly("INIFileParser")]
[assembly: PexInstrumentAssembly("BlueRain")]
[assembly: PexInstrumentAssembly("System.Windows.Forms")]

// Microsoft.Pex.Framework.Creatable
[assembly: PexCreatableFactoryForDelegates]

// Microsoft.Pex.Framework.Validation
[assembly: PexAllowedContractRequiresFailureAtTypeUnderTestSurface]
[assembly: PexAllowedXmlDocumentedException]

// Microsoft.Pex.Framework.Coverage
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Numerics.Vectors")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "Smurf.Common")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Core")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "INIFileParser")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "BlueRain")]
[assembly: PexCoverageFilterAssembly(PexCoverageDomain.UserOrTestCode, "System.Windows.Forms")]

