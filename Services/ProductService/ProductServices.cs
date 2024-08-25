using AutoMapper;
using backend.Models;
using backend.Models.Dtos;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace backend.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        private readonly ApplicationDbContext _context;

        public ProductService(IMapper mapper, ApplicationDbContext context)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<GetProducts> GetProductsAsync()
        {
            var dbProducts = await _context.Products.ToListAsync();
            var mappedProducts = _mapper.Map<List<GetProduct>>(dbProducts);

            var response = new GetProducts
            {
                Products = mappedProducts
            };

            return response;
        }

        public async Task<GetProduct> GetProductAsync(long productId)
        {
            var dbProduct = await _context.Products.FindAsync(productId);
            return _mapper.Map<GetProduct>(dbProduct);
        }
    }
}
