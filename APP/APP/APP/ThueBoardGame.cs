using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APP
{
    public partial class ThueBoardGame : Form
    {
        static MySqlConnection conn;
        public ThueBoardGame()
        {
            InitializeComponent();
            Connection();
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand mySqlComman = new MySqlCommand("select ID_THUE,USERNAME,NGAYTHUE,concat(TONGTIEN,'.000') as TONGTIEN from THUE", conn);
            MySqlDataReader reader = mySqlComman.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            TTThueBoardGame.DataSource = dt;
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand mySqlComman = new MySqlCommand("select ID_THUE,MASP,TENSP, sum(soluong) from thuegame group by ID_THUE, MASP,TENSP", conn);
            MySqlDataReader reader = mySqlComman.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            TTSPThue.DataSource = dt;
            conn.Close();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
        public void search(string searcValue)
        {
            string query = "SELECT * FROM `thuegame`" +
                " WHERE CONCAT(`ID_THUE`, `MASP`, `TENSP`, `SOLUONG`) like '%" + searcValue + "%'";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            TTThueBoardGame.DataSource = table;
        }

        private void TTThueBoardGame_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchValue = searchBar.Text.ToString();
            search(searchValue);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            search("");
        }


    }
}
