using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Drawing.Imaging;
using CtangKiosk.Categories;

namespace CtangKiosk.Categories
{
    public partial class Sizzling : UserControl
    {
        private OleDbConnection conn;
        private OleDbCommand cmd;
        private OleDbDataAdapter adapter;
        private DataTable dt;

        public event Action<string, decimal> ProductSelected;
        public string productName { get; set; }
        public decimal productPrice { get; set; }


        private string category;


        public Sizzling(string category)
        {
            InitializeComponent();
            this.category = category;
            conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=CitangPOS.accdb");
            LoadSizzlingProducts();
        }


        private void LoadSizzlingProducts()
        {
            try
            {
                conn.Open();


                string query = "SELECT product_name, price, prod_image FROM products WHERE category = @category";
                cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@category", category);
                adapter = new OleDbDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No products found for this category.");
                    return;
                }

                PopulateProducts(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
            }
            finally
            {
                conn?.Close();
            }
        }

        private void PopulateProducts(DataTable products)
        {
            foreach (DataRow row in products.Rows)
            {
                string productName = row["product_name"].ToString();
                decimal price = Convert.ToDecimal(row["price"]);
                string samplePic = row["prod_image"].ToString();


                Panel productPanel = new Panel
                {
                    Width = 350,
                    Height = 200,
                    BorderStyle = BorderStyle.Fixed3D
                };

                productPanel.Tag = new Tuple<string, decimal>(productName, price);
                productPanel.Click += (sender, e) => ProductPanel_Click(sender, e, productName, price);


                PictureBox productImage = new PictureBox
                {
                    Width = 160,
                    Height = 120,
                    Location = new Point(10, 40),
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    BorderStyle = BorderStyle.FixedSingle
                };


                try
                {
                    productImage.Image = Image.FromFile(samplePic);
                }
                catch
                {
                    productImage.Image = Image.FromFile(@"D:\Code\CtangKiosk\CtangKiosk\bin\Debug\DefaultImg.png");
                }

                productPanel.Controls.Add(productImage);


                Label lblProductName = new Label
                {
                    Text = productName,
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    AutoSize = true,
                    Location = new Point(180, 40)
                };
                productPanel.Controls.Add(lblProductName);


                Label lblPrice = new Label
                {
                    Text = "Price: ₱" + price.ToString("0.00"),
                    Font = new Font("Arial", 10, FontStyle.Bold),
                    AutoSize = true,
                    Location = new Point(180, 70)
                };
                productPanel.Controls.Add(lblPrice);


                sizzlingflow.Controls.Add(productPanel);



            }
        }

        private void sizzlingflow_Paint(object sender, PaintEventArgs e)
        {

        }

        private void kakaninflow_Paint(object sender, PaintEventArgs e)
        {
            sizzlingflow = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                WrapContents = true,
                FlowDirection = FlowDirection.TopDown
            };

            this.Controls.Add(sizzlingflow);
        }


        private void ProductPanel_Click(object sender, EventArgs e, string productName, decimal productPrice)
        {

            ProductSelected?.Invoke(productName, productPrice);
        }
    }
}
