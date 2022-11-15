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
	namespace UI.HiDpi
	{
		/// <summary>Identifies the dots per inch (dpi) setting for a thread, process, or window.</summary>
		/// <remarks>
		/// <para>In previous versions of Windows, DPI values were only set once for an entire application. For those apps, the <a href="https://docs.microsoft.com/windows/desktop/api/shellscalingapi/ne-shellscalingapi-process_dpi_awareness">PROCESS_DPI_AWARENESS</a> type determined the type of DPI awareness for the entire application. Currently, the DPI awareness is defined on an individual thread, window, or process level and is indicated by the <b>DPI_AWARENESS</b> type. While the focus shifted from a process level to a thread level, the different kinds of DPI awareness are the same: unaware, system aware, and per monitor aware. For detailed descriptions and some examples of the different DPI kinds, see <b>PROCESS_DPI_AWARENESS</b>. The old recommendation was to define the DPI awareness level in the application manifest using the setting <i>dpiAware</i> as explained in <a href="https://docs.microsoft.com/windows/desktop/api/shellscalingapi/ne-shellscalingapi-process_dpi_awareness">PROCESS_DPI_AWARENESS</a>. Now that the DPI awareness is tied to threads and windows instead of an entire application, a new windows setting is added to the app manifest. This setting is <i>dpiAwareness</i> and will override any <i>dpiAware</i> setting if both of them are present in the manifest. While it is still recommended to use the manifest, you can now change the DPI awareness while the app is running by using <a href="https://docs.microsoft.com/windows/desktop/api/winuser/nf-winuser-setthreaddpiawarenesscontext">SetThreadDpiAwarenessContext</a>. It is important to note that if your application has a <b>DPI_AWARENESS_PER_MONITOR_AWARE</b> window, you are responsible for keeping track of the DPI by responding to <a href="https://docs.microsoft.com/windows/desktop/hidpi/wm-dpichanged">WM_DPICHANGED</a> messages.</para>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//windef/ne-windef-dpi_awareness#">Read more on docs.microsoft.com</see>.</para>
		/// </remarks>
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal enum DPI_AWARENESS
		{
			/// <summary>Invalid DPI awareness. This is an invalid DPI awareness value.</summary>
			DPI_AWARENESS_INVALID = -1,
			/// <summary>DPI unaware. This process does not scale for DPI changes and is always assumed to have a scale factor of 100% (96 DPI). It will be automatically scaled by the system on any other DPI setting.</summary>
			DPI_AWARENESS_UNAWARE = 0,
			/// <summary>System DPI aware. This process does not scale for DPI changes. It will query for the DPI once and use that value for the lifetime of the process. If the DPI changes, the process will not adjust to the new DPI value. It will be automatically scaled up or down by the system when the DPI changes from the system value.</summary>
			DPI_AWARENESS_SYSTEM_AWARE = 1,
			/// <summary>Per monitor DPI aware. This process checks for the DPI when it is created and adjusts the scale factor whenever the DPI changes. These processes are not automatically scaled by the system.</summary>
			DPI_AWARENESS_PER_MONITOR_AWARE = 2,
		}
	}
}