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
    public interface ISlideService
    {
        void Add(Slide slide);
        void Update(Slide slide);
        void Delete(Slide slide);
        Slide GetById(int id);
        IEnumerable<Slide> GetAll();
        IEnumerable<Slide> GetAllPaging(int page, int pageseze, out int totalRow);
    }
    public class SlideService : ISlideService
    {
        ISlideRepository _slideRepository;
        IUnitOfWork _unitofwork;
        public SlideService(ISlideRepository slideRepository, IUnitOfWork unitofwork)
        {
            this._slideRepository = slideRepository;
            this._unitofwork = unitofwork;
        }
        public void Add(Slide slide)
        {
            _slideRepository.Add(slide);
        }

        public void Delete(int id)
        {
            _slideRepository.Delete(id);
        }

        public IEnumerable<Slide> GetAll()
        {
            return _slideRepository.GetAll();
        }

        public IEnumerable<Slide> GetAllPaging(int page, int pagesize, out int totalRow)
        {
            return _slideRepository.GetMultiPaging(x => x.Status, out totalRow, page, pagesize);
        }

        public Slide GetById(int id)
        {
            return _slideRepository.GetSingleById(id);
        }

        public void Update(Slide slide)
        {
            _slideRepository.Update(slide);
        }
    }
}
