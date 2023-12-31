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
            string row = tbRow.Text;
            try
            {
                vector = new Vector(int.Parse(row));
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
                tbValue.Text = vector[int.Parse(row), int.Parse(col)].ToString();
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
                vector[int.Parse(row), int.Parse(col)] = int.Parse(tbValue.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
