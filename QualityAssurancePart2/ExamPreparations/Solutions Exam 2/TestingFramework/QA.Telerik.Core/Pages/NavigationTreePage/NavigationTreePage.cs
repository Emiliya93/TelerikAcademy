using ArtOfTest.WebAii.Core;
using QA.UI.TestingFramework.Core;
using QA.UI.TestingFramework.Core.Pages;

namespace QA.Telerik.Core.Pages.NavigationTreePage
{
    public class NavigationTreePage : BasePage<NavigationTreePage, NavigationTreePageMap>
    {
        public void NavigateToGrid(string gridControl)
        {
            this.Browser.NavigateTo(@"http://demos.telerik.com/aspnet-ajax/");

            Map.SearchField.MouseClick();
            Manager.Current.ActiveBrowser.Desktop.KeyBoard.TypeText(gridControl, 150, 120);
            Map.ListItem.Wait.ForVisible();
            Map.ListItem.MouseClick();

            this.Browser.WaitUntilReady();
            this.Browser.RefreshDomTree();
        }
    }
}
