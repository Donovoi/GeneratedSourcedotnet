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
		/// <summary>Contains information that the GetFileInformationByHandle function retrieves.</summary>
		/// <remarks>
		/// <para>The identifier that is stored in the <b>nFileIndexHigh</b> and <b>nFileIndexLow</b> members is called the file ID. Support for file IDs is file system-specific. File IDs are not guaranteed to be unique over time, because file systems are free to reuse them. In some cases, the file ID for a file can change over time. In the FAT file system, the file ID is generated from the first cluster of the containing directory and the byte offset within the directory of the entry for the file. Some defragmentation products change this byte offset. (Windows in-box defragmentation does not.) Thus, a FAT file ID can change over time. Renaming a file in the FAT file system can also change the file ID, but only if the new file name is longer than the old one. In the NTFS file system, a file keeps the same file ID until it is deleted. You can replace one file with another file without changing the file ID by using the <a href="https://docs.microsoft.com/windows/desktop/api/winbase/nf-winbase-replacefilea">ReplaceFile</a> function. However, the file ID of the replacement file, not the replaced file, is retained as the file ID of the resulting file. Not all file systems can record creation and last access time, and not all file systems record them in the same manner. For example, on a Windows FAT file system, create time has a resolution of 10 milliseconds, write time has a resolution of 2 seconds, and access time has a resolution of 1 day (the access date). On the NTFS file system, access time has a resolution of 1 hour. For more information, see <a href="https://docs.microsoft.com/windows/desktop/SysInfo/file-times">File Times</a>.</para>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//fileapi/ns-fileapi-by_handle_file_information#">Read more on docs.microsoft.com</see>.</para>
		/// </remarks>
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal partial struct BY_HANDLE_FILE_INFORMATION
		{
			/// <summary>
			/// <para>The file attributes. For possible values and their descriptions, see <a href="https://docs.microsoft.com/windows/desktop/FileIO/file-attribute-constants">File Attribute Constants</a>.</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//fileapi/ns-fileapi-by_handle_file_information#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			internal uint dwFileAttributes;
			/// <summary>
			/// <para>A <a href="https://docs.microsoft.com/windows/desktop/api/minwinbase/ns-minwinbase-filetime">FILETIME</a> structure that specifies when a file or directory is created. If the underlying file system does not support creation time, this member is zero (0).</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//fileapi/ns-fileapi-by_handle_file_information#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			internal global::System.Runtime.InteropServices.ComTypes.FILETIME ftCreationTime;
			/// <summary>
			/// <para>A <a href="https://docs.microsoft.com/windows/desktop/api/minwinbase/ns-minwinbase-filetime">FILETIME</a> structure. For a file, the structure specifies the last time that a file is read from or written to. For a directory, the structure specifies when the directory is created. For both files and directories, the specified date is correct, but the time of day is always set to midnight. If the underlying file system does not support the last access time, this member is zero (0).</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//fileapi/ns-fileapi-by_handle_file_information#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			internal global::System.Runtime.InteropServices.ComTypes.FILETIME ftLastAccessTime;
			/// <summary>
			/// <para>A <a href="https://docs.microsoft.com/windows/desktop/api/minwinbase/ns-minwinbase-filetime">FILETIME</a> structure. For a file, the structure specifies the last time that a file is written to. For a directory, the structure specifies when the directory is created. If the underlying file system does not support the last write time, this member is zero (0).</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//fileapi/ns-fileapi-by_handle_file_information#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			internal global::System.Runtime.InteropServices.ComTypes.FILETIME ftLastWriteTime;
			/// <summary>The serial number of the volume that contains a file.</summary>
			internal uint dwVolumeSerialNumber;
			/// <summary>The high-order part of the file size.</summary>
			internal uint nFileSizeHigh;
			/// <summary>The low-order part of the file size.</summary>
			internal uint nFileSizeLow;
			/// <summary>
			/// <para>The number of links to this file. For the FAT file system this member is always 1. For the NTFS file system, it can be more than 1.</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//fileapi/ns-fileapi-by_handle_file_information#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			internal uint nNumberOfLinks;
			/// <summary>
			/// <para>The high-order part of a unique identifier that is associated with a file. For more information, see <b>nFileIndexLow</b>.</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//fileapi/ns-fileapi-by_handle_file_information#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			internal uint nFileIndexHigh;
			/// <summary>
			/// <para>The low-order part of a unique identifier that is associated with a file. The identifier (low and high parts) and the volume serial number uniquely identify a file on a single computer. To determine whether two open handles represent the same file, combine the identifier and the volume serial number for each file and compare them. The ReFS file system, introduced with Windows Server 2012, includes 128-bit file identifiers. To retrieve the 128-bit file identifier use the <a href="https://docs.microsoft.com/windows/desktop/api/winbase/nf-winbase-getfileinformationbyhandleex">GetFileInformationByHandleEx</a> function with <b>FileIdInfo</b> to retrieve the <a href="https://docs.microsoft.com/windows/desktop/api/winbase/ns-winbase-file_id_info">FILE_ID_INFO</a> structure. The 64-bit identifier in this structure is not guaranteed to be unique on ReFS.</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//fileapi/ns-fileapi-by_handle_file_information#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			internal uint nFileIndexLow;
		}
	}
}