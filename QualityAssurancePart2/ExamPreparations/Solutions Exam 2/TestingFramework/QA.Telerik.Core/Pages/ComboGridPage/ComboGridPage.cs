using QA.Telerik.Core.Pages.BaseGridPage;
using System.Threading;

namespace QA.Telerik.Core.Pages.ComboGridPage
{
    public class ComboGridPage : BaseGridPage<ComboGridPage, ComboGridPageMap, ComboGridPageValidator>
    {
        public void SelectContactName()
        {
            Map.ContactsNameList.ScrollToVisible();
            Map.ContactsNameList.MouseClick();
            Map.ContactsNameItem.ScrollToVisible();
            Map.ContactsNameItem.MouseClick();
        }
    }
}
