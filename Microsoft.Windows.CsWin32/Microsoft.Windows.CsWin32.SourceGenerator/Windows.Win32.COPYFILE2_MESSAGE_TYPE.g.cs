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
		/// <summary>Indicates the type of message passed in the COPYFILE2_MESSAGE structure to the CopyFile2ProgressRoutine callback function.</summary>
		/// <remarks>
		/// <para>To compile an application that uses this enumeration, define the <b>_WIN32_WINNT</b> macro as 0x0601 or later. For more information, see <a href="https://docs.microsoft.com/windows/desktop/WinProg/using-the-windows-headers">Using the Windows Headers</a>.</para>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//winbase/ne-winbase-copyfile2_message_type#">Read more on docs.microsoft.com</see>.</para>
		/// </remarks>
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal enum COPYFILE2_MESSAGE_TYPE
		{
			/// <summary>Not a valid value.</summary>
			COPYFILE2_CALLBACK_NONE = 0,
			/// <summary>Indicates a single chunk of a stream has started to be copied.</summary>
			COPYFILE2_CALLBACK_CHUNK_STARTED = 1,
			/// <summary>Indicates the copy of a single chunk of a stream has completed.</summary>
			COPYFILE2_CALLBACK_CHUNK_FINISHED = 2,
			/// <summary>
			/// <para>Indicates both source and destination handles for a stream have been opened and the  copy of the stream is about to be started.</para>
			/// <para><see href="https://docs.microsoft.com/windows/win32/api//winbase/ne-winbase-copyfile2_message_type#members">Read more on docs.microsoft.com</see>.</para>
			/// </summary>
			COPYFILE2_CALLBACK_STREAM_STARTED = 3,
			/// <summary>Indicates the copy operation for a stream have started to be completed.</summary>
			COPYFILE2_CALLBACK_STREAM_FINISHED = 4,
			/// <summary>May be sent periodically.</summary>
			COPYFILE2_CALLBACK_POLL_CONTINUE = 5,
			/// <summary></summary>
			COPYFILE2_CALLBACK_ERROR = 6,
			/// <summary>An error was encountered during the copy operation.</summary>
			COPYFILE2_CALLBACK_MAX = 7,
		}
	}
}
