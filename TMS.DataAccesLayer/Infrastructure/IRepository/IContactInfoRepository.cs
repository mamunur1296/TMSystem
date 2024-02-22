using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Models;

namespace TMS.DataAccesLayer.Infrastructure.IRepository
{
    public interface IContactInfoRepository : IGRepository<ContactInfo>
    {
        void Update(ContactInfo contactInfo);
    }
}
