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
		/// <summary>The DISPLAYCONFIG_PATH_INFO structure is used to describe a single path from a target to a source.</summary>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//wingdi/ns-wingdi-displayconfig_path_info">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal partial struct DISPLAYCONFIG_PATH_INFO
		{
			/// <summary>A <a href="https://docs.microsoft.com/windows/desktop/api/wingdi/ns-wingdi-displayconfig_path_source_info">DISPLAYCONFIG_PATH_SOURCE_INFO</a> structure that contains the source information for the path.</summary>
			internal winmdroot.Devices.Display.DISPLAYCONFIG_PATH_SOURCE_INFO sourceInfo;
			/// <summary>A <a href="https://docs.microsoft.com/windows/desktop/api/wingdi/ns-wingdi-displayconfig_path_target_info">DISPLAYCONFIG_PATH_TARGET_INFO</a> structure that contains the target information for the path.</summary>
			internal winmdroot.Devices.Display.DISPLAYCONFIG_PATH_TARGET_INFO targetInfo;
			/// <summary>A bitwise OR of flag values that indicates the state of the path. The following values are supported:</summary>
			internal uint flags;
		}
	}
}
