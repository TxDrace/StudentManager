namespace StudentManager
{
    partial class EmployeeManagerForm
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
            splitContainer1 = new SplitContainer();
            groupBox1 = new GroupBox();
            txt_Password = new TextBox();
            label4 = new Label();
            txt_Salary = new TextBox();
            label5 = new Label();
            txt_Name = new TextBox();
            label6 = new Label();
            txt_Username = new TextBox();
            label3 = new Label();
            txt_Email = new TextBox();
            label2 = new Label();
            txt_ID = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            splitContainer2 = new SplitContainer();
            btn_Exit = new Button();
            btn_Clear = new Button();
            btn_Edit = new Button();
            btn_Delete = new Button();
            btn_Insert = new Button();
            listView_EmployeeList = new ListView();
            ID = new ColumnHeader();
            FullName = new ColumnHeader();
            Email = new ColumnHeader();
            Salary = new ColumnHeader();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(4, 3, 4, 3);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox2);
            splitContainer1.Size = new Size(917, 573);
            splitContainer1.SplitterDistance = 194;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(txt_Password);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txt_Salary);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(txt_Name);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(txt_Username);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txt_Email);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txt_ID);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(4, 3, 4, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 3, 4, 3);
            groupBox1.Size = new Size(917, 194);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Employee Info";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // txt_Password
            // 
            txt_Password.Location = new Point(565, 142);
            txt_Password.Margin = new Padding(4, 3, 4, 3);
            txt_Password.Name = "txt_Password";
            txt_Password.Size = new Size(326, 23);
            txt_Password.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(486, 145);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(60, 15);
            label4.TabIndex = 10;
            label4.Text = "Password:";
            // 
            // txt_Salary
            // 
            txt_Salary.Location = new Point(565, 90);
            txt_Salary.Margin = new Padding(4, 3, 4, 3);
            txt_Salary.Name = "txt_Salary";
            txt_Salary.Size = new Size(326, 23);
            txt_Salary.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(486, 93);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(41, 15);
            label5.TabIndex = 8;
            label5.Text = "Salary:";
            // 
            // txt_Name
            // 
            txt_Name.Location = new Point(565, 38);
            txt_Name.Margin = new Padding(4, 3, 4, 3);
            txt_Name.Name = "txt_Name";
            txt_Name.Size = new Size(326, 23);
            txt_Name.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(486, 42);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 6;
            label6.Text = "Name:";
            label6.Click += label6_Click;
            // 
            // txt_Username
            // 
            txt_Username.Location = new Point(93, 142);
            txt_Username.Margin = new Padding(4, 3, 4, 3);
            txt_Username.Name = "txt_Username";
            txt_Username.Size = new Size(326, 23);
            txt_Username.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 145);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 4;
            label3.Text = "Username:";
            // 
            // txt_Email
            // 
            txt_Email.Location = new Point(93, 90);
            txt_Email.Margin = new Padding(4, 3, 4, 3);
            txt_Email.Name = "txt_Email";
            txt_Email.Size = new Size(326, 23);
            txt_Email.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 93);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 2;
            label2.Text = "Email:";
            // 
            // txt_ID
            // 
            txt_ID.Location = new Point(93, 38);
            txt_ID.Margin = new Padding(4, 3, 4, 3);
            txt_ID.Name = "txt_ID";
            txt_ID.Size = new Size(326, 23);
            txt_ID.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 42);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(21, 15);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            label1.Click += label1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(splitContainer2);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Margin = new Padding(4, 3, 4, 3);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 3, 4, 3);
            groupBox2.Size = new Size(917, 374);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Employee List";
            groupBox2.Enter += groupBox2_Enter;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(4, 19);
            splitContainer2.Margin = new Padding(4, 3, 4, 3);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(btn_Exit);
            splitContainer2.Panel1.Controls.Add(btn_Clear);
            splitContainer2.Panel1.Controls.Add(btn_Edit);
            splitContainer2.Panel1.Controls.Add(btn_Delete);
            splitContainer2.Panel1.Controls.Add(btn_Insert);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(listView_EmployeeList);
            splitContainer2.Size = new Size(909, 352);
            splitContainer2.SplitterDistance = 120;
            splitContainer2.SplitterWidth = 5;
            splitContainer2.TabIndex = 0;
            // 
            // btn_Exit
            // 
            btn_Exit.Location = new Point(15, 271);
            btn_Exit.Margin = new Padding(4, 3, 4, 3);
            btn_Exit.Name = "btn_Exit";
            btn_Exit.Size = new Size(88, 27);
            btn_Exit.TabIndex = 4;
            btn_Exit.Text = "Exit";
            btn_Exit.UseVisualStyleBackColor = true;
            btn_Exit.Click += btn_Exit_Click;
            // 
            // btn_Clear
            // 
            btn_Clear.Location = new Point(15, 214);
            btn_Clear.Margin = new Padding(4, 3, 4, 3);
            btn_Clear.Name = "btn_Clear";
            btn_Clear.Size = new Size(88, 27);
            btn_Clear.TabIndex = 3;
            btn_Clear.Text = "Clear";
            btn_Clear.UseVisualStyleBackColor = true;
            btn_Clear.Click += btn_Clear_Click;
            // 
            // btn_Edit
            // 
            btn_Edit.Location = new Point(15, 100);
            btn_Edit.Margin = new Padding(4, 3, 4, 3);
            btn_Edit.Name = "btn_Edit";
            btn_Edit.Size = new Size(88, 27);
            btn_Edit.TabIndex = 2;
            btn_Edit.Text = "Update";
            btn_Edit.UseVisualStyleBackColor = true;
            btn_Edit.Click += btn_Edit_Click;
            // 
            // btn_Delete
            // 
            btn_Delete.Location = new Point(15, 157);
            btn_Delete.Margin = new Padding(4, 3, 4, 3);
            btn_Delete.Name = "btn_Delete";
            btn_Delete.Size = new Size(88, 27);
            btn_Delete.TabIndex = 1;
            btn_Delete.Text = "Delete";
            btn_Delete.UseVisualStyleBackColor = true;
            btn_Delete.Click += btn_Delete_Click;
            // 
            // btn_Insert
            // 
            btn_Insert.Location = new Point(15, 43);
            btn_Insert.Margin = new Padding(4, 3, 4, 3);
            btn_Insert.Name = "btn_Insert";
            btn_Insert.Size = new Size(88, 27);
            btn_Insert.TabIndex = 0;
            btn_Insert.Text = "Insert";
            btn_Insert.UseVisualStyleBackColor = true;
            btn_Insert.Click += btn_Insert_Click;
            // 
            // listView_EmployeeList
            // 
            listView_EmployeeList.Columns.AddRange(new ColumnHeader[] { ID, FullName, Email, Salary });
            listView_EmployeeList.Dock = DockStyle.Fill;
            listView_EmployeeList.FullRowSelect = true;
            listView_EmployeeList.GridLines = true;
            listView_EmployeeList.Location = new Point(0, 0);
            listView_EmployeeList.Margin = new Padding(4, 3, 4, 3);
            listView_EmployeeList.Name = "listView_EmployeeList";
            listView_EmployeeList.Size = new Size(784, 352);
            listView_EmployeeList.TabIndex = 0;
            listView_EmployeeList.UseCompatibleStateImageBehavior = false;
            listView_EmployeeList.View = View.Details;
            listView_EmployeeList.SelectedIndexChanged += listView_EmployeeList_SelectedIndexChanged;
            // 
            // ID
            // 
            ID.Text = "ID";
            ID.Width = 99;
            // 
            // FullName
            // 
            FullName.Text = "Name";
            FullName.Width = 158;
            // 
            // Email
            // 
            Email.Text = "Email";
            Email.Width = 179;
            // 
            // Salary
            // 
            Salary.Text = "Salary";
            Salary.Width = 228;
            // 
            // EmployeeManagerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 573);
            Controls.Add(splitContainer1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "EmployeeManagerForm";
            Text = "Employee Manager";
            Load += MainForm_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private SplitContainer splitContainer2;
        private ListView listView_EmployeeList;
        private TextBox txt_ID;
        private Label label1;
        private TextBox txt_Email;
        private Label label2;
        private TextBox txt_Username;
        private Label label3;
        private TextBox txt_Password;
        private Label label4;
        private TextBox txt_Salary;
        private Label label5;
        private TextBox txt_Name;
        private Label label6;
        private Button btn_Delete;
        private Button btn_Insert;
        private Button btn_Exit;
        private Button btn_Clear;
        private Button btn_Edit;
        private ColumnHeader ID;
        private ColumnHeader FullName;
        private ColumnHeader Email;
        private ColumnHeader Salary;
    }
}