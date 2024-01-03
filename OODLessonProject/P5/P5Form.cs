using System;
using System.Collections;
using System.Windows.Forms;

namespace OODLessonProject.P5
{
    public partial class P5Form : Form
    {
        public P5Form()
        {
            InitializeComponent();
        }
        private void BConvert_Click(object sender, System.EventArgs ev)
        {
            string input = tbInput.Text;
            string output = Convert(input);

            lOutput.Text = "Output: " + output;
        }

        string Convert(string expression)
        {
            string[] tokens = expression.Split(' ');

            Stack operators = new Stack(tokens.Length);
            Queue postfix = new Queue();

            foreach (string t in tokens)
            {
                char token = t[0];

                if (IsOperator(token))
                {
                    while (operators.Size > 0 && IsHigherPrecedence(operators.Read(), token))
                    {
                        postfix.Enqueue(operators.Pop());
                    }
                    operators.Push(token);
                }
                else if (token == '(')
                {
                    operators.Push(token);
                }
                else if (token == ')')
                {
                    while (operators.Read().ToString() != "(")
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

            while (operators.Size > 0)
            {
                postfix.Enqueue(operators.Pop());
            }

            return string.Join(" ", postfix.ToArray());
        }

        bool IsOperator(char token)
        {
            return token == '+' || token == '-' || token == '*' || token == '/' || token == '^';
        }

        bool IsHigherPrecedence(char op1, char op2)
        {
            int op1Precedence = GetOperatorPrecedence(op1);
            int op2Precedence = GetOperatorPrecedence(op2);

            return op1Precedence >= op2Precedence;
        }

        int GetOperatorPrecedence(char op)
        {
            switch (op)
            {
                case '+':
                case '-':
                    return 1;
                case '*':
                case '/':
                    return 2;
                case '^':
                    return 3;
                default:
                    return 0;
            }
        }
    }
}
