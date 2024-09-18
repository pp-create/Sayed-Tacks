using DAL.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DataBase
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

 
 public  DbSet<Details_Task> Details_Task_TBL { get; set; }
 public  DbSet<Park> Park_TBL { get; set; }
 public  DbSet<Area> Area_TBL { get; set; }
 public  DbSet<governorate> governorate_TBL { get; set; }
 public  DbSet<Citys> Citys_TBL { get; set; }
 public  DbSet<SurveysVistor> SurveysVistor_TBL { get; set; }



        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


       }
    }
}
