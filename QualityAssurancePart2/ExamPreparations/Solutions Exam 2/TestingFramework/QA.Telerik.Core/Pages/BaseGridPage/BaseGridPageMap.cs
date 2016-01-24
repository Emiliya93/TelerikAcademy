using ArtOfTest.WebAii.Controls.HtmlControls;
using QA.Telerik.Core.Enums;
using QA.UI.TestingFramework.Core;

namespace QA.Telerik.Core.Pages.BaseGridPage
{
    public abstract class BaseGridPageMap : BaseElementMap
    {
        public HtmlSpan DemoTitle 
        {
            get
            {
                return this.Find.ByExpression<HtmlSpan>("id=?_DemoName");
            }
        } 
        
        public HtmlDiv PageSizeField
        {
            get
            {
                return this.Find.ByExpression<HtmlDiv>("id=?PageSizeComboBox");
            }
        }

        public HtmlListItem SizeTwenty
        {
            get
            {
                return this.Find.ByExpression<HtmlDiv>("id=?PageSizeComboBox_DropDown").Find.ByContent<HtmlListItem>(((int)Size.Twenty).ToString());
            }
        }

        public HtmlListItem SizeTen
        {
            get
            {
                return this.Find.ByExpression<HtmlDiv>("id=?PageSizeComboBox_DropDown").Find.ByContent<HtmlListItem>(((int)Size.Ten).ToString());
            }
        }

        public HtmlListItem SizeFifty
        {
            get
            {
                return this.Find.ByExpression<HtmlDiv>("id=?PageSizeComboBox_DropDown").Find.ByContent<HtmlListItem>(((int)Size.Fifty).ToString());
            }
        }

        public HtmlInputText PageSelector
        {
            get
            {
                return this.Find.ByExpression<HtmlInputText>("id=?PageSizeComboBox_Input");
            }
        }

        public abstract HtmlTable Grid { get; }
    }
}