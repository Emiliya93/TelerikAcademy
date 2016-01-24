using ArtOfTest.Common.UnitTesting;

namespace RadGridDemo.Core.Pages.IntegrationWithRadGridPage
{
	public static class IntegrationWithRadGridPageAsserter
	{
		public static void AssertTitle(this IntegrationWithRadGridPage page, string expectedTitle)
		{
			Assert.AreEqual(
				page.Title.GetValue("textContent", string.Empty), expectedTitle);
		}
			
		public static void AssertNewRecordValues(
			this IntegrationWithRadGridPage page, 
			string companyName, 
			string contactName, 
			string contactTitle)
		{
			Assert.IsTrue(page.CustomerIdCell.TextContent.Length == 5);
			Assert.AreEqual(companyName, page.CompanyNameText.TextContent);
			Assert.AreEqual(contactName, page.ContactNameText.TextContent);
			Assert.AreEqual(contactTitle, page.ContactTitleText.TextContent);
		}
	}
}
