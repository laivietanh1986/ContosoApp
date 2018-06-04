using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ContosoApp.Models;
using ContosoApp.ViewModels;
using ContosoApp.Helper;
using ContosoApp.Common;
using Microsoft.EntityFrameworkCore;

namespace ContosoApp.Controllers
{
 
    public class PersonController : Controller
    {
        public ContosoDbContext ContosoDbContext { get; }

        public PersonController(ContosoDbContext contosoDbContext)
        {
            ContosoDbContext = contosoDbContext;
        }
        [Route("api/Person/")]
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
        [HttpGet]
        [Route("api/Person/{id}")]
        public IActionResult Get(int id)
        {
            var person = ContosoDbContext.Persons
               .Include(x=>x.EmailAddresses)
               .Include(x=>x.PersonPhones)
                .FirstOrDefault(x=>x.BusinessEntityID == id);
            var result = new PersonInformationDetail
            {
                BusinessEntityId = person.BusinessEntityID,
                FullName = $"{person.FirstName} {person.MiddleName} {person.LastName}",
                Email = person.EmailAddresses.Any() ? string.Join(" / ", person.EmailAddresses.Select(e => e.EmailAddress)) : string.Empty,
                PhoneNumber = person.PersonPhones.Any() ? string.Join(" or ", person.PersonPhones.Select(p => p.PhoneNumber)) : string.Empty,
                PersonType = EnumHelper.GetDescription<PersonType>((PersonType)Enum.Parse(typeof(PersonType), person.PersonType)),
                NameStyle = person.NameStyle?EnumHelper.GetDescription<NameStyle>(NameStyle.ES): EnumHelper.GetDescription<NameStyle>(NameStyle.WS),
                emailPromotion = EnumHelper.GetDescription<EmailPromotion>((EmailPromotion)person.EmailPromotion),
            };          
            
            return Json(result);
        }


    }
}
