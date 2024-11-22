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

            TabsPermission(); // 권한 값에 따라 탭 보여주기 설정

            ToolStripLabel loginStatusLabel = new ToolStripLabel() // 로그인 상태바 생성 및 글자 정렬
            {
                TextAlign = ContentAlignment.MiddleCenter,
                Alignment = ToolStripItemAlignment.Right
            }; 

            loginStatusLabel.Text = !string.IsNullOrEmpty(LoginSession.LoggedInMemberName)
                ? $"{LoginSession.LoggedInMemberName} 님 로그인 중입니다."
                : "에러! 먼저 로그인을 해주세요.";

            menuStrip1.Items.Add(loginStatusLabel); // MenuStrip에 로그인 상태 라벨 추가

            ToolStripButton logoutButton = new ToolStripButton // 로그아웃 버튼 생성
            {
                Text = "로그아웃",
                Alignment = ToolStripItemAlignment.Right, // 우측정렬
                AutoSize = true, // 사이즈 자동 조정
                BackColor = Color.Blue, // 배경색 설정
                ForeColor = Color.White, // 글자색 설정
                Margin = new Padding(0, 0, 20, 0) // 오른쪽 여백 추가
            };

            logoutButton.Click += LogoutButton_Click; // 로그아웃 버튼 클릭 이벤트 추가
            menuStrip1.Items.Add(logoutButton); // MenuStrip에 로그아웃 버튼 추가

            tabControl1.Dock = DockStyle.Fill; // 탭 화면에 꽉차게 설정
        }
        
        // 로그아웃 기능
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            // 로그인 세션 초기화 및 로그인 화면으로 이동
            LoginSession.LoggedInMemberName = null;

            // 로그인 화면 표시
            LoginForm loginForm = new LoginForm();
            this.Hide(); // 현재 화면 숨기기
            loginForm.Show(); // 로그인 화면 표시

            // LoginForm이 닫히면 MainForm도 닫기
            loginForm.FormClosed += (s, args) => this.Close();
        }

        // 권한 값에 따라 탭 보여주기 설정
        private void TabsPermission()
        {
            // 일반 사용자: 첫 4개의 탭만 표시
            if (LoginSession.UserPermission == 1)
            {
                // 탭 4 이후로는 삭제
                while (tabControl1.TabPages.Count > 4)
                {
                    tabControl1.TabPages.RemoveAt(4); // RemoveAt(4)를 사용하여 5번째 탭부터 차례대로 제거
                }
            }
            // 관리자 및 최종 관리자: 모든 탭 표시
            else if (LoginSession.UserPermission == 2 || LoginSession.UserPermission == 3)
            {
                while (tabControl1.TabPages.Count < 7) // 현재 탭 갯수 총 7개
                {
                    tabControl1.TabPages.Add(new TabPage($"Tab {tabControl1.TabPages.Count + 1}"));
                }
            }
        }


        private void mainForm_Load(object sender, EventArgs e)
        {
            InitializeDataGridView(); // 공지사항 탭
            dataGridView1.CellDoubleClick += dataGridView1_CellContentClick; // 공지사항 글 더블클릭 시 상세내용으로 이동

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

        // 공지사항 탭 설정
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

        // 개별 셀 클릭 시 상세보기로 전환 - BoardDetailForm
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string boardNumber = dataGridView1.Rows[e.RowIndex].Cells["boardNumber"].Value.ToString();
        
                BoardDetailForm detailForm = new BoardDetailForm();
                detailForm.SetDetails(boardNumber); // 글번호로 연결
                detailForm.ShowDialog();
           }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

    }
}
