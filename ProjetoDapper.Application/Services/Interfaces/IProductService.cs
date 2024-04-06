using ProjetoDapper.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDapper.Application.Services.Interfaces
{
    public interface IProductService
    {
        Task<List<Product>> GetAll();
        Task AddProctuct(Product product);
    }
}
