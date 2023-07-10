namespace APP
{
    partial class ThongtinBoardGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThongtinBoardGame));
            tabControl1 = new TabControl();
            TTSP = new TabPage();
            refreshButton = new Button();
            searchButton = new Button();
            searchBar = new TextBox();
            label1 = new Label();
            label14 = new Label();
            TTBoardGame = new DataGridView();
            addBG = new TabPage();
            label4 = new Label();
            AddAdmin = new Panel();
            Mota = new TextBox();
            label5 = new Label();
            them = new Button();
            SL = new TextBox();
            email = new Label();
            Theloai = new TextBox();
            sdt = new Label();
            Gia = new TextBox();
            pass = new Label();
            TenBG = new TextBox();
            name = new Label();
            MaBG = new TextBox();
            label = new Label();
            delBG = new TabPage();
            label3 = new Label();
            label2 = new Label();
            panel1 = new Panel();
            delSp = new Button();
            label6 = new Label();
            masp = new TextBox();
            updateBG = new TabPage();
            label13 = new Label();
            label7 = new Label();
            panel2 = new Panel();
            Mota1 = new TextBox();
            label8 = new Label();
            suaBG = new Button();
            SL1 = new TextBox();
            label9 = new Label();
            Theloai1 = new TextBox();
            label10 = new Label();
            Gia1 = new TextBox();
            label11 = new Label();
            TenBG1 = new TextBox();
            label12 = new Label();
            MaBG1 = new TextBox();
            label15 = new Label();
            tabControl1.SuspendLayout();
            TTSP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TTBoardGame).BeginInit();
            addBG.SuspendLayout();
            AddAdmin.SuspendLayout();
            delBG.SuspendLayout();
            panel1.SuspendLayout();
            updateBG.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(TTSP);
            tabControl1.Controls.Add(addBG);
            tabControl1.Controls.Add(delBG);
            tabControl1.Controls.Add(updateBG);
            tabControl1.Location = new Point(1, 7);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1243, 741);
            tabControl1.TabIndex = 5;
            // 
            // TTSP
            // 
            TTSP.BackgroundImage = (Image)resources.GetObject("TTSP.BackgroundImage");
            TTSP.Controls.Add(refreshButton);
            TTSP.Controls.Add(searchButton);
            TTSP.Controls.Add(searchBar);
            TTSP.Controls.Add(label1);
            TTSP.Controls.Add(label14);
            TTSP.Controls.Add(TTBoardGame);
            TTSP.Location = new Point(4, 29);
            TTSP.Name = "TTSP";
            TTSP.Padding = new Padding(3);
            TTSP.Size = new Size(1235, 708);
            TTSP.TabIndex = 0;
            TTSP.Text = "Thông tin BoardGame";
            TTSP.UseVisualStyleBackColor = true;
            TTSP.Click += TTSP_Click;
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.LightBlue;
            refreshButton.Location = new Point(1059, 632);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(94, 53);
            refreshButton.TabIndex = 16;
            refreshButton.Text = "Làm mới";
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += refreshButton_Click;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.LightBlue;
            searchButton.Location = new Point(866, 635);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(94, 50);
            searchButton.TabIndex = 15;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += searchButton_Click;
            // 
            // searchBar
            // 
            searchBar.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            searchBar.Location = new Point(247, 643);
            searchBar.Name = "searchBar";
            searchBar.Size = new Size(541, 31);
            searchBar.TabIndex = 14;
            searchBar.Text = "Hãy nhập thông tin BoardGame cần tìm";
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Cornsilk;
            label1.Location = new Point(13, 46);
            label1.Name = "label1";
            label1.Size = new Size(309, 46);
            label1.TabIndex = 13;
            label1.Text = "BoardGame";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label14
            // 
            label14.Location = new Point(0, 0);
            label14.Margin = new Padding(2, 0, 2, 0);
            label14.Name = "label14";
            label14.Size = new Size(53, 12);
            label14.TabIndex = 0;
            // 
            // TTBoardGame
            // 
            TTBoardGame.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            TTBoardGame.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            TTBoardGame.BackgroundColor = SystemColors.ButtonHighlight;
            TTBoardGame.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TTBoardGame.Location = new Point(13, 95);
            TTBoardGame.Name = "TTBoardGame";
            TTBoardGame.ReadOnly = true;
            TTBoardGame.RowHeadersWidth = 51;
            TTBoardGame.RowTemplate.Height = 29;
            TTBoardGame.Size = new Size(1206, 511);
            TTBoardGame.TabIndex = 8;
            // 
            // addBG
            // 
            addBG.BackgroundImage = (Image)resources.GetObject("addBG.BackgroundImage");
            addBG.Controls.Add(label4);
            addBG.Controls.Add(AddAdmin);
            addBG.Location = new Point(4, 29);
            addBG.Name = "addBG";
            addBG.Padding = new Padding(3);
            addBG.Size = new Size(1235, 708);
            addBG.TabIndex = 1;
            addBG.Text = "Thêm BoardGame";
            addBG.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label4.ForeColor = Color.Cyan;
            label4.Location = new Point(193, 59);
            label4.Name = "label4";
            label4.Size = new Size(283, 41);
            label4.TabIndex = 12;
            label4.Text = "Thêm BoardGame";
            // 
            // AddAdmin
            // 
            AddAdmin.Controls.Add(Mota);
            AddAdmin.Controls.Add(label5);
            AddAdmin.Controls.Add(them);
            AddAdmin.Controls.Add(SL);
            AddAdmin.Controls.Add(email);
            AddAdmin.Controls.Add(Theloai);
            AddAdmin.Controls.Add(sdt);
            AddAdmin.Controls.Add(Gia);
            AddAdmin.Controls.Add(pass);
            AddAdmin.Controls.Add(TenBG);
            AddAdmin.Controls.Add(name);
            AddAdmin.Controls.Add(MaBG);
            AddAdmin.Controls.Add(label);
            AddAdmin.Location = new Point(193, 103);
            AddAdmin.Name = "AddAdmin";
            AddAdmin.Size = new Size(636, 443);
            AddAdmin.TabIndex = 11;
            // 
            // Mota
            // 
            Mota.Location = new Point(133, 334);
            Mota.Name = "Mota";
            Mota.Size = new Size(268, 27);
            Mota.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.BlanchedAlmond;
            label5.Location = new Point(47, 334);
            label5.Name = "label5";
            label5.Size = new Size(48, 20);
            label5.TabIndex = 11;
            label5.Text = "Mô tả";
            // 
            // them
            // 
            them.BackColor = Color.Green;
            them.Location = new Point(350, 385);
            them.Name = "them";
            them.Size = new Size(97, 38);
            them.TabIndex = 10;
            them.Text = "Thêm";
            them.UseVisualStyleBackColor = false;
            them.Click += them_Click;
            // 
            // SL
            // 
            SL.Location = new Point(133, 277);
            SL.Name = "SL";
            SL.Size = new Size(268, 27);
            SL.TabIndex = 9;
            // 
            // email
            // 
            email.AutoSize = true;
            email.BackColor = Color.BlanchedAlmond;
            email.Location = new Point(25, 277);
            email.Name = "email";
            email.Size = new Size(69, 20);
            email.TabIndex = 8;
            email.Text = "Số lượng";
            // 
            // Theloai
            // 
            Theloai.Location = new Point(133, 218);
            Theloai.Name = "Theloai";
            Theloai.Size = new Size(268, 27);
            Theloai.TabIndex = 7;
            // 
            // sdt
            // 
            sdt.AutoSize = true;
            sdt.BackColor = Color.BlanchedAlmond;
            sdt.Location = new Point(25, 221);
            sdt.Name = "sdt";
            sdt.Size = new Size(65, 20);
            sdt.TabIndex = 6;
            sdt.Text = "Thể Loại";
            // 
            // Gia
            // 
            Gia.Location = new Point(133, 158);
            Gia.Name = "Gia";
            Gia.Size = new Size(268, 27);
            Gia.TabIndex = 5;
            // 
            // pass
            // 
            pass.AutoSize = true;
            pass.BackColor = Color.BlanchedAlmond;
            pass.Location = new Point(47, 158);
            pass.Name = "pass";
            pass.Size = new Size(31, 20);
            pass.TabIndex = 4;
            pass.Text = "Giá";
            // 
            // TenBG
            // 
            TenBG.Location = new Point(133, 99);
            TenBG.Name = "TenBG";
            TenBG.Size = new Size(268, 27);
            TenBG.TabIndex = 3;
            // 
            // name
            // 
            name.AutoSize = true;
            name.BackColor = Color.BlanchedAlmond;
            name.Location = new Point(14, 99);
            name.Name = "name";
            name.Size = new Size(115, 20);
            name.TabIndex = 2;
            name.Text = "Tên BoardGame";
            // 
            // MaBG
            // 
            MaBG.Location = new Point(133, 42);
            MaBG.Name = "MaBG";
            MaBG.Size = new Size(268, 27);
            MaBG.TabIndex = 1;
            // 
            // label
            // 
            label.AutoSize = true;
            label.BackColor = Color.BlanchedAlmond;
            label.Location = new Point(14, 42);
            label.Name = "label";
            label.Size = new Size(113, 20);
            label.TabIndex = 0;
            label.Text = "Mã BoardGame";
            // 
            // delBG
            // 
            delBG.BackgroundImage = (Image)resources.GetObject("delBG.BackgroundImage");
            delBG.Controls.Add(label3);
            delBG.Controls.Add(label2);
            delBG.Controls.Add(panel1);
            delBG.Location = new Point(4, 29);
            delBG.Name = "delBG";
            delBG.Padding = new Padding(3);
            delBG.Size = new Size(1235, 708);
            delBG.TabIndex = 2;
            delBG.Text = "Xóa BoardGame";
            delBG.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.ForeColor = Color.MidnightBlue;
            label3.Location = new Point(189, 141);
            label3.Name = "label3";
            label3.Size = new Size(259, 41);
            label3.TabIndex = 10;
            label3.Text = "Xóa BoardGame";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Turquoise;
            label2.Location = new Point(189, 484);
            label2.Name = "label2";
            label2.Size = new Size(435, 20);
            label2.TabIndex = 9;
            label2.Text = "Nhập Mã BoardGame cần xóa (Mã BoardGame là mã sản phẩm)";
            // 
            // panel1
            // 
            panel1.Controls.Add(delSp);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(masp);
            panel1.Location = new Point(189, 185);
            panel1.Name = "panel1";
            panel1.Size = new Size(696, 296);
            panel1.TabIndex = 8;
            // 
            // delSp
            // 
            delSp.BackColor = Color.LightBlue;
            delSp.Location = new Point(390, 169);
            delSp.Name = "delSp";
            delSp.Size = new Size(109, 47);
            delSp.TabIndex = 2;
            delSp.Text = "Xóa";
            delSp.UseVisualStyleBackColor = false;
            delSp.Click += delSp_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Turquoise;
            label6.Location = new Point(58, 66);
            label6.Name = "label6";
            label6.Size = new Size(113, 20);
            label6.TabIndex = 0;
            label6.Text = "Mã BoardGame";
            // 
            // masp
            // 
            masp.Location = new Point(198, 66);
            masp.Name = "masp";
            masp.Size = new Size(301, 27);
            masp.TabIndex = 1;
            // 
            // updateBG
            // 
            updateBG.BackgroundImage = (Image)resources.GetObject("updateBG.BackgroundImage");
            updateBG.Controls.Add(label13);
            updateBG.Controls.Add(label7);
            updateBG.Controls.Add(panel2);
            updateBG.Location = new Point(4, 29);
            updateBG.Name = "updateBG";
            updateBG.Padding = new Padding(3);
            updateBG.Size = new Size(1235, 708);
            updateBG.TabIndex = 3;
            updateBG.Text = "Sửa BoardGame";
            updateBG.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.BackColor = Color.DarkCyan;
            label13.Location = new Point(193, 549);
            label13.Name = "label13";
            label13.Size = new Size(786, 20);
            label13.TabIndex = 16;
            label13.Text = "Nhập đầy đủ các thông tin cần sửa, những thông tin không sửa vui lòng nhập như cũ (Mã BoardGame không thay đổi)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label7.ForeColor = Color.PaleGreen;
            label7.Location = new Point(193, 59);
            label7.Name = "label7";
            label7.Size = new Size(257, 41);
            label7.TabIndex = 15;
            label7.Text = "Sửa BoardGame";
            // 
            // panel2
            // 
            panel2.Controls.Add(Mota1);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(suaBG);
            panel2.Controls.Add(SL1);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(Theloai1);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(Gia1);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(TenBG1);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(MaBG1);
            panel2.Controls.Add(label15);
            panel2.Location = new Point(193, 103);
            panel2.Name = "panel2";
            panel2.Size = new Size(636, 443);
            panel2.TabIndex = 14;
            // 
            // Mota1
            // 
            Mota1.Location = new Point(133, 334);
            Mota1.Name = "Mota1";
            Mota1.Size = new Size(268, 27);
            Mota1.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.DarkCyan;
            label8.Location = new Point(47, 334);
            label8.Name = "label8";
            label8.Size = new Size(48, 20);
            label8.TabIndex = 11;
            label8.Text = "Mô tả";
            // 
            // suaBG
            // 
            suaBG.BackColor = Color.Green;
            suaBG.Location = new Point(350, 385);
            suaBG.Name = "suaBG";
            suaBG.Size = new Size(97, 38);
            suaBG.TabIndex = 10;
            suaBG.Text = "Sửa";
            suaBG.UseVisualStyleBackColor = false;
            suaBG.Click += suaBG_Click;
            // 
            // SL1
            // 
            SL1.Location = new Point(133, 277);
            SL1.Name = "SL1";
            SL1.Size = new Size(268, 27);
            SL1.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.DarkCyan;
            label9.Location = new Point(25, 277);
            label9.Name = "label9";
            label9.Size = new Size(69, 20);
            label9.TabIndex = 8;
            label9.Text = "Số lượng";
            // 
            // Theloai1
            // 
            Theloai1.Location = new Point(133, 218);
            Theloai1.Name = "Theloai1";
            Theloai1.Size = new Size(268, 27);
            Theloai1.TabIndex = 7;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.BackColor = Color.DarkCyan;
            label10.Location = new Point(25, 221);
            label10.Name = "label10";
            label10.Size = new Size(65, 20);
            label10.TabIndex = 6;
            label10.Text = "Thể Loại";
            // 
            // Gia1
            // 
            Gia1.Location = new Point(133, 158);
            Gia1.Name = "Gia1";
            Gia1.Size = new Size(268, 27);
            Gia1.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.BackColor = Color.DarkCyan;
            label11.Location = new Point(47, 158);
            label11.Name = "label11";
            label11.Size = new Size(31, 20);
            label11.TabIndex = 4;
            label11.Text = "Giá";
            // 
            // TenBG1
            // 
            TenBG1.Location = new Point(133, 99);
            TenBG1.Name = "TenBG1";
            TenBG1.Size = new Size(268, 27);
            TenBG1.TabIndex = 3;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.BackColor = Color.DarkCyan;
            label12.Location = new Point(14, 99);
            label12.Name = "label12";
            label12.Size = new Size(115, 20);
            label12.TabIndex = 2;
            label12.Text = "Tên BoardGame";
            // 
            // MaBG1
            // 
            MaBG1.Location = new Point(133, 42);
            MaBG1.Name = "MaBG1";
            MaBG1.Size = new Size(268, 27);
            MaBG1.TabIndex = 1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.BackColor = Color.DarkCyan;
            label15.Location = new Point(14, 42);
            label15.Name = "label15";
            label15.Size = new Size(113, 20);
            label15.TabIndex = 0;
            label15.Text = "Mã BoardGame";
            // 
            // ThongtinBoardGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1246, 755);
            Controls.Add(tabControl1);
            Name = "ThongtinBoardGame";
            Text = "ThongtinBoardGame";
            tabControl1.ResumeLayout(false);
            TTSP.ResumeLayout(false);
            TTSP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TTBoardGame).EndInit();
            addBG.ResumeLayout(false);
            addBG.PerformLayout();
            AddAdmin.ResumeLayout(false);
            AddAdmin.PerformLayout();
            delBG.ResumeLayout(false);
            delBG.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            updateBG.ResumeLayout(false);
            updateBG.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage TTSP;
        private Label label14;
        public DataGridView TTBoardGame;
        private TabPage addBG;
        private TabPage delBG;
        private TabPage updateBG;
        private Label label4;
        private Panel AddAdmin;
        private TextBox Mota;
        private Label label5;
        private Button them;
        private TextBox SL;
        private Label email;
        private TextBox Theloai;
        private Label sdt;
        private TextBox Gia;
        private Label pass;
        private TextBox TenBG;
        private Label name;
        private TextBox MaBG;
        private Label label;
        private Label label1;
        private Label label3;
        private Label label2;
        private Panel panel1;
        private Button delSp;
        private Label label6;
        private TextBox masp;
        private Label label13;
        private Label label7;
        private Panel panel2;
        private TextBox Mota1;
        private Label label8;
        private Button suaBG;
        private TextBox SL1;
        private Label label9;
        private TextBox Theloai1;
        private Label label10;
        private TextBox Gia1;
        private Label label11;
        private TextBox TenBG1;
        private Label label12;
        private TextBox MaBG1;
        private Label label15;
        private Button searchButton;
        private TextBox searchBar;
        private Button refreshButton;
    }
}