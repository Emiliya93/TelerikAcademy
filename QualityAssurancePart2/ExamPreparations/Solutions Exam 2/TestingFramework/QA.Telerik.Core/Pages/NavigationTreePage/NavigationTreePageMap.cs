using ArtOfTest.WebAii.Controls.HtmlControls;
using QA.UI.TestingFramework.Core;
using System.Linq;


namespace QA.Telerik.Core.Pages.NavigationTreePage
{
    public class NavigationTreePageMap : BaseElementMap
    {
        public HtmlInputText SearchField
        {
            get
            {
                this.Browser.WaitForExists(@"DemoSearchControl_SearchBox_Input".IdEndingWith());
                return this.Find.ById<HtmlInputText>("DemoSearchControl_SearchBox_Input");
            }
        }

        public HtmlUnorderedList List
        {
            get
            {
                var uls = this.Find.AllByTagName<HtmlUnorderedList>("ul");
                return uls.Where(ul=> ul.CssClass.Contains("rsbList")).FirstOrDefault();
            }
        }

        public HtmlAnchor ListItem
        {
            get
            {
                this.Browser.WaitForExists(@"//*[@id='form1']/div[1]/div/ul/li[1]/a".Xpath());
                return this.Find.ByXPath<HtmlAnchor>("//*[@id='form1']/div[1]/div/ul/li[1]/a");
            }
        }
    }
}
