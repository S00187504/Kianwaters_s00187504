﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kianwaters_s00187504
{
    public class Phone
    {
        //Properties
        //Ex2
        public string Name { get; set; }
        public double Price { get; set; }
        public string OperatingSystem { get; set; }
        public string OS_Image { get; set; }
        public string Phone_string { get; set; }

        //Ex3
        //Creating a method which tale percentage value and then increases the price by that value
        public void IncreasePrice(double StartingPrice, double PercentageValue)
        {
            Price = (StartingPrice * PercentageValue) + StartingPrice;
        }
    }

   
}
