using AutoFixture;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace MGK.Extensions.Test
{
	public class EnumerableExtensionsTests
	{
		private readonly IFixture _fixture;

		public EnumerableExtensionsTests()
		{
			_fixture = new Fixture();
		}

		[Test]
		public void IsNullOrEmpty_IfEnumerableIsNullOrEmpty_ShouldReturnTrue()
		{
			var array = new int[0];
			var list = new List<int>();
			var dictionary = new Dictionary<int, string>();

			Assert.True(array.IsNullOrEmpty());
			Assert.True(list.IsNullOrEmpty());
			Assert.True(dictionary.IsNullOrEmpty());
		}

		[Test]
		public void IsNullOrEmpty_IfEnumerableIsNotNullNorEmpty_ShouldReturnFalse()
		{
			var array = _fixture.CreateMany<int>().ToArray();
			var list = _fixture.CreateMany<int>().ToList();
			var dictionary = _fixture.CreateMany<KeyValuePair<int, string>>().ToDictionary(x => x.Key, x => x.Value);

			Assert.False(array.IsNullOrEmpty());
			Assert.False(list.IsNullOrEmpty());
			Assert.False(dictionary.IsNullOrEmpty());
		}
	}
}