﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#pragma warning disable CS1591,CS1573,CS0465,CS0649,CS8019,CS1570,CS1584,CS1658,CS0436,CS8981
using global::System;
using global::System.Diagnostics;
using global::System.Diagnostics.CodeAnalysis;
using global::System.Runtime.CompilerServices;
using global::System.Runtime.InteropServices;
using global::System.Runtime.Versioning;
using winmdroot = global::Windows.Win32;
namespace Windows.Win32
{
	namespace Globalization
	{
		[Flags]
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal enum COMPARE_STRING_FLAGS : uint
		{
			LINGUISTIC_IGNORECASE = 0x00000010,
			LINGUISTIC_IGNOREDIACRITIC = 0x00000020,
			NORM_IGNORECASE = 0x00000001,
			NORM_IGNOREKANATYPE = 0x00010000,
			NORM_IGNORENONSPACE = 0x00000002,
			NORM_IGNORESYMBOLS = 0x00000004,
			NORM_IGNOREWIDTH = 0x00020000,
			NORM_LINGUISTIC_CASING = 0x08000000,
			SORT_DIGITSASNUMBERS = 0x00000008,
			SORT_STRINGSORT = 0x00001000,
		}
	}
}
