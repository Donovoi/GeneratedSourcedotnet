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
	namespace UI.Input
	{
		/// <summary>The ID of the input message source.</summary>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//winuser/ne-winuser-input_message_origin_id">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal enum INPUT_MESSAGE_ORIGIN_ID
		{
			/// <summary>The source isn't identified.</summary>
			IMO_UNAVAILABLE = 0,
			/// <summary>
			/// <para>The input message is from a hardware device or has been  injected into the message queue by an application that has the <b>UIAccess</b> attribute set to TRUE in its manifest file. For more information about the <b>UIAccess</b> attribute and application manifests, see <a href="https://docs.microsoft.com/previous-versions/bb756883(v=msdn.10)">UAC References</a>.</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//winuser/ne-winuser-input_message_origin_id#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			IMO_HARDWARE = 1,
			/// <summary>The input message has been injected (through the <a href="https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-sendinput">SendInput</a> function) by an application that doesn't have the <b>UIAccess</b> attribute set to TRUE in its manifest file.</summary>
			IMO_INJECTED = 2,
			/// <summary>The system has injected the input message.</summary>
			IMO_SYSTEM = 4,
		}
	}
}
