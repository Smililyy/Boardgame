namespace APP
{
    partial class ThongTinAdmin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongTinAdmin));
            tabControl = new TabControl();
            info = new TabPage();
            label1 = new Label();
            TTAdmin = new DataGridView();
            insert = new TabPage();
            label2 = new Label();
            AddAdmin = new Panel();
            them = new Button();
            tkemail = new TextBox();
            email = new Label();
            sodienthoai = new TextBox();
            sdt = new Label();
            password = new TextBox();
            pass = new Label();
            hovaten = new TextBox();
            name = new Label();
            username = new TextBox();
            uname = new Label();
            delete = new TabPage();
            label5 = new Label();
            label4 = new Label();
            button1 = new Button();
            tentk = new TextBox();
            label3 = new Label();
            update = new TabPage();
            label12 = new Label();
            label11 = new Label();
            panel1 = new Panel();
            button10 = new Button();
            tkmail = new TextBox();
            label6 = new Label();
            phonenb = new TextBox();
            label7 = new Label();
            matkhau = new TextBox();
            label8 = new Label();
            hovten = new TextBox();
            label9 = new Label();
            account = new TextBox();
            label10 = new Label();
            tabControl.SuspendLayout();
            info.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TTAdmin).BeginInit();
            insert.SuspendLayout();
            AddAdmin.SuspendLayout();
            delete.SuspendLayout();
            update.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(info);
            tabControl.Controls.Add(insert);
            tabControl.Controls.Add(delete);
            tabControl.Controls.Add(update);
            tabControl.Location = new Point(4, 2);
            tabControl.Margin = new Padding(6);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(2060, 1278);
            tabControl.TabIndex = 9;
            tabControl.TabStop = false;
            // 
            // info
            // 
            info.BackgroundImage = (Image)resources.GetObject("info.BackgroundImage");
            info.BackgroundImageLayout = ImageLayout.Stretch;
            info.Controls.Add(label1);
            info.Controls.Add(TTAdmin);
            info.Location = new Point(10, 55);
            info.Margin = new Padding(6);
            info.Name = "info";
            info.Padding = new Padding(6);
            info.Size = new Size(2040, 1213);
            info.TabIndex = 0;
            info.Text = "Thông Tin quản trị viên";
            info.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(242, 65);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(648, 72);
            label1.TabIndex = 7;
            label1.Text = "Thông tin Quản trị viên";
            // 
            // TTAdmin
            // 
            TTAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            TTAdmin.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            TTAdmin.BackgroundColor = SystemColors.ButtonHighlight;
            TTAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TTAdmin.Location = new Point(236, 137);
            TTAdmin.Margin = new Padding(6);
            TTAdmin.Name = "TTAdmin";
            TTAdmin.ReadOnly = true;
            TTAdmin.RowHeadersWidth = 51;
            TTAdmin.RowTemplate.Height = 29;
            TTAdmin.Size = new Size(1483, 908);
            TTAdmin.TabIndex = 3;
            // 
            // insert
            // 
            insert.BackgroundImage = (Image)resources.GetObject("insert.BackgroundImage");
            insert.BackgroundImageLayout = ImageLayout.Stretch;
            insert.Controls.Add(label2);
            insert.Controls.Add(AddAdmin);
            insert.Location = new Point(10, 55);
            insert.Margin = new Padding(6);
            insert.Name = "insert";
            insert.Padding = new Padding(6);
            insert.Size = new Size(2040, 1213);
            insert.TabIndex = 1;
            insert.Text = "Thêm quản trị viên";
            insert.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(371, 118);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(539, 72);
            label2.TabIndex = 10;
            label2.Text = "Thêm Quản trị viên";
            // 
            // AddAdmin
            // 
            AddAdmin.BackColor = Color.White;
            AddAdmin.Controls.Add(them);
            AddAdmin.Controls.Add(tkemail);
            AddAdmin.Controls.Add(email);
            AddAdmin.Controls.Add(sodienthoai);
            AddAdmin.Controls.Add(sdt);
            AddAdmin.Controls.Add(password);
            AddAdmin.Controls.Add(pass);
            AddAdmin.Controls.Add(hovaten);
            AddAdmin.Controls.Add(name);
            AddAdmin.Controls.Add(username);
            AddAdmin.Controls.Add(uname);
            AddAdmin.Location = new Point(371, 215);
            AddAdmin.Margin = new Padding(6);
            AddAdmin.Name = "AddAdmin";
            AddAdmin.Size = new Size(1192, 820);
            AddAdmin.TabIndex = 9;
            // 
            // them
            // 
            them.BackColor = Color.LightBlue;
            them.Location = new Point(758, 644);
            them.Margin = new Padding(6);
            them.Name = "them";
            them.Size = new Size(182, 70);
            them.TabIndex = 10;
            them.Text = "Thêm";
            them.UseVisualStyleBackColor = false;
            them.Click += them_Click;
            // 
            // tkemail
            // 
            tkemail.BackColor = SystemColors.ControlLight;
            tkemail.Location = new Point(429, 535);
            tkemail.Margin = new Padding(6);
            tkemail.Name = "tkemail";
            tkemail.Size = new Size(499, 43);
            tkemail.TabIndex = 9;
            // 
            // email
            // 
            email.AutoSize = true;
            email.Location = new Point(204, 535);
            email.Margin = new Padding(6, 0, 6, 0);
            email.Name = "email";
            email.Size = new Size(82, 37);
            email.TabIndex = 8;
            email.Text = "Email";
            // 
            // sodienthoai
            // 
            sodienthoai.BackColor = SystemColors.ControlLight;
            sodienthoai.Location = new Point(429, 426);
            sodienthoai.Margin = new Padding(6);
            sodienthoai.Name = "sodienthoai";
            sodienthoai.Size = new Size(499, 43);
            sodienthoai.TabIndex = 7;
            // 
            // sdt
            // 
            sdt.AutoSize = true;
            sdt.Location = new Point(204, 426);
            sdt.Margin = new Padding(6, 0, 6, 0);
            sdt.Name = "sdt";
            sdt.Size = new Size(174, 37);
            sdt.TabIndex = 6;
            sdt.Text = "Số điện thoại";
            // 
            // password
            // 
            password.BackColor = SystemColors.ControlLight;
            password.Location = new Point(429, 314);
            password.Margin = new Padding(6);
            password.Name = "password";
            password.Size = new Size(499, 43);
            password.TabIndex = 5;
            // 
            // pass
            // 
            pass.AutoSize = true;
            pass.Location = new Point(204, 314);
            pass.Margin = new Padding(6, 0, 6, 0);
            pass.Name = "pass";
            pass.Size = new Size(127, 37);
            pass.TabIndex = 4;
            pass.Text = "mật khẩu";
            // 
            // hovaten
            // 
            hovaten.BackColor = SystemColors.ControlLight;
            hovaten.Location = new Point(429, 205);
            hovaten.Margin = new Padding(6);
            hovaten.Name = "hovaten";
            hovaten.Size = new Size(499, 43);
            hovaten.TabIndex = 3;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(204, 205);
            name.Margin = new Padding(6, 0, 6, 0);
            name.Name = "name";
            name.Size = new Size(131, 37);
            name.TabIndex = 2;
            name.Text = "Họ và tên";
            // 
            // username
            // 
            username.BackColor = SystemColors.ControlLight;
            username.Location = new Point(429, 94);
            username.Margin = new Padding(6);
            username.Name = "username";
            username.Size = new Size(499, 43);
            username.TabIndex = 1;
            // 
            // uname
            // 
            uname.AutoSize = true;
            uname.Location = new Point(204, 102);
            uname.Margin = new Padding(6, 0, 6, 0);
            uname.Name = "uname";
            uname.Size = new Size(141, 37);
            uname.TabIndex = 0;
            uname.Text = "UserName";
            // 
            // delete
            // 
            delete.BackgroundImage = (Image)resources.GetObject("delete.BackgroundImage");
            delete.BackgroundImageLayout = ImageLayout.Stretch;
            delete.Controls.Add(label5);
            delete.Controls.Add(label4);
            delete.Controls.Add(button1);
            delete.Controls.Add(tentk);
            delete.Controls.Add(label3);
            delete.Location = new Point(10, 55);
            delete.Margin = new Padding(6);
            delete.Name = "delete";
            delete.Padding = new Padding(6);
            delete.Size = new Size(2040, 1213);
            delete.TabIndex = 2;
            delete.Text = "Xóa quản trị viên";
            delete.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(477, 392);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(453, 144);
            label5.TabIndex = 15;
            label5.Text = "\r\nNhập tên Username để xóa\r\n\r\n";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(477, 246);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(496, 72);
            label4.TabIndex = 14;
            label4.Text = "Xóa Quản trị viên";
            label4.Click += label4_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.LightBlue;
            button1.Location = new Point(1085, 701);
            button1.Margin = new Padding(6);
            button1.Name = "button1";
            button1.Size = new Size(206, 85);
            button1.TabIndex = 13;
            button1.Text = "Xóa";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // tentk
            // 
            tentk.BackColor = SystemColors.ControlLight;
            tentk.Location = new Point(690, 594);
            tentk.Margin = new Padding(6);
            tentk.Name = "tentk";
            tentk.Size = new Size(601, 43);
            tentk.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(477, 594);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(187, 48);
            label3.TabIndex = 11;
            label3.Text = "UserName";
            // 
            // update
            // 
            update.BackgroundImage = (Image)resources.GetObject("update.BackgroundImage");
            update.BackgroundImageLayout = ImageLayout.Stretch;
            update.Controls.Add(label12);
            update.Controls.Add(label11);
            update.Controls.Add(panel1);
            update.Location = new Point(10, 55);
            update.Margin = new Padding(6);
            update.Name = "update";
            update.Padding = new Padding(6);
            update.Size = new Size(2040, 1213);
            update.TabIndex = 3;
            update.Text = "Sửa quản trị viên";
            update.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.LightBlue;
            label12.Location = new Point(344, 180);
            label12.Margin = new Padding(6, 0, 6, 0);
            label12.Name = "label12";
            label12.Size = new Size(1347, 37);
            label12.TabIndex = 12;
            label12.Text = "Nhâp dữ liệu muốn sửa (những thông tin không đổi vui lòng nhập lại như cũ) UserName sẽ không thay đổi được";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.Transparent;
            label11.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label11.ForeColor = Color.Black;
            label11.Location = new Point(423, 82);
            label11.Margin = new Padding(6, 0, 6, 0);
            label11.Name = "label11";
            label11.Size = new Size(764, 72);
            label11.TabIndex = 11;
            label11.Text = "Sửa Thông tin Quản trị viên";
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(button10);
            panel1.Controls.Add(tkmail);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(phonenb);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(matkhau);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(hovten);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(account);
            panel1.Controls.Add(label10);
            panel1.Location = new Point(423, 240);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(1192, 820);
            panel1.TabIndex = 10;
            // 
            // button10
            // 
            button10.BackColor = Color.LightBlue;
            button10.Location = new Point(720, 657);
            button10.Margin = new Padding(6);
            button10.Name = "button10";
            button10.Size = new Size(182, 70);
            button10.TabIndex = 10;
            button10.Text = "Sửa";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // tkmail
            // 
            tkmail.BackColor = SystemColors.ControlLight;
            tkmail.Location = new Point(403, 560);
            tkmail.Margin = new Padding(6);
            tkmail.Name = "tkmail";
            tkmail.Size = new Size(499, 43);
            tkmail.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(178, 566);
            label6.Margin = new Padding(6, 0, 6, 0);
            label6.Name = "label6";
            label6.Size = new Size(82, 37);
            label6.TabIndex = 8;
            label6.Text = "Email";
            // 
            // phonenb
            // 
            phonenb.BackColor = SystemColors.ControlLight;
            phonenb.Location = new Point(403, 451);
            phonenb.Margin = new Padding(6);
            phonenb.Name = "phonenb";
            phonenb.Size = new Size(499, 43);
            phonenb.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(178, 451);
            label7.Margin = new Padding(6, 0, 6, 0);
            label7.Name = "label7";
            label7.Size = new Size(174, 37);
            label7.TabIndex = 6;
            label7.Text = "Số điện thoại";
            // 
            // matkhau
            // 
            matkhau.BackColor = SystemColors.ControlLight;
            matkhau.Location = new Point(403, 340);
            matkhau.Margin = new Padding(6);
            matkhau.Name = "matkhau";
            matkhau.Size = new Size(499, 43);
            matkhau.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(178, 343);
            label8.Margin = new Padding(6, 0, 6, 0);
            label8.Name = "label8";
            label8.Size = new Size(127, 37);
            label8.TabIndex = 4;
            label8.Text = "mật khẩu";
            // 
            // hovten
            // 
            hovten.BackColor = SystemColors.ControlLight;
            hovten.Location = new Point(403, 231);
            hovten.Margin = new Padding(6);
            hovten.Name = "hovten";
            hovten.Size = new Size(499, 43);
            hovten.TabIndex = 3;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(178, 231);
            label9.Margin = new Padding(6, 0, 6, 0);
            label9.Name = "label9";
            label9.Size = new Size(131, 37);
            label9.TabIndex = 2;
            label9.Text = "Họ và tên";
            // 
            // account
            // 
            account.BackColor = SystemColors.ControlLight;
            account.Location = new Point(403, 126);
            account.Margin = new Padding(6);
            account.Name = "account";
            account.Size = new Size(499, 43);
            account.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(178, 129);
            label10.Margin = new Padding(6, 0, 6, 0);
            label10.Name = "label10";
            label10.Size = new Size(141, 37);
            label10.TabIndex = 0;
            label10.Text = "UserName";
            // 
            // ThongTinAdmin
            // 
            AutoScaleDimensions = new SizeF(15F, 37F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(2065, 1265);
            Controls.Add(tabControl);
            Margin = new Padding(6);
            Name = "ThongTinAdmin";
            Text = "ThongTinAdmin";
            tabControl.ResumeLayout(false);
            info.ResumeLayout(false);
            info.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TTAdmin).EndInit();
            insert.ResumeLayout(false);
            insert.PerformLayout();
            AddAdmin.ResumeLayout(false);
            AddAdmin.PerformLayout();
            delete.ResumeLayout(false);
            delete.PerformLayout();
            update.ResumeLayout(false);
            update.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl;
        private TabPage info;
        private Label label1;
        public DataGridView TTAdmin;
        private TabPage insert;
        private TabPage delete;
        private TabPage update;
        private Label label2;
        private Panel AddAdmin;
        private Button them;
        private TextBox tkemail;
        private Label email;
        private TextBox sodienthoai;
        private Label sdt;
        private TextBox password;
        private Label pass;
        private TextBox hovaten;
        private Label name;
        private TextBox username;
        private Label uname;
        private Label label5;
        private Label label4;
        private Button button1;
        private TextBox tentk;
        private Label label3;
        private Label label12;
        private Label label11;
        private Panel panel1;
        private Button button10;
        private TextBox tkmail;
        private Label label6;
        private TextBox phonenb;
        private Label label7;
        private TextBox matkhau;
        private Label label8;
        private TextBox hovten;
        private Label label9;
        private TextBox account;
        private Label label10;
    }
}