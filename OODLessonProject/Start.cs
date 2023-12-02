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
            new DataGridViewTextBoxCell{ Value = "عبارت پسوندی با استک",},
            new DataGridViewTextBoxCell{ Value = " با استفاده از کالس Stack طراحی شده در تمرین قبل برنامهای به زبان #C بنویسید که یک عبارت میانوندی 
را با استفاده از پشته به یک عبارت پسوندی تبدیل کند )الگوریتم تبدیل در ابتدای این جزوه ارائه شده است(."},
            new DataGridViewTextBoxCell{ Value = "Hi"},
            });

            dgvProjects.Rows.Add(row);
        }
    }
}
