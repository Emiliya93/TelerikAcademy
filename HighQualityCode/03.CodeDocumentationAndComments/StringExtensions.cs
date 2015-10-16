namespace Telerik.ILS.Common
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Security.Cryptography;
    using System.Text;
    using System.Text.RegularExpressions;

    /// <summary>
    /// Custom string extensions
    /// </summary>
    public static class StringExtensions
    {
        /// <summary>
        /// A string extension method that converts an input string to a byte array and compute the hash.
        /// </summary>
        /// <param name="input">The string to be transformed to MD5 hash and then to HEX representation.</param>
        /// <returns>A hexadecimal string.</returns>
        public static string ToMd5Hash(this string input)
        {
            var md5Hash = MD5.Create();

            var data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            var builder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                builder.Append(data[i].ToString("x2"));
            }

            return builder.ToString();
        }

        /// <summary>
        /// A string extension method that converts an input string to its boolean representation - True if it's true-like or False if it's not.
        /// </summary>
        /// <remarks>
        /// A true-like values can be: "true", "ok", "yes", "1", "да".
        /// </remarks>
        /// <param name="input">The string to be converted</param>
        /// <returns>Boolean representation of the input string.</returns>
        public static bool ToBoolean(this string input)
        {
            var stringTrueValues = new[] { "true", "ok", "yes", "1", "да" };
            return stringTrueValues.Contains(input.ToLower());
        }

        /// <summary>
        /// A string extension method that converts an input string to short value.
        /// </summary>
        /// <param name="input">The string to be converted.</param>
        /// <returns>The short representation of the given string input (or zero if the string is not a number).</returns>
        public static short ToShort(this string input)
        {
            short shortValue;
            short.TryParse(input, out shortValue);
            return shortValue;
        }

        /// <summary>
        /// A string extension method that converts an input string to integer value.
        /// </summary>
        /// <param name="input">The string to be converted.</param>
        /// <returns>The integer representation of the given string input (or zero if the string is not a number).</returns>
        public static int ToInteger(this string input)
        {
            int integerValue;
            int.TryParse(input, out integerValue);
            return integerValue;
        }

        /// <summary>
        /// A string extension method that converts an input string to long value.
        /// </summary>
        /// <param name="input">The string to be converted.</param>
        /// <returns>The long representation of the given string input (or zero if the string is not a number).</returns>
        public static long ToLong(this string input)
        {
            long longValue;
            long.TryParse(input, out longValue);
            return longValue;
        }

        /// <summary>
        /// A string extension method that converts an input string to DateTime object.
        /// </summary>
        /// <param name="input">The string to be converted.</param>
        /// <returns>The System.DateTime equivalent of the specified string representation of a date and time.</returns>
        public static DateTime ToDateTime(this string input)
        {
            DateTime dateTimeValue;
            DateTime.TryParse(input, out dateTimeValue);
            return dateTimeValue;
        }

        /// <summary>
        /// A string extension method that converts an input string to a string with capitalized first letter.
        /// </summary>
        /// <param name="input">The string to be converted.</param>
        /// <returns>The new converted string with capital first letter.</returns>
        public static string CapitalizeFirstLetter(this string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return input;
            }

            return input.Substring(0, 1).ToUpper(CultureInfo.CurrentCulture) + input.Substring(1, input.Length - 1);
        }

        /// <summary>
        /// A string extension method that finds a string within the specified one, that starts with <see cref="startString"/> and ends with <see cref="endString"/>.
        /// </summary>
        /// <param name="input">The specified string to search in.</param>
        /// <param name="startString">The string that should begin the searched one.</param>
        /// <param name="endString">The string that should end the searched one.</param>
        /// <param name="startFrom">Optional parameter to set starting index of the search.</param>
        /// <returns>The substring from the specified that meets the predefined rules or an empty string otherwise.</returns>
        public static string GetStringBetween(this string input, string startString, string endString, int startFrom = 0)
        {
            input = input.Substring(startFrom);
            startFrom = 0;
            if (!input.Contains(startString) || !input.Contains(endString))
            {
                return string.Empty;
            }

            var startPosition = input.IndexOf(startString, startFrom, StringComparison.Ordinal) + startString.Length;
            if (startPosition == -1)
            {
                return string.Empty;
            }

            var endPosition = input.IndexOf(endString, startPosition, StringComparison.Ordinal);
            if (endPosition == -1)
            {
                return string.Empty;
            }

            return input.Substring(startPosition, endPosition - startPosition);
        }

        /// <summary>
        /// A string extension method that converts the specified string with cyrillic letters to a string with latin representation of them.
        /// </summary>
        /// <param name="input">The string to be converted.</param>
        /// <returns>The converted string with latin letters.</returns>
        /// <exception cref="System.ArgumentNullException">Exception is thrown when the provided string is null or empty.</exception>
        /// <exception cref="System.ArgumentException">Exception is thrown when the provided string is null or empty.</exception>
        public static string ConvertCyrillicToLatinLetters(this string input)
        {
            var bulgarianLetters = new[]
                                       {
                                           "а", "б", "в", "г", "д", "е", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п",
                                           "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ь", "ю", "я"
                                       };
            var latinRepresentationsOfBulgarianLetters = new[]
                                                             {
                                                                 "a", "b", "v", "g", "d", "e", "j", "z", "i", "y", "k",
                                                                 "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "h",
                                                                 "c", "ch", "sh", "sht", "u", "i", "yu", "ya"
                                                             };
            for (var i = 0; i < bulgarianLetters.Length; i++)
            {
                input = input.Replace(bulgarianLetters[i], latinRepresentationsOfBulgarianLetters[i]);
                input = input.Replace(bulgarianLetters[i].ToUpper(), latinRepresentationsOfBulgarianLetters[i].CapitalizeFirstLetter());
            }

            return input;
        }

        /// <summary>
        /// A string extension method that converts the specified string with latin letters to a string with cyrillic representation of them.
        /// </summary>
        /// <param name="input">The string to be converted.</param>
        /// <returns>The converted string with cyrillic letters.</returns>
        /// <exception cref="System.ArgumentNullException">Exception is thrown when the provided string is null or empty.</exception>
        /// <exception cref="System.ArgumentException">Exception is thrown when the provided string is null or empty.</exception>
        public static string ConvertLatinToCyrillicKeyboard(this string input)
        {
            var latinLetters = new[]
                                   {
                                       "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p",
                                       "q", "r", "s", "t", "u", "v", "w", "x", "y", "z"
                                   };

            var bulgarianRepresentationOfLatinKeyboard = new[]
                                                             {
                                                                 "а", "б", "ц", "д", "е", "ф", "г", "х", "и", "й", "к",
                                                                 "л", "м", "н", "о", "п", "я", "р", "с", "т", "у", "ж",
                                                                 "в", "ь", "ъ", "з"
                                                             };

            for (int i = 0; i < latinLetters.Length; i++)
            {
                input = input.Replace(latinLetters[i], bulgarianRepresentationOfLatinKeyboard[i]);
                input = input.Replace(latinLetters[i].ToUpper(), bulgarianRepresentationOfLatinKeyboard[i].ToUpper());
            }

            return input;
        }

        /// <summary>
        /// A string extension method that converts the specified string to valid string with only latin letters.
        /// </summary>
        /// <param name="input">The string to be converted.</param>
        /// <returns>The new string with valid symbols and letters.</returns>
        public static string ToValidUsername(this string input)
        {
            input = input.ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.]+", string.Empty);
        }

        /// <summary>
        /// A string extension method that converts the specified string to valid string for file name.
        /// </summary>
        /// <param name="input">The string to be converted.</param>
        /// <returns>The new converted string.</returns>
        public static string ToValidLatinFileName(this string input)
        {
            input = input.Replace(" ", "-").ConvertCyrillicToLatinLetters();
            return Regex.Replace(input, @"[^a-zA-z0-9_\.\-]+", string.Empty);
        }

        /// <summary>
        /// A string extension method that returns the specified characters count string from the original. 
        /// </summary>
        /// <param name="input">The original string.</param>
        /// <param name="charsCount">Count of characters from the beginning of the specified string to be returned as string.</param>
        /// <returns>The new string extracted from the original with length <see cref="charsCount"/>.</returns>
        public static string GetFirstCharacters(this string input, int charsCount)
        {
            return input.Substring(0, Math.Min(input.Length, charsCount));
        }

        /// <summary>
        /// A string extension method that returns valid file extension of the specified string. If missing returns empty string.
        /// </summary>
        /// <param name="fileName">The string with the file name and file extension.</param>
        /// <returns>The file extension or empty string if extension is not found.</returns>
        public static string GetFileExtension(this string fileName)
        {
            if (string.IsNullOrWhiteSpace(fileName))
            {
                return string.Empty;
            }

            string[] fileParts = fileName.Split(new[] { "." }, StringSplitOptions.None);
            if (fileParts.Count() == 1 || string.IsNullOrEmpty(fileParts.Last()))
            {
                return string.Empty;
            }

            return fileParts.Last().Trim().ToLower();
        }

        /// <summary>
        /// A string extension method that returns the full content type of a file extension.
        /// </summary>
        /// <param name="fileExtension">The file extension to search equivalent content type for.</param>
        /// <returns>The content type of the given file extension or default ("application/octet-stream") if there is not equivalent fount.</returns>
        public static string ToContentType(this string fileExtension)
        {
            var fileExtensionToContentType = new Dictionary<string, string>
                                                 {
                                                     { "jpg", "image/jpeg" },
                                                     { "jpeg", "image/jpeg" },
                                                     { "png", "image/x-png" },
                                                     {
                                                         "docx",
                                                         "application/vnd.openxmlformats-officedocument.wordprocessingml.document"
                                                     },
                                                     { "doc", "application/msword" },
                                                     { "pdf", "application/pdf" },
                                                     { "txt", "text/plain" },
                                                     { "rtf", "application/rtf" }
                                                 };
            if (fileExtensionToContentType.ContainsKey(fileExtension.Trim()))
            {
                return fileExtensionToContentType[fileExtension.Trim()];
            }

            return "application/octet-stream";
        }

        /// <summary>
        /// A string extension method that converts a string into an array of bytes.
        /// </summary>
        /// <param name="input">The string to be converted.</param>
        /// <returns>An array of bytes derived from converting every character 
        /// in the given string to its byte representation.</returns>
        public static byte[] ToByteArray(this string input)
        {
            var bytesArray = new byte[input.Length * sizeof(char)];
            Buffer.BlockCopy(input.ToCharArray(), 0, bytesArray, 0, bytesArray.Length);
            return bytesArray;
        }
    }
}
