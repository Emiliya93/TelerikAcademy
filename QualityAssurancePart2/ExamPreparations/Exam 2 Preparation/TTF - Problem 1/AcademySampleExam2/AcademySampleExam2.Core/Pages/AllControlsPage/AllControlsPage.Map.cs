using ArtOfTest.WebAii.Controls.HtmlControls;
using RadGridDemo.Core.Extensions;

namespace RadGridDemo.Core.Pages.AllControlsPage
{
	public partial class AllControlsPage
	{
		public HtmlAnchor ClientDataSourceLink
		{
			get
			{
				return this.Browser.FindElementByExpressionAndWait<HtmlAnchor>("href=~clientdatasource");
			}
		}
	}
}
