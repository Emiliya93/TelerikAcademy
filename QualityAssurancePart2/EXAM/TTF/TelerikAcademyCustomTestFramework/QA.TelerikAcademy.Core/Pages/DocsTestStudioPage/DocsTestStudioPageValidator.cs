using ArtOfTest.WebAii.Core;
using QA.TestingFramework.Core.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QA.TelerikAcademy.Core.Pages.DocsTestStudioPage
{
    public class DocsTestStudioPageValidator
    {
        public DocsTestStudioPageMap Map => new DocsTestStudioPageMap();

        public void PageLoaded()
        {
            Manager.Current.ActiveBrowser.WaitForExists(this.Map.DocumentationLabelExpressions);
            this.Map.DocumentationLabel.AssertIsPresent();
        }

        public void BuildInHandlersLoaded()
        {
            this.Map.BuiltInHandlersHeading.AssertTextEquals("Built-In Handlers");
        }
    }
}
