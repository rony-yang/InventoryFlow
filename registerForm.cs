using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace InventoryFlow
{
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void registerForm_Load(object sender, EventArgs e)
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

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }


        private void box_memberNumber_TextChanged(object sender, EventArgs e)
        {
        }

        private void box_memberPassword_TextChanged(object sender, EventArgs e)
        {
        }

        private void box_memberName_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_phoneNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_department_TextChanged(object sender, EventArgs e)
        {

        }

        private void box_position_TextChanged(object sender, EventArgs e)
        {

        }

        private void register_button_Click(object sender, EventArgs e)
        {
            string memberNumber = box_memberNumber.Text;
            string memberPassword = box_memberPassword.Text;
            string memberName = box_memberName.Text;
            string phoneNumber = box_phoneNumber.Text;
            string department = box_department.Text;
            string position = box_position.Text;

            string insertQuery =
                "INSERT INTO members (memberNumber, memberPassword, memberName, phoneNumber, department, position) " +
                "VALUES (@memberNumber, @memberPassword, @memberName, @phoneNumber, @department, @position);";

            using (var connection = new SQLiteConnection(DatabaseConfig.ConnectionString))
            {
                connection.Open();

                using (var command = new SQLiteCommand(insertQuery, connection))
                {
                    command.Parameters.AddWithValue("@memberNumber", memberNumber);
                    command.Parameters.AddWithValue("@memberPassword", memberPassword);
                    command.Parameters.AddWithValue("@memberName", memberName);
                    command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                    command.Parameters.AddWithValue("@department", department);
                    command.Parameters.AddWithValue("@position", position);

                    command.ExecuteNonQuery();
                }
            }
            MessageBox.Show("회원가입 성공!");
            loginForm loginFormInstance = new loginForm();
            this.Hide(); // 기존 품 숨기기
            loginFormInstance.Show(); // 새로운 폼 열기
            loginFormInstance.FormClosed += (s, args) => this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loginForm loginFormInstance = new loginForm();
            this.Hide(); // 기존 품 숨기기
            loginFormInstance.Show(); // 새로운 폼 열기
            loginFormInstance.FormClosed += (s, args) => this.Close();
        }
    }
}