using System;
using System.Collections;
using System.Windows.Forms;

namespace OODLessonProject.P3
{
    public partial class P3Form : Form
    {
        Matrix matrix;

        public P3Form()
        {
            InitializeComponent();
        }
        private void BCreate_Click(object sender, EventArgs ev)
        {
            string row = tbRow.Text;
            string col = tbCol.Text;
            try
            {
                matrix = new Matrix(int.Parse(row), int.Parse(col));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }

        private void bGet_Click(object sender, EventArgs e)
        {
            string row = tbRowIndex.Text;
            string col = tbColIndex.Text;
            try
            {
                tbValue.Text = matrix[int.Parse(row), int.Parse(col)].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bSet_Click(object sender, EventArgs e)
        {
            string row = tbRowIndex.Text;
            string col = tbColIndex.Text;
            try
            {
                matrix[int.Parse(row), int.Parse(col)] = int.Parse(tbValue.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
