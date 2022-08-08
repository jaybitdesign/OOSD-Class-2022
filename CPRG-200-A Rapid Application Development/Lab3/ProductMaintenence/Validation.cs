using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlTypes;
using System.Text.RegularExpressions;

/**
 *  ProductMaintenance database application & unit tests
 *  Written & Designed by: James Buchanan / Jaybit Design
 *  Created: July 8th, 2022
 */
namespace ProductMaintenence
{
    /// <summary>
    /// Main validation class
    /// </summary>
    public static class Validation
    {

        // WriteColor("This is my [message] with inline [color] changes.", ConsoleColor.Yellow);
        public static void WriteColor(string message, ConsoleColor color)
        {
            var pieces = Regex.Split(message, @"(\[[^\]]*\])");

            for (int i = 0; i < pieces.Length; i++)
            {
                string piece = pieces[i];

                if (piece.StartsWith("[") && piece.EndsWith("]"))
                {
                    Console.ForegroundColor = color;
                    piece = piece.Substring(1, piece.Length - 2);
                }

                Console.Write(piece);
                Console.ResetColor();
            }

            Console.WriteLine();
        }

        /// <summary>
        /// Check if text box text is present
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns></returns>
        public static bool IsPresent(TextBox textBox)
        {
            return !string.IsNullOrEmpty(textBox.Text);
        }

        /// <summary>
        /// Check if list of text boxes contain only legal characters
        /// </summary>
        /// <param name="textBoxList"></param>
        /// <param name="blacklistChars"></param>
        /// <returns></returns>
        public static bool ContainsLegalCharacters(List<TextBox> textBoxList, string blacklistChars)
        {
            // Loop through each text box
            foreach(TextBox textBox in textBoxList)
            {
                // Display results to console
                WriteColor("[" + textBox.Tag + "]", ConsoleColor.Yellow);
                WriteColor("[ContainsValidCharacters:] " + textBox.Text + ": [" + !(textBox.Text.IndexOfAny(blacklistChars.ToCharArray()) >= 0) + "]\n", ConsoleColor.Blue);

                // If the text box is present
                if (IsPresent(textBox))
                {
                    // If the text box contains illegal charcters
                    if(textBox.Text.IndexOfAny(blacklistChars.ToCharArray()) >= 0)
                    {
                        return false;
                    }
                }
                // If the text box is NOT present
                else
                {
                    return false;
                }
            }
            // Default true
            return true;
        }
        
        /// <summary>
        /// Check if text box texts length is within or equal to lower and upper bounds
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="lower"></param>
        /// <param name="upper"></param>
        /// <returns></returns>
        public static bool IsLengthWithinBounds(TextBox textBox, int lower, int upper)
        {
            // Display results to console
            WriteColor("[" + textBox.Tag + "]", ConsoleColor.Yellow);
            WriteColor("[IsLengthWithinBounds:] " + textBox.Text + ": [" + (textBox.Text.Length >= lower && textBox.Text.Length <= upper) + "]\n", ConsoleColor.Blue);

            // If the text box is present
            if (IsPresent(textBox))
            {
                // Get the length of the text box text
                int textBoxLength = textBox.Text.Length;

                // Return true if value is within bounds
                return textBoxLength >= lower && textBoxLength <= upper;

            }
            // Default false
            return false;
        }

        /// <summary>
        /// Check if the text box text is a valid decimal
        /// </summary>
        /// <param name="textBox"></param>
        /// <param name="testPrecision"></param>
        /// <param name="testScale"></param>
        /// <returns></returns>
        public static bool IsValidDecimal(TextBox textBox, int testPrecision = 18, int testScale = 1)
        {
            // If the text box is present
            if (IsPresent(textBox))
            {
                // Try to parse the decimal
                if(decimal.TryParse(textBox.Text, out decimal value))
                {
                    // Create new SQLDecimal object
                    SqlDecimal sqlDecimal = new SqlDecimal(value);

                    // Display results to console
                    WriteColor("[" + textBox.Tag + "]", ConsoleColor.Yellow);
                    WriteColor("[IsValid Decimal:] " + textBox.Text + ": [" + ((int)sqlDecimal.Precision <= testPrecision && (int)sqlDecimal.Scale <= testScale) + "]\n", ConsoleColor.Blue);

                    // return true if the precision and scale match the database
                    return
                        (int)sqlDecimal.Precision <= testPrecision 
                        &&
                        (int)sqlDecimal.Scale <= testScale;
                }
            }
            // Default false
            return false;
        }

        /// <summary>
        /// Check if the text box text is a valid date time
        /// </summary>
        /// <param name="textBox"></param>
        /// <returns></returns>
        public static bool IsValidDateTime(TextBox textBox)
        {
            // Display results to console
            WriteColor("[" + textBox.Tag + "]", ConsoleColor.Yellow);
            WriteColor("[IsValidDateTime:] " + textBox.Text + ": [" + DateTime.TryParse(textBox.Text, out _) + "]\n", ConsoleColor.Blue);

            // If the text box is present
            if (IsPresent(textBox))
            {
                // Return true if the parse succeeds
                return DateTime.TryParse(textBox.Text, out _);
            }
            // Default false
            return false;
        }
    }
}
