using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AddressBookMVC.Models
{
    public class Category
    {
        public int Id { get; set; }

        public string UserId { get; set; }

        [Required]
        [Display(Name = "Category Name")]
        [StringLength(50)]
        public string Name { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; } = new HashSet<Contact>();

    }
}
