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
	namespace UI.Controls
	{
		/// <summary>Contains information about the pointer input type.</summary>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-pointer_type_info">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal partial struct POINTER_TYPE_INFO
		{
			/// <summary>The pointer input device.</summary>
			internal winmdroot.UI.WindowsAndMessaging.POINTER_INPUT_TYPE type;
			internal winmdroot.UI.Controls.POINTER_TYPE_INFO._Anonymous_e__Union Anonymous;

			[StructLayout(LayoutKind.Explicit)]
			[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
			internal partial struct _Anonymous_e__Union
			{
				[FieldOffset(0)]
				internal winmdroot.UI.Input.Pointer.POINTER_TOUCH_INFO touchInfo;
				[FieldOffset(0)]
				internal winmdroot.UI.Input.Pointer.POINTER_PEN_INFO penInfo;
			}
		}
	}
}
