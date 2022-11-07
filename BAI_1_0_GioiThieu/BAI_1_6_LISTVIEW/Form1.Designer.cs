namespace BAI_1_6_LISTVIEW
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstTest = new System.Windows.Forms.ListView();
            this.btnSmall = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.btnLarge = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstTest
            // 
            this.lstTest.FullRowSelect = true;
            this.lstTest.Location = new System.Drawing.Point(12, 12);
            this.lstTest.Name = "lstTest";
            this.lstTest.Size = new System.Drawing.Size(570, 426);
            this.lstTest.TabIndex = 0;
            this.lstTest.UseCompatibleStateImageBehavior = false;
            this.lstTest.SelectedIndexChanged += new System.EventHandler(this.lstTest_SelectedIndexChanged);
            // 
            // btnSmall
            // 
            this.btnSmall.Location = new System.Drawing.Point(630, 71);
            this.btnSmall.Name = "btnSmall";
            this.btnSmall.Size = new System.Drawing.Size(75, 23);
            this.btnSmall.TabIndex = 1;
            this.btnSmall.Text = "SmallIcon";
            this.btnSmall.UseVisualStyleBackColor = true;
            this.btnSmall.Click += new System.EventHandler(this.btnSmall_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(630, 142);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(75, 23);
            this.btnDetail.TabIndex = 2;
            this.btnDetail.Text = "Detail";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.btnDetail_Click);
            // 
            // btnLarge
            // 
            this.btnLarge.Location = new System.Drawing.Point(630, 234);
            this.btnLarge.Name = "btnLarge";
            this.btnLarge.Size = new System.Drawing.Size(75, 23);
            this.btnLarge.TabIndex = 3;
            this.btnLarge.Text = "LargeIcon";
            this.btnLarge.UseVisualStyleBackColor = true;
            this.btnLarge.Click += new System.EventHandler(this.btnLarge_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLarge);
            this.Controls.Add(this.btnDetail);
            this.Controls.Add(this.btnSmall);
            this.Controls.Add(this.lstTest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ListView lstTest;
        private Button btnSmall;
        private Button btnDetail;
        private Button btnLarge;
    }
}