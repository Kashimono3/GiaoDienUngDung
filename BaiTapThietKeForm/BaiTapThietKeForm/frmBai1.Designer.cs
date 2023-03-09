
namespace BaiTapThietKeForm
{
    partial class frmBai1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBai1));
            this.panel = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdDen = new System.Windows.Forms.RadioButton();
            this.rdTrang = new System.Windows.Forms.RadioButton();
            this.rdDo = new System.Windows.Forms.RadioButton();
            this.donGia = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.soLuong = new System.Windows.Forms.Label();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.btn_TinhTien = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSoTien = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.panel)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel.BackgroundImage")));
            this.panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel.Location = new System.Drawing.Point(12, 19);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(336, 204);
            this.panel.TabIndex = 0;
            this.panel.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdDen);
            this.groupBox1.Controls.Add(this.rdTrang);
            this.groupBox1.Controls.Add(this.rdDo);
            this.groupBox1.Location = new System.Drawing.Point(426, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 116);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn Màu Xe";
            // 
            // rdDen
            // 
            this.rdDen.AutoSize = true;
            this.rdDen.Location = new System.Drawing.Point(16, 75);
            this.rdDen.Name = "rdDen";
            this.rdDen.Size = new System.Drawing.Size(45, 17);
            this.rdDen.TabIndex = 0;
            this.rdDen.Text = "Đen";
            this.rdDen.UseVisualStyleBackColor = true;
            this.rdDen.CheckedChanged += new System.EventHandler(this.rdDen_CheckedChanged);
            // 
            // rdTrang
            // 
            this.rdTrang.AutoSize = true;
            this.rdTrang.Location = new System.Drawing.Point(16, 52);
            this.rdTrang.Name = "rdTrang";
            this.rdTrang.Size = new System.Drawing.Size(53, 17);
            this.rdTrang.TabIndex = 0;
            this.rdTrang.Text = "Trắng";
            this.rdTrang.UseVisualStyleBackColor = true;
            this.rdTrang.CheckedChanged += new System.EventHandler(this.rdTrang_CheckedChanged);
            // 
            // rdDo
            // 
            this.rdDo.AutoSize = true;
            this.rdDo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rdDo.BackgroundImage")));
            this.rdDo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.rdDo.Location = new System.Drawing.Point(16, 29);
            this.rdDo.Name = "rdDo";
            this.rdDo.Size = new System.Drawing.Size(39, 17);
            this.rdDo.TabIndex = 0;
            this.rdDo.Text = "Đỏ";
            this.rdDo.UseVisualStyleBackColor = true;
            this.rdDo.CheckedChanged += new System.EventHandler(this.rdDo_CheckedChanged);
            // 
            // donGia
            // 
            this.donGia.AutoSize = true;
            this.donGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.donGia.Location = new System.Drawing.Point(423, 150);
            this.donGia.Name = "donGia";
            this.donGia.Size = new System.Drawing.Size(60, 17);
            this.donGia.TabIndex = 2;
            this.donGia.Text = "Đơn Giá";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(589, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "$";
            // 
            // soLuong
            // 
            this.soLuong.AutoSize = true;
            this.soLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.soLuong.Location = new System.Drawing.Point(418, 190);
            this.soLuong.Name = "soLuong";
            this.soLuong.Size = new System.Drawing.Size(69, 17);
            this.soLuong.TabIndex = 2;
            this.soLuong.Text = "Số Lượng";
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(489, 150);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(94, 23);
            this.txtDonGia.TabIndex = 3;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(489, 190);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(94, 23);
            this.txtSoLuong.TabIndex = 3;
            // 
            // btn_TinhTien
            // 
            this.btn_TinhTien.Location = new System.Drawing.Point(421, 230);
            this.btn_TinhTien.Name = "btn_TinhTien";
            this.btn_TinhTien.Size = new System.Drawing.Size(76, 24);
            this.btn_TinhTien.TabIndex = 4;
            this.btn_TinhTien.Text = "Tính Tiền";
            this.btn_TinhTien.UseVisualStyleBackColor = true;
            this.btn_TinhTien.Click += new System.EventHandler(this.btn_TinhTien_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(320, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tổng số tiền thanh toán";
            // 
            // lblSoTien
            // 
            this.lblSoTien.AutoSize = true;
            this.lblSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTien.Location = new System.Drawing.Point(503, 272);
            this.lblSoTien.Name = "lblSoTien";
            this.lblSoTien.Size = new System.Drawing.Size(18, 20);
            this.lblSoTien.TabIndex = 2;
            this.lblSoTien.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(650, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "$";
            // 
            // frmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_TinhTien);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSoTien);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.soLuong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.donGia);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel);
            this.Name = "frmBai1";
            this.Text = "frmBai1";
            ((System.ComponentModel.ISupportInitialize)(this.panel)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox panel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdDo;
        private System.Windows.Forms.RadioButton rdDen;
        private System.Windows.Forms.RadioButton rdTrang;
        private System.Windows.Forms.Label donGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label soLuong;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Button btn_TinhTien;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSoTien;
        private System.Windows.Forms.Label label3;
    }
}