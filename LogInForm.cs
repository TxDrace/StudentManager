using Microsoft.Data.SqlClient;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Security.Cryptography;


namespace StudentManager
{
    public partial class LogIn : Form
    {
        string connectionString = "Data Source=localhost;Initial Catalog=QLSVNhom;Integrated Security=True;TrustServerCertificate=true;";
        public string username = "";
        public string password = "";
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogInButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.username = UsernameInput.Text;
            this.password = PasswordInput.Text;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(@"EXEC SP_SEL_PUBLIC_ENCRYPT_NHANVIEN @username, @password", connection))
                {
                    command.Parameters.Add("@Username", SqlDbType.NVarChar, 100).Value = username;
                    command.Parameters.Add("@password", SqlDbType.VarBinary, -1).Value = Hash_SHA1(password);
                    Console.WriteLine(Hash_SHA1(PasswordInput.Text));
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            MessageBox.Show("Login successful!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            HomeForm home = new HomeForm(this);
                            home.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Login failed. Please check your username and password.", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {

        }

        private void LogIn_Load(object sender, EventArgs e)
        {

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