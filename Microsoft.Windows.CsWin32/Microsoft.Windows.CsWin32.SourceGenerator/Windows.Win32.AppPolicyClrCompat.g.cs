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
	namespace Storage.Packaging.Appx
	{
		/// <summary>The AppPolicyClrCompat enumeration indicates the application type of a process so that you can determine whether to enable private reflection and/or make managed objects agile.</summary>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//appmodel/ne-appmodel-apppolicyclrcompat">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal enum AppPolicyClrCompat
		{
			/// <summary>Indicates an application type other than the ones indicated by the other enumerated constants. The Common Language Runtime (CLR) should not be called by applications that are not Universal Windows Platform (UWP), Win32, nor Desktop Bridge.</summary>
			AppPolicyClrCompat_Other = 0,
			/// <summary>Indicates a desktop/Win32 application, or an NT service. You can support private reflection on framework types.</summary>
			AppPolicyClrCompat_ClassicDesktop = 1,
			/// <summary>Indicates a Universal Windows Platform (UWP) application. You should disable private reflection on framework types, but you can support IAgileObject.</summary>
			AppPolicyClrCompat_Universal = 2,
			/// <summary>Indicates a Desktop Bridge application. You can support private reflection on framework types, and you can support IAgileObject.</summary>
			AppPolicyClrCompat_PackagedDesktop = 3,
		}
	}
}