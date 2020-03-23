using System.IO;

namespace MGK.Extensions
{
	public static class StringExtensions
	{
		public static bool IsDecimal(this string source)
			=> decimal.TryParse(source, out var result);

		public static bool IsInteger(this string source)
			=> int.TryParse(source, out var result);

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
