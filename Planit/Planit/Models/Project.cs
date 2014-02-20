using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Planit.Models
{
    public class Project

    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime DueDate { get; set; }

        public DateTime StartDate { get; set; }
    }
    public class ProjectDBContext : ApplicationDbContext {
        public DbSet<Project> Projects { get; set; }
    }
}