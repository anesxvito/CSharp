
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Collections.Generic
Imports System.Linq

Public Module Extensions_29

	''' <summary>
	'''     An IEnumerable&lt;T&gt; extension method that query if '@this' contains any.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="values">A variable-length parameters list containing values.</param>
	''' <returns>true if it succeeds, false if it fails.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ContainsAny(Of T)(this As IEnumerable(Of T), ParamArray values As T()) As Boolean
		Dim list As T() = this.ToArray()
		For Each value As T In values
			If list.Contains(value) Then
				Return True
			End If
		Next

		Return False
	End Function
End Module


