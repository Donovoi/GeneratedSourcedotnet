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
		/// <summary>Contains information about the current state of both physical and virtual memory.</summary>
		/// <remarks>
		/// <para><b>MEMORYSTATUS</b> reflects the state of memory at the time of the call. It also reflects the size of the paging file at that time. The operating system can enlarge the paging file up to the maximum size set by the administrator. On computers with more than 4 GB of memory, the <b>MEMORYSTATUS</b> structure can return incorrect information, reporting a value of –1 to indicate an overflow. If your application is at risk for this behavior, use the <a href="https://docs.microsoft.com/windows/desktop/api/sysinfoapi/nf-sysinfoapi-globalmemorystatusex">GlobalMemoryStatusEx</a> function instead of the <a href="https://docs.microsoft.com/windows/desktop/api/winbase/nf-winbase-globalmemorystatus">GlobalMemoryStatus</a> function.</para>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//winbase/ns-winbase-memorystatus#">Read more on docs.microsoft.com</see>.</para>
		/// </remarks>
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal partial struct MEMORYSTATUS
		{
			/// <summary>
			/// <para>The size of the <b>MEMORYSTATUS</b> data structure, in bytes. You do not need to set this member before calling the <a href="https://docs.microsoft.com/windows/desktop/api/winbase/nf-winbase-globalmemorystatus">GlobalMemoryStatus</a> function; the function sets it.</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//winbase/ns-winbase-memorystatus#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			internal uint dwLength;
			/// <summary>A number between 0 and 100 that specifies the approximate percentage of physical memory that is in use (0 indicates no memory use and 100 indicates full memory use).</summary>
			internal uint dwMemoryLoad;
			/// <summary>The amount of actual physical memory, in bytes.</summary>
			internal nuint dwTotalPhys;
			/// <summary>The amount of physical memory currently available, in bytes. This is the amount of physical memory that can be immediately reused without having to write its contents to disk first. It is the sum of the size of the standby, free, and zero lists.</summary>
			internal nuint dwAvailPhys;
			/// <summary>The current size of the committed memory limit, in bytes. This is physical memory plus the size of the page file, minus a small overhead.</summary>
			internal nuint dwTotalPageFile;
			/// <summary>The maximum amount of memory the current process can commit, in bytes. This value should be smaller than the system-wide available commit. To calculate this value, call <a href="https://docs.microsoft.com/windows/desktop/api/psapi/nf-psapi-getperformanceinfo">GetPerformanceInfo</a> and subtract the value of <b>CommitTotal</b> from <b>CommitLimit</b>.</summary>
			internal nuint dwAvailPageFile;
			/// <summary>The size of the user-mode portion of the virtual address space of the calling process, in bytes. This value depends on the type of process, the type of processor, and the configuration of the operating system. For example, this value is approximately 2 GB for most 32-bit processes on an x86 processor and approximately 3 GB for 32-bit processes that are large address aware running on a system with 4 GT RAM Tuning enabled.</summary>
			internal nuint dwTotalVirtual;
			/// <summary>The amount of unreserved and uncommitted memory currently in the user-mode portion of the virtual address space of the calling process, in bytes.</summary>
			internal nuint dwAvailVirtual;
		}
	}
}
