using System;
using System.Collections.Generic;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Models;

namespace TeduShop.Service
{
    public interface INewsCategoryService
    {
        NewsCategory Add(NewsCategory newsCategory);

        void Update(NewsCategory newsCategory);

        NewsCategory Delete(int id);

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

        public NewsCategory Add(NewsCategory newsCategory)
        {
            return _newsCategoryRepository.Add(newsCategory);
        }

        public NewsCategory Delete(int id)
        {
            return _newsCategoryRepository.Delete(id);
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

        public void Update(NewsCategory newsCategory)
        {
            _newsCategoryRepository.Update(newsCategory);
        }
    }
}