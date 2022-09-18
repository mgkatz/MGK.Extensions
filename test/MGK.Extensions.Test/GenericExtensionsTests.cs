namespace MGK.Extensions.Test
{
	public class GenericExtensionsTests
	{
		[Test]
		public void In_WhenValidNumberValue_ShouldReturnTrue()
		{
			const int valueToFind = 3;
			var listOfValues = new int[] { 1, 2, valueToFind, 4, 5 };

			Assert.Multiple(() =>
			{
				Assert.That(valueToFind.IsIn(listOfValues), Is.True);
				Assert.That(valueToFind.IsIn(listOfValues.ToList()), Is.True);
			});
		}

		[Test]
		public void In_WhenInvalidNumberValue_ShouldReturnTrue()
		{
			const int valueToFind = 10;
			var listOfValues = new int[] { 1, 2, 3, 4, 5 };

			Assert.Multiple(() =>
			{
				Assert.That(valueToFind.IsIn(listOfValues), Is.False);
				Assert.That(valueToFind.IsIn(listOfValues.ToList()), Is.False);
			});
		}

		[Test]
		public void In_WhenValidStringValue_ShouldReturnTrue()
		{
			const string valueToFind = "ghi";
			var listOfValues = new string[] { "abc", "def", valueToFind, "jkl", "mno" };

			Assert.Multiple(() =>
			{
				Assert.That(valueToFind.IsIn(listOfValues), Is.True);
				Assert.That(valueToFind.IsIn(listOfValues.ToList()), Is.True);
			});
		}

		[Test]
		public void In_WhenInvalidStringValue_ShouldReturnTrue()
		{
			const string valueToFind = "xyz";
			var listOfValues = new string[] { "abc", "def", "ghi", "jkl", "mno" };

			Assert.Multiple(() =>
			{
				Assert.That(valueToFind.IsIn(listOfValues), Is.False);
				Assert.That(valueToFind.IsIn(listOfValues.ToList()), Is.False);
			});
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

			Assert.Multiple(() =>
			{
				Assert.That(valueToFind.IsIn(listOfValues), Is.True);
				Assert.That(valueToFind.IsIn(listOfValues.ToList()), Is.True);
			});
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

			Assert.Multiple(() =>
			{
				Assert.That(valueToFind.IsIn(listOfValues), Is.False);
				Assert.That(valueToFind.IsIn(listOfValues.ToList()), Is.False);
			});
		}
	}
}