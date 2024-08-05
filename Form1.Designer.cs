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
            rbMonday = new RadioButton();
            rbTuesday = new RadioButton();
            rbWednesday = new RadioButton();
            groupBox2 = new GroupBox();
            rb1 = new RadioButton();
            rb12 = new RadioButton();
            rb10 = new RadioButton();
            lbxbooking = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnMakeBooking
            // 
            btnMakeBooking.Location = new Point(256, 64);
            btnMakeBooking.Name = "btnMakeBooking";
            btnMakeBooking.Size = new Size(147, 44);
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
            groupBox1.Location = new Point(87, 140);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(141, 118);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Day";
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
            // groupBox2
            // 
            groupBox2.Controls.Add(rb1);
            groupBox2.Controls.Add(rb12);
            groupBox2.Controls.Add(rb10);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            groupBox2.ForeColor = Color.ForestGreen;
            groupBox2.Location = new Point(256, 140);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(141, 118);
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
            lbxbooking.Location = new Point(427, 149);
            lbxbooking.Name = "lbxbooking";
            lbxbooking.Size = new Size(176, 109);
            lbxbooking.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}
