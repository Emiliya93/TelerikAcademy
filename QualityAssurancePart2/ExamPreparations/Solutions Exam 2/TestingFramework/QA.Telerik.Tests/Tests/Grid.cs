using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using QA.Telerik.Core.Enums;
using QA.Telerik.Core.Pages.AutomaticOperationsPage;
using QA.Telerik.Core.Pages.ComboGridPage;
using QA.Telerik.Core.Pages.NavigationTreePage;
using QA.UI.TestingFramework.Core;
using System.Threading;

namespace QA.Telerik.Tests.Tests
{
    [TestClass]
    public class Grid : BaseTest
    {
        public override void TestInit()
        {
            this.Browser.Manager.ActiveBrowser.Window.Maximize();
            this.Browser.AutoWaitUntilReady = true;
        }

        [TestMethod]
        public void ComboGridFiltering()
        {
            NavigationTreePage.That.NavigateToGrid("Grid Filtered by Combo");
            ComboGridPage.That.Validate().VerifyDemoPageIsCorrect("ComboBox - Grid Filtered by Combo");
            ComboGridPage.That.SelectContactName();
            ComboGridPage.That.Validate().VerifyNumberOfRows(3);
        }

        [TestMethod]
        public void ComboGridPaging()
        {
            NavigationTreePage.That.NavigateToGrid("Grid Filtered by Combo");
            ComboGridPage.That.Validate().VerifyDemoPageIsCorrect("ComboBox - Grid Filtered by Combo");
            ComboGridPage.That.SelectSize(Size.Twenty);
            ComboGridPage.That.Validate().VerifyNumberOfRows(20);  
        }

        [TestMethod]
        public void AutomaticOperationsGrigPaging()
        {
            NavigationTreePage.That.NavigateToGrid("automatic operations");
            AutomaticOperationsPage.That.Validate().VerifyDemoPageIsCorrect("Grid - Automatic Operations");
            AutomaticOperationsPage.That.SelectSize(Size.Twenty);
            AutomaticOperationsPage.That.Validate().VerifyNumberOfRows(20);
        }

        [TestMethod]
        public void VerifyContactTitleByContactName()
        {
           NavigationTreePage.That.NavigateToGrid("automatic operations");
           string contactTitle = AutomaticOperationsPage.That.GetContactTitleByContactName("Alexander Feuer");
           AutomaticOperationsPage.That.Validate().VerifyContactTitle("Marketing Assistant", contactTitle);
        }
    }
}