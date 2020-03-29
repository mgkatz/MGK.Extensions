using System;
using System.Globalization;
using System.IO;

namespace MGK.Extensions
{
	public static class StringExtensions
	{
		/// <summary>
		/// In a given string, replaces the format item with the string representation of a corresponding object in a specified array.
		/// </summary>
		/// <param name="source">The given string.</param>
		/// <param name="args">An object array that contains zero or more objects to format.</param>
		/// <returns>The given string with the items replaced.</returns>
		public static string Format(this string source, params object[] args)
			=> string.Format(source, args);

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
		/// Indicates whether the given string is null or empty.
		/// </summary>
		/// <param name="source">The given string.</param>
		/// <returns>True if the given string is null or empty; otherwise false.</returns>
		public static bool IsNullOrEmpty(this string source)
			=> string.IsNullOrEmpty(source);

		/// <summary>
		/// Indicates whether the given string is null, empty or consists only of white spaces.
		/// </summary>
		/// <param name="source">The given string.</param>
		/// <returns>True if the given string is null, empty or only white spaces; otherwise false.</returns>
		public static bool IsNullOrEmptyOrWhiteSpace(this string source)
			=> string.IsNullOrWhiteSpace(source);

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
