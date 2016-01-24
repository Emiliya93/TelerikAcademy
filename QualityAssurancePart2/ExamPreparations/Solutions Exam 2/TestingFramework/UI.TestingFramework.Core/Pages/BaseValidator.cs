using QA.UI.TestingFramework.Core.Pages;

namespace QA.UI.TestingFramework.Core.Pages
{
    /// <summary>
    /// Base class for all pages.
    /// </summary>
    /// <typeparam name="S">The specific type of derived page.</typeparam>
    /// <typeparam name="M">The type of the element map.</typeparam>
    public abstract class BaseValidator<S, M> : BaseInstance<S>
        where S : BaseValidator<S, M>, new()
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
    }
}
