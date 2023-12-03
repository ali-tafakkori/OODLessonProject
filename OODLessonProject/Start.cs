using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OODLessonProject
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
            LoadProejctList();
        }

        private void LoadProejctList()
        {
            DataGridViewRow row = new DataGridViewRow();
            row.Cells.AddRange(new DataGridViewCell[] {
            new DataGridViewTextBoxCell{ Value = "Paratice 1",},
            new DataGridViewTextBoxCell{ Value = "Hi"},
            new DataGridViewTextBoxCell{ Value = " - "},
            });

            dgvProjects.Rows.Add(row);
        }

        private void BOpen_Click(object sender, EventArgs e)
        {

        }

        private void DgvProjects_SelectionChanged(object sender, EventArgs e)
        {
            bOpen.Enabled = true;
        }
    }
}
