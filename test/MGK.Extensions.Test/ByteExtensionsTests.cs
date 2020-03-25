using AutoFixture;
using NUnit.Framework;

namespace MGK.Extensions.Test
{
	public class ByteExtensionsTests
	{
		[Test]
		public void ToString_ShouldConvertBytesToString()
		{
			var originalString = "qwerty";
			var bytesToConvert = originalString.ToByteArray();
			var convertedString = bytesToConvert.ToOriginalString();

			Assert.AreEqual(originalString, convertedString);
		}
	}
}