using AutoFixture;

namespace MGK.Extensions.Test
{
	public class ArrayExtensionsTests
	{
		private IFixture _fixture;

        [SetUp]
        public void Setup()
        {
            _fixture = new Fixture();
        }

        [Test]
		public void RemoveAt_ShouldRemoveItem()
		{
			const int itemCount = 10;
			const int index = 6;
			string[] arrayForTest = _fixture.CreateMany<string>(itemCount).ToArray();
			string valueToRemove = arrayForTest[index];

			Assert.That(arrayForTest, Has.Length.EqualTo(itemCount));

			arrayForTest = arrayForTest.RemoveAt(index);

			Assert.That(arrayForTest, Has.Length.EqualTo(itemCount - 1));
			Assert.That(arrayForTest, Does.Not.Contain(valueToRemove));
		}

		[Test]
		public void RemoveAt_IfIndexNotExists_ShouldThrowOutOfRangeException()
		{
			const int itemCount = 10;
			const int index = 14;
			string[] arrayForTest = _fixture.CreateMany<string>(itemCount).ToArray();

			Assert.That(arrayForTest, Has.Length.EqualTo(itemCount));
			Assert.Throws<ArgumentOutOfRangeException>(() => arrayForTest.RemoveAt(index));
		}
	}
}