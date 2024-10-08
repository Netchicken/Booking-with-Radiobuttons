namespace Booking_with_Radiobuttons
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void btnMakeBooking_Click(object sender, EventArgs e)
        {
            //create 3 variables to hold 
            string week = "", day = "", time = "";

            //if you click the first radiobutton
            if (rbW1.Checked)
            {
                //make the text on that radiobutton pass to teh string week. 
                week = rbW1.Text;
            }
            else if (rbW2.Checked)
            {
                week = rbW2.Text;
            }
            else if (rbW3.Checked)
            { week = rbW3.Text; }


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

            lbxBooking.Items.Add(week + " " + day + " " + time);

            //in the groupbox gbWeeks, get all the controls that are radiobuttons, find the first one that is checked, and send back the text on it.

            //  week = gbWeek.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked).Text;

        }

        private void lbxbooking_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxBooking.Items.Clear();
        }
    }
}
