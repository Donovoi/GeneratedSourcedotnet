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
		[Flags]
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal enum MESSAGEBOX_STYLE : uint
		{
			MB_ABORTRETRYIGNORE = 0x00000002,
			MB_CANCELTRYCONTINUE = 0x00000006,
			MB_HELP = 0x00004000,
			MB_OK = 0x00000000,
			MB_OKCANCEL = 0x00000001,
			MB_RETRYCANCEL = 0x00000005,
			MB_YESNO = 0x00000004,
			MB_YESNOCANCEL = 0x00000003,
			MB_ICONHAND = 0x00000010,
			MB_ICONQUESTION = 0x00000020,
			MB_ICONEXCLAMATION = 0x00000030,
			MB_ICONASTERISK = 0x00000040,
			MB_USERICON = 0x00000080,
			MB_ICONWARNING = 0x00000030,
			MB_ICONERROR = 0x00000010,
			MB_ICONINFORMATION = 0x00000040,
			MB_ICONSTOP = 0x00000010,
			MB_DEFBUTTON1 = 0x00000000,
			MB_DEFBUTTON2 = 0x00000100,
			MB_DEFBUTTON3 = 0x00000200,
			MB_DEFBUTTON4 = 0x00000300,
			MB_APPLMODAL = 0x00000000,
			MB_SYSTEMMODAL = 0x00001000,
			MB_TASKMODAL = 0x00002000,
			MB_NOFOCUS = 0x00008000,
			MB_SETFOREGROUND = 0x00010000,
			MB_DEFAULT_DESKTOP_ONLY = 0x00020000,
			MB_TOPMOST = 0x00040000,
			MB_RIGHT = 0x00080000,
			MB_RTLREADING = 0x00100000,
			MB_SERVICE_NOTIFICATION = 0x00200000,
			MB_SERVICE_NOTIFICATION_NT3X = 0x00040000,
			MB_TYPEMASK = 0x0000000F,
			MB_ICONMASK = 0x000000F0,
			MB_DEFMASK = 0x00000F00,
			MB_MODEMASK = 0x00003000,
			MB_MISCMASK = 0x0000C000,
		}
	}
}
