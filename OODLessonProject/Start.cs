using System;
using System.Windows.Forms;

namespace OODLessonProject
{
    public partial class Start : Form
    {
        private string[] practices = {
            "Stack",
            "Circle",
            "Matrix",
            "Line",
            "Polygon",
            "Vector",
            "LinkedList",
            "BinaryNumber",
            "Singleton",
            "Node (Counter)",
            "Generic LinkedList",
        };

        public Start()
        {
            InitializeComponent();
            LoadProejctList();
        }

        private void LoadProejctList()
        {
            for (int i = 0; i < practices.Length; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.Cells.AddRange(new DataGridViewCell[] {
                 new DataGridViewTextBoxCell{ Value = i+1},
                 new DataGridViewTextBoxCell{ Value = practices[i]},
                });
                dgvProjects.Rows.Add(row);
            }
        }

        private void BOpen_Click(object sender, EventArgs e)
        {
            if (dgvProjects.SelectedRows.Count > 0)
            {
                int index = (int)dgvProjects.SelectedRows[0].Cells[0].Value;
                switch (index)
                {
                    case 1:
                        new P1.P1Form().Show();
                        break;
                    case 2:
                        new P2.P2Form().Show();
                        break;
                    case 3:
                        new P3.P3Form().Show();
                        break;
                    case 4:
                        new P4.P4Form().Show();
                        break;
                    case 5:
                        //new P5.P5Form().Show();
                        break;
                    case 6:
                        new P6.P6Form().Show();
                        break;
                    case 7:
                        //new P7.P7Form().Show();
                        break;
                    case 8:
                        new P8.P8Form().Show();
                        break;
                    case 9:
                        new P9.P9Form().Show();
                        break;
                    case 10:
                        new P10.P10Form().Show();
                        break;
                    case 11:
                        new P11.P11Form().Show();
                        break;
                }
            }
        }

        private void DgvProjects_SelectionChanged(object sender, EventArgs e)
        {
            bOpen.Enabled = true;
        }
    }
}
