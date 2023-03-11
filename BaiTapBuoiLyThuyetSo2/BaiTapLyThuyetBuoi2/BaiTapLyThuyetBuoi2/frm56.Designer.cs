namespace BaiTapLyThuyetBuoi2
{
    partial class frm56
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
            this.grbSex = new System.Windows.Forms.GroupBox();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.grbSex.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbSex
            // 
            this.grbSex.Controls.Add(this.rdNu);
            this.grbSex.Controls.Add(this.rdNam);
            this.grbSex.Location = new System.Drawing.Point(133, 141);
            this.grbSex.Name = "grbSex";
            this.grbSex.Size = new System.Drawing.Size(123, 92);
            this.grbSex.TabIndex = 0;
            this.grbSex.TabStop = false;
            this.grbSex.Text = "Giới Tính";
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(7, 32);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(47, 17);
            this.rdNam.TabIndex = 0;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = false;
            this.rdNam.CheckedChanged += new System.EventHandler(this.rdNam_CheckedChanged);
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rdNu.Location = new System.Drawing.Point(7, 55);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(39, 17);
            this.rdNu.TabIndex = 0;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = false;
            this.rdNu.CheckedChanged += new System.EventHandler(this.rdNu_CheckedChanged);
            // 
            // frm56
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbSex);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "frm56";
            this.Text = "Demo RadioButton";
            this.grbSex.ResumeLayout(false);
            this.grbSex.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbSex;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
    }
}