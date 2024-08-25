using backend.Models.Dtos;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace backend.Services.ProductService
{
    public interface IProductService
    {
        Task<GetProducts> GetProductsAsync();
        Task<GetProduct> GetProductAsync(long productId);
    }
}
