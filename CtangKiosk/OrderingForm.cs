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
using System.IO;
using System.Drawing.Imaging;
using CtangKiosk.Categories;

namespace CtangKiosk
{
    public partial class OrderingForm : Form
    {
        private OleDbConnection conn; 
        

        private string SPName = "";
        private decimal SPPrice = 0;

        public OrderingForm()
        {
            InitializeComponent();

            TPriceTB.ReadOnly = true;
            conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=CitangPOS.accdb");

            NUDQuant.ValueChanged += numericUpDownQuantity_ValueChanged;

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResetFormControls(this);

            
            ViewOrders viewOrdersForm = ViewOrders.GetInstance();
            ResetFormControls(viewOrdersForm);

            Entrance entrance = new Entrance();
            entrance.Show();
            this.Hide();
        }

        private void Merienda(UserControl userControl)
        {

            panel3.Controls.Clear();
            Merienda meriendaControl = new Merienda("Merienda");
            meriendaControl.Dock = DockStyle.Fill;

            meriendaControl.ProductSelected += ProductPanel_Click;

            panel3.Controls.Add(meriendaControl);
        }

        private void Sizzling(UserControl userControl)
        {
            panel3.Controls.Clear();
           Sizzling kakaninControl = new Sizzling("Sizzling");
            kakaninControl.Dock = DockStyle.Fill;

            kakaninControl.ProductSelected += ProductPanel_Click;

            panel3.Controls.Add(kakaninControl);
        }

        private void Kakanin(UserControl userControl)
        {
            panel3.Controls.Clear();
            Kakanin kakaninControl = new Kakanin("Kakanin");
            kakaninControl.Dock = DockStyle.Fill;

            kakaninControl.ProductSelected += ProductPanel_Click;

            panel3.Controls.Add(kakaninControl);
        }

        private void Special(UserControl userControl)
        {
            panel3.Controls.Clear();
            Special meriendaControl = new Special("Special");
            meriendaControl.Dock = DockStyle.Fill;

            meriendaControl.ProductSelected += ProductPanel_Click;

            panel3.Controls.Add(meriendaControl);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Orderbtn_Click(object sender, EventArgs e)
        {
            //ViewOrders vieworderForm = new ViewOrders();
            //vieworderForm.Show();
            //this.Hide();
            ViewOrders viewOrderForm = ViewOrders.GetInstance();
            viewOrderForm.Show();
            this.Hide();
        }

        private void Speciealbtn_Click(object sender, EventArgs e)
        {
            Special(new Categories.Special("Special"));
        }

        private void Meryendabtn_Click(object sender, EventArgs e)
        {
            Merienda(new Categories.Merienda("Merienda"));
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Kakaninbtn_Click(object sender, EventArgs e)
        {
            Kakanin(new Categories.Kakanin("Kakanin"));
        }

        private void Sizzlingbtn_Click(object sender, EventArgs e)
        {
            Sizzling(new Categories.Sizzling("Sizzling"));
        }


        public void ProductPanel_Click(string productName, decimal productPrice)
        {
            
            SPName = productName;
            SPPrice = productPrice;

        
            label2.Text = SPName;

            
            NUDQuant.Value = 0;  
            TPriceTB.Text = "₱0.00"; 
        }



        private void numericUpDownQuantity_ValueChanged(object sender, EventArgs e)
        {
           
            decimal quantity = NUDQuant.Value;
            decimal totalPrice = quantity * SPPrice;

           
            TPriceTB.Text = $"₱{totalPrice:F2}";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TPriceTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void NUDQuant_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Addbtn_Click(object sender, EventArgs e)
        {
            decimal quantity = NUDQuant.Value;
            decimal totalPrice = quantity * SPPrice;

            if (string.IsNullOrEmpty(SPName) || totalPrice <= 0)
            {
                MessageBox.Show("Please select a product and set a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //ViewOrders viewOrderForm = new ViewOrders();
            //viewOrderForm.AddOrder(SPName, quantity, totalPrice);
            //viewOrderForm.Show();

            ViewOrders viewOrderForm = ViewOrders.GetInstance();
            viewOrderForm.AddOrder(SPName, quantity, totalPrice);


            SPName = "";
            SPPrice = 0;
            label2.Text = "No product selected";
            TPriceTB.Text = "₱0.00";
            NUDQuant.Value = 0;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void ResetFormControls(Control parent)
        {
            foreach (Control ctrl in parent.Controls)
            {
       
                if (ctrl is TextBox)
                {
                    (ctrl as TextBox).Clear();
                }
            
                else if (ctrl is FlowLayoutPanel)
                {
                    (ctrl as FlowLayoutPanel).Controls.Clear();
                }
        
                else if (ctrl is NumericUpDown)
                {
                    (ctrl as NumericUpDown).Value = 0;
                }
        
                else if (ctrl is RadioButton)
                {
                    (ctrl as RadioButton).Checked = false;
                }
        
                else if (ctrl is CheckBox)
                {
                    (ctrl as CheckBox).Checked = false;
                }

               
                if (ctrl.HasChildren)
                {
                    ResetFormControls(ctrl);  
                }
            }
        }
    }


    }

