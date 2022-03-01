using LR1.Lib;
using System;

namespace LR1.App
{
	class Program
	{
		static void Main()
		{
			PasswordSymbols passwordSymbols = new PasswordSymbols('a', 'z');

			passwordSymbols.AddSymbolCollestion('А', 'Я');

			PasswordGenerator passwordGenerator = new PasswordGenerator();

			for (int passNum = 0; passNum < 20; passNum++)
			{
				Console.WriteLine(passwordGenerator.GeneratePassword(passwordSymbols.SymbolsCoolection, 5));
			}

			Console.ReadLine();
		}
	}
}
