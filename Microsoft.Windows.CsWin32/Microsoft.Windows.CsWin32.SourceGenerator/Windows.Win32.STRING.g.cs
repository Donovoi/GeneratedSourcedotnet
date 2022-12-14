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
	namespace System.Kernel
	{
		/// <summary>Used with the RtlUnicodeStringToOemString function.</summary>
		/// <remarks>
		/// <para>The data type used in the <b>DestinationString</b> parameter of the <a href="https://docs.microsoft.com/windows/desktop/api/winternl/nf-winternl-rtlunicodestringtooemstring">RtlUnicodeStringToOemString</a> function, <c> POEM_STRING</c>, is defined as:</para>
		/// <para><c>typedef PSTRING POEM_STRING;</c></para>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//winternl/ns-winternl-string#">Read more on docs.microsoft.com</see>.</para>
		/// </remarks>
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal partial struct STRING
		{
			/// <summary>The length of the buffer.</summary>
			internal ushort Length;
			/// <summary>The maximum length of the buffer.</summary>
			internal ushort MaximumLength;
			/// <summary>The address of the buffer.</summary>
			internal winmdroot.Foundation.PSTR Buffer;
		}
	}
}
