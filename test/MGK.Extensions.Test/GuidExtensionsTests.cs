namespace MGK.Extensions.Test
{
	public class GuidExtensionsTests
	{
		[Test]
		public void IsEmpty_WhenGuidEmpty_ShouldReturnTrue()
		{
			var guidValue = Guid.Empty;
			Assert.That(guidValue.IsEmpty(), Is.True);
		}

		[Test]
		public void IsEmpty_WhenGuidNotEmpty_ShouldReturnFalse()
		{
			var guidValue = Guid.NewGuid();
			Assert.That(guidValue.IsEmpty(), Is.False);
		}
	}
}