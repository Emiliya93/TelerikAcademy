using System;
using ArtOfTest.WebAii.Controls;
using ArtOfTest.WebAii.Core;
using ArtOfTest.WebAii.ObjectModel;

namespace RadGridDemo.Core.Pages.IntegrationWithRadGridPage
{
	public partial class IntegrationWithRadGridPage : BasePage
	{
		public IntegrationWithRadGridPage(Browser browser) : base(browser)
		{			
		}

		public void WaitForSavedChanges()
		{
			this.CustomerIdCell.Wait.ForContentNot(FindContentType.TextContent, string.Empty);
		}

		public void AddNewRecord(string companyName, string contactName, string contactTitle)
		{
			this.AddNewRecordButton.Click();
			this.Browser.RefreshDomTree();
			this.CompanyNameInput.Text = companyName;
			this.ContactNameCell.Click();
			this.ContactNameInput.Text = contactName;
			this.ContactTitleCell.Click();
			this.ContactTitleInput.Text = contactTitle;
			this.SaveChangesButton.Click();
			this.WaitForSavedChanges();
		}

		public void WaitForGridLoad()
		{
			this.Browser.RefreshDomTree();
			this.FirstCell.Wait.ForContentNot(FindContentType.TextContent, string.Empty);
			this.Browser.RefreshDomTree();
		}
	}
}
