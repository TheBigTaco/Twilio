using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Texter.Models
{
	[Table("contacts")]
    public class Contact
    {
        [Key]
        public string Name { get; set; }
        public string Number { get; set; }

        public Contact()
        {

        }
    }
}
