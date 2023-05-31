using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ilk.Models
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-AKNTGAT; database=corePersonel; integrated security=true;");
        }
        public DbSet<Departman> Departmans { get; set; }
        public DbSet<Personel> Personels { get; set; }
		public DbSet<Admin> Admins { get; set; }
	}
}
