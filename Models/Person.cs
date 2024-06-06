using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public abstract class Person
    {
        public string? CPF { get; set; }
        public string? Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Adress? Adress { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
    }
}
