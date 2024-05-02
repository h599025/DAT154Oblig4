using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManagementSystem
{
    public partial class ViewTasks : Form
    {

        dat154Context dx;
        DbSet<Service> Service;
        public ViewTasks(dat154Context d)
        {
            InitializeComponent();
            dx = d;
            Service = dx.Services;
            Service.Load();

            List<Service> list = Service.ToList();
            foreach(Service s in list)
            {
                ListViewItem item = new ListViewItem(s.Roomnr.ToString());
                item.SubItems.Add(s.Checkedin.ToString());
                if(s.Cleaning !=null)
                {
                    item.SubItems.Add(s.Cleaning.ToString());
                } else
                {
                    item.SubItems.Add("null");
                }
                if (s.Service1 != null)
                {
                    item.SubItems.Add(s.Service1.ToString());
                }
                else
                {
                    item.SubItems.Add("null");
                }
                if (s.Maintenance != null)
                {
                    item.SubItems.Add(s.Maintenance.ToString());
                }
                else
                {
                    item.SubItems.Add("null");
                }
                if (s.Status != null)
                {
                    item.SubItems.Add(s.Status.ToString());
                }
                else
                {
                    item.SubItems.Add("null");
                }
                if (s.Note != null)
                {
                    item.SubItems.Add(s.Note.ToString());
                }
                else
                {
                    item.SubItems.Add("null");
                }
                listView1.Items.Add(item);
            }

            
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
