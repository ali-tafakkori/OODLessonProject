using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;

namespace OODLessonProject.P7
{
    public partial class P7Form : Form
    {
        LinkedList linkedList = new LinkedList();
        public P7Form()
        {
            InitializeComponent();
        }
        private void BAdd_Click(object sender, System.EventArgs ev)
        {
            string id = tbId.Text;
            string name = tbName.Text;
            try
            {
                linkedList.Add(new Student(int.Parse(id), name));
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
    }
}
