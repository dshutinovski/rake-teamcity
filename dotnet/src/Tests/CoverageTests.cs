namespace Tests
{
	using NUnit.Framework;

	[TestFixture]
	public class CoverageTests : AssertionHelper
	{
		[Test]
		public void TestTrue()
		{
			Expect(BooleanToInt(true), Is.EqualTo(1));
		}

		public int BooleanToInt(bool value)
		{
			if (value)
			{
				return 1;
			}
			return 0;
		}
	}
}