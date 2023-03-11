namespace BaiTapLyThuyetBuoi2
{
    partial class Frm60
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
            this.clbMonHoc = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // clbMonHoc
            // 
            this.clbMonHoc.FormattingEnabled = true;
            this.clbMonHoc.Items.AddRange(new object[] {
            "CC và MT LT1",
            "Cơ sở dữ liệu ",
            "Tiếng Anh 2",
            "Quản Trị Mạng ",
            "Photoshop",
            "Đồ án ",
            "Tin học cơ Sở ",
            "Cấu trúc dữ liệu và thuật giải ",
            "OOP",
            "Nhập Môn CNTT",
            "Thiết Kế Web",
            "Bảo Trì Máy Tính ",
            "Mạng Máy Tính"});
            this.clbMonHoc.Location = new System.Drawing.Point(1, 12);
            this.clbMonHoc.MultiColumn = true;
            this.clbMonHoc.Name = "clbMonHoc";
            this.clbMonHoc.Size = new System.Drawing.Size(394, 124);
            this.clbMonHoc.TabIndex = 1;
            this.clbMonHoc.SelectedIndexChanged += new System.EventHandler(this.clbMonHoc_SelectedIndexChanged);
            // 
            // Frm60
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clbMonHoc);
            this.Name = "Frm60";
            this.Text = "Demo CheckListBox";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox clbMonHoc;
    }
}