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
		internal enum SYNCHRONIZATION_ACCESS_RIGHTS : uint
		{
			EVENT_ALL_ACCESS = 0x001F0003,
			EVENT_MODIFY_STATE = 0x00000002,
			MUTEX_ALL_ACCESS = 0x001F0001,
			MUTEX_MODIFY_STATE = 0x00000001,
			SEMAPHORE_ALL_ACCESS = 0x001F0003,
			SEMAPHORE_MODIFY_STATE = 0x00000002,
			TIMER_ALL_ACCESS = 0x001F0003,
			TIMER_MODIFY_STATE = 0x00000002,
			TIMER_QUERY_STATE = 0x00000001,
			SYNCHRONIZATION_DELETE = 0x00010000,
			SYNCHRONIZATION_READ_CONTROL = 0x00020000,
			SYNCHRONIZATION_WRITE_DAC = 0x00040000,
			SYNCHRONIZATION_WRITE_OWNER = 0x00080000,
			SYNCHRONIZATION_SYNCHRONIZE = 0x00100000,
		}
	}
}
