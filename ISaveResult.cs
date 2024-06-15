using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveExpression
{
    public interface ISaveResult
    {

        void AddEntry(string infixExp, string result);
    }
}
