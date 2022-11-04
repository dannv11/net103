namespace BAI_1_0_GioiThieu
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
            this.txtSo1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCong = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSo2 = new System.Windows.Forms.TextBox();
            this.lbKetQua = new System.Windows.Forms.Label();
            this.rbCong = new System.Windows.Forms.RadioButton();
            this.rbNhan = new System.Windows.Forms.RadioButton();
            this.rbTru = new System.Windows.Forms.RadioButton();
            this.rbChia = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // txtSo1
            // 
            this.txtSo1.Location = new System.Drawing.Point(152, 36);
            this.txtSo1.Name = "txtSo1";
            this.txtSo1.Size = new System.Drawing.Size(674, 23);
            this.txtSo1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Số 1";
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(389, 389);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(75, 23);
            this.btnCong.TabIndex = 3;
            this.btnCong.Text = "Tính";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Số 2";
            // 
            // txtSo2
            // 
            this.txtSo2.Location = new System.Drawing.Point(152, 81);
            this.txtSo2.Name = "txtSo2";
            this.txtSo2.Size = new System.Drawing.Size(674, 23);
            this.txtSo2.TabIndex = 4;
            // 
            // lbKetQua
            // 
            this.lbKetQua.AutoSize = true;
            this.lbKetQua.Location = new System.Drawing.Point(414, 350);
            this.lbKetQua.Name = "lbKetQua";
            this.lbKetQua.Size = new System.Drawing.Size(0, 15);
            this.lbKetQua.TabIndex = 6;
            // 
            // rbCong
            // 
            this.rbCong.AutoSize = true;
            this.rbCong.Location = new System.Drawing.Point(83, 146);
            this.rbCong.Name = "rbCong";
            this.rbCong.Size = new System.Drawing.Size(54, 19);
            this.rbCong.TabIndex = 7;
            this.rbCong.TabStop = true;
            this.rbCong.Text = "Cộng";
            this.rbCong.UseVisualStyleBackColor = true;
            this.rbCong.CheckedChanged += new System.EventHandler(this.rbCong_CheckedChanged);
            // 
            // rbNhan
            // 
            this.rbNhan.AutoSize = true;
            this.rbNhan.Location = new System.Drawing.Point(610, 146);
            this.rbNhan.Name = "rbNhan";
            this.rbNhan.Size = new System.Drawing.Size(54, 19);
            this.rbNhan.TabIndex = 8;
            this.rbNhan.TabStop = true;
            this.rbNhan.Text = "Nhân";
            this.rbNhan.UseVisualStyleBackColor = true;
            this.rbNhan.CheckedChanged += new System.EventHandler(this.rbNhan_CheckedChanged);
            // 
            // rbTru
            // 
            this.rbTru.AutoSize = true;
            this.rbTru.Location = new System.Drawing.Point(83, 225);
            this.rbTru.Name = "rbTru";
            this.rbTru.Size = new System.Drawing.Size(41, 19);
            this.rbTru.TabIndex = 9;
            this.rbTru.TabStop = true;
            this.rbTru.Text = "Trừ";
            this.rbTru.UseVisualStyleBackColor = true;
            this.rbTru.CheckedChanged += new System.EventHandler(this.rbTru_CheckedChanged);
            // 
            // rbChia
            // 
            this.rbChia.AutoSize = true;
            this.rbChia.Location = new System.Drawing.Point(610, 245);
            this.rbChia.Name = "rbChia";
            this.rbChia.Size = new System.Drawing.Size(49, 19);
            this.rbChia.TabIndex = 10;
            this.rbChia.TabStop = true;
            this.rbChia.Text = "Chia";
            this.rbChia.UseVisualStyleBackColor = true;
            this.rbChia.CheckedChanged += new System.EventHandler(this.rbChia_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(832, 484);
            this.Controls.Add(this.rbChia);
            this.Controls.Add(this.rbTru);
            this.Controls.Add(this.rbNhan);
            this.Controls.Add(this.rbCong);
            this.Controls.Add(this.lbKetQua);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtSo2);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSo1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Quản lý ny";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtSo1;
        private Label label1;
        private Button btnCong;
        private Label label2;
        private TextBox txtSo2;
        private Label lbKetQua;
        private RadioButton rbCong;
        private RadioButton rbNhan;
        private RadioButton rbTru;
        private RadioButton rbChia;
    }
}