namespace StudentManager
{
    partial class HomeForm
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
            employee_btn = new Button();
            Student_btn = new Button();
            label1 = new Label();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            SuspendLayout();
            // 
            // employee_btn
            // 
            employee_btn.Dock = DockStyle.Fill;
            employee_btn.Location = new Point(0, 0);
            employee_btn.Margin = new Padding(20);
            employee_btn.Name = "employee_btn";
            employee_btn.Size = new Size(274, 335);
            employee_btn.TabIndex = 0;
            employee_btn.Text = "Quản Lý Nhân Viên";
            employee_btn.UseVisualStyleBackColor = true;
            employee_btn.Click += employee_btn_Click;
            // 
            // Student_btn
            // 
            Student_btn.AutoSize = true;
            Student_btn.Dock = DockStyle.Fill;
            Student_btn.Location = new Point(0, 0);
            Student_btn.Name = "Student_btn";
            Student_btn.Padding = new Padding(10);
            Student_btn.Size = new Size(272, 335);
            Student_btn.TabIndex = 1;
            Student_btn.Text = "Quản Lý Sinh Viên";
            Student_btn.UseVisualStyleBackColor = true;
            Student_btn.Click += Student_btn_Click;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(550, 73);
            label1.TabIndex = 2;
            label1.Text = "ỨNG DỤNG QUẢNG LÝ NHÂN VIÊN - SINH VIÊN";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(550, 412);
            splitContainer1.SplitterDistance = 73;
            splitContainer1.TabIndex = 3;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(employee_btn);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(Student_btn);
            splitContainer2.Size = new Size(550, 335);
            splitContainer2.SplitterDistance = 274;
            splitContainer2.TabIndex = 2;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(550, 412);
            Controls.Add(splitContainer1);
            Name = "HomeForm";
            Text = "Trang Chủ";
            Load += HomeForm_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button employee_btn;
        private Button Student_btn;
        private Label label1;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
    }
}