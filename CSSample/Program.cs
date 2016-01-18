using FSharp.TV;
using System;

namespace CSSample
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			var candidates = PredictiveText.Autocomplete ("aa", PredictiveText.LoadDict());

			foreach (var candidate in candidates)
				Console.WriteLine (candidate);
		}
	}
}
