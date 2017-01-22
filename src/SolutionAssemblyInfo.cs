// --------------------------------------------------------------------------------------------------------------------
//    <copyright file="SolutionAssemblyInfo.cs" Company = "Hse Development Team.">
//      Copyright (c) 2008 - 2017 Hse, Inc., Inc. All rights reserved.
//    </copyright> 
// --------------------------------------------------------------------------------------------------------------------

#pragma warning disable 1699    // 1699 = Use command line option '/keyfile' or appropriate project settings instead of 'AssemblyKeyFile'

using System;
using System.Reflection;
using System.Resources;

// Shared assembly info that is common for all assemblies of this project

////[assembly: AssemblyTitle("DEFINED IN ACTUAL ASSEMBLYINFO")]
////[assembly: AssemblyProduct("DEFINED IN ACTUAL ASSEMBLYINFO")]
////[assembly: AssemblyDescription("DEFINED IN ACTUAL ASSEMBLYINFO")]

[assembly: AssemblyCompany("Hse, Inc.")]
[assembly: AssemblyCopyright("Copyright © 2017 Hse, Inc. All rights reserved.")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: NeutralResourcesLanguage("en-US")]

#if DEBUG

#if NET461
[assembly: AssemblyConfiguration("NET461, Debug")]
#endif

#else

#if NET461
[assembly: AssemblyConfiguration("NET461, Release")]
#endif

#endif

// CLS compliant
#if !NETFX_CORE && !XAMARIN

[assembly: CLSCompliant(true)]
#endif