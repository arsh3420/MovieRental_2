namespace MovieRentalSystem
{
    partial class MainForm
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
            this.pnl_customeradd = new System.Windows.Forms.Panel();
            this.addcustomer = new System.Windows.Forms.Button();
            this.tb = new System.Windows.Forms.TextBox();
            this.tb3 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnl_customerview = new System.Windows.Forms.Panel();
            this.gridcustomer = new System.Windows.Forms.DataGridView();
            this.CustomerEdit = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItemCustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_addmovie = new System.Windows.Forms.Panel();
            this.movie_plot = new System.Windows.Forms.TextBox();
            this.addmovie = new System.Windows.Forms.Button();
            this.movie_gener = new System.Windows.Forms.TextBox();
            this.movie_copies = new System.Windows.Forms.TextBox();
            this.movie_year = new System.Windows.Forms.TextBox();
            this.movie_title = new System.Windows.Forms.TextBox();
            this.movie_rating = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pnl_viewmovie = new System.Windows.Forms.Panel();
            this.gridmovie = new System.Windows.Forms.DataGridView();
            this.menumovie = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.issueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_return = new System.Windows.Forms.Panel();
            this.dataGridView1return = new System.Windows.Forms.DataGridView();
            this.menureturn = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_top10 = new System.Windows.Forms.Panel();
            this.gridc = new System.Windows.Forms.DataGridView();
            this.gridm = new System.Windows.Forms.DataGridView();
            this.btn_addcustomer = new System.Windows.Forms.Button();
            this.btn_viewcustomer = new System.Windows.Forms.Button();
            this.btn_addmovie = new System.Windows.Forms.Button();
            this.btn_viewmovie = new System.Windows.Forms.Button();
            this.btn_issuemovie = new System.Windows.Forms.Button();
            this.btn_returnmovie = new System.Windows.Forms.Button();
            this.btn_top10rec = new System.Windows.Forms.Button();
            this.btn_home = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.PictureBox();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl_customeradd.SuspendLayout();
            this.pnl_customerview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridcustomer)).BeginInit();
            this.CustomerEdit.SuspendLayout();
            this.pnl_addmovie.SuspendLayout();
            this.pnl_viewmovie.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridmovie)).BeginInit();
            this.menumovie.SuspendLayout();
            this.pnl_return.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1return)).BeginInit();
            this.menureturn.SuspendLayout();
            this.pnl_top10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_customeradd
            // 
            this.pnl_customeradd.Controls.Add(this.addcustomer);
            this.pnl_customeradd.Controls.Add(this.tb);
            this.pnl_customeradd.Controls.Add(this.tb3);
            this.pnl_customeradd.Controls.Add(this.tb2);
            this.pnl_customeradd.Controls.Add(this.tb1);
            this.pnl_customeradd.Controls.Add(this.label5);
            this.pnl_customeradd.Controls.Add(this.label4);
            this.pnl_customeradd.Controls.Add(this.label3);
            this.pnl_customeradd.Controls.Add(this.label2);
            this.pnl_customeradd.Location = new System.Drawing.Point(110, 27);
            this.pnl_customeradd.Name = "pnl_customeradd";
            this.pnl_customeradd.Size = new System.Drawing.Size(771, 384);
            this.pnl_customeradd.TabIndex = 10;
            this.pnl_customeradd.Visible = false;
            // 
            // addcustomer
            // 
            this.addcustomer.Location = new System.Drawing.Point(469, 232);
            this.addcustomer.Name = "addcustomer";
            this.addcustomer.Size = new System.Drawing.Size(88, 20);
            this.addcustomer.TabIndex = 26;
            this.addcustomer.Text = "Add Customer";
            this.addcustomer.UseVisualStyleBackColor = true;
            this.addcustomer.Click += new System.EventHandler(this.addcustomer_Click);
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(129, 182);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(445, 20);
            this.tb.TabIndex = 25;
            // 
            // tb3
            // 
            this.tb3.Location = new System.Drawing.Point(129, 112);
            this.tb3.Multiline = true;
            this.tb3.Name = "tb3";
            this.tb3.Size = new System.Drawing.Size(445, 50);
            this.tb3.TabIndex = 24;
            // 
            // tb2
            // 
            this.tb2.Location = new System.Drawing.Point(129, 73);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(445, 20);
            this.tb2.TabIndex = 23;
            // 
            // tb1
            // 
            this.tb1.Location = new System.Drawing.Point(129, 39);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(445, 20);
            this.tb1.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Phone No";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Address";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "First Name";
            // 
            // pnl_customerview
            // 
            this.pnl_customerview.Controls.Add(this.gridcustomer);
            this.pnl_customerview.Location = new System.Drawing.Point(116, 26);
            this.pnl_customerview.Name = "pnl_customerview";
            this.pnl_customerview.Size = new System.Drawing.Size(765, 233);
            this.pnl_customerview.TabIndex = 11;
            this.pnl_customerview.Visible = false;
            // 
            // gridcustomer
            // 
            this.gridcustomer.AllowUserToAddRows = false;
            this.gridcustomer.AllowUserToDeleteRows = false;
            this.gridcustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridcustomer.ContextMenuStrip = this.CustomerEdit;
            this.gridcustomer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridcustomer.Location = new System.Drawing.Point(0, 0);
            this.gridcustomer.Name = "gridcustomer";
            this.gridcustomer.ReadOnly = true;
            this.gridcustomer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridcustomer.Size = new System.Drawing.Size(765, 233);
            this.gridcustomer.TabIndex = 5;
            // 
            // CustomerEdit
            // 
            this.CustomerEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItemCustomer,
            this.deleteToolStripMenuItem});
            this.CustomerEdit.Name = "contextMenuStrip1";
            this.CustomerEdit.Size = new System.Drawing.Size(181, 70);
            // 
            // editToolStripMenuItemCustomer
            // 
            this.editToolStripMenuItemCustomer.Name = "editToolStripMenuItemCustomer";
            this.editToolStripMenuItemCustomer.Size = new System.Drawing.Size(180, 22);
            this.editToolStripMenuItemCustomer.Text = "Edit";
            this.editToolStripMenuItemCustomer.Click += new System.EventHandler(this.editToolStripMenuItemCustomer_Click);
            // 
            // pnl_addmovie
            // 
            this.pnl_addmovie.Controls.Add(this.movie_plot);
            this.pnl_addmovie.Controls.Add(this.addmovie);
            this.pnl_addmovie.Controls.Add(this.movie_gener);
            this.pnl_addmovie.Controls.Add(this.movie_copies);
            this.pnl_addmovie.Controls.Add(this.movie_year);
            this.pnl_addmovie.Controls.Add(this.movie_title);
            this.pnl_addmovie.Controls.Add(this.movie_rating);
            this.pnl_addmovie.Controls.Add(this.label6);
            this.pnl_addmovie.Controls.Add(this.label1);
            this.pnl_addmovie.Controls.Add(this.label7);
            this.pnl_addmovie.Controls.Add(this.label8);
            this.pnl_addmovie.Controls.Add(this.label9);
            this.pnl_addmovie.Controls.Add(this.label10);
            this.pnl_addmovie.Location = new System.Drawing.Point(110, 27);
            this.pnl_addmovie.Name = "pnl_addmovie";
            this.pnl_addmovie.Size = new System.Drawing.Size(771, 384);
            this.pnl_addmovie.TabIndex = 13;
            this.pnl_addmovie.Visible = false;
            // 
            // movie_plot
            // 
            this.movie_plot.Location = new System.Drawing.Point(106, 192);
            this.movie_plot.Multiline = true;
            this.movie_plot.Name = "movie_plot";
            this.movie_plot.Size = new System.Drawing.Size(468, 53);
            this.movie_plot.TabIndex = 32;
            // 
            // addmovie
            // 
            this.addmovie.Location = new System.Drawing.Point(490, 358);
            this.addmovie.Name = "addmovie";
            this.addmovie.Size = new System.Drawing.Size(84, 20);
            this.addmovie.TabIndex = 34;
            this.addmovie.Text = "Add Movie";
            this.addmovie.UseVisualStyleBackColor = true;
            this.addmovie.Click += new System.EventHandler(this.addmovie_Click);
            // 
            // movie_gener
            // 
            this.movie_gener.Location = new System.Drawing.Point(106, 265);
            this.movie_gener.Multiline = true;
            this.movie_gener.Name = "movie_gener";
            this.movie_gener.Size = new System.Drawing.Size(468, 53);
            this.movie_gener.TabIndex = 33;
            // 
            // movie_copies
            // 
            this.movie_copies.Location = new System.Drawing.Point(106, 152);
            this.movie_copies.Name = "movie_copies";
            this.movie_copies.Size = new System.Drawing.Size(468, 20);
            this.movie_copies.TabIndex = 31;
            // 
            // movie_year
            // 
            this.movie_year.Location = new System.Drawing.Point(106, 107);
            this.movie_year.Name = "movie_year";
            this.movie_year.Size = new System.Drawing.Size(468, 20);
            this.movie_year.TabIndex = 30;
            // 
            // movie_title
            // 
            this.movie_title.Location = new System.Drawing.Point(106, 18);
            this.movie_title.Multiline = true;
            this.movie_title.Name = "movie_title";
            this.movie_title.Size = new System.Drawing.Size(468, 32);
            this.movie_title.TabIndex = 28;
            // 
            // movie_rating
            // 
            this.movie_rating.Location = new System.Drawing.Point(106, 66);
            this.movie_rating.Name = "movie_rating";
            this.movie_rating.Size = new System.Drawing.Size(468, 20);
            this.movie_rating.TabIndex = 29;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Genre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 213);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Plot";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Copies";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(29, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Year";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 21);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Title";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(37, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 36;
            this.label10.Text = "Rating";
            // 
            // pnl_viewmovie
            // 
            this.pnl_viewmovie.Controls.Add(this.gridmovie);
            this.pnl_viewmovie.Location = new System.Drawing.Point(116, 27);
            this.pnl_viewmovie.Name = "pnl_viewmovie";
            this.pnl_viewmovie.Size = new System.Drawing.Size(765, 223);
            this.pnl_viewmovie.TabIndex = 14;
            this.pnl_viewmovie.Visible = false;
            // 
            // gridmovie
            // 
            this.gridmovie.AllowUserToAddRows = false;
            this.gridmovie.AllowUserToDeleteRows = false;
            this.gridmovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridmovie.ContextMenuStrip = this.menumovie;
            this.gridmovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridmovie.Location = new System.Drawing.Point(0, 0);
            this.gridmovie.Name = "gridmovie";
            this.gridmovie.ReadOnly = true;
            this.gridmovie.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridmovie.Size = new System.Drawing.Size(765, 223);
            this.gridmovie.TabIndex = 1;
            // 
            // menumovie
            // 
            this.menumovie.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.issueToolStripMenuItem,
            this.deleteToolStripMenuItem1});
            this.menumovie.Name = "contextMenuStrip1";
            this.menumovie.Size = new System.Drawing.Size(108, 70);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // issueToolStripMenuItem
            // 
            this.issueToolStripMenuItem.Name = "issueToolStripMenuItem";
            this.issueToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.issueToolStripMenuItem.Text = "Issue";
            this.issueToolStripMenuItem.Click += new System.EventHandler(this.issueToolStripMenuItem_Click);
            // 
            // pnl_return
            // 
            this.pnl_return.Controls.Add(this.dataGridView1return);
            this.pnl_return.Location = new System.Drawing.Point(116, 27);
            this.pnl_return.Name = "pnl_return";
            this.pnl_return.Size = new System.Drawing.Size(762, 232);
            this.pnl_return.TabIndex = 16;
            this.pnl_return.Visible = false;
            // 
            // dataGridView1return
            // 
            this.dataGridView1return.AllowUserToAddRows = false;
            this.dataGridView1return.AllowUserToDeleteRows = false;
            this.dataGridView1return.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1return.ContextMenuStrip = this.menureturn;
            this.dataGridView1return.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1return.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1return.Name = "dataGridView1return";
            this.dataGridView1return.ReadOnly = true;
            this.dataGridView1return.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1return.Size = new System.Drawing.Size(762, 232);
            this.dataGridView1return.TabIndex = 1;
            // 
            // menureturn
            // 
            this.menureturn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnToolStripMenuItem});
            this.menureturn.Name = "contextMenuStrip1";
            this.menureturn.Size = new System.Drawing.Size(110, 26);
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(109, 22);
            this.returnToolStripMenuItem.Text = "Return";
            this.returnToolStripMenuItem.Click += new System.EventHandler(this.returnToolStripMenuItem_Click);
            // 
            // pnl_top10
            // 
            this.pnl_top10.Controls.Add(this.gridc);
            this.pnl_top10.Controls.Add(this.gridm);
            this.pnl_top10.Location = new System.Drawing.Point(114, 27);
            this.pnl_top10.Name = "pnl_top10";
            this.pnl_top10.Size = new System.Drawing.Size(765, 389);
            this.pnl_top10.TabIndex = 18;
            this.pnl_top10.Visible = false;
            // 
            // gridc
            // 
            this.gridc.AllowUserToAddRows = false;
            this.gridc.AllowUserToDeleteRows = false;
            this.gridc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridc.Location = new System.Drawing.Point(3, 3);
            this.gridc.Name = "gridc";
            this.gridc.ReadOnly = true;
            this.gridc.Size = new System.Drawing.Size(764, 180);
            this.gridc.TabIndex = 1;
            // 
            // gridm
            // 
            this.gridm.AllowUserToAddRows = false;
            this.gridm.AllowUserToDeleteRows = false;
            this.gridm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridm.Location = new System.Drawing.Point(3, 189);
            this.gridm.Name = "gridm";
            this.gridm.ReadOnly = true;
            this.gridm.Size = new System.Drawing.Size(762, 195);
            this.gridm.TabIndex = 2;
            // 
            // btn_addcustomer
            // 
            this.btn_addcustomer.Location = new System.Drawing.Point(12, 27);
            this.btn_addcustomer.Name = "btn_addcustomer";
            this.btn_addcustomer.Size = new System.Drawing.Size(87, 23);
            this.btn_addcustomer.TabIndex = 41;
            this.btn_addcustomer.Text = "Add customer";
            this.btn_addcustomer.UseVisualStyleBackColor = true;
            this.btn_addcustomer.Click += new System.EventHandler(this.btn_addcustomer_Click);
            // 
            // btn_viewcustomer
            // 
            this.btn_viewcustomer.Location = new System.Drawing.Point(12, 75);
            this.btn_viewcustomer.Name = "btn_viewcustomer";
            this.btn_viewcustomer.Size = new System.Drawing.Size(87, 23);
            this.btn_viewcustomer.TabIndex = 42;
            this.btn_viewcustomer.Text = "View customer";
            this.btn_viewcustomer.UseVisualStyleBackColor = true;
            this.btn_viewcustomer.Click += new System.EventHandler(this.btn_viewcustomer_Click);
            // 
            // btn_addmovie
            // 
            this.btn_addmovie.Location = new System.Drawing.Point(12, 120);
            this.btn_addmovie.Name = "btn_addmovie";
            this.btn_addmovie.Size = new System.Drawing.Size(87, 23);
            this.btn_addmovie.TabIndex = 43;
            this.btn_addmovie.Text = "Add movie";
            this.btn_addmovie.UseVisualStyleBackColor = true;
            this.btn_addmovie.Click += new System.EventHandler(this.btn_addmovie_Click);
            // 
            // btn_viewmovie
            // 
            this.btn_viewmovie.Location = new System.Drawing.Point(12, 166);
            this.btn_viewmovie.Name = "btn_viewmovie";
            this.btn_viewmovie.Size = new System.Drawing.Size(87, 23);
            this.btn_viewmovie.TabIndex = 44;
            this.btn_viewmovie.Text = "View Movie";
            this.btn_viewmovie.UseVisualStyleBackColor = true;
            this.btn_viewmovie.Click += new System.EventHandler(this.btn_viewmovie_Click);
            // 
            // btn_issuemovie
            // 
            this.btn_issuemovie.Location = new System.Drawing.Point(12, 208);
            this.btn_issuemovie.Name = "btn_issuemovie";
            this.btn_issuemovie.Size = new System.Drawing.Size(87, 23);
            this.btn_issuemovie.TabIndex = 45;
            this.btn_issuemovie.Text = "Issue movie";
            this.btn_issuemovie.UseVisualStyleBackColor = true;
            this.btn_issuemovie.Click += new System.EventHandler(this.btn_issuemovie_Click);
            // 
            // btn_returnmovie
            // 
            this.btn_returnmovie.Location = new System.Drawing.Point(12, 255);
            this.btn_returnmovie.Name = "btn_returnmovie";
            this.btn_returnmovie.Size = new System.Drawing.Size(87, 23);
            this.btn_returnmovie.TabIndex = 46;
            this.btn_returnmovie.Text = "Return movie";
            this.btn_returnmovie.UseVisualStyleBackColor = true;
            this.btn_returnmovie.Click += new System.EventHandler(this.btn_returnmovie_Click);
            // 
            // btn_top10rec
            // 
            this.btn_top10rec.Location = new System.Drawing.Point(12, 298);
            this.btn_top10rec.Name = "btn_top10rec";
            this.btn_top10rec.Size = new System.Drawing.Size(87, 23);
            this.btn_top10rec.TabIndex = 47;
            this.btn_top10rec.Text = "Top 10 records";
            this.btn_top10rec.UseVisualStyleBackColor = true;
            this.btn_top10rec.Click += new System.EventHandler(this.btn_top10rec_Click);
            // 
            // btn_home
            // 
            this.btn_home.Location = new System.Drawing.Point(12, 346);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(87, 23);
            this.btn_home.TabIndex = 48;
            this.btn_home.Text = "Home";
            this.btn_home.UseVisualStyleBackColor = true;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // logo
            // 
            this.logo.Image = global::MovieRentalSystem.Properties.Resources.download;
            this.logo.Location = new System.Drawing.Point(110, -4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(771, 420);
            this.logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo.TabIndex = 49;
            this.logo.TabStop = false;
            this.logo.WaitOnLoad = true;
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.deleteToolStripMenuItem1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 414);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.pnl_top10);
            this.Controls.Add(this.btn_home);
            this.Controls.Add(this.btn_top10rec);
            this.Controls.Add(this.btn_returnmovie);
            this.Controls.Add(this.btn_issuemovie);
            this.Controls.Add(this.btn_viewmovie);
            this.Controls.Add(this.btn_addmovie);
            this.Controls.Add(this.btn_viewcustomer);
            this.Controls.Add(this.btn_addcustomer);
            this.Controls.Add(this.pnl_return);
            this.Controls.Add(this.pnl_viewmovie);
            this.Controls.Add(this.pnl_customerview);
            this.Controls.Add(this.pnl_customeradd);
            this.Controls.Add(this.pnl_addmovie);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.pnl_customeradd.ResumeLayout(false);
            this.pnl_customeradd.PerformLayout();
            this.pnl_customerview.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridcustomer)).EndInit();
            this.CustomerEdit.ResumeLayout(false);
            this.pnl_addmovie.ResumeLayout(false);
            this.pnl_addmovie.PerformLayout();
            this.pnl_viewmovie.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridmovie)).EndInit();
            this.menumovie.ResumeLayout(false);
            this.pnl_return.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1return)).EndInit();
            this.menureturn.ResumeLayout(false);
            this.pnl_top10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnl_customeradd;
        private System.Windows.Forms.Button addcustomer;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.TextBox tb3;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnl_customerview;
        private System.Windows.Forms.DataGridView gridcustomer;
        private System.Windows.Forms.ContextMenuStrip CustomerEdit;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItemCustomer;
        private System.Windows.Forms.Panel pnl_addmovie;
        private System.Windows.Forms.Button addmovie;
        private System.Windows.Forms.TextBox movie_gener;
        private System.Windows.Forms.TextBox movie_plot;
        private System.Windows.Forms.TextBox movie_copies;
        private System.Windows.Forms.TextBox movie_year;
        private System.Windows.Forms.TextBox movie_title;
        private System.Windows.Forms.TextBox movie_rating;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnl_viewmovie;
        private System.Windows.Forms.DataGridView gridmovie;
        private System.Windows.Forms.ContextMenuStrip menumovie;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem issueToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_return;
        private System.Windows.Forms.DataGridView dataGridView1return;
        private System.Windows.Forms.ContextMenuStrip menureturn;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
        private System.Windows.Forms.Panel pnl_top10;
        private System.Windows.Forms.DataGridView gridc;
        private System.Windows.Forms.DataGridView gridm;
        private System.Windows.Forms.Button btn_addcustomer;
        private System.Windows.Forms.Button btn_viewcustomer;
        private System.Windows.Forms.Button btn_addmovie;
        private System.Windows.Forms.Button btn_viewmovie;
        private System.Windows.Forms.Button btn_issuemovie;
        private System.Windows.Forms.Button btn_returnmovie;
        private System.Windows.Forms.Button btn_top10rec;
        private System.Windows.Forms.Button btn_home;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem1;
    }
}