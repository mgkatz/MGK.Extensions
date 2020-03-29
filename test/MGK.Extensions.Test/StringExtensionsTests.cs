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

		[TestCase("")]
		[TestCase(null)]
		public void IsNullOrEmpty_WhenStringIsNullOrEmpty_ShouldReturnTrue(string stringToEvaluate)
			=> Assert.True(stringToEvaluate.IsNullOrEmpty());

		[Test]
		public void IsNullOrEmpty_WhenStringIsNotNullNorEmpty_ShouldReturnFalse()
			=> Assert.False("qwerty".IsNullOrEmpty());

		[TestCase("")]
		[TestCase(null)]
		[TestCase("          ")]
		public void IsNullOrEmptyOrWhiteSpace_WhenStringIsNullOrEmptyOrWhiteSpace_ShouldReturnTrue(string stringToEvaluate)
			=> Assert.True(stringToEvaluate.IsNullOrEmptyOrWhiteSpace());

		[Test]
		public void IsNullOrEmptyOrWhiteSpace_WhenStringIsNullOrEmptyOrWhiteSpace_ShouldReturnTrue()
			=> Assert.False("qwerty".IsNullOrEmptyOrWhiteSpace());

		[TestCase("Hello {0}!!", null, null, null)]
		[TestCase("Hello {0}!!", "World", null, null)]
		[TestCase("Hello {0}!! This is a {1} day.", "World", "wonderful", null)]
		[TestCase("Hello {0}!! This is a {1} day and here goes the third parameter: {2}", "World", "wonderful", "I don't know what else to put in here!!")]
		public void Format_WhenGivenStringIsValid_ShouldReplaceItems(string originalString, string param1, string param2, string param3)
		{
			var stringFormatManually = string.Empty;
			var stringFormatByExtension = string.Empty;

			if (param2.IsNullOrEmpty())
			{
				stringFormatManually = string.Format(originalString, param1);
				stringFormatByExtension = originalString.Format(param1);
			}
			else if (param3.IsNullOrEmpty())
			{
				stringFormatManually = string.Format(originalString, param1, param2);
				stringFormatByExtension = originalString.Format(param1, param2);
			}
			else
			{
				stringFormatManually = string.Format(originalString, param1, param2, param3);
				stringFormatByExtension = originalString.Format(param1, param2, param3);
			}

			Assert.AreEqual(stringFormatManually, stringFormatByExtension);
		}
	}
}