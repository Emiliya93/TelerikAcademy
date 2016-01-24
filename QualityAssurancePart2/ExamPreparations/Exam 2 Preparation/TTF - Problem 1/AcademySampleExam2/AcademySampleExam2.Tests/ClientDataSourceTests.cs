using Microsoft.VisualStudio.TestTools.UnitTesting;
using RadGridDemo.Core.Pages.AllControlsPage;
using RadGridDemo.Core.Pages.ClientDataSourcePage;
using RadGridDemo.Core.Pages.IntegrationWithRadGridPage;

namespace RadGridDemo.Tests
{
	[TestClass]
	public class ClientDataSourceTests : BaseTestCase
	{
		[TestMethod]
		public void VerifyAddNewRecord()
		{
			string companyName = "Company name";
			string contactName = "Contact name";
			string contactTitle = "Contact title";

			AllControlsPage allControlsPage = new AllControlsPage(this.Browser);
			allControlsPage.Navigate();
			allControlsPage.NavigateToClientDataSource();

			ClientDataSourcePage clientDataSourcePage = new ClientDataSourcePage(this.Browser);
			clientDataSourcePage.AssertTitle("RadClientDataSource - Telerik ASP.NET ClientDataSource");
			clientDataSourcePage.ExpandApplicationScenarios();
			clientDataSourcePage.ClickIntegrationWithRadGrid();

			IntegrationWithRadGridPage integrationWithRadGridPage = new IntegrationWithRadGridPage(this.Browser);
			integrationWithRadGridPage.AssertTitle("ClientDataSource - Integration with RadGrid");
			integrationWithRadGridPage.WaitForGridLoad();
			integrationWithRadGridPage.AddNewRecord(companyName, contactName, contactTitle);
			integrationWithRadGridPage.AssertNewRecordValues(companyName, contactName, contactTitle);
		}
	}
}
