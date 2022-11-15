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
		/// <summary>The DISPLAYCONFIG_MODE_INFO_TYPE enumeration specifies that the information that is contained within the DISPLAYCONFIG_MODE_INFO structure is either source or target mode.</summary>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//wingdi/ne-wingdi-displayconfig_mode_info_type">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal enum DISPLAYCONFIG_MODE_INFO_TYPE
		{
			/// <summary>Indicates that the <a href="https://docs.microsoft.com/windows/desktop/api/wingdi/ns-wingdi-displayconfig_mode_info">DISPLAYCONFIG_MODE_INFO</a> structure contains source mode information.</summary>
			DISPLAYCONFIG_MODE_INFO_TYPE_SOURCE = 1,
			/// <summary>Indicates that the <a href="https://docs.microsoft.com/windows/desktop/api/wingdi/ns-wingdi-displayconfig_mode_info">DISPLAYCONFIG_MODE_INFO</a> structure contains target mode information.</summary>
			DISPLAYCONFIG_MODE_INFO_TYPE_TARGET = 2,
			/// <summary>Indicates that the <a href="https://docs.microsoft.com/windows/desktop/api/wingdi/ns-wingdi-displayconfig_mode_info">DISPLAYCONFIG_MODE_INFO</a> structure contains a valid <a href="https://docs.microsoft.com/windows/desktop/api/wingdi/ns-wingdi-displayconfig_desktop_image_info">DISPLAYCONFIG_DESKTOP_IMAGE_INFO</a> structure. Supported starting in Windows 10.</summary>
			DISPLAYCONFIG_MODE_INFO_TYPE_DESKTOP_IMAGE = 3,
			/// <summary>Forces this enumeration to compile to 32 bits in size. Without this value, some compilers would allow this enumeration to compile to a size other than 32 bits. You should not use this value.</summary>
			DISPLAYCONFIG_MODE_INFO_TYPE_FORCE_UINT32 = -1,
		}
	}
}
