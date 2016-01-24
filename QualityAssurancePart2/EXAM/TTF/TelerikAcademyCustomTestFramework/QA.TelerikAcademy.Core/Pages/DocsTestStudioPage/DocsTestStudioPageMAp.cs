namespace QA.TelerikAcademy.Core.Pages.DocsTestStudioPage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using ArtOfTest.WebAii.ObjectModel;
    using System.Collections.ObjectModel;
    using System.Linq;
    using TestingFramework.Core.Base;
    using TestingFramework.Core.Extensions;
    public class DocsTestStudioPageMap : BaseElementMap
    {
        public readonly string[] DocumentationLabelExpressions =
        {
            "tagname=a",
            "Test Studio Documentation".TextContentContaining()
        };
        
        public HtmlAnchor DocumentationLabel => this.Find.ByExpression<HtmlAnchor>(this.DocumentationLabelExpressions);

        public HtmlUnorderedList TreeviewLines
            => this.Find.ByExpression<HtmlUnorderedList>(
                "k-group".ClassContaining(),
                "k-treeview-lines".ClassEndingWith(),
                "role=group");
        
        public HtmlSpan TestingFramework => this.TreeviewLines.Find.ByExpression<HtmlSpan>("k-in".ClassEqualTo(), "Testing Framework".TextContentContaining());
        
        public HtmlSpan WriteTestsInCode 
            => this.GetListOfElement(this.TestingFramework).Find.ByExpression<HtmlSpan>("k-in".ClassEqualTo(), "Write Tests in Code".TextContentContaining());
        
        public HtmlSpan AdvancedTopics 
            => this.GetListOfElement(this.WriteTestsInCode).Find.ByExpression<HtmlSpan>("k-in".ClassEqualTo(), "Advanced Topics".TextContentContaining());

        public HtmlSpan HtmlPopupsAndDialogs
            => this.GetListOfElement(this.AdvancedTopics).Find.ByExpression<HtmlSpan>("k-in".ClassEqualTo(), "HTML Popups and Dialogs".TextContentContaining());


        public HtmlAnchor HtmlPopUps => this.Find.ByExpression<HtmlAnchor>("tagname=a", "HTML Pop-ups".TextContentContaining());

        public HtmlUnorderedList GetListOfElement(HtmlControl element)
        {
            HtmlListItem elementParentListItem = element.Parent<HtmlListItem>();

            ReadOnlyCollection<HtmlUnorderedList> elementParentListItemChildNodes = elementParentListItem.Find.AllByTagName<HtmlUnorderedList>("ul");

            HtmlUnorderedList elementList = elementParentListItemChildNodes.FirstOrDefault();

            return elementList;
        }
    }
}
