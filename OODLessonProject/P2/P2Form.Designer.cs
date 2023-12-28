
namespace OODLessonProject.P2
{
    partial class P2Form
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
            this.lTitle = new System.Windows.Forms.Label();
            this.lDesc = new System.Windows.Forms.Label();
            this.tbRadius = new System.Windows.Forms.TextBox();
            this.bCalculate = new System.Windows.Forms.Button();
            this.lEnterRadius = new System.Windows.Forms.Label();
            this.lPerimeter = new System.Windows.Forms.Label();
            this.lArea = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("B Zar", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lTitle.Location = new System.Drawing.Point(723, 9);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(65, 35);
            this.lTitle.TabIndex = 1;
            this.lTitle.Text = "تمرین 2";
            // 
            // lDesc
            // 
            this.lDesc.Font = new System.Drawing.Font("B Zar", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lDesc.Location = new System.Drawing.Point(12, 44);
            this.lDesc.Name = "lDesc";
            this.lDesc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lDesc.Size = new System.Drawing.Size(776, 82);
            this.lDesc.TabIndex = 2;
            this.lDesc.Text = "کلاسی به نام Circle برای دایره طراحی کنید. این کلاس باید دارای یک سازنده پیش فرض،" +
    " یک سازنده که شعاع دایره را به عنوان پارامتر دریافت میکند، یک سازنده کپی و توابع" +
    " محاسبه محیط و مساحت باشد.";
            // 
            // tbRadius
            // 
            this.tbRadius.Location = new System.Drawing.Point(323, 202);
            this.tbRadius.Name = "tbRadius";
            this.tbRadius.Size = new System.Drawing.Size(100, 20);
            this.tbRadius.TabIndex = 5;
            // 
            // bCalculate
            // 
            this.bCalculate.Location = new System.Drawing.Point(348, 228);
            this.bCalculate.Name = "bCalculate";
            this.bCalculate.Size = new System.Drawing.Size(75, 23);
            this.bCalculate.TabIndex = 7;
            this.bCalculate.Text = "Calculate";
            this.bCalculate.UseVisualStyleBackColor = true;
            this.bCalculate.Click += new System.EventHandler(this.BCalculate_Click);
            // 
            // lEnterRadius
            // 
            this.lEnterRadius.AutoSize = true;
            this.lEnterRadius.Location = new System.Drawing.Point(320, 186);
            this.lEnterRadius.Name = "lEnterRadius";
            this.lEnterRadius.Size = new System.Drawing.Size(66, 13);
            this.lEnterRadius.TabIndex = 4;
            this.lEnterRadius.Text = "Enter radius:";
            // 
            // lPerimeter
            // 
            this.lPerimeter.AutoSize = true;
            this.lPerimeter.Location = new System.Drawing.Point(320, 272);
            this.lPerimeter.Name = "lPerimeter";
            this.lPerimeter.Size = new System.Drawing.Size(0, 13);
            this.lPerimeter.TabIndex = 8;
            // 
            // lArea
            // 
            this.lArea.AutoSize = true;
            this.lArea.Location = new System.Drawing.Point(320, 296);
            this.lArea.Name = "lArea";
            this.lArea.Size = new System.Drawing.Size(0, 13);
            this.lArea.TabIndex = 9;
            // 
            // P2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lArea);
            this.Controls.Add(this.lPerimeter);
            this.Controls.Add(this.bCalculate);
            this.Controls.Add(this.tbRadius);
            this.Controls.Add(this.lEnterRadius);
            this.Controls.Add(this.lDesc);
            this.Controls.Add(this.lTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "P2Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "P1 Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Label lDesc;
        private System.Windows.Forms.TextBox tbRadius;
        private System.Windows.Forms.Button bCalculate;
        private System.Windows.Forms.Label lEnterRadius;
        private System.Windows.Forms.Label lPerimeter;
        private System.Windows.Forms.Label lArea;
    }
}