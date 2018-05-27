using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcExamples.Models
{
    public class EmployeContext :DbContext
    {
        public DbSet<Employ> Employs { get; set; }
    }
}