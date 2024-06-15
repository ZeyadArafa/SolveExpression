using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SolveExpression
{
    public struct FileSaveResult : ISaveResult
    {
        private string filename;

        /// <summary>
        /// constructor for objects of type FileSaveResult
        /// </summary>
        /// <param name="filename">the file name</param>
        public FileSaveResult(string filename)
        {
            this.filename = filename;
        }


        public void AddEntry(string infixExp, string result)
        {
            // store information in file
            Console.WriteLine("stored in file: {0}", filename);
            string[] textLines1 = { "Expression: " + infixExp, "Result: " + result };
            File.WriteAllLines(filename, textLines1);
            Console.WriteLine(File.ReadAllText(filename));
        }
    }
}
