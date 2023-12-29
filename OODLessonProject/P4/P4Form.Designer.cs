
namespace OODLessonProject.P4
{
    partial class P4Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(P4Form));
            this.lTitle = new System.Windows.Forms.Label();
            this.lDesc = new System.Windows.Forms.Label();
            this.tbX1 = new System.Windows.Forms.TextBox();
            this.bLength = new System.Windows.Forms.Button();
            this.lX1 = new System.Windows.Forms.Label();
            this.tbY1 = new System.Windows.Forms.TextBox();
            this.lY1 = new System.Windows.Forms.Label();
            this.tbX2 = new System.Windows.Forms.TextBox();
            this.lX2 = new System.Windows.Forms.Label();
            this.tbY2 = new System.Windows.Forms.TextBox();
            this.lY2 = new System.Windows.Forms.Label();
            this.lPoint1 = new System.Windows.Forms.Label();
            this.lPoint2 = new System.Windows.Forms.Label();
            this.lLength = new System.Windows.Forms.Label();
            this.lIsOn = new System.Windows.Forms.Label();
            this.lPointX = new System.Windows.Forms.Label();
            this.tbYX = new System.Windows.Forms.TextBox();
            this.lYX = new System.Windows.Forms.Label();
            this.tbXX = new System.Windows.Forms.TextBox();
            this.lXX = new System.Windows.Forms.Label();
            this.bIsOn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.bSlope = new System.Windows.Forms.Button();
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
            this.lTitle.Text = "تمرین 4";
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
            // tbX1
            // 
            this.tbX1.Location = new System.Drawing.Point(102, 208);
            this.tbX1.Name = "tbX1";
            this.tbX1.Size = new System.Drawing.Size(100, 20);
            this.tbX1.TabIndex = 5;
            // 
            // bLength
            // 
            this.bLength.Location = new System.Drawing.Point(255, 286);
            this.bLength.Name = "bLength";
            this.bLength.Size = new System.Drawing.Size(75, 23);
            this.bLength.TabIndex = 7;
            this.bLength.Text = "Length";
            this.bLength.UseVisualStyleBackColor = true;
            this.bLength.Click += new System.EventHandler(this.BLentgh_Click_1);
            // 
            // lX1
            // 
            this.lX1.AutoSize = true;
            this.lX1.Location = new System.Drawing.Point(79, 211);
            this.lX1.Name = "lX1";
            this.lX1.Size = new System.Drawing.Size(17, 13);
            this.lX1.TabIndex = 4;
            this.lX1.Text = "X:";
            // 
            // tbY1
            // 
            this.tbY1.Location = new System.Drawing.Point(230, 208);
            this.tbY1.Name = "tbY1";
            this.tbY1.Size = new System.Drawing.Size(100, 20);
            this.tbY1.TabIndex = 11;
            // 
            // lY1
            // 
            this.lY1.AutoSize = true;
            this.lY1.Location = new System.Drawing.Point(207, 211);
            this.lY1.Name = "lY1";
            this.lY1.Size = new System.Drawing.Size(17, 13);
            this.lY1.TabIndex = 10;
            this.lY1.Text = "Y:";
            // 
            // tbX2
            // 
            this.tbX2.Location = new System.Drawing.Point(102, 255);
            this.tbX2.Name = "tbX2";
            this.tbX2.Size = new System.Drawing.Size(100, 20);
            this.tbX2.TabIndex = 13;
            // 
            // lX2
            // 
            this.lX2.AutoSize = true;
            this.lX2.Location = new System.Drawing.Point(79, 258);
            this.lX2.Name = "lX2";
            this.lX2.Size = new System.Drawing.Size(17, 13);
            this.lX2.TabIndex = 12;
            this.lX2.Text = "X:";
            // 
            // tbY2
            // 
            this.tbY2.Location = new System.Drawing.Point(230, 255);
            this.tbY2.Name = "tbY2";
            this.tbY2.Size = new System.Drawing.Size(100, 20);
            this.tbY2.TabIndex = 15;
            // 
            // lY2
            // 
            this.lY2.AutoSize = true;
            this.lY2.Location = new System.Drawing.Point(207, 258);
            this.lY2.Name = "lY2";
            this.lY2.Size = new System.Drawing.Size(17, 13);
            this.lY2.TabIndex = 14;
            this.lY2.Text = "Y:";
            // 
            // lPoint1
            // 
            this.lPoint1.AutoSize = true;
            this.lPoint1.Location = new System.Drawing.Point(102, 190);
            this.lPoint1.Name = "lPoint1";
            this.lPoint1.Size = new System.Drawing.Size(43, 13);
            this.lPoint1.TabIndex = 16;
            this.lPoint1.Text = "Point 1:";
            // 
            // lPoint2
            // 
            this.lPoint2.AutoSize = true;
            this.lPoint2.Location = new System.Drawing.Point(102, 239);
            this.lPoint2.Name = "lPoint2";
            this.lPoint2.Size = new System.Drawing.Size(43, 13);
            this.lPoint2.TabIndex = 18;
            this.lPoint2.Text = "Point 2:";
            // 
            // lLength
            // 
            this.lLength.AutoSize = true;
            this.lLength.Location = new System.Drawing.Point(99, 291);
            this.lLength.Name = "lLength";
            this.lLength.Size = new System.Drawing.Size(43, 13);
            this.lLength.TabIndex = 19;
            this.lLength.Text = "Length:";
            // 
            // lIsOn
            // 
            this.lIsOn.AutoSize = true;
            this.lIsOn.Location = new System.Drawing.Point(422, 244);
            this.lIsOn.Name = "lIsOn";
            this.lIsOn.Size = new System.Drawing.Size(95, 13);
            this.lIsOn.TabIndex = 26;
            this.lIsOn.Text = "Is on the Line: Yes";
            // 
            // lPointX
            // 
            this.lPointX.AutoSize = true;
            this.lPointX.Location = new System.Drawing.Point(422, 192);
            this.lPointX.Name = "lPointX";
            this.lPointX.Size = new System.Drawing.Size(44, 13);
            this.lPointX.TabIndex = 25;
            this.lPointX.Text = "Point X:";
            // 
            // tbYX
            // 
            this.tbYX.Location = new System.Drawing.Point(550, 208);
            this.tbYX.Name = "tbYX";
            this.tbYX.Size = new System.Drawing.Size(100, 20);
            this.tbYX.TabIndex = 24;
            // 
            // lYX
            // 
            this.lYX.AutoSize = true;
            this.lYX.Location = new System.Drawing.Point(527, 211);
            this.lYX.Name = "lYX";
            this.lYX.Size = new System.Drawing.Size(17, 13);
            this.lYX.TabIndex = 23;
            this.lYX.Text = "Y:";
            // 
            // tbXX
            // 
            this.tbXX.Location = new System.Drawing.Point(422, 208);
            this.tbXX.Name = "tbXX";
            this.tbXX.Size = new System.Drawing.Size(100, 20);
            this.tbXX.TabIndex = 22;
            // 
            // lXX
            // 
            this.lXX.AutoSize = true;
            this.lXX.Location = new System.Drawing.Point(399, 211);
            this.lXX.Name = "lXX";
            this.lXX.Size = new System.Drawing.Size(17, 13);
            this.lXX.TabIndex = 21;
            this.lXX.Text = "X:";
            // 
            // bIsOn
            // 
            this.bIsOn.Location = new System.Drawing.Point(575, 239);
            this.bIsOn.Name = "bIsOn";
            this.bIsOn.Size = new System.Drawing.Size(75, 23);
            this.bIsOn.TabIndex = 20;
            this.bIsOn.Text = "Is on";
            this.bIsOn.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "Slope:";
            // 
            // bSlope
            // 
            this.bSlope.Location = new System.Drawing.Point(255, 315);
            this.bSlope.Name = "bSlope";
            this.bSlope.Size = new System.Drawing.Size(75, 23);
            this.bSlope.TabIndex = 27;
            this.bSlope.Text = "Slope";
            this.bSlope.UseVisualStyleBackColor = true;
            // 
            // P4Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bSlope);
            this.Controls.Add(this.lIsOn);
            this.Controls.Add(this.lPointX);
            this.Controls.Add(this.tbYX);
            this.Controls.Add(this.lYX);
            this.Controls.Add(this.tbXX);
            this.Controls.Add(this.lXX);
            this.Controls.Add(this.bIsOn);
            this.Controls.Add(this.lLength);
            this.Controls.Add(this.lPoint2);
            this.Controls.Add(this.lPoint1);
            this.Controls.Add(this.tbY2);
            this.Controls.Add(this.lY2);
            this.Controls.Add(this.tbX2);
            this.Controls.Add(this.lX2);
            this.Controls.Add(this.tbY1);
            this.Controls.Add(this.lY1);
            this.Controls.Add(this.bLength);
            this.Controls.Add(this.tbX1);
            this.Controls.Add(this.lX1);
            this.Controls.Add(this.lDesc);
            this.Controls.Add(this.lTitle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "P4Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "P1 Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Label lDesc;
        private System.Windows.Forms.TextBox tbX1;
        private System.Windows.Forms.Button bLength;
        private System.Windows.Forms.Label lX1;
        private System.Windows.Forms.TextBox tbY1;
        private System.Windows.Forms.Label lY1;
        private System.Windows.Forms.TextBox tbX2;
        private System.Windows.Forms.Label lX2;
        private System.Windows.Forms.TextBox tbY2;
        private System.Windows.Forms.Label lY2;
        private System.Windows.Forms.Label lPoint1;
        private System.Windows.Forms.Label lPoint2;
        private System.Windows.Forms.Label lLength;
        private System.Windows.Forms.Label lIsOn;
        private System.Windows.Forms.Label lPointX;
        private System.Windows.Forms.TextBox tbYX;
        private System.Windows.Forms.Label lYX;
        private System.Windows.Forms.TextBox tbXX;
        private System.Windows.Forms.Label lXX;
        private System.Windows.Forms.Button bIsOn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bSlope;
    }
}