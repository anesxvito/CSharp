
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Reflection

Public Module Extensions_819

	''' <summary>
	'''     A T extension method that gets a field value (Public | NonPublic | Instance | Static)
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <param name="fieldName">Name of the field.</param>
	''' <returns>The field value.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function GetFieldValue(Of T)(this As T, fieldName As String) As Object
		Dim type As Type = this.[GetType]()
		Dim field As FieldInfo = type.GetField(fieldName, BindingFlags.[Public] Or BindingFlags.NonPublic Or BindingFlags.Instance Or BindingFlags.[Static])

		Return field.GetValue(this)
	End Function
End Module


