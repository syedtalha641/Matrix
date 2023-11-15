﻿using Matrix.Core.Domain.Entities;
using Matrix.Infastructure.Persistence.Seeding;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace Matrix.Infastructure.Persistence
{
    public class MatrixContext : DbContext
    {
        public MatrixContext() { }
        public MatrixContext(DbContextOptions<MatrixContext> options)
        : base(options)
        { }

        //public DbSet<tblOrganizations> Organizations { get; set; }
        public DbSet<tblWareHouse> WareHouses { get; set; }
        public DbSet<tblWareHouseInHoldProducts> WareHouseInHoldProducts { get; set; }
        public DbSet<tblSuppliers> Suppliers { get; set; }
        public DbSet<tblModels> Models { get; set; }
        public DbSet<tblLocalPurchase> LocalPurchase { get; set; }
        public DbSet<tblLocalPurchaseDetails> LocalPurchaseDetails { get; set; }
        public DbSet<tblSalesInvoice> SalesInvoice { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedData();
            base.OnModelCreating(modelBuilder);
        }

    }
}