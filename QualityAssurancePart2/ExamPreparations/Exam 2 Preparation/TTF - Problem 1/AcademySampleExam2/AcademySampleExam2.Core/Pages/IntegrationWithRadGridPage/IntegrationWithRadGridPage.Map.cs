using ArtOfTest.WebAii.Controls.HtmlControls;
using RadGridDemo.Core.Extensions;
using Telerik.WebAii.Controls.Html;

namespace RadGridDemo.Core.Pages.IntegrationWithRadGridPage
{
	public partial class IntegrationWithRadGridPage
	{
		public HtmlControl Title
		{
			get
			{
				return this.Browser.FindElementByExpressionAndWait<HtmlControl>("xpath=//div[@id='main']/h1");
			}
		}

		public HtmlButton AddNewRecordButton
		{
			get
			{
				return this.Browser.FindElementByExpressionAndWait<HtmlButton>("id=?AddNewRecordButton");
			}
		}

		public HtmlButton SaveChangesButton
		{
			get
			{
				return this.Browser.FindElementByExpressionAndWait<HtmlButton>("id=?SaveChangesIcon");
			}
		}

		public RadGrid Grid
		{
			get
			{
				return this.Browser.FindElementByExpressionAndWait<RadGrid>("id=?ContentPlaceholder1_RadGrid1");
			}
		}

		public HtmlInputText CompanyNameInput
		{
			get
			{
				return this.Browser.FindElementByExpressionAndWait<HtmlInputText>("id=?CompanyName_TB_CompanyName");
			}
		}

		public HtmlInputText ContactNameInput
		{
			get
			{
				return this.Browser.FindElementByExpressionAndWait<HtmlInputText>("id=?ContactName_TB_ContactName");
			}
		}

		public HtmlInputText ContactTitleInput
		{
			get
			{
				return this.Browser.FindElementByExpressionAndWait<HtmlInputText>("id=?ContactTitle_TB_ContactTitle");
			}
		}

		public HtmlTableCell FirstCell
		{
			get
			{
				return this.Browser.FindElementByExpressionAndWait<HtmlTableCell>("xpath=//div[@id='grid']/div/table/tbody/tr[1]/td[1]");
			}
		}

		public HtmlTableCell CustomerIdCell
		{
			get
			{
				return this.Grid.MasterTable.BodyRows[0].Cells[0];
			}
		}

		public HtmlTableCell CompanyNameCell
		{
			get
			{
				return this.Grid.MasterTable.BodyRows[0].Cells[1];
			}
		}

		public HtmlTableCell ContactNameCell
		{
			get
			{
				return this.Grid.MasterTable.BodyRows[0].Cells[2];
			}
		}

		public HtmlTableCell ContactTitleCell
		{
			get
			{
				return this.Grid.MasterTable.BodyRows[0].Cells[3];
			}
		}

		public HtmlDiv CompanyNameText
		{
			get
			{
				return this.CompanyNameCell.Find.AllByTagName<HtmlDiv>("div")[0];
			}
		}

		public HtmlDiv ContactNameText
		{
			get
			{
				return this.ContactNameCell.Find.AllByTagName<HtmlDiv>("div")[0];
			}
		}

		public HtmlDiv ContactTitleText
		{
			get
			{
				return this.ContactTitleCell.Find.AllByTagName<HtmlDiv>("div")[0];
			}
		}
	}
}
