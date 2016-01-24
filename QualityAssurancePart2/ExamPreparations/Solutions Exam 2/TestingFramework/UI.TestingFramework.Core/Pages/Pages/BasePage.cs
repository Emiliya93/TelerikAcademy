namespace QA.UI.TestingFramework.Core.Pages.Pages
{
    /// <summary>
    /// Base class for all pages.
    /// </summary>
    /// <typeparam name="S">The specific type of derived page.</typeparam>
    /// <typeparam name="M">The type of the element map.</typeparam>
    /// <typeparam name="V">The type of the validator.</typeparam>
    public abstract class BasePage<S, M, V> : QA.UI.TestingFramework.Core.Pages.BasePage<S, M>
        where S : BasePage<S, M, V>, new()
        where M : BaseElementMap, new()
        where V : BaseValidator<V, M>, new()
    {
        /// <summary>
        /// Validates this instance.
        /// </summary>
        /// <returns>
        /// The validator.
        /// </returns>
        public V Validate()
        {
            return new V();
        }
    }
}
