using System.Collections.Generic;
using System.Linq;

namespace MGK.Extensions
{
	public static class EnumerableExtensions
	{
		/// <summary>
		/// Indicates if a given enumerable is null or empty.
		/// </summary>
		/// <typeparam name="T">The type of the enumerable.</typeparam>
		/// <param name="source">The given enumerable.</param>
		/// <returns>True if the enumerable is null or empty; otherwise false.</returns>
		public static bool IsNullOrEmpty<T>(this IEnumerable<T> source)
			=> source?.Any() != true;
	}
}
