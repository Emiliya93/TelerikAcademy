using ArtOfTest.WebAii.Controls.HtmlControls;
using RadGridDemo.Core.Extensions;
using Telerik.WebAii.Controls.Html;

namespace RadGridDemo.Core.Pages.ClientDataSourcePage
{
	public partial class ClientDataSourcePage
	{
		public HtmlControl Title
		{
			get
			{
				return this.Browser.FindElementByExpressionAndWait<HtmlControl>("xpath=//div[@id='main']/h1");
			}
		}

		public RadTreeView LeftNav
		{
			get
			{
				RadTreeView nav = this.Browser.FindElementByExpressionAndWait<RadTreeView>("id=?LeftNavigation_ControlDemos");
				nav.Wait.ForVisible(this.Browser.CommandTimeOut);
				return nav;
			}
		}
	}
}
