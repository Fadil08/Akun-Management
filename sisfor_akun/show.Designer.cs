namespace sisfor_akun
{
    partial class show
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
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.log = new FontAwesome.Sharp.IconButton();
            this.home = new FontAwesome.Sharp.IconButton();
            this.notes = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.akun = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.closeN = new System.Windows.Forms.Button();
            this.npgsqlCommandBuilder1 = new Npgsql.NpgsqlCommandBuilder();
            this.pnldata = new System.Windows.Forms.Panel();
            this.guna2ColorTransition1 = new Guna.UI2.WinForms.Guna2ColorTransition(this.components);
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(0)))), ((int)(((byte)(59)))));
            this.flowLayoutPanel1.Controls.Add(this.log);
            this.flowLayoutPanel1.Controls.Add(this.home);
            this.flowLayoutPanel1.Controls.Add(this.notes);
            this.flowLayoutPanel1.Controls.Add(this.iconButton1);
            this.flowLayoutPanel1.Controls.Add(this.akun);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(166, 410);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // log
            // 
            this.log.FlatAppearance.BorderSize = 0;
            this.log.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.log.Font = new System.Drawing.Font("Tempus Sans ITC", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.log.ForeColor = System.Drawing.Color.White;
            this.log.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            this.log.IconColor = System.Drawing.Color.White;
            this.log.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.log.IconSize = 60;
            this.log.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.log.Location = new System.Drawing.Point(3, 3);
            this.log.Name = "log";
            this.log.Size = new System.Drawing.Size(163, 93);
            this.log.TabIndex = 2;
            this.log.Text = "Management Account";
            this.log.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.log.UseVisualStyleBackColor = true;
            // 
            // home
            // 
            this.home.FlatAppearance.BorderSize = 0;
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.home.ForeColor = System.Drawing.Color.White;
            this.home.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.home.IconColor = System.Drawing.Color.Azure;
            this.home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.home.IconSize = 30;
            this.home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.home.Location = new System.Drawing.Point(3, 102);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(163, 47);
            this.home.TabIndex = 2;
            this.home.Text = "Home";
            this.home.UseVisualStyleBackColor = true;
            // 
            // notes
            // 
            this.notes.FlatAppearance.BorderSize = 0;
            this.notes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.notes.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.notes.ForeColor = System.Drawing.Color.White;
            this.notes.IconChar = FontAwesome.Sharp.IconChar.Neos;
            this.notes.IconColor = System.Drawing.Color.Azure;
            this.notes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.notes.IconSize = 30;
            this.notes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.notes.Location = new System.Drawing.Point(3, 155);
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(163, 51);
            this.notes.TabIndex = 3;
            this.notes.Text = "Notes";
            this.notes.UseVisualStyleBackColor = true;
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.List;
            this.iconButton1.IconColor = System.Drawing.Color.Azure;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(3, 212);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(163, 54);
            this.iconButton1.TabIndex = 4;
            this.iconButton1.Text = "Show ";
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // akun
            // 
            this.akun.FlatAppearance.BorderSize = 0;
            this.akun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.akun.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.akun.ForeColor = System.Drawing.Color.White;
            this.akun.IconChar = FontAwesome.Sharp.IconChar.User;
            this.akun.IconColor = System.Drawing.Color.Azure;
            this.akun.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.akun.IconSize = 30;
            this.akun.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.akun.Location = new System.Drawing.Point(3, 272);
            this.akun.Name = "akun";
            this.akun.Size = new System.Drawing.Size(163, 57);
            this.akun.TabIndex = 5;
            this.akun.Text = "Account";
            this.akun.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(0)))), ((int)(((byte)(59)))));
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.closeN, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 40);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // closeN
            // 
            this.closeN.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeN.FlatAppearance.BorderSize = 0;
            this.closeN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeN.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.closeN.ForeColor = System.Drawing.Color.White;
            this.closeN.Location = new System.Drawing.Point(760, 3);
            this.closeN.Name = "closeN";
            this.closeN.Size = new System.Drawing.Size(37, 34);
            this.closeN.TabIndex = 1;
            this.closeN.Text = "X";
            this.closeN.UseVisualStyleBackColor = true;
            // 
            // npgsqlCommandBuilder1
            // 
            this.npgsqlCommandBuilder1.QuotePrefix = "\"";
            this.npgsqlCommandBuilder1.QuoteSuffix = "\"";
            // 
            // pnldata
            // 
            this.pnldata.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(4)))), ((int)(((byte)(94)))));
            this.pnldata.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnldata.Location = new System.Drawing.Point(0, 0);
            this.pnldata.Name = "pnldata";
            this.pnldata.Size = new System.Drawing.Size(800, 450);
            this.pnldata.TabIndex = 5;
            // 
            // guna2ColorTransition1
            // 
            this.guna2ColorTransition1.ColorArray = new System.Drawing.Color[] {
        System.Drawing.Color.Red,
        System.Drawing.Color.Blue,
        System.Drawing.Color.Orange};
            // 
            // show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnldata);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "show";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "show";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconButton log;
        private FontAwesome.Sharp.IconButton home;
        public FontAwesome.Sharp.IconButton notes;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton akun;
        private TableLayoutPanel tableLayoutPanel1;
        private Button closeN;
        private Npgsql.NpgsqlCommandBuilder npgsqlCommandBuilder1;
        private Panel pnldata;
        private Guna.UI2.WinForms.Guna2ColorTransition guna2ColorTransition1;
    }
}