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
	namespace Devices.Display
	{
		/// <summary>The DISPLAYCONFIG_SCANLINE_ORDERING enumeration specifies the method that the display uses to create an image on a screen.</summary>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//wingdi/ne-wingdi-displayconfig_scanline_ordering">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal enum DISPLAYCONFIG_SCANLINE_ORDERING
		{
			/// <summary>Indicates that scan-line ordering of the output is unspecified. The caller can only set the <b>scanLineOrdering</b> member of the <a href="https://docs.microsoft.com/windows/desktop/api/wingdi/ns-wingdi-displayconfig_path_target_info">DISPLAYCONFIG_PATH_TARGET_INFO</a> structure in a call to the <a href="https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-setdisplayconfig">SetDisplayConfig</a> function to DISPLAYCONFIG_SCANLINE_ORDERING_UNSPECIFIED if the caller also set the refresh rate denominator and numerator of the <b>refreshRate</b> member both to zero. In this case, <b>SetDisplayConfig</b> uses the best refresh rate it can find.</summary>
			DISPLAYCONFIG_SCANLINE_ORDERING_UNSPECIFIED = 0,
			/// <summary>Indicates that the output is a progressive image.</summary>
			DISPLAYCONFIG_SCANLINE_ORDERING_PROGRESSIVE = 1,
			/// <summary>Indicates that the output is an interlaced image that is created beginning with the upper field.</summary>
			DISPLAYCONFIG_SCANLINE_ORDERING_INTERLACED = 2,
			/// <summary>Indicates that the output is an interlaced image that is created beginning with the upper field.</summary>
			DISPLAYCONFIG_SCANLINE_ORDERING_INTERLACED_UPPERFIELDFIRST = 2,
			/// <summary>Indicates that the output is an interlaced image that is created beginning with the lower field.</summary>
			DISPLAYCONFIG_SCANLINE_ORDERING_INTERLACED_LOWERFIELDFIRST = 3,
			/// <summary>Forces this enumeration to compile to 32 bits in size. Without this value, some compilers would allow this enumeration to compile to a size other than 32 bits. You should not use this value.</summary>
			DISPLAYCONFIG_SCANLINE_ORDERING_FORCE_UINT32 = -1,
		}
	}
}
