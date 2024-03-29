﻿namespace MGK.Extensions;

public static class GenericExtensions
{
	/// <summary>
	/// Evaluates if a given value exists into a list of values.
	/// </summary>
	/// <typeparam name="T">The type of the given value.</typeparam>
	/// <param name="source">The given value.</param>
	/// <param name="listOfValues">The list of values where to search.</param>
	/// <returns>True if the value exists in the given list, otherwise returns false.</returns>
	public static bool IsIn<T>(this T source, T[] listOfValues)
		=> listOfValues.Contains(source);

	/// <summary>
	/// Evaluates if a given value exists into a list of values and try to ignore case if applies.
	/// </summary>
	/// <typeparam name="T">The type of the given value.</typeparam>
	/// <param name="source">The given value.</param>
	/// <param name="listOfValues">The list of values where to search.</param>
	/// <param name="ignoreCase">True if want to ignore case, otherwise false.</param>
	/// <returns>True if the value exists in the given list, otherwise returns false.</returns>
	public static bool IsIn<T>(this T source, T[] listOfValues, bool ignoreCase, bool hasToMatchExact = false)
		=> PrivateIsIn(source, listOfValues, ignoreCase, hasToMatchExact);

	/// <summary>
	/// Evaluates if a given value exists into a list of values.
	/// </summary>
	/// <typeparam name="T">The type of the given value.</typeparam>
	/// <param name="source">The given value.</param>
	/// <param name="listOfValues">The list of values where to search.</param>
	/// <returns>True if the value exists in the given list, otherwise returns false.</returns>
	public static bool IsIn<T>(this T source, List<T> listOfValues)
		=> listOfValues.Contains(source);

	/// <summary>
	/// Evaluates if a given value exists into a list of values and try to ignore case if applies.
	/// </summary>
	/// <typeparam name="T">The type of the given value.</typeparam>
	/// <param name="source">The given value.</param>
	/// <param name="listOfValues">The list of values where to search.</param>
	/// <param name="ignoreCase">True if want to ignore case, otherwise false.</param>
	/// <returns>True if the value exists in the given list, otherwise returns false.</returns>
	public static bool IsIn<T>(this T source, List<T> listOfValues, bool ignoreCase, bool hasToMatchExact = false)
		=> PrivateIsIn(source, listOfValues, ignoreCase, hasToMatchExact);

	/// <summary>
	/// Evaluates if a given value exists into a list of values.
	/// </summary>
	/// <typeparam name="T">The type of the given value.</typeparam>
	/// <param name="source">The given value.</param>
	/// <param name="listOfValues">The list of values where to search.</param>
	/// <returns>True if the value exists in the given list, otherwise returns false.</returns>
	public static bool IsIn<T>(this T source, IEnumerable<T> listOfValues)
		=> listOfValues.Contains(source);

	/// <summary>
	/// Evaluates if a given value exists into a list of values and try to ignore case if applies.
	/// </summary>
	/// <typeparam name="T">The type of the given value.</typeparam>
	/// <param name="source">The given value.</param>
	/// <param name="listOfValues">The list of values where to search.</param>
	/// <param name="ignoreCase">True if want to ignore case, otherwise false.</param>
	/// <returns>True if the value exists in the given list, otherwise returns false.</returns>
	public static bool IsIn<T>(this T source, IEnumerable<T> listOfValues, bool ignoreCase, bool hasToMatchExact = false)
		=> PrivateIsIn(source, listOfValues, ignoreCase, hasToMatchExact);

	private static bool PrivateIsIn<T>(T source, IEnumerable<T> listOfValues, bool ignoreCase, bool hasToMatchExact = false)
	{
		if (ignoreCase && source is string stringSource)
		{
			return hasToMatchExact
				? listOfValues.Any(lov => ((lov as string) ?? string.Empty).Equals(stringSource, StringComparison.InvariantCultureIgnoreCase))
				: listOfValues.Any(lov => stringSource.IndexOf((lov as string) ?? string.Empty, StringComparison.InvariantCultureIgnoreCase) > 0);
		}

		return IsIn(source, listOfValues);
	}
}
