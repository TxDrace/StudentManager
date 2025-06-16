using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManager
{
    public partial class MainForm : Form
    {
        string connectionString = "Data Source=DESKTOP-HAITUYEN;Initial Catalog=QLSVNhom;Integrated Security=True;TrustServerCertificate=true;";
        public LogIn logInForm { get; set; }
        public MainForm(LogIn _logInForm)
        {
            this.logInForm = _logInForm;
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string query = @"SELECT MALOP, TENLOP, HOTEN AS TENNV, NHANVIEN.MANV FROM LOP INNER JOIN NHANVIEN ON LOP.MANV = NHANVIEN.MANV";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader[0].ToString());
                            item.SubItems.Add(reader[1].ToString());
                            item.SubItems.Add(reader[2].ToString());
                            item.SubItems.Add(reader[3].ToString());
                            lsvDSLop.Items.Add(item);
                        }
                    }
                }
            }
        }

        private void lsvDSLop_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnShowClass_Click(object sender, EventArgs e)
        {
            if (lsvDSLop.SelectedItems.Count > 0)
            {
                ClassDetails classDetails = new ClassDetails(this);
                classDetails.Show();
            }
            else
            {
                MessageBox.Show("Chọn một lớp để hiển thị.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BangDiem bangDiem = new BangDiem(this);
            bangDiem.Show();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
