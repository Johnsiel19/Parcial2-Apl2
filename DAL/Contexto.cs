﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace DAL
{
    public class Contexto : DbContext
    {


        //public DbSet<Pagos> Pagos { get; set; }



        public Contexto() : base("ConStr")
        { }

    }
}
