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
	namespace Foundation
	{
		/// <summary>The SIZE structure defines the width and height of a rectangle.</summary>
		/// <remarks>
		/// <para>The rectangle dimensions stored in this structure can correspond to viewport extents, window extents, text extents, bitmap dimensions, or the aspect-ratio filter for some extended functions.</para>
		/// <para><see href="https://docs.microsoft.com/windows/win32/api//windef/ns-windef-size#">Read more on docs.microsoft.com</see>.</para>
		/// </remarks>
		[global::System.CodeDom.Compiler.GeneratedCode("Microsoft.Windows.CsWin32", "0.2.104-beta+6d86f35b75")]
		internal partial struct SIZE
		{
			/// <summary>Specifies the rectangle's width. The units depend on which function uses this structure.</summary>
			internal int cx;
			/// <summary>Specifies the rectangle's height. The units depend on which function uses this structure.</summary>
			internal int cy;
			internal SIZE(global::System.Drawing.Size value) : this(value.Width, value.Height) 
			{
			}
			internal SIZE(int width, int height)

			{
				this.cx = width;
				this.cy = height;
			}


			internal readonly int Width => this.cx;

			internal readonly int Height => this.cy;

			internal readonly bool IsEmpty => this.cx == 0 && this.cy == 0;
			public static implicit operator global::System.Drawing.Size(SIZE value) => new global::System.Drawing.Size(value.cx, value.cy);
			public static implicit operator SIZE(global::System.Drawing.Size value) => new SIZE(value);
		}
	}
}