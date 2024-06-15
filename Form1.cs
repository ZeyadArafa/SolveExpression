using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolveExpression
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void butCheckValidity_Click(object sender, EventArgs e)
        {
            string infix;
            
            bool validity;
            
            if (textExpression.Text == "")
            {
                labValidityOuput.Text = "Please enter an expression";
                return;
            }
            Equation eq = new Equation();
            infix = textExpression.Text;
            labValidityOuput.Text = infix + "\n" + infix;
            validity = eq.CheckValidity(infix);
            if (validity)
                labValidityOuput.Text = "THE EXPRESSION IS VALID";
            else
                labValidityOuput.Text = "THE EXPRESSION IS NOT VALID";

        }

        private void butCheckBalance_Click(object sender, EventArgs e)
        {
            string infix;
           
            bool validity;
            bool balanced;
            
            Equation eq = new Equation();
            infix = textExpression.Text;
            //labValidityOuput.Text = infix + "\n" + infix;
            if(textExpression.Text=="")
            {
                labValidityOuput.Text = "Please enter an expression";
                return;
            }
            validity = eq.CheckValidity(infix);
            if (validity)
            {
                labValidityOuput.Text = "THE EXPRESSION IS VALID";
                balanced = eq.CheckBalance(infix);
                if (balanced)
                    labValidityOuput.Text = "It is a balanced equation";
                else
                    labValidityOuput.Text = "It is a NOT balanced equation";
            }
                
            else
                labValidityOuput.Text = "THE EXPRESSION IS NOT VALID";
        }

        private void butSplitExpression_Click(object sender, EventArgs e)
        {
            string infix;
            string[] infixArr;
            int infixArrElements;
            
            bool validity;
            bool balanced;
            
            Equation eq = new Equation();
            infix = textExpression.Text;
            //labValidityOuput.Text = infix + "\n" + infix;
            if (textExpression.Text == "")
            {
                labValidityOuput.Text = "Please enter an expression";
                return;
            }
            validity = eq.CheckValidity(infix);
            if (validity)
            {
                labValidityOuput.Text = "THE EXPRESSION IS VALID";
                balanced = eq.CheckBalance(infix);
                if (balanced)
                {
                    labValidityOuput.Text = "It is a balanced equation";
                    infixArr = eq.Split(infix); //Split infix expression into array of string
                    infixArrElements = eq.ExpressionLength;// get the expression Length, number of array elements
                    string outputdata = infixArr[0];
                    for(int i=1;i< infixArrElements;i++)
                        outputdata= outputdata + " ,  " + infixArr[i];
                    labValidityOuput.Text = "The Expression Has " + infixArrElements + " Elements: \n" + outputdata ;
                }
                else
                    labValidityOuput.Text = "It is a NOT balanced equation";
            }

            else
                labValidityOuput.Text = "THE EXPRESSION IS NOT VALID";
        }

        private void butSolution_Click(object sender, EventArgs e)
        {
            string infix;
            string[] infixArr;
            int infixArrElements;
            string[] postfix;
            bool validity;
            bool balanced;
            string result = "";
            Equation eq = new Equation();
            infix = textExpression.Text;
            //labValidityOuput.Text = infix + "\n" + infix;
            if (textExpression.Text == "")
            {
                labValidityOuput.Text = "Please enter an expression";
                return;
            }
            validity = eq.CheckValidity(infix);
            if (validity)
            {
                labValidityOuput.Text = "THE EXPRESSION IS VALID";
                balanced = eq.CheckBalance(infix);
                if (balanced)
                {
                    labValidityOuput.Text = "It is a balanced equation";
                    infixArr = eq.Split(infix); //Split infix expression into array of string
                    infixArrElements = eq.ExpressionLength;// get the expression Length, number of array elements
                    postfix = eq.Infix2Postfix(infixArr, infixArrElements);  //Convert infix expression to postfix
                    //result = eq.CalculatePostfix(postfix, infixArrElements); //Solve postfix equation
                    int elmNo = 0;
                    while (postfix[elmNo] != null)
                        elmNo++;
                    result = eq.CalculatePostfix(postfix, elmNo);//Solve postfix equation
                    labValidityOuput.Text = result;
                    //Save Result
                    ISaveResult save2file = new FileSaveResult(@"f:\expfile.txt");
                    ISaveResult save2db = new DatabaseSaveResult(@"mydb");

                    eq.SaveResult(save2file, infix, result); //Save the result to file through the interface
                    eq.SaveResult(save2db, infix, result); //Save the result to database through the interface
                }
                else
                    labValidityOuput.Text = "It is a NOT balanced equation";
            }

            else
                labValidityOuput.Text = "THE EXPRESSION IS NOT VALID";
        }

        private void butPostfix_Click(object sender, EventArgs e)
        {
            string infix;
            string[] infixArr;
            int infixArrElements;
            string[] postfix;
            bool validity;
            bool balanced;
            
            Equation eq = new Equation();
            infix = textExpression.Text;
            //labValidityOuput.Text = infix + "\n" + infix;
            if (textExpression.Text == "")
            {
                labValidityOuput.Text = "Please enter an expression";
                return;
            }
            validity = eq.CheckValidity(infix);
            if (validity)
            {
                labValidityOuput.Text = "THE EXPRESSION IS VALID";
                balanced = eq.CheckBalance(infix);
                if (balanced)
                {
                    labValidityOuput.Text = "It is a balanced equation";
                    infixArr = eq.Split(infix); //Split infix expression into array of string
                    infixArrElements = eq.ExpressionLength;// get the expression Length, number of array elements
                    postfix = eq.Infix2Postfix(infixArr, infixArrElements);  //Convert infix expression to postfix
                    string outputdata = postfix[0];
                    for (int i = 1; i < infixArrElements; i++)
                        outputdata = outputdata + postfix[i];
                    labValidityOuput.Text = "The Postfix Expression: " + outputdata;
                }
                else
                    labValidityOuput.Text = "It is a NOT balanced equation";
            }

            else
                labValidityOuput.Text = "THE EXPRESSION IS NOT VALID";
        }
    }
}
