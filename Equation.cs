using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolveExpression
{
    class Equation
    {

        private int expressionLength;

        //PROPERTY: ExpressionElementsCount to count the number of elements in the espression array
        public int ExpressionLength
        {
            get { return expressionLength; }
            //set { expressionElementsCount = value; }
        }

        //Method: CheckValidity, Check if the mathematical  equation is valid
        public bool CheckValidity(string infix)
        {
            foreach (char c in infix)
            {

                // Check for numeric characters (0-9), a negative sign, or leading or trailing spaces.
                if (!((c >= '0' && c <= '9') || c == '+' || c == '-' || c == '*' || c == '/' || c == '^' || c == '(' || c == ')'))
                    return false;

            }
            return true;
        }
        //Method: CheckBalance, Check the equation's brackets balance
        public bool CheckBalance(string equ)
        {
            //l = strlen(equ);
            Stack exq_stack = new Stack();
            for (int i = 0; i < equ.Length; i++)
            {
                if (equ[i] == '(')
                {
                    exq_stack.Push("(");
                }
                else if (equ[i] == ')')
                {
                    string item;
                    item = exq_stack.Pop();
                    if (item == "#")
                    {
                        return false; //It is unbalanced
                    }
                }
            }//end for
            if (exq_stack.IsEmpty())
            {
                return true; //It balanced
            }
            else
            {
                return false; //It is unbalanced
            }

        }//End CheckBalance Method


        //Method: Split mathematical expression. Parsing...
        public string[] Split(string infix)
        {


            //Split  the equation: Convert the equation from string  to array of string
            string elmementString = "";
            string[] numericArr = new string[100];
            int elmCount = 0;

            foreach (char c in infix)
            {

                // Check for numeric characters (0-9), a negative sign, or leading or trailing spaces.
                if ((c >= '0' && c <= '9'))
                {
                    elmementString = string.Concat(elmementString, c);
                }
                else
                {
                    if (elmementString != "")
                    {
                        numericArr[elmCount] = elmementString;
                        elmCount++;
                    }
                    elmementString = "";
                    numericArr[elmCount] = c.ToString();
                    elmCount++;
                }
            }
            if (elmementString != "")
            {
                numericArr[elmCount] = elmementString;
                elmCount++;
            }

            expressionLength = elmCount; // update the expressionElementsCount proparty 
            return numericArr; //return an array of string
            //End of Splitting ..Parsing

        }
        //Method: convert infix expression to postfix
        public string[] Infix2Postfix(string[] numericArr, int elmCount)
        {
            Stack exq_stack = new Stack();
            string[] postfix = new string[100];
            int postfix_index = 0;

            for (int i = 0; i < elmCount; i++) //Start: Convert infix array, numericArr[], to postfix
            {
                if (numericArr[i] == "*" || numericArr[i] == "/" || numericArr[i] == "(" || numericArr[i] == "^") // check '*', '/' , '(' and '^'
                {
                    exq_stack.Push(numericArr[i]);
                } // end '*', '/' , '(' and '^'

                else if (numericArr[i] == "+" || numericArr[i] == "-") // check '+' and '-'
                {

                    do //Search for '(' and insert it in postfix array if it is exiest
                    {
                        string item;
                        item = exq_stack.Top();
                        if (item == "#")
                            break;
                        if (item != "(")
                        {
                            item = exq_stack.Pop();
                            postfix[postfix_index++] = item;
                        }
                        else
                            break;
                    } while (true); //end search for '('
                    exq_stack.Push(numericArr[i]); //push + or -
                } // end check '+' and '-'

                else if (numericArr[i] == ")") //chech ')"
                {
                    do
                    {
                        string item;
                        item = exq_stack.Pop();
                        if (item == "#")
                        {
                            break;
                        }
                        else
                        {

                            if (item == "(")
                            {
                                break;
                            }
                            else
                            {
                                postfix[postfix_index++] = item;
                            }
                        }

                    } while (true);
                } // end chech ')"
                else
                    postfix[postfix_index++] = numericArr[i]; //Numeric value
            }//end of infix string

            //pop all items from the stack
            do
            {
                string item;
                item = exq_stack.Pop();
                if (item != "#")
                {
                    postfix[postfix_index++] = item;

                }
                else
                {
                    break;
                }

            } while (true);

            return postfix; //return the postfix result as a string
        }//End Infix2Postfix Method



        //Method CalculatePostfix, solve the eqation
        public string CalculatePostfix(string[] equ, int elmNo)
        {

            Stack exq_stack = new Stack();
            double v1, v2, result;
            for (int i = 0; i < elmNo; i++)
            {
                if (equ[i] == "+")
                {
                    v2 = int.Parse(exq_stack.Pop());
                    v1 = int.Parse(exq_stack.Pop());
                    result = v1 + v2;
                    exq_stack.Push(result.ToString());
                }
                else if (equ[i] == "*")
                {
                    v2 = int.Parse(exq_stack.Pop());
                    v1 = int.Parse(exq_stack.Pop());
                    result = v1 * v2;
                    exq_stack.Push(result.ToString());
                }
                else if (equ[i] == "-")
                {
                    v2 = int.Parse(exq_stack.Pop());
                    v1 = int.Parse(exq_stack.Pop());
                    result = v1 - v2;
                    exq_stack.Push(result.ToString());
                }
                else if (equ[i] == "/")
                {
                    v2 = int.Parse(exq_stack.Pop());
                    v1 = int.Parse(exq_stack.Pop());
                    result = v1 / v2;
                    exq_stack.Push(result.ToString());
                }
                else if (equ[i] == "^")
                {
                    v2 = int.Parse(exq_stack.Pop());
                    v1 = int.Parse(exq_stack.Pop());
                    result = Math.Pow(v1, v2);
                    exq_stack.Push(result.ToString());
                }

                else //the is a number
                    exq_stack.Push(equ[i]);

            }//end for

            return exq_stack.Top();

        }//End CalculatePostfix Method

        //Method Save result uses the ISaveResult interface to store data in file or database
        public void SaveResult(ISaveResult sr, string infix, string result)
        {
            sr.AddEntry(infix, result);
        }



    }//End Class Equation

}
