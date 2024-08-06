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
            groupBox1 = new GroupBox();
            rbWednesday = new RadioButton();
            rbTuesday = new RadioButton();
            rbMonday = new RadioButton();
            groupBox2 = new GroupBox();
            rb1 = new RadioButton();
            rb12 = new RadioButton();
            rb10 = new RadioButton();
            lbxbooking = new ListBox();
            gbWeek = new GroupBox();
            rbW3 = new RadioButton();
            rbW2 = new RadioButton();
            rbW1 = new RadioButton();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            gbWeek.SuspendLayout();
            SuspendLayout();
            // 
            // btnMakeBooking
            // 
            btnMakeBooking.Location = new Point(362, 116);
            btnMakeBooking.Name = "btnMakeBooking";
            btnMakeBooking.Size = new Size(176, 24);
            btnMakeBooking.TabIndex = 0;
            btnMakeBooking.Text = "Make a booking";
            btnMakeBooking.UseVisualStyleBackColor = true;
            btnMakeBooking.Click += btnMakeBooking_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbWednesday);
            groupBox1.Controls.Add(rbTuesday);
            groupBox1.Controls.Add(rbMonday);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox1.ForeColor = Color.DarkRed;
            groupBox1.Location = new Point(163, 146);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(107, 118);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Day";
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
            // groupBox2
            // 
            groupBox2.Controls.Add(rb1);
            groupBox2.Controls.Add(rb12);
            groupBox2.Controls.Add(rb10);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.ForeColor = Color.ForestGreen;
            groupBox2.Location = new Point(276, 146);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(80, 118);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Time";
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
            // lbxbooking
            // 
            lbxbooking.FormattingEnabled = true;
            lbxbooking.ItemHeight = 15;
            lbxbooking.Location = new Point(362, 155);
            lbxbooking.Name = "lbxbooking";
            lbxbooking.Size = new Size(176, 109);
            lbxbooking.TabIndex = 4;
            // 
            // gbWeek
            // 
            gbWeek.Controls.Add(rbW3);
            gbWeek.Controls.Add(rbW2);
            gbWeek.Controls.Add(rbW1);
            gbWeek.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            gbWeek.ForeColor = Color.RoyalBlue;
            gbWeek.Location = new Point(72, 146);
            gbWeek.Name = "gbWeek";
            gbWeek.Size = new Size(85, 118);
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
            rbW2.Location = new Point(9, 62);
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
            ClientSize = new Size(800, 450);
            Controls.Add(gbWeek);
            Controls.Add(lbxbooking);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnMakeBooking);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            gbWeek.ResumeLayout(false);
            gbWeek.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnMakeBooking;
        private GroupBox groupBox1;
        private RadioButton rbWednesday;
        private RadioButton rbTuesday;
        private RadioButton rbMonday;
        private GroupBox groupBox2;
        private RadioButton rb1;
        private RadioButton rb12;
        private RadioButton rb10;
        private ListBox lbxbooking;
        private GroupBox gbWeek;
        private RadioButton rbW3;
        private RadioButton rbW2;
        private RadioButton rbW1;
    }
}
