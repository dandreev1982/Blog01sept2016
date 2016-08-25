using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyBlog1sept2016.Classes
{
    public class Utils
    {
        public static string CutText(string text, int maxLength)
        {
            if (text==null)
            {
                return null;
            }
            
            if (text.Length<=maxLength)
            {
                return text;
            }
            var newText = text.Substring(0, maxLength) + "...";
            return newText;
        }
    }
}