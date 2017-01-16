using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Models;

namespace TeduShop.Service
{
    public interface ISupportOnlineService
    {
        void Add(SupportOnline supportOnline);
        void Update(SupportOnline supportOnline);
        void Delete(int id);
        SupportOnline GetById(int id);
        IEnumerable<SupportOnline> GetAll();
        IEnumerable<SupportOnline> GetAllPaging(int page, int pagesize, out int totalRow);
        void SaveChanges();
    }
    public class SupportOnlineService : ISupportOnlineService
    {
        ISupportOnlineRepository _supportOnlineRepository;
        IUnitOfWork _unitofwork;
        public SupportOnlineService(ISupportOnlineRepository supportOnlineRepository, IUnitOfWork unitofwork)
        {
            this._supportOnlineRepository = supportOnlineRepository;
            this._unitofwork = unitofwork;
        }
        public void Add(SupportOnline supportOnline)
        {
            _supportOnlineRepository.Add(supportOnline);
        }

        public void Delete(int id)
        {
            _supportOnlineRepository.Delete(id);
        }

        public IEnumerable<SupportOnline> GetAll()
        {
            return _supportOnlineRepository.GetAll();
        }

        public IEnumerable<SupportOnline> GetAllPaging(int page, int pagesize, out int totalRow)
        {
            return _supportOnlineRepository.GetMultiPaging(x => x.Status, out totalRow, page, pagesize);
        }

        public SupportOnline GetById(int id)
        {
            return _supportOnlineRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitofwork.Commit();
        }

        public void Update(SupportOnline supportOnline)
        {
            _supportOnlineRepository.Update(supportOnline);
        }
    }
}
