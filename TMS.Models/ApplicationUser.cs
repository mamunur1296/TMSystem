using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string ? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? ProfilePick { get; set; }
        public string? Dagiknation { get; set; }
        public string? Company { get; set; }
        public string? Country { get; set; }
        public string? Address { get; set; }
        public string? About { get; set; }
        public string? Twitter { get; set; }
        public string? Facebook { get; set; }
        public string? Instagram { get; set; }
        public string? Linkedin { get; set; }
    }
}
