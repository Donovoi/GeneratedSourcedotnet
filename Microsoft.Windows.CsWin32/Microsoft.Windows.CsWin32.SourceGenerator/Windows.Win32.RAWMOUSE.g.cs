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
	namespace UI.Input
	{
		/// <summary>Contains information about the state of the mouse.</summary>
		/// <remarks>
		/// <para>If the mouse has moved, indicated by **MOUSE_MOVE_RELATIVE** or **MOUSE_MOVE_ABSOLUTE**, **lLastX** and **lLastY** specify information about that movement. The information is specified as relative or absolute integer values. If **MOUSE_MOVE_RELATIVE** value is specified, **lLastX** and **lLastY** specify movement relative to the previous mouse event (the last reported position). Positive values mean the mouse moved right (or down); negative values mean the mouse moved left (or up). If **MOUSE_MOVE_ABSOLUTE** value is specified, **lLastX** and **lLastY** contain normalized absolute coordinates between 0 and 65,535. Coordinate (0,0) maps onto the upper-left corner of the display surface; coordinate (65535,65535) maps onto the lower-right corner. In a multimonitor system, the coordinates map to the primary monitor. If **MOUSE_VIRTUAL_DESKTOP** is specified in addition to **MOUSE_MOVE_ABSOLUTE**, the coordinates map to the entire virtual desktop. </para>
		/// <para>This doc was truncated.</para>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-rawmouse#">Read more on docs.microsoft.com</see>.</para>
		/// </remarks>
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal partial struct RAWMOUSE
		{
			/// <summary>
			/// <para>Type: **USHORT** The mouse state. This member can be any reasonable combination of the following. | Value | Meaning | |-------|---------| | **MOUSE_MOVE_RELATIVE**</br>0x00 | Mouse movement data is relative to the last mouse position. For further information about mouse motion, see the following Remarks section. | | **MOUSE_MOVE_ABSOLUTE**</br>0x01 | Mouse movement data is based on absolute position. For further information about mouse motion, see the following Remarks section. | | **MOUSE_VIRTUAL_DESKTOP**</br>0x02 | Mouse coordinates are mapped to the virtual desktop (for a multiple monitor system). For further information about mouse motion, see the following Remarks section. | | **MOUSE_ATTRIBUTES_CHANGED**</br>0x04 | Mouse attributes changed; application needs to query the mouse attributes. | | **MOUSE_MOVE_NOCOALESCE**</br>0x08 | This mouse movement event was not coalesced. Mouse movement events can be coalescened by default.<br/>Windows XP/2000: This value is not supported. |</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-rawmouse#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			internal ushort usFlags;
			internal winmdroot.UI.Input.RAWMOUSE._Anonymous_e__Union Anonymous;
			/// <summary>
			/// <para>Type: **ULONG** The raw state of the mouse buttons. The Win32 subsystem does not use this member.</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-rawmouse#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			internal uint ulRawButtons;
			/// <summary>
			/// <para>Type: **LONG** The motion in the X direction. This is signed relative motion or absolute motion, depending on the value of **usFlags**.</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-rawmouse#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			internal int lLastX;
			/// <summary>
			/// <para>Type: **LONG** The motion in the Y direction. This is signed relative motion or absolute motion, depending on the value of **usFlags**.</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-rawmouse#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			internal int lLastY;
			/// <summary>
			/// <para>Type: **ULONG** The device-specific additional information for the event.</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-rawmouse#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			internal uint ulExtraInformation;

			[StructLayout(LayoutKind.Explicit)]
			[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
			internal partial struct _Anonymous_e__Union
			{
				[FieldOffset(0)]
				internal uint ulButtons;
				[FieldOffset(0)]
				internal winmdroot.UI.Input.RAWMOUSE._Anonymous_e__Union._Anonymous_e__Struct Anonymous;

				[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
				internal partial struct _Anonymous_e__Struct
				{
					internal ushort usButtonFlags;
					internal ushort usButtonData;
				}
			}
		}
	}
}
