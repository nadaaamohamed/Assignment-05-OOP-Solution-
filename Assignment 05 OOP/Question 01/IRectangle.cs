﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_05_OOP
{
    internal interface IRectangle : IShape
    {
        public double Length { get; set; }
        public double Width { get; set; }   
    }
}
