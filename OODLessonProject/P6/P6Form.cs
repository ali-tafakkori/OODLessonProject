using System;
using System.Windows.Forms;

namespace OODLessonProject.P6
{
    public partial class P6Form : Form
    {
        Vector vector;

        public P6Form()
        {
            InitializeComponent();
        }
        private void BCreate_Click(object sender, EventArgs ev)
        {
            string size = tbSize.Text;
            try
            {
                vector = new Vector(int.Parse(size));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void BGet_Click(object sender, EventArgs e)
        {
            string index = tbIndex.Text;
            try
            {
                tbValue.Text = vector[int.Parse(index)].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BSet_Click(object sender, EventArgs e)
        {
            string row = tbIndex.Text;
            try
            {
                vector[int.Parse(row)] = int.Parse(tbValue.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BSort_Click(object sender, EventArgs e)
        {
            try
            {
                vector.Sort();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BPrint_Click(object sender, EventArgs e)
        {
            try
            {
                lVector.Text = vector.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
