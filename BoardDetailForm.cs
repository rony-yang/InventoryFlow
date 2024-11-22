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
    public partial class BoardDetailForm : Form
    {
        public BoardDetailForm()
        {
            InitializeComponent();
            this.Width = 1000;
            this.Height = 530;
            this.WindowState = FormWindowState.Normal;
        }

        private void BoardDetailForm_Load(object sender, EventArgs e)
        {

        }

        public void SetDetails(string boardNumber)
        {
            string selectQuery = "SELECT boardNumber, boardTitle, boardDate, boardContext " +
                "FROM board WHERE boardNumber = @boardNumber;";

            dataGridView2.Columns.Clear();
            dataGridView2.RowHeadersWidth = 50; // 행 머리글 가로넓이

            dataGridView2.AllowUserToAddRows = false; // 사용자가 수동으로 행 추가하는것 방지
            dataGridView2.AllowUserToDeleteRows = false; // 사용자가 직접 삭제하는것 방지
            dataGridView2.AutoGenerateColumns = false; // 열, 너비를 사용자 정의로 사용
            dataGridView2.DefaultCellStyle.WrapMode = DataGridViewTriState.True; // 글이 여러줄 일때 자동 띄워쓰기 기능

            var columnField = new DataGridViewTextBoxColumn
            {
                Name = "Field",
                HeaderText = "Field",
                Width = 100 
            };

            var columnValue = new DataGridViewTextBoxColumn
            {
                Name = "Value",
                HeaderText = "Value",
                Width = 800
            };

            dataGridView2.Columns.Add(columnField);
            dataGridView2.Columns.Add(columnValue);

            dataGridView2.ColumnHeadersVisible = false; // 제목 줄 안보이게

            using (var connection = new SQLiteConnection(DatabaseConfig.ConnectionString))
            {
                connection.Open();

                using (var command = new SQLiteCommand(selectQuery, connection))
                {
                    command.Parameters.AddWithValue("@boardNumber", boardNumber);

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) 
                        {
                            dataGridView2.Rows.Add("번호", boardNumber);
                            dataGridView2.Rows.Add("작성일", reader["boardDate"].ToString());
                            dataGridView2.Rows.Add("제목", reader["boardTitle"].ToString());
                            //dataGridView2.Rows.Add("내용", reader["boardContext"].ToString());
                            int contentRowIndex = dataGridView2.Rows.Add("내용", reader["boardContext"].ToString());
                            dataGridView2.Rows[contentRowIndex].Height = 350; // 내용 칸 높이 설정
                        }
                        else
                        {
                            MessageBox.Show("게시글이 없습니다.", "Error");
                        }
                    }
                }
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
