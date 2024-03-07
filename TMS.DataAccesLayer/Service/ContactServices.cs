using Microsoft.AspNetCore.Mvc;
using TMS.DataAccesLayer.Infrastructure.IRepository;
using TMS.Models;
using TMS.Models.ViewModels;

namespace TMS.DataAccesLayer.Service
{
    public class ContactServices : IServices<ContactInfo>
    {
        private readonly IUnitOfWork _unitOfWork;

        public ContactServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void Create(ContactInfo model)
        {
            _unitOfWork.ContactInfoRepo.Add(model);
            _unitOfWork.Save();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ContactInfo> GetAll()
        {
            var data = _unitOfWork.ContactInfoRepo.GetAll();
            return data;
        }

        public Task<IActionResult> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IActionResult> Update(ContactInfo model, int id)
        {
            throw new NotImplementedException();
        }
    }
}
