using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveExpression
{
    public class Stack
    {
        private List<string> stackarray = new List<string>();
        //default constractor
        public Stack()
        {

        }
        public void Push(string x)
        {
            stackarray.Add(x);
        }

        public string Pop()
        {
            if (IsEmpty())
            {
                return "#";
                //throw new Exception("Stack is empty");
            }
            else
            {
                string x;
                x = stackarray[stackarray.Count() - 1];
                stackarray.RemoveAt(stackarray.Count() - 1);
                return x;
            }
        }

        public string Top()
        {
            //if (stackarray.Count() == 0)
            if (IsEmpty())
            {
                return "#";
            }
            else
            {
                string x;
                x = stackarray[stackarray.Count() - 1];
                //stackarray.RemoveAt(stackarray.Count());
                return x;
            }
        }

        public bool IsEmpty()
        {
            if (stackarray.Count() == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public int Count()
        {
            return stackarray.Count();
        }

        public bool Search(string x)
        {
            for (int i = 0; i < Count(); i++)
            {
                if (stackarray[i] == x)
                    return true;
            }
            return false;
        }
    }
}
