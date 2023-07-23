using MGK.Extensions.Constants;

namespace MGK.Extensions.Test
{
	public class StringExtensionsTests
	{
		[TestCase("Text for testing")]
		[TestCase(" ")]
		[TestCase("")]
		[TestCase(null)]
		public void AddCRLF_WhenValidString_ShouldReturnStringWithCRLF(string text)
		{
			var textWithCRLF = text.AddCRLF();
			Assert.That(textWithCRLF, Is.Not.EqualTo(text));
			Assert.That(textWithCRLF, Does.EndWith(StringConstants.CRLF));

			if (text.IsNullOrEmpty())
				Assert.That(textWithCRLF, Is.EqualTo(StringConstants.CRLF));
		}

		[TestCase("Text for testing")]
		[TestCase(" ")]
		[TestCase("")]
		[TestCase(null)]
		public void Indent_WhenValidString_ShouldReturnStringWithOneTab(string text)
		{
			var textWithIndent = text.Indent();
			Assert.That(textWithIndent, Is.Not.EqualTo(text));
			Assert.That(textWithIndent, Does.StartWith(StringConstants.Tab));

			if (text.IsNullOrEmpty())
				Assert.That(textWithIndent, Is.EqualTo(StringConstants.Tab));
			else
				Assert.That(textWithIndent, Is.EqualTo(StringConstants.Tab + text));
		}

		[TestCase("Text for testing", 2)]
		[TestCase(" ", 2)]
		[TestCase("", 2)]
		[TestCase(null, 2)]
		[TestCase("Text for testing", 0)]
		[TestCase(" ", 0)]
		[TestCase("", 0)]
		[TestCase(null, 0)]
		public void Indent_WhenValidStringAndManyTabs_ShouldReturnStringWithManyTabsAsStated(string text, byte total)
		{
			var textWithIndents = text.Indent(total);

			if (total == 0)
			{
				Assert.That(textWithIndents, Is.EqualTo(text));
			}
			else
			{
				Assert.That(textWithIndents, Is.Not.EqualTo(text));
				var indents = string.Empty.Indent(total);
				Assert.That(textWithIndents, Does.StartWith(indents));

				if (text.IsNullOrEmpty())
					Assert.That(indents, Is.EqualTo(textWithIndents));
				else
					Assert.That(textWithIndents, Is.EqualTo(indents + text));
			}
		}

		[Test]
		public void IsDate_WhenValidString_ShouldReturnTrue()
		{
			// This gets a date in the current culture
			var date = new DateTime(2000, 1, 1).ToString("d");
			Assert.That(date.IsDate(), Is.True);
		}

		[TestCase("qwerty")]
		[TestCase("123456789")]
		[TestCase("86DCDCF0-1646-4380-BDE0-677059AAC264")]
		[TestCase("")]
		[TestCase(null)]
		public void IsDate_WhenInvalidString_ShouldReturnFalse(string date)
			=> Assert.That(date.IsDate(), Is.False);

		[Test]
		public void IsDecimal_WhenValidString_ShouldReturnTrue()
			=> Assert.That(12.34M.ToString().IsDecimal(), Is.True);

		[TestCase("qwerty")]
		[TestCase("123456789")]
		[TestCase("86DCDCF0-1646-4380-BDE0-677059AAC264")]
		[TestCase("")]
		[TestCase(null)]
		public void IsDecimal_WhenInvalidString_ShouldReturnFalse(string number)
			=> Assert.That(number.IsDecimal(), Is.False);

		[Test]
		public void IsInteger_WhenValidString_ShouldReturnTrue()
			=> Assert.That("1234".IsInteger(), Is.True);

		[TestCase("qwerty")]
		[TestCase("12.34")]
		[TestCase("86DCDCF0-1646-4380-BDE0-677059AAC264")]
		[TestCase("")]
		[TestCase(null)]
		public void IsInteger_WhenInvalidString_ShouldReturnFalse(string number)
			=> Assert.That(number.IsInteger(), Is.False);

		[Test]
		public void ToByteArray_WhenValidString_ShouldReturnByteArray()
		{
            var originalByteArray = new byte[] { 113, 119, 101, 114, 116, 121 };
			const string stringToConvert = "qwerty";
			var convertedByteArray = stringToConvert.ToByteArray();

			Assert.That(convertedByteArray, Is.EqualTo(originalByteArray));
		}

		[TestCase("")]
		[TestCase(null)]
		public void ToByteArray_WhenStringIsNullOrEmpty_ShouldReturnEmptyArray(string stringToConvert)
			=> Assert.That(stringToConvert.ToByteArray(), Is.Empty);

		[TestCase("")]
		[TestCase(null)]
		public void IsNullOrEmpty_WhenStringIsNullOrEmpty_ShouldReturnTrue(string stringToEvaluate)
			=> Assert.That(stringToEvaluate.IsNullOrEmpty(), Is.True);

		[Test]
		public void IsNullOrEmpty_WhenStringIsNotNullNorEmpty_ShouldReturnFalse()
			=> Assert.That("qwerty".IsNullOrEmpty(), Is.False);

		[TestCase("")]
		[TestCase(null)]
		[TestCase("          ")]
		public void IsNullOrEmptyOrWhiteSpace_WhenStringIsNullOrEmptyOrWhiteSpace_ShouldReturnTrue(string stringToEvaluate)
			=> Assert.That(stringToEvaluate.IsNullOrEmptyOrWhiteSpace(), Is.True);

		[Test]
		public void IsNullOrEmptyOrWhiteSpace_WhenStringIsNotNullNorEmptyNorWhiteSpace_ShouldReturnFalse()
			=> Assert.That("qwerty".IsNullOrEmptyOrWhiteSpace(), Is.False);

		[TestCase("Hello {0}!!", null, null, null)]
		[TestCase("Hello {0}!!", "World", null, null)]
		[TestCase("Hello {0}!! This is a {1} day.", "World", "wonderful", null)]
		[TestCase("Hello {0}!! This is a {1} day and here goes the third parameter: {2}", "World", "wonderful", "I don't know what else to put in here!!")]
		public void Format_WhenGivenStringIsValid_ShouldReplaceItems(string originalString, string param1, string param2, string param3)
		{
			string? stringFormatManually;
			string? stringFormatByExtension;

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

			Assert.That(stringFormatByExtension, Is.EqualTo(stringFormatManually));
		}

		[TestCase(null, null, true)]
        [TestCase("", "", true)]
        [TestCase(null, "", true)]
        [TestCase("", null, true)]
        [TestCase("Hello world!!", "Hello world!!", true)]
        [TestCase("Hello world!!", "Hello world!", false)]
        [TestCase("Hello world!!", null, false)]
        [TestCase("Hello world!!", "", false)]
        [TestCase(null, "Hello world!!", false)]
        [TestCase("", "Hello world!!", false)]
        public void IsEqualto_WhenTwoStringsAreGiven_ShouldEvaluateEquality(
			string source,
			string target,
			bool expectedResult)
		{
			bool actualResult = source.IsEqualTo(target);
			Assert.That(actualResult, Is.EqualTo(expectedResult));
		}

        [TestCase(null, null, StringComparison.CurrentCulture, true)]
        [TestCase(null, null, StringComparison.CurrentCultureIgnoreCase, true)]
        [TestCase(null, null, StringComparison.InvariantCulture, true)]
        [TestCase(null, null, StringComparison.InvariantCultureIgnoreCase, true)]
        [TestCase(null, null, StringComparison.Ordinal, true)]
        [TestCase("", "", StringComparison.CurrentCulture, true)]
        [TestCase("", "", StringComparison.CurrentCultureIgnoreCase, true)]
        [TestCase("", "", StringComparison.InvariantCulture, true)]
        [TestCase("", "", StringComparison.InvariantCultureIgnoreCase, true)]
        [TestCase("", "", StringComparison.Ordinal, true)]
        [TestCase(null, "", StringComparison.CurrentCulture, true)]
        [TestCase(null, "", StringComparison.CurrentCultureIgnoreCase, true)]
        [TestCase(null, "", StringComparison.InvariantCulture, true)]
        [TestCase(null, "", StringComparison.InvariantCultureIgnoreCase, true)]
        [TestCase(null, "", StringComparison.Ordinal, true)]
        [TestCase("", null, StringComparison.CurrentCulture, true)]
        [TestCase("", null, StringComparison.CurrentCultureIgnoreCase, true)]
        [TestCase("", null, StringComparison.InvariantCulture, true)]
        [TestCase("", null, StringComparison.InvariantCultureIgnoreCase, true)]
        [TestCase("", null, StringComparison.Ordinal, true)]
        [TestCase("Strasse", "Strasse", StringComparison.CurrentCulture, true)]
        [TestCase("Strasse", "STrasse", StringComparison.CurrentCulture, false)]
        [TestCase("Strasse", "Straße", StringComparison.CurrentCulture, false)]
        [TestCase("Strasse", "Strasse", StringComparison.CurrentCultureIgnoreCase, true)]
        [TestCase("Strasse", "STrasse", StringComparison.CurrentCultureIgnoreCase, true)]
        [TestCase("Strasse", "Straße", StringComparison.CurrentCultureIgnoreCase, false)]
        [TestCase("Strasse", "Strasse", StringComparison.InvariantCulture, true)]
        [TestCase("Strasse", "STrasse", StringComparison.InvariantCulture, false)]
        [TestCase("Strasse", "Straße", StringComparison.InvariantCulture, false)]
        [TestCase("Strasse", "Strasse", StringComparison.InvariantCultureIgnoreCase, true)]
        [TestCase("Strasse", "STrasse", StringComparison.InvariantCultureIgnoreCase, true)]
        [TestCase("Strasse", "Straße", StringComparison.InvariantCultureIgnoreCase, false)]
        [TestCase("Hello world!!", "Hello world!!", StringComparison.Ordinal, true)]
        [TestCase("Hello world!!", "Hello World!!", StringComparison.Ordinal, false)]
        public void IsEqualto_WhenTwoStringsAreGivenWithComparisonType_ShouldEvaluateEquality(
			string source,
			string target,
			StringComparison comparisonType,
			bool expectedResult)
        {
            bool actualResult = source.IsEqualTo(target, comparisonType);
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }
}