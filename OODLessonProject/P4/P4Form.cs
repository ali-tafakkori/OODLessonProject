using System;
using System.Windows.Forms;

namespace OODLessonProject.P4
{
    public partial class P4Form : Form
    {
        public P4Form()
        {
            InitializeComponent();
        }
        private void BLentgh_Click_1(object sender, EventArgs ev)
        {
            string x1 = tbX1.Text;
            string y1 = tbY1.Text;
            string x2 = tbX2.Text;
            string y2 = tbY2.Text;
            try
            {
                Line line = new Line(new Point(int.Parse(x1),int.Parse(y1)), new Point(int.Parse(x2), int.Parse(y2)));

                lLength.Text = "Length: " + line.Length;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void BSlope_Click(object sender, EventArgs ev)
        {
            string x1 = tbX1.Text;
            string y1 = tbY1.Text;
            string x2 = tbX2.Text;
            string y2 = tbY2.Text;
            try
            {
                Line line = new Line(new Point(int.Parse(x1), int.Parse(y1)), new Point(int.Parse(x2), int.Parse(y2)));

                lSlope.Text = "Slope: " + line.Slope;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
