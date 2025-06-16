using Microsoft.Data.SqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace StudentManager
{
    public partial class BangDiem : Form
    {
        private string connectionString = "Data Source=DESKTOP-HAITUYEN;Initial Catalog=QLSVNhom;Integrated Security=True;TrustServerCertificate=true;";
        private string employee_ID = "";
        public MainForm mainForm { get; set; }
        public BangDiem(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }


        private void BangDiem_loads(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }


        private void folderBrowserDialog2_HelpRequest(object sender, EventArgs e)
        {

        }

        private void folderBrowserDialog1_HelpRequest(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            float diem = 0;
            if (float.TryParse(textBoxDIEM.Text, out diem))
            {
                if (diem < 0 || diem > 10)
                {
                    MessageBox.Show("Điểm không hợp lệ");
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = @"EXEC INSERT_BANGDIEM @MASV, @MAHP, @DIEM, @PUBKEY"; // Co the them dieu kien vào
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.Add("@MASV", SqlDbType.VarChar, 20).Value = cbbMaSV.SelectedItem.ToString();
                            cmd.Parameters.Add("@MAHP", SqlDbType.VarChar, 20).Value = cbbCourseID.SelectedItem.ToString();
                            cmd.Parameters.Add("@DIEM", SqlDbType.Float).Value = diem;
                            cmd.Parameters.Add("@PUBKEY", SqlDbType.VarChar, 20).Value = getEmployeePubKey();

                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("Insert successful");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }

                }
            }
            else
            {
                return;
            }
        }

        private string getEmployeePubKey()
        {
            string employeeUsername = mainForm.logInForm.username;
            string query = @"SELECT PUBKEY FROM NHANVIEN WHERE TENDN = @employeeUsername";
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@employeeUsername", SqlDbType.NVarChar, 100).Value = employeeUsername;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return reader[0].ToString();
                        }
                    }
                }
            }
            return "";
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BangDiem_Load(object sender, EventArgs e)
        {
            loadClassTreeView();
            loadCoursesCombobox();
            initScoreBoard();
        }

        private void initScoreBoard()
        {
            listViewBANGDIEM.Items.Clear();
        }

        private void loadClassTreeView()
        {
            string query = @"SELECT TENLOP FROM LOP";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TreeNode newNode = new TreeNode(reader[0].ToString());
                            treeClassList.Nodes.Add(newNode);
                        }
                    }
                }
            }            
        }

        private void loadCoursesCombobox()
        {
            cbbCourseID.Items.Clear();
            string query = @"SELECT MAHP FROM HOCPHAN";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cbbCourseID.Items.Add(reader[0].ToString());
                        }
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void splitContainer3_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void treeClassList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            listViewBANGDIEM.Items.Clear();
            cbbCourseID.SelectedItem = null;
            textBoxDIEM.Text = "";

            // Cập nhật bảng điểm
            string selectedClassName = treeClassList.SelectedNode.Text;
            string query = @"
                SELECT SINHVIEN.MASV, HOTEN, BANGDIEM.MAHP, TENHP, DIEMTHI, LOP.MANV FROM BANGDIEM
                INNER JOIN SINHVIEN ON BANGDIEM.MASV = SINHVIEN.MASV 
                INNER JOIN LOP ON SINHVIEN.MALOP = LOP.MALOP
                INNER JOIN HOCPHAN ON BANGDIEM.MAHP = HOCPHAN.MAHP
                WHERE TENLOP = @ClassName";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                string private_key_path = this.employee_ID + "-private";
                RSAEncryption rsa = new RSAEncryption();

                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@ClassName", SqlDbType.NVarChar, 100).Value = selectedClassName;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader[0].ToString());
                            item.SubItems.Add(reader[1].ToString());
                            item.SubItems.Add(reader[2].ToString());
                            item.SubItems.Add(reader[3].ToString());
                            //byte[] diemthiBytes = (byte[])reader[4];
                            //// Convert binary data to hexadecimal string
                            //string diemthiHex = BitConverter.ToString(diemthiBytes).Replace("-", "");
                            //item.SubItems.Add(diemthiHex);

                            if (reader[4] is byte[] encryptedScore)
                            {
                                try
                                {
                                    item.SubItems.Add(rsa.Decrypt(encryptedScore, private_key_path));
                                }
                                catch
                                {
                                    item.SubItems.Add("");
                                }
                            }
                            else
                            {
                                item.SubItems.Add("");
                            }

                            // Cập nhật giá trị employee_ID của lớp đang chọn
                            this.employee_ID = reader[5].ToString();

                            listViewBANGDIEM.Items.Add(item);
                        }
                    }
                }
            }


            // Cập nhật các giá trị trong combobox MaSV và TenSV
            cbbMaSV.Items.Clear();
            cbbHoTen.Items.Clear();
            query = @"
                SELECT MASV, HOTEN FROM SINHVIEN 
                INNER JOIN LOP ON SINHVIEN.MALOP = LOP.MALOP
                WHERE TENLOP = @ClassName";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@ClassName", SqlDbType.NVarChar, 100).Value = selectedClassName;
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cbbMaSV.Items.Add(reader[0].ToString());
                            cbbHoTen.Items.Add(reader[1].ToString());
                        }
                    }
                }
            }

            //// Chỉ cho phép nhân viên quản lý lớp đó sửa điểm

            //query = @"SELECT NHANVIEN.TENDN
            //    FROM LOP JOIN NHANVIEN ON LOP.MANV = NHANVIEN.MANV
            //    WHERE TENLOP = @CourseName";
            //using (SqlConnection conn = new SqlConnection(connectionString))
            //{
            //    conn.Open();
            //    using (SqlCommand cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.Add("@CourseName", SqlDbType.NVarChar, 100).Value = selectedClassName;
            //        using (SqlDataReader reader = cmd.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                if (reader[0].ToString() != mainForm.logInForm.username)
            //                {
            //                    cbbMaSV.Enabled = false;
            //                    cbbHoTen.Enabled = false;
            //                    cbbCourseID.Enabled = false;
            //                    textBoxDIEM.Enabled = false;

            //                    btnAddScore.Enabled = false;
            //                    btnRemoveScore.Enabled = false;
            //                    btnEditScore.Enabled = false;
            //                }
            //                else
            //                {
            //                    cbbMaSV.Enabled = true;
            //                    cbbHoTen.Enabled = true;
            //                    cbbCourseID.Enabled = true;
            //                    textBoxDIEM.Enabled = true;

            //                    btnAddScore.Enabled = true;
            //                    btnRemoveScore.Enabled = true;
            //                    btnEditScore.Enabled = true;
            //                } 
                           
            //            }
            //        }
            //    }
            //}

        }

        private void cbbCourseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listViewBANGDIEM.Items.Clear();
            //string selectedCourseName = cbbCourseName.SelectedItem.ToString();
            //string selectedClassName = treeClassList.SelectedNode.ToString();

            //string query = @"
            //    SELECT SINHVIEN.MASV, HOTEN, TENHP, DIEMTHI FROM BANGDIEM 
            //    INNER JOIN SINHVIEN ON BANGDIEM.MASV = SINHVIEN.MASV 
            //    INNER JOIN LOP ON SINHVIEN.MALOP = LOP.MALOP
            //    INNER JOIN HOCPHAN ON BANGDIEM.MAHP = HOCPHAN.MAHP
            //    WHERE TENLOP = @ClassName AND TENHP = @CourseName";

            //using (SqlConnection conn = new SqlConnection(connectionString))
            //{

            //    conn.Open();
            //    using (SqlCommand cmd = new SqlCommand(query, conn))
            //    {
            //        cmd.Parameters.Add("@ClassName", SqlDbType.NVarChar, 100).Value = selectedClassName;
            //        cmd.Parameters.Add("@CourseName", SqlDbType.NVarChar, 100).Value = selectedCourseName;
            //        using (SqlDataReader reader = cmd.ExecuteReader())
            //        {
            //            while (reader.Read())
            //            {
            //                ListViewItem item = new ListViewItem(reader[0].ToString());
            //                item.SubItems.Add(reader[1].ToString());
            //                item.SubItems.Add(reader[2].ToString());
            //                item.SubItems.Add(reader[3].ToString());
            //                listViewBANGDIEM.Items.Add(item);
            //            }
            //        }
            //    }
            //}
        }

        private void cbbMaSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = @" SELECT HOTEN FROM SINHVIEN WHERE MASV = @StudentID";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@StudentID", SqlDbType.NVarChar, 100).Value = cbbMaSV.SelectedItem.ToString();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cbbHoTen.SelectedItem = reader[0].ToString();
                        }
                    }
                }
            }
        }

        private void cbbHoTen_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = @" SELECT MASV FROM SINHVIEN WHERE HOTEN = @StudentName";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {

                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@StudentName", SqlDbType.NVarChar, 100).Value = cbbHoTen.SelectedItem.ToString();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cbbMaSV.SelectedItem = reader[0].ToString();
                        }
                    }
                }
            }
        }

        private void listViewBANGDIEM_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewBANGDIEM.SelectedItems.Count > 0)
            {
                ListViewItem item = listViewBANGDIEM.SelectedItems[0];
                if (item != null)
                {
                    string studentID = item.SubItems[0].Text;
                    string studentName = item.SubItems[1].Text;
                    string courseID = item.SubItems[2].Text;
                    string score  = item.SubItems[4].Text;

                    cbbMaSV.SelectedItem = studentID;
                    cbbHoTen.SelectedItem = studentName;
                    cbbCourseID.SelectedItem = courseID;
                    textBoxDIEM.Text = score;

                    //// Giải mã điểm sử dụng mật khẩu đã đăng nhập
                    //string query = @"EXEC GET_DIEMTHI @StudentID, @CourseID, @EmployeeUsername, @EmployeePassword";

                    //using (SqlConnection conn = new SqlConnection(connectionString))
                    //{
                    //    conn.Open();
                    //    using (SqlCommand cmd = new SqlCommand(query, conn))
                    //    {
                    //        cmd.Parameters.Add("@StudentID", SqlDbType.VarChar, 20).Value = studentID;
                    //        cmd.Parameters.Add("@CourseID", SqlDbType.VarChar, 20).Value = courseID;
                    //        cmd.Parameters.Add("@EmployeeUsername", SqlDbType.NVarChar, 100).Value = mainForm.logInForm.username;
                    //        cmd.Parameters.Add("@EmployeePassword", SqlDbType.NVarChar, 100).Value = mainForm.logInForm.password;

                    //        using (SqlDataReader reader = cmd.ExecuteReader())
                    //        {
                    //            while (reader.Read())
                    //            {
                    //                textBoxDIEM.Text = reader[0].ToString();
                    //            }
                    //        }
                    //    }
                    //}
                }

                // Vô hiệu các trường nhập maSV, hoTen, hocPhan
                cbbMaSV.Enabled = false;
                cbbHoTen.Enabled = false;
                cbbCourseID.Enabled = false;

            }
            else
            {
                cbbMaSV.Enabled = true;
                cbbHoTen.Enabled = true;
                cbbCourseID.Enabled = true;
            }
        }


        private void btnEditScore_Click(object sender, EventArgs e)
        {
            string studentID = cbbMaSV.SelectedItem.ToString();
            string courseID = cbbCourseID.SelectedItem.ToString();
            string query = @"EXEC UPDATE_BANGDIEM @StudentID, @CourseID, @Score";
            float score;
            if (float.TryParse(textBoxDIEM.Text, out score))
            {
                if (score < 0 || score > 10)
                {
                    MessageBox.Show("Điểm không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string public_key_path = this.employee_ID + "-public";
                    RSAEncryption rsa = new RSAEncryption();
                    byte[] encryptedScore = rsa.Encrypt(textBoxDIEM.Text, public_key_path);

                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@StudentID", SqlDbType.VarChar, 20).Value = studentID;
                        cmd.Parameters.Add("@CourseID", SqlDbType.NVarChar, 100).Value = courseID;
                        cmd.Parameters.Add("@Score", SqlDbType.VarBinary, -1).Value = encryptedScore;

                        try
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Cập nhật thành công, chọn lại lớp để cập nhật thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void cbbCourseID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAddScore_Click(object sender, EventArgs e)
        {
            float score = 0;
            string studentID = cbbMaSV.SelectedItem.ToString();
            string courseID = cbbCourseID.SelectedItem.ToString();

            string query = @"EXEC INSERT_BANGDIEM @StudentID, @CourseID, @Score";

            if (float.TryParse(textBoxDIEM.Text, out score))
            {
                if (score < 0 || score > 10)
                {
                    MessageBox.Show("Điểm không hợp lệ", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    string public_key_path = this.employee_ID + "-public";

                    RSAEncryption rsa = new RSAEncryption();
                    byte[] encryptedScore = rsa.Encrypt(textBoxDIEM.Text, public_key_path);

                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@StudentID", SqlDbType.VarChar, 20).Value = studentID;
                        cmd.Parameters.Add("@CourseID", SqlDbType.NVarChar, 100).Value = courseID;
                        cmd.Parameters.Add("@Score", SqlDbType.VarBinary, -1).Value = encryptedScore;

                        try
                        {
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Thêm điểm thành công, chọn lại lớp để cập nhật thông tin", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                return;
            }
        }

        private void btnRemoveScore_Click(object sender, EventArgs e)
        {
            string studentID = cbbMaSV.SelectedItem.ToString();
            string courseID = cbbCourseID.SelectedItem.ToString();
            string query = @"EXEC DELETE_BANGDIEM @StudentID, @CourseID";
            string score = textBoxDIEM.Text;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.Add("@StudentID", SqlDbType.VarChar, 20).Value = studentID;
                    cmd.Parameters.Add("@CourseID", SqlDbType.NVarChar, 100).Value = courseID;
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Xóa thành công, chọn lại lớp để cập nhật thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
