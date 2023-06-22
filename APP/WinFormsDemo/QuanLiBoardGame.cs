﻿using System;
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
namespace WinFormsDemo
{
    public partial class QuanLiBoardGame : Form
    {
        static MySqlConnection conn;
        public string Admin;
        public QuanLiBoardGame(string Account_Admin)
        {
            InitializeComponent();
            Connection();
            Admin = Account_Admin;
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

        private void QuanLyBoardGame_Load(object sender, EventArgs e)
        {
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
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
            MySqlCommand insertCommand1 = new MySqlCommand("insert into customers select user_login,display_name,user_pass,0,user_email from wp_users where user_login not in(select username from customers)", conn);
            insertCommand1.ExecuteNonQuery();
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

        private void thôngTinTrảBoardGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TraBoardGame TTTra = new TraBoardGame();
            TTTra.ShowDialog();
        }

        private void thôngTinThuêBoardGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThueBoardGame TTThue = new ThueBoardGame();
            TTThue.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DateTime currentDate = DateTime.Now;
            string formattedDate = currentDate.ToString("dd-MM-yyyy");
            string slkh = "0";
            string ds = "0";
            string slgame = "0";
            string HoVaTen="0";
            conn.Open();
            MySqlCommand insertCommand1 = new MySqlCommand("insert into order_game select order_id, customer_id,date(date_created) as date_created,sum(product_gross_revenue) as tongtien,count(order_id) as soluong from wp_wc_order_product_lookup where wp_wc_order_product_lookup.order_id not in (select order_id from order_game)\r\ngroup by order_id,customer_id, date(date_created)", conn);
            insertCommand1.ExecuteNonQuery();
            MySqlCommand insertCommand2 = new MySqlCommand("INSERT into thue select order_id,display_name,date_created,tongtien from order_game o join wp_users c on o.customer_id=c.id where order_id not in (select ID_thue from thue);", conn);
            insertCommand2.ExecuteNonQuery();
            conn.Close();
            conn.Open();
            MySqlCommand mySqlComman = new MySqlCommand("select count(*) as soluong from wp_users ", conn);
            MySqlDataReader Reader = mySqlComman.ExecuteReader();
            while (Reader.Read())
            {
                slkh = Reader.GetString("soluong");
            }
            Reader.Close();
            conn.Close();
            conn.Open();
            MySqlCommand mySqlComman1 = new MySqlCommand("select sum(tongtien) as doanhthu from thue ", conn);
            MySqlDataReader Reader1 = mySqlComman1.ExecuteReader();
            while (Reader1.Read())
            {
                ds = Reader1.GetString("doanhthu");
            }
            Reader1.Close();
            MySqlCommand mySqlComman2 = new MySqlCommand("select sum(soluong) as slg from order_game ", conn);
            MySqlDataReader Reader2 = mySqlComman2.ExecuteReader();
            while (Reader2.Read())
            {
                slgame = Reader2.GetString("slg");
            }
            Reader2.Close();
            MySqlCommand mySqlComman3 = new MySqlCommand("select hoten from admins where username=@Admin ", conn);
            mySqlComman3.Parameters.AddWithValue("@Admin", Admin);
            MySqlDataReader Reader3 = mySqlComman3.ExecuteReader();
            while (Reader3.Read())
            {
                HoVaTen = Reader3.GetString("hoten");
            }
            Reader3.Close();
            conn.Close();
            label2.Text = "Tính tới ngày " + formattedDate;
            label3.Text = "Có tổng " + slkh + " đăng kí tài khoản trên website";
            label4.Text = "Doanh thu thu được là: " + ds + "000 VNĐ" + "";
            label5.Text = "Có tổng " + slgame + " game được thuê";
            label6.Text = "Xin chào quản trị viên " + HoVaTen + ",";

        }
    }
}
