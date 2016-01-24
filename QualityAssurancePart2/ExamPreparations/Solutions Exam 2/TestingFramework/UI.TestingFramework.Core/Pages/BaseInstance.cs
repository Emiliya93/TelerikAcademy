namespace QA.UI.TestingFramework.Core.Pages
{
    /// <summary>
    /// Base singleton class for all singletons.
    /// </summary>
    /// <typeparam name="S">The singleton type.</typeparam>
    public abstract class BaseInstance<S>
        where S : new()
    {
        private static S instance;

        /// <summary>
        /// Gets the instance of the desired type.
        /// </summary>
        /// <value>
        /// The instance of the desired type.
        /// </value>
        public static S That
        {
            get
            {
                if (instance == null)
                {
                    instance = new S();
                }

                return instance;
            }
        }
    }
}
