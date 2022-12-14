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
	namespace UI.Input.KeyboardAndMouse
	{
		/// <summary>Contains the time of the last input.</summary>
		/// <remarks>
		/// <para>This function is useful for input idle detection. For more information on tick counts, see <a href="https://docs.microsoft.com/windows/desktop/api/sysinfoapi/nf-sysinfoapi-gettickcount">GetTickCount</a>.</para>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-lastinputinfo#">Read more on docs.microsoft.com</see>.</para>
		/// </remarks>
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal partial struct LASTINPUTINFO
		{
			/// <summary>
			/// <para>Type: <b>UINT</b> The size of the structure, in bytes. This member must be set to <c>sizeof(LASTINPUTINFO)</c>.</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-lastinputinfo#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			internal uint cbSize;
			/// <summary>
			/// <para>Type: <b>DWORD</b> The tick count when the last input event was received.</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-lastinputinfo#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			internal uint dwTime;
		}
	}
}
