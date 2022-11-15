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
	namespace System.Shutdown
	{
		[Flags]
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal enum SHUTDOWN_REASON : uint
		{
			SHTDN_REASON_NONE = 0x00000000,
			SHTDN_REASON_FLAG_COMMENT_REQUIRED = 0x01000000,
			SHTDN_REASON_FLAG_DIRTY_PROBLEM_ID_REQUIRED = 0x02000000,
			SHTDN_REASON_FLAG_CLEAN_UI = 0x04000000,
			SHTDN_REASON_FLAG_DIRTY_UI = 0x08000000,
			SHTDN_REASON_FLAG_MOBILE_UI_RESERVED = 0x10000000,
			SHTDN_REASON_FLAG_USER_DEFINED = 0x40000000,
			SHTDN_REASON_FLAG_PLANNED = 0x80000000,
			SHTDN_REASON_MAJOR_OTHER = 0x00000000,
			SHTDN_REASON_MAJOR_NONE = 0x00000000,
			SHTDN_REASON_MAJOR_HARDWARE = 0x00010000,
			SHTDN_REASON_MAJOR_OPERATINGSYSTEM = 0x00020000,
			SHTDN_REASON_MAJOR_SOFTWARE = 0x00030000,
			SHTDN_REASON_MAJOR_APPLICATION = 0x00040000,
			SHTDN_REASON_MAJOR_SYSTEM = 0x00050000,
			SHTDN_REASON_MAJOR_POWER = 0x00060000,
			SHTDN_REASON_MAJOR_LEGACY_API = 0x00070000,
			SHTDN_REASON_MINOR_OTHER = 0x00000000,
			SHTDN_REASON_MINOR_NONE = 0x000000FF,
			SHTDN_REASON_MINOR_MAINTENANCE = 0x00000001,
			SHTDN_REASON_MINOR_INSTALLATION = 0x00000002,
			SHTDN_REASON_MINOR_UPGRADE = 0x00000003,
			SHTDN_REASON_MINOR_RECONFIG = 0x00000004,
			SHTDN_REASON_MINOR_HUNG = 0x00000005,
			SHTDN_REASON_MINOR_UNSTABLE = 0x00000006,
			SHTDN_REASON_MINOR_DISK = 0x00000007,
			SHTDN_REASON_MINOR_PROCESSOR = 0x00000008,
			SHTDN_REASON_MINOR_NETWORKCARD = 0x00000009,
			SHTDN_REASON_MINOR_POWER_SUPPLY = 0x0000000A,
			SHTDN_REASON_MINOR_CORDUNPLUGGED = 0x0000000B,
			SHTDN_REASON_MINOR_ENVIRONMENT = 0x0000000C,
			SHTDN_REASON_MINOR_HARDWARE_DRIVER = 0x0000000D,
			SHTDN_REASON_MINOR_OTHERDRIVER = 0x0000000E,
			SHTDN_REASON_MINOR_BLUESCREEN = 0x0000000F,
			SHTDN_REASON_MINOR_SERVICEPACK = 0x00000010,
			SHTDN_REASON_MINOR_HOTFIX = 0x00000011,
			SHTDN_REASON_MINOR_SECURITYFIX = 0x00000012,
			SHTDN_REASON_MINOR_SECURITY = 0x00000013,
			SHTDN_REASON_MINOR_NETWORK_CONNECTIVITY = 0x00000014,
			SHTDN_REASON_MINOR_WMI = 0x00000015,
			SHTDN_REASON_MINOR_SERVICEPACK_UNINSTALL = 0x00000016,
			SHTDN_REASON_MINOR_HOTFIX_UNINSTALL = 0x00000017,
			SHTDN_REASON_MINOR_SECURITYFIX_UNINSTALL = 0x00000018,
			SHTDN_REASON_MINOR_MMC = 0x00000019,
			SHTDN_REASON_MINOR_SYSTEMRESTORE = 0x0000001A,
			SHTDN_REASON_MINOR_TERMSRV = 0x00000020,
			SHTDN_REASON_MINOR_DC_PROMOTION = 0x00000021,
			SHTDN_REASON_MINOR_DC_DEMOTION = 0x00000022,
			SHTDN_REASON_UNKNOWN = 0x000000FF,
			SHTDN_REASON_LEGACY_API = 0x80070000,
			SHTDN_REASON_VALID_BIT_MASK = 0xC0FFFFFF,
		}
	}
}