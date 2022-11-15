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
	namespace System.StationsAndDesktops
	{
		/// <summary>Contains information about a window that denied a request from BroadcastSystemMessageEx.</summary>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-bsminfo">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal partial struct BSMINFO
		{
			/// <summary>
			/// <para>Type: <b>UINT</b> The size, in bytes, of this structure.</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-bsminfo#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			internal uint cbSize;
			/// <summary>
			/// <para>Type: <b>HDESK</b> A desktop handle to the window specified by <b>hwnd</b>. This value is returned only if <a href="https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-broadcastsystemmessageexa">BroadcastSystemMessageEx</a> specifies <b>BSF_RETURNHDESK</b> and <b>BSF_QUERY</b>.</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-bsminfo#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			internal winmdroot.System.StationsAndDesktops.HDESK hdesk;
			/// <summary>
			/// <para>Type: <b>HWND</b> A handle to the window that denied the request. This value is returned if <a href="https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-broadcastsystemmessageexa">BroadcastSystemMessageEx</a> specifies <b>BSF_QUERY</b>.</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-bsminfo#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			internal winmdroot.Foundation.HWND hwnd;
			/// <summary>
			/// <para>Type: <b>LUID</b> A locally unique identifier (LUID) for the window.</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-bsminfo#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			internal winmdroot.Foundation.LUID luid;
		}
	}
}
