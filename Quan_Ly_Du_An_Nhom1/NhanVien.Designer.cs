
namespace Quan_Ly_Du_An_Nhom1
{
    partial class NhanVien
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbCheckViTri = new System.Windows.Forms.RadioButton();
            this.rdbCheckSDT = new System.Windows.Forms.RadioButton();
            this.rdbCheckTenNV = new System.Windows.Forms.RadioButton();
            this.rdbCheckMaNV = new System.Windows.Forms.RadioButton();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dateNgaySinh = new System.Windows.Forms.DateTimePicker();
            this.lblSDT = new System.Windows.Forms.Label();
            this.lblNgaySinh = new System.Windows.Forms.Label();
            this.lblDiaChi = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblMaKH = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaNV = new System.Windows.Forms.TextBox();
            this.dgvDataView = new System.Windows.Forms.DataGridView();
            this.txtVitri = new System.Windows.Forms.TextBox();
            this.lblVitri = new System.Windows.Forms.Label();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.lblLuong = new System.Windows.Forms.Label();
            this.rdbCheckChucVu = new System.Windows.Forms.RadioButton();
            this.rdbCheckAll = new System.Windows.Forms.RadioButton();
            this.cbbChucVu = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnEdit);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(499, 38);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(401, 245);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chức năng";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbCheckViTri);
            this.panel1.Controls.Add(this.rdbCheckSDT);
            this.panel1.Controls.Add(this.rdbCheckAll);
            this.panel1.Controls.Add(this.rdbCheckChucVu);
            this.panel1.Controls.Add(this.rdbCheckTenNV);
            this.panel1.Controls.Add(this.rdbCheckMaNV);
            this.panel1.Location = new System.Drawing.Point(6, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(389, 99);
            this.panel1.TabIndex = 14;
            // 
            // rdbCheckViTri
            // 
            this.rdbCheckViTri.AutoSize = true;
            this.rdbCheckViTri.Location = new System.Drawing.Point(130, 54);
            this.rdbCheckViTri.Name = "rdbCheckViTri";
            this.rdbCheckViTri.Size = new System.Drawing.Size(47, 17);
            this.rdbCheckViTri.TabIndex = 13;
            this.rdbCheckViTri.Text = "Vị trí";
            this.rdbCheckViTri.UseVisualStyleBackColor = true;
            // 
            // rdbCheckSDT
            // 
            this.rdbCheckSDT.AutoSize = true;
            this.rdbCheckSDT.Location = new System.Drawing.Point(21, 54);
            this.rdbCheckSDT.Name = "rdbCheckSDT";
            this.rdbCheckSDT.Size = new System.Drawing.Size(88, 17);
            this.rdbCheckSDT.TabIndex = 13;
            this.rdbCheckSDT.Text = "Số điện thoại";
            this.rdbCheckSDT.UseVisualStyleBackColor = true;
            // 
            // rdbCheckTenNV
            // 
            this.rdbCheckTenNV.AutoSize = true;
            this.rdbCheckTenNV.Location = new System.Drawing.Point(130, 9);
            this.rdbCheckTenNV.Name = "rdbCheckTenNV";
            this.rdbCheckTenNV.Size = new System.Drawing.Size(96, 17);
            this.rdbCheckTenNV.TabIndex = 13;
            this.rdbCheckTenNV.Text = "Tên Nhân viên";
            this.rdbCheckTenNV.UseVisualStyleBackColor = true;
            // 
            // rdbCheckMaNV
            // 
            this.rdbCheckMaNV.AutoSize = true;
            this.rdbCheckMaNV.Location = new System.Drawing.Point(21, 9);
            this.rdbCheckMaNV.Name = "rdbCheckMaNV";
            this.rdbCheckMaNV.Size = new System.Drawing.Size(92, 17);
            this.rdbCheckMaNV.TabIndex = 13;
            this.rdbCheckMaNV.Text = "Mã Nhân viên";
            this.rdbCheckMaNV.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(27, 191);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(165, 48);
            this.txtSearch.TabIndex = 11;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(227, 191);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 31);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(231, 28);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 34);
            this.btnDelete.TabIndex = 10;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(134, 28);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 34);
            this.btnEdit.TabIndex = 9;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(38, 28);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 34);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dateNgaySinh
            // 
            this.dateNgaySinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dateNgaySinh.Location = new System.Drawing.Point(196, 90);
            this.dateNgaySinh.Name = "dateNgaySinh";
            this.dateNgaySinh.Size = new System.Drawing.Size(200, 20);
            this.dateNgaySinh.TabIndex = 18;
            // 
            // lblSDT
            // 
            this.lblSDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblSDT.AutoSize = true;
            this.lblSDT.Location = new System.Drawing.Point(82, 149);
            this.lblSDT.Name = "lblSDT";
            this.lblSDT.Size = new System.Drawing.Size(71, 13);
            this.lblSDT.TabIndex = 19;
            this.lblSDT.Text = "Số Điện thoại";
            // 
            // lblNgaySinh
            // 
            this.lblNgaySinh.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNgaySinh.AutoSize = true;
            this.lblNgaySinh.Location = new System.Drawing.Point(82, 97);
            this.lblNgaySinh.Name = "lblNgaySinh";
            this.lblNgaySinh.Size = new System.Drawing.Size(56, 13);
            this.lblNgaySinh.TabIndex = 20;
            this.lblNgaySinh.Text = "Ngày Sinh";
            // 
            // lblDiaChi
            // 
            this.lblDiaChi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDiaChi.AutoSize = true;
            this.lblDiaChi.Location = new System.Drawing.Point(82, 123);
            this.lblDiaChi.Name = "lblDiaChi";
            this.lblDiaChi.Size = new System.Drawing.Size(40, 13);
            this.lblDiaChi.TabIndex = 21;
            this.lblDiaChi.Text = "Địa chỉ";
            // 
            // lblHoTen
            // 
            this.lblHoTen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Location = new System.Drawing.Point(82, 71);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(95, 13);
            this.lblHoTen.TabIndex = 22;
            this.lblHoTen.Text = "Họ Tên Nhân viên";
            // 
            // lblMaKH
            // 
            this.lblMaKH.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMaKH.AutoSize = true;
            this.lblMaKH.Location = new System.Drawing.Point(82, 45);
            this.lblMaKH.Name = "lblMaKH";
            this.lblMaKH.Size = new System.Drawing.Size(74, 13);
            this.lblMaKH.TabIndex = 23;
            this.lblMaKH.Text = "Mã Nhân viên";
            // 
            // txtSDT
            // 
            this.txtSDT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSDT.Location = new System.Drawing.Point(196, 142);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(207, 20);
            this.txtSDT.TabIndex = 25;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtDiaChi.Location = new System.Drawing.Point(196, 116);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(207, 20);
            this.txtDiaChi.TabIndex = 24;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtHoTen.Location = new System.Drawing.Point(196, 64);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.Size = new System.Drawing.Size(207, 20);
            this.txtHoTen.TabIndex = 17;
            // 
            // txtMaNV
            // 
            this.txtMaNV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaNV.Location = new System.Drawing.Point(196, 38);
            this.txtMaNV.Name = "txtMaNV";
            this.txtMaNV.Size = new System.Drawing.Size(207, 20);
            this.txtMaNV.TabIndex = 15;
            // 
            // dgvDataView
            // 
            this.dgvDataView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDataView.Location = new System.Drawing.Point(88, 289);
            this.dgvDataView.Name = "dgvDataView";
            this.dgvDataView.Size = new System.Drawing.Size(793, 359);
            this.dgvDataView.TabIndex = 16;
            this.dgvDataView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDataView_CellClick);
            // 
            // txtVitri
            // 
            this.txtVitri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtVitri.Location = new System.Drawing.Point(196, 175);
            this.txtVitri.Name = "txtVitri";
            this.txtVitri.Size = new System.Drawing.Size(207, 20);
            this.txtVitri.TabIndex = 15;
            // 
            // lblVitri
            // 
            this.lblVitri.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblVitri.AutoSize = true;
            this.lblVitri.Location = new System.Drawing.Point(82, 182);
            this.lblVitri.Name = "lblVitri";
            this.lblVitri.Size = new System.Drawing.Size(29, 13);
            this.lblVitri.TabIndex = 23;
            this.lblVitri.Text = "Vị trí";
            // 
            // lblChucVu
            // 
            this.lblChucVu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblChucVu.AutoSize = true;
            this.lblChucVu.Location = new System.Drawing.Point(82, 216);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(47, 13);
            this.lblChucVu.TabIndex = 23;
            this.lblChucVu.Text = "Chức vụ";
            // 
            // txtLuong
            // 
            this.txtLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtLuong.Location = new System.Drawing.Point(196, 240);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(207, 20);
            this.txtLuong.TabIndex = 15;
            // 
            // lblLuong
            // 
            this.lblLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblLuong.AutoSize = true;
            this.lblLuong.Location = new System.Drawing.Point(82, 247);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(37, 13);
            this.lblLuong.TabIndex = 23;
            this.lblLuong.Text = "Lương";
            // 
            // rdbCheckChucVu
            // 
            this.rdbCheckChucVu.AutoSize = true;
            this.rdbCheckChucVu.Location = new System.Drawing.Point(253, 9);
            this.rdbCheckChucVu.Name = "rdbCheckChucVu";
            this.rdbCheckChucVu.Size = new System.Drawing.Size(65, 17);
            this.rdbCheckChucVu.TabIndex = 13;
            this.rdbCheckChucVu.Text = "Chức vụ";
            this.rdbCheckChucVu.UseVisualStyleBackColor = true;
            // 
            // rdbCheckAll
            // 
            this.rdbCheckAll.AutoSize = true;
            this.rdbCheckAll.Checked = true;
            this.rdbCheckAll.Location = new System.Drawing.Point(253, 54);
            this.rdbCheckAll.Name = "rdbCheckAll";
            this.rdbCheckAll.Size = new System.Drawing.Size(56, 17);
            this.rdbCheckAll.TabIndex = 13;
            this.rdbCheckAll.TabStop = true;
            this.rdbCheckAll.Text = "Tất cả";
            this.rdbCheckAll.UseVisualStyleBackColor = true;
            // 
            // cbbChucVu
            // 
            this.cbbChucVu.FormattingEnabled = true;
            this.cbbChucVu.Items.AddRange(new object[] {
            "Quản lý",
            "Kế toán",
            "Nhân viên chiến lược",
            "Nhân viên marketing",
            "free"});
            this.cbbChucVu.Location = new System.Drawing.Point(196, 208);
            this.cbbChucVu.Name = "cbbChucVu";
            this.cbbChucVu.Size = new System.Drawing.Size(207, 21);
            this.cbbChucVu.TabIndex = 27;
            this.cbbChucVu.Text = "Nhân Viên";
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 686);
            this.Controls.Add(this.cbbChucVu);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dateNgaySinh);
            this.Controls.Add(this.lblSDT);
            this.Controls.Add(this.lblNgaySinh);
            this.Controls.Add(this.lblDiaChi);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblLuong);
            this.Controls.Add(this.lblChucVu);
            this.Controls.Add(this.lblVitri);
            this.Controls.Add(this.lblMaKH);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtVitri);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMaNV);
            this.Controls.Add(this.dgvDataView);
            this.Name = "NhanVien";
            this.Text = "NhanVien";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDataView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbCheckViTri;
        private System.Windows.Forms.RadioButton rdbCheckSDT;
        private System.Windows.Forms.RadioButton rdbCheckTenNV;
        private System.Windows.Forms.RadioButton rdbCheckMaNV;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DateTimePicker dateNgaySinh;
        private System.Windows.Forms.Label lblSDT;
        private System.Windows.Forms.Label lblNgaySinh;
        private System.Windows.Forms.Label lblDiaChi;
        private System.Windows.Forms.Label lblHoTen;
        private System.Windows.Forms.Label lblMaKH;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtHoTen;
        private System.Windows.Forms.TextBox txtMaNV;
        private System.Windows.Forms.DataGridView dgvDataView;
        private System.Windows.Forms.TextBox txtVitri;
        private System.Windows.Forms.Label lblVitri;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.RadioButton rdbCheckAll;
        private System.Windows.Forms.RadioButton rdbCheckChucVu;
        private System.Windows.Forms.ComboBox cbbChucVu;
    }
}