using ArtOfTest.WebAii.Controls.HtmlControls;
using QA.Telerik.Core.Enums;
using QA.UI.TestingFramework.Core;
using QA.UI.TestingFramework.Core.Pages.Pages;

namespace QA.Telerik.Core.Pages.BaseGridPage
{
    public abstract class BaseGridPage<P, M, V> : BasePage<P, M, V>
        where P : BaseGridPage<P, M, V>, new()
        where M : BaseGridPageMap, new()
        where V : BaseGridPageValidator<V, M>, new()
    {    
        public void SelectSize(Size size)
        {
            this.Map.PageSelector.ScrollToVisible();
            this.Map.PageSelector.MouseClick();
            this.Browser.RefreshDomTree();

            if (Size.Ten == size)
            {
                this.Map.SizeTen.MouseClick();
            }
            else if (Size.Twenty == size)
            {
                this.Map.SizeTwenty.MouseClick();
            }
            else if (Size.Fifty == size)
            {
                this.Map.SizeFifty.MouseClick();
            }
        }

        public string GetContactTitleByContactName(string productName)
        {
            string xpathExpression = string.Format(@"//td[text()='{0}']/following-sibling::td[2]", productName);
            HtmlTableCell element = this.Browser.Find.ByXPath<HtmlTableCell>(xpathExpression);
            string result = string.Empty;
            if (!string.IsNullOrEmpty(element.InnerText))
            {
                result = element.InnerText;
            }
            return result;
        }
    }
}
