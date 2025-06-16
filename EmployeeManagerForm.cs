using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace StudentManager
{
    public partial class EmployeeManagerForm : Form
    {
        private string connectionString = "Data Source=localhost;Initial Catalog=QLSVNhom;Integrated Security=True;TrustServerCertificate=true;";


        public EmployeeManagerForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private byte[] Encrypt_AES(string plainText, byte[] Key, byte[] IV)
        {
            byte[] cipher = null;
            try
            {
                // Check arguments.
                if (plainText == null || plainText.Length <= 0)
                    throw new ArgumentNullException("plainText");
                if (Key == null || Key.Length <= 0)
                    throw new ArgumentNullException("Key");
                if (IV == null || IV.Length <= 0)
                    throw new ArgumentNullException("IV");

                // Create an AES object with the specified key and IV.
                using (Aes aesAlg = Aes.Create())
                {
                    aesAlg.Key = Key;
                    aesAlg.IV = IV;

                    // Create an encryptor to perform the stream transform.
                    ICryptoTransform encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV);

                    // Create the streams used for encryption.
                    using (MemoryStream msEncrypt = new MemoryStream())
                    {
                        using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                        {
                            using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                            {
                                // Write all data to the stream.
                                swEncrypt.Write(plainText);
                            }
                            cipher = msEncrypt.ToArray();
                        }
                    }
                }

                // Return the encrypted bytes from the memory stream.
                return cipher;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "System Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return cipher;
            }
        }

        //private string Decrypt_AES(byte[] cipherText, byte[] Key, byte[] IV)
        //{
        //    // Check arguments.
        //    if (cipherText == null || cipherText.Length <= 0)
        //        throw new ArgumentNullException("cipherText");
        //    if (Key == null || Key.Length <= 0)
        //        throw new ArgumentNullException("Key");
        //    if (IV == null || IV.Length <= 0)
        //        throw new ArgumentNullException("IV");

        //    // Declare the string used to hold the decrypted text.
        //    string plaintext = null;

        //    // Create an Aes object with the specified key and IV.
        //    using (Aes aesAlg = Aes.Create())
        //    {
        //        aesAlg.Key = Key;
        //        aesAlg.IV = IV;

        //        // Create a decryptor to perform the stream transform.
        //        ICryptoTransform decryptor = aesAlg.CreateDecryptor(aesAlg.Key, aesAlg.IV);

        //        // Create the streams used for decryption.
        //        using (MemoryStream msDecrypt = new MemoryStream(cipherText))
        //        {
        //            using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
        //            {
        //                using (StreamReader srDecrypt = new StreamReader(csDecrypt))
        //                {
        //                    // Read the decrypted bytes from the decrypting stream and place them in a string.
        //                    plaintext = srDecrypt.ReadToEnd();
        //                }
        //            }
        //        }
        //    }

        //    return plaintext;
        //}

        private string byteToString(byte[] data)
        {
            // Create a new Stringbuilder to collect the bytes and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("X2"));
            }

            return sBuilder.ToString();
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadListView_EmployeeList();
        }

        private void listView_EmployeeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView_EmployeeList.SelectedItems.Count > 0)
            {
                ListViewItem item = listView_EmployeeList.SelectedItems[0];
                if (item != null)
                {
                    string ID = item.SubItems[0].Text;
                    string Name = item.SubItems[1].Text;
                    string Email = item.SubItems[2].Text;
                    string Salary = item.SubItems[3].Text;
                    string Username = "";
                    string Password = "";

                    string query = "SELECT TENDN FROM NHANVIEN WHERE MANV = @ID";
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        using (SqlCommand cmd = new SqlCommand(query, conn))
                        {
                            cmd.Parameters.Add("@ID", SqlDbType.VarChar, 20).Value = ID;
                            using (SqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    Username = reader[0].ToString();
                                }
                            }
                        }
                    }

                    txt_ID.Text = ID;
                    txt_Name.Text = Name;
                    txt_Email.Text = Email;
                    txt_Salary.Text = Salary;
                    txt_Username.Text = Username;
                    txt_Password.Text = Password;
                }
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void LoadListView_EmployeeList()
        {
            listView_EmployeeList.Items.Clear();
            string query = @"EXEC SP_SEL_ENCRYPT_NHANVIEN";
            try
            {
                string private_key_path = txt_ID.Text + "-private";

                RSAEncryption rsa = new RSAEncryption();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader[0].ToString());
                                item.SubItems.Add(reader[1].ToString());
                                item.SubItems.Add(reader[2].ToString());
                                if (reader[3] is byte[] encryptedSalary)
                                {
                                    try
                                    {
                                        item.SubItems.Add(rsa.Decrypt(encryptedSalary, private_key_path));
                                    }
                                    catch
                                    {
                                        item.SubItems.Add("Dữ liệu không hợp lệ");

                                    }
                                }
                                else
                                {
                                    item.SubItems.Add("Dữ liệu không hợp lệ");
                                }

                                listView_EmployeeList.Items.Add(item);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            string query = @"EXEC SP_INS_PUBLIC_ENCRYPT_NHANVIEN @ID, @Name, @Email, @Salary, @Username, @Password, @Pubkey";

            try
            {
                string private_key_path = txt_ID.Text + "-private";
                string public_key_path = txt_ID.Text + "-public";

                RSAEncryption rsa = new RSAEncryption();
                rsa.GenrateKeyPair(public_key_path, private_key_path);
                byte[] encryptedSalary = rsa.Encrypt(txt_Salary.Text, public_key_path);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@ID", SqlDbType.VarChar, 20).Value = txt_ID.Text;
                        cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 100).Value = txt_Name.Text;
                        cmd.Parameters.Add("@Email", SqlDbType.VarChar, 20).Value = txt_Email.Text;
                        cmd.Parameters.Add("@Salary", SqlDbType.VarBinary, -1).Value = encryptedSalary;
                        cmd.Parameters.Add("@Username", SqlDbType.NVarChar, 100).Value = txt_Username.Text;
                        cmd.Parameters.Add("@Password", SqlDbType.VarBinary, -1).Value = Hash_SHA1(txt_Password.Text);
                        cmd.Parameters.Add("@Pubkey", SqlDbType.VarChar, 200).Value = public_key_path;

                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ListViewItem item = new ListViewItem(reader[0].ToString());
                                item.SubItems.Add(reader[1].ToString());
                                item.SubItems.Add(reader[2].ToString());
                                byte[] SalaryBytes = (byte[])reader[3];
                                // Convert binary data to hexadecimal string
                                string SalaryString = BitConverter.ToString(SalaryBytes).Replace("-", "");
                                item.SubItems.Add(SalaryString);
                                listView_EmployeeList.Items.Add(item);
                            }
                        }
                    }
                }

                MessageBox.Show("Insert employee successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadListView_EmployeeList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "System Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string ConvertBytesToString(byte[] input)
        {
            return BitConverter.ToString(input).Replace("-", "");
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {

        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            txt_ID.Text = "";
            txt_Email.Text = "";
            txt_Username.Text = "";
            txt_Name.Text = "";
            txt_Salary.Text = "";
            txt_Password.Text = "";
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            string query = @"EXEC UPDATE_NHANVIEN @ID, @Name, @Email, @Salary, @Username";

            try
            {
                string public_key_path = txt_ID.Text + "-public";
                RSAEncryption rsa = new RSAEncryption();
                byte[] encryptedSalary = rsa.Encrypt(txt_Salary.Text, public_key_path);

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@ID", SqlDbType.VarChar, 20).Value = txt_ID.Text;
                        cmd.Parameters.Add("@Name", SqlDbType.NVarChar, 100).Value = txt_Name.Text;
                        cmd.Parameters.Add("@Email", SqlDbType.VarChar, 100).Value = txt_Email.Text;
                        cmd.Parameters.Add("@Salary", SqlDbType.VarBinary, -1).Value = encryptedSalary;
                        cmd.Parameters.Add("@Username", SqlDbType.NVarChar, 100).Value = txt_Username.Text;

                        int rowsAffected = cmd.ExecuteNonQuery();

                        MessageBox.Show("Cập nhật thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }

                LoadListView_EmployeeList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            string query = @"EXEC DELETE_NHANVIEN @ID";

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@ID", SqlDbType.VarChar, 20).Value = txt_ID.Text;
                        int rowsAffected = cmd.ExecuteNonQuery();

                        MessageBox.Show("Xóa nhân viên thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }

                LoadListView_EmployeeList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
