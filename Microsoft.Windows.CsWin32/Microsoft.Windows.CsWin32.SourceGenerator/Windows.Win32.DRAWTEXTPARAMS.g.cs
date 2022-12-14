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
	namespace Graphics.Gdi
	{
		/// <summary>The DRAWTEXTPARAMS structure contains extended formatting options for the DrawTextEx function.</summary>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//winuser/ns-winuser-drawtextparams">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal partial struct DRAWTEXTPARAMS
		{
			/// <summary>The structure size, in bytes.</summary>
			internal uint cbSize;
			/// <summary>The size of each tab stop, in units equal to the average character width.</summary>
			internal int iTabLength;
			/// <summary>The left margin, in units equal to the average character width.</summary>
			internal int iLeftMargin;
			/// <summary>The right margin, in units equal to the average character width.</summary>
			internal int iRightMargin;
			/// <summary>Receives the number of characters processed by <a href="https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-drawtextexa">DrawTextEx</a>, including white-space characters. The number can be the <a href="https://docs.microsoft.com/windows/desktop/gdi/specifying-length-of-text-output-string">length of the string</a> or the index of the first line that falls below the drawing area. Note that <b>DrawTextEx</b> always processes the entire string if the DT_NOCLIP formatting flag is specified.</summary>
			internal uint uiLengthDrawn;
		}
	}
}
