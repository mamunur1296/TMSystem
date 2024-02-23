using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Models.ViewModels
{
    public class ContactViewModel
    {
        public ContactInfo Contact { get; set; } = new ContactInfo();
        public IEnumerable<ContactInfo> Contacts { get; set; } = new List<ContactInfo>();
    }
}
