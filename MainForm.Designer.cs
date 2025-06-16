namespace StudentManager
{
    partial class MainForm
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
            Label_Title = new Label();
            panel2 = new Panel();
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            lsvDSLop = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            groupBox2 = new GroupBox();
            button1 = new Button();
            btnExit = new Button();
            btnShowClass = new Button();
            columnHeader4 = new ColumnHeader();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // Label_Title
            // 
            Label_Title.BackColor = Color.Transparent;
            Label_Title.Dock = DockStyle.Fill;
            Label_Title.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            Label_Title.Location = new Point(0, 0);
            Label_Title.Name = "Label_Title";
            Label_Title.Size = new Size(781, 68);
            Label_Title.TabIndex = 0;
            Label_Title.Text = "QUẢN LÝ LỚP HỌC";
            Label_Title.TextAlign = ContentAlignment.MiddleCenter;
            Label_Title.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(Label_Title);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(781, 68);
            panel2.TabIndex = 2;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 68);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Size = new Size(781, 505);
            splitContainer1.SplitterDistance = 512;
            splitContainer1.TabIndex = 3;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(lsvDSLop);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(512, 505);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Danh sách các lớp";
            groupBox1.Enter += groupBox1_Enter_1;
            // 
            // lsvDSLop
            // 
            lsvDSLop.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            lsvDSLop.Dock = DockStyle.Fill;
            lsvDSLop.FullRowSelect = true;
            lsvDSLop.GridLines = true;
            lsvDSLop.Location = new Point(3, 19);
            lsvDSLop.Name = "lsvDSLop";
            lsvDSLop.Size = new Size(506, 483);
            lsvDSLop.TabIndex = 0;
            lsvDSLop.UseCompatibleStateImageBehavior = false;
            lsvDSLop.View = View.Details;
            lsvDSLop.SelectedIndexChanged += lsvDSLop_SelectedIndexChanged;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Mã Lớp";
            columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Tên Lớp";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Nhân Viên Quản Lý";
            columnHeader3.Width = 150;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Controls.Add(btnExit);
            groupBox2.Controls.Add(btnShowClass);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(265, 505);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Chức năng";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(9, 115);
            button1.Name = "button1";
            button1.Size = new Size(229, 46);
            button1.TabIndex = 2;
            button1.Text = "Nhập điểm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = SystemColors.ActiveCaption;
            btnExit.Location = new Point(9, 191);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(229, 46);
            btnExit.TabIndex = 1;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnShowClass
            // 
            btnShowClass.BackColor = SystemColors.ActiveCaption;
            btnShowClass.Location = new Point(9, 39);
            btnShowClass.Name = "btnShowClass";
            btnShowClass.Size = new Size(229, 46);
            btnShowClass.TabIndex = 0;
            btnShowClass.Text = "Xem Chi Tiết";
            btnShowClass.UseVisualStyleBackColor = false;
            btnShowClass.Click += btnShowClass_Click;
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Mã Nhân Viên";
            columnHeader4.Width = 100;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(781, 573);
            Controls.Add(splitContainer1);
            Controls.Add(panel2);
            Name = "MainForm";
            Text = "Quản Lý Lớp Học";
            Load += MainForm_Load;
            panel2.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label Label_Title;
        private Panel panel2;
        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        internal ListView lsvDSLop;
        private GroupBox groupBox2;
        private Button btnShowClass;
        private Button btnExit;
        private Button button1;
        private ColumnHeader columnHeader4;
    }
}