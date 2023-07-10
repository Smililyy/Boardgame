namespace APP
{
    partial class QuanLiBoardGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLiBoardGame));
            panel1 = new Panel();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            TKSP = new DataGridView();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            adminToolStripMenuItem = new ToolStripMenuItem();
            thôngTinTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            đổiMậtKhẩuToolStripMenuItem = new ToolStripMenuItem();
            đăngXuấtToolStripMenuItem = new ToolStripMenuItem();
            thôngTinKháchHàngToolStripMenuItem = new ToolStripMenuItem();
            thôngTinQuảnTrịViênToolStripMenuItem = new ToolStripMenuItem();
            thôngTinSảnPhẩmToolStripMenuItem = new ToolStripMenuItem();
            thôngTinThuêBoardGameToolStripMenuItem = new ToolStripMenuItem();
            thôngTinTrảBoardGameToolStripMenuItem = new ToolStripMenuItem();
            thôngTinTrảBoardGameToolStripMenuItem1 = new ToolStripMenuItem();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TKSP).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label8);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(TKSP);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(72, 89);
            panel1.Name = "panel1";
            panel1.Size = new Size(1300, 756);
            panel1.TabIndex = 17;
            panel1.Paint += panel1_Paint;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.LightBlue;
            label9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label9.Location = new Point(22, 276);
            label9.Name = "label9";
            label9.Size = new Size(587, 28);
            label9.TabIndex = 15;
            label9.Text = "Danh sách top 3 các khách hàng thuê game với doanh số cao nhất";
            label9.Click += label9_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.LightBlue;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(22, 67);
            label8.Name = "label8";
            label8.Size = new Size(82, 28);
            label8.TabIndex = 14;
            label8.Text = "Từ ngày";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.LightBlue;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(543, 67);
            label7.Name = "label7";
            label7.Size = new Size(93, 28);
            label7.TabIndex = 13;
            label7.Text = "đến ngày";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker2.Location = new Point(721, 64);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(310, 34);
            dateTimePicker2.TabIndex = 12;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dateTimePicker1.Location = new Point(136, 67);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(333, 34);
            dateTimePicker1.TabIndex = 11;
            // 
            // button1
            // 
            button1.BackColor = Color.LightBlue;
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(874, 125);
            button1.Name = "button1";
            button1.Size = new Size(155, 41);
            button1.TabIndex = 10;
            button1.Text = "Xem thống kê";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // TKSP
            // 
            TKSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            TKSP.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            TKSP.BackgroundColor = SystemColors.ButtonHighlight;
            TKSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TKSP.Location = new Point(22, 319);
            TKSP.Name = "TKSP";
            TKSP.ReadOnly = true;
            TKSP.RowHeadersWidth = 51;
            TKSP.RowTemplate.Height = 29;
            TKSP.Size = new Size(631, 431);
            TKSP.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(65, 18);
            label6.Name = "label6";
            label6.Size = new Size(36, 20);
            label6.TabIndex = 4;
            label6.Text = "QTV";
            label6.Click += label6_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(473, 138);
            label5.Name = "label5";
            label5.Size = new Size(342, 20);
            label5.TabIndex = 3;
            label5.Text = "             label5                                                            ";
            label5.Click += label5_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(494, 216);
            label4.Name = "label4";
            label4.Size = new Size(342, 20);
            label4.TabIndex = 2;
            label4.Text = "     label4                                                                    ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 203);
            label3.Name = "label3";
            label3.Size = new Size(342, 20);
            label3.TabIndex = 1;
            label3.Text = "          label3                                                               ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(38, 125);
            label2.Name = "label2";
            label2.Size = new Size(338, 20);
            label2.TabIndex = 0;
            label2.Text = "          label2                                                              ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(72, 39);
            label1.Name = "label1";
            label1.Size = new Size(551, 41);
            label1.TabIndex = 15;
            label1.Text = "Trang Quản Lý cho thuê BoardGame\r\n";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { adminToolStripMenuItem, thôngTinKháchHàngToolStripMenuItem, thôngTinQuảnTrịViênToolStripMenuItem, thôngTinSảnPhẩmToolStripMenuItem, thôngTinThuêBoardGameToolStripMenuItem, thôngTinTrảBoardGameToolStripMenuItem, thôngTinTrảBoardGameToolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1367, 28);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // adminToolStripMenuItem
            // 
            adminToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinTàiKhoảnToolStripMenuItem, đổiMậtKhẩuToolStripMenuItem, đăngXuấtToolStripMenuItem });
            adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            adminToolStripMenuItem.Size = new Size(67, 24);
            adminToolStripMenuItem.Text = "Admin";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            thôngTinTàiKhoảnToolStripMenuItem.Size = new Size(220, 26);
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            thôngTinTàiKhoảnToolStripMenuItem.Click += thôngTinTàiKhoảnToolStripMenuItem_Click;
            // 
            // đổiMậtKhẩuToolStripMenuItem
            // 
            đổiMậtKhẩuToolStripMenuItem.Name = "đổiMậtKhẩuToolStripMenuItem";
            đổiMậtKhẩuToolStripMenuItem.Size = new Size(220, 26);
            đổiMậtKhẩuToolStripMenuItem.Text = "Đổi mật khẩu";
            đổiMậtKhẩuToolStripMenuItem.Click += đổiMậtKhẩuToolStripMenuItem_Click;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            đăngXuấtToolStripMenuItem.Size = new Size(220, 26);
            đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            đăngXuấtToolStripMenuItem.Click += đăngXuấtToolStripMenuItem_Click;
            // 
            // thôngTinKháchHàngToolStripMenuItem
            // 
            thôngTinKháchHàngToolStripMenuItem.Name = "thôngTinKháchHàngToolStripMenuItem";
            thôngTinKháchHàngToolStripMenuItem.Size = new Size(165, 24);
            thôngTinKháchHàngToolStripMenuItem.Text = "Thông tin khách hàng";
            thôngTinKháchHàngToolStripMenuItem.Click += thôngTinKháchHàngToolStripMenuItem_Click;
            // 
            // thôngTinQuảnTrịViênToolStripMenuItem
            // 
            thôngTinQuảnTrịViênToolStripMenuItem.Name = "thôngTinQuảnTrịViênToolStripMenuItem";
            thôngTinQuảnTrịViênToolStripMenuItem.Size = new Size(172, 24);
            thôngTinQuảnTrịViênToolStripMenuItem.Text = "Thông tin quản trị viên";
            thôngTinQuảnTrịViênToolStripMenuItem.Click += thôngTinQuảnTrịViênToolStripMenuItem_Click;
            // 
            // thôngTinSảnPhẩmToolStripMenuItem
            // 
            thôngTinSảnPhẩmToolStripMenuItem.Name = "thôngTinSảnPhẩmToolStripMenuItem";
            thôngTinSảnPhẩmToolStripMenuItem.Size = new Size(154, 24);
            thôngTinSảnPhẩmToolStripMenuItem.Text = "Thông tin sản phẩm";
            thôngTinSảnPhẩmToolStripMenuItem.Click += thôngTinSảnPhẩmToolStripMenuItem_Click;
            // 
            // thôngTinThuêBoardGameToolStripMenuItem
            // 
            thôngTinThuêBoardGameToolStripMenuItem.Name = "thôngTinThuêBoardGameToolStripMenuItem";
            thôngTinThuêBoardGameToolStripMenuItem.Size = new Size(202, 24);
            thôngTinThuêBoardGameToolStripMenuItem.Text = "Thông tin thuê BoardGame";
            thôngTinThuêBoardGameToolStripMenuItem.Click += thôngTinThuêBoardGameToolStripMenuItem_Click;
            // 
            // thôngTinTrảBoardGameToolStripMenuItem
            // 
            thôngTinTrảBoardGameToolStripMenuItem.Name = "thôngTinTrảBoardGameToolStripMenuItem";
            thôngTinTrảBoardGameToolStripMenuItem.Size = new Size(27, 24);
            thôngTinTrảBoardGameToolStripMenuItem.Text = " ";
            // 
            // thôngTinTrảBoardGameToolStripMenuItem1
            // 
            thôngTinTrảBoardGameToolStripMenuItem1.Name = "thôngTinTrảBoardGameToolStripMenuItem1";
            thôngTinTrảBoardGameToolStripMenuItem1.Size = new Size(193, 24);
            thôngTinTrảBoardGameToolStripMenuItem1.Text = "Thông tin Trả BoardGame";
            thôngTinTrảBoardGameToolStripMenuItem1.Click += thôngTinTrảBoardGameToolStripMenuItem1_Click;
            // 
            // QuanLiBoardGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1367, 851);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            Controls.Add(panel1);
            Name = "QuanLiBoardGame";
            Text = "QuanLiBoardGame";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TKSP).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label9;
        private Label label8;
        private Label label7;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        public DataGridView TKSP;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem adminToolStripMenuItem;
        private ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem đổiMậtKhẩuToolStripMenuItem;
        private ToolStripMenuItem đăngXuấtToolStripMenuItem;
        private ToolStripMenuItem thôngTinKháchHàngToolStripMenuItem;
        private ToolStripMenuItem thôngTinQuảnTrịViênToolStripMenuItem;
        private ToolStripMenuItem thôngTinSảnPhẩmToolStripMenuItem;
        private ToolStripMenuItem thôngTinThuêBoardGameToolStripMenuItem;
        private ToolStripMenuItem thôngTinTrảBoardGameToolStripMenuItem;
        private ToolStripMenuItem thôngTinTrảBoardGameToolStripMenuItem1;
    }
}