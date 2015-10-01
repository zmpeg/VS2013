using CRMService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CRMService.Controllers
{
    public class ContactsController : ApiController
    {
        Contact[] contacts = new Contact[]
        {
            new Contact { Id = 1, FirstName = "Ken", LastName = "Anderson" },
            new Contact { Id = 2, FirstName = "Trish", LastName = "Anderson" }
        };

        public IEnumerable<Contact> GetAllContacts()
        {
            return contacts;
        }

        public IHttpActionResult GetContact(int id)
        {
            var contact = contacts.FirstOrDefault((p) => p.Id == id);
            if(contact == null)
            {
                return NotFound();
            }
            return Ok(contact);
        }
    }
}
