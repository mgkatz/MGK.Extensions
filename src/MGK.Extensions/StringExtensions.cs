using MGK.Extensions.Constants;
using MGK.Extensions.Enums;
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
		/// Adds spaces to a given string.
		/// </summary>
		/// <param name="source">The given string.</param>
		/// <returns>The given string with the spaces.</returns>
		public static string AddSpaces(this string source, int total = 1, Position position = Position.Beggining)
		{
			if (total <= 0)
				return source;

			var spaces = new string(Convert.ToChar(StringConstants.Space), total);

			return position == Position.Beggining
				? spaces + (source ?? string.Empty)
				: (source ?? string.Empty) + spaces;
		}

		/// <summary>
		/// In a given string, replaces the format item with the string representation of a corresponding object in a specified array.
		/// </summary>
		/// <param name="source">The given string.</param>
		/// <param name="args">An object array that contains zero or more objects to format.</param>
		/// <returns>The given string with the items replaced.</returns>
		public static string Format(this string source, params object[] args)
			=> string.Format(source, args);

		/// <summary>
		/// In a given string adds a specific number of a given character for indentation at the beginning. The default character is a tab.
		/// </summary>
		/// <param name="source">The given string.</param>
		/// <returns>The given string with the number of a given character for indentation at the beginning. If the number of characters is equal to or less than 0 (zero) it will return the original string.</returns>
		public static string Indent(this string source)
			=> Indent(source, 1, IndentationCharacter.Tab);

		/// <summary>
		/// In a given string adds a specific number of a given character for indentation at the beginning. The default character is a tab.
		/// </summary>
		/// <param name="source">The given string.</param>
		/// <param name="total">The total characters to add for indentation.</param>
		/// <returns>The given string with the number of a given character for indentation at the beginning. If the number of characters is equal to or less than 0 (zero) it will return the original string.</returns>
		public static string Indent(this string source, int total)
			=> Indent(source, total, IndentationCharacter.Tab);

		/// <summary>
		/// In a given string adds a specific number of a given character for indentation at the beginning.
		/// </summary>
		/// <param name="source">The given string.</param>
		/// <param name="total">The total characters to add for indentation.</param>
		/// <param name="indentationCharacter">The given character to add.</param>
		/// <returns>The given string with the number of a given character for indentation at the beginning. If the number of characters is equal to or less than 0 (zero) it will return the original string.</returns>
		public static string Indent(this string source, int total, IndentationCharacter indentationCharacter)
		{
			if (total <= 0)
				return source;

			var indentations = new string(Convert.ToChar(indentationCharacter.GetStringValue()), total);
			return indentations + (source ?? string.Empty);
		}

		/// <summary>
		/// In a given block adds a specific number of a given character for indentation at the beginning of each line. The default character is a tab.
		/// </summary>
		/// <param name="source">The given block.</param>
		/// <returns>The given block with the number of a given character for indentation at the beginning of each line. If the number of the given character is equal to or less than 0 (zero) it will return the original string.</returns>
		public static string IndentBlock(this string source)
			=> IndentBlock(source, 1, IndentationCharacter.Tab);

		/// <summary>
		/// In a given block adds a specific number of a given character for indentation at the beginning of each line. The default character is a tab.
		/// </summary>
		/// <param name="source">The given block.</param>
		/// <param name="total">The total number of the given character to add for indentation.</param>
		/// <returns>The given block with the number of a given character for indentation at the beginning of each line. If the number of the given character is equal to or less than 0 (zero) it will return the original string.</returns>
		public static string IndentBlock(this string source, int total)
			=> IndentBlock(source, total, IndentationCharacter.Tab);

		/// <summary>
		/// In a given block adds a specific number of a given character for indentation at the beginning of each line.
		/// </summary>
		/// <param name="source">The given block.</param>
		/// <param name="total">The total number of the given character to add for indentation.</param>
		/// <param name="indentationCharacter">The given character to use for indentation.</param>
		/// <returns>The given block with the number of a given character for indentation at the beginning of each line. If the number of the given character is equal to or less than 0 (zero) it will return the original string.</returns>
		public static string IndentBlock(this string source, int total, IndentationCharacter indentationCharacter)
		{
			if (total <= 0)
				return source;

			source = source ?? string.Empty;
			var sb = new StringBuilder();
			var indentations = new string(Convert.ToChar(indentationCharacter.GetStringValue()), total);
			var lines = source.Split(new string[] { StringConstants.CRLF }, StringSplitOptions.None);

			foreach (var line in lines)
			{
				if (line.IsNullOrEmpty())
					sb.AppendLine(line);
				else
					sb.Append(indentations).AppendLine(line);
			}

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
