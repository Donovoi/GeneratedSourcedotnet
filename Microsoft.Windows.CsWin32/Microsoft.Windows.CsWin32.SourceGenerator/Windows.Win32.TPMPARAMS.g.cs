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
		/// <summary>Contains extended parameters for the TrackPopupMenuEx function.</summary>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-tpmparams">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal partial struct TPMPARAMS
		{
			/// <summary>
			/// <para>Type: <b>UINT</b> The size of structure, in bytes.</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-tpmparams#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			internal uint cbSize;
			/// <summary>
			/// <para>Type: <b><a href="https://docs.microsoft.com/windows/desktop/api/windef/ns-windef-rect">RECT</a></b> The rectangle to be excluded when positioning the window, in screen coordinates.</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-tpmparams#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			internal winmdroot.Foundation.RECT rcExclude;
		}
	}
}
