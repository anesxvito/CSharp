
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Text.RegularExpressions

Public Module Extensions_502

	''' <summary>
	'''     A string extension method that query if '@this' is Alpha.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>true if Alpha, false if not.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IsAlpha(this As String) As Boolean
		Return Not Regex.IsMatch(this, "[^a-zA-Z]")
	End Function
End Module


