﻿using Balloons.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Balloons
{
    public class Balloon : IProperty
    {
        public Balloon(string color, int size)
        {
            this.Color = color;
            this.Size = size;
        }
        public string Color { get; set; }
        public int Size { get; set; }
    }
}
