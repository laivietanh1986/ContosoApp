using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoApp.Models
{
    [Table("PersonPhone", Schema ="Person")]
    public class PersonPhone
    {
        [Key]
        public int BusinessEntityID { get; set; }
        public string PhoneNumber { get; set; }       
        public virtual Person Person { get; set; }

    }
}
