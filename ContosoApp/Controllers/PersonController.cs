using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ContosoApp.Models;
using ContosoApp.ViewModels;

namespace ContosoApp.Controllers
{
    [Route("api/Person")]
    public class PersonController : Controller
    {
        public ContosoDbContext ContosoDbContext { get; }

        public PersonController(ContosoDbContext contosoDbContext)
        {
            ContosoDbContext = contosoDbContext;
        }        
        [HttpGet]
        public IActionResult Get()
        {
            var result = ContosoDbContext.Persons.Take(10).Select(x => new PersonInformation()
            {
                BusinessEntityId = x.BusinessEntityID,
                FullName = $"{x.FirstName} {x.MiddleName} {x.LastName}",
                Email = x.EmailAddresses.Any()?string.Join(" / ",x.EmailAddresses.Select(e=>e.EmailAddress)):string.Empty,
                PhoneNumber = x.PersonPhones.Any()?string.Join(" or ",x.PersonPhones.Select(p=>p.PhoneNumber)):string.Empty
            });
            return Json(result);
        }       

        
    }
}
