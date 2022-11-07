namespace BAI_1_3_LISTBOX
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
            this.lstItem = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstItem
            // 
            this.lstItem.FormattingEnabled = true;
            this.lstItem.ItemHeight = 15;
            this.lstItem.Location = new System.Drawing.Point(12, 12);
            this.lstItem.Name = "lstItem";
            this.lstItem.Size = new System.Drawing.Size(469, 424);
            this.lstItem.TabIndex = 0;
            this.lstItem.SelectedValueChanged += new System.EventHandler(this.lstItem_SelectedValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 450);
            this.Controls.Add(this.lstItem);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox lstItem;
    }
}