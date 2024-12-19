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
    public partial class YouThank : Form
    {
        public YouThank()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ResetFormControls(this);


            ViewOrders viewOrdersForm = ViewOrders.GetInstance();
            ResetFormControls(viewOrdersForm);

            Entrance entrance = new Entrance();
            entrance.Show();
            this.Hide();
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
