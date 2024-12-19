using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace CtangKiosk
{
    public partial class ViewOrders : Form
    {
        private static ViewOrders instance;
        private decimal totalOrderPrice = 0;
        

        public ViewOrders()
        {
            InitializeComponent();

            if (flowLayoutPanel1 == null)
            {
                flowLayoutPanel1 = new FlowLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    AutoScroll = true,
                    FlowDirection = FlowDirection.TopDown,
                    WrapContents = false
                };
                Controls.Add(flowLayoutPanel1);
            }
        }

        public static ViewOrders GetInstance()
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new ViewOrders();
            }
            return instance;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderingForm orderingForm = new OrderingForm();
            orderingForm.Show();
            this.Hide();
        }

        private void ViewOrders_Load(object sender, EventArgs e)
        {

        }

        private void Proceedbtn_Click(object sender, EventArgs e)
        {
            var choicesForm = Application.OpenForms.OfType<Choices>().FirstOrDefault();
           
                choicesForm = new Choices();
                choicesForm.SetTotalPrice(totalOrderPrice);
                choicesForm.Show();

            

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void AddOrder(string productName,decimal quantity, decimal totalPrice)
        {
            
            Panel orderPanel = new Panel
            {
                Width = flowLayoutPanel1.ClientSize.Width - 20,
                Height = 100,
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(5)
            };

            
            Label lblProductName = new Label
            {
                Text = productName,
                Font = new Font("Arial", 10, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(10, 10)
            };
            orderPanel.Controls.Add(lblProductName);

            Label quantityLabel = new Label
            {
                Text = $"Quantity: {quantity}",
                AutoSize = true,
                Location = new Point(10, 30),
                Font = new Font("Arial", 10, FontStyle.Bold)
            };
            orderPanel.Controls.Add(quantityLabel);

            Label lblTotalPrice = new Label
            {
                Text = $"₱{totalPrice:F2}",
                Font = new Font("Arial", 10, FontStyle.Regular),
                AutoSize = true,
                Location = new Point(10, 50)
            };
            orderPanel.Controls.Add(lblTotalPrice);

           
            flowLayoutPanel1.Controls.Add(orderPanel);

            totalOrderPrice += totalPrice;
            TPriceTB.Text = $"₱{totalOrderPrice:F2}";
        }

        public string GetOrderReceipt()
        {
            StringBuilder receipt = new StringBuilder();

           
            int pageWidth = 40;


            string headerText = "---- Citang's Eatery ----";
            int headerPadding = (pageWidth - headerText.Length) / 2; 
            receipt.AppendLine(new string(' ', headerPadding) + headerText);

            receipt.AppendLine(new string('-', pageWidth));

           
            int productNameWidth = 20;  
            int quantityWidth = 5;      
            int priceWidth = 10;

            foreach (Panel orderPanel in flowLayoutPanel1.Controls)
            {
                string productName = "";
                string quantity = "";
                string totalPrice = "";

                foreach (Control ctrl in orderPanel.Controls)
                {
                    if (ctrl is Label)
                    {
                        var label = ctrl as Label;
                        if (label.Text.Contains("Quantity"))
                        {
                            quantity = label.Text;
                        }
                        else if (label.Text.Contains("₱"))
                        {
                            totalPrice = label.Text; 
                        }
                        else
                        {
                            productName = label.Text; 
                        }
                    }
                }

                string formattedProductName = productName.Length > productNameWidth ? productName.Substring(0, productNameWidth) : productName.PadRight(productNameWidth);
                string formattedQuantity = quantity.PadLeft(quantityWidth);
                string formattedPrice = ("Price: " + totalPrice).PadLeft(priceWidth);

                
                receipt.AppendLine($"{formattedProductName} {formattedQuantity} {formattedPrice}");
            }

            
            receipt.AppendLine(new string('-', pageWidth));

            // Add the total price (centered)
            string totalPriceText = $"Total Price: {TPriceTB.Text}";
            int totalPricePadding = (pageWidth - totalPriceText.Length) / 2;
            receipt.AppendLine(new string(' ', totalPricePadding) + totalPriceText);

            
            receipt.AppendLine(new string('-', pageWidth));

            // Add the current date (centered)
            string footerText = $"Date: {DateTime.Now.ToString("MM/dd/yyyy hh:mm tt")}";
            int footerPadding = (pageWidth - footerText.Length) / 2;
            receipt.AppendLine(new string(' ', footerPadding) + footerText);

            // Return the receipt as a string
            return receipt.ToString();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            /*flowLayoutPanel1 = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                AutoScroll = true,
                WrapContents = true,
                FlowDirection = FlowDirection.TopDown
            };

            this.Controls.Add(flowLayoutPanel1);*/
        }

        /*public void SaveOrderToDatabase(string status)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection("Your Connection String Here"))
                {
                    connection.Open();

                    foreach (Panel orderPanel in flowLayoutPanel1.Controls)
                    {
                        string productName = "";
                        string quantity = "";
                        string totalPrice = "";

                        foreach (Control ctrl in orderPanel.Controls)
                        {
                            if (ctrl is Label)
                            {
                                var label = ctrl as Label;
                                if (label.Text.Contains("Quantity"))
                                {
                                    quantity = label.Text;
                                }
                                else if (label.Text.Contains("₱"))
                                {
                                    totalPrice = label.Text;
                                }
                                else
                                {
                                    productName = label.Text;
                                }
                            }
                        }

                        // Now insert the order into the database
                        string insertQuery = "INSERT INTO Orders (CustomerID,ProductName, Quantity, TotalPrice, Status, OrderDate) " +
                                             "VALUES (@CustomerID, @ProductName, @Quantity, @TotalPrice, @Status, @OrderDate)";
                        using (OleDbCommand cmd = new OleDbCommand(insertQuery, connection))
                        {
                            cmd.Parameters.AddWithValue("@CustomerID", customerID);
                            cmd.Parameters.AddWithValue("@ProductName", productName);
                            cmd.Parameters.AddWithValue("@Quantity", Convert.ToDecimal(quantity));  // Convert quantity to decimal
                            cmd.Parameters.AddWithValue("@TotalPrice", Convert.ToDecimal(totalPrice));  // Convert total price to decimal
                            cmd.Parameters.AddWithValue("@Status", status);
                            cmd.Parameters.AddWithValue("@OrderDate", DateTime.Now);  // Save the current date and time
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving order: " + ex.Message);
            }
        }*/


    }
}
