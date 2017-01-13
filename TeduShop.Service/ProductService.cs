using System.Collections.Generic;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Models;

namespace TeduShop.Service
{
    public interface IProductService
    {
        void Add(Product product);

        void Update(Product product);

        void Delete(int id);

        Product GetById(int id);

        IEnumerable<Product> GetAll();

        IEnumerable<Product> GetAllPaging(int page, int pagesize, out int totalRow);

        IEnumerable<Product> GetAllByTagPaging(string tag, int page, int pagesize, out int totalRow);

        void SaveChanges();
    }

    public class ProductService : IProductService
    {
        private IProductRepository _productRepository;
        private IUnitOfWork _unitofwork;

        public ProductService(IProductRepository productRepository, IUnitOfWork unitofwork)
        {
            this._productRepository = productRepository;
            this._unitofwork = unitofwork;
        }

        public void Add(Product product)
        {
            _productRepository.Add(product);
        }

        public void Delete(int id)
        {
            _productRepository.Delete(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return _productRepository.GetAll(new string[] { "ProductCategories" });
        }

        public IEnumerable<Product> GetAllByTagPaging(string tag, int page, int pagesize, out int totalRow)
        {
            //TODO
            return _productRepository.GetMultiPaging(x => x.Status, out totalRow, page, pagesize);
        }

        public IEnumerable<Product> GetAllPaging(int page, int pagesize, out int totalRow)
        {
            return _productRepository.GetMultiPaging(x => x.Status, out totalRow, page, pagesize);
        }

        public Product GetById(int id)
        {
            return _productRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitofwork.Commit();
        }

        public void Update(Product product)
        {
            _productRepository.Update(product);
        }
    }
}