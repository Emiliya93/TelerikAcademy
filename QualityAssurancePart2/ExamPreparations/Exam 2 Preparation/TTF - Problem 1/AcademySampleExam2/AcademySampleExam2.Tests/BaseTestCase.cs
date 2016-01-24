using ArtOfTest.WebAii.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace RadGridDemo.Tests
{
	public abstract class BaseTestCase
	{
		private Browser browser;
		private Manager manager;

		protected Browser Browser
		{
			get 
			{ 
				return this.browser; 
			}
		}
		
		[TestInitialize]
		public void TestInit()
		{
			Settings mySettings = new Settings();
			mySettings.Web.DefaultBrowser = BrowserType.InternetExplorer;

			this.manager = new Manager(mySettings);
			this.manager.Start();
			this.manager.LaunchNewBrowser();

			this.browser = Manager.Current.ActiveBrowser;
			this.browser.Window.Maximize();
			this.browser.AutoDomRefresh = true;
			this.browser.AutoWaitUntilReady = true;
			this.browser.CommandTimeOut = 10000;
		}

		[TestCleanup]
		public void TestCleanup()
		{
			this.manager.Dispose();
		}
	}
}
