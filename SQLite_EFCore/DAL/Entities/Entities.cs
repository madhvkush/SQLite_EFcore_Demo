using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLite_EFCore.DAL.Entities
{
    [Table("Persons")]
    public class Person
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public virtual Address Address { get; set; } // Navigation property for Address
    }

    [Table("Addresses")]
    public class Address
    {
        [Key]
        public Guid Id { get; set; }
        public Guid PersonId { get; set; }
        [ForeignKey("PersonId")]
        public virtual Person Person { get; set; } // Navigation property for Person
        public string City { get; set; }
        public string State { get; set; }
    }
}
