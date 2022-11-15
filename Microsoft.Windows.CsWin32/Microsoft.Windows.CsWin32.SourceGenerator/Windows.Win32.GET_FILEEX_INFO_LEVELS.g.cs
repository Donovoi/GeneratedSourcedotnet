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
		/// <summary>Defines values that are used with the GetFileAttributesEx and GetFileAttributesTransacted functions to specify the information level of the returned data.</summary>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//minwinbase/ne-minwinbase-get_fileex_info_levels">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal enum GET_FILEEX_INFO_LEVELS
		{
			/// <summary>
			/// <para>The <a href="https://docs.microsoft.com/windows/desktop/api/fileapi/nf-fileapi-getfileattributesexa">GetFileAttributesEx</a> or <a href="https://docs.microsoft.com/windows/desktop/api/winbase/nf-winbase-getfileattributestransacteda">GetFileAttributesTransacted</a> function retrieves a standard set of attribute information. The data is returned in a <a href="https://docs.microsoft.com/windows/desktop/api/fileapi/ns-fileapi-win32_file_attribute_data">WIN32_FILE_ATTRIBUTE_DATA</a> structure.</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//minwinbase/ne-minwinbase-get_fileex_info_levels#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			GetFileExInfoStandard = 0,
			/// <summary>One greater than the maximum value. Valid values for this enumeration will be less than this value.</summary>
			GetFileExMaxInfoLevel = 1,
		}
	}
}
