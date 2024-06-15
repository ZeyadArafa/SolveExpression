using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveExpression
{
    public class DatabaseSaveResult : ISaveResult
    {
        private string database;

        /// <summary>
        /// constructor for objects of type DatabaseSaveResult
        /// </summary>
        /// <param name="database">the database name</param>
        public DatabaseSaveResult(string database)
        {
            this.database = database;
        }


        public void AddEntry(string infixExp, string result)
        {
            // store information in database - incomplete
            Console.WriteLine("stored in database: {0}", database);
            Console.WriteLine("Expression: {0}", infixExp);
            Console.WriteLine("Result: {0}", result);
        }
    }
}
