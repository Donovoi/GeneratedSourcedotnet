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
	namespace Storage.FileSystem
	{
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal partial struct DISK_SPACE_INFORMATION
		{
			internal ulong ActualTotalAllocationUnits;
			internal ulong ActualAvailableAllocationUnits;
			internal ulong ActualPoolUnavailableAllocationUnits;
			internal ulong CallerTotalAllocationUnits;
			internal ulong CallerAvailableAllocationUnits;
			internal ulong CallerPoolUnavailableAllocationUnits;
			internal ulong UsedAllocationUnits;
			internal ulong TotalReservedAllocationUnits;
			internal ulong VolumeStorageReserveAllocationUnits;
			internal ulong AvailableCommittedAllocationUnits;
			internal ulong PoolAvailableAllocationUnits;
			internal uint SectorsPerAllocationUnit;
			internal uint BytesPerSector;
		}
	}
}
