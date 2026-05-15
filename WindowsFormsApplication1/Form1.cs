using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=DESKTOP-T6LL24R;Initial Catalog=Inventa;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
            ShowDashboard();
        }

        //show dashboard pannel
        private void ShowDashboard()
        {
            dashboard.Visible = true;
            panelProduct.Visible = false;
            panelSuppliers.Visible = false;
            panelSuppliers.Visible = false;
            panelSales.Visible = false;


        }
        //show product pannel
        private void ShowProduct()
        {
            panelProduct.Visible = true;
            panelProduct.BringToFront();
            dashboard.Visible = false;
            panelSuppliers.Visible = false;
            panelSales.Visible = false;


            LoadProductTable();
        }
        private void ShowSuppliers()
        {
            dashboard.Visible = false;
            panelProduct.Visible = false;
            panelSuppliers.Visible = true;
            LoadSellersTable();
            panelSales.Visible = false;
        }
        private void ShowSales()
        {
            dashboard.Visible = false;
            panelProduct.Visible = false;
            panelSuppliers.Visible = false;
            panelSales.Visible = true;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Dashboard productbtn 
        private void ProductBtn_Click_1(object sender, EventArgs e)
        {
            ShowProduct();
        }

        //load product table
        private void LoadProductTable()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query = "SELECT * FROM Products";
            SqlDataAdapter da = new SqlDataAdapter(query, connection);
            DataTable dt = new DataTable();
            da.Fill(dt);

            dgvProducts.DataSource = dt;
        }

        //Data grid view table
        private void dgvProducts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvProducts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;    
        }

        //add product button
        private void AddProduct_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            string query1 = "INSERT INTO Products(ProductName,Category,Quantity,Price)VALUES(@productname,@category,@quantity,@price)";
            SqlCommand cmd = new SqlCommand(query1, connection);

            cmd.Parameters.AddWithValue("@productname", ProductName.Text);
            cmd.Parameters.AddWithValue("@category", Category.Text);
            cmd.Parameters.AddWithValue("@quantity", Quantity.Text);
            cmd.Parameters.AddWithValue("@price", Price.Text);

            cmd.ExecuteNonQuery();
            connection.Close();

            MessageBox.Show("Product Added Successfully!","Success", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

            ClearProductInputs();
            LoadProductTable();
        }
        
        //clear text fields
        private void ClearProductInputs()
        {
            ProductName.Text = "";
            Category.Text = "";
            Quantity.Text = "";
            Price.Text = "";
        }

        //clear button
        private void ClearProduct_Click(object sender, EventArgs e)
        {
            ClearProductInputs();
        }
        //stripn menu product show
        private void productListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowProduct();
        }

        //strip menu application exit
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //strip menu dashboard show
        private void dashboardToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ShowDashboard();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Price_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void CustormerBtn_Click(object sender, EventArgs e)
        {
            ShowSuppliers();
        }
        
        private void SalesBtn_Click(object sender, EventArgs e)
        {
            ShowSales();
        }

        private void Reportbtn_Click(object sender, EventArgs e)
        {

        }
        //salers section
        private void Sid_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sname_TextChanged(object sender, EventArgs e)
        {

        }

        private void Snumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void Slocation_TextChanged(object sender, EventArgs e)
        {

        }
        //seller add section
        private void SellerAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string query = "INSERT INTO Sellers (SellerID, SellerName, Phone, Location) " +
                           "VALUES (@id, @name, @phone, @location)";

            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", Sid.Text);
            cmd.Parameters.AddWithValue("@name", Sname.Text);
            cmd.Parameters.AddWithValue("@phone", Snumber.Text);
            cmd.Parameters.AddWithValue("@location", Slocation.Text);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Seller Added Successfully!");

            ClearSellerInputs();
            LoadSellersTable();

        }
        private void ClearSellerInputs()
        {
            Sid.Text = "";
            Sname.Text = "";
            Snumber.Text = "";
            Slocation.Text = "";
            
        }
        private void SellerClear_Click(object sender, EventArgs e)
        {
            ClearSellerInputs();
        }

        private void LoadSellersTable()
        {
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            string query = "SELECT SellerID, SellerName, Phone, Location FROM Sellers";
            SqlDataAdapter daS = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            daS.Fill(dt);

            SellersData.DataSource = dt;

            con.Close();
        } 
        private void SellersData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadSellersTable();
        }

        private void sellersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowSuppliers();
        }

        private void panelSuppliers_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
        //sales section
        private void panelSales_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelProduct_Paint(object sender, PaintEventArgs e)
        {

        }
        //-----------------------sales section-------------------
        private void panelSales_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }
    }
}

