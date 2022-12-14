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
	namespace Security
	{
		/// <summary>Specifies the OCTET_STRING value type of the claim security attribute.</summary>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//winnt/ns-winnt-claim_security_attribute_octet_string_value">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal partial struct CLAIM_SECURITY_ATTRIBUTE_OCTET_STRING_VALUE
		{
			/// <summary>A pointer buffer that contains the <b>OCTET_STRING</b> value. The value is a series of bytes of the length indicated in the <b>ValueLength</b>  member.</summary>
			internal unsafe void* pValue;
			/// <summary>The length, in bytes, of the <b>OCTET_STRING</b>  value.</summary>
			internal uint ValueLength;
		}
	}
}
