using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace BritTest
{
    public class FileReader
    {
        static Dictionary<string, double> instructionDictionary = new Dictionary<string, double>();
         public static Dictionary<string, double> Readfile(string fileName)
         {
            string filePath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), $@"InputInstructionFiles\{fileName}");
            using (StreamReader file = new StreamReader(filePath))
            {
                string line;
                instructionDictionary.Clear();
                while ((line = file.ReadLine()) != null)
                {
                    instructionDictionary.Add(line.Split(' ')[0], Convert.ToDouble(line.Split(' ')[1]));
                }
                file.Close();
            }
            return instructionDictionary;
         }

    }
}