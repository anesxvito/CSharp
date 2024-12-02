
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_262

	''' <summary>
	'''     Returns a value indicating the sign of a 16-bit signed integer.
	''' </summary>
	''' <param name="value">A signed number.</param>
	''' <returns>
	'''     A number that indicates the sign of , as shown in the following table.Return value Meaning -1  is less than
	'''     zero. 0  is equal to zero. 1  is greater than zero.
	''' </returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function Sign(value As Int16) As Int32
		Return Math.Sign(value)
	End Function
End Module


