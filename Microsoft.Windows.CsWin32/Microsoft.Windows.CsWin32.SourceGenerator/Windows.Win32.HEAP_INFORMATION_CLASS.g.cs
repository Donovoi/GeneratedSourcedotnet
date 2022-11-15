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
	namespace System.Memory
	{
		/// <summary>Specifies the class of heap information to be set or retrieved.</summary>
		/// <remarks>
		/// <para>To retrieve information about a heap, use the <a href="https://docs.microsoft.com/windows/desktop/api/heapapi/nf-heapapi-heapqueryinformation">HeapQueryInformation</a> function. To enable features for a heap, use the <a href="https://docs.microsoft.com/windows/desktop/api/heapapi/nf-heapapi-heapsetinformation">HeapSetInformation</a> function. <b>Windows XP and Windows Server 2003:  </b> A look-aside list is a fast memory allocation mechanism that contains only fixed-sized blocks. Look-aside lists are enabled by default for heaps that support them. Starting with Windows Vista, look-aside lists are not used and the LFH is enabled by default. Look-aside lists are faster than general pool allocations that vary in size, because the system does not search for free memory that fits the allocation. In addition, access to look-aside lists is generally synchronized using fast atomic processor exchange instructions instead of mutexes or spinlocks. Look-aside lists can be created by the system or drivers. They can be allocated from paged or nonpaged pool.</para>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//winnt/ne-winnt-heap_information_class#">Read more on docs.microsoft.com</see>.</para>
		/// </remarks>
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal enum HEAP_INFORMATION_CLASS
		{
			/// <summary>
			/// <para>The heap features that are enabled. The available features vary based on operating system. Depending on the <i>HeapInformation</i> parameter in the <a href="https://docs.microsoft.com/windows/desktop/api/heapapi/nf-heapapi-heapqueryinformation">HeapQueryInformation</a> or <a href="https://docs.microsoft.com/windows/desktop/api/heapapi/nf-heapapi-heapsetinformation">HeapSetInformation</a> functions, specifying this enumeration value can indicate one of the following features: </para>
			/// <para>This doc was truncated.</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//winnt/ne-winnt-heap_information_class#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			HeapCompatibilityInformation = 0,
			/// <summary>
			/// <para>The terminate-on-corruption feature. If the heap manager detects an error in any heap used by the process, it calls the Windows Error Reporting service and terminates the process. After a process enables this feature, it cannot be disabled.</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//winnt/ne-winnt-heap_information_class#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			HeapEnableTerminationOnCorruption = 1,
			/// <summary></summary>
			HeapOptimizeResources = 3,
			HeapTag = 7,
		}
	}
}
