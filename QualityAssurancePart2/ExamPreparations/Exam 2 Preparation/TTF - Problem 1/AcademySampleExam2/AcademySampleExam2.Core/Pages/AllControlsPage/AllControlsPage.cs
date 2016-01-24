using ArtOfTest.WebAii.Core;

namespace RadGridDemo.Core.Pages.AllControlsPage
{
	public partial class AllControlsPage : BasePage
	{
		private string url = "http://demos.telerik.com/aspnet-ajax/";

		public AllControlsPage(Browser browser) : base(browser)
		{
		}

		public void Navigate()
		{
			this.Browser.NavigateTo(this.url);
			this.Browser.WaitUntilReady();
		}

		public void NavigateToClientDataSource()
		{
			this.ClientDataSourceLink.Click();
		}
	}
}
