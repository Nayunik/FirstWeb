﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstWeb.Data.Models
{
    public class Car
    {
        public int id { set; get; }

        public string name { set; get; }

        public string shortDesc { set; get; }

        public string longDesc { set; get; }

        public  string img { set; get; }

        public ushort price { set; get; }

        public bool isFavorit { set; get; }

        public int available { set; get; }

        public int categoryId { set; get; }

        public virtual  Category category { set; get; }

    }
}