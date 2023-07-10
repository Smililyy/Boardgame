namespace APP
{
    partial class TTKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TTKhachHang));
            TTKH = new TabControl();
            TTSP = new TabPage();
            refreshButton = new Button();
            searchButton = new Button();
            searchBar = new TextBox();
            label14 = new Label();
            TTCustomers = new DataGridView();
            addKH = new TabPage();
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
            label4 = new Label();
            delKH = new TabPage();
            label5 = new Label();
            label3 = new Label();
            panel1 = new Panel();
            delSp = new Button();
            label1 = new Label();
            tentk = new TextBox();
            updateKH = new TabPage();
            panel3 = new Panel();
            tkmail = new TextBox();
            suaBG = new Button();
            label2 = new Label();
            phonenb = new TextBox();
            label15 = new Label();
            matkhau = new TextBox();
            label16 = new Label();
            hovten = new TextBox();
            label17 = new Label();
            account = new TextBox();
            label18 = new Label();
            label13 = new Label();
            label6 = new Label();
            TTKH.SuspendLayout();
            TTSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TTCustomers).BeginInit();
            addKH.SuspendLayout();
            AddAdmin.SuspendLayout();
            delKH.SuspendLayout();
            panel1.SuspendLayout();
            updateKH.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // TTKH
            // 
            TTKH.Controls.Add(TTSP);
            TTKH.Controls.Add(addKH);
            TTKH.Controls.Add(delKH);
            TTKH.Controls.Add(updateKH);
            TTKH.Location = new Point(1, 1);
            TTKH.Name = "TTKH";
            TTKH.SelectedIndex = 0;
            TTKH.Size = new Size(1243, 745);
            TTKH.TabIndex = 6;
            // 
            // TTSP
            // 
            TTSP.BackgroundImage = (Image)resources.GetObject("TTSP.BackgroundImage");
            TTSP.Controls.Add(refreshButton);
            TTSP.Controls.Add(searchButton);
            TTSP.Controls.Add(searchBar);
            TTSP.Controls.Add(label14);
            TTSP.Controls.Add(TTCustomers);
            TTSP.Location = new Point(4, 29);
            TTSP.Name = "TTSP";
            TTSP.Padding = new Padding(3);
            TTSP.Size = new Size(1235, 712);
            TTSP.TabIndex = 0;
            TTSP.Text = "Thông tin khách hàng";
            TTSP.UseVisualStyleBackColor = true;
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.LightBlue;
            refreshButton.Location = new Point(1030, 607);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(94, 50);
            refreshButton.TabIndex = 12;
            refreshButton.Text = "Làm mới";
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += button1_Click;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.LightBlue;
            searchButton.Location = new Point(840, 607);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(94, 50);
            searchButton.TabIndex = 11;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // searchBar
            // 
            searchBar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            searchBar.Location = new Point(257, 615);
            searchBar.Name = "searchBar";
            searchBar.Size = new Size(488, 31);
            searchBar.TabIndex = 10;
            // 
            // label14
            // 
            label14.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label14.ForeColor = Color.Cornsilk;
            label14.Location = new Point(36, 19);
            label14.Name = "label14";
            label14.Size = new Size(405, 51);
            label14.TabIndex = 9;
            label14.Text = "Thông Tin Khách hàng";
            label14.TextAlign = ContentAlignment.MiddleLeft;
            label14.Click += label14_Click;
            // 
            // TTCustomers
            // 
            TTCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            TTCustomers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            TTCustomers.BackgroundColor = SystemColors.ButtonHighlight;
            TTCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TTCustomers.Location = new Point(36, 73);
            TTCustomers.Name = "TTCustomers";
            TTCustomers.ReadOnly = true;
            TTCustomers.RowHeadersWidth = 51;
            TTCustomers.RowTemplate.Height = 29;
            TTCustomers.Size = new Size(1158, 491);
            TTCustomers.TabIndex = 8;
            // 
            // addKH
            // 
            addKH.BackgroundImage = (Image)resources.GetObject("addKH.BackgroundImage");
            addKH.Controls.Add(AddAdmin);
            addKH.Controls.Add(label4);
            addKH.Location = new Point(4, 29);
            addKH.Name = "addKH";
            addKH.Padding = new Padding(3);
            addKH.Size = new Size(1235, 712);
            addKH.TabIndex = 1;
            addKH.Text = "Thêm Khách hàng";
            addKH.UseVisualStyleBackColor = true;
            addKH.Click += addKH_Click;
            // 
            // AddAdmin
            // 
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
            AddAdmin.Location = new Point(238, 112);
            AddAdmin.Name = "AddAdmin";
            AddAdmin.Size = new Size(636, 443);
            AddAdmin.TabIndex = 13;
            // 
            // them
            // 
            them.BackColor = Color.Green;
            them.Location = new Point(346, 351);
            them.Name = "them";
            them.Size = new Size(97, 38);
            them.TabIndex = 10;
            them.Text = "Thêm";
            them.UseVisualStyleBackColor = false;
            them.Click += them_Click;
            // 
            // tkemail
            // 
            tkemail.Location = new Point(133, 277);
            tkemail.Name = "tkemail";
            tkemail.Size = new Size(268, 27);
            tkemail.TabIndex = 9;
            // 
            // email
            // 
            email.AutoSize = true;
            email.Location = new Point(60, 277);
            email.Name = "email";
            email.Size = new Size(46, 20);
            email.TabIndex = 8;
            email.Text = "Email";
            // 
            // sodienthoai
            // 
            sodienthoai.Location = new Point(133, 218);
            sodienthoai.Name = "sodienthoai";
            sodienthoai.Size = new Size(268, 27);
            sodienthoai.TabIndex = 7;
            // 
            // sdt
            // 
            sdt.AutoSize = true;
            sdt.Location = new Point(13, 218);
            sdt.Name = "sdt";
            sdt.Size = new Size(97, 20);
            sdt.TabIndex = 6;
            sdt.Text = "Số điện thoại";
            // 
            // password
            // 
            password.Location = new Point(133, 158);
            password.Name = "password";
            password.Size = new Size(268, 27);
            password.TabIndex = 5;
            // 
            // pass
            // 
            pass.AutoSize = true;
            pass.Location = new Point(32, 158);
            pass.Name = "pass";
            pass.Size = new Size(70, 20);
            pass.TabIndex = 4;
            pass.Text = "mật khẩu";
            // 
            // hovaten
            // 
            hovaten.Location = new Point(133, 99);
            hovaten.Name = "hovaten";
            hovaten.Size = new Size(268, 27);
            hovaten.TabIndex = 3;
            // 
            // name
            // 
            name.AutoSize = true;
            name.Location = new Point(32, 99);
            name.Name = "name";
            name.Size = new Size(73, 20);
            name.TabIndex = 2;
            name.Text = "Họ và tên";
            // 
            // username
            // 
            username.Location = new Point(133, 42);
            username.Name = "username";
            username.Size = new Size(268, 27);
            username.TabIndex = 1;
            // 
            // uname
            // 
            uname.AutoSize = true;
            uname.Location = new Point(32, 42);
            uname.Name = "uname";
            uname.Size = new Size(78, 20);
            uname.TabIndex = 0;
            uname.Text = "UserName";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.Cornsilk;
            label4.Location = new Point(238, 68);
            label4.Name = "label4";
            label4.Size = new Size(436, 41);
            label4.TabIndex = 12;
            label4.Text = "Thêm Tài khoản khách hàng";
            // 
            // delKH
            // 
            delKH.BackgroundImage = (Image)resources.GetObject("delKH.BackgroundImage");
            delKH.Controls.Add(label5);
            delKH.Controls.Add(label3);
            delKH.Controls.Add(panel1);
            delKH.Location = new Point(4, 29);
            delKH.Name = "delKH";
            delKH.Padding = new Padding(3);
            delKH.Size = new Size(1235, 712);
            delKH.TabIndex = 2;
            delKH.Text = "Xóa Khách hàng";
            delKH.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(186, 481);
            label5.Name = "label5";
            label5.Size = new Size(189, 20);
            label5.TabIndex = 14;
            label5.Text = "Nhập tên Username để xóa";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.Cornsilk;
            label3.Location = new Point(186, 138);
            label3.Name = "label3";
            label3.Size = new Size(412, 41);
            label3.TabIndex = 13;
            label3.Text = "Xóa Tài khoản khách hàng";
            // 
            // panel1
            // 
            panel1.Controls.Add(delSp);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(tentk);
            panel1.Location = new Point(186, 182);
            panel1.Name = "panel1";
            panel1.Size = new Size(696, 296);
            panel1.TabIndex = 12;
            // 
            // delSp
            // 
            delSp.Location = new Point(390, 169);
            delSp.Name = "delSp";
            delSp.Size = new Size(109, 47);
            delSp.TabIndex = 2;
            delSp.Text = "Xóa";
            delSp.UseVisualStyleBackColor = true;
            delSp.Click += delSp_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = SystemColors.Info;
            label1.Location = new Point(58, 66);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "UserName";
            // 
            // tentk
            // 
            tentk.Location = new Point(198, 66);
            tentk.Name = "tentk";
            tentk.Size = new Size(301, 27);
            tentk.TabIndex = 1;
            // 
            // updateKH
            // 
            updateKH.BackgroundImage = (Image)resources.GetObject("updateKH.BackgroundImage");
            updateKH.Controls.Add(panel3);
            updateKH.Controls.Add(label13);
            updateKH.Controls.Add(label6);
            updateKH.Location = new Point(4, 29);
            updateKH.Name = "updateKH";
            updateKH.Padding = new Padding(3);
            updateKH.Size = new Size(1235, 712);
            updateKH.TabIndex = 3;
            updateKH.Text = "Sửa Thông tin khách hàng";
            updateKH.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.Controls.Add(tkmail);
            panel3.Controls.Add(suaBG);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(phonenb);
            panel3.Controls.Add(label15);
            panel3.Controls.Add(matkhau);
            panel3.Controls.Add(label16);
            panel3.Controls.Add(hovten);
            panel3.Controls.Add(label17);
            panel3.Controls.Add(account);
            panel3.Controls.Add(label18);
            panel3.Location = new Point(286, 119);
            panel3.Name = "panel3";
            panel3.Size = new Size(636, 443);
            panel3.TabIndex = 17;
            // 
            // tkmail
            // 
            tkmail.Location = new Point(133, 277);
            tkmail.Name = "tkmail";
            tkmail.Size = new Size(268, 27);
            tkmail.TabIndex = 9;
            // 
            // suaBG
            // 
            suaBG.BackColor = Color.Green;
            suaBG.Location = new Point(304, 356);
            suaBG.Name = "suaBG";
            suaBG.Size = new Size(97, 38);
            suaBG.TabIndex = 10;
            suaBG.Text = "Sửa";
            suaBG.UseVisualStyleBackColor = false;
            suaBG.Click += suaBG_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 277);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 8;
            label2.Text = "Email";
            // 
            // phonenb
            // 
            phonenb.Location = new Point(133, 218);
            phonenb.Name = "phonenb";
            phonenb.Size = new Size(268, 27);
            phonenb.TabIndex = 7;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(13, 218);
            label15.Name = "label15";
            label15.Size = new Size(97, 20);
            label15.TabIndex = 6;
            label15.Text = "Số điện thoại";
            // 
            // matkhau
            // 
            matkhau.Location = new Point(133, 158);
            matkhau.Name = "matkhau";
            matkhau.Size = new Size(268, 27);
            matkhau.TabIndex = 5;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(32, 158);
            label16.Name = "label16";
            label16.Size = new Size(70, 20);
            label16.TabIndex = 4;
            label16.Text = "mật khẩu";
            // 
            // hovten
            // 
            hovten.Location = new Point(133, 99);
            hovten.Name = "hovten";
            hovten.Size = new Size(268, 27);
            hovten.TabIndex = 3;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(32, 99);
            label17.Name = "label17";
            label17.Size = new Size(73, 20);
            label17.TabIndex = 2;
            label17.Text = "Họ và tên";
            // 
            // account
            // 
            account.Location = new Point(133, 42);
            account.Name = "account";
            account.Size = new Size(268, 27);
            account.TabIndex = 1;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(32, 42);
            label18.Name = "label18";
            label18.Size = new Size(78, 20);
            label18.TabIndex = 0;
            label18.Text = "UserName";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(286, 565);
            label13.Name = "label13";
            label13.Size = new Size(751, 20);
            label13.TabIndex = 16;
            label13.Text = "Nhập đầy đủ các thông tin cần sửa, những thông tin không sửa vui lòng nhập như cũ (UserName không thay đổi)";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.ForeColor = Color.Cornsilk;
            label6.Location = new Point(286, 75);
            label6.Name = "label6";
            label6.Size = new Size(401, 41);
            label6.TabIndex = 15;
            label6.Text = "Sửa thông tin Khách hàng\r\n";
            // 
            // TTKhachHang
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1247, 778);
            Controls.Add(TTKH);
            Name = "TTKhachHang";
            Text = "TTKhachHang";
            TTKH.ResumeLayout(false);
            TTSP.ResumeLayout(false);
            TTSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TTCustomers).EndInit();
            addKH.ResumeLayout(false);
            addKH.PerformLayout();
            AddAdmin.ResumeLayout(false);
            AddAdmin.PerformLayout();
            delKH.ResumeLayout(false);
            delKH.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            updateKH.ResumeLayout(false);
            updateKH.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TTKH;
        private TabPage TTSP;
        private Label label14;
        public DataGridView TTCustomers;
        private TabPage addKH;
        private TabPage delKH;
        private TabPage updateKH;
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
        private Label label4;
        private Panel panel3;
        private TextBox tkmail;
        private Button suaBG;
        private Label label2;
        private TextBox phonenb;
        private Label label15;
        private TextBox matkhau;
        private Label label16;
        private TextBox hovten;
        private Label label17;
        private TextBox account;
        private Label label18;
        private Label label13;
        private Label label6;
        private Label label5;
        private Label label3;
        private Panel panel1;
        private Button delSp;
        private Label label1;
        private TextBox tentk;
        private Button searchButton;
        private TextBox searchBar;
        private Button refreshButton;
    }
}