namespace APP
{
    partial class TraBoardGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TraBoardGame));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            searchButton = new Button();
            searchBar = new TextBox();
            refreshButton = new Button();
            label14 = new Label();
            TTTraBoardGame = new DataGridView();
            tabPage2 = new TabPage();
            dateTimePicker1 = new DateTimePicker();
            button2 = new Button();
            label3 = new Label();
            label2 = new Label();
            mahd = new TextBox();
            label1 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)TTTraBoardGame).BeginInit();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(2, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1122, 765);
            tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            tabPage1.BackgroundImage = (Image)resources.GetObject("tabPage1.BackgroundImage");
            tabPage1.Controls.Add(searchButton);
            tabPage1.Controls.Add(searchBar);
            tabPage1.Controls.Add(refreshButton);
            tabPage1.Controls.Add(label14);
            tabPage1.Controls.Add(TTTraBoardGame);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(1114, 732);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Thông Tin Trả BoardGame";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            searchButton.BackColor = Color.LightBlue;
            searchButton.Location = new Point(716, 673);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(94, 50);
            searchButton.TabIndex = 17;
            searchButton.Text = "Search";
            searchButton.UseVisualStyleBackColor = false;
            searchButton.Click += button3_Click;
            // 
            // searchBar
            // 
            searchBar.Location = new Point(115, 685);
            searchBar.Name = "searchBar";
            searchBar.Size = new Size(524, 27);
            searchBar.TabIndex = 16;
            searchBar.TextChanged += searchBar_TextChanged;
            // 
            // refreshButton
            // 
            refreshButton.BackColor = Color.LightBlue;
            refreshButton.Location = new Point(879, 673);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(125, 50);
            refreshButton.TabIndex = 15;
            refreshButton.Text = "Làm mới";
            refreshButton.UseVisualStyleBackColor = false;
            refreshButton.Click += refreshButton_Click;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label14.ForeColor = Color.MediumOrchid;
            label14.Location = new Point(38, 34);
            label14.Name = "label14";
            label14.Size = new Size(408, 41);
            label14.TabIndex = 14;
            label14.Text = "Thông Tin Trả BoardGame";
            // 
            // TTTraBoardGame
            // 
            TTTraBoardGame.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            TTTraBoardGame.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            TTTraBoardGame.BackgroundColor = SystemColors.ButtonHighlight;
            TTTraBoardGame.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TTTraBoardGame.Location = new Point(38, 78);
            TTTraBoardGame.Name = "TTTraBoardGame";
            TTTraBoardGame.ReadOnly = true;
            TTTraBoardGame.RowHeadersWidth = 51;
            TTTraBoardGame.RowTemplate.Height = 29;
            TTTraBoardGame.Size = new Size(1034, 587);
            TTTraBoardGame.TabIndex = 13;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dateTimePicker1);
            tabPage2.Controls.Add(button2);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(mahd);
            tabPage2.Controls.Add(label1);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(1114, 732);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Cập nhật thông tin trả BoardGame";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(306, 179);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(257, 27);
            dateTimePicker1.TabIndex = 13;
            // 
            // button2
            // 
            button2.Location = new Point(465, 280);
            button2.Name = "button2";
            button2.Size = new Size(128, 44);
            button2.TabIndex = 12;
            button2.Text = "Cập nhật";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(148, 184);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 11;
            label3.Text = "Ngày trả";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(148, 155);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 10;
            // 
            // mahd
            // 
            mahd.Location = new Point(306, 97);
            mahd.Name = "mahd";
            mahd.Size = new Size(177, 27);
            mahd.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(148, 97);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 8;
            label1.Text = "Mã hóa đơn";
            // 
            // TraBoardGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1128, 808);
            Controls.Add(tabControl1);
            Name = "TraBoardGame";
            Text = "TraBoardGame";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)TTTraBoardGame).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private Button refreshButton;
        private Label label14;
        public DataGridView TTTraBoardGame;
        private TabPage tabPage2;
        private DateTimePicker dateTimePicker1;
        private Button button2;
        private Label label3;
        private Label label2;
        public TextBox mahd;
        private Label label1;
        private Button searchButton;
        private TextBox searchBar;
    }
}