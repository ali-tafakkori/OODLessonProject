
namespace OODLessonProject.P1
{
    partial class P1Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P1Form));
            this.tbInput = new System.Windows.Forms.TextBox();
            this.lTitle = new System.Windows.Forms.Label();
            this.lDesc = new System.Windows.Forms.Label();
            this.lEnterInfixExpression = new System.Windows.Forms.Label();
            this.bConvert = new System.Windows.Forms.Button();
            this.lOutput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(235, 274);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(283, 20);
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
            this.lTitle.Text = "تمرین 1";
            // 
            // lDesc
            // 
            this.lDesc.Font = new System.Drawing.Font("B Zar", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lDesc.Location = new System.Drawing.Point(12, 44);
            this.lDesc.Name = "lDesc";
            this.lDesc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lDesc.Size = new System.Drawing.Size(776, 82);
            this.lDesc.TabIndex = 2;
            this.lDesc.Text = resources.GetString("lDesc.Text");
            // 
            // lEnterInfixExpression
            // 
            this.lEnterInfixExpression.AutoSize = true;
            this.lEnterInfixExpression.Location = new System.Drawing.Point(232, 258);
            this.lEnterInfixExpression.Name = "lEnterInfixExpression";
            this.lEnterInfixExpression.Size = new System.Drawing.Size(110, 13);
            this.lEnterInfixExpression.TabIndex = 3;
            this.lEnterInfixExpression.Text = "Enter Infix expression:";
            // 
            // bConvert
            // 
            this.bConvert.Location = new System.Drawing.Point(443, 313);
            this.bConvert.Name = "bConvert";
            this.bConvert.Size = new System.Drawing.Size(75, 23);
            this.bConvert.TabIndex = 4;
            this.bConvert.Text = "Convert";
            this.bConvert.UseVisualStyleBackColor = true;
            this.bConvert.Click += new System.EventHandler(this.BConvert_Click);
            // 
            // lOutput
            // 
            this.lOutput.AutoSize = true;
            this.lOutput.Location = new System.Drawing.Point(325, 359);
            this.lOutput.Name = "lOutput";
            this.lOutput.Size = new System.Drawing.Size(0, 13);
            this.lOutput.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(235, 297);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "exmple: 3 + 4 * 2 / ( 1 - 5 ) ^ 2 ^ 3";
            // 
            // P1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lOutput);
            this.Controls.Add(this.bConvert);
            this.Controls.Add(this.lEnterInfixExpression);
            this.Controls.Add(this.lDesc);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.tbInput);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "P1Form";
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
        private System.Windows.Forms.Label lEnterInfixExpression;
        private System.Windows.Forms.Button bConvert;
        private System.Windows.Forms.Label lOutput;
        private System.Windows.Forms.Label label1;
    }
}