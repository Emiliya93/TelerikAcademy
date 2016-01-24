namespace QA.TelerikAcademy.Core.Facades
{
    using QA.TelerikAcademy.Core.Pages.DocsTestStudioPage;

    public class DocsTestStudioService
    {
        public DocsTestStudioService()
        {
            this.DocsTestStudioPage = new DocsTestStudioPage();
        }
        
        public DocsTestStudioPage DocsTestStudioPage { get; }

        public void NavigateToBuiltInHandlers()
        {
            this.DocsTestStudioPage.Navigate();
            this.DocsTestStudioPage.Validator.PageLoaded();

            this.DocsTestStudioPage.NavigateToBuiltInHandlers();
        }
    }
}
