﻿namespace RestEasy_System.Presentation
{
    partial class BookingForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookingForm));
            this.label1 = new System.Windows.Forms.Label();
            this.bookingListView = new System.Windows.Forms.ListView();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bookingNoTextBox = new System.Windows.Forms.TextBox();
            this.roomNumberTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.arrivalDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.endDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.availabilityButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.guestComboBox = new System.Windows.Forms.ComboBox();
            this.guestButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "All Bookings:";
            // 
            // bookingListView
            // 
            this.bookingListView.HideSelection = false;
            this.bookingListView.Location = new System.Drawing.Point(12, 184);
            this.bookingListView.Name = "bookingListView";
            this.bookingListView.Size = new System.Drawing.Size(857, 183);
            this.bookingListView.TabIndex = 1;
            this.bookingListView.UseCompatibleStateImageBehavior = false;
            this.bookingListView.SelectedIndexChanged += new System.EventHandler(this.BookingListView_SelectedIndexChanged);
            // 
            // messageTextBox
            // 
            this.messageTextBox.Enabled = false;
            this.messageTextBox.Location = new System.Drawing.Point(901, 311);
            this.messageTextBox.Multiline = true;
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(283, 111);
            this.messageTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(898, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Messages:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 391);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Booking Number:";
            // 
            // bookingNoTextBox
            // 
            this.bookingNoTextBox.Location = new System.Drawing.Point(165, 392);
            this.bookingNoTextBox.Name = "bookingNoTextBox";
            this.bookingNoTextBox.Size = new System.Drawing.Size(37, 20);
            this.bookingNoTextBox.TabIndex = 5;
            // 
            // roomNumberTextBox
            // 
            this.roomNumberTextBox.Location = new System.Drawing.Point(165, 424);
            this.roomNumberTextBox.Name = "roomNumberTextBox";
            this.roomNumberTextBox.Size = new System.Drawing.Size(37, 20);
            this.roomNumberTextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(9, 423);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Room Number:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(232, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Arrival Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(230, 391);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Select Dates";
            // 
            // arrivalDateTimePicker
            // 
            this.arrivalDateTimePicker.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.arrivalDateTimePicker.CalendarTitleForeColor = System.Drawing.Color.White;
            this.arrivalDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.arrivalDateTimePicker.Location = new System.Drawing.Point(338, 424);
            this.arrivalDateTimePicker.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.arrivalDateTimePicker.MinDate = new System.DateTime(2019, 9, 21, 0, 0, 0, 0);
            this.arrivalDateTimePicker.Name = "arrivalDateTimePicker";
            this.arrivalDateTimePicker.Size = new System.Drawing.Size(182, 20);
            this.arrivalDateTimePicker.TabIndex = 11;
            this.arrivalDateTimePicker.Value = new System.DateTime(2019, 9, 21, 0, 0, 0, 0);
            this.arrivalDateTimePicker.ValueChanged += new System.EventHandler(this.ArrivalDateTimePicker_ValueChanged);
            // 
            // endDateDateTimePicker
            // 
            this.endDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.endDateDateTimePicker.Location = new System.Drawing.Point(336, 463);
            this.endDateDateTimePicker.MaxDate = new System.DateTime(2019, 12, 31, 0, 0, 0, 0);
            this.endDateDateTimePicker.MinDate = new System.DateTime(2019, 9, 21, 0, 0, 0, 0);
            this.endDateDateTimePicker.Name = "endDateDateTimePicker";
            this.endDateDateTimePicker.Size = new System.Drawing.Size(182, 20);
            this.endDateDateTimePicker.TabIndex = 13;
            this.endDateDateTimePicker.Value = new System.DateTime(2019, 9, 21, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(230, 462);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "End Date:";
            // 
            // availabilityButton
            // 
            this.availabilityButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.availabilityButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availabilityButton.ForeColor = System.Drawing.Color.Black;
            this.availabilityButton.Location = new System.Drawing.Point(235, 501);
            this.availabilityButton.Name = "availabilityButton";
            this.availabilityButton.Size = new System.Drawing.Size(283, 31);
            this.availabilityButton.TabIndex = 14;
            this.availabilityButton.Text = "Check Availability";
            this.availabilityButton.UseVisualStyleBackColor = false;
            this.availabilityButton.Click += new System.EventHandler(this.AvailabilityButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(556, 391);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "Guest Information";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(556, 423);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "Existing Guest:";
            // 
            // guestComboBox
            // 
            this.guestComboBox.FormattingEnabled = true;
            this.guestComboBox.Location = new System.Drawing.Point(684, 423);
            this.guestComboBox.Name = "guestComboBox";
            this.guestComboBox.Size = new System.Drawing.Size(196, 21);
            this.guestComboBox.TabIndex = 17;
            this.guestComboBox.SelectedIndexChanged += new System.EventHandler(this.GuestComboBox_SelectedIndexChanged);
            // 
            // guestButton
            // 
            this.guestButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.guestButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guestButton.ForeColor = System.Drawing.Color.Black;
            this.guestButton.Location = new System.Drawing.Point(559, 464);
            this.guestButton.Name = "guestButton";
            this.guestButton.Size = new System.Drawing.Size(321, 60);
            this.guestButton.TabIndex = 18;
            this.guestButton.Text = "New Guest";
            this.guestButton.UseVisualStyleBackColor = false;
            this.guestButton.Click += new System.EventHandler(this.GuestButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.Black;
            this.deleteButton.Location = new System.Drawing.Point(901, 220);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(170, 56);
            this.deleteButton.TabIndex = 19;
            this.deleteButton.Text = "Delete Booking";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.submitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.Color.Black;
            this.submitButton.Location = new System.Drawing.Point(971, 439);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(148, 41);
            this.submitButton.TabIndex = 20;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.cancelButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.Black;
            this.cancelButton.Location = new System.Drawing.Point(971, 486);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(148, 41);
            this.cancelButton.TabIndex = 21;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-5, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(480, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(280, 57);
            this.label10.TabIndex = 23;
            this.label10.Text = "Booking Form";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.DarkTurquoise;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label11.Location = new System.Drawing.Point(-5, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(1253, 11);
            this.label11.TabIndex = 25;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1075, 109);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(147, 116);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.ClientSize = new System.Drawing.Size(1221, 538);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.guestButton);
            this.Controls.Add(this.guestComboBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.availabilityButton);
            this.Controls.Add(this.endDateDateTimePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.arrivalDateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.roomNumberTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bookingNoTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.messageTextBox);
            this.Controls.Add(this.bookingListView);
            this.Controls.Add(this.label1);
            this.Name = "BookingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BookingForm";
            this.Load += new System.EventHandler(this.BookingForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView bookingListView;
        private System.Windows.Forms.TextBox messageTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox bookingNoTextBox;
        private System.Windows.Forms.TextBox roomNumberTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker arrivalDateTimePicker;
        private System.Windows.Forms.DateTimePicker endDateDateTimePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button availabilityButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox guestComboBox;
        private System.Windows.Forms.Button guestButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}