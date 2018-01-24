﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MileageCalculator
{
    public partial class Form1 : Form
    {

        int startingMileage;
        int endingMileage;
        double milesTraveled;        
        double amountOwed;
        double reimburseRate = .39;
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            startingMileage = (int) startingMile.Value;
            endingMileage = (int) endingMile.Value;
            if (startingMileage < endingMileage)
            {
                milesTraveled = endingMileage -= startingMileage;
                amountOwed = milesTraveled *= reimburseRate;
                label4.Text = "$" + amountOwed;
            }
            else
            {
                MessageBox.Show("Ending Mileage must be higher than Starting Mileage", "Cannot Calculate Mileage");
            }
        }
    }
}
