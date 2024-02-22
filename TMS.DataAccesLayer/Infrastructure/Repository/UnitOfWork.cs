using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.DataAccesLayer.Data;
using TMS.DataAccesLayer.Infrastructure.IRepository;

namespace TMS.DataAccesLayer.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationDbContext _context;
        public IContactInfoRepository ContactInfoRepo { get; private set; }
        public UnitOfWork(ApplicationDbContext context)
        {
            _context = context;
            ContactInfoRepo = new ContactInfoRepository(context);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
