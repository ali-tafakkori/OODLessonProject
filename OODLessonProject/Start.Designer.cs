
namespace OODLessonProject
{
    partial class Start
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bOpen = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvProjects = new System.Windows.Forms.DataGridView();
            this.CName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bOpen);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 340);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 110);
            this.panel1.TabIndex = 1;
            // 
            // bOpen
            // 
            this.bOpen.Enabled = false;
            this.bOpen.Location = new System.Drawing.Point(713, 75);
            this.bOpen.Name = "bOpen";
            this.bOpen.Size = new System.Drawing.Size(75, 23);
            this.bOpen.TabIndex = 3;
            this.bOpen.Text = "Open";
            this.bOpen.UseVisualStyleBackColor = true;
            this.bOpen.Click += new System.EventHandler(this.BOpen_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::OODLessonProject.Properties.Resources.profile;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(14, 67);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ali Tafakkori Khosrowshahi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hey!";
            // 
            // dgvProjects
            // 
            this.dgvProjects.AllowUserToAddRows = false;
            this.dgvProjects.AllowUserToDeleteRows = false;
            this.dgvProjects.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjects.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CName,
            this.CDescription,
            this.CDate});
            this.dgvProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProjects.Location = new System.Drawing.Point(0, 0);
            this.dgvProjects.MultiSelect = false;
            this.dgvProjects.Name = "dgvProjects";
            this.dgvProjects.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProjects.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProjects.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProjects.ShowCellErrors = false;
            this.dgvProjects.ShowCellToolTips = false;
            this.dgvProjects.ShowEditingIcon = false;
            this.dgvProjects.ShowRowErrors = false;
            this.dgvProjects.Size = new System.Drawing.Size(800, 340);
            this.dgvProjects.TabIndex = 2;
            this.dgvProjects.SelectionChanged += new System.EventHandler(this.DgvProjects_SelectionChanged);
            // 
            // CName
            // 
            this.CName.HeaderText = "Name";
            this.CName.Name = "CName";
            this.CName.ReadOnly = true;
            this.CName.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CName.Width = 120;
            // 
            // CDescription
            // 
            this.CDescription.HeaderText = "Description";
            this.CDescription.Name = "CDescription";
            this.CDescription.ReadOnly = true;
            this.CDescription.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CDescription.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CDescription.Width = 500;
            // 
            // CDate
            // 
            this.CDate.HeaderText = "Date";
            this.CDate.Name = "CDate";
            this.CDate.ReadOnly = true;
            this.CDate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.CDate.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.CDate.Width = 120;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvProjects);
            this.Controls.Add(this.panel1);
            this.Name = "Start";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Start";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvProjects;
        private System.Windows.Forms.DataGridViewTextBoxColumn CName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn CDate;
        private System.Windows.Forms.Button bOpen;
    }
}