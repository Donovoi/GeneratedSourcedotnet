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
	namespace System.SystemInformation
	{
		/// <summary>Represents the number and affinity of processors in a processor group.</summary>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//winnt/ns-winnt-processor_group_info">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal partial struct PROCESSOR_GROUP_INFO
		{
			/// <summary>The maximum number of processors in the group.</summary>
			internal byte MaximumProcessorCount;
			/// <summary>The number of active processors in the group.</summary>
			internal byte ActiveProcessorCount;
			/// <summary>This member is reserved.</summary>
			internal winmdroot.__byte_38 Reserved;
			/// <summary>A bitmap that specifies the affinity for zero or more active processors within the group.</summary>
			internal nuint ActiveProcessorMask;
		}
	}
}