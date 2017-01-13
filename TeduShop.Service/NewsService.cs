using System.Collections.Generic;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Models;

namespace TeduShop.Service
{
    public interface INewsService
    {
        void Add(News News);

        void Update(News news);

        void delete(int id);

        News GetById(int id);

        IEnumerable<News> GetAll();

        IEnumerable<News> GetAllPaging(int page, int pagesize, out int totalRow);

        IEnumerable<News> GetAllByCategoryPaging(int CategoryID, int page, int pagesize, out int totalRow);

        IEnumerable<News> GetAllByTagPaging(string tag, int page, int pagesize, out int totalRow);

        void SaveChanges();
    }

    public class NewsService : INewsService
    {
        private INewsRepository _newsRepository;
        private IUnitOfWork _unitofwork;

        public NewsService(INewsRepository newsRepository, IUnitOfWork unitofwork)
        {
            this._newsRepository = newsRepository;
            this._unitofwork = unitofwork;
        }

        public void Add(News news)
        {
            _newsRepository.Add(news);
        }

        public void delete(int id)
        {
            _newsRepository.Delete(id);
        }

        public IEnumerable<News> GetAll()
        {
            return _newsRepository.GetAll(new string[] { "NewsCategories" });
        }

        public IEnumerable<News> GetAllByCategoryPaging(int CategoryID, int page, int pagesize, out int totalRow)
        {
            return _newsRepository.GetMultiPaging(x => x.Status && x.CategoryID == CategoryID, out totalRow, page, pagesize, new string[] { "NewsCategories" });
        }

        public IEnumerable<News> GetAllByTagPaging(string tag, int page, int pagesize, out int totalRow)
        {
            //TODO: Select all News by tag
            return _newsRepository.GetAllByTag(tag, page, pagesize, out totalRow);
        }

        public IEnumerable<News> GetAllPaging(int page, int pagesize, out int totalRow)
        {
            return _newsRepository.GetMultiPaging(x => x.Status, out totalRow, page, pagesize);
        }

        public News GetById(int id)
        {
            return _newsRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitofwork.Commit();
        }

        public void Update(News news)
        {
            _newsRepository.Update(news);
        }
    }
}