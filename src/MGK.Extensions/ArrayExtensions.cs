namespace MGK.Extensions;

public static class ArrayExtensions
{
	/// <summary>
	/// Removes an item from an array by its index position.
	/// </summary>
	/// <typeparam name="T">The type of the array.</typeparam>
	/// <param name="source">The array.</param>
	/// <param name="index">The index position of the item in the array.</param>
	/// <returns>The array without the removed item.</returns>
	public static T[] RemoveAt<T>(this T[] source, int index)
	{
		if (index > source.Length)
			throw new ArgumentOutOfRangeException(nameof(index));

		T[] destination = new T[source.Length - 1];

		if (index > 0)
			Array.Copy(source, 0, destination, 0, index);

		if (index < source.Length - 1)
			Array.Copy(source, index + 1, destination, index, source.Length - index - 1);

		return destination;
	}
}
