namespace MGK.Extensions.Test
{
    public class ByteExtensionsTests
	{
		[Test]
		public void ToString_ShouldConvertBytesToString()
		{
			const string originalString = "qwerty";
			var bytesToConvert = originalString.ToByteArray();
			var convertedString = bytesToConvert.ToOriginalString();

			Assert.That(convertedString, Is.EqualTo(originalString));
		}
	}
}