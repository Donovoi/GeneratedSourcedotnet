// ------------------------------------------------------------------------------
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
		/// <summary>Contains the address, format, and length, in bytes, of a debugging string.</summary>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//minwinbase/ns-minwinbase-output_debug_string_info">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal partial struct OUTPUT_DEBUG_STRING_INFO
		{
			/// <summary>
			/// <para>The debugging string in the calling process's address space. The debugger can use the <a href="https://docs.microsoft.com/windows/desktop/api/memoryapi/nf-memoryapi-readprocessmemory">ReadProcessMemory</a> function to retrieve the value of the string.</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//minwinbase/ns-minwinbase-output_debug_string_info#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			internal winmdroot.Foundation.PSTR lpDebugStringData;
			/// <summary>The format of the debugging string. If this member is zero, the debugging string is ANSI; if it is nonzero, the string is Unicode.</summary>
			internal ushort fUnicode;
			/// <summary>
			/// <para>The lower 16 bits of the length of the string in bytes. As nDebugStringLength is of type WORD, this does not always contain the full length of the string in bytes. For example, if the original output string is longer than 65536 bytes, this field will contain a value that is less than the actual string length in bytes.</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//minwinbase/ns-minwinbase-output_debug_string_info#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			internal ushort nDebugStringLength;
		}
	}
}
