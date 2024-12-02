
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Text

Public Module Extensions_601

	''' <summary>
	'''     A string extension method that extracts the UInt32 from the string.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>The extracted UInt32.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ExtractUInt32(this As String) As UInteger
		Dim sb = New StringBuilder()
		For i As Integer = 0 To this.Length - 1
			If [Char].IsDigit(this(i)) Then
				sb.Append(this(i))
			End If
		Next

		Return Convert.ToUInt32(sb.ToString())
	End Function
End Module


