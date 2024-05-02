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
    public partial class Tasks : Form
    {
        dat154Context dx;
        DbSet<Service> Service;
        DbSet<Room> rooms;
        public Tasks(dat154Context d)
        {
            InitializeComponent();
            dx = d;
            Service = dx.Services;
            rooms = dx.Rooms;

            List<Room> list2 = rooms.ToList();
            foreach (Room r in list2)
            {
                roomnr.Items.Add(r.Roomnr);
            }

        }

        private void Task_Click(object sender, EventArgs e)
        {
            if (roomnr.Text != null && tasktype.Text != null && description.Text != null)
            {
                var rr = from r in rooms
                         where r.Roomnr == int.Parse(roomnr.Text)
                         select r;
                
                Room room = rr.FirstOrDefault();

                Service s = new Service();
                s.Roomnr = int.Parse(roomnr.SelectedIndex.ToString());
                s.RoomnrNavigation = room;
                room.Service = s;

                switch (tasktype.Text)
                {
                    case "Cleaning":
                        s.Cleaning = description.Text;
                        Service.Add(s);
                        dx.SaveChanges();
                        break;
                    case "Maintenance":
                        s.Maintenance = description.Text;
                        Service.Add(s);
                        dx.SaveChanges();
                        break;
                    case "Service":
                        s.Service1 = description.Text;
                        Service.Add(s);
                        dx.SaveChanges();
                        break;
                    default:
                        break;
                }
                roomnr.Text = tasktype.Text = description.Text = "";
            } 
        }

        private void viewtasks_Click(object sender, EventArgs e)
        {
            ViewTasks view = new ViewTasks(dx);
            view.Show();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
