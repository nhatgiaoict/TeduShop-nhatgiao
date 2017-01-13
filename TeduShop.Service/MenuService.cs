using System.Collections.Generic;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Models;

namespace TeduShop.Service
{
    public interface IMenuService
    {
        void Add(Menu menu);

        void Update(Menu menu);

        void Delete(int id);

        Menu GetById(int id);

        IEnumerable<Menu> GetAll();

        IEnumerable<Menu> GetAllByPaging(int page, int pagesize, out int totalRow);

        void SaveChanges();
    }

    public class MenuService : IMenuService
    {
        private IMenuRepository _menuRepository;
        private IUnitOfWork _unitofwork;

        public MenuService(IMenuRepository menuRepository, IUnitOfWork unitofwork)
        {
            this._menuRepository = menuRepository;
            this._unitofwork = unitofwork;
        }

        public void Add(Menu menu)
        {
            _menuRepository.Add(menu);
        }

        public void Delete(int id)
        {
            _menuRepository.Delete(id);
        }

        public IEnumerable<Menu> GetAll()
        {
            return _menuRepository.GetAll(new string[] { "MenuGroups" });
        }

        public IEnumerable<Menu> GetAllByPaging(int page, int pagesize, out int totalRow)
        {
            return _menuRepository.GetMultiPaging(x => x.Status, out totalRow, page, pagesize);
        }

        public Menu GetById(int id)
        {
            return _menuRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitofwork.Commit();
        }

        public void Update(Menu menu)
        {
            _menuRepository.Update(menu);
        }
    }
}