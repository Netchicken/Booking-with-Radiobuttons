namespace Booking_with_Radiobuttons
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnMakeBooking = new Button();
            gbxDay = new GroupBox();
            rbWednesday = new RadioButton();
            rbTuesday = new RadioButton();
            rbMonday = new RadioButton();
            gbxTime = new GroupBox();
            rb1 = new RadioButton();
            rb12 = new RadioButton();
            rb10 = new RadioButton();
            lbxBooking = new ListBox();
            gbWeek = new GroupBox();
            rbW3 = new RadioButton();
            rbW2 = new RadioButton();
            rbW1 = new RadioButton();
            gbxDay.SuspendLayout();
            gbxTime.SuspendLayout();
            gbWeek.SuspendLayout();
            SuspendLayout();
            // 
            // btnMakeBooking
            // 
            btnMakeBooking.Location = new Point(379, 34);
            btnMakeBooking.Name = "btnMakeBooking";
            btnMakeBooking.Size = new Size(176, 24);
            btnMakeBooking.TabIndex = 0;
            btnMakeBooking.Text = "Make a booking";
            btnMakeBooking.UseVisualStyleBackColor = true;
            btnMakeBooking.Click += btnMakeBooking_Click;
            // 
            // gbxDay
            // 
            gbxDay.BackColor = Color.Lavender;
            gbxDay.Controls.Add(rbWednesday);
            gbxDay.Controls.Add(rbTuesday);
            gbxDay.Controls.Add(rbMonday);
            gbxDay.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            gbxDay.ForeColor = Color.DarkRed;
            gbxDay.Location = new Point(149, 61);
            gbxDay.Name = "gbxDay";
            gbxDay.Size = new Size(107, 118);
            gbxDay.TabIndex = 1;
            gbxDay.TabStop = false;
            gbxDay.Text = "Day";
            // 
            // rbWednesday
            // 
            rbWednesday.AutoSize = true;
            rbWednesday.Location = new Point(9, 87);
            rbWednesday.Name = "rbWednesday";
            rbWednesday.Size = new Size(89, 19);
            rbWednesday.TabIndex = 2;
            rbWednesday.TabStop = true;
            rbWednesday.Text = "Wednesday";
            rbWednesday.UseVisualStyleBackColor = true;
            // 
            // rbTuesday
            // 
            rbTuesday.AutoSize = true;
            rbTuesday.Location = new Point(9, 62);
            rbTuesday.Name = "rbTuesday";
            rbTuesday.Size = new Size(69, 19);
            rbTuesday.TabIndex = 1;
            rbTuesday.TabStop = true;
            rbTuesday.Text = "Tuesday";
            rbTuesday.UseVisualStyleBackColor = true;
            // 
            // rbMonday
            // 
            rbMonday.AutoSize = true;
            rbMonday.Location = new Point(9, 32);
            rbMonday.Name = "rbMonday";
            rbMonday.Size = new Size(69, 19);
            rbMonday.TabIndex = 0;
            rbMonday.TabStop = true;
            rbMonday.Text = "Monday";
            rbMonday.UseVisualStyleBackColor = true;
            // 
            // gbxTime
            // 
            gbxTime.BackColor = Color.Lavender;
            gbxTime.Controls.Add(rb1);
            gbxTime.Controls.Add(rb12);
            gbxTime.Controls.Add(rb10);
            gbxTime.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            gbxTime.ForeColor = Color.ForestGreen;
            gbxTime.Location = new Point(262, 61);
            gbxTime.Name = "gbxTime";
            gbxTime.Size = new Size(102, 118);
            gbxTime.TabIndex = 3;
            gbxTime.TabStop = false;
            gbxTime.Text = "Time";
            // 
            // rb1
            // 
            rb1.AutoSize = true;
            rb1.Location = new Point(9, 87);
            rb1.Name = "rb1";
            rb1.Size = new Size(50, 19);
            rb1.TabIndex = 2;
            rb1.TabStop = true;
            rb1.Text = "1pm";
            rb1.UseVisualStyleBackColor = true;
            // 
            // rb12
            // 
            rb12.AutoSize = true;
            rb12.Location = new Point(8, 62);
            rb12.Name = "rb12";
            rb12.Size = new Size(57, 19);
            rb12.TabIndex = 1;
            rb12.TabStop = true;
            rb12.Text = "12pm";
            rb12.UseVisualStyleBackColor = true;
            // 
            // rb10
            // 
            rb10.AutoSize = true;
            rb10.Location = new Point(9, 32);
            rb10.Name = "rb10";
            rb10.Size = new Size(56, 19);
            rb10.TabIndex = 0;
            rb10.TabStop = true;
            rb10.Text = "10am";
            rb10.UseVisualStyleBackColor = true;
            // 
            // lbxBooking
            // 
            lbxBooking.FormattingEnabled = true;
            lbxBooking.ItemHeight = 15;
            lbxBooking.Location = new Point(379, 64);
            lbxBooking.Name = "lbxBooking";
            lbxBooking.Size = new Size(176, 109);
            lbxBooking.TabIndex = 4;
            lbxBooking.SelectedIndexChanged += lbxbooking_SelectedIndexChanged;
            // 
            // gbWeek
            // 
            gbWeek.BackColor = Color.Lavender;
            gbWeek.Controls.Add(rbW3);
            gbWeek.Controls.Add(rbW2);
            gbWeek.Controls.Add(rbW1);
            gbWeek.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            gbWeek.ForeColor = Color.MediumSeaGreen;
            gbWeek.Location = new Point(24, 61);
            gbWeek.Name = "gbWeek";
            gbWeek.Size = new Size(119, 112);
            gbWeek.TabIndex = 3;
            gbWeek.TabStop = false;
            gbWeek.Text = "Week";
            // 
            // rbW3
            // 
            rbW3.AutoSize = true;
            rbW3.Location = new Point(9, 87);
            rbW3.Name = "rbW3";
            rbW3.Size = new Size(68, 19);
            rbW3.TabIndex = 2;
            rbW3.TabStop = true;
            rbW3.Text = "Week 3";
            rbW3.UseVisualStyleBackColor = true;
            // 
            // rbW2
            // 
            rbW2.AutoSize = true;
            rbW2.Location = new Point(8, 62);
            rbW2.Name = "rbW2";
            rbW2.Size = new Size(68, 19);
            rbW2.TabIndex = 1;
            rbW2.TabStop = true;
            rbW2.Text = "Week 2";
            rbW2.UseVisualStyleBackColor = true;
            // 
            // rbW1
            // 
            rbW1.AutoSize = true;
            rbW1.Location = new Point(9, 32);
            rbW1.Name = "rbW1";
            rbW1.Size = new Size(68, 19);
            rbW1.TabIndex = 0;
            rbW1.TabStop = true;
            rbW1.Text = "Week 1";
            rbW1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(689, 465);
            Controls.Add(gbWeek);
            Controls.Add(lbxBooking);
            Controls.Add(gbxTime);
            Controls.Add(gbxDay);
            Controls.Add(btnMakeBooking);
            Name = "Form1";
            Text = "Form1";
            gbxDay.ResumeLayout(false);
            gbxDay.PerformLayout();
            gbxTime.ResumeLayout(false);
            gbxTime.PerformLayout();
            gbWeek.ResumeLayout(false);
            gbWeek.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnMakeBooking;
        private GroupBox gbxDay;
        private RadioButton rbWednesday;
        private RadioButton rbTuesday;
        private RadioButton rbMonday;
        private GroupBox gbxTime;
        private RadioButton rb1;
        private RadioButton rb12;
        private RadioButton rb10;
        private ListBox lbxBooking;
        private GroupBox gbWeek;
        private RadioButton rbW3;
        private RadioButton rbW2;
        private RadioButton rbW1;
    }
}
