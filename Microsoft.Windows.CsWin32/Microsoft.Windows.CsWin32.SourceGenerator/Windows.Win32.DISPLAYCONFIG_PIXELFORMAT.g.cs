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
		/// <summary>The DISPLAYCONFIG_PIXELFORMAT enumeration specifies pixel format in various bits per pixel (BPP) values.</summary>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//wingdi/ne-wingdi-displayconfig_pixelformat">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal enum DISPLAYCONFIG_PIXELFORMAT
		{
			/// <summary>Indicates 8 BPP format.</summary>
			DISPLAYCONFIG_PIXELFORMAT_8BPP = 1,
			/// <summary>Indicates 16 BPP format.</summary>
			DISPLAYCONFIG_PIXELFORMAT_16BPP = 2,
			/// <summary>Indicates 24 BPP format.</summary>
			DISPLAYCONFIG_PIXELFORMAT_24BPP = 3,
			/// <summary>Indicates 32 BPP format.</summary>
			DISPLAYCONFIG_PIXELFORMAT_32BPP = 4,
			/// <summary>Indicates that the current display is not an 8, 16, 24, or 32 BPP GDI desktop mode. For example, a call to the <a href="https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-querydisplayconfig">QueryDisplayConfig</a> function returns DISPLAYCONFIG_PIXELFORMAT_NONGDI if a DirectX application previously set the desktop to A2R10G10B10 format. A call to the <a href="https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-setdisplayconfig">SetDisplayConfig</a> function fails if any pixel formats for active paths are set to DISPLAYCONFIG_PIXELFORMAT_NONGDI.</summary>
			DISPLAYCONFIG_PIXELFORMAT_NONGDI = 5,
			/// <summary>Forces this enumeration to compile to 32 bits in size. Without this value, some compilers would allow this enumeration to compile to a size other than 32 bits. You should not use this value.</summary>
			DISPLAYCONFIG_PIXELFORMAT_FORCE_UINT32 = -1,
		}
	}
}