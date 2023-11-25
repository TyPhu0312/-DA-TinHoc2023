namespace QLLKDienTu
{
    partial class FGioHang
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
            this.grbTTDH = new System.Windows.Forms.GroupBox();
            this.rdbDangGiao = new System.Windows.Forms.RadioButton();
            this.rdbNhan = new System.Windows.Forms.RadioButton();
            this.dgvGioHang = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lb = new System.Windows.Forms.Label();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.grbTTDH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbTTDH
            // 
            this.grbTTDH.Controls.Add(this.rdbDangGiao);
            this.grbTTDH.Controls.Add(this.rdbNhan);
            this.grbTTDH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbTTDH.Location = new System.Drawing.Point(660, 29);
            this.grbTTDH.Name = "grbTTDH";
            this.grbTTDH.Size = new System.Drawing.Size(223, 129);
            this.grbTTDH.TabIndex = 1;
            this.grbTTDH.TabStop = false;
            this.grbTTDH.Text = "Tình trạng đơn hàng";
            // 
            // rdbDangGiao
            // 
            this.rdbDangGiao.AutoSize = true;
            this.rdbDangGiao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDangGiao.Location = new System.Drawing.Point(6, 83);
            this.rdbDangGiao.Name = "rdbDangGiao";
            this.rdbDangGiao.Size = new System.Drawing.Size(171, 29);
            this.rdbDangGiao.TabIndex = 0;
            this.rdbDangGiao.TabStop = true;
            this.rdbDangGiao.Text = "Đang giao hàng";
            this.rdbDangGiao.UseVisualStyleBackColor = true;
            // 
            // rdbNhan
            // 
            this.rdbNhan.AutoSize = true;
            this.rdbNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNhan.Location = new System.Drawing.Point(6, 38);
            this.rdbNhan.Name = "rdbNhan";
            this.rdbNhan.Size = new System.Drawing.Size(204, 29);
            this.rdbNhan.TabIndex = 0;
            this.rdbNhan.TabStop = true;
            this.rdbNhan.Text = "Đã nhận được hàng";
            this.rdbNhan.UseVisualStyleBackColor = true;
            // 
            // dgvGioHang
            // 
            this.dgvGioHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGioHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvGioHang.Location = new System.Drawing.Point(15, 88);
            this.dgvGioHang.Name = "dgvGioHang";
            this.dgvGioHang.RowHeadersWidth = 51;
            this.dgvGioHang.RowTemplate.Height = 24;
            this.dgvGioHang.Size = new System.Drawing.Size(794, 178);
            this.dgvGioHang.TabIndex = 4;
            this.dgvGioHang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGioHang_CellContentClick);
            this.dgvGioHang.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGioHang_RowEnter);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "MaLK";
            this.Column1.HeaderText = "Mã LK";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenLK";
            this.Column2.HeaderText = "Tên LK";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "LoaiLK";
            this.Column3.HeaderText = "Loại LK";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "SoLuong";
            this.Column4.HeaderText = "Số Lượng";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "HangLK";
            this.Column5.HeaderText = "Hãng";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Gia";
            this.Column6.HeaderText = "Giá";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lb.Location = new System.Drawing.Point(680, 43);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(0, 16);
            this.lb.TabIndex = 6;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(583, 43);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(69, 16);
            this.lblTongTien.TabIndex = 5;
            this.lblTongTien.Text = "Tổng Tiền";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvGioHang);
            this.groupBox1.Controls.Add(this.lb);
            this.groupBox1.Controls.Add(this.lblTongTien);
            this.groupBox1.Location = new System.Drawing.Point(31, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(852, 272);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(561, 45);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 8;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(561, 95);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 24);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // FGioHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 513);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grbTTDH);
            this.Name = "FGioHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giỏ Hàng";
            this.Load += new System.EventHandler(this.FGioHang_Load);
            this.grbTTDH.ResumeLayout(false);
            this.grbTTDH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGioHang)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox grbTTDH;
        private System.Windows.Forms.RadioButton rdbDangGiao;
        private System.Windows.Forms.RadioButton rdbNhan;
        private System.Windows.Forms.DataGridView dgvGioHang;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnXoa;
    }
}