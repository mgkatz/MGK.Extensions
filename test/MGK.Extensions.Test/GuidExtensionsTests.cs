using NUnit.Framework;
using System;
using System.Linq;

namespace MGK.Extensions.Test
{
	public class GuidExtensionsTests
	{
		[Test]
		public void IsEmpty_WhenGuidEmpty_ShouldReturnTrue()
		{
			var guidValue = Guid.Empty;
			Assert.True(guidValue.IsEmpty());
		}

		[Test]
		public void IsEmpty_WhenGuidNotEmpty_ShouldReturnFalse()
		{
			var guidValue = Guid.NewGuid();
			Assert.False(guidValue.IsEmpty());
		}
	}
}