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

	/// <summary>
	/// Represents a Win32 handle that can be closed with <see cref="PInvoke.UnhookWindowsHookEx"/>.
	/// </summary>
	[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
	internal class UnhookWindowsHookExSafeHandle
		:SafeHandle	{
		private static readonly IntPtr INVALID_HANDLE_VALUE = new IntPtr(-1L);
		internal UnhookWindowsHookExSafeHandle():base(INVALID_HANDLE_VALUE, true)
		{
		}
		internal UnhookWindowsHookExSafeHandle(IntPtr preexistingHandle, bool ownsHandle = true):base(INVALID_HANDLE_VALUE, ownsHandle)
		{
			this.SetHandle(preexistingHandle);
		}

		public override bool IsInvalid => this.handle.ToInt64() == -1L || this.handle.ToInt64() == 0L;

		protected override bool ReleaseHandle() => PInvoke.UnhookWindowsHookEx((winmdroot.UI.WindowsAndMessaging.HHOOK)this.handle);
	}
}