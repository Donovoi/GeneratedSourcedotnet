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
	namespace System.Threading
	{
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal partial struct RTL_CRITICAL_SECTION_DEBUG
		{
			internal ushort Type;
			internal ushort CreatorBackTraceIndex;
			internal unsafe winmdroot.System.Threading.RTL_CRITICAL_SECTION* CriticalSection;
			internal winmdroot.System.Kernel.LIST_ENTRY ProcessLocksList;
			internal uint EntryCount;
			internal uint ContentionCount;
			internal uint Flags;
			internal ushort CreatorBackTraceIndexHigh;
			internal ushort SpareWORD;
		}
	}
}
