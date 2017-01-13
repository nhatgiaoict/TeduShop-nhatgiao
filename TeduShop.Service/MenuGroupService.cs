using System.Collections.Generic;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Models;

namespace TeduShop.Service
{
    public interface IMenuGroupService
    {
        void Add(MenuGroup menuGroup);

        void Update(MenuGroup menuGroup);

        void Delete(int id);

        MenuGroup GetById(int id);

        IEnumerable<MenuGroup> GetAll();

        void SaveChanges();
    }

    public class MenuGroupService : IMenuGroupService
    {
        private IMenuGroupRepository _menuGroupRepository;
        private IUnitOfWork _unitofwork;

        public MenuGroupService(IMenuGroupRepository menuGroupRepository, IUnitOfWork unitofwork)
        {
            this._menuGroupRepository = menuGroupRepository;
            this._unitofwork = unitofwork;
        }

        public void Add(MenuGroup menuGroup)
        {
            _menuGroupRepository.Add(menuGroup);
        }

        public void Delete(int id)
        {
            _menuGroupRepository.Delete(id);
        }

        public IEnumerable<MenuGroup> GetAll()
        {
            return _menuGroupRepository.GetAll();
        }

        public MenuGroup GetById(int id)
        {
            return _menuGroupRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitofwork.Commit();
        }

        public void Update(MenuGroup menuGroup)
        {
            _menuGroupRepository.Update(menuGroup);
        }
    }
}