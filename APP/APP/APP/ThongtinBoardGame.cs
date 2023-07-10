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
    public partial class ThongtinBoardGame : Form
    {
        static MySqlConnection conn;
        public ThongtinBoardGame()
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
        private void them_Click(object sender, EventArgs e)
        {
            string masp = MaBG.Text;
            string tensp = TenBG.Text;
            string gia = Gia.Text;
            string TL = Theloai.Text;
            string Soluong = SL.Text;
            string mt = Mota.Text;
            conn.Open();
            MySqlCommand mySqlCommand = new MySqlCommand("insert into boardgame values(@masp,@tensp,@gia,@TL,@soluong,@mt) ", conn);
            mySqlCommand.Parameters.AddWithValue("@masp", masp);
            mySqlCommand.Parameters.AddWithValue("@tensp", tensp);
            mySqlCommand.Parameters.AddWithValue("@gia", gia);
            mySqlCommand.Parameters.AddWithValue("@TL", TL);
            mySqlCommand.Parameters.AddWithValue("@Soluong", Soluong);
            mySqlCommand.Parameters.AddWithValue("@mt", mt);
            mySqlCommand.ExecuteNonQuery();
            MessageBox.Show("Thêm BoardGame thành công!");
            conn.Close();
            MaBG.Text = "";
            TenBG.Text = "";
            Gia.Text = "";
            Theloai.Text = "";
            SL.Text = "";
            Mota.Text = "";
        }

        private void delSp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa sản phẩm BoardGame này ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                string Masp = masp.Text;
                conn.Open();

                MySqlCommand mySqlCommand = new MySqlCommand("delete from boardgame where MASP=@masp ", conn);
                mySqlCommand.Parameters.AddWithValue("@masp", Masp);
                mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("xóa BoardGame thành công!");
                conn.Close();
                masp.Text = "";
            }
            else
            {
                MessageBox.Show("Hủy Thành Công!");
            }
        }

        private void suaBG_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sửa sản phẩm BoardGame này ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                string masp = MaBG1.Text;
                string tensp = TenBG1.Text;
                string gia = Gia1.Text;
                string TL = Theloai1.Text;
                string Soluong = SL1.Text;
                string mt = Mota1.Text;
                conn.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("update boardgame set TENSP=@tensp,GIA=@gia,THELOAI=@TL,SOLUONG=@Soluong,MOTA=@mt where MASP=@masp ", conn);
                mySqlCommand.Parameters.AddWithValue("@masp", masp);
                mySqlCommand.Parameters.AddWithValue("@tensp", tensp);
                mySqlCommand.Parameters.AddWithValue("@gia", gia);
                mySqlCommand.Parameters.AddWithValue("@TL", TL);
                mySqlCommand.Parameters.AddWithValue("@Soluong", Soluong);
                mySqlCommand.Parameters.AddWithValue("@mt", mt);
                mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("sửa BoardGame thành công!");
                conn.Close();
                MaBG.Text = "";
                TenBG.Text = "";
                Gia.Text = "";
                Theloai.Text = "";
                SL.Text = "";
                Mota.Text = "";
            }
            else
            {
                MessageBox.Show("Hủy thành công !");
            }
        }

        private void TTSP_Click(object sender, EventArgs e)
        {

        }

        private void updateBG_Click(object sender, EventArgs e)
        {

        }

        private void updateBG_Click_1(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchValue = searchBar.Text.ToString();
            search(searchValue);
        }
        public void search(string searchValue)
        {
            string query = "SELECT * FROM `boardgame` " +
                "WHERE CONCAT(`MASP`, `TENSP`, `GIA`, `THELOAI`, `SOLUONG`, `MOTA`) like '%" + searchValue + "%'";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            TTBoardGame.DataSource = table;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            search("");
        }


    }
}
