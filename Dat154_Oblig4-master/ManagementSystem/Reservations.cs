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
    public partial class Reservations : Form
    {
        dat154Context dx;
        DbSet<Booking> booking;
        DbSet<Room> rooms;
        DbSet<Customer> customer;
        public Reservations(dat154Context d)
        {
            InitializeComponent();
            dx = d;
            booking = dx.Bookings;
            booking.Load();
            rooms = dx.Rooms;
            customer = dx.Customers;

            List<Booking> list = booking.ToList();
            foreach (Booking b in list)
            {
                ListViewItem item = new ListViewItem(b.Id.ToString());
                item.SubItems.Add(b.Email.ToString());
                item.SubItems.Add(b.Roomnr.ToString());
                item.SubItems.Add(b.Checkindate.ToString());
                item.SubItems.Add(b.Checkoutdate.ToString());
                listView1.Items.Add(item);
            }

            List<Room> list2 = rooms.ToList();
            foreach (Room r in list2)
            {
                roomnrbox.Items.Add(r.Roomnr);
            }
            
            List<Customer> list3 = customer.ToList();
            foreach(Customer c in list3)
            {
                emailbox.Items.Add(c.Email);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void remove_Click(object sender, EventArgs e)
        {

            String id = listView1.SelectedItems[0].Text;
            if (id != null)
            {
                var result = from b in booking
                             where b.Id == int.Parse(id)
                             select b;

                Booking b1 = result.FirstOrDefault();
                booking.Remove(b1);
                dx.SaveChanges();

                listView1.Items.Remove(listView1.SelectedItems[0]);
                
                
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void add_res_Click(object sender, EventArgs e)
        {      
            if (emailbox.Text != null && roomnrbox.Text != null)
            {
                var rr = from r in rooms
                         where r.Roomnr == int.Parse(roomnrbox.Text)
                         select r;

                Room room = rr.FirstOrDefault();

                var cc = from c in customer
                         where c.Email == emailbox.Text
                         select c;

                Customer c1 = cc.FirstOrDefault();

                Booking b = new Booking();
               
                b.RoomnrNavigation = room;
                room.Bookings.Add(b);

                b.EmailNavigation = c1;
                c1.Bookings.Add(b);

                Random rnd = new Random();
                b.Id = rnd.Next(0,3000);
                b.Email = emailbox.Text;
                b.Roomnr = int.Parse(roomnrbox.Text);
                b.Checkindate = dateTimePicker1.Value;
                b.Checkoutdate = dateTimePicker1.Value;
                booking.Add(b);
                dx.SaveChanges();

                ListViewItem item = new ListViewItem(b.Id.ToString());
                item.SubItems.Add(b.Email.ToString());
                item.SubItems.Add(b.Roomnr.ToString());
                item.SubItems.Add(b.Checkindate.ToString());
                item.SubItems.Add(b.Checkoutdate.ToString());
                listView1.Items.Add(item);
            }
        }
    }
}
