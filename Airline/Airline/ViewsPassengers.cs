﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Airline
{
    public partial class ViewsPassengers : Form
    {
        private List<Flight> flights;
        public ViewsPassengers(List<Flight> flights)
        {
            InitializeComponent();
            this.flights = flights;
            updateViewsPassengers();
        }

        private void labelDelete2_Click(object sender, EventArgs e)
        {

        }

        public void updateViewsPassengers()
        {
            listViewPassengers1.Items.Clear();
            string[] arrString = new string[6];
            
            foreach (Passenger passenger in passengers)
            {
                arrString[0] = passenger.getId();
                arrString[1] = passenger.getFlightRoute();
                arrString[2] = passenger.getName();
                arrString[3] = passenger.getLastname();
                arrString[4] = Convert.ToString(passenger.getAge());
                arrString[5] = Convert.ToString(passenger.getSeatNumber() + 1);
                ListViewItem item = new ListViewItem(arrString);
                listViewPassengers1.Items.Add(item);
            }

        }
    }
}
