using System.Collections.Generic;
using System.Linq;

namespace MGK.Extensions
{
	public static class GenericExtensions
	{
		/// <summary>
		/// Evaluates if a given value exists into a list of values.
		/// </summary>
		/// <typeparam name="T">The type of the given value.</typeparam>
		/// <param name="source">The given value.</param>
		/// <param name="listOfValues">The list of values where to search.</param>
		/// <returns>True if the value exists in the given list, otherwise returns false.</returns>
		public static bool In<T>(this T source, T[] listOfValues)
			=> listOfValues.Contains(source);

		/// <summary>
		/// Evaluates if a given value exists into a list of values.
		/// </summary>
		/// <typeparam name="T">The type of the given value.</typeparam>
		/// <param name="source">The given value.</param>
		/// <param name="listOfValues">The list of values where to search.</param>
		/// <returns>True if the value exists in the given list, otherwise returns false.</returns>
		public static bool In<T>(this T source, List<T> listOfValues)
			=> listOfValues.Contains(source);

		/// <summary>
		/// Evaluates if a given value exists into a list of values.
		/// </summary>
		/// <typeparam name="T">The type of the given value.</typeparam>
		/// <param name="source">The given value.</param>
		/// <param name="listOfValues">The list of values where to search.</param>
		/// <returns>True if the value exists in the given list, otherwise returns false.</returns>
		public static bool In<T>(this T source, IEnumerable<T> listOfValues)
			=> listOfValues.Contains(source);
	}
}
