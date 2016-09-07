using System.Reflection;
using System.Runtime.InteropServices;

[assembly:AssemblyTitle("test")]
[assembly:AssemblyProduct("test")]
[assembly:AssemblyDescription("description of test.")]
[assembly:AssemblyCompany("Rik Cousens")]
[assembly:AssemblyCopyright("Copyright © 2016, Rik Cousens")]
#if DEBUG
[assembly:AssemblyConfiguration("Debug assemblyVersion")]
#else
[assembly:AssemblyConfiguration("Release assemblyVersion")]
#endif
[assembly:ComVisible(false)]

[assembly:AssemblyVersion("1.0.0.0")]
[assembly:AssemblyFileVersion("1.0.0.0")]
[assembly:AssemblyInformationalVersion("1.0.0.0")]

