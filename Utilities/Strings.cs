using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utilities
{
    /// <summary>
    /// Author: Dean M. Bortell
    /// This class extends some of the .Net string functionality
    /// </summary>
    public static class Strings
    {
        /// <summary>
        /// This function takes a generic list of strings and returns them as one string with endlines in between entities.
        /// </summary>
        /// <param name="st"></param>
        /// <returns></returns>
        public static string ConvertListStringToString(List<string> st)
        {
            StringBuilder sb = new StringBuilder();
            foreach (string s in st)
                sb.AppendLine(s);
            return sb.ToString();
        }
    }
}
