using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using CA.Application.Interfaces;
using CA.Application.ViewModels;
using CA.Domain.Entities;
using CA.Domain.Interfaces;

namespace CA.Application.Services
{
    public class ProductService: IProductService
    {
        private IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IProductRepository productRepository, IMapper mapper)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductViewModel>> GetProducts()
        {
            var result = await _productRepository.GetProducts();
            return _mapper.Map<IEnumerable<ProductViewModel>>(result);
        }

        public async Task<ProductViewModel> GetById(int? id)
        {
            var result = await _productRepository.GetById(id);
            return _mapper.Map<ProductViewModel>(result);
        }

        public void Add(ProductViewModel product)
        {
            var mapProduct = _mapper.Map<Product>(product);
            _productRepository.Add(mapProduct);
        }

        public void Update(ProductViewModel product)
        {
            var mapProduct = _mapper.Map<Product>(product);
            _productRepository.Update(mapProduct);
        }

        public void Remove(int? id)
        {
            var products = _productRepository.GetById(id).Result;
            _productRepository.Remove(products);
        }
    }
}