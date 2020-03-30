using AutoFixture;
using NUnit.Framework;
using System;
using System.Linq;

namespace MGK.Extensions.Test
{
	public class ArrayExtensionsTests
	{
		private readonly IFixture _fixture;

		public ArrayExtensionsTests()
		{
			_fixture = new Fixture();
		}

		[Test]
		public void RemoveAt_ShouldRemoveItem()
		{
			int itemCount = 10;
			int index = 6;
			string[] arrayForTest = _fixture.CreateMany<string>(itemCount).ToArray();
			string valueToRemove = arrayForTest[index];

			Assert.AreEqual(arrayForTest.Length, itemCount);

			arrayForTest = arrayForTest.RemoveAt(index);

			Assert.AreEqual(arrayForTest.Length, itemCount - 1);
			Assert.False(arrayForTest.Contains(valueToRemove));
		}

		[Test]
		public void RemoveAt_IfIndexNotExists_ShouldThrowOutOfRangeException()
		{
			int itemCount = 10;
			int index = 14;
			string[] arrayForTest = _fixture.CreateMany<string>(itemCount).ToArray();

			Assert.AreEqual(arrayForTest.Length, itemCount);
			Assert.Throws<ArgumentOutOfRangeException>(() => arrayForTest.RemoveAt(index));
		}
	}
}