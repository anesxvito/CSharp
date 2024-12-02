
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Globalization

Public Module Extensions_152

	''' <summary>
	'''     A DateTime extension method that converts this object to an universal sortable date time string.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <returns>The given data converted to a string.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToUniversalSortableDateTimeString(this As DateTime) As String
		Return this.ToString("u", DateTimeFormatInfo.CurrentInfo)
	End Function

	''' <summary>
	'''     A DateTime extension method that converts this object to an universal sortable date time string.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="culture">The culture.</param>
	''' <returns>The given data converted to a string.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToUniversalSortableDateTimeString(this As DateTime, culture As String) As String
		Return this.ToString("u", New CultureInfo(culture))
	End Function

	''' <summary>
	'''     A DateTime extension method that converts this object to an universal sortable date time string.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="culture">The culture.</param>
	''' <returns>The given data converted to a string.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToUniversalSortableDateTimeString(this As DateTime, culture As CultureInfo) As String
		Return this.ToString("u", culture)
	End Function
End Module


