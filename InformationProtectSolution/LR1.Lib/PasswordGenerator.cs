using System;

namespace LR1.Lib
{
	/// <summary>
	/// Generate Password.
	/// </summary>
	public class PasswordGenerator
	{
		private Random randomGenerator = new Random();

		private string GeneratedPassword;

		public string GeneratePassword(string SymbolsCollection, int size)
		{
			for (int symbolIndex = 0; symbolIndex < size; symbolIndex++)
			{
				var symbolPos = randomGenerator.Next(SymbolsCollection.Length);

				GeneratedPassword += SymbolsCollection[symbolPos];
			}

			return GeneratedPassword;
		}
	}
}
