
' Copyright (c) 2015 ZZZ Projects. All rights reserved
' Licensed under MIT License (MIT) (https://github.com/zzzprojects/Z.ExtensionMethods)
' Website: http://www.zzzprojects.com/
' Feedback / Feature Requests / Issues : http://zzzprojects.uservoice.com/forums/283927
' All ZZZ Projects products: Entity Framework Extensions / Bulk Operations / Extension Methods /Icon Library


Public Module Extensions_300

	''' <summary>
	'''     An Int64 extension method that factor of.
	''' </summary>
	''' <param name="this">The @this to act on.</param>
	''' <param name="factorNumer">The factor numer.</param>
	''' <returns>true if it succeeds, false if it fails.</returns>
	<System.Runtime.CompilerServices.Extension> _
	Public Function FactorOf(this As Int64, factorNumer As Int64) As Boolean
		Return factorNumer Mod this = 0
	End Function
End Module


