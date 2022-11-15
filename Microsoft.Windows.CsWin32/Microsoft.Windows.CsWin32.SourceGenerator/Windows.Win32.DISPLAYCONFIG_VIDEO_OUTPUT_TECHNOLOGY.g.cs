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
		/// <summary>The DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY enumeration specifies the target's connector type.</summary>
		/// <remarks>
		/// <para>Values with "embedded" in their names indicate that the graphics adapter's video output device connects internally to the display device. In those cases, the DISPLAYCONFIG_OUTPUT_TECHNOLOGY_INTERNAL value is redundant. The caller should ignore DISPLAYCONFIG_OUTPUT_TECHNOLOGY_INTERNAL and just process the embedded values, DISPLAYCONFIG_OUTPUT_TECHNOLOGY_DISPLAYPORT_EMBEDDED and DISPLAYCONFIG_OUTPUT_TECHNOLOGY_UDI_EMBEDDED. An embedded display port or UDI is also known as an integrated display port or UDI.</para>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//wingdi/ne-wingdi-displayconfig_video_output_technology#">Read more on docs.microsoft.com</see>.</para>
		/// </remarks>
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal enum DISPLAYCONFIG_VIDEO_OUTPUT_TECHNOLOGY
		{
			/// <summary>Indicates a connector that is not one of the types that is indicated by the following enumerators in this enumeration.</summary>
			DISPLAYCONFIG_OUTPUT_TECHNOLOGY_OTHER = -1,
			/// <summary>Indicates an HD15 (VGA) connector.</summary>
			DISPLAYCONFIG_OUTPUT_TECHNOLOGY_HD15 = 0,
			/// <summary>Indicates an S-video connector.</summary>
			DISPLAYCONFIG_OUTPUT_TECHNOLOGY_SVIDEO = 1,
			/// <summary>Indicates a composite video connector group.</summary>
			DISPLAYCONFIG_OUTPUT_TECHNOLOGY_COMPOSITE_VIDEO = 2,
			/// <summary>Indicates a component video connector group.</summary>
			DISPLAYCONFIG_OUTPUT_TECHNOLOGY_COMPONENT_VIDEO = 3,
			/// <summary>Indicates a Digital Video Interface (DVI) connector.</summary>
			DISPLAYCONFIG_OUTPUT_TECHNOLOGY_DVI = 4,
			/// <summary>Indicates a High-Definition Multimedia Interface (HDMI) connector.</summary>
			DISPLAYCONFIG_OUTPUT_TECHNOLOGY_HDMI = 5,
			/// <summary>Indicates a Low Voltage Differential Swing (LVDS) connector.</summary>
			DISPLAYCONFIG_OUTPUT_TECHNOLOGY_LVDS = 6,
			/// <summary>Indicates a Japanese D connector.</summary>
			DISPLAYCONFIG_OUTPUT_TECHNOLOGY_D_JPN = 8,
			/// <summary>Indicates an SDI connector.</summary>
			DISPLAYCONFIG_OUTPUT_TECHNOLOGY_SDI = 9,
			/// <summary>Indicates an external display port, which is a display port that connects externally to a display device.</summary>
			DISPLAYCONFIG_OUTPUT_TECHNOLOGY_DISPLAYPORT_EXTERNAL = 10,
			/// <summary>Indicates an embedded display port that connects internally to a display device.</summary>
			DISPLAYCONFIG_OUTPUT_TECHNOLOGY_DISPLAYPORT_EMBEDDED = 11,
			/// <summary>Indicates an external Unified Display Interface (UDI), which is a UDI that connects externally to a display device.</summary>
			DISPLAYCONFIG_OUTPUT_TECHNOLOGY_UDI_EXTERNAL = 12,
			/// <summary>Indicates an embedded UDI that connects internally to a display device.</summary>
			DISPLAYCONFIG_OUTPUT_TECHNOLOGY_UDI_EMBEDDED = 13,
			/// <summary>Indicates a dongle cable that supports standard definition television (SDTV).</summary>
			DISPLAYCONFIG_OUTPUT_TECHNOLOGY_SDTVDONGLE = 14,
			/// <summary>
			/// <para>Indicates that the VidPN target is  a Miracast wireless display device. Supported starting in Windows 8.1.</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//wingdi/ne-wingdi-displayconfig_video_output_technology#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			DISPLAYCONFIG_OUTPUT_TECHNOLOGY_MIRACAST = 15,
			/// <summary></summary>
			DISPLAYCONFIG_OUTPUT_TECHNOLOGY_INDIRECT_WIRED = 16,
			/// <summary></summary>
			DISPLAYCONFIG_OUTPUT_TECHNOLOGY_INDIRECT_VIRTUAL = 17,
			DISPLAYCONFIG_OUTPUT_TECHNOLOGY_DISPLAYPORT_USB_TUNNEL = 18,
			/// <summary>Indicates that the video output device connects internally to a display device (for example, the internal connection in a laptop computer).</summary>
			DISPLAYCONFIG_OUTPUT_TECHNOLOGY_INTERNAL = -2147483648,
			/// <summary>Forces this enumeration to compile to 32 bits in size. Without this value, some compilers would allow this enumeration to compile to a size other than 32 bits. You should not use this value.</summary>
			DISPLAYCONFIG_OUTPUT_TECHNOLOGY_FORCE_UINT32 = -1,
		}
	}
}
