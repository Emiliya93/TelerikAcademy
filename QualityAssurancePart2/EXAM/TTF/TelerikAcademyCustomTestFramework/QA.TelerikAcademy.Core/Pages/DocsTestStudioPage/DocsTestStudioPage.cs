using ArtOfTest.WebAii.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA.TelerikAcademy.Core.Pages.DocsTestStudioPage
{
    public class DocsTestStudioPage
    {
        public const string Url = @"http://docs.telerik.com/teststudio/";

        public DocsTestStudioPageMap Map => new DocsTestStudioPageMap();

        public DocsTestStudioPageValidator Validator => new DocsTestStudioPageValidator();

        public void Navigate()
        {
            Manager.Current.ActiveBrowser.NavigateTo(Url);
        }

        public void NavigateToBuiltInHandlers()
        {
            this.Map.TestingFramework.Click();
            
            //TODO: Wait for WriteTestsInCode to appear
            this.Map.WriteTestsInCode.Click();

            var adt = this.Map.AdvancedTopics;
            this.Map.AdvancedTopics.Click();

            var html = this.Map.HtmlPopupsAndDialogs;
            this.Map.HtmlPopupsAndDialogs.Click();

            var bih = this.Map.BuiltInHandlers;
            this.Map.BuiltInHandlers.Click();

        }
    }
}
