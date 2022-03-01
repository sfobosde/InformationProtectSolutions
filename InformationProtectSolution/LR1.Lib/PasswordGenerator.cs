using System;

namespace LR1.Lib
{
	/// <summary>
	/// Generate Password.
	/// </summary>
	class PasswordGenerator
	{
		private Random randomGenerator = new Random();

		public string GeneratedPassword;

		public PasswordGenerator(string SymbolsCollection, int size)
		{
			for (int symbolIndex = 0; symbolIndex < size; symbolIndex++)
			{
				var symbolPos = randomGenerator.Next(SymbolsCollection.Length);

				GeneratedPassword += SymbolsCollection[symbolPos];
			}
		}
	}
}
