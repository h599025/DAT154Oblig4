namespace ManagementSystem
{
    partial class Reservations
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
            this.label1 = new System.Windows.Forms.Label();
            this.remove = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.bookingid = new System.Windows.Forms.ColumnHeader();
            this.email = new System.Windows.Forms.ColumnHeader();
            this.roomnr = new System.Windows.Forms.ColumnHeader();
            this.checkindate = new System.Windows.Forms.ColumnHeader();
            this.checkoutdate = new System.Windows.Forms.ColumnHeader();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.roomnrbox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.emailbox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 0;
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(653, 65);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(135, 31);
            this.remove.TabIndex = 1;
            this.remove.Text = "Remove Selected Item";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.bookingid,
            this.email,
            this.roomnr,
            this.checkindate,
            this.checkoutdate});
            this.listView1.Location = new System.Drawing.Point(12, 125);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 313);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // bookingid
            // 
            this.bookingid.Text = "ID";
            // 
            // email
            // 
            this.email.Text = "Email";
            this.email.Width = 150;
            // 
            // roomnr
            // 
            this.roomnr.Text = "Room Nr";
            this.roomnr.Width = 70;
            // 
            // checkindate
            // 
            this.checkindate.Text = "Check in Date";
            this.checkindate.Width = 120;
            // 
            // checkoutdate
            // 
            this.checkoutdate.Text = "Check out Date";
            this.checkoutdate.Width = 120;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Email:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Room Nr:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Check in Date:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Check out Date:";
            // 
            // roomnrbox
            // 
            this.roomnrbox.FormattingEnabled = true;
            this.roomnrbox.Location = new System.Drawing.Point(111, 35);
            this.roomnrbox.Name = "roomnrbox";
            this.roomnrbox.Size = new System.Drawing.Size(200, 23);
            this.roomnrbox.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(111, 64);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker1.TabIndex = 9;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(111, 93);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 23);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Add Reservation";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.add_res_Click);
            // 
            // emailbox
            // 
            this.emailbox.FormattingEnabled = true;
            this.emailbox.Location = new System.Drawing.Point(111, 6);
            this.emailbox.Name = "emailbox";
            this.emailbox.Size = new System.Drawing.Size(200, 23);
            this.emailbox.TabIndex = 12;
            // 
            // Reservations
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.emailbox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.roomnrbox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.label1);
            this.Name = "Reservations";
            this.Text = "Reservations";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Button remove;
        private ListView listView1;
        private ColumnHeader bookingid;
        private ColumnHeader roomnr;
        private ColumnHeader checkindate;
        private ColumnHeader checkoutdate;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox emailtext;
        private ComboBox roomnrbox;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Button button1;
        private ColumnHeader email;
        private ComboBox emailbox;
    }
}