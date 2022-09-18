using System.IO;

namespace MGK.Extensions;

public static class ByteExtensions
{
	/// <summary>
	/// Converts an array of bytes to its representation as a string.
	/// </summary>
	/// <param name="source">The array of bytes to convert.</param>
	/// <returns>The string representation of the array of bytes.</returns>
	public static string ToOriginalString(this byte[] source)
	{
		var result = string.Empty;

		using (MemoryStream ms = new(source))
		{
			using StreamReader sr = new(ms);
			result = sr.ReadToEnd();
		}

		return result;
	}
}
