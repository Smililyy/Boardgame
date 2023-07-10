using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace APP
{
    public partial class QuanLiBoardGame : Form
    {
        static MySqlConnection conn;
        public string Admin;
        public string slkh = "0";
        public string ds = "0";
        public string slgame = "0";
        public string HoVaTen = "0";
        public QuanLiBoardGame(string Account_Admin)
        {
            InitializeComponent();
            Connection();
            Admin = Account_Admin;
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
        }
        static void Connection()
        {
            string connstr = "server=127.0.0.1;uid=root;pwd=;database=boardgame";
            try
            {
                conn = new MySqlConnection(connstr);
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }



        }
        private void QuanLiBoardGame_Load(object sender, EventArgs e)
        {

        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoiMatKhau change = new DoiMatKhau();
            change.ShowDialog();
        }

        private void thôngTinTàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TTAcount TTacc = new TTAcount(Admin);
            TTacc.ShowDialog();
        }

        private void thôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TTKhachHang tt = new TTKhachHang();
            conn.Open();
            MySqlCommand mySqlComman = new MySqlCommand("select * from customers", conn);
            MySqlDataReader reader = mySqlComman.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            tt.TTCustomers.DataSource = dt;
            tt.ShowDialog();
            conn.Close();
        }

        private void thôngTinQuảnTrịViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongTinAdmin tt = new ThongTinAdmin();
            conn.Open();
            MySqlCommand mySqlComman = new MySqlCommand("select * from admins", conn);
            MySqlDataReader reader = mySqlComman.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            tt.TTAdmin.DataSource = dt;
            tt.ShowDialog();
            conn.Close();
        }

        private void thôngTinSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongtinBoardGame tt = new ThongtinBoardGame();
            conn.Open();
            MySqlCommand mySqlComman = new MySqlCommand("select * from boardgame", conn);
            MySqlDataReader reader = mySqlComman.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            tt.TTBoardGame.DataSource = dt;

            tt.ShowDialog();
            conn.Close();
        }

        private void thôngTinThuêBoardGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThueBoardGame TTThue = new ThueBoardGame();
            TTThue.ShowDialog();
        }

        private void thôngTinTrảBoardGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraBoardGame TTTra = new TraBoardGame();
            TTTra.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime selectedDate1 = dateTimePicker1.Value;
            string date1 = selectedDate1.ToString("yyyy-MM-dd");
            DateTime selectedDate2 = dateTimePicker2.Value;
            string date2 = selectedDate2.ToString("yyyy-MM-dd");
            if (conn.State != System.Data.ConnectionState.Closed)
            {
                conn.Close();
            }
            conn.Open();
            MySqlCommand mySqlComman = new MySqlCommand("select count(*) as soluong from customers where date(ngaytao) between @date1 and @date2 ", conn);
            mySqlComman.Parameters.AddWithValue("@date1", date1);
            mySqlComman.Parameters.AddWithValue("@date2", date2);
            MySqlDataReader Reader = mySqlComman.ExecuteReader();
            while (Reader.Read())
            {
                slkh = Reader.GetString("soluong");
            }
            Reader.Close();
            MySqlCommand mySqlComman1 = new MySqlCommand("select IFNULL(SUM(tongtien), 0) as dt from thue where ngaythue between @date1 and @date2 ", conn);
            mySqlComman1.Parameters.AddWithValue("@date1", date1);
            mySqlComman1.Parameters.AddWithValue("@date2", date2);
            MySqlDataReader Reader1 = mySqlComman1.ExecuteReader();
            while (Reader1.Read())
            {
                ds = Reader1.GetString("dt");
            }
            Reader1.Close();
            MySqlCommand mySqlComman2 = new MySqlCommand("select IFNULL(SUM(soluong), 0) as slg from thuegame join thue on thuegame.id_thue=thue.id_thue where ngaythue between @date1 and @date2 ", conn);
            mySqlComman2.Parameters.AddWithValue("@date1", date1);
            mySqlComman2.Parameters.AddWithValue("@date2", date2);
            MySqlDataReader Reader2 = mySqlComman2.ExecuteReader();
            while (Reader2.Read())
            {
                slgame = Reader2.GetString("slg");
            }
            Reader2.Close();
            conn.Close();
            conn.Open();
            MySqlCommand Command1 = new MySqlCommand("WITH temp AS (SELECT t.USERNAME, HOTEN, sdt,IFNULL(SUM(tongtien), 0) AS DoanhSo FROM thue t JOIN customers c ON t.username = c.username WHERE ngaythue BETWEEN @date1 AND @date2 GROUP BY t.username, hoten, sdt ORDER BY SUM(tongtien) DESC LIMIT 3) select USERNAME,HOTEN,sdt,concat(DoanhSo,'000') as DoanhSo from temp", conn);
            Command1.Parameters.AddWithValue("@date1", date1);
            Command1.Parameters.AddWithValue("@date2", date2);
            MySqlDataReader reader = Command1.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            TKSP.DataSource = dt;
            conn.Close();
            string date3 = selectedDate1.ToString("dd-MM-yyyy");
            string date4 = selectedDate2.ToString("dd-MM-yyyy");
            label2.Text = "Tính từ ngày " + date3 + " tới ngày " + date4;
            label3.Text = "Có tổng " + slkh + " đăng kí tài khoản trên website";
            label4.Text = "Doanh thu thu được là: " + ds + " VNĐ" + "";
            label5.Text = "Có tổng " + slgame + " game được thuê";
        }

        private void TKSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DateTime selectedDate1 = dateTimePicker1.Value;
            string date1 = selectedDate1.ToString("yyyy-MM-dd");
            DateTime selectedDate2 = dateTimePicker2.Value;
            string date2 = selectedDate2.ToString("yyyy-MM-dd");
            if (conn.State != System.Data.ConnectionState.Closed)
            {
                conn.Close();
            }
            conn.Open();
            MySqlCommand mySqlComman3 = new MySqlCommand("select hoten from admins where username=@Admin ", conn);
            mySqlComman3.Parameters.AddWithValue("@Admin", Admin);
            MySqlDataReader Reader3 = mySqlComman3.ExecuteReader();
            while (Reader3.Read())
            {
                HoVaTen = Reader3.GetString("hoten");
            }
            Reader3.Close();
            conn.Close();
            label6.Text = "Xin chào quản trị viên " + HoVaTen + ",";
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinTrảBoardGameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            TraBoardGame TTTra = new TraBoardGame();
            TTTra.ShowDialog();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }


        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

    }
}
