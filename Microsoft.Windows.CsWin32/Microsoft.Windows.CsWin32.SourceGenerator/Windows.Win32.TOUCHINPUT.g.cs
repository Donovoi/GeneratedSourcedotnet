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
	namespace UI.Input.Touch
	{
		/// <summary>Encapsulates data for touch input.</summary>
		/// <remarks>
		/// <para>The following table lists the flags for the <b>dwFlags</b> member. </para>
		/// <para>This doc was truncated.</para>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-touchinput#">Read more on docs.microsoft.com</see>.</para>
		/// </remarks>
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal partial struct TOUCHINPUT
		{
			/// <summary>The x-coordinate (horizontal point) of the touch input. This member is indicated in hundredths of a pixel of physical screen coordinates.</summary>
			internal int x;
			/// <summary>The y-coordinate (vertical point) of the touch input. This member is indicated in hundredths of a pixel of physical screen coordinates.</summary>
			internal int y;
			/// <summary>A device handle for the source input device.  Each device is given a unique provider at run time by the touch input provider. See **Examples** section below.</summary>
			internal winmdroot.Foundation.HANDLE hSource;
			/// <summary>A touch point identifier that distinguishes a particular touch input.  This value stays consistent in a touch contact sequence from the point a contact comes down until it comes back up. An ID may be reused later for subsequent contacts.</summary>
			internal uint dwID;
			/// <summary>A set of bit flags that specify various aspects of touch point press, release, and motion. The bits in this member can be any reasonable combination of the values in the Remarks section.</summary>
			internal winmdroot.UI.Input.Touch.TOUCHEVENTF_FLAGS dwFlags;
			/// <summary>A set of bit flags that specify which of the optional fields in the structure contain valid values. The availability of valid information in the optional fields is device-specific. Applications should use an optional field value only when the corresponding bit is set in <i>dwMask</i>. This field may contain a combination of the <i>dwMask</i> flags mentioned in the Remarks section.</summary>
			internal winmdroot.UI.Input.Touch.TOUCHINPUTMASKF_MASK dwMask;
			/// <summary>The time stamp for the event, in milliseconds.  The consuming application should note that the system performs no validation on this field; when the <b>TOUCHINPUTMASKF_TIMEFROMSYSTEM</b> flag is not set, the accuracy and sequencing of values in this field are completely dependent on the touch input provider.</summary>
			internal uint dwTime;
			/// <summary>An additional value associated with the touch event.</summary>
			internal nuint dwExtraInfo;
			/// <summary>The width of the touch contact area in hundredths of a pixel in physical screen coordinates. This value is only valid if the <b>dwMask</b> member has the <b>TOUCHEVENTFMASK_CONTACTAREA</b> flag set.</summary>
			internal uint cxContact;
			/// <summary>The height of the touch contact area in hundredths of a pixel in physical screen coordinates. This value is only valid if the <b>dwMask</b> member has the <b>TOUCHEVENTFMASK_CONTACTAREA</b> flag set.</summary>
			internal uint cyContact;
		}
	}
}