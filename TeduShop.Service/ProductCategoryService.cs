using System;
using System.Collections.Generic;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Models;

namespace TeduShop.Service
{
    public interface IProductCategoryService
    {
        void Add(ProductCategory productCategory);

        void Update(ProductCategory productCategory);

        ProductCategory Delete(int id);

        ProductCategory GetById(int id);

        IEnumerable<ProductCategory> GetAll();

        IEnumerable<ProductCategory> GetAll(string keyword);

        IEnumerable<ProductCategory> GetAllPaging(int page, int pagesize, out int totalRow);

        void SaveChanges();
    }

    public class ProductCategoryService : IProductCategoryService
    {
        private IProductCategoryRepository _productCategoryRepository;
        private IUnitOfWork _unitofwork;

        public ProductCategoryService(IProductCategoryRepository productCategoryRepository, IUnitOfWork unitofwork)
        {
            this._productCategoryRepository = productCategoryRepository;
            this._unitofwork = unitofwork;
        }

        public void Add(ProductCategory productCategories)
        {
            _productCategoryRepository.Add(productCategories);
        }

        public ProductCategory Delete(int id)
        {
           return _productCategoryRepository.Delete(id);
        }

        public IEnumerable<ProductCategory> GetAll()
        {
            return _productCategoryRepository.GetAll();
        }

        public IEnumerable<ProductCategory> GetAll(string keyword)
        {
            if (!string.IsNullOrEmpty(keyword))
                return _productCategoryRepository.GetMulti(x => x.Title.Contains(keyword) || x.Summary.Contains(keyword));
            else
                return _productCategoryRepository.GetAll();
        }

        public IEnumerable<ProductCategory> GetAllPaging(int page, int pagesize, out int totalRow)
        {
            return _productCategoryRepository.GetMultiPaging(x => x.Status, out totalRow, page, pagesize);
        }

        public ProductCategory GetById(int id)
        {
            return _productCategoryRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitofwork.Commit();
        }

        public void Update(ProductCategory productCategory)
        {
            _productCategoryRepository.Update(productCategory);
        }
    }
}