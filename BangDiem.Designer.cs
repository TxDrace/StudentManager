namespace StudentManager
{
    partial class BangDiem
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
            splitContainer2 = new SplitContainer();
            groupBox4 = new GroupBox();
            treeClassList = new TreeView();
            splitContainer1 = new SplitContainer();
            groupBox3 = new GroupBox();
            listViewBANGDIEM = new ListView();
            StudentID = new ColumnHeader();
            TENSV = new ColumnHeader();
            TENHP = new ColumnHeader();
            CourseID = new ColumnHeader();
            DIEMTHI = new ColumnHeader();
            splitContainer4 = new SplitContainer();
            groupBox2 = new GroupBox();
            cbbCourseID = new ComboBox();
            cbbHoTen = new ComboBox();
            cbbMaSV = new ComboBox();
            label7 = new Label();
            textBoxDIEM = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            btnRemoveScore = new Button();
            btnAddScore = new Button();
            btnEditScore = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(1012, 74);
            label1.TabIndex = 0;
            label1.Text = "BẢNG ĐIỂM";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1012, 74);
            panel1.TabIndex = 3;
            panel1.Paint += splitContainer3_Panel1_Paint;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 74);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(groupBox4);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(splitContainer1);
            splitContainer2.Size = new Size(1012, 448);
            splitContainer2.SplitterDistance = 132;
            splitContainer2.TabIndex = 5;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(treeClassList);
            groupBox4.Dock = DockStyle.Fill;
            groupBox4.Location = new Point(0, 0);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(132, 448);
            groupBox4.TabIndex = 1;
            groupBox4.TabStop = false;
            groupBox4.Text = "Danh sách lớp";
            // 
            // treeClassList
            // 
            treeClassList.Dock = DockStyle.Fill;
            treeClassList.Location = new Point(3, 19);
            treeClassList.Name = "treeClassList";
            treeClassList.Size = new Size(126, 426);
            treeClassList.TabIndex = 0;
            treeClassList.AfterSelect += treeClassList_AfterSelect;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox3);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer4);
            splitContainer1.Size = new Size(876, 448);
            splitContainer1.SplitterDistance = 573;
            splitContainer1.TabIndex = 4;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(listViewBANGDIEM);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(573, 448);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Thông tin bảng điểm";
            groupBox3.Enter += groupBox3_Enter;
            // 
            // listViewBANGDIEM
            // 
            listViewBANGDIEM.Columns.AddRange(new ColumnHeader[] { StudentID, TENSV, TENHP, CourseID, DIEMTHI });
            listViewBANGDIEM.Dock = DockStyle.Fill;
            listViewBANGDIEM.FullRowSelect = true;
            listViewBANGDIEM.GridLines = true;
            listViewBANGDIEM.Location = new Point(3, 19);
            listViewBANGDIEM.Margin = new Padding(3, 2, 3, 2);
            listViewBANGDIEM.Name = "listViewBANGDIEM";
            listViewBANGDIEM.Size = new Size(567, 426);
            listViewBANGDIEM.TabIndex = 0;
            listViewBANGDIEM.UseCompatibleStateImageBehavior = false;
            listViewBANGDIEM.View = View.Details;
            listViewBANGDIEM.SelectedIndexChanged += listViewBANGDIEM_SelectedIndexChanged;
            // 
            // StudentID
            // 
            StudentID.Text = "Mã SV";
            // 
            // TENSV
            // 
            TENSV.Text = "Họ Tên";
            TENSV.Width = 120;
            // 
            // TENHP
            // 
            TENHP.Text = "Mã HP";
            TENHP.Width = 80;
            // 
            // CourseID
            // 
            CourseID.Text = "Tên HP";
            CourseID.Width = 120;
            // 
            // DIEMTHI
            // 
            DIEMTHI.Text = "Điểm";
            DIEMTHI.Width = 180;
            // 
            // splitContainer4
            // 
            splitContainer4.Dock = DockStyle.Fill;
            splitContainer4.Location = new Point(0, 0);
            splitContainer4.Name = "splitContainer4";
            splitContainer4.Orientation = Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            splitContainer4.Panel1.Controls.Add(groupBox2);
            // 
            // splitContainer4.Panel2
            // 
            splitContainer4.Panel2.Controls.Add(groupBox1);
            splitContainer4.Size = new Size(299, 448);
            splitContainer4.SplitterDistance = 203;
            splitContainer4.TabIndex = 3;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(cbbCourseID);
            groupBox2.Controls.Add(cbbHoTen);
            groupBox2.Controls.Add(cbbMaSV);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(textBoxDIEM);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(299, 203);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Nhập bảng điểm";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // cbbCourseID
            // 
            cbbCourseID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbCourseID.FormattingEnabled = true;
            cbbCourseID.Location = new Point(118, 119);
            cbbCourseID.Name = "cbbCourseID";
            cbbCourseID.Size = new Size(175, 23);
            cbbCourseID.TabIndex = 0;
            cbbCourseID.SelectedIndexChanged += cbbCourseID_SelectedIndexChanged;
            // 
            // cbbHoTen
            // 
            cbbHoTen.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbHoTen.FormattingEnabled = true;
            cbbHoTen.Location = new Point(118, 77);
            cbbHoTen.Name = "cbbHoTen";
            cbbHoTen.Size = new Size(175, 23);
            cbbHoTen.TabIndex = 12;
            cbbHoTen.SelectedIndexChanged += cbbHoTen_SelectedIndexChanged;
            // 
            // cbbMaSV
            // 
            cbbMaSV.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbMaSV.FormattingEnabled = true;
            cbbMaSV.Location = new Point(118, 35);
            cbbMaSV.Name = "cbbMaSV";
            cbbMaSV.Size = new Size(175, 23);
            cbbMaSV.TabIndex = 11;
            cbbMaSV.SelectedIndexChanged += cbbMaSV_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(19, 80);
            label7.Name = "label7";
            label7.Size = new Size(44, 15);
            label7.TabIndex = 10;
            label7.Text = "Họ Tên";
            label7.Click += label7_Click;
            // 
            // textBoxDIEM
            // 
            textBoxDIEM.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBoxDIEM.Location = new Point(118, 161);
            textBoxDIEM.Margin = new Padding(3, 2, 3, 2);
            textBoxDIEM.Name = "textBoxDIEM";
            textBoxDIEM.Size = new Size(175, 23);
            textBoxDIEM.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(19, 164);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 5;
            label6.Text = "Điểm:";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(94, 69);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 122);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 3;
            label4.Text = "Mã Học Phần:";
            label4.Click += label4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(94, 38);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 38);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 1;
            label2.Text = "Mã Sinh Viên:";
            label2.Click += label2_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRemoveScore);
            groupBox1.Controls.Add(btnAddScore);
            groupBox1.Controls.Add(btnEditScore);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(299, 241);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Chức năng";
            // 
            // btnRemoveScore
            // 
            btnRemoveScore.BackColor = SystemColors.ActiveCaption;
            btnRemoveScore.Location = new Point(43, 178);
            btnRemoveScore.Name = "btnRemoveScore";
            btnRemoveScore.Size = new Size(229, 46);
            btnRemoveScore.TabIndex = 6;
            btnRemoveScore.Text = "Xóa";
            btnRemoveScore.UseVisualStyleBackColor = false;
            btnRemoveScore.Click += btnRemoveScore_Click;
            // 
            // btnAddScore
            // 
            btnAddScore.BackColor = SystemColors.ActiveCaption;
            btnAddScore.Location = new Point(43, 112);
            btnAddScore.Name = "btnAddScore";
            btnAddScore.Size = new Size(229, 46);
            btnAddScore.TabIndex = 5;
            btnAddScore.Text = "Thêm";
            btnAddScore.UseVisualStyleBackColor = false;
            btnAddScore.Click += btnAddScore_Click;
            // 
            // btnEditScore
            // 
            btnEditScore.BackColor = SystemColors.ActiveCaption;
            btnEditScore.Location = new Point(43, 46);
            btnEditScore.Name = "btnEditScore";
            btnEditScore.Size = new Size(229, 46);
            btnEditScore.TabIndex = 4;
            btnEditScore.Text = "Chỉnh Sửa";
            btnEditScore.UseVisualStyleBackColor = false;
            btnEditScore.Click += btnEditScore_Click;
            // 
            // BangDiem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1012, 522);
            Controls.Add(splitContainer2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "BangDiem";
            Text = "Bảng điểm";
            Load += BangDiem_Load;
            panel1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private ColumnHeader MASV;
        private ColumnHeader MAHP;
        private Panel panel1;
        private SplitContainer splitContainer2;
        private GroupBox groupBox4;
        private TreeView treeView1;
        private TreeView treeClassList;
        private SplitContainer splitContainer1;
        private GroupBox groupBox3;
        private ListView listViewBANGDIEM;
        private ColumnHeader StudentID;
        private ColumnHeader TENSV;
        private ColumnHeader TENHP;
        private ColumnHeader DIEMTHI;
        private SplitContainer splitContainer4;
        private GroupBox groupBox2;
        private ComboBox cbbCourseID;
        private ComboBox cbbHoTen;
        private ComboBox cbbMaSV;
        private Label label7;
        private TextBox textBoxDIEM;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox1;
        private Button btnRemoveScore;
        private Button btnAddScore;
        private Button btnEditScore;
        private ColumnHeader CourseID;
    }
}