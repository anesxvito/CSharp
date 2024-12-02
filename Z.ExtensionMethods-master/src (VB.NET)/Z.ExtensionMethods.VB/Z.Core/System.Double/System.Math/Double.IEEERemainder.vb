
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_215

	''' <summary>
	'''     Returns the remainder resulting from the division of a specified number by another specified number.
	''' </summary>
	''' <param name="x">A dividend.</param>
	''' <param name="y">A divisor.</param>
	''' <returns>
	'''     A number equal to  - ( Q), where Q is the quotient of  /  rounded to the nearest integer (if  /  falls
	'''     halfway between two integers, the even integer is returned).If  - ( Q) is zero, the value +0 is returned if
	'''     is positive, or -0 if  is negative.If  = 0,  is returned.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function IEEERemainder(x As [Double], y As [Double]) As [Double]
		Return Math.IEEERemainder(x, y)
	End Function
End Module


