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
    public partial class MainMenu : Form
    {
        private List<Flight> flights;

        public MainMenu(ref List<Flight> flights)
        {
            this.flights = flights;
            InitializeComponent();
        }
        
        private void buttonReservation_Click(object sender, EventArgs e)
        {
            FlightReservation flightReservation = new FlightReservation(ref flights);
            flightReservation.ShowDialog();
        }

        private void buttonPassengers_Click(object sender, EventArgs e)
        {
            ViewsPassengers viewsPassengers = new ViewsPassengers();
            viewsPassengers.ShowDialog();
        }

        private void buttonFlights_Click(object sender, EventArgs e)
        {
            ViewsFlights viewsFlights = new ViewsFlights();
            viewsFlights.ShowDialog();
        }
    }
}
