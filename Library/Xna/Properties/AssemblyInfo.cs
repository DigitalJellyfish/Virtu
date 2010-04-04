﻿using System;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using Jellyfish.Library;

[assembly: AssemblyTitle("Library")]
[assembly: AssemblyDescription("Common Library")]
#if XBOX
[assembly: AssemblyProduct("Jellyfish.Library.Xna.Xbox")]
#elif ZUNE
[assembly: AssemblyProduct("Jellyfish.Library.Xna.Zune")]
#else
[assembly: AssemblyProduct("Jellyfish.Library.Xna")]
#endif
[assembly: AssemblyCompany("Digital Jellyfish Design Ltd")]
[assembly: AssemblyCopyright("Copyright © 2009-2010 Digital Jellyfish Design Ltd")]
[assembly: AssemblyComment("Developed by Sean Fausett")]

[assembly: AssemblyVersion("0.1.0.0")]
#if WINDOWS
[assembly: AssemblyFileVersion("0.1.0.0")]
#endif
[assembly: AssemblyInformationalVersion("0.1.0.0")]

[assembly: CLSCompliant(false)]
[assembly: ComVisible(false)]
[assembly: Guid("66034b9e-9f0b-47b0-aac4-cade9a748891")]

[assembly: NeutralResourcesLanguage("en")]
