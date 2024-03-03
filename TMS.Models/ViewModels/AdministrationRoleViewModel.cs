using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Models.ViewModels
{
    public class AdministrationRoleViewModel
    {
       
        public string Id { get; set; }
        public string  RoleName { get; set; }
        public List<string> Users { get; set; }
        public AdministrationRoleViewModel()
        {
            Users = new List<string>(); 
        }
    }
}
