using System;
using ArtOfTest.WebAii.Controls.HtmlControls;
using QA.Telerik.Core.Pages.BaseGridPage;
using System.Linq;

namespace QA.Telerik.Core.Pages.AutomaticOperationsPage
{
    public class AutomaticOperationsPageMap : BaseGridPageMap
    {
        public override HtmlTable Grid
        {
            get
            {
                return this.Find.ByExpression<HtmlTable>("id=?ContentPlaceHolder1_RadGrid1_ctl00");
            }
        }
    }
}