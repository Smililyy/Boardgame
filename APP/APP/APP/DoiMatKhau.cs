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
    public partial class DoiMatKhau : Form
    {
        static MySqlConnection conn;
        public DoiMatKhau()
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
        private void update_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string passwd = textBox3.Text;
            conn.Open();
            MySqlCommand mySqlCommand = new MySqlCommand("update admins set password=@passwd where username=@user ", conn);
            mySqlCommand.Parameters.AddWithValue("@user", user);
            mySqlCommand.Parameters.AddWithValue("@passwd", passwd);
            mySqlCommand.ExecuteNonQuery();
            MessageBox.Show("Cập nhật mật khẩu thành công!");
            conn.Close();
            this.Close();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
