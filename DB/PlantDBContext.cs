using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic.Devices;

namespace Lab7.DB
{
    public class PlantDBContext:DbContext
    {
        
        public DbSet<Plants> Plant { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Plant_DB;Trusted_Connection=True;");
        }

    }
}
