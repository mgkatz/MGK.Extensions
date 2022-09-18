using AutoFixture;

namespace MGK.Extensions.Test
{
	public class EnumerableExtensionsTests
	{
		private IFixture _fixture;

        [SetUp]
        public void Setup()
        {
            _fixture = new Fixture();
        }

        [Test]
		public void IsNullOrEmpty_IfEnumerableIsNullOrEmpty_ShouldReturnTrue()
		{
			var array = Array.Empty<int>();
			var list = new List<int>();
			var dictionary = new Dictionary<int, string>();

			Assert.Multiple(() =>
			{
				Assert.That(array.IsNullOrEmpty(), Is.True);
				Assert.That(list.IsNullOrEmpty(), Is.True);
				Assert.That(dictionary.IsNullOrEmpty(), Is.True);
			});
		}

		[Test]
		public void IsNullOrEmpty_IfEnumerableIsNotNullNorEmpty_ShouldReturnFalse()
		{
			var array = _fixture.CreateMany<int>().ToArray();
			var list = _fixture.CreateMany<int>().ToList();
			var dictionary = _fixture.CreateMany<KeyValuePair<int, string>>().ToDictionary(x => x.Key, x => x.Value);

			Assert.Multiple(() =>
			{
				Assert.That(array.IsNullOrEmpty(), Is.False);
				Assert.That(list.IsNullOrEmpty(), Is.False);
				Assert.That(dictionary.IsNullOrEmpty(), Is.False);
			});
		}
	}
}