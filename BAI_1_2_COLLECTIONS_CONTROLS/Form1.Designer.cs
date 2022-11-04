namespace BAI_1_2_COLLECTIONS_CONTROLS
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
            this.cbbCountry = new System.Windows.Forms.ComboBox();
            this.lstMonHoc = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cbbCountry
            // 
            this.cbbCountry.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cbbCountry.FormattingEnabled = true;
            this.cbbCountry.Items.AddRange(new object[] {
            "Việt Nam",
            "Hàn Quốc",
            "Trung Quốc",
            "Nga"});
            this.cbbCountry.Location = new System.Drawing.Point(153, 12);
            this.cbbCountry.Name = "cbbCountry";
            this.cbbCountry.Size = new System.Drawing.Size(349, 38);
            this.cbbCountry.TabIndex = 0;
            this.cbbCountry.SelectedIndexChanged += new System.EventHandler(this.cbbCountry_SelectedIndexChanged);
            // 
            // lstMonHoc
            // 
            this.lstMonHoc.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lstMonHoc.FormattingEnabled = true;
            this.lstMonHoc.ItemHeight = 30;
            this.lstMonHoc.Items.AddRange(new object[] {
            "Toán",
            "Ngữ Văn ",
            "Hoá",
            "Sử"});
            this.lstMonHoc.Location = new System.Drawing.Point(153, 88);
            this.lstMonHoc.Name = "lstMonHoc";
            this.lstMonHoc.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstMonHoc.Size = new System.Drawing.Size(349, 154);
            this.lstMonHoc.TabIndex = 1;
            this.lstMonHoc.SelectedIndexChanged += new System.EventHandler(this.lstMonHoc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(34, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Quốc gia";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(34, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Môn học";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstMonHoc);
            this.Controls.Add(this.cbbCountry);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cbbCountry;
        private ListBox lstMonHoc;
        private Label label1;
        private Label label2;
    }
}