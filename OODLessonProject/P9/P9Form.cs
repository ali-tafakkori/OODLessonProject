using System;
using System.Collections;
using System.Windows.Forms;

namespace OODLessonProject.P9
{
    public partial class P9Form : Form
    {
        public P9Form()
        {
            InitializeComponent();
        }
        private void BCreate_Click(object sender, System.EventArgs ev)
        {
            try {
                Program program = new Program("path");
                MessageBox.Show("Created");
            }
            catch (Exception e) {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
