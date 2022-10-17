﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SWII6_TP02.Models;
using System.Data.Entity;

namespace SWII6_TP02.DAO
{
    public class PortoContext:DbContext
    {
        public DbSet<BL> BLs { get; set; }
        public DbSet<Container> Containers { get; set; }
    }
}