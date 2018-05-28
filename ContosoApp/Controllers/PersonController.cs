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
            var result = ContosoDbContext.Persons.Select(x => new PersonInformation()
            {
                BusinessEntityId = x.BusinessEntityID,
                FullName = $"{x.FirstName} {x.MiddleName} {x.LastName}"
            });
            return Json(result);
        }
        

        
    }
}
