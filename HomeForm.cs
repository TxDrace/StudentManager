using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager
{
    public partial class HomeForm : Form
    {
        public LogIn logInForm { get; set; }
        public HomeForm(LogIn _logInForm)
        {
            this.logInForm = _logInForm;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void employee_btn_Click(object sender, EventArgs e)
        {
            EmployeeManagerForm employeeManagerForm = new EmployeeManagerForm();
            employeeManagerForm.Show();
        }

        private void Student_btn_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm(logInForm);
            mainForm.Show();
        }
    }
}
