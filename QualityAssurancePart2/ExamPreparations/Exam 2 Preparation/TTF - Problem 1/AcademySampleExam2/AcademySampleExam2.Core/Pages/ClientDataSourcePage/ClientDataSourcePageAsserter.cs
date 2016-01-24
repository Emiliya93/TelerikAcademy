using ArtOfTest.Common.UnitTesting;

namespace RadGridDemo.Core.Pages.ClientDataSourcePage
{
	public static class ClientDataSourcePageAsserter
	{
		public static void AssertTitle(this ClientDataSourcePage page, string expectedTitle)
		{
			Assert.AreEqual(
				page.Title.GetValue("textContent", string.Empty), expectedTitle);
		}
	}
}
