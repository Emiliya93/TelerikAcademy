namespace CohesionAndCoupling
{
    /// <summary>
    /// Contains methods for extracting file names or file extension names.
    /// </summary>
    public class FileNameAndExtensionUtils
    {
        /// <summary>
        /// Extract only the extension of a file name.
        /// </summary>
        /// <param name="fileName">The full file name.</param>
        /// <returns>The file extension or empty string if there is no file extension.</returns>
        /// <exception cref="ArgumentOutOfRangeException">If there is invalid file name.</exception>
        public static string GetFileExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return string.Empty;
            }

            string extension = fileName.Substring(indexOfLastDot + 1);
            return extension;
        }

        /// <summary>
        /// Extract only the file name without the extension.
        /// </summary>
        /// <param name="fileName">The full file name.</param>
        /// <returns>The pure file name without the extension.</returns>
        public static string GetFileNameWithoutExtension(string fileName)
        {
            int indexOfLastDot = fileName.LastIndexOf(".");
            if (indexOfLastDot == -1)
            {
                return fileName;
            }

            string extension = fileName.Substring(0, indexOfLastDot);
            return extension;
        }
    }
}
