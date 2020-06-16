using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace corewebapi.Model
{
    public class CourseContext : DbContext
    {
        // Replace your connecting string
        readonly string connectionstring = "";
        public DbSet<Course> Courses { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(connectionstring);
            base.OnConfiguring(options);
        }
    }

    
}
