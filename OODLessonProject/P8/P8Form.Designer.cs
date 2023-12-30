
namespace OODLessonProject.P8
{
    partial class P8Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P8Form));
            this.tbInput1 = new System.Windows.Forms.TextBox();
            this.lTitle = new System.Windows.Forms.Label();
            this.lDesc = new System.Windows.Forms.Label();
            this.lOutput = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbInput2 = new System.Windows.Forms.TextBox();
            this.bNot = new System.Windows.Forms.Button();
            this.bOr = new System.Windows.Forms.Button();
            this.bAnd = new System.Windows.Forms.Button();
            this.bXor = new System.Windows.Forms.Button();
            this.bTwosComplement = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbInput1
            // 
            this.tbInput1.Location = new System.Drawing.Point(42, 212);
            this.tbInput1.Name = "tbInput1";
            this.tbInput1.Size = new System.Drawing.Size(283, 20);
            this.tbInput1.TabIndex = 0;
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("B Zar", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lTitle.Location = new System.Drawing.Point(723, 9);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(65, 35);
            this.lTitle.TabIndex = 1;
            this.lTitle.Text = "تمرین 8";
            // 
            // lDesc
            // 
            this.lDesc.Font = new System.Drawing.Font("B Zar", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lDesc.Location = new System.Drawing.Point(12, 44);
            this.lDesc.Name = "lDesc";
            this.lDesc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lDesc.Size = new System.Drawing.Size(776, 142);
            this.lDesc.TabIndex = 2;
            this.lDesc.Text = resources.GetString("lDesc.Text");
            // 
            // lOutput
            // 
            this.lOutput.AutoSize = true;
            this.lOutput.Location = new System.Drawing.Point(274, 349);
            this.lOutput.Name = "lOutput";
            this.lOutput.Size = new System.Drawing.Size(0, 13);
            this.lOutput.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "exmple: 1011";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(354, 235);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "exmple: 1011";
            // 
            // tbInput2
            // 
            this.tbInput2.Location = new System.Drawing.Point(354, 212);
            this.tbInput2.Name = "tbInput2";
            this.tbInput2.Size = new System.Drawing.Size(283, 20);
            this.tbInput2.TabIndex = 7;
            // 
            // bNot
            // 
            this.bNot.Location = new System.Drawing.Point(250, 263);
            this.bNot.Name = "bNot";
            this.bNot.Size = new System.Drawing.Size(75, 23);
            this.bNot.TabIndex = 9;
            this.bNot.Text = "Not";
            this.bNot.UseVisualStyleBackColor = true;
            this.bNot.Click += new System.EventHandler(this.BNot_Click);
            // 
            // bOr
            // 
            this.bOr.Location = new System.Drawing.Point(250, 292);
            this.bOr.Name = "bOr";
            this.bOr.Size = new System.Drawing.Size(75, 23);
            this.bOr.TabIndex = 10;
            this.bOr.Text = "Or";
            this.bOr.UseVisualStyleBackColor = true;
            this.bOr.Click += new System.EventHandler(this.BOr_Click);
            // 
            // bAnd
            // 
            this.bAnd.Location = new System.Drawing.Point(250, 321);
            this.bAnd.Name = "bAnd";
            this.bAnd.Size = new System.Drawing.Size(75, 23);
            this.bAnd.TabIndex = 11;
            this.bAnd.Text = "And";
            this.bAnd.UseVisualStyleBackColor = true;
            this.bAnd.Click += new System.EventHandler(this.BAnd_Click);
            // 
            // bXor
            // 
            this.bXor.Location = new System.Drawing.Point(250, 350);
            this.bXor.Name = "bXor";
            this.bXor.Size = new System.Drawing.Size(75, 23);
            this.bXor.TabIndex = 12;
            this.bXor.Text = "Xor";
            this.bXor.UseVisualStyleBackColor = true;
            this.bXor.Click += new System.EventHandler(this.BXor_Click);
            // 
            // bTwosComplement
            // 
            this.bTwosComplement.Location = new System.Drawing.Point(236, 379);
            this.bTwosComplement.Name = "bTwosComplement";
            this.bTwosComplement.Size = new System.Drawing.Size(102, 23);
            this.bTwosComplement.TabIndex = 13;
            this.bTwosComplement.Text = "TwosComplement";
            this.bTwosComplement.UseVisualStyleBackColor = true;
            this.bTwosComplement.Click += new System.EventHandler(this.BTwosComplement_Click);
            // 
            // P8Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bTwosComplement);
            this.Controls.Add(this.bXor);
            this.Controls.Add(this.bAnd);
            this.Controls.Add(this.bOr);
            this.Controls.Add(this.bNot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbInput2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lOutput);
            this.Controls.Add(this.lDesc);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.tbInput1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "P8Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "P1 Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInput1;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Label lDesc;
        private System.Windows.Forms.Label lOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbInput2;
        private System.Windows.Forms.Button bNot;
        private System.Windows.Forms.Button bOr;
        private System.Windows.Forms.Button bAnd;
        private System.Windows.Forms.Button bXor;
        private System.Windows.Forms.Button bTwosComplement;
    }
}