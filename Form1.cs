namespace Booking_with_Radiobuttons
{
    public partial class Form1 : Form
    {
        string day, time;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnMakeBooking_Click(object sender, EventArgs e)
        {
            if (rbMonday.Checked)
            {
                day = rbMonday.Text;
            }
            else if (rbTuesday.Checked)
            {
                day = rbTuesday.Text;
            }
            else if (rbWednesday.Checked)
            { day = rbWednesday.Text; }


            if (rb10.Checked)
            {
                time = rb10.Text;
            }
            else if (rb12.Checked)
            {
                time = rb12.Text;
            }
            else if (rb1.Checked)
            {
                time = rb1.Text;
            }

            lbxbooking.Items.Add(day + " " + time);



        }
    }
}
