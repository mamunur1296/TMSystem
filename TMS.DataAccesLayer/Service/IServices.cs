using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMS.Models;

namespace TMS.DataAccesLayer.Service
{
    public interface IServices<TModel>
    {
        IEnumerable<TModel> GetAll();
        Task<IActionResult> GetById(int id);
        void Create(TModel model);
        Task<IActionResult> Update(TModel model, int id);
        void Delete(int id);
    }
}
