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
    public partial class TraBoardGame : Form
    {
        static MySqlConnection conn;
        public TraBoardGame()
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
        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            MySqlCommand mySqlComman = new MySqlCommand("select * from tragame", conn);
            MySqlDataReader reader = mySqlComman.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            TTTraBoardGame.DataSource = dt;
            conn.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string idthue = mahd.Text;
            DateTime selectedDate1 = dateTimePicker1.Value;
            string date1 = selectedDate1.ToString("yyyy-MM-dd");
            if (string.IsNullOrEmpty(mahd.Text))
            {
                MessageBox.Show("Mã hóa đơn không được để trống !");
            }
            else
            {
                conn.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("insert into tragame(ID_THUE,ngaytra) values(@mahd,@date)", conn);
                mySqlCommand.Parameters.AddWithValue("@mahd", idthue);
                mySqlCommand.Parameters.AddWithValue("@date", date1);
                mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Cập nhật thành công!");
                conn.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void mahd_TextChanged(object sender, EventArgs e)
        {
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string searchValue = searchBar.Text.ToString();
            search(searchValue);
        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {

        }
        public void search(string searchValue)
        {
            string query = "SELECT * FROM `tragame`" +
                " WHERE CONCAT(`ID_TRA`, `ID_THUE`, `NGAYTRA`) like '%" + searchValue + "%'";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            TTTraBoardGame.DataSource = table;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            search("");
        }

    }
}
