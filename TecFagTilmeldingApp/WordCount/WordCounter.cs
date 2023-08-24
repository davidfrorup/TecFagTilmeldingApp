using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TecFagTilmeldingApp.WordCount
{
    internal class WordCounter
    {



        public static int Count(string text)
        {
            
            string targetWord = "type";
            string targetWordPlural = "types";

            
            int count = Regex.Matches(text, @"\b" + targetWord + @"\b", RegexOptions.IgnoreCase).Count;
            int countPlural = Regex.Matches(text, @"\b" + targetWordPlural + @"\b", RegexOptions.IgnoreCase).Count;

            
            int totalCount = count + countPlural;

            return totalCount;
        }







    }
}
