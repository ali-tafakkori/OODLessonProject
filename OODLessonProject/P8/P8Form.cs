using System;
using System.Windows.Forms;

namespace OODLessonProject.P8
{
    public partial class P8Form : Form
    {
        public P8Form()
        {
            InitializeComponent();
        }
        private void BNot_Click(object sender, EventArgs e)
        {
            try
            {
                BinaryNumber bn = new BinaryNumber(tbInput1.Text);
                MessageBox.Show(bn.Not().Value);
            }
            catch (Exception ex) {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BOr_Click(object sender, EventArgs e)
        {
            try
            {
                BinaryNumber bn1 = new BinaryNumber(tbInput1.Text);
                BinaryNumber bn2 = new BinaryNumber(tbInput2.Text);

                MessageBox.Show(bn1.Or(bn2).Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BAnd_Click(object sender, EventArgs e)
        {
            try
            {
                BinaryNumber bn1 = new BinaryNumber(tbInput1.Text);
                BinaryNumber bn2 = new BinaryNumber(tbInput2.Text);

                MessageBox.Show(bn1.And(bn2).Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BXor_Click(object sender, EventArgs e)
        {
            try
            {
                BinaryNumber bn1 = new BinaryNumber(tbInput1.Text);
                BinaryNumber bn2 = new BinaryNumber(tbInput2.Text);

                MessageBox.Show(bn1.Xor(bn2).Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BTwosComplement_Click(object sender, EventArgs e)
        {
            try
            {
                BinaryNumber bn = new BinaryNumber(tbInput1.Text);
                MessageBox.Show(bn.TwosComplement().Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
