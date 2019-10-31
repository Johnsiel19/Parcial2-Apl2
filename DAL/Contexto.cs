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


        public DbSet<Clientes> Clientes { get; set; }


        public DbSet<Transacciones> Transacciones { get; set; }
        public Contexto() : base("ConStr")
        { }

    }
}
