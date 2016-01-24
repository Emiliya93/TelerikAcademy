using ArtOfTest.WebAii.Core;

namespace QA.UI.TestingFramework.Core.Pages
{
    /// <summary>
    /// Base class for all pages.
    /// </summary>
    /// <typeparam name="S">The specific type of derived page.</typeparam>
    /// <typeparam name="M">The type of the element map.</typeparam>
    public abstract class BasePage<S, M> : BaseInstance<S>
        where S : BasePage<S, M>, new()
        where M : BaseElementMap, new()
    {        
        /// <summary>
        /// Gets the map.
        /// </summary>
        /// <value>
        /// The map.
        /// </value>
        protected M Map
        {
            get
            {
                return new M();
            }
        }

        /// <summary>
        /// Gets the browser.
        /// </summary>
        /// <value>
        /// The browser.
        /// </value>
        protected Browser Browser
        {
            get
            {
                return Manager.Current.ActiveBrowser;
            }
        }

    }
}
