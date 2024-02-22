
using TMS.DataAccesLayer.Data;
using TMS.DataAccesLayer.Infrastructure.IRepository;
using TMS.Models;

namespace TMS.DataAccesLayer.Infrastructure.Repository
{
    public class ContactInfoRepository : GRepository<ContactInfo>, IContactInfoRepository
    {
        private readonly ApplicationDbContext _context;
        public ContactInfoRepository(ApplicationDbContext context) : base(context)
        {
            _context = context;
        }

        public void Update(ContactInfo contactInfo)
        {
            var data = _context.Contacts.Where(x => x.Id == contactInfo.Id).FirstOrDefault();
            if(data != null)
            {
                data.Name = contactInfo.Name;
                data.Email = contactInfo.Email;
                data.Subject = contactInfo.Subject;
                data.Message = contactInfo.Message;
            }
        }
    }
}
