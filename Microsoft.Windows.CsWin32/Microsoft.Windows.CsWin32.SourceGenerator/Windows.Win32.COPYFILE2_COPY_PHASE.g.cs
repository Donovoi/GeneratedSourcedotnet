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
	namespace Storage.FileSystem
	{
		/// <summary>Indicates the phase of a copy at the time of an error.</summary>
		/// <remarks>
		/// <para>To compile an application that uses this enumeration, define the <b>_WIN32_WINNT</b> macro as 0x0601 or later. For more information, see <a href="https://docs.microsoft.com/windows/desktop/WinProg/using-the-windows-headers">Using the Windows Headers</a>.</para>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//winbase/ne-winbase-copyfile2_copy_phase#">Read more on docs.microsoft.com</see>.</para>
		/// </remarks>
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal enum COPYFILE2_COPY_PHASE
		{
			/// <summary>The copy had not yet started processing.</summary>
			COPYFILE2_PHASE_NONE = 0,
			/// <summary>
			/// <para>The source was being prepared including opening a handle to the source. This phase happens once per stream copy operation.</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//winbase/ne-winbase-copyfile2_copy_phase#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			COPYFILE2_PHASE_PREPARE_SOURCE = 1,
			/// <summary>
			/// <para>The destination was being prepared including opening a handle to the destination. This phase happens once per stream copy operation.</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//winbase/ne-winbase-copyfile2_copy_phase#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			COPYFILE2_PHASE_PREPARE_DEST = 2,
			/// <summary>The source file was being read. This phase happens one or more times per stream copy operation.</summary>
			COPYFILE2_PHASE_READ_SOURCE = 3,
			/// <summary>
			/// <para>The destination file was being written. This phase happens one or more times per stream copy operation.</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//winbase/ne-winbase-copyfile2_copy_phase#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			COPYFILE2_PHASE_WRITE_DESTINATION = 4,
			/// <summary>
			/// <para>Both the source and destination were on the same remote server and the copy was being processed remotely. This phase happens once per stream copy operation.</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//winbase/ne-winbase-copyfile2_copy_phase#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			COPYFILE2_PHASE_SERVER_COPY = 5,
			/// <summary>
			/// <para>The copy operation was processing symbolic links and/or reparse points. This phase happens once per file copy operation.</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//winbase/ne-winbase-copyfile2_copy_phase#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			COPYFILE2_PHASE_NAMEGRAFT_COPY = 6,
			/// <summary>One greater than the maximum value. Valid values for this enumeration will be less than this value.</summary>
			COPYFILE2_PHASE_MAX = 7,
		}
	}
}
