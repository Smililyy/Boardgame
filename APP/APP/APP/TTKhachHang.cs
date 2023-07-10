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
    public partial class TTKhachHang : Form
    {
        static MySqlConnection conn;
        public TTKhachHang()
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

        private void TTCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void them_Click(object sender, EventArgs e)
        {
            string user = username.Text;
            string passwd = password.Text;
            string hoten = hovaten.Text;
            string phone = sodienthoai.Text;
            string mail = tkemail.Text;
            conn.Open();
            MySqlCommand mySqlCommand = new MySqlCommand("insert into Customers(UserName,HOTEN,PassWord,sdt,email) values(@user, @hoten, @passwd, @phone, @mail) ", conn);
            mySqlCommand.Parameters.AddWithValue("@user", user);
            mySqlCommand.Parameters.AddWithValue("@hoten", hoten);
            mySqlCommand.Parameters.AddWithValue("@passwd", passwd);
            mySqlCommand.Parameters.AddWithValue("@phone", phone);
            mySqlCommand.Parameters.AddWithValue("@mail", mail);
            mySqlCommand.ExecuteNonQuery();
            DateTime currentDate = DateTime.Now;

            string formattedDate = currentDate.ToString("yyyy-MM-dd");

            MySqlCommand mySqlCommand1 = new MySqlCommand("insert into wp_users(User_login,display_name,user_nicename,user_Pass,user_email,user_registered) values(@user, @hoten, @user,@passwd, @mail,@date) ", conn);
            mySqlCommand1.Parameters.AddWithValue("@user", user);
            mySqlCommand1.Parameters.AddWithValue("@hoten", hoten);
            mySqlCommand1.Parameters.AddWithValue("@passwd", passwd);
            mySqlCommand1.Parameters.AddWithValue("@mail", mail);
            mySqlCommand1.Parameters.AddWithValue("@date", formattedDate);
            mySqlCommand1.ExecuteNonQuery();
            MessageBox.Show("Thêm Khách hàng thành công!");
            conn.Close();
            username.Text = "";
            hovaten.Text = "";
            password.Text = "";
            sodienthoai.Text = "";
            tkemail.Text = "";
        }

        private void suaBG_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sửa tài khoản của khách hàng này ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                string user = account.Text;
                string passwd = matkhau.Text;
                string hoten = hovten.Text;
                string phone = phonenb.Text;
                string mail = tkmail.Text;
                conn.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("UPDATE customers SET HOTEN=@hoten,PassWord=@passwd,sdt=@phone,email=@mail where UserName=@user", conn);
                MySqlCommand mySqlCommand1 = new MySqlCommand("UPDATE wp_users SET display_name=@hoten,user_pass=@passwd,user_email=@mail where user_login=@user", conn);
                mySqlCommand.Parameters.AddWithValue("@user", user);
                mySqlCommand.Parameters.AddWithValue("@hoten", hoten);
                mySqlCommand.Parameters.AddWithValue("@passwd", passwd);
                mySqlCommand.Parameters.AddWithValue("@phone", phone);
                mySqlCommand.Parameters.AddWithValue("@mail", mail);
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand1.Parameters.AddWithValue("@user", user);
                mySqlCommand1.Parameters.AddWithValue("@hoten", hoten);
                mySqlCommand1.Parameters.AddWithValue("@passwd", passwd);
                mySqlCommand1.Parameters.AddWithValue("@mail", mail);
                mySqlCommand1.ExecuteNonQuery();
                MessageBox.Show("Sửa Thông Tin khách hàng thành công!");
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

        private void delSp_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xóa tài khoản của khách hàng này ?", "Thông báo", MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                string account = tentk.Text;
                conn.Open();
                MySqlCommand mySqlCommand = new MySqlCommand("delete from customers where UserName =@account ", conn);
                MySqlCommand mySqlCommand1 = new MySqlCommand("delete from wp_users where user_login =@account ", conn);
                mySqlCommand.Parameters.AddWithValue("@account", account);
                mySqlCommand1.Parameters.AddWithValue("@account", account);
                mySqlCommand.ExecuteNonQuery();
                mySqlCommand1.ExecuteNonQuery();
                MessageBox.Show("xóa thành công!");
                conn.Close();
                tentk.Text = "";

            }
            else
            {
                MessageBox.Show("Hủy Thành Công!");
                tentk.Text = "";
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void addKH_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            search("");
        }
        public void search(string searchValue)
        {
            string query = "SELECT * FROM `customers` " +
                "WHERE CONCAT(`USERNAME`, `HOTEN`, `PassWord`, `sdt`, `email`, `ngaytao`) like '%" + searchValue + "%'";
            MySqlCommand command = new MySqlCommand(query, conn);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            TTCustomers.DataSource = table;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchValue = searchBar.Text.ToString();
            search(searchValue);
        }


    }
}
