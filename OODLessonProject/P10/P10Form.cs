using System.Windows.Forms;

namespace OODLessonProject.P10
{
    public partial class P10Form : Form
    {
        public P10Form()
        {
            InitializeComponent();
        }
        private void BCreate_Click(object sender, System.EventArgs ev)
        {
            Node node = new Node(0);
            lPrint.Text += node.id + ", ";
        }
    }
}
