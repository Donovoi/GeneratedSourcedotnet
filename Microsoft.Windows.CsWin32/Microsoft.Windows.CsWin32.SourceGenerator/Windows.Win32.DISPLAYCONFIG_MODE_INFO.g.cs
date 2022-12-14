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
	namespace Devices.Display
	{
		/// <summary>The DISPLAYCONFIG_MODE_INFO structure contains either source mode or target mode information.</summary>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//wingdi/ns-wingdi-displayconfig_mode_info">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal partial struct DISPLAYCONFIG_MODE_INFO
		{
			/// <summary>A value that indicates whether the <b>DISPLAYCONFIG_MODE_INFO</b> structure represents source or target mode information. If <b>infoType</b> is DISPLAYCONFIG_MODE_INFO_TYPE_TARGET, the <i>targetMode</i> parameter value contains a valid DISPLAYCONFIG_TARGET_MODE structure describing the specified target. If <b>infoType</b> is DISPLAYCONFIG_MODE_INFO_TYPE_SOURCE, the <i>sourceMode</i> parameter value contains a valid DISPLAYCONFIG_SOURCE_MODE structure describing the specified source.</summary>
			internal winmdroot.Devices.Display.DISPLAYCONFIG_MODE_INFO_TYPE infoType;
			/// <summary>The source or target identifier on the specified adapter that this path relates to.</summary>
			internal uint id;
			/// <summary>The identifier of the adapter that this source or target mode information relates to.</summary>
			internal winmdroot.Foundation.LUID adapterId;
			internal winmdroot.Devices.Display.DISPLAYCONFIG_MODE_INFO._Anonymous_e__Union Anonymous;

			[StructLayout(LayoutKind.Explicit)]
			[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
			internal partial struct _Anonymous_e__Union
			{
				[FieldOffset(0)]
				internal winmdroot.Devices.Display.DISPLAYCONFIG_TARGET_MODE targetMode;
				[FieldOffset(0)]
				internal winmdroot.Devices.Display.DISPLAYCONFIG_SOURCE_MODE sourceMode;
				[FieldOffset(0)]
				internal winmdroot.Devices.Display.DISPLAYCONFIG_DESKTOP_IMAGE_INFO desktopImageInfo;
			}
		}
	}
}
