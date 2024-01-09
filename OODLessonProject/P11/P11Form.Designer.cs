
namespace OODLessonProject.P11
{
    partial class P11Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P11Form));
            this.tbInput = new System.Windows.Forms.TextBox();
            this.lTitle = new System.Windows.Forms.Label();
            this.lDesc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bAddFirst = new System.Windows.Forms.Button();
            this.bAddLast = new System.Windows.Forms.Button();
            this.bRemoveFirst = new System.Windows.Forms.Button();
            this.loutput = new System.Windows.Forms.Label();
            this.bRemoveLast = new System.Windows.Forms.Button();
            this.bRemoveAfter = new System.Windows.Forms.Button();
            this.bReverse = new System.Windows.Forms.Button();
            this.bPrint = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbInput
            // 
            this.tbInput.Location = new System.Drawing.Point(42, 212);
            this.tbInput.Name = "tbInput";
            this.tbInput.Size = new System.Drawing.Size(156, 20);
            this.tbInput.TabIndex = 0;
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("B Zar", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lTitle.Location = new System.Drawing.Point(714, 9);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(74, 35);
            this.lTitle.TabIndex = 1;
            this.lTitle.Text = "تمرین 11";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "exmple: hi,x,ali,..";
            // 
            // bAddFirst
            // 
            this.bAddFirst.Location = new System.Drawing.Point(42, 251);
            this.bAddFirst.Name = "bAddFirst";
            this.bAddFirst.Size = new System.Drawing.Size(75, 23);
            this.bAddFirst.TabIndex = 9;
            this.bAddFirst.Text = "Add First";
            this.bAddFirst.UseVisualStyleBackColor = true;
            this.bAddFirst.Click += new System.EventHandler(this.BAddFirst_Click);
            // 
            // bAddLast
            // 
            this.bAddLast.Location = new System.Drawing.Point(123, 251);
            this.bAddLast.Name = "bAddLast";
            this.bAddLast.Size = new System.Drawing.Size(75, 23);
            this.bAddLast.TabIndex = 10;
            this.bAddLast.Text = "AddLast";
            this.bAddLast.UseVisualStyleBackColor = true;
            this.bAddLast.Click += new System.EventHandler(this.BAddLast_Click);
            // 
            // bRemoveFirst
            // 
            this.bRemoveFirst.Location = new System.Drawing.Point(234, 210);
            this.bRemoveFirst.Name = "bRemoveFirst";
            this.bRemoveFirst.Size = new System.Drawing.Size(88, 23);
            this.bRemoveFirst.TabIndex = 12;
            this.bRemoveFirst.Text = "Remove First";
            this.bRemoveFirst.UseVisualStyleBackColor = true;
            this.bRemoveFirst.Click += new System.EventHandler(this.BRemoveFirst_Click);
            // 
            // loutput
            // 
            this.loutput.Location = new System.Drawing.Point(39, 290);
            this.loutput.Name = "loutput";
            this.loutput.Size = new System.Drawing.Size(718, 130);
            this.loutput.TabIndex = 8;
            // 
            // bRemoveLast
            // 
            this.bRemoveLast.Location = new System.Drawing.Point(328, 210);
            this.bRemoveLast.Name = "bRemoveLast";
            this.bRemoveLast.Size = new System.Drawing.Size(88, 23);
            this.bRemoveLast.TabIndex = 13;
            this.bRemoveLast.Text = "Remove Last";
            this.bRemoveLast.UseVisualStyleBackColor = true;
            this.bRemoveLast.Click += new System.EventHandler(this.BRemoveLast_Click);
            // 
            // bRemoveAfter
            // 
            this.bRemoveAfter.Location = new System.Drawing.Point(422, 210);
            this.bRemoveAfter.Name = "bRemoveAfter";
            this.bRemoveAfter.Size = new System.Drawing.Size(88, 23);
            this.bRemoveAfter.TabIndex = 14;
            this.bRemoveAfter.Text = "Remove After";
            this.bRemoveAfter.UseVisualStyleBackColor = true;
            this.bRemoveAfter.Click += new System.EventHandler(this.BRemoveAfter_Click);
            // 
            // bReverse
            // 
            this.bReverse.Location = new System.Drawing.Point(328, 251);
            this.bReverse.Name = "bReverse";
            this.bReverse.Size = new System.Drawing.Size(88, 23);
            this.bReverse.TabIndex = 15;
            this.bReverse.Text = "Reverse";
            this.bReverse.UseVisualStyleBackColor = true;
            this.bReverse.Click += new System.EventHandler(this.BReverse_Click);
            // 
            // bPrint
            // 
            this.bPrint.Location = new System.Drawing.Point(234, 251);
            this.bPrint.Name = "bPrint";
            this.bPrint.Size = new System.Drawing.Size(88, 23);
            this.bPrint.TabIndex = 16;
            this.bPrint.Text = "Print";
            this.bPrint.UseVisualStyleBackColor = true;
            this.bPrint.Click += new System.EventHandler(this.BPrint_Click);
            // 
            // P11Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bPrint);
            this.Controls.Add(this.bReverse);
            this.Controls.Add(this.bRemoveAfter);
            this.Controls.Add(this.bRemoveLast);
            this.Controls.Add(this.bRemoveFirst);
            this.Controls.Add(this.bAddLast);
            this.Controls.Add(this.bAddFirst);
            this.Controls.Add(this.loutput);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lDesc);
            this.Controls.Add(this.lTitle);
            this.Controls.Add(this.tbInput);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "P11Form";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bAddFirst;
        private System.Windows.Forms.Button bAddLast;
        private System.Windows.Forms.Button bRemoveFirst;
        private System.Windows.Forms.Label loutput;
        private System.Windows.Forms.Button bRemoveLast;
        private System.Windows.Forms.Button bRemoveAfter;
        private System.Windows.Forms.Button bReverse;
        private System.Windows.Forms.Button bPrint;
    }
}