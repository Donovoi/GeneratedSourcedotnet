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
	namespace System.DataExchange
	{
		[Flags]
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal enum DDE_INITIALIZE_COMMAND : uint
		{
			APPCLASS_MONITOR = 0x00000001,
			APPCLASS_STANDARD = 0x00000000,
			APPCMD_CLIENTONLY = 0x00000010,
			APPCMD_FILTERINITS = 0x00000020,
			CBF_FAIL_ALLSVRXACTIONS = 0x0003F000,
			CBF_FAIL_ADVISES = 0x00004000,
			CBF_FAIL_CONNECTIONS = 0x00002000,
			CBF_FAIL_EXECUTES = 0x00008000,
			CBF_FAIL_POKES = 0x00010000,
			CBF_FAIL_REQUESTS = 0x00020000,
			CBF_FAIL_SELFCONNECTIONS = 0x00001000,
			CBF_SKIP_ALLNOTIFICATIONS = 0x003C0000,
			CBF_SKIP_CONNECT_CONFIRMS = 0x00040000,
			CBF_SKIP_DISCONNECTS = 0x00200000,
			CBF_SKIP_REGISTRATIONS = 0x00080000,
			CBF_SKIP_UNREGISTRATIONS = 0x00100000,
			MF_CALLBACKS = 0x08000000,
			MF_CONV = 0x40000000,
			MF_ERRORS = 0x10000000,
			MF_HSZ_INFO = 0x01000000,
			MF_LINKS = 0x20000000,
			MF_POSTMSGS = 0x04000000,
			MF_SENDMSGS = 0x02000000,
		}
	}
}
