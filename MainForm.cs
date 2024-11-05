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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            tabControl1.Dock = DockStyle.Fill; // 탭 화면에 꽉차게 설정
        }
        

        private void mainForm_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            dataGridView1.CellDoubleClick += dataGridView1_CellContentClick; // 글 더블클릭 시 상세내용으로 이동

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

        private void InitializeDataGridView()
        {
            dataGridView1.AllowUserToAddRows = false; // 사용자가 수동으로 행 추가하는것 방지
            dataGridView1.AllowUserToDeleteRows = false; // 사용자가 직접 삭제하는것 방지
            dataGridView1.AutoGenerateColumns = false; // 열, 너비를 사용자 정의로 사용
            dataGridView1.Dock = DockStyle.Fill; // 화면에 꽉 차게 설정

            dataGridView1.RowHeadersWidth = 50; // 행 머리글 가로넓이
            dataGridView1.RowTemplate.Height = 25; // 전체 셀 세로높이
            dataGridView1.Columns.Clear();

            string selectQuery = 
                "SELECT boardNumber, boardTitle, boardDate " +
                "FROM board ORDER BY boardNumber ASC;";

            var columnNumber = new DataGridViewTextBoxColumn
            {
                Name = "boardNumber",
                HeaderText = "번호",
                Width = 50
            };

            var columnTitle = new DataGridViewTextBoxColumn
            {
                Name = "boardTitle",
                HeaderText = "제목",
                Width = 500 
            };

            var columnDate = new DataGridViewTextBoxColumn
            {
                Name = "boardDate",
                HeaderText = "작성일",
                Width = 200 
            };

            dataGridView1.Columns.Add(columnNumber);
            dataGridView1.Columns.Add(columnTitle);
            dataGridView1.Columns.Add(columnDate);

            using (var connection = new SQLiteConnection(DatabaseConfig.ConnectionString))
            {
                connection.Open();

                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            dataGridView1.Rows.Add(
                                reader["boardNumber"].ToString(),
                                reader["boardTitle"].ToString(),
                                reader["boardDate"].ToString()
                            );
                        }
                    }
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string boardNumber = dataGridView1.Rows[e.RowIndex].Cells["boardNumber"].Value.ToString();
        
                BoardDetailForm detailForm = new BoardDetailForm();
                detailForm.SetDetails(boardNumber); 
                detailForm.ShowDialog();
           }
        }

    }
}
