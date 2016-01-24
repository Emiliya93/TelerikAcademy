using ArtOfTest.WebAii.Controls.HtmlControls;
using QA.Telerik.Core.Pages.BaseGridPage;
using System.Linq;

namespace QA.Telerik.Core.Pages.ComboGridPage
{
    public class ComboGridPageMap : BaseGridPageMap
    {
        public HtmlInputText ContactsNameList
        {
            get
            {
                return this.Find.ByExpression<HtmlInputText>("id=?_NamesDDL_Input");
            }
        }

        public HtmlListItem ContactsNameItem
        {
            get
            {
                return this.Find.ByExpression<HtmlDiv>("id=?_NamesDDL_DropDown").
                    Find.AllByTagName<HtmlUnorderedList>("ul").First().
                    Find.ByContent<HtmlListItem>("Regina Murphy");
            }
        }

        public override HtmlTable Grid
        {
            get
            {
                return this.Find.ByExpression<HtmlTable>("id=?_ContentPlaceHolder1_OrdersGrid_ctl00");
            }
        }
    }
}