using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.Data.OleDb;


namespace CtangKiosk
{
    public partial class Choices : Form
    {
        private Timer timerBlink;
        private PrintDocument printDocument;
        


        public Choices()
        {
            InitializeComponent();
            

            TPriceTB.ReadOnly = true;

            timerBlink = new Timer();
            timerBlink.Interval = 500;
            timerBlink.Tick += TimerBlink_Tick;
            timerBlink.Start();

            printDocument = new PrintDocument();
            printDocument.PrintPage += printDocument1_PrintPage;
        }


        private void TimerBlink_Tick(object sender, EventArgs e)
        {

            pictureBox1.Visible = !pictureBox1.Visible;
        }


        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            timerBlink.Stop();
            base.OnFormClosing(e);
        }

        private void ViewObtn_Click(object sender, EventArgs e)
        {
            ViewOrders viewOrderForm = ViewOrders.GetInstance();
            viewOrderForm.Show();
            this.Hide();
        }

        public void SetTotalPrice(decimal totalPrice)
        {
            TPriceTB.Text = $"₱{totalPrice:F2}";
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TPriceTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void Dinebtn_Click(object sender, EventArgs e)
        {
            string receiptText = ViewOrders.GetInstance().GetOrderReceipt();

            // Set the receipt text for printing
            printDocument.PrinterSettings = new PrinterSettings();  // You can set specific printer settings here

            // Show the PrintDialog
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Trigger the print action
                printDocument.Print();
            }

            

            ThankYou ThankYou = new ThankYou();
            ThankYou.Show();
            this.Hide();
        }

        private void Takebtn_Click(object sender, EventArgs e)
        {
            string receiptText = ViewOrders.GetInstance().GetOrderReceipt();

            // Set the receipt text for printing
            printDocument.PrinterSettings = new PrinterSettings();  // You can set specific printer settings here

            // Show the PrintDialog
            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                // Trigger the print action
                printDocument.Print();
            }

            

            YouThank YouThank = new YouThank();
            YouThank.Show();
            this.Hide();
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            string receiptText = ViewOrders.GetInstance().GetOrderReceipt();

            // Set font for printing
            Font font = new Font("Arial", 12);
            float yPos = 100;  // Starting Y position to print

            // Print the receipt text line by line
            e.Graphics.DrawString(receiptText, font, Brushes.Black, 100, yPos);
        }

        /*private void GenerateReceipt(string status)
        {
            string receiptText = $"---- Receipt ----\n";
            receiptText += $"Customer ID: {customerID}\n";
            receiptText += $"Date: {DateTime.Now.ToString("MM/dd/yyyy hh:mm tt")}\n";
            receiptText += $"Status: {status}\n";
            receiptText += "-------------------\n";

          
            var orderDetails = GetOrderDetailsFromDatabase(customerID);
            foreach (var item in orderDetails)
            {
                receiptText += $"{item.ProductName} {item.Quantity} x {item.Price} = {item.TotalPrice}\n";
            }

            receiptText += $"-------------------\n";
            receiptText += $"Total: {TPriceTB.Text}\n";

            
            MessageBox.Show(receiptText, "Receipt");
        }

        private List<OrderDetail> GetOrderDetailsFromDatabase(int orderID)
        {
            var orderDetails = new List<OrderDetail>();

            try
            {
                using (OleDbConnection connection = new OleDbConnection("Your Connection String Here"))
                {
                    connection.Open();

                    string query = "SELECT ProductName, Quantity, TotalPrice FROM Orders WHERE CustomerID = @CustomerID";
                    using (OleDbCommand cmd = new OleDbCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@customerID", customerID);

                        using (OleDbDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                string productName = reader["ProductName"].ToString();
                                decimal quantity = Convert.ToDecimal(reader["Quantity"]);
                                decimal totalPrice = Convert.ToDecimal(reader["TotalPrice"]);

                                orderDetails.Add(new OrderDetail
                                {
                                    ProductName = productName,
                                    Quantity = quantity,
                                    Price = totalPrice / quantity,
                                    TotalPrice = totalPrice
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error retrieving order details: " + ex.Message);
            }

            return orderDetails;
        }
    }

    public class OrderDetail
    {
        public string ProductName { get; set; }
        public decimal Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }*/
    }

}
