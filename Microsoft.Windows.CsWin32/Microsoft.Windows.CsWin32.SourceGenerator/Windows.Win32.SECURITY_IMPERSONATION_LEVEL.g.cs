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
	namespace Security
	{
		/// <summary>Contains values that specify security impersonation levels. Security impersonation levels govern the degree to which a server process can act on behalf of a client process.</summary>
		/// <remarks>
		/// <para>Impersonation is the ability of a process to take on the security attributes of another process.</para>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//winnt/ne-winnt-security_impersonation_level#">Read more on docs.microsoft.com</see>.</para>
		/// </remarks>
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal enum SECURITY_IMPERSONATION_LEVEL
		{
			/// <summary>The server process cannot obtain identification information about the client, and it cannot impersonate the client. It is defined with no value given, and thus, by ANSI C rules, defaults to a value of zero.</summary>
			SecurityAnonymous = 0,
			/// <summary>The server process can obtain information about the client, such as security identifiers and <a href="https://docs.microsoft.com/windows/desktop/SecGloss/p-gly">privileges</a>, but it cannot impersonate the client. This is useful for servers that export their own objects, for example, database products that export tables and views. Using the retrieved client-security information, the server can make access-validation decisions without being able to use other services that are using the client's <a href="https://docs.microsoft.com/windows/desktop/SecGloss/s-gly">security context</a>.</summary>
			SecurityIdentification = 1,
			/// <summary>The server process can impersonate the client's security context on its local system. The server cannot impersonate the client on remote systems.</summary>
			SecurityImpersonation = 2,
			/// <summary>The server process can impersonate the client's security context on remote systems.</summary>
			SecurityDelegation = 3,
		}
	}
}
