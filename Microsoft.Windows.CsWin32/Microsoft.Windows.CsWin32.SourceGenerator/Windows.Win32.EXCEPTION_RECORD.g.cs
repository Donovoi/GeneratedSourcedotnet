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
	namespace System.Diagnostics.Debug
	{
		/// <summary>Describes an exception.</summary>
		/// <remarks>
		/// <para>To enable a debugger to debug a target that is running on a different architecture (32-bit versus 64-bit), use one of the explicit forms of this structure.</para>
		/// <para></para>
		/// <para>This doc was truncated.</para>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//winnt/ns-winnt-exception_record#">Read more on docs.microsoft.com</see>.</para>
		/// </remarks>
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal partial struct EXCEPTION_RECORD
		{
			/// <summary>
			/// <para>The reason the exception occurred. This is the code generated by a hardware exception, or the code specified in the <a href="https://docs.microsoft.com/windows/desktop/api/errhandlingapi/nf-errhandlingapi-raiseexception">RaiseException</a> function for a software-generated exception. The following tables describes the exception codes that are likely to occur due to common programming errors.</para>
			/// <para></para>
			/// <para>This doc was truncated.</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//winnt/ns-winnt-exception_record#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			internal winmdroot.Foundation.NTSTATUS ExceptionCode;
			/// <summary>The exception flags. This member can be either zero, indicating a continuable exception, or <b>EXCEPTION_NONCONTINUABLE</b> indicating a noncontinuable exception. Any attempt to continue execution after a noncontinuable exception causes the <b>EXCEPTION_NONCONTINUABLE_EXCEPTION</b> exception.</summary>
			internal uint ExceptionFlags;
			/// <summary>
			/// <para>A pointer to an associated <b>EXCEPTION_RECORD</b> structure. Exception records can be chained together to provide additional information when nested exceptions occur.</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//winnt/ns-winnt-exception_record#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			internal unsafe winmdroot.System.Diagnostics.Debug.EXCEPTION_RECORD* ExceptionRecord;
			/// <summary>The address where the exception occurred.</summary>
			internal unsafe void* ExceptionAddress;
			/// <summary>The number of parameters associated with the exception. This is the number of defined elements in the <b>ExceptionInformation</b> array.</summary>
			internal uint NumberParameters;
			/// <summary>
			/// <para>An array of additional arguments that describe the exception. The <a href="https://docs.microsoft.com/windows/desktop/api/errhandlingapi/nf-errhandlingapi-raiseexception">RaiseException</a> function can specify this array of arguments. For most exception codes, the array elements are undefined. The following table describes the exception codes whose array elements are defined.</para>
			/// <para></para>
			/// <para>This doc was truncated.</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//winnt/ns-winnt-exception_record#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			internal winmdroot.__nuint_15 ExceptionInformation;
		}
	}
}
