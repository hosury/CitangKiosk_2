using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CtangKiosk
{
    public partial class Entrance : Form
    {
        private Timer timerBlink;

        public Entrance()
        {
            InitializeComponent();

            timerBlink = new Timer();
            timerBlink.Interval = 500; 
            timerBlink.Tick += TimerBlink_Tick; 
            timerBlink.Start();

        }



        private void TimerBlink_Tick(object sender, EventArgs e)
        {
           
            label1.Visible = !label1.Visible;
        }

        
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            timerBlink.Stop();
            base.OnFormClosing(e);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            OrderingForm orderingForm = new OrderingForm();
            orderingForm.Show();
            this.Hide();
        }

        private void Entrance_Resize(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OrderingForm orderingForm = new OrderingForm();
            orderingForm.Show();  
            this.Hide();
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Entrance_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Entrance_Load(object sender, EventArgs e)
        {
           
        }

        private void Entrance_Click(object sender, EventArgs e)
        {
            OrderingForm orderingForm = new OrderingForm();
            orderingForm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            OrderingForm orderingForm = new OrderingForm();
            orderingForm.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

            
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            OrderingForm orderingForm = new OrderingForm();
            orderingForm.Show();
            this.Hide();
        }

        private void panel2_Click(object sender, EventArgs e)
        {
            OrderingForm orderingForm = new OrderingForm();
            orderingForm.Show();
            this.Hide();
        }
    }
}
