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
		[Flags]
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal enum THREAD_ACCESS_RIGHTS : uint
		{
			THREAD_TERMINATE = 0x00000001,
			THREAD_SUSPEND_RESUME = 0x00000002,
			THREAD_GET_CONTEXT = 0x00000008,
			THREAD_SET_CONTEXT = 0x00000010,
			THREAD_SET_INFORMATION = 0x00000020,
			THREAD_QUERY_INFORMATION = 0x00000040,
			THREAD_SET_THREAD_TOKEN = 0x00000080,
			THREAD_IMPERSONATE = 0x00000100,
			THREAD_DIRECT_IMPERSONATION = 0x00000200,
			THREAD_SET_LIMITED_INFORMATION = 0x00000400,
			THREAD_QUERY_LIMITED_INFORMATION = 0x00000800,
			THREAD_RESUME = 0x00001000,
			THREAD_ALL_ACCESS = 0x001FFFFF,
			THREAD_DELETE = 0x00010000,
			THREAD_READ_CONTROL = 0x00020000,
			THREAD_WRITE_DAC = 0x00040000,
			THREAD_WRITE_OWNER = 0x00080000,
			THREAD_SYNCHRONIZE = 0x00100000,
			THREAD_STANDARD_RIGHTS_REQUIRED = 0x000F0000,
		}
	}
}
