namespace WindowsFormsApplication1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dashboard = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Reportbtn = new System.Windows.Forms.Button();
            this.CustormerBtn = new System.Windows.Forms.Button();
            this.SalesBtn = new System.Windows.Forms.Button();
            this.ProductBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.productListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sellersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProductName = new System.Windows.Forms.TextBox();
            this.Category = new System.Windows.Forms.TextBox();
            this.Quantity = new System.Windows.Forms.TextBox();
            this.Price = new System.Windows.Forms.TextBox();
            this.AddProduct = new System.Windows.Forms.Button();
            this.ClearProduct = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panelProduct = new System.Windows.Forms.Panel();
            this.panelSuppliers = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.SellersData = new System.Windows.Forms.DataGridView();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.SellerClear = new System.Windows.Forms.Button();
            this.SellerAdd = new System.Windows.Forms.Button();
            this.Snumber = new System.Windows.Forms.TextBox();
            this.Slocation = new System.Windows.Forms.TextBox();
            this.Sname = new System.Windows.Forms.TextBox();
            this.Sid = new System.Windows.Forms.TextBox();
            this.panelSales = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.dashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.panelProduct.SuspendLayout();
            this.panelSuppliers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SellersData)).BeginInit();
            this.panelSales.SuspendLayout();
            this.SuspendLayout();
            // 
            // dashboard
            // 
            this.dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.dashboard.Controls.Add(this.label11);
            this.dashboard.Controls.Add(this.label10);
            this.dashboard.Controls.Add(this.label9);
            this.dashboard.Controls.Add(this.label2);
            this.dashboard.Controls.Add(this.label1);
            this.dashboard.Controls.Add(this.Reportbtn);
            this.dashboard.Controls.Add(this.CustormerBtn);
            this.dashboard.Controls.Add(this.SalesBtn);
            this.dashboard.Controls.Add(this.ProductBtn);
            this.dashboard.Location = new System.Drawing.Point(477, 27);
            this.dashboard.Name = "dashboard";
            this.dashboard.Size = new System.Drawing.Size(600, 578);
            this.dashboard.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(105, 469);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(363, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = " smooth, accurate supply distribution to all suppliers.";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(61, 449);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(483, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Inventa is the main-branch system that manages products and ensures";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft YaHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(203, 411);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(173, 24);
            this.label9.TabIndex = 6;
            this.label9.Text = "About Us – Inventa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(121)))), ((int)(((byte)(146)))));
            this.label2.Location = new System.Drawing.Point(222, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Welcome Admin...";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            this.label1.Location = new System.Drawing.Point(197, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 58);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dashboard";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Reportbtn
            // 
            this.Reportbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(121)))), ((int)(((byte)(146)))));
            this.Reportbtn.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reportbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.Reportbtn.Location = new System.Drawing.Point(338, 298);
            this.Reportbtn.Name = "Reportbtn";
            this.Reportbtn.Size = new System.Drawing.Size(199, 64);
            this.Reportbtn.TabIndex = 3;
            this.Reportbtn.Text = "Report";
            this.Reportbtn.UseVisualStyleBackColor = false;
            this.Reportbtn.Click += new System.EventHandler(this.Reportbtn_Click);
            // 
            // CustormerBtn
            // 
            this.CustormerBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(121)))), ((int)(((byte)(146)))));
            this.CustormerBtn.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustormerBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.CustormerBtn.Location = new System.Drawing.Point(66, 298);
            this.CustormerBtn.Name = "CustormerBtn";
            this.CustormerBtn.Size = new System.Drawing.Size(199, 64);
            this.CustormerBtn.TabIndex = 2;
            this.CustormerBtn.Text = "Suppliers";
            this.CustormerBtn.UseVisualStyleBackColor = false;
            this.CustormerBtn.Click += new System.EventHandler(this.CustormerBtn_Click);
            // 
            // SalesBtn
            // 
            this.SalesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(121)))), ((int)(((byte)(146)))));
            this.SalesBtn.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesBtn.ForeColor = System.Drawing.Color.White;
            this.SalesBtn.Location = new System.Drawing.Point(338, 184);
            this.SalesBtn.Name = "SalesBtn";
            this.SalesBtn.Size = new System.Drawing.Size(199, 64);
            this.SalesBtn.TabIndex = 1;
            this.SalesBtn.Text = "Sales";
            this.SalesBtn.UseVisualStyleBackColor = false;
            this.SalesBtn.Click += new System.EventHandler(this.SalesBtn_Click);
            // 
            // ProductBtn
            // 
            this.ProductBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(121)))), ((int)(((byte)(146)))));
            this.ProductBtn.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.ProductBtn.Location = new System.Drawing.Point(66, 184);
            this.ProductBtn.Name = "ProductBtn";
            this.ProductBtn.Size = new System.Drawing.Size(199, 64);
            this.ProductBtn.TabIndex = 0;
            this.ProductBtn.Text = "Product";
            this.ProductBtn.UseVisualStyleBackColor = false;
            this.ProductBtn.Click += new System.EventHandler(this.ProductBtn_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(433, 578);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.dashboardToolStripMenuItem1,
            this.productListToolStripMenuItem,
            this.sellersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1066, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.dashboardToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(45, 24);
            this.dashboardToolStripMenuItem.Text = "File";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(110, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // dashboardToolStripMenuItem1
            // 
            this.dashboardToolStripMenuItem1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardToolStripMenuItem1.Name = "dashboardToolStripMenuItem1";
            this.dashboardToolStripMenuItem1.Size = new System.Drawing.Size(97, 24);
            this.dashboardToolStripMenuItem1.Text = "Dashboard";
            this.dashboardToolStripMenuItem1.Click += new System.EventHandler(this.dashboardToolStripMenuItem1_Click);
            // 
            // productListToolStripMenuItem
            // 
            this.productListToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productListToolStripMenuItem.Name = "productListToolStripMenuItem";
            this.productListToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.productListToolStripMenuItem.Text = "Product List";
            this.productListToolStripMenuItem.Click += new System.EventHandler(this.productListToolStripMenuItem_Click);
            // 
            // sellersToolStripMenuItem
            // 
            this.sellersToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sellersToolStripMenuItem.Name = "sellersToolStripMenuItem";
            this.sellersToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.sellersToolStripMenuItem.Text = "Sellers";
            this.sellersToolStripMenuItem.Click += new System.EventHandler(this.sellersToolStripMenuItem_Click);
            // 
            // ProductName
            // 
            this.ProductName.BackColor = System.Drawing.Color.AliceBlue;
            this.ProductName.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(121)))), ((int)(((byte)(146)))));
            this.ProductName.Location = new System.Drawing.Point(201, 61);
            this.ProductName.Multiline = true;
            this.ProductName.Name = "ProductName";
            this.ProductName.Size = new System.Drawing.Size(291, 24);
            this.ProductName.TabIndex = 0;
            // 
            // Category
            // 
            this.Category.BackColor = System.Drawing.Color.AliceBlue;
            this.Category.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Category.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(121)))), ((int)(((byte)(146)))));
            this.Category.Location = new System.Drawing.Point(201, 104);
            this.Category.Multiline = true;
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(291, 23);
            this.Category.TabIndex = 1;
            // 
            // Quantity
            // 
            this.Quantity.BackColor = System.Drawing.Color.AliceBlue;
            this.Quantity.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(121)))), ((int)(((byte)(146)))));
            this.Quantity.Location = new System.Drawing.Point(201, 148);
            this.Quantity.Name = "Quantity";
            this.Quantity.Size = new System.Drawing.Size(291, 25);
            this.Quantity.TabIndex = 2;
            // 
            // Price
            // 
            this.Price.BackColor = System.Drawing.Color.AliceBlue;
            this.Price.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(121)))), ((int)(((byte)(146)))));
            this.Price.Location = new System.Drawing.Point(201, 191);
            this.Price.Multiline = true;
            this.Price.Name = "Price";
            this.Price.Size = new System.Drawing.Size(291, 22);
            this.Price.TabIndex = 3;
            this.Price.TextChanged += new System.EventHandler(this.Price_TextChanged);
            // 
            // AddProduct
            // 
            this.AddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.AddProduct.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProduct.ForeColor = System.Drawing.SystemColors.Control;
            this.AddProduct.Location = new System.Drawing.Point(235, 228);
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(75, 39);
            this.AddProduct.TabIndex = 4;
            this.AddProduct.Text = "Add";
            this.AddProduct.UseVisualStyleBackColor = false;
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // ClearProduct
            // 
            this.ClearProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.ClearProduct.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearProduct.ForeColor = System.Drawing.SystemColors.Control;
            this.ClearProduct.Location = new System.Drawing.Point(362, 228);
            this.ClearProduct.Name = "ClearProduct";
            this.ClearProduct.Size = new System.Drawing.Size(75, 39);
            this.ClearProduct.TabIndex = 5;
            this.ClearProduct.Text = "Clear";
            this.ClearProduct.UseVisualStyleBackColor = false;
            this.ClearProduct.Click += new System.EventHandler(this.ClearProduct_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(121)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvProducts.Location = new System.Drawing.Point(17, 327);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(566, 190);
            this.dgvProducts.TabIndex = 6;
            this.dgvProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProducts_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            this.label3.Location = new System.Drawing.Point(16, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 25);
            this.label3.TabIndex = 7;
            this.label3.Text = "Product Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            this.label4.Location = new System.Drawing.Point(16, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Product Category";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            this.label5.Location = new System.Drawing.Point(16, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Product Quantity";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            this.label6.Location = new System.Drawing.Point(16, 192);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 25);
            this.label6.TabIndex = 10;
            this.label6.Text = "Product Price";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            this.label7.Location = new System.Drawing.Point(221, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(161, 42);
            this.label7.TabIndex = 11;
            this.label7.Text = "Product List";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(479, 523);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 35);
            this.button1.TabIndex = 12;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            this.label8.Location = new System.Drawing.Point(223, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 42);
            this.label8.TabIndex = 13;
            this.label8.Text = "Add Product";
            // 
            // panelProduct
            // 
            this.panelProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panelProduct.Controls.Add(this.label8);
            this.panelProduct.Controls.Add(this.button1);
            this.panelProduct.Controls.Add(this.label7);
            this.panelProduct.Controls.Add(this.label6);
            this.panelProduct.Controls.Add(this.label5);
            this.panelProduct.Controls.Add(this.label4);
            this.panelProduct.Controls.Add(this.label3);
            this.panelProduct.Controls.Add(this.dgvProducts);
            this.panelProduct.Controls.Add(this.ClearProduct);
            this.panelProduct.Controls.Add(this.AddProduct);
            this.panelProduct.Controls.Add(this.Price);
            this.panelProduct.Controls.Add(this.Quantity);
            this.panelProduct.Controls.Add(this.Category);
            this.panelProduct.Controls.Add(this.ProductName);
            this.panelProduct.Location = new System.Drawing.Point(468, 27);
            this.panelProduct.Name = "panelProduct";
            this.panelProduct.Size = new System.Drawing.Size(598, 578);
            this.panelProduct.TabIndex = 10;
            this.panelProduct.Paint += new System.Windows.Forms.PaintEventHandler(this.panelProduct_Paint);
            // 
            // panelSuppliers
            // 
            this.panelSuppliers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.panelSuppliers.Controls.Add(this.label13);
            this.panelSuppliers.Controls.Add(this.SellersData);
            this.panelSuppliers.Controls.Add(this.label12);
            this.panelSuppliers.Controls.Add(this.label14);
            this.panelSuppliers.Controls.Add(this.label15);
            this.panelSuppliers.Controls.Add(this.label16);
            this.panelSuppliers.Controls.Add(this.label17);
            this.panelSuppliers.Controls.Add(this.SellerClear);
            this.panelSuppliers.Controls.Add(this.SellerAdd);
            this.panelSuppliers.Controls.Add(this.Snumber);
            this.panelSuppliers.Controls.Add(this.Slocation);
            this.panelSuppliers.Controls.Add(this.Sname);
            this.panelSuppliers.Controls.Add(this.Sid);
            this.panelSuppliers.Location = new System.Drawing.Point(471, 27);
            this.panelSuppliers.Name = "panelSuppliers";
            this.panelSuppliers.Size = new System.Drawing.Size(595, 578);
            this.panelSuppliers.TabIndex = 13;
            this.panelSuppliers.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSuppliers_Paint);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            this.label13.Location = new System.Drawing.Point(220, 270);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(146, 42);
            this.label13.TabIndex = 29;
            this.label13.Text = "Sellers List";
            // 
            // SellersData
            // 
            this.SellersData.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(121)))), ((int)(((byte)(146)))));
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SellersData.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.SellersData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SellersData.DefaultCellStyle = dataGridViewCellStyle20;
            this.SellersData.Location = new System.Drawing.Point(20, 326);
            this.SellersData.Name = "SellersData";
            this.SellersData.RowTemplate.Height = 24;
            this.SellersData.Size = new System.Drawing.Size(556, 207);
            this.SellersData.TabIndex = 28;
            this.SellersData.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SellersData_CellContentClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            this.label12.Location = new System.Drawing.Point(220, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(155, 42);
            this.label12.TabIndex = 27;
            this.label12.Text = "Add Sellers";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            this.label14.Location = new System.Drawing.Point(64, 127);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(102, 25);
            this.label14.TabIndex = 24;
            this.label14.Text = "Telphone No";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            this.label15.Location = new System.Drawing.Point(291, 127);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(87, 25);
            this.label15.TabIndex = 23;
            this.label15.Text = " Loacation";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            this.label16.Location = new System.Drawing.Point(291, 67);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(60, 25);
            this.label16.TabIndex = 22;
            this.label16.Text = " Name";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            this.label17.Location = new System.Drawing.Point(64, 67);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(70, 25);
            this.label17.TabIndex = 21;
            this.label17.Text = "Seller ID";
            // 
            // SellerClear
            // 
            this.SellerClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.SellerClear.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerClear.ForeColor = System.Drawing.SystemColors.Control;
            this.SellerClear.Location = new System.Drawing.Point(173, 209);
            this.SellerClear.Name = "SellerClear";
            this.SellerClear.Size = new System.Drawing.Size(75, 39);
            this.SellerClear.TabIndex = 19;
            this.SellerClear.Text = "Clear";
            this.SellerClear.UseVisualStyleBackColor = false;
            this.SellerClear.Click += new System.EventHandler(this.SellerClear_Click);
            // 
            // SellerAdd
            // 
            this.SellerAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.SellerAdd.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SellerAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.SellerAdd.Location = new System.Drawing.Point(72, 209);
            this.SellerAdd.Name = "SellerAdd";
            this.SellerAdd.Size = new System.Drawing.Size(75, 39);
            this.SellerAdd.TabIndex = 18;
            this.SellerAdd.Text = "Add";
            this.SellerAdd.UseVisualStyleBackColor = false;
            this.SellerAdd.Click += new System.EventHandler(this.SellerAdd_Click);
            // 
            // Snumber
            // 
            this.Snumber.BackColor = System.Drawing.Color.AliceBlue;
            this.Snumber.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Snumber.ForeColor = System.Drawing.Color.Black;
            this.Snumber.Location = new System.Drawing.Point(69, 160);
            this.Snumber.Multiline = true;
            this.Snumber.Name = "Snumber";
            this.Snumber.Size = new System.Drawing.Size(197, 22);
            this.Snumber.TabIndex = 17;
            this.Snumber.TextChanged += new System.EventHandler(this.Snumber_TextChanged);
            // 
            // Slocation
            // 
            this.Slocation.BackColor = System.Drawing.Color.AliceBlue;
            this.Slocation.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Slocation.ForeColor = System.Drawing.Color.Black;
            this.Slocation.Location = new System.Drawing.Point(296, 155);
            this.Slocation.Name = "Slocation";
            this.Slocation.Size = new System.Drawing.Size(269, 25);
            this.Slocation.TabIndex = 16;
            this.Slocation.TextChanged += new System.EventHandler(this.Slocation_TextChanged);
            // 
            // Sname
            // 
            this.Sname.BackColor = System.Drawing.Color.AliceBlue;
            this.Sname.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sname.ForeColor = System.Drawing.Color.Black;
            this.Sname.Location = new System.Drawing.Point(295, 95);
            this.Sname.Multiline = true;
            this.Sname.Name = "Sname";
            this.Sname.Size = new System.Drawing.Size(270, 23);
            this.Sname.TabIndex = 15;
            this.Sname.TextChanged += new System.EventHandler(this.Sname_TextChanged);
            // 
            // Sid
            // 
            this.Sid.BackColor = System.Drawing.Color.AliceBlue;
            this.Sid.Font = new System.Drawing.Font("Microsoft JhengHei", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sid.ForeColor = System.Drawing.Color.Black;
            this.Sid.Location = new System.Drawing.Point(69, 95);
            this.Sid.Multiline = true;
            this.Sid.Name = "Sid";
            this.Sid.Size = new System.Drawing.Size(197, 24);
            this.Sid.TabIndex = 14;
            this.Sid.TextChanged += new System.EventHandler(this.Sid_TextChanged);
            // 
            // panelSales
            // 
            this.panelSales.Controls.Add(this.label18);
            this.panelSales.Location = new System.Drawing.Point(463, 27);
            this.panelSales.Name = "panelSales";
            this.panelSales.Size = new System.Drawing.Size(603, 575);
            this.panelSales.TabIndex = 14;
            this.panelSales.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSales_Paint_1);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Poppins", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(56)))), ((int)(((byte)(91)))));
            this.label18.Location = new System.Drawing.Point(261, 16);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(89, 42);
            this.label18.TabIndex = 14;
            this.label18.Text = "Sales ";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(249)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(1066, 597);
            this.Controls.Add(this.panelSales);
            this.Controls.Add(this.panelProduct);
            this.Controls.Add(this.panelSuppliers);
            this.Controls.Add(this.dashboard);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Inventa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.dashboard.ResumeLayout(false);
            this.dashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.panelProduct.ResumeLayout(false);
            this.panelProduct.PerformLayout();
            this.panelSuppliers.ResumeLayout(false);
            this.panelSuppliers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SellersData)).EndInit();
            this.panelSales.ResumeLayout(false);
            this.panelSales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel dashboard;
        private System.Windows.Forms.Button Reportbtn;
        private System.Windows.Forms.Button CustormerBtn;
        private System.Windows.Forms.Button SalesBtn;
        private System.Windows.Forms.Button ProductBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ProductName;
        private System.Windows.Forms.TextBox Category;
        private System.Windows.Forms.TextBox Quantity;
        private System.Windows.Forms.TextBox Price;
        private System.Windows.Forms.Button AddProduct;
        private System.Windows.Forms.Button ClearProduct;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelProduct;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panelSuppliers;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button SellerClear;
        private System.Windows.Forms.Button SellerAdd;
        private System.Windows.Forms.TextBox Snumber;
        private System.Windows.Forms.TextBox Slocation;
        private System.Windows.Forms.TextBox Sname;
        private System.Windows.Forms.TextBox Sid;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView SellersData;
        private System.Windows.Forms.ToolStripMenuItem sellersToolStripMenuItem;
        private System.Windows.Forms.Panel panelSales;
        private System.Windows.Forms.Label label18;
    }
}

