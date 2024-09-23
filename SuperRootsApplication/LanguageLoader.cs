using System;
using System.Collections.Generic;
using System.IO;

namespace SuperRootsApplication
{
    internal class LanguageLoader
    {
        static public List<string> SetTranslation(string file)
        {
            StreamReader f = File.OpenText(file);
            List<string> result = new List<string>();
            while (!f.EndOfStream) 
            { 
                result.Add(f.ReadLine());
            }
            return result;
        }        
    }
}
