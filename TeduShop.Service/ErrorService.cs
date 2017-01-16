using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Models;

namespace TeduShop.Service
{
    public interface IErrorService
    {
        Error Create(Error error);

        void SaveChanges();
    }

    public class ErrorService : IErrorService
    {
        private IErrorRepository _errorRepository;
        private IUnitOfWork _unitofwork;

        public ErrorService(IErrorRepository errorRepository, IUnitOfWork unitofwork)
        {
            this._errorRepository = errorRepository;
            this._unitofwork = unitofwork;
        }

        public Error Create(Error error)
        {
            return _errorRepository.Add(error);
        }

        public void SaveChanges()
        {
            _unitofwork.Commit();
        }
    }
}