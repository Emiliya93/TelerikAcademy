using System.Threading;
using ArtOfTest.Common.UnitTesting;
using ArtOfTest.WebAii.Core;
using QA.UI.TestingFramework.Core;
using QA.UI.TestingFramework.Core.Pages;

namespace QA.Telerik.Core.Pages.BaseGridPage
{
    public abstract class BaseGridPageValidator<P, M> : BaseValidator<P, M>
        where P : BaseValidator<P, M>, new()
        where M : BaseGridPageMap, new()
    {
        public void VerifyDemoPageIsCorrect(string demoName)
        {
            Manager.Current.ActiveBrowser.WaitUntilReady();
            Manager.Current.ActiveBrowser.WaitForAjax(10000);
            this.Map.DemoTitle.AssertTextContains(demoName);
        }

        public void VerifyNumberOfRows(int number)
        {
            Manager.Current.ActiveBrowser.WaitUntilReady();
            this.Map.Grid.Wait.ForExists();
            Assert.AreEqual<int>(this.Map.Grid.BodyRows.Count, number);
        }

        public void VerifyContactTitle(string contactTitleExpected, string contactTitleActual)
        {
            Assert.AreEqual(contactTitleExpected, contactTitleActual);
        }
    }
}
