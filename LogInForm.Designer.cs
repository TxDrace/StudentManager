namespace StudentManager
{
    partial class LogIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LogInButton = new Button();
            label1 = new Label();
            UsernameInput = new TextBox();
            PasswordInput = new TextBox();
            label2 = new Label();
            ExitButton = new Button();
            SuspendLayout();
            // 
            // LogInButton
            // 
            LogInButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LogInButton.Location = new Point(185, 161);
            LogInButton.Name = "LogInButton";
            LogInButton.Size = new Size(94, 35);
            LogInButton.TabIndex = 0;
            LogInButton.Text = "Đăng nhập";
            LogInButton.UseVisualStyleBackColor = true;
            LogInButton.Click += LogInButton_Click;
            LogInButton.MouseClick += LogInButton_MouseClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(53, 42);
            label1.Name = "label1";
            label1.Size = new Size(114, 21);
            label1.TabIndex = 1;
            label1.Text = "Tên đăng nhập:";
            // 
            // UsernameInput
            // 
            UsernameInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameInput.Location = new Point(185, 42);
            UsernameInput.Name = "UsernameInput";
            UsernameInput.Size = new Size(227, 29);
            UsernameInput.TabIndex = 2;
            // 
            // PasswordInput
            // 
            PasswordInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordInput.Location = new Point(185, 93);
            PasswordInput.Name = "PasswordInput";
            PasswordInput.Size = new Size(227, 29);
            PasswordInput.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(53, 93);
            label2.Name = "label2";
            label2.Size = new Size(78, 21);
            label2.TabIndex = 3;
            label2.Text = "Mật khẩu:";
            // 
            // ExitButton
            // 
            ExitButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ExitButton.Location = new Point(314, 161);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(98, 35);
            ExitButton.TabIndex = 5;
            ExitButton.Text = "Thoát";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // LogIn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 272);
            Controls.Add(ExitButton);
            Controls.Add(PasswordInput);
            Controls.Add(label2);
            Controls.Add(UsernameInput);
            Controls.Add(label1);
            Controls.Add(LogInButton);
            Name = "LogIn";
            Text = "Màn hình đăng nhập";
            Load += LogIn_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LogInButton;
        private Label label1;
        private TextBox UsernameInput;
        private TextBox PasswordInput;
        private Label label2;
        private Button ExitButton;
    }
}