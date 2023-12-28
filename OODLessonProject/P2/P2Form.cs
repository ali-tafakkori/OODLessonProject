using System;
using System.Collections;
using System.Windows.Forms;

namespace OODLessonProject.P2
{
    public partial class P2Form : Form
    {
        public P2Form()
        {
            InitializeComponent();
        }
        private void BCalculate_Click(object sender, EventArgs ev)
        {
            string input = tbRadius.Text;

            try
            {
                int radius = int.Parse(input);
                Circle circle = new Circle(radius);

                lPerimeter.Text = "Perimeter: " + circle.Perimeter();
                lArea.Text = "Area: " + circle.Area();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
