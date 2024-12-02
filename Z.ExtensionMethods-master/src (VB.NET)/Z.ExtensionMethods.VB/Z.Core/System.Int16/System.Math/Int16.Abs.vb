
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_259

	''' <summary>
	'''     Returns the absolute value of a 16-bit signed integer.
	''' </summary>
	''' <param name="value">A number that is greater than , but less than or equal to .</param>
	''' <returns>A 16-bit signed integer, x, such that 0 ? x ?.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Abs(value As Int16) As Int16
		Return Math.Abs(value)
	End Function
End Module


