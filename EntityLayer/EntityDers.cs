﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityDers
    {
        private int id;
        private string dersAd;
        private int min;
        private int max;

        public string DersAd { get => dersAd; set => dersAd = value; }
        public int Min { get => min; set => min = value; }
        public int Max { get => max; set => max = value; }
        public int Id { get => id; set => id = value; }
    }
}