using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;


namespace StudentManager
{
    public partial class ClassDetails : Form
    {
        string connectionString = "Data Source=DESKTOP-HAITUYEN;Initial Catalog=QLSVNhom;Integrated Security=True;TrustServerCertificate=true;";
        string employee_ID = "";
        string employee_username = "";


        public MainForm mainForm { get; set; }

        public ClassDetails(MainForm mainForm)
        {
            this.mainForm = mainForm;
            InitializeComponent();
        }

        private void ClassDetails_Load(object sender, EventArgs e)
        {
            LoadClassData();

            ListViewItem classItem = mainForm.lsvDSLop.SelectedItems[0];
            this.employee_ID = classItem.SubItems[3].Text;
            this.employee_username = getEmployeeUsername(this.employee_ID);

            // Chỉ cho phép nhân viên quản lý lớp sửa điểm
            if (employee_username != mainForm.logInForm.username)
            {
                textboxMaSV.Enabled = false;
                textBoxHoTen.Enabled = false;
                dtBirthday.Enabled = false;
                textBoxDiaChi.Enabled = false;
                textBoxTenDN.Enabled = false;
                textBoxMK.Enabled = false;

                btnAddStudent.Enabled = false;
                btnEditStudent.Enabled = false;
                btnRemoveStudent.Enabled = false;
            }
        }

        private void SettingDateTimePicker()
        {
            dtBirthday.CustomFormat = " ";
            dtBirthday.Checked = false;
        }

        private string getEmployeeUsername(string employee_ID)
        {
            string employee_username = "";
            string query = @"SELECT TENDN FROM NHANVIEN WHERE MANV = @employeeID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@employeeID", SqlDbType.VarChar, 20).Value = employee_ID;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            employee_username = reader[0].ToString();
                        }
                    }
                }
            }
            return employee_username;
        }


        private void LoadClassData()
        {
            lsvDsSinhVien.Items.Clear();
            ListViewItem classItem = mainForm.lsvDSLop.SelectedItems[0];
            string query = @"SELECT MASV, HOTEN, CONVERT(VARCHAR, NGAYSINH, 103) AS NGAYSINH, DIACHI, TENDN FROM SINHVIEN WHERE MALOP = @ClassID";
            string classID = classItem.SubItems[0].Text;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@ClassID", SqlDbType.VarChar, 20).Value = classID;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader[0].ToString());
                            item.SubItems.Add(reader[1].ToString());
                            item.SubItems.Add(reader[2].ToString());
                            item.SubItems.Add(reader[3].ToString());
                            item.SubItems.Add(reader[4].ToString());
                            lsvDsSinhVien.Items.Add(item);
                        }
                    }
                }
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void labelMaSV_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void lsvDsSinhVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!dtBirthday.Checked)
            {
                dtBirthday.Checked = true;
                dtBirthday.CustomFormat = "dd/MM/yyyy";
            }

            if (lsvDsSinhVien.SelectedItems.Count > 0)
            {
                ListViewItem item = lsvDsSinhVien.SelectedItems[0];
                string maSV = item.SubItems[0].Text;
                string hoTen = item.SubItems[1].Text;
                string ngaySinh = item.SubItems[2].Text;
                string diaChi = item.SubItems[3].Text;
                string tenDangNhap = item.SubItems[4].Text;


                textboxMaSV.Text = maSV;
                textBoxHoTen.Text = hoTen;
                dtBirthday.Value = DateTime.ParseExact(ngaySinh, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                textBoxDiaChi.Text = diaChi;
                textBoxTenDN.Text = tenDangNhap;
                textBoxMK.Text = "";
            }
        }

        private void btnEditStudent_Click(object sender, EventArgs e)
        {
            string query = @"EXEC UPDATE_SINHVIEN @studentID, @name, @birthday, @address, @username, @employee_id";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@studentID", SqlDbType.VarChar, 20).Value = textboxMaSV.Text;
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar, 100).Value = textBoxHoTen.Text;
                    cmd.Parameters.Add("@birthday", SqlDbType.DateTime).Value = dtBirthday.Value;
                    cmd.Parameters.Add("@address", SqlDbType.NVarChar, 200).Value = textBoxDiaChi.Text;
                    cmd.Parameters.Add("@username", SqlDbType.NVarChar, 100).Value = textBoxTenDN.Text;
                    cmd.Parameters.Add("@employee_id", SqlDbType.VarChar, 20).Value = this.employee_ID;

                    try
                    {
                        cmd.ExecuteNonQuery();
                        LoadClassData();
                        MessageBox.Show("Chỉnh sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dtBirthday_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            ListViewItem classItem = mainForm.lsvDSLop.SelectedItems[0];
            string classID = classItem.SubItems[0].Text;
            string query = @"EXEC SP_INS_ENCRYPT_SINHVIEN @studentID, @name, @birthday, @address, @classID, @username, @password";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@studentID", SqlDbType.VarChar, 20).Value = textboxMaSV.Text;
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar, 100).Value = textBoxHoTen.Text;
                    cmd.Parameters.Add("@birthday", SqlDbType.DateTime).Value = dtBirthday.Value;
                    cmd.Parameters.Add("@address", SqlDbType.NVarChar, 200).Value = textBoxDiaChi.Text;
                    cmd.Parameters.Add("@classID", SqlDbType.VarChar, 20).Value = classID;
                    cmd.Parameters.Add("@username", SqlDbType.NVarChar, 100).Value = textBoxTenDN.Text;
                    cmd.Parameters.Add("@password", SqlDbType.VarBinary, -1).Value = Hash_SHA1(textBoxMK.Text);

                    try
                    {
                        cmd.ExecuteNonQuery();
                        LoadClassData();
                        MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            string query = @"EXEC DELETE_SINHVIEN @studentID, @employeeID";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@studentID", SqlDbType.NVarChar, 100).Value = textboxMaSV.Text;
                    cmd.Parameters.Add("@employeeID", SqlDbType.VarChar, 20).Value = this.employee_ID;
                    try
                    {
                        cmd.ExecuteNonQuery();
                        LoadClassData();
                        MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private byte[] Hash_SHA1(string input)
        {
            using (SHA1 sha1Hash = SHA1.Create())
            {
                // Convert the input string to a byte array and compute the hash.
                byte[] data = sha1Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
                return data;
            }
        }
    }
}
