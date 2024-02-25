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
       
    }
}
