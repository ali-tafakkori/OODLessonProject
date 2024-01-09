using System;
using System.Windows.Forms;

namespace OODLessonProject.P11
{
    public partial class P11Form : Form
    {
        LinkedList<string> linkedList = new LinkedList<string>();
        public P11Form()
        {
            InitializeComponent();
        }
        private void BAddFirst_Click(object sender, EventArgs e)
        {
            string input = tbInput.Text;
            linkedList.AddToFirst(input);
        }

        private void BRemoveFirst_Click(object sender, EventArgs e)
        {
            linkedList.RemoveFromFirst();
        }

        private void BAddLast_Click(object sender, EventArgs e)
        {
            string input = tbInput.Text;
            linkedList.AddToLast(input);
        }

        private void BRemoveLast_Click(object sender, EventArgs e)
        {
            linkedList.RemoveFromLast();
        }

        private void BRemoveAfter_Click(object sender, EventArgs e)
        {
            try
            {
                Node<string> node = linkedList.Search(tbInput.Text);
                linkedList.RemoveAfter(node);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void BPrint_Click(object sender, EventArgs e)
        {
            loutput.Text = linkedList.Print();
        }

        private void BReverse_Click(object sender, EventArgs e)
        {
            linkedList.Reverse();
        }
    }
}
