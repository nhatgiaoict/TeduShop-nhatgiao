using System;
using System.Collections.Generic;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Models;

namespace TeduShop.Service
{
    public interface INewsCategoryService
    {
        void Add(NewsCategory newsCategories);

        void Update(NewsCategory newsCategories);

        void Delete(int id);

        NewsCategory GetById(int id);

        IEnumerable<NewsCategory> GetAll();

        IEnumerable<NewsCategory> GetAllByParentId(int parentId);

        void SaveChange();
    }

    public class NewsCategoryService : INewsCategoryService
    {
        private INewsCategoryRepository _newsCategoryRepository;
        private IUnitOfWork _unitofwork;

        public NewsCategoryService(INewsCategoryRepository newsCategoryRepository, IUnitOfWork unitofwork)
        {
            this._newsCategoryRepository = newsCategoryRepository;
            this._unitofwork = unitofwork;
        }

        public void Add(NewsCategory newsCategories)
        {
            _newsCategoryRepository.Add(newsCategories);
        }

        public void Delete(int id)
        {
            _newsCategoryRepository.Delete(id);
        }

        public IEnumerable<NewsCategory> GetAll()
        {
            return _newsCategoryRepository.GetAll();
        }

        public IEnumerable<NewsCategory> GetAllByParentId(int parentId)
        {
            return _newsCategoryRepository.GetMulti(x => x.Status && x.ParentID == parentId);
        }

        public NewsCategory GetById(int id)
        {
            return _newsCategoryRepository.GetSingleById(id);
        }

        public void SaveChange()
        {
            _unitofwork.Commit();
        }

        public void Update(NewsCategory newsCategories)
        {
            _newsCategoryRepository.Update(newsCategories);
        }
    }
}