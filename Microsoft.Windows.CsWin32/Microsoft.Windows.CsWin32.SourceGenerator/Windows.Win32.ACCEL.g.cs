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
	namespace UI.WindowsAndMessaging
	{
		/// <summary>Defines an accelerator key used in an accelerator table.</summary>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-accel">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal partial struct ACCEL
		{
			/// <summary>Type: <b>BYTE</b></summary>
			internal winmdroot.UI.WindowsAndMessaging.ACCEL_VIRT_FLAGS fVirt;
			/// <summary>
			/// <para>Type: <b>WORD</b> The accelerator key. This member can be either a <a href="https://docs.microsoft.com/windows/desktop/inputdev/virtual-key-codes">virtual-key code</a> or a character code.</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-accel#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			internal ushort key;
			/// <summary>
			/// <para>Type: <b>WORD</b> The accelerator identifier. This value is placed in the low-order word of the <i>wParam</i> parameter of the <a href="https://docs.microsoft.com/windows/desktop/menurc/wm-command">WM_COMMAND</a> or <a href="https://docs.microsoft.com/windows/desktop/menurc/wm-syscommand">WM_SYSCOMMAND</a> message when the accelerator is pressed.</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-accel#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			internal ushort cmd;
		}
	}
}
