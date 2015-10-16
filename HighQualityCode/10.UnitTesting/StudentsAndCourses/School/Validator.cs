namespace School
{
    using System;

    public static class Validator
    {
        /// <summary>
        /// Checks if a string is null or empty and throws exception whitch message starts with the given name.
        /// </summary>
        /// <param name="value">String to be checked.</param>
        /// <param name="name">Name for the exception message.</param>
        /// <exception cref="ArgumentNullException">Name cannot be null or empty./></exception>
        public static void CheckIfNullOrEmpty(string value, string name)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentNullException(name + " cannot be null or empty.");
            }
        }

        /// <summary>
        /// Checks if a number is between predefined range and throws exception if the number is invalid.
        /// </summary>
        /// <param name="id">The number to be checked.</param>
        /// <param name="minIdValue">The minimum value for the number.</param>
        /// <param name="maxIdValue">The maximum value for the number.</param>
        /// <exception cref="System.ArgumentOutOfRangeException">Id must be between 10000 and 99999.</exception>
        public static void CheckIfValidID(int id, int minIdValue, int maxIdValue)
        {
            if (id < minIdValue || id > maxIdValue)
            {
                throw new ArgumentOutOfRangeException(string.Format("Id must be between {0} and {1}", minIdValue, maxIdValue));
            }
        }
    }
}
