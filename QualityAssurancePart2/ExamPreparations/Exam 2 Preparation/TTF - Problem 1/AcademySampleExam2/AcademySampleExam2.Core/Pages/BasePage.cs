using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArtOfTest.WebAii.Core;

namespace RadGridDemo.Core.Pages
{
	public abstract class BasePage
	{
		private Browser browser;

		protected Browser Browser
		{
			get 
			{
				return this.browser; 
			}
		}

		public BasePage(Browser browser)
		{
			this.browser = browser;
		}
	}
}
