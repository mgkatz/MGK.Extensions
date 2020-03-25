using System;
using System.Globalization;
using System.IO;

namespace MGK.Extensions
{
	public static class StringExtensions
	{
		/// <summary>
		/// Evaluates if a given string is a date.
		/// </summary>
		/// <param name="source">The given string.</param>
		/// <returns>True if the given string is a date, otherwise false.</returns>
		public static bool IsDate(this string source)
			=> DateTime.TryParse(source, out _);

		/// <summary>
		/// Evaluates if a given string is a decimal number.
		/// </summary>
		/// <param name="source">The given string.</param>
		/// <returns>True if the given string is a decimal number, otherwise false.</returns>
		public static bool IsDecimal(this string source)
			=> decimal.TryParse(source, out _) && source.Contains(CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

		/// <summary>
		/// Evaluates if a given string is an integer.
		/// </summary>
		/// <param name="source">The given string.</param>
		/// <returns>True if the given string is an integer, otherwise false.</returns>

		public static bool IsInteger(this string source)
			=> int.TryParse(source, out _);

		/// <summary>
		/// Converts a given string to an array of bytes.
		/// </summary>
		/// <param name="source">The given string.</param>
		/// <returns>An array of bytes.</returns>
		public static byte[] ToByteArray(this string source)
		{
			byte[] result;

			using (MemoryStream ms = new MemoryStream())
			{
				using (StreamWriter sw = new StreamWriter(ms))
				{
					sw.Write(source);
				}

				result = ms.ToArray();
			}

			return result;
		}
	}
}
