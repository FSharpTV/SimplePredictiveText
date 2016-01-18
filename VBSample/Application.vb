Imports System
Imports FSharp.TV.PredictiveText

Public Class Application
	Public Shared Sub Main()
		Dim candidates as String() = Autocomplete("aa", LoadDict())

		For each candidate As String in candidates
			Console.WriteLine(candidate)
		Next

	End Sub
End Class

