
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library

Public Module Extensions_459

	''' <summary>
	'''     A T extension method that query if '@this' is not null.
	''' </summary>
	''' <typeparam name="T">Generic type parameter.</typeparam>
	''' <param name="this">The @this to act on.</param>
	''' <returns>true if not null, false if not.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IsNotNull(Of T As Class)(this As T) As Boolean
		Return this IsNot Nothing
	End Function
End Module


