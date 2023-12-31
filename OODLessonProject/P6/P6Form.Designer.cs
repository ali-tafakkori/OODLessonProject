
namespace OODLessonProject.P6
{
    partial class P6Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P6Form));
            this.lTitle = new System.Windows.Forms.Label();
            this.lDesc = new System.Windows.Forms.Label();
            this.tbRow = new System.Windows.Forms.TextBox();
            this.bCreate = new System.Windows.Forms.Button();
            this.lSize = new System.Windows.Forms.Label();
            this.lPerimeter = new System.Windows.Forms.Label();
            this.tbRowIndex = new System.Windows.Forms.TextBox();
            this.lIndex = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bGet = new System.Windows.Forms.Button();
            this.bSet = new System.Windows.Forms.Button();
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
            this.lTitle.Text = "تمرین 3";
            // 
            // lDesc
            // 
            this.lDesc.Font = new System.Drawing.Font("B Zar", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lDesc.Location = new System.Drawing.Point(12, 44);
            this.lDesc.Name = "lDesc";
            this.lDesc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lDesc.Size = new System.Drawing.Size(776, 184);
            this.lDesc.TabIndex = 2;
            this.lDesc.Text = resources.GetString("lDesc.Text");
            // 
            // tbRow
            // 
            this.tbRow.Location = new System.Drawing.Point(96, 269);
            this.tbRow.Name = "tbRow";
            this.tbRow.Size = new System.Drawing.Size(68, 20);
            this.tbRow.TabIndex = 5;
            // 
            // bCreate
            // 
            this.bCreate.Location = new System.Drawing.Point(96, 337);
            this.bCreate.Name = "bCreate";
            this.bCreate.Size = new System.Drawing.Size(75, 23);
            this.bCreate.TabIndex = 7;
            this.bCreate.Text = "Create";
            this.bCreate.UseVisualStyleBackColor = true;
            this.bCreate.Click += new System.EventHandler(this.BCreate_Click);
            // 
            // lSize
            // 
            this.lSize.AutoSize = true;
            this.lSize.Location = new System.Drawing.Point(9, 272);
            this.lSize.Name = "lSize";
            this.lSize.Size = new System.Drawing.Size(30, 13);
            this.lSize.TabIndex = 4;
            this.lSize.Text = "Size:";
            // 
            // lPerimeter
            // 
            this.lPerimeter.AutoSize = true;
            this.lPerimeter.Location = new System.Drawing.Point(320, 272);
            this.lPerimeter.Name = "lPerimeter";
            this.lPerimeter.Size = new System.Drawing.Size(0, 13);
            this.lPerimeter.TabIndex = 8;
            // 
            // tbRowIndex
            // 
            this.tbRowIndex.Location = new System.Drawing.Point(336, 269);
            this.tbRowIndex.Name = "tbRowIndex";
            this.tbRowIndex.Size = new System.Drawing.Size(68, 20);
            this.tbRowIndex.TabIndex = 13;
            // 
            // lIndex
            // 
            this.lIndex.AutoSize = true;
            this.lIndex.Location = new System.Drawing.Point(269, 272);
            this.lIndex.Name = "lIndex";
            this.lIndex.Size = new System.Drawing.Size(36, 13);
            this.lIndex.TabIndex = 12;
            this.lIndex.Text = "Index:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(468, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 14;
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(336, 299);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(68, 20);
            this.tbValue.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 302);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Value:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 302);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 17;
            // 
            // bGet
            // 
            this.bGet.Location = new System.Drawing.Point(336, 337);
            this.bGet.Name = "bGet";
            this.bGet.Size = new System.Drawing.Size(75, 23);
            this.bGet.TabIndex = 20;
            this.bGet.Text = "Get";
            this.bGet.UseVisualStyleBackColor = true;
            this.bGet.Click += new System.EventHandler(this.bGet_Click);
            // 
            // bSet
            // 
            this.bSet.Location = new System.Drawing.Point(336, 366);
            this.bSet.Name = "bSet";
            this.bSet.Size = new System.Drawing.Size(75, 23);
            this.bSet.TabIndex = 21;
            this.bSet.Text = "Set";
            this.bSet.UseVisualStyleBackColor = true;
            this.bSet.Click += new System.EventHandler(this.bSet_Click);
            // 
            // P6Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bSet);
            this.Controls.Add(this.bGet);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbRowIndex);
            this.Controls.Add(this.lIndex);
            this.Controls.Add(this.lPerimeter);
            this.Controls.Add(this.bCreate);
            this.Controls.Add(this.tbRow);
            this.Controls.Add(this.lSize);
            this.Controls.Add(this.lDesc);
            this.Controls.Add(this.lTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "P6Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "P1 Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Label lDesc;
        private System.Windows.Forms.TextBox tbRow;
        private System.Windows.Forms.Button bCreate;
        private System.Windows.Forms.Label lSize;
        private System.Windows.Forms.Label lPerimeter;
        private System.Windows.Forms.TextBox tbRowIndex;
        private System.Windows.Forms.Label lIndex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bGet;
        private System.Windows.Forms.Button bSet;
    }
}