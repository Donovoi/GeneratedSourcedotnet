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
	namespace UI.Input.Pointer
	{
		/// <summary>Identifies a change in the state of a button associated with a pointer.</summary>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//winuser/ne-winuser-pointer_button_change_type">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal enum POINTER_BUTTON_CHANGE_TYPE
		{
			/// <summary>No change in button state.</summary>
			POINTER_CHANGE_NONE = 0,
			/// <summary>The first button (see <a href="https://docs.microsoft.com/previous-versions/windows/desktop/inputmsg/pointer-flags-contants">POINTER_FLAG_FIRSTBUTTON</a>) transitioned to a pressed state.</summary>
			POINTER_CHANGE_FIRSTBUTTON_DOWN = 1,
			/// <summary>The first button (see <a href="https://docs.microsoft.com/previous-versions/windows/desktop/inputmsg/pointer-flags-contants">POINTER_FLAG_FIRSTBUTTON</a>) transitioned to a released state.</summary>
			POINTER_CHANGE_FIRSTBUTTON_UP = 2,
			/// <summary>The second button (see <a href="https://docs.microsoft.com/previous-versions/windows/desktop/inputmsg/pointer-flags-contants">POINTER_FLAG_SECONDBUTTON</a>) transitioned to a pressed state.</summary>
			POINTER_CHANGE_SECONDBUTTON_DOWN = 3,
			/// <summary>The second button (see <a href="https://docs.microsoft.com/previous-versions/windows/desktop/inputmsg/pointer-flags-contants">POINTER_FLAG_SECONDBUTTON</a>) transitioned to a released state.</summary>
			POINTER_CHANGE_SECONDBUTTON_UP = 4,
			/// <summary>The third button (see <a href="https://docs.microsoft.com/previous-versions/windows/desktop/inputmsg/pointer-flags-contants">POINTER_FLAG_THIRDBUTTON</a>) transitioned to a pressed state.</summary>
			POINTER_CHANGE_THIRDBUTTON_DOWN = 5,
			/// <summary>The third button (see <a href="https://docs.microsoft.com/previous-versions/windows/desktop/inputmsg/pointer-flags-contants">POINTER_FLAG_THIRDBUTTON</a>) transitioned to a released state.</summary>
			POINTER_CHANGE_THIRDBUTTON_UP = 6,
			/// <summary>The fourth button (see <a href="https://docs.microsoft.com/previous-versions/windows/desktop/inputmsg/pointer-flags-contants">POINTER_FLAG_FOURTHBUTTON</a>) transitioned to a pressed state.</summary>
			POINTER_CHANGE_FOURTHBUTTON_DOWN = 7,
			/// <summary>The fourth button (see <a href="https://docs.microsoft.com/previous-versions/windows/desktop/inputmsg/pointer-flags-contants">POINTER_FLAG_FOURTHBUTTON</a>) transitioned to a released state.</summary>
			POINTER_CHANGE_FOURTHBUTTON_UP = 8,
			/// <summary>The fifth button (see <a href="https://docs.microsoft.com/previous-versions/windows/desktop/inputmsg/pointer-flags-contants">POINTER_FLAG_FIFTHBUTTON</a>) transitioned to a pressed state.</summary>
			POINTER_CHANGE_FIFTHBUTTON_DOWN = 9,
			/// <summary>The fifth button (see <a href="https://docs.microsoft.com/previous-versions/windows/desktop/inputmsg/pointer-flags-contants">POINTER_FLAG_FIFTHBUTTON</a>) transitioned to a released state.</summary>
			POINTER_CHANGE_FIFTHBUTTON_UP = 10,
		}
	}
}
