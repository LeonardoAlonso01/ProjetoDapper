using ProjetoDapper.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDapper.Core.Repositories
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllAsync();
        Task AddProductAsync(Product product);
    }
}
