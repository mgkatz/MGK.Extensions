using NUnit.Framework;
using System;
using System.Linq;

namespace MGK.Extensions.Test
{
	public class GenericExtensionsTests
	{
		[Test]
		public void In_WhenValidNumberValue_ShouldReturnTrue()
		{
			var valueToFind = 3;
			var listOfValues = new int[] { 1, 2, valueToFind, 4, 5 };
			Assert.True(valueToFind.In(listOfValues));
			Assert.True(valueToFind.In(listOfValues.ToList()));
		}

		[Test]
		public void In_WhenInvalidNumberValue_ShouldReturnTrue()
		{
			var valueToFind = 10;
			var listOfValues = new int[] { 1, 2, 3, 4, 5 };
			Assert.False(valueToFind.In(listOfValues));
			Assert.False(valueToFind.In(listOfValues.ToList()));
		}

		[Test]
		public void In_WhenValidStringValue_ShouldReturnTrue()
		{
			var valueToFind = "ghi";
			var listOfValues = new string[] { "abc", "def", valueToFind, "jkl", "mno" };
			Assert.True(valueToFind.In(listOfValues));
			Assert.True(valueToFind.In(listOfValues.ToList()));
		}

		[Test]
		public void In_WhenInvalidStringValue_ShouldReturnTrue()
		{
			var valueToFind = "xyz";
			var listOfValues = new string[] { "abc", "def", "ghi", "jkl", "mno" };
			Assert.False(valueToFind.In(listOfValues));
			Assert.False(valueToFind.In(listOfValues.ToList()));
		}

		[Test]
		public void In_WhenValidDateTimeValue_ShouldReturnTrue()
		{
			var valueToFind = DateTime.Now;
			var listOfValues = new DateTime[]
			{
				DateTime.Now.AddDays(-2),
				DateTime.Now.AddDays(-1),
				valueToFind,
				DateTime.Now.AddDays(1),
				DateTime.Now.AddDays(2)
			};

			Assert.True(valueToFind.In(listOfValues));
			Assert.True(valueToFind.In(listOfValues.ToList()));
		}

		[Test]
		public void In_WhenInvalidDateTimeValue_ShouldReturnTrue()
		{
			var valueToFind = DateTime.Now.AddDays(10);
			var listOfValues = new DateTime[]
			{
				DateTime.Now.AddDays(-2),
				DateTime.Now.AddDays(-1),
				DateTime.Now,
				DateTime.Now.AddDays(1),
				DateTime.Now.AddDays(2)
			};

			Assert.False(valueToFind.In(listOfValues));
			Assert.False(valueToFind.In(listOfValues.ToList()));
		}
	}
}