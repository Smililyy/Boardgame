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
    public partial class ThongTinAdmin : Form
    {
        static MySqlConnection conn;
        public ThongTinAdmin()
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
            string user = username.Text;
            string passwd = password.Text;
            string hoten = hovaten.Text;
            string phone = sodienthoai.Text;
            string mail = tkemail.Text;
            conn.Open();
            MySqlCommand mySqlCommand = new MySqlCommand("insert into admins(UserName,HOTEN,PassWord,sdt,email) values(@user, @hoten, @passwd, @phone, @mail) ", conn);
            mySqlCommand.Parameters.AddWithValue("@user", user);
            mySqlCommand.Parameters.AddWithValue("@hoten", hoten);
            mySqlCommand.Parameters.AddWithValue("@passwd", passwd);
            mySqlCommand.Parameters.AddWithValue("@phone", phone);
            mySqlCommand.Parameters.AddWithValue("@mail", mail);
            mySqlCommand.ExecuteNonQuery();
            MessageBox.Show("Thêm Quản trị viên thành công!");
            conn.Close();
            username.Text = "";
            hovaten.Text = "";
            password.Text = "";
            sodienthoai.Text = "";
            tkemail.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa tài khoản admin này ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                string account = tentk.Text;
                conn.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("delete from admins where UserName =@account ", conn);
                mySqlCommand.Parameters.AddWithValue("@account", account);
                mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("xóa thành công thành công!");
                conn.Close();
                tentk.Text = "";

            }
            else
            {
                MessageBox.Show("Hủy Thành Công!");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sửa tài khoản admin này ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                string user = account.Text;
                string passwd = matkhau.Text;
                string hoten = hovten.Text;
                string phone = phonenb.Text;
                string mail = tkmail.Text;
                conn.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("UPDATE admins SET HOTEN=@hoten,PassWord=@passwd,sdt=@phone,email=@mail where UserName=@user", conn);
                mySqlCommand.Parameters.AddWithValue("@user", user);
                mySqlCommand.Parameters.AddWithValue("@hoten", hoten);
                mySqlCommand.Parameters.AddWithValue("@passwd", passwd);
                mySqlCommand.Parameters.AddWithValue("@phone", phone);
                mySqlCommand.Parameters.AddWithValue("@mail", mail);
                mySqlCommand.ExecuteNonQuery();
                MessageBox.Show("Sửa Thông Tin Quản trị viên thành công!");
                account.Text = "";
                hovten.Text = "";
                matkhau.Text = "";
                phonenb.Text = "";
                tkmail.Text = "";
                conn.Close();


            }
            else
            {
                MessageBox.Show("Hủy Thành Công!");
            }
        }
    }
}
