
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
            this.lTitle = new System.Windows.Forms.Label();
            this.lDesc = new System.Windows.Forms.Label();
            this.tbSize = new System.Windows.Forms.TextBox();
            this.bCreate = new System.Windows.Forms.Button();
            this.lSize = new System.Windows.Forms.Label();
            this.lPerimeter = new System.Windows.Forms.Label();
            this.tbIndex = new System.Windows.Forms.TextBox();
            this.lIndex = new System.Windows.Forms.Label();
            this.tbValue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bGet = new System.Windows.Forms.Button();
            this.bSet = new System.Windows.Forms.Button();
            this.lVector = new System.Windows.Forms.Label();
            this.bSort = new System.Windows.Forms.Button();
            this.bPrint = new System.Windows.Forms.Button();
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
            this.lTitle.Text = "تمرین 6";
            // 
            // lDesc
            // 
            this.lDesc.Font = new System.Drawing.Font("B Zar", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lDesc.Location = new System.Drawing.Point(12, 44);
            this.lDesc.Name = "lDesc";
            this.lDesc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lDesc.Size = new System.Drawing.Size(776, 184);
            this.lDesc.TabIndex = 2;
            this.lDesc.Text = "همانطور که مشاهده میکنید در حالی که v یک آرایه نیست ولی همانند یک آرایه با آن رفت" +
    "ار میشود. \r\nکالس Vector را با افزودن توابع Print ,Sort ,Search و ویژگیهای Maximu" +
    "m ,Minimum و Average تکمیل کنید.\r\n";
            // 
            // tbSize
            // 
            this.tbSize.Location = new System.Drawing.Point(45, 245);
            this.tbSize.Name = "tbSize";
            this.tbSize.Size = new System.Drawing.Size(68, 20);
            this.tbSize.TabIndex = 5;
            // 
            // bCreate
            // 
            this.bCreate.Location = new System.Drawing.Point(119, 243);
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
            this.lSize.Location = new System.Drawing.Point(9, 248);
            this.lSize.Name = "lSize";
            this.lSize.Size = new System.Drawing.Size(30, 13);
            this.lSize.TabIndex = 4;
            this.lSize.Text = "Size:";
            // 
            // lPerimeter
            // 
            this.lPerimeter.AutoSize = true;
            this.lPerimeter.Location = new System.Drawing.Point(320, 248);
            this.lPerimeter.Name = "lPerimeter";
            this.lPerimeter.Size = new System.Drawing.Size(0, 13);
            this.lPerimeter.TabIndex = 8;
            // 
            // tbIndex
            // 
            this.tbIndex.Location = new System.Drawing.Point(269, 245);
            this.tbIndex.Name = "tbIndex";
            this.tbIndex.Size = new System.Drawing.Size(68, 20);
            this.tbIndex.TabIndex = 13;
            // 
            // lIndex
            // 
            this.lIndex.AutoSize = true;
            this.lIndex.Location = new System.Drawing.Point(227, 248);
            this.lIndex.Name = "lIndex";
            this.lIndex.Size = new System.Drawing.Size(36, 13);
            this.lIndex.TabIndex = 12;
            this.lIndex.Text = "Index:";
            // 
            // tbValue
            // 
            this.tbValue.Location = new System.Drawing.Point(386, 245);
            this.tbValue.Name = "tbValue";
            this.tbValue.Size = new System.Drawing.Size(68, 20);
            this.tbValue.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Value:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(320, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 17;
            // 
            // bGet
            // 
            this.bGet.Location = new System.Drawing.Point(269, 273);
            this.bGet.Name = "bGet";
            this.bGet.Size = new System.Drawing.Size(75, 23);
            this.bGet.TabIndex = 20;
            this.bGet.Text = "Get";
            this.bGet.UseVisualStyleBackColor = true;
            this.bGet.Click += new System.EventHandler(this.BGet_Click);
            // 
            // bSet
            // 
            this.bSet.Location = new System.Drawing.Point(379, 273);
            this.bSet.Name = "bSet";
            this.bSet.Size = new System.Drawing.Size(75, 23);
            this.bSet.TabIndex = 21;
            this.bSet.Text = "Set";
            this.bSet.UseVisualStyleBackColor = true;
            this.bSet.Click += new System.EventHandler(this.BSet_Click);
            // 
            // lVector
            // 
            this.lVector.AutoSize = true;
            this.lVector.Location = new System.Drawing.Point(12, 346);
            this.lVector.Name = "lVector";
            this.lVector.Size = new System.Drawing.Size(0, 13);
            this.lVector.TabIndex = 22;
            // 
            // bSort
            // 
            this.bSort.Location = new System.Drawing.Point(38, 273);
            this.bSort.Name = "bSort";
            this.bSort.Size = new System.Drawing.Size(75, 23);
            this.bSort.TabIndex = 23;
            this.bSort.Text = "Sort";
            this.bSort.UseVisualStyleBackColor = true;
            this.bSort.Click += new System.EventHandler(this.BSort_Click);
            // 
            // bPrint
            // 
            this.bPrint.Location = new System.Drawing.Point(119, 273);
            this.bPrint.Name = "bPrint";
            this.bPrint.Size = new System.Drawing.Size(75, 23);
            this.bPrint.TabIndex = 24;
            this.bPrint.Text = "Print";
            this.bPrint.UseVisualStyleBackColor = true;
            this.bPrint.Click += new System.EventHandler(this.BPrint_Click);
            // 
            // P6Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bPrint);
            this.Controls.Add(this.bSort);
            this.Controls.Add(this.lVector);
            this.Controls.Add(this.bSet);
            this.Controls.Add(this.bGet);
            this.Controls.Add(this.tbValue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbIndex);
            this.Controls.Add(this.lIndex);
            this.Controls.Add(this.lPerimeter);
            this.Controls.Add(this.bCreate);
            this.Controls.Add(this.tbSize);
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
        private System.Windows.Forms.TextBox tbSize;
        private System.Windows.Forms.Button bCreate;
        private System.Windows.Forms.Label lSize;
        private System.Windows.Forms.Label lPerimeter;
        private System.Windows.Forms.TextBox tbIndex;
        private System.Windows.Forms.Label lIndex;
        private System.Windows.Forms.TextBox tbValue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bGet;
        private System.Windows.Forms.Button bSet;
        private System.Windows.Forms.Label lVector;
        private System.Windows.Forms.Button bSort;
        private System.Windows.Forms.Button bPrint;
    }
}