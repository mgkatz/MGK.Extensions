using System.IO;

namespace MGK.Extensions
{
	public static class ByteExtensions
	{
		public static string ToString(this byte[] source)
		{
			var result = string.Empty;

			using (MemoryStream ms = new MemoryStream(source))
			{
				using (StreamReader sr = new StreamReader(ms))
				{
					result = sr.ReadToEnd();
				}
			}

			return result;
		}
	}
}
