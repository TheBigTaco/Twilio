using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Texter.Models;
using Texter.ViewModels;

namespace Texter.Controllers
{
    public class HomeController : Controller
    {
        private readonly TexterDbContext _db;

        public HomeController(TexterDbContext db)
        {
            _db = db;    
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetMessages()
        {
            var allMessages = Message.GetMessages();
            return View(allMessages);
        }

        public IActionResult SendMessage()
        {
            ContactsMessage cm = new ContactsMessage();
            cm.Contacts = _db.Contacts.ToList();
            return View(cm);
        }

        [HttpPost]
        public IActionResult SendMessage(ContactsMessage cm)
        {
            Message newMessage = cm.Message;
            newMessage.Send();
            return RedirectToAction("Index");
        }

        public IActionResult AddContact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddContact(Contact newContact)
        {
            Console.WriteLine("##############################" + newContact.Name + "           " + newContact.Number + "###########################");
            if (newContact.Number != null)
            {
				_db.Contacts.Add(newContact);
                _db.SaveChanges();
                return RedirectToAction("Index");            
            }
            else
            {
                return View();
            }
        }
    }
}
