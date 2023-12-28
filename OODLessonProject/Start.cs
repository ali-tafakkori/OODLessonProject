using System;
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
            DataGridViewRow row1 = new DataGridViewRow();
            row1.Cells.AddRange(new DataGridViewCell[] {
            new DataGridViewTextBoxCell{ Value = "تمرین 1",},
            new DataGridViewTextBoxCell{ Value = "با مراجعه به درس ساختمان داده و مرور مبحث تبدیل عبارات میانوندی به پسوندی با استفاده از پشته، برنامهای به زبان #C بدون استفاده از مفهوم کالس بنویسید که با استفاده از پشته عبارات میانوندی را به عبارات پسوندی تبدیل کند."},
            new DataGridViewTextBoxCell{ Value = "6"},
            });
            dgvProjects.Rows.Add(row1);

            DataGridViewRow row2 = new DataGridViewRow();
            row2.Height = 54;
            row2.Cells.AddRange(new DataGridViewCell[] {
            new DataGridViewTextBoxCell{ Value = "تمرین 2",},
            new DataGridViewTextBoxCell{ Value = "کلاسی به نام Circle برای دایره طراحی کنید. این کالس باید دارای یک سازنده پیش فرض، یک سازنده که شعاع دایره را به عنوان پارامتر دریافت میکند، یک سازنده کپی و توابع محاسبه محیط و مساحت باشد."},
            new DataGridViewTextBoxCell{ Value = "27"},
            });
            dgvProjects.Rows.Add(row2);
        }

        private void BOpen_Click(object sender, EventArgs e)
        {
            if (dgvProjects.SelectedRows.Count > 0) {
                int index = dgvProjects.SelectedRows[0].Index;
                switch (index)
                {
                    case 0:
                        new P1Form().Show();
                        break;
                    case 1:
                        new P2Form().Show();
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
