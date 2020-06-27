using MGK.Extensions.Constants;
using System;
using System.Globalization;
using System.IO;
using System.Text;

namespace MGK.Extensions
{
	public static class StringExtensions
	{
		/// <summary>
		/// Adds a carriage return and a line feed to a given string.
		/// </summary>
		/// <param name="source">The given string.</param>
		/// <returns>The given string with the carriage return and the line feed.</returns>
		public static string AddCRLF(this string source)
			=> (source ?? string.Empty) + StringConstants.CRLF;

		/// <summary>
		/// In a given string, replaces the format item with the string representation of a corresponding object in a specified array.
		/// </summary>
		/// <param name="source">The given string.</param>
		/// <param name="args">An object array that contains zero or more objects to format.</param>
		/// <returns>The given string with the items replaced.</returns>
		public static string Format(this string source, params object[] args)
			=> string.Format(source, args);

		/// <summary>
		/// In a given string adds a tab indentation at the beginning.
		/// </summary>
		/// <param name="source">The given string.</param>
		/// <returns>The given string with the tab indentation at the beginning.</returns>
		public static string Indent(this string source)
			=> Indent(source, 1);

		/// <summary>
		/// In a given string adds a specific number of tabs for indentation at the beginning.
		/// </summary>
		/// <param name="source">The given string.</param>
		/// <param name="total">The total tabs to add for indentation.</param>
		/// <returns>The given string with the number of tabs for indentation at the beginning. If the number of tabs is 0 (zero) it will return the original string.</returns>
		public static string Indent(this string source, byte total)
		{
			if (total == 0)
				return source;

			var indentations = new string(Convert.ToChar(StringConstants.Indentation), total);
			return indentations + (source ?? string.Empty);
		}

		/// <summary>
		/// In a given block adds a tab indentation at the beginning of each line.
		/// </summary>
		/// <param name="source">The given block.</param>
		/// <returns>The given block with the tab indentation at the beginning of each line.</returns>
		public static string IndentBlock(this string source)
			=> IndentBlock(source, 1);

		/// <summary>
		/// In a given block adds a specific number of tabs for indentation at the beginning of each line.
		/// </summary>
		/// <param name="source">The given block.</param>
		/// <param name="total">The total tabs to add for indentation.</param>
		/// <returns>The given block with the number of tabs for indentation at the beginning of each line. If the number of tabs is 0 (zero) it will return the original string.</returns>
		public static string IndentBlock(this string source, byte total)
		{
			if (total == 0)
				return source;

			source = source ?? string.Empty;
			var sb = new StringBuilder();
			var indentations = new string(Convert.ToChar(StringConstants.Indentation), total);
			var lines = source.Split(new string[] { StringConstants.CRLF }, StringSplitOptions.None);

			foreach (var line in lines)
				sb.Append(indentations).AppendLine(line);

			return sb.ToString();
		}

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
