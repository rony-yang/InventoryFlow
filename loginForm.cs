﻿using System;
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
    public partial class loginForm : Form
    {
        public loginForm()
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

            string query = "SELECT COUNT(1) FROM members " +
                "WHERE memberNumber = @memberNumber AND memberPassword = @memberPassword;";

            using (var connection = new SQLiteConnection(DatabaseConfig.ConnectionString))
            {
                connection.Open();

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@memberNumber", memberNumber);
                    command.Parameters.AddWithValue("@memberPassword", memberPassword);

                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count == 1)
                    {
                        MessageBox.Show("로그인 성공!", "성공");
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
            registerForm registerFormInstance = new registerForm();
            this.Hide(); // 기존 품 숨기기
            registerFormInstance.Show(); // 새로운 폼 열기
            registerFormInstance.FormClosed += (s, args) => this.Close();
        }
    }
}
