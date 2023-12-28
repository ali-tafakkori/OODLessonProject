using System;
using System.Collections;
using System.Windows.Forms;

namespace OODLessonProject
{
    public partial class P1Form : Form
    {
        public P1Form()
        {
            InitializeComponent();
        }
        private void BConvert_Click(object sender, System.EventArgs ev)
        {
            string input = tbInput.Text;
            try {
                lOutput.Text = Convert(input);
            }
            catch (Exception e) {
                lOutput.Text = e.ToString();
            }
        }

        string Convert(string expression) {
            string[] tokens = expression.Split(' ');

            Stack operators = new Stack();
            Queue postfix = new Queue();

            foreach (string token in tokens)
            {
                if (IsOperator(token))
                {
                    while (operators.Count > 0 && IsHigherPrecedence((string)operators.Peek(), token))
                    {
                        postfix.Enqueue(operators.Pop());
                    }
                    operators.Push(token);
                }
                else if (token == "(")
                {
                    operators.Push(token);
                }
                else if (token == ")")
                {
                    while ((string)operators.Peek() != "(")
                    {
                        postfix.Enqueue(operators.Pop());
                    }
                    operators.Pop();
                }
                else
                {
                    postfix.Enqueue(token);
                }
            }

            while (operators.Count > 0)
            {
                postfix.Enqueue(operators.Pop());
            }

            return string.Join(" ", postfix.ToArray());
        }

         bool IsOperator(string token)
        {
            return token == "+" || token == "-" || token == "*" || token == "/" || token == "^";
        }

         bool IsHigherPrecedence(string op1, string op2)
        {
            int op1Precedence = GetOperatorPrecedence(op1);
            int op2Precedence = GetOperatorPrecedence(op2);

            return op1Precedence >= op2Precedence;
        }

         int GetOperatorPrecedence(string op)
        {
            switch (op)
            {
                case "+":
                case "-":
                    return 1;
                case "*":
                case "/":
                    return 2;
                case "^":
                    return 3;
                default:
                    return 0;
            }
        }
    }
}
