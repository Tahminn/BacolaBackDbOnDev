﻿using BacolaBackDb.Models;
using BacolaBackDb.Models.Home;
using FiorelloBackDb.Models.Admin;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BacolaBackDb.Data
{
    public class AppDbContext: DbContext
    {
        #region DbSetClasses
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<Setting> Settings { get; set; }
        #endregion

        public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}


        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Setting>().HasData(
        //        new Setting
        //        {
        //            Id = 1,
        //            ProductTake = 8,
        //            LoadTake = 4
        //        }
        //        );
        //}
    }
}
