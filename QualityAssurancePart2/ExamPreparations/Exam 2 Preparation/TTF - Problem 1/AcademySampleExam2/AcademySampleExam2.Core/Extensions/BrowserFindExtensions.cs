using ArtOfTest.WebAii.Controls.HtmlControls;
using ArtOfTest.WebAii.Core;

namespace RadGridDemo.Core.Extensions
{
	public static class BrowserFindExtensions
	{
		public static TControl FindElementByExpressionAndWait<TControl>(this Browser browser, string expression)
			where TControl : HtmlControl, new()
		{
			HtmlFindExpression hfe = new HtmlFindExpression(expression);
			browser.WaitForAjax(browser.CommandTimeOut);
			browser.RefreshDomTree();
			browser.WaitForElement(hfe, browser.CommandTimeOut, false);
			TControl element = browser.Find.ByExpression<TControl>(hfe);
			element.Wait.ForExists(browser.CommandTimeOut);
			return element;
		}
	}
}	
