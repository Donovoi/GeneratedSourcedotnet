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
	namespace UI.Input.Touch
	{
		[DebuggerDisplay("{Value}")]
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal readonly partial struct HGESTUREINFO
			: IEquatable<HGESTUREINFO>
		{
			internal readonly nint Value;
			internal HGESTUREINFO(nint value) => this.Value = value;
			public static implicit operator nint(HGESTUREINFO value) => value.Value;
			public static explicit operator HGESTUREINFO(nint value) => new HGESTUREINFO(value);
			public static bool operator ==(HGESTUREINFO left, HGESTUREINFO right) => left.Value == right.Value;
			public static bool operator !=(HGESTUREINFO left, HGESTUREINFO right) => !(left == right);

			public bool Equals(HGESTUREINFO other) => this.Value == other.Value;

			public override bool Equals(object obj) => obj is HGESTUREINFO other && this.Equals(other);

			public override int GetHashCode() => this.Value.GetHashCode();
		}
	}
}
