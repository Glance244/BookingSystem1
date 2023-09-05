using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookingSystem1
{
    public partial class Cfrmbooking : Form
    {
        public Cfrmbooking()
        {
            InitializeComponent();
        }

        private void btnQuote_Click(object sender, EventArgs e)
        {
            Booking booking;
            if (radOneway.Checked)
            {
                booking = new OneWay(cmbClass.SelectedItem.ToString(),
                                      (int)nudPass.Value, dtpDepature.Value.Date);

            }
            else
            {
                booking = new Return(cmbClass.SelectedItem.ToString(),
                 (int)nudPass.Value, dtpDepature.Value.Date,
                         dtpReturn.Value.Date);
            }
            MessageBox.Show(booking.Details(), "ACCEPT QUOTE?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);




        }


    }
}
