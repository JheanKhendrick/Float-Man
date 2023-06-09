using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Unity.Services.Core.Registration")]
[assembly: InternalsVisibleTo("Unity.Services.Core.Editor")]
[assembly: InternalsVisibleTo("Unity.Services.Core.Environments.Editor")]

#if UNITY_INCLUDE_TESTS
[assembly: InternalsVisibleTo("Unity.Services.Core.Tests")]
[assembly: InternalsVisibleTo("Unity.Services.Core.EditorTests")]
[assembly: InternalsVisibleTo("Unity.Services.Core.EditorTests.Environments")]
[assembly: InternalsVisibleTo("Unity.Services.Core.TestUtils.Tests")]
[assembly: InternalsVisibleTo("Unity.Services.Core.TestUtils.EditorTests")]
[assembly: InternalsVisibleTo("DynamicProxyGenAssembly2")]
#endif
