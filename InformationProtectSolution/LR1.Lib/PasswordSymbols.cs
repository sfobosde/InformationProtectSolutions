using System;

namespace LR1.Lib
{
	/// <summary>
	/// Generate password symbols.
	/// </summary>
	public class PasswordSymbols
	{
		#region Properties
		/// <summary>
		/// Default = 0.
		/// </summary>
		private int AsciiStart;

		/// <summary>
		/// Default = 256.
		/// </summary>
		private int AsciiStop;

		/// <summary>
		/// Symbols using in password.
		/// </summary>
		public string SymbolsCoolection;
		#endregion

		#region Constructions
		/// <summary>
		/// Generate Alphavet symbols in diapazone.
		/// </summary>
		/// <param name="AsciiStart">Start Ascii code.</param>
		/// <param name="AsciiStop">Stop Ascii code.</param>
		public PasswordSymbols(int AsciiStart, int AsciiStop)
		{
			/// Validate values.
			if (AsciiStart > 255 || AsciiStart < 0 ||
				AsciiStop > 255 && AsciiStop < 0)
			{
				throw new ArgumentException("Коды элементов должны быть в диапазоне 0..255.");
			}

			this.AsciiStart = AsciiStart;
			this.AsciiStop = AsciiStop;

			GenerateAlphavet();
		}

		/// <summary>
		/// If no diapazone.
		/// </summary>
		public PasswordSymbols():this(0, 255)
		{

		}

		/// <summary>
		/// If diapazon selected by char.
		/// </summary>
		/// <param name="AsciiStart">Start symbol.</param>
		/// <param name="AsciiStop">Stop symbol.</param>
		public PasswordSymbols(char AsciiStart, char AsciiStop):
			this((int)AsciiStart, (int)AsciiStop)
		{

		}
		#endregion

		#region Methods

		public void AddSymbolCollestion(string Collcetion)
		{
			SymbolsCoolection += Collcetion;
		}
		public void AddSymbolCollestion(int AsciiStart, int AsciiStop)
		{
			GenerateAlphavet(AsciiStart, AsciiStop);
		}
		public void AddSymbolCollestion(char Start, char Stop)
		{
			GenerateAlphavet((int)Start, (int)Stop);
		}
		/// <summary>
		/// Alphavet Generating.
		/// </summary>
		private void GenerateAlphavet(int AsciiStart, int AsciiStop)
		{
			for (int asciiCode = AsciiStart;
				asciiCode <= AsciiStop;
				asciiCode++)
			{
				SymbolsCoolection += (char)asciiCode;
			}
		}
		private void GenerateAlphavet()
		{
			GenerateAlphavet(AsciiStart, AsciiStop);
		}
		private void GenerateAlphavet(char Start, char Stop)
		{
			GenerateAlphavet((int)Start, (int)Stop);
		}
		#endregion

	}
}
