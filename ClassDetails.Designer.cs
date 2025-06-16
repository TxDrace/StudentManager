namespace StudentManager
{
    partial class ClassDetails
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
            label1 = new Label();
            panel1 = new Panel();
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            lsvDsSinhVien = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            columnHeader5 = new ColumnHeader();
            splitContainer2 = new SplitContainer();
            groupBox2 = new GroupBox();
            dtBirthday = new DateTimePicker();
            textBoxMK = new TextBox();
            label3 = new Label();
            textBoxTenDN = new TextBox();
            labelTenDangNhap = new Label();
            textBoxDiaChi = new TextBox();
            textBoxHoTen = new TextBox();
            labelDiaChi = new Label();
            labelNgaySinh = new Label();
            labelHoTen = new Label();
            textboxMaSV = new TextBox();
            labelMaSV = new Label();
            groupBox3 = new GroupBox();
            btnRemoveStudent = new Button();
            btnAddStudent = new Button();
            btnEditStudent = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(914, 62);
            label1.TabIndex = 0;
            label1.Text = "THÔNG TIN LỚP HỌC";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(914, 62);
            panel1.TabIndex = 1;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 62);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(914, 529);
            splitContainer1.SplitterDistance = 620;
            splitContainer1.TabIndex = 2;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lsvDsSinhVien);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(620, 529);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách sinh viên";
            // 
            // lsvDsSinhVien
            // 
            lsvDsSinhVien.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4, columnHeader5 });
            lsvDsSinhVien.Dock = DockStyle.Fill;
            lsvDsSinhVien.FullRowSelect = true;
            lsvDsSinhVien.GridLines = true;
            lsvDsSinhVien.Location = new Point(3, 19);
            lsvDsSinhVien.Name = "lsvDsSinhVien";
            lsvDsSinhVien.Size = new Size(614, 507);
            lsvDsSinhVien.TabIndex = 0;
            lsvDsSinhVien.UseCompatibleStateImageBehavior = false;
            lsvDsSinhVien.View = View.Details;
            lsvDsSinhVien.SelectedIndexChanged += lsvDsSinhVien_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mã SV";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Họ Tên";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Ngày Sinh";
            columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Địa Chỉ";
            columnHeader4.Width = 150;
            // 
            // columnHeader5
            // 
            columnHeader5.Text = "Tên Đăng Nhập";
            columnHeader5.Width = 150;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(groupBox2);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(groupBox3);
            splitContainer2.Size = new Size(290, 529);
            splitContainer2.SplitterDistance = 301;
            splitContainer2.TabIndex = 0;
            splitContainer2.SplitterMoved += splitContainer2_SplitterMoved;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtBirthday);
            groupBox2.Controls.Add(textBoxMK);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(textBoxTenDN);
            groupBox2.Controls.Add(labelTenDangNhap);
            groupBox2.Controls.Add(textBoxDiaChi);
            groupBox2.Controls.Add(textBoxHoTen);
            groupBox2.Controls.Add(labelDiaChi);
            groupBox2.Controls.Add(labelNgaySinh);
            groupBox2.Controls.Add(labelHoTen);
            groupBox2.Controls.Add(textboxMaSV);
            groupBox2.Controls.Add(labelMaSV);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(290, 301);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chỉnh sửa thông tin";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // dtBirthday
            // 
            dtBirthday.Checked = false;
            dtBirthday.Format = DateTimePickerFormat.Custom;
            dtBirthday.ImeMode = ImeMode.NoControl;
            dtBirthday.Location = new Point(106, 118);
            dtBirthday.Name = "dtBirthday";
            dtBirthday.RightToLeft = RightToLeft.No;
            dtBirthday.Size = new Size(170, 23);
            dtBirthday.TabIndex = 12;
            dtBirthday.Value = new DateTime(2024, 3, 14, 14, 49, 58, 0);
            dtBirthday.ValueChanged += dtBirthday_ValueChanged;
            // 
            // textBoxMK
            // 
            textBoxMK.Location = new Point(106, 241);
            textBoxMK.Name = "textBoxMK";
            textBoxMK.Size = new Size(170, 23);
            textBoxMK.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 244);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 10;
            label3.Text = "Mật Khẩu:";
            label3.Click += label3_Click;
            // 
            // textBoxTenDN
            // 
            textBoxTenDN.Location = new Point(106, 200);
            textBoxTenDN.Name = "textBoxTenDN";
            textBoxTenDN.Size = new Size(170, 23);
            textBoxTenDN.TabIndex = 9;
            // 
            // labelTenDangNhap
            // 
            labelTenDangNhap.AutoSize = true;
            labelTenDangNhap.Location = new Point(6, 203);
            labelTenDangNhap.Name = "labelTenDangNhap";
            labelTenDangNhap.Size = new Size(91, 15);
            labelTenDangNhap.TabIndex = 8;
            labelTenDangNhap.Text = "Tên Đăng Nhập:";
            labelTenDangNhap.Click += label2_Click;
            // 
            // textBoxDiaChi
            // 
            textBoxDiaChi.Location = new Point(106, 160);
            textBoxDiaChi.Name = "textBoxDiaChi";
            textBoxDiaChi.Size = new Size(170, 23);
            textBoxDiaChi.TabIndex = 7;
            // 
            // textBoxHoTen
            // 
            textBoxHoTen.Location = new Point(106, 82);
            textBoxHoTen.Name = "textBoxHoTen";
            textBoxHoTen.Size = new Size(170, 23);
            textBoxHoTen.TabIndex = 5;
            // 
            // labelDiaChi
            // 
            labelDiaChi.AutoSize = true;
            labelDiaChi.Location = new Point(6, 163);
            labelDiaChi.Name = "labelDiaChi";
            labelDiaChi.Size = new Size(48, 15);
            labelDiaChi.TabIndex = 4;
            labelDiaChi.Text = "Địa Chỉ:";
            // 
            // labelNgaySinh
            // 
            labelNgaySinh.AutoSize = true;
            labelNgaySinh.Location = new Point(6, 124);
            labelNgaySinh.Name = "labelNgaySinh";
            labelNgaySinh.Size = new Size(64, 15);
            labelNgaySinh.TabIndex = 3;
            labelNgaySinh.Text = "Ngày Sinh:";
            // 
            // labelHoTen
            // 
            labelHoTen.AutoSize = true;
            labelHoTen.Location = new Point(6, 85);
            labelHoTen.Name = "labelHoTen";
            labelHoTen.Size = new Size(47, 15);
            labelHoTen.TabIndex = 2;
            labelHoTen.Text = "Họ Tên:";
            // 
            // textboxMaSV
            // 
            textboxMaSV.Location = new Point(106, 43);
            textboxMaSV.Name = "textboxMaSV";
            textboxMaSV.Size = new Size(170, 23);
            textboxMaSV.TabIndex = 1;
            // 
            // labelMaSV
            // 
            labelMaSV.AutoSize = true;
            labelMaSV.Location = new Point(6, 46);
            labelMaSV.Name = "labelMaSV";
            labelMaSV.Size = new Size(40, 15);
            labelMaSV.TabIndex = 0;
            labelMaSV.Text = "MaSV:";
            labelMaSV.Click += labelMaSV_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnRemoveStudent);
            groupBox3.Controls.Add(btnAddStudent);
            groupBox3.Controls.Add(btnEditStudent);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(290, 224);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Chức năng";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // btnRemoveStudent
            // 
            btnRemoveStudent.BackColor = SystemColors.ActiveCaption;
            btnRemoveStudent.Location = new Point(23, 164);
            btnRemoveStudent.Name = "btnRemoveStudent";
            btnRemoveStudent.Size = new Size(229, 46);
            btnRemoveStudent.TabIndex = 3;
            btnRemoveStudent.Text = "Xóa";
            btnRemoveStudent.UseVisualStyleBackColor = false;
            btnRemoveStudent.Click += btnRemoveStudent_Click;
            // 
            // btnAddStudent
            // 
            btnAddStudent.BackColor = SystemColors.ActiveCaption;
            btnAddStudent.Location = new Point(23, 98);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(229, 46);
            btnAddStudent.TabIndex = 2;
            btnAddStudent.Text = "Thêm";
            btnAddStudent.UseVisualStyleBackColor = false;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnEditStudent
            // 
            btnEditStudent.BackColor = SystemColors.ActiveCaption;
            btnEditStudent.Location = new Point(23, 32);
            btnEditStudent.Name = "btnEditStudent";
            btnEditStudent.Size = new Size(229, 46);
            btnEditStudent.TabIndex = 1;
            btnEditStudent.Text = "Chỉnh Sửa";
            btnEditStudent.UseVisualStyleBackColor = false;
            btnEditStudent.Click += btnEditStudent_Click;
            // 
            // ClassDetails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 591);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            Name = "ClassDetails";
            Text = "Thông tin lớp học";
            Load += ClassDetails_Load;
            panel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private GroupBox groupBox1;
        private ListView lsvDsSinhVien;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label labelMaSV;
        private Label labelDiaChi;
        private Label labelNgaySinh;
        private Label labelHoTen;
        private TextBox textboxMaSV;
        private TextBox textBoxDiaChi;
        private TextBox textBoxHoTen;
        private Button btnRemoveStudent;
        private Button btnAddStudent;
        private Button btnEditStudent;
        private TextBox textBoxMK;
        private Label label3;
        private TextBox textBoxTenDN;
        private Label labelTenDangNhap;
        private ColumnHeader columnHeader5;
        private DateTimePicker dtBirthday;
    }
}