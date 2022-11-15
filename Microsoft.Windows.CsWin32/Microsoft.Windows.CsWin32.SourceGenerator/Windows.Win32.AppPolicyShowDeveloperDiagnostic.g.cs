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
		/// <summary>The AppPolicyShowDeveloperDiagnostic enumeration indicates the method used for a process to surface developer information, such as asserts, to the user.</summary>
		/// <remarks>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//appmodel/ne-appmodel-apppolicyshowdeveloperdiagnostic">Learn more about this API from docs.microsoft.com</see>.</para>
		/// </remarks>
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal enum AppPolicyShowDeveloperDiagnostic
		{
			/// <summary>Indicates that the process does not show developer diagnostics. This value is expected for a UWP app.</summary>
			AppPolicyShowDeveloperDiagnostic_None = 0,
			/// <summary>Indicates that the process shows developer diagnostics UI. This value is expected for a desktop application, or for a Desktop Bridge application.</summary>
			AppPolicyShowDeveloperDiagnostic_ShowUI = 1,
		}
	}
}
