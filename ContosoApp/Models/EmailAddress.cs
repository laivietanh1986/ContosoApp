using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoApp.Models
{
    [Table("EmailAddress", Schema ="Person")]
    public class EmailAddresses
    {
        [Key]
        public int BusinessEntityID { get; set; }
        public int EmailAddressId { get; set; }
        public string EmailAddress { get; set; }
        public virtual Person Person { get; set; }

    }
}
