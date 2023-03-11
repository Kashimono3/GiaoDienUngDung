namespace BaiTapLyThuyetBuoi2
{
    partial class frm52
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
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.lbDanhSach = new System.Windows.Forms.ListBox();
            this.LbDanhSachChon = new System.Windows.Forms.ListBox();
            this.lblDanhSachChon = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDanhSach
            // 
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.Location = new System.Drawing.Point(12, 40);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(121, 13);
            this.lblDanhSach.TabIndex = 0;
            this.lblDanhSach.Text = "Danh sách sinh viên lớp";
            // 
            // lbDanhSach
            // 
            this.lbDanhSach.FormattingEnabled = true;
            this.lbDanhSach.Items.AddRange(new object[] {
            "Pham Vu Ngoc Ha",
            "Hoang Van hung ",
            "Le Thi Van ",
            "Nguyen Thi Thu",
            "Le Van Quoc",
            "Le Van Phuoc",
            "Truong Van Dung",
            "Tran The Anh",
            "Nguyen Thi Lan Huong"});
            this.lbDanhSach.Location = new System.Drawing.Point(18, 68);
            this.lbDanhSach.MultiColumn = true;
            this.lbDanhSach.Name = "lbDanhSach";
            this.lbDanhSach.Size = new System.Drawing.Size(160, 199);
            this.lbDanhSach.TabIndex = 1;
            // 
            // LbDanhSachChon
            // 
            this.LbDanhSachChon.FormattingEnabled = true;
            this.LbDanhSachChon.Location = new System.Drawing.Point(246, 68);
            this.LbDanhSachChon.MultiColumn = true;
            this.LbDanhSachChon.Name = "LbDanhSachChon";
            this.LbDanhSachChon.Size = new System.Drawing.Size(187, 199);
            this.LbDanhSachChon.TabIndex = 1;
            // 
            // lblDanhSachChon
            // 
            this.lblDanhSachChon.AutoSize = true;
            this.lblDanhSachChon.Location = new System.Drawing.Point(216, 40);
            this.lblDanhSachChon.Name = "lblDanhSachChon";
            this.lblDanhSachChon.Size = new System.Drawing.Size(190, 13);
            this.lblDanhSachChon.TabIndex = 0;
            this.lblDanhSachChon.Text = "Danh sách sinh viên tham gia bóng đá";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(184, 130);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(47, 21);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(184, 170);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(47, 21);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frm52
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.LbDanhSachChon);
            this.Controls.Add(this.lbDanhSach);
            this.Controls.Add(this.lblDanhSachChon);
            this.Controls.Add(this.lblDanhSach);
            this.Name = "frm52";
            this.Text = "frm52";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.ListBox lbDanhSach;
        private System.Windows.Forms.ListBox LbDanhSachChon;
        private System.Windows.Forms.Label lblDanhSachChon;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnXoa;
    }
}