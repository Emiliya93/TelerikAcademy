using ArtOfTest.WebAii.Core;

namespace RadGridDemo.Core.Pages.ClientDataSourcePage
{
	public partial class ClientDataSourcePage : BasePage
	{
		public ClientDataSourcePage(Browser browser) : base(browser)
		{
		}

		public void ExpandApplicationScenarios()
		{
			this.LeftNav.ExpandNodeByText("Application Scenarios");
		}

		public void ClickIntegrationWithRadGrid()
		{
			this.LeftNav.ClickNodeByText("Integration with RadGrid");
		}
	}
}
