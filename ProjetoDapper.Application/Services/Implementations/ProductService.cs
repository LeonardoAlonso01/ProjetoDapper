using ProjetoDapper.Application.Services.Interfaces;
using ProjetoDapper.Core.Entities;
using ProjetoDapper.Core.Repositories;


namespace ProjetoDapper.Application.Services.Implementations
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }


        public async Task AddProctuct(Product product)
        {
            try
            {
                await _productRepository.AddProductAsync(product);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            
        }

        public async Task<List<Product>> GetAll()
        {
            try
            {
                return await _productRepository.GetAllAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
