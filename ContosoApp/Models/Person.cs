﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoApp.Models
{
    [Table("Person",Schema ="Person")]
    public class Person
    {
        public Person()
        {
            PersonPhones = new List<PersonPhone>();
            EmailAddresses = new List<EmailAddresses>();
        }
        [Key]
        public int BusinessEntityID { get; set; }
        public string PersonType { get; set; }
        public bool NameStyle { get; set; }
        public string Title { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public int EmailPromotion { get; set; }
        public virtual List<PersonPhone> PersonPhones { get; set; }
        public virtual List<EmailAddresses> EmailAddresses { get; set; }
    }
}
