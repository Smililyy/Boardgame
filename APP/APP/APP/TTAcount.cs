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
    public partial class TTAcount : Form
    {
        public string account_Admin;
        public string pwd, ten, mail, phone;
        static MySqlConnection conn;
        public TTAcount(string Admin)
        {
            InitializeComponent();
            Connection();
            account_Admin = Admin;
            take_values();
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
            finally { conn.Close(); }



        }
        public void take_values()
        {
            conn.Open();
            MySqlCommand mySqlComman = new MySqlCommand("select * from admins where UserName=@account_Admin", conn);
            mySqlComman.Parameters.AddWithValue("@account_Admin", account_Admin);
            MySqlDataReader Reader = mySqlComman.ExecuteReader();
            while (Reader.Read())
            {
                account_Admin = Reader.GetString("UserName");
                ten = Reader.GetString("HOTEN");
                pwd = Reader.GetString("PassWord");
                phone = Reader.GetString("sdt");
                mail = Reader.GetString("Email");
            }
            Reader.Close();
            conn.Close();
            textBox1.Text = account_Admin;
            textBox2.Text = ten;
            textBox3.Text = pwd;
            textBox4.Text = phone;
            textBox5.Text = mail;
        }
        private void TTAcount_Load(object sender, EventArgs e)
        {

        }
    }
}
