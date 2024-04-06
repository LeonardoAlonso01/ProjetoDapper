using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using ProjetoDapper.Core.Entities;
using ProjetoDapper.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDapper.Infrastructure.Persistence.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly string? _connectionString;

        public ProductRepository(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("cs");
        }

        public async Task AddProductAsync(Product product)
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                try
                {
                    await sqlConnection.OpenAsync();
                    var script = "INSERT INTO PRODUTO (Description, Price, CodeBar, Stock) VALUES (@description, @price, @codebar, @stock)";
                    await sqlConnection.ExecuteAsync(script, new { description = product.Description, price = product.Price, codebar = product.CodeBar, stock = product.Stock });
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    await sqlConnection.CloseAsync();
                }

            }
        }

        public async Task<List<Product>> GetAllAsync()
        {
            using (var sqlConnection = new SqlConnection(_connectionString))
            {
                
                try
                {
                    await sqlConnection.OpenAsync();
                    var script = "SELECT Id, Description, Price, CodeBar, Stock FROM PRODUTO";
                    var products = await sqlConnection.QueryAsync<Product>(script);
                    return products.ToList();
                }
                catch (Exception ex)
                {
                    throw new Exception(ex.Message);
                }
                finally
                {
                    await sqlConnection.CloseAsync();
                }

            }
        }
    }
}
