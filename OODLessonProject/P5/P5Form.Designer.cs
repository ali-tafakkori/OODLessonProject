
namespace OODLessonProject.P5
{
    partial class P5Form
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
            this.tbInput = new System.Windows.Forms.TextBox();
            this.lTitle = new System.Windows.Forms.Label();
            this.lDesc = new System.Windows.Forms.Label();
            this.bCreate = new System.Windows.Forms.Button();
            this.lOutput = new System.Windows.Forms.Label();
            this.lSize = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(48, 95);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(90, 20);
            this.tbInput.TabIndex = 0;
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("B Zar", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lTitle.Location = new System.Drawing.Point(723, 9);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(65, 35);
            this.lTitle.TabIndex = 1;
            this.lTitle.Text = "تمرین 5";
            // 
            // lDesc
            // 
            this.lDesc.Font = new System.Drawing.Font("B Zar", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lDesc.Location = new System.Drawing.Point(12, 44);
            this.lDesc.Name = "lDesc";
            this.lDesc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lDesc.Size = new System.Drawing.Size(776, 36);
            this.lDesc.TabIndex = 2;
            this.lDesc.Text = "کلاسی به نام Polygon برای چند ضلعی طراحی کنید. یک چند ضلعی از لیستی از نقاط تشکیل" +
    " شده است.";
            // 
            // bCreate
            // 
            this.bCreate.Location = new System.Drawing.Point(144, 93);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(75, 23);
            this.bCreate.TabIndex = 4;
            this.bCreate.Text = "Create";
            this.bCreate.UseVisualStyleBackColor = true;
            this.bCreate.Click += new System.EventHandler(this.BCreate_Click);
            // 
            // lOutput
            // 
            this.lOutput.AutoSize = true;
            this.lOutput.Location = new System.Drawing.Point(325, 359);
            this.lOutput.Name = "lOutput";
            this.lOutput.Size = new System.Drawing.Size(0, 13);
            this.lOutput.TabIndex = 5;
            // 
            // lSize
            // 
            this.lSize.AutoSize = true;
            this.lSize.Location = new System.Drawing.Point(12, 98);
            this.lSize.Name = "lSize";
            this.lSize.Size = new System.Drawing.Size(30, 13);
            this.lSize.TabIndex = 6;
            this.lSize.Text = "Size:";
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.White;
            this.panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel.Location = new System.Drawing.Point(12, 132);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(776, 306);
            this.panel.TabIndex = 7;
            // 
            // P5Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.lSize);
            this.Controls.Add(this.lOutput);
            this.Controls.Add(this.bCreate);
            this.Controls.Add(this.lDesc);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.tbInput);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "P5Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "P1 Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Label lDesc;
        private System.Windows.Forms.Button bCreate;
        private System.Windows.Forms.Label lOutput;
        private System.Windows.Forms.Label lSize;
        private System.Windows.Forms.Panel panel;
    }
}