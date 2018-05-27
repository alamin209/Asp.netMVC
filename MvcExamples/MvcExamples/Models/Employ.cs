using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcExamples.Models
{
    [Table("dbo.Emloyee")]

    public class Employ
    {
        public int EmployID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string City { get; set; }


    }
}