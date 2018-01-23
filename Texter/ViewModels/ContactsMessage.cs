using System.Collections.Generic;
using Texter.Models;

namespace Texter.ViewModels
{
    public class ContactsMessage
    {
        public Message Message { get; set; }
        public IEnumerable<Contact> Contacts { get; set; }

        public ContactsMessage()
        {
            Message = new Message();
        }
    }
}
