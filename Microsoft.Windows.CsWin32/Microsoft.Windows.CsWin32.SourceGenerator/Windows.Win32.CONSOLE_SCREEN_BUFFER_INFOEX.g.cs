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
	namespace System.Console
	{
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal partial struct CONSOLE_SCREEN_BUFFER_INFOEX
		{
			internal uint cbSize;
			internal winmdroot.System.Console.COORD dwSize;
			internal winmdroot.System.Console.COORD dwCursorPosition;
			internal winmdroot.System.Console.CONSOLE_CHARACTER_ATTRIBUTES wAttributes;
			internal winmdroot.System.Console.SMALL_RECT srWindow;
			internal winmdroot.System.Console.COORD dwMaximumWindowSize;
			internal ushort wPopupAttributes;
			internal winmdroot.Foundation.BOOL bFullscreenSupported;
			internal winmdroot.Foundation.__COLORREF_16 ColorTable;
		}
	}
}
