namespace QLLKDienTu
{
    partial class FMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.thôngTinToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hổTrợToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hóaĐơnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.giỏHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvDSLK = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemGioHang = new System.Windows.Forms.Button();
            this.txtTimLK = new System.Windows.Forms.TextBox();
            this.cbbLK = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLK)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thôngTinToolStripMenuItem,
            this.hổTrợToolStripMenuItem,
            this.hóaĐơnToolStripMenuItem,
            this.giỏHàngToolStripMenuItem,
            this.đăngXuấtToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(975, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // thôngTinToolStripMenuItem
            // 
            this.thôngTinToolStripMenuItem.Name = "thôngTinToolStripMenuItem";
            this.thôngTinToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.thôngTinToolStripMenuItem.Text = "Thông Tin";
            this.thôngTinToolStripMenuItem.Click += new System.EventHandler(this.thôngTinToolStripMenuItem_Click);
            // 
            // hổTrợToolStripMenuItem
            // 
            this.hổTrợToolStripMenuItem.Name = "hổTrợToolStripMenuItem";
            this.hổTrợToolStripMenuItem.Size = new System.Drawing.Size(68, 24);
            this.hổTrợToolStripMenuItem.Text = "Hổ Trợ";
            // 
            // hóaĐơnToolStripMenuItem
            // 
            this.hóaĐơnToolStripMenuItem.Name = "hóaĐơnToolStripMenuItem";
            this.hóaĐơnToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.hóaĐơnToolStripMenuItem.Text = "Hóa đơn";
            this.hóaĐơnToolStripMenuItem.Click += new System.EventHandler(this.hóaĐơnToolStripMenuItem_Click);
            // 
            // giỏHàngToolStripMenuItem
            // 
            this.giỏHàngToolStripMenuItem.Name = "giỏHàngToolStripMenuItem";
            this.giỏHàngToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.giỏHàngToolStripMenuItem.Text = "Giỏ Hàng";
            this.giỏHàngToolStripMenuItem.Click += new System.EventHandler(this.giỏHàngToolStripMenuItem_Click);
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng Xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.đăngXuấtToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // dgvDSLK
            // 
            this.dgvDSLK.BackgroundColor = System.Drawing.Color.Salmon;
            this.dgvDSLK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSLK.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvDSLK.Location = new System.Drawing.Point(0, 219);
            this.dgvDSLK.Name = "dgvDSLK";
            this.dgvDSLK.RowHeadersWidth = 51;
            this.dgvDSLK.RowTemplate.Height = 24;
            this.dgvDSLK.Size = new System.Drawing.Size(963, 308);
            this.dgvDSLK.TabIndex = 2;
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
            // btnThemGioHang
            // 
            this.btnThemGioHang.Location = new System.Drawing.Point(806, 31);
            this.btnThemGioHang.Name = "btnThemGioHang";
            this.btnThemGioHang.Size = new System.Drawing.Size(157, 36);
            this.btnThemGioHang.TabIndex = 3;
            this.btnThemGioHang.Text = "Thêm vào giỏ hàng";
            this.btnThemGioHang.UseVisualStyleBackColor = true;
            this.btnThemGioHang.Click += new System.EventHandler(this.btnThemGioHang_Click);
            // 
            // txtTimLK
            // 
            this.txtTimLK.Location = new System.Drawing.Point(447, 48);
            this.txtTimLK.Name = "txtTimLK";
            this.txtTimLK.Size = new System.Drawing.Size(254, 22);
            this.txtTimLK.TabIndex = 6;
            this.txtTimLK.TextChanged += new System.EventHandler(this.Sort);
            // 
            // cbbLK
            // 
            this.cbbLK.FormattingEnabled = true;
            this.cbbLK.Items.AddRange(new object[] {
            "Mã",
            "Tên",
            "Loại",
            "Số Lượng",
            "Hãng",
            "Giá"});
            this.cbbLK.Location = new System.Drawing.Point(274, 46);
            this.cbbLK.Name = "cbbLK";
            this.cbbLK.Size = new System.Drawing.Size(167, 24);
            this.cbbLK.TabIndex = 7;
            this.cbbLK.SelectedIndexChanged += new System.EventHandler(this.cbbLK_SelectedIndexChanged);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 539);
            this.Controls.Add(this.cbbLK);
            this.Controls.Add(this.txtTimLK);
            this.Controls.Add(this.btnThemGioHang);
            this.Controls.Add(this.dgvDSLK);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.Load += new System.EventHandler(this.FMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSLK)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem thôngTinToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hổTrợToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hóaĐơnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem giỏHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvDSLK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Button btnThemGioHang;
        private System.Windows.Forms.TextBox txtTimLK;
        private System.Windows.Forms.ComboBox cbbLK;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
    }
}