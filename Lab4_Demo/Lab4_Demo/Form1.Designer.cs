﻿namespace Lab4_Demo
{
    partial class frmSinhVien
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
            this.components = new System.ComponentModel.Container();
            this.lvSinhVien = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.pbHinh = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnluu = new System.Windows.Forms.Button();
            this.btnMacDinh = new System.Windows.Forms.Button();
            this.btnChonHinh = new System.Windows.Forms.Button();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.rdNu = new System.Windows.Forms.RadioButton();
            this.rdNam = new System.Windows.Forms.RadioButton();
            this.dtpNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.mtxtSDT = new System.Windows.Forms.MaskedTextBox();
            this.mtxtMaSo = new System.Windows.Forms.MaskedTextBox();
            this.txtHinh = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.xóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tảiLạiDanhSáchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvSinhVien
            // 
            this.lvSinhVien.CheckBoxes = true;
            this.lvSinhVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.lvSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvSinhVien.GridLines = true;
            this.lvSinhVien.HideSelection = false;
            this.lvSinhVien.Location = new System.Drawing.Point(3, 16);
            this.lvSinhVien.Name = "lvSinhVien";
            this.lvSinhVien.Size = new System.Drawing.Size(794, 146);
            this.lvSinhVien.TabIndex = 0;
            this.lvSinhVien.UseCompatibleStateImageBehavior = false;
            this.lvSinhVien.View = System.Windows.Forms.View.Details;
            this.lvSinhVien.SelectedIndexChanged += new System.EventHandler(this.lvSinhVien_SelectedIndexChanged);
            this.lvSinhVien.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lvSinhVien_MouseClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "MSSV";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Họ và tên";
            this.columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Phái";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ngày sinh";
            this.columnHeader4.Width = 100;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Lớp";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Số điện thoại";
            this.columnHeader6.Width = 100;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Email";
            this.columnHeader7.Width = 100;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Địa chỉ";
            this.columnHeader8.Width = 200;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Hình";
            this.columnHeader9.Width = 200;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.pbHinh);
            this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 281;
            this.splitContainer1.TabIndex = 0;
            // 
            // pbHinh
            // 
            this.pbHinh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pbHinh.Location = new System.Drawing.Point(12, 18);
            this.pbHinh.Name = "pbHinh";
            this.pbHinh.Size = new System.Drawing.Size(154, 206);
            this.pbHinh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHinh.TabIndex = 1;
            this.pbHinh.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnThoat);
            this.groupBox1.Controls.Add(this.btnluu);
            this.groupBox1.Controls.Add(this.btnMacDinh);
            this.groupBox1.Controls.Add(this.btnChonHinh);
            this.groupBox1.Controls.Add(this.cboLop);
            this.groupBox1.Controls.Add(this.rdNu);
            this.groupBox1.Controls.Add(this.rdNam);
            this.groupBox1.Controls.Add(this.dtpNgaySinh);
            this.groupBox1.Controls.Add(this.mtxtSDT);
            this.groupBox1.Controls.Add(this.mtxtMaSo);
            this.groupBox1.Controls.Add(this.txtHinh);
            this.groupBox1.Controls.Add(this.txtDiaChi);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtHoTen);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(186, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(602, 266);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông Tin Sinh Viên";
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(473, 231);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(88, 20);
            this.btnThoat.TabIndex = 12;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnluu
            // 
            this.btnluu.Location = new System.Drawing.Point(349, 231);
            this.btnluu.Name = "btnluu";
            this.btnluu.Size = new System.Drawing.Size(83, 20);
            this.btnluu.TabIndex = 11;
            this.btnluu.Text = "Lưu";
            this.btnluu.UseVisualStyleBackColor = true;
            this.btnluu.Click += new System.EventHandler(this.btnluu_Click);
            // 
            // btnMacDinh
            // 
            this.btnMacDinh.Location = new System.Drawing.Point(225, 231);
            this.btnMacDinh.Name = "btnMacDinh";
            this.btnMacDinh.Size = new System.Drawing.Size(94, 20);
            this.btnMacDinh.TabIndex = 10;
            this.btnMacDinh.Text = "Mặc định";
            this.btnMacDinh.UseVisualStyleBackColor = true;
            this.btnMacDinh.Click += new System.EventHandler(this.btnMacDinh_Click);
            // 
            // btnChonHinh
            // 
            this.btnChonHinh.Location = new System.Drawing.Point(443, 193);
            this.btnChonHinh.Name = "btnChonHinh";
            this.btnChonHinh.Size = new System.Drawing.Size(118, 20);
            this.btnChonHinh.TabIndex = 9;
            this.btnChonHinh.Text = "Chọn hình";
            this.btnChonHinh.UseVisualStyleBackColor = true;
            this.btnChonHinh.Click += new System.EventHandler(this.btnChonHinh_Click);
            // 
            // cboLop
            // 
            this.cboLop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Items.AddRange(new object[] {
            "CTK43",
            "CTK44",
            "CTK45",
            "CTK46"});
            this.cboLop.Location = new System.Drawing.Point(422, 113);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(167, 21);
            this.cboLop.TabIndex = 7;
            // 
            // rdNu
            // 
            this.rdNu.AutoSize = true;
            this.rdNu.Location = new System.Drawing.Point(502, 80);
            this.rdNu.Name = "rdNu";
            this.rdNu.Size = new System.Drawing.Size(39, 17);
            this.rdNu.TabIndex = 6;
            this.rdNu.Text = "Nữ";
            this.rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            this.rdNam.AutoSize = true;
            this.rdNam.Checked = true;
            this.rdNam.Location = new System.Drawing.Point(422, 80);
            this.rdNam.Name = "rdNam";
            this.rdNam.Size = new System.Drawing.Size(47, 17);
            this.rdNam.TabIndex = 5;
            this.rdNam.TabStop = true;
            this.rdNam.Text = "Nam";
            this.rdNam.UseVisualStyleBackColor = true;
            // 
            // dtpNgaySinh
            // 
            this.dtpNgaySinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaySinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaySinh.Location = new System.Drawing.Point(422, 41);
            this.dtpNgaySinh.Name = "dtpNgaySinh";
            this.dtpNgaySinh.Size = new System.Drawing.Size(167, 20);
            this.dtpNgaySinh.TabIndex = 4;
            // 
            // mtxtSDT
            // 
            this.mtxtSDT.Location = new System.Drawing.Point(438, 158);
            this.mtxtSDT.Mask = "000.000.000";
            this.mtxtSDT.Name = "mtxtSDT";
            this.mtxtSDT.Size = new System.Drawing.Size(151, 20);
            this.mtxtSDT.TabIndex = 8;
            // 
            // mtxtMaSo
            // 
            this.mtxtMaSo.Location = new System.Drawing.Point(74, 41);
            this.mtxtMaSo.Mask = "0000000";
            this.mtxtMaSo.Name = "mtxtMaSo";
            this.mtxtMaSo.Size = new System.Drawing.Size(245, 20);
            this.mtxtMaSo.TabIndex = 0;
            // 
            // txtHinh
            // 
            this.txtHinh.Location = new System.Drawing.Point(73, 194);
            this.txtHinh.Name = "txtHinh";
            this.txtHinh.ReadOnly = true;
            this.txtHinh.Size = new System.Drawing.Size(359, 20);
            this.txtHinh.TabIndex = 1;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(73, 158);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(246, 20);
            this.txtDiaChi.TabIndex = 3;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(73, 116);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(246, 20);
            this.txtEmail.TabIndex = 2;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Location = new System.Drawing.Point(74, 76);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(246, 20);
            this.txtHoTen.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(351, 158);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Số điện thoại";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(351, 118);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Lớp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(351, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Phái";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Hình";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Địa Chỉ\r\n";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(351, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Họ và tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "MSSV";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lvSinhVien);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(800, 165);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh Sách Sinh Viên";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.xóaToolStripMenuItem,
            this.tảiLạiDanhSáchToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 70);
            this.contextMenuStrip1.Text = "Menu";
            // 
            // xóaToolStripMenuItem
            // 
            this.xóaToolStripMenuItem.Name = "xóaToolStripMenuItem";
            this.xóaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.xóaToolStripMenuItem.Text = "Xóa";
            this.xóaToolStripMenuItem.Click += new System.EventHandler(this.xóaToolStripMenuItem_Click);
            // 
            // tảiLạiDanhSáchToolStripMenuItem
            // 
            this.tảiLạiDanhSáchToolStripMenuItem.Name = "tảiLạiDanhSáchToolStripMenuItem";
            this.tảiLạiDanhSáchToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tảiLạiDanhSáchToolStripMenuItem.Text = "Tải lại danh sách";
            this.tảiLạiDanhSáchToolStripMenuItem.Click += new System.EventHandler(this.tảiLạiDanhSáchToolStripMenuItem_Click);
            // 
            // frmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Name = "frmSinhVien";
            this.Text = "Quản lý sinh viên thông tin khoa CNTT";
            this.Load += new System.EventHandler(this.frmSinhVien_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbHinh)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox mtxtMaSo;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.PictureBox pbHinh;
        private System.Windows.Forms.RadioButton rdNu;
        private System.Windows.Forms.RadioButton rdNam;
        private System.Windows.Forms.DateTimePicker dtpNgaySinh;
        private System.Windows.Forms.MaskedTextBox mtxtSDT;
        private System.Windows.Forms.TextBox txtHinh;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnluu;
        private System.Windows.Forms.Button btnMacDinh;
        private System.Windows.Forms.Button btnChonHinh;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem xóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tảiLạiDanhSáchToolStripMenuItem;
        private System.Windows.Forms.ListView lvSinhVien;
    }
}

