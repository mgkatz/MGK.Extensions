using NUnit.Framework;
using System;

namespace MGK.Extensions.Test
{
	public class StringExtensionsTests
	{
		[Test]
		public void IsDate_WhenValidString_ShouldReturnTrue()
		{
			// This gets a date in the current culture
			var date = new DateTime(2000, 1, 1).ToString("d");
			Assert.True(date.IsDate());
		}

		[TestCase("qwerty")]
		[TestCase("123456789")]
		[TestCase("86DCDCF0-1646-4380-BDE0-677059AAC264")]
		[TestCase("")]
		[TestCase(null)]
		public void IsDate_WhenInvalidString_ShouldReturnFalse(string date)
			=> Assert.False(date.IsDate());

		[Test]
		public void IsDecimal_WhenValidString_ShouldReturnTrue()
			=> Assert.True(12.34M.ToString().IsDecimal());

		[TestCase("qwerty")]
		[TestCase("123456789")]
		[TestCase("86DCDCF0-1646-4380-BDE0-677059AAC264")]
		[TestCase("")]
		[TestCase(null)]
		public void IsDecimal_WhenInvalidString_ShouldReturnFalse(string number)
			=> Assert.False(number.IsDecimal());

		[Test]
		public void IsInteger_WhenValidString_ShouldReturnTrue()
			=> Assert.True("1234".IsInteger());

		[TestCase("qwerty")]
		[TestCase("12.34")]
		[TestCase("86DCDCF0-1646-4380-BDE0-677059AAC264")]
		[TestCase("")]
		[TestCase(null)]
		public void IsInteger_WhenInvalidString_ShouldReturnFalse(string number)
			=> Assert.False(number.IsInteger());

		[Test]
		public void ToByteArray_WhenValidString_ShouldReturnByteArray()
		{
			var originalByteArray = new byte[] { 113, 119, 101, 114, 116, 121 };
			var stringToConvert = "qwerty";
			var convertedByteArray = stringToConvert.ToByteArray();

			Assert.AreEqual(originalByteArray, convertedByteArray);
		}

		[TestCase("")]
		[TestCase(null)]
		public void ToByteArray_WhenStringIsNullOrEmpty_ShouldReturnEmptyArray(string stringToConvert)
			=> Assert.Zero(stringToConvert.ToByteArray().Length);
	}
}