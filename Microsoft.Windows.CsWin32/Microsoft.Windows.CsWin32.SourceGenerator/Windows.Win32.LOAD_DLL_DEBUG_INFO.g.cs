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
		/// <summary>Contains information about a dynamic-link library (DLL) that has just been loaded.</summary>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//minwinbase/ns-minwinbase-load_dll_debug_info">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal partial struct LOAD_DLL_DEBUG_INFO
		{
			/// <summary>
			/// <para>A handle to the loaded DLL. If this member is <b>NULL</b>, the handle is not valid. Otherwise, the member is opened for reading and read-sharing in the context of the debugger. When the debugger is finished with this file, it should close the handle using the <a href="https://docs.microsoft.com/windows/desktop/api/handleapi/nf-handleapi-closehandle">CloseHandle</a> function.</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//minwinbase/ns-minwinbase-load_dll_debug_info#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			internal winmdroot.Foundation.HANDLE hFile;
			/// <summary>A pointer to the base address of the DLL in the address space of the process loading the DLL.</summary>
			internal unsafe void* lpBaseOfDll;
			/// <summary>The offset to the debugging information in the file identified by the <b>hFile</b> member, in bytes. The system expects the debugging information to be in CodeView 4.0 format. This format is currently a derivative of Common Object File Format (COFF).</summary>
			internal uint dwDebugInfoFileOffset;
			/// <summary>The size of the debugging information in the file, in bytes. If this member is zero, there is no debugging information.</summary>
			internal uint nDebugInfoSize;
			/// <summary>
			/// <para>A pointer to the file name associated with <b>hFile</b>. This member may be <b>NULL</b>, or it may contain the address of a string pointer in the address space of the process being debugged. That address may, in turn, either be <b>NULL</b> or point to the actual filename. If <b>fUnicode</b> is a nonzero value, the name string is Unicode; otherwise, it is ANSI.</para>
			/// <para>This member is strictly optional. Debuggers must be prepared to handle the case where <b>lpImageName</b> is <b>NULL</b> or *<b>lpImageName</b> (in the address space of the process being debugged) is <b>NULL</b>. Specifically, the system will never provide an image name for a create process event, and it will not likely pass an image name for the first DLL event. The system will also never provide this information in the case of debugging events that originate from a call to the <a href="https://docs.microsoft.com/windows/desktop/api/debugapi/nf-debugapi-debugactiveprocess">DebugActiveProcess</a> function.</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//minwinbase/ns-minwinbase-load_dll_debug_info#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			internal unsafe void* lpImageName;
			/// <summary>A value that indicates whether a filename specified by <b>lpImageName</b> is Unicode or ANSI. A nonzero value for this member indicates Unicode; zero indicates ANSI.</summary>
			internal ushort fUnicode;
		}
	}
}
