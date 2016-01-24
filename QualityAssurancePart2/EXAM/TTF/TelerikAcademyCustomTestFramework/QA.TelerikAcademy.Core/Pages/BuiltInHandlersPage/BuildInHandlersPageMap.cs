using ArtOfTest.WebAii.Controls.HtmlControls;

namespace QA.TelerikAcademy.Core.Pages.BuiltInHandlersPage
{
    public class BuildInHandlersPageMap
    {
        public HtmlAnchor BuiltInHandlers
            => this.GetListOfElement(this.HtmlPopupsAndDialogs).Find.ByExpression<HtmlAnchor>("Built-In Handlers".TextContentContaining());

        public HtmlContainerControl BuiltInHandlersHeading => this.Find.ById<HtmlContainerControl>("built-in-handlers");
    }
}
