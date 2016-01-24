namespace QA.TelerikAcademy.Admin.Tests.DocsTestStudio
{
    using Core.Facades;

    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TestingFramework.Core.Base;
    [TestClass]
    public class DocsTestStudioLeftTreeTests : BaseTest
    {
        public DocsTestStudioService DocsTestStudioService { get; set; }

        public override void TestInit()
        {
            this.DocsTestStudioService = new DocsTestStudioService();
        }

        [TestMethod]
        public void BuiltInHandlersShouldLoadCorrect()
        {
            this.DocsTestStudioService.NavigateToBuiltInHandlers();

            this.DocsTestStudioService.DocsTestStudioPage.Validator.BuildInHandlersLoaded();

            this.DocsTestStudioService.DocsTestStudioPage.Map.HtmlPopUps.Click();
        }
    }
}
