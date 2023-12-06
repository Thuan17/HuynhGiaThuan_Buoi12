namespace _2001207369_HuynhGiaThuan_KiemTra
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaPhongHoiNghi = new System.Windows.Forms.TextBox();
            this.txtTenHoiNghi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbxLoaiPhong = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_LocDuLieu = new System.Windows.Forms.Button();
            this.DGV_HoiNghi = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_HoiNghi)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(146, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(452, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "-THÔNG TIN PHÒNG HỘI NGHỊ-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "MÃ PHÒNG HỘI NGHỊ";
            // 
            // txtMaPhongHoiNghi
            // 
            this.txtMaPhongHoiNghi.Location = new System.Drawing.Point(215, 76);
            this.txtMaPhongHoiNghi.Name = "txtMaPhongHoiNghi";
            this.txtMaPhongHoiNghi.Size = new System.Drawing.Size(494, 22);
            this.txtMaPhongHoiNghi.TabIndex = 2;
            // 
            // txtTenHoiNghi
            // 
            this.txtTenHoiNghi.Location = new System.Drawing.Point(215, 122);
            this.txtTenHoiNghi.Name = "txtTenHoiNghi";
            this.txtTenHoiNghi.Size = new System.Drawing.Size(494, 22);
            this.txtTenHoiNghi.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "TÊN HỘI NGHỊ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "LOẠI PHÒNG HỘI NGHỊ";
            // 
            // cbxLoaiPhong
            // 
            this.cbxLoaiPhong.FormattingEnabled = true;
            this.cbxLoaiPhong.Location = new System.Drawing.Point(214, 161);
            this.cbxLoaiPhong.Name = "cbxLoaiPhong";
            this.cbxLoaiPhong.Size = new System.Drawing.Size(204, 24);
            this.cbxLoaiPhong.TabIndex = 6;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(580, 164);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(129, 22);
            this.txtSoLuong.TabIndex = 8;
            this.txtSoLuong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSoLuong_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(450, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số người tham gia";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(58, 206);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(89, 32);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Thêm Mới";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(171, 206);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(129, 32);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "Lưu thông tin";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(329, 206);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(129, 32);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Xóa phòng HN";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(487, 206);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(89, 32);
            this.btnEnd.TabIndex = 12;
            this.btnEnd.Text = "Kết thúc";
            this.btnEnd.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGV_HoiNghi);
            this.groupBox1.Location = new System.Drawing.Point(12, 244);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(728, 300);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = " Danh Sách Phòng Hội Nghị";
            // 
            // btn_LocDuLieu
            // 
            this.btn_LocDuLieu.Location = new System.Drawing.Point(378, 576);
            this.btn_LocDuLieu.Name = "btn_LocDuLieu";
            this.btn_LocDuLieu.Size = new System.Drawing.Size(292, 32);
            this.btn_LocDuLieu.TabIndex = 14;
            this.btn_LocDuLieu.Text = "Lọc dữ liệu";
            this.btn_LocDuLieu.UseVisualStyleBackColor = true;
            this.btn_LocDuLieu.Click += new System.EventHandler(this.btn_LocDuLieu_Click);
            // 
            // DGV_HoiNghi
            // 
            this.DGV_HoiNghi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_HoiNghi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV_HoiNghi.Location = new System.Drawing.Point(3, 18);
            this.DGV_HoiNghi.Name = "DGV_HoiNghi";
            this.DGV_HoiNghi.RowHeadersWidth = 51;
            this.DGV_HoiNghi.RowTemplate.Height = 24;
            this.DGV_HoiNghi.Size = new System.Drawing.Size(722, 279);
            this.DGV_HoiNghi.TabIndex = 0;
            this.DGV_HoiNghi.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGV_HoiNghi_CellClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 620);
            this.Controls.Add(this.btn_LocDuLieu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbxLoaiPhong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTenHoiNghi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaPhongHoiNghi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_HoiNghi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMaPhongHoiNghi;
        private System.Windows.Forms.TextBox txtTenHoiNghi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbxLoaiPhong;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_LocDuLieu;
        private System.Windows.Forms.DataGridView DGV_HoiNghi;
    }
}

