namespace ManagementSystem
{
    partial class ViewTasks
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.roomnr = new System.Windows.Forms.ColumnHeader();
            this.checkedin = new System.Windows.Forms.ColumnHeader(1);
            this.cleaning = new System.Windows.Forms.ColumnHeader();
            this.service1 = new System.Windows.Forms.ColumnHeader();
            this.maintenance = new System.Windows.Forms.ColumnHeader();
            this.status = new System.Windows.Forms.ColumnHeader();
            this.note = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tasks";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.roomnr,
            this.checkedin,
            this.cleaning,
            this.service1,
            this.maintenance,
            this.status,
            this.note});
            this.listView1.Location = new System.Drawing.Point(12, 61);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(776, 377);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // roomnr
            // 
            this.roomnr.Text = "Room Nr";
            // 
            // checkedin
            // 
            this.checkedin.Text = "Checked in";
            this.checkedin.Width = 100;
            // 
            // cleaning
            // 
            this.cleaning.Text = "Cleaning";
            this.cleaning.Width = 140;
            // 
            // service1
            // 
            this.service1.Text = "Service";
            this.service1.Width = 140;
            // 
            // maintenance
            // 
            this.maintenance.Text = "Maintenance";
            this.maintenance.Width = 140;
            // 
            // status
            // 
            this.status.Text = "Status";
            this.status.Width = 70;
            // 
            // note
            // 
            this.note.Text = "Note";
            // 
            // ViewTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "ViewTasks";
            this.Text = "ViewTasks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ListView listView1;
        private ColumnHeader roomnr;
        private ColumnHeader checkedin;
        private ColumnHeader cleaning;
        private ColumnHeader service1;
        private ColumnHeader maintenance;
        private ColumnHeader status;
        private ColumnHeader note;
    }
}