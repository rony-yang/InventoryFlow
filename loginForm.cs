using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryFlow
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void loginForm_Load(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new SQLiteConnection(DatabaseConfig.ConnectionString))
                {
                    connection.Open();
                }
            }
            catch
            {
                MessageBox.Show("데이터베이스 연결 오류");
            }
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            string memberNumber = login_memberNumber.Text;
            string memberPassword = login_memberPassword.Text;

            string query = "SELECT memberName FROM members " +
                           "WHERE memberNumber = @memberNumber AND memberPassword = @memberPassword;";

            using (var connection = new SQLiteConnection(DatabaseConfig.ConnectionString))
            {
                connection.Open();

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@memberNumber", memberNumber);
                    command.Parameters.AddWithValue("@memberPassword", memberPassword);

                    var memberName = command.ExecuteScalar()?.ToString();

                    if (!string.IsNullOrEmpty(memberName))
                    {
                        LoginSession.LoggedInMemberName = memberName; // 로그인정보 세션에 저장

                        MessageBox.Show("로그인 성공!", "성공");
                        MainForm mainFormInstance = new MainForm();
                        this.Hide(); // 기존 품 숨기기
                        mainFormInstance.Show(); // 새로운 폼 열기
                        mainFormInstance.FormClosed += (s, args) => this.Close();
                    }
                    else
                    {
                        MessageBox.Show("정보를 다시 확인해주세요.", "실패");
                    }
                }
            }
        }

        private void login_memberPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegisterForm registerFormInstance = new RegisterForm();
            this.Hide(); // 기존 품 숨기기
            registerFormInstance.Show(); // 새로운 폼 열기
            registerFormInstance.FormClosed += (s, args) => this.Close();
        }
    }
}
