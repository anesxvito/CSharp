
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Imports System.Collections.Generic
Imports System.Data
Imports System.Reflection

Public Module Extensions_669

	''' <summary>
	'''     Enumerates to entities in this collection.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <returns>@this as an IEnumerable&lt;T&gt;</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function ToEntities(Of T As New)(this As DataTable) As IEnumerable(Of T)
		Dim type As Type = GetType(T)
		Dim properties As PropertyInfo() = type.GetProperties(BindingFlags.[Public] Or BindingFlags.Instance)
		Dim fields As FieldInfo() = type.GetFields(BindingFlags.[Public] Or BindingFlags.Instance)

		Dim list = New List(Of T)()

		For Each dr As DataRow In this.Rows
			Dim entity = New T()

			For Each [property] As PropertyInfo In properties
				If this.Columns.Contains([property].Name) Then
					Dim valueType As Type = [property].PropertyType
					[property].SetValue(entity, dr([property].Name).[To](valueType), Nothing)
				End If
			Next

			For Each field As FieldInfo In fields
				If this.Columns.Contains(field.Name) Then
					Dim valueType As Type = field.FieldType
					field.SetValue(entity, dr(field.Name).[To](valueType))
				End If
			Next

			list.Add(entity)
		Next

		Return list
	End Function
End Module


