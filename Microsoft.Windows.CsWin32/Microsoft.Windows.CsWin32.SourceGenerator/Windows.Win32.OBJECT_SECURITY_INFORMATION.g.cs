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
	namespace Security
	{
		[Flags]
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal enum OBJECT_SECURITY_INFORMATION : uint
		{
			ATTRIBUTE_SECURITY_INFORMATION = 0x00000020,
			BACKUP_SECURITY_INFORMATION = 0x00010000,
			DACL_SECURITY_INFORMATION = 0x00000004,
			GROUP_SECURITY_INFORMATION = 0x00000002,
			LABEL_SECURITY_INFORMATION = 0x00000010,
			OWNER_SECURITY_INFORMATION = 0x00000001,
			PROTECTED_DACL_SECURITY_INFORMATION = 0x80000000,
			PROTECTED_SACL_SECURITY_INFORMATION = 0x40000000,
			SACL_SECURITY_INFORMATION = 0x00000008,
			SCOPE_SECURITY_INFORMATION = 0x00000040,
			UNPROTECTED_DACL_SECURITY_INFORMATION = 0x20000000,
			UNPROTECTED_SACL_SECURITY_INFORMATION = 0x10000000,
		}
	}
}
