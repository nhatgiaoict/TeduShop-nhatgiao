using System.Collections.Generic;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Models;

namespace TeduShop.Service
{
    public interface IProductCategoriesService
    {
        void Add(ProductCategories productCategories);

        void Update(ProductCategories productCategories);

        void Delete(int id);

        ProductCategories GetById(int id);

        IEnumerable<ProductCategories> GetAll();

        IEnumerable<ProductCategories> GetAllPaging(int page, int pagesize, out int totalRow);

        void SaveChanges();
    }

    public class ProductCategoriesService : IProductCategoriesService
    {
        private IProductCategoriesRepository _productCategoriesRepository;
        private IUnitOfWork _unitofwork;

        public ProductCategoriesService(IProductCategoriesRepository productCategoriesRepository, IUnitOfWork unitofwork)
        {
            this._productCategoriesRepository = productCategoriesRepository;
            this._unitofwork = unitofwork;
        }

        public void Add(ProductCategories productCategories)
        {
            _productCategoriesRepository.Add(productCategories);
        }

        public void Delete(int id)
        {
            _productCategoriesRepository.Delete(id);
        }

        public IEnumerable<ProductCategories> GetAll()
        {
            return _productCategoriesRepository.GetAll();
        }

        public IEnumerable<ProductCategories> GetAllPaging(int page, int pagesize, out int totalRow)
        {
            return _productCategoriesRepository.GetMultiPaging(x => x.Status, out totalRow, page, pagesize);
        }

        public ProductCategories GetById(int id)
        {
            return _productCategoriesRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitofwork.Commit();
        }

        public void Update(ProductCategories productCategories)
        {
            _productCategoriesRepository.Update(productCategories);
        }
    }
}