using System.Collections.Generic;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Models;

namespace TeduShop.Service
{
    public interface IOrderService
    {
        void Add(Order orders);

        void Update(Order orders);

        void Delete(int id);

        IEnumerable<Order> GetAll();

        IEnumerable<Order> GetAllPaging(int page, int pagesize, out int totalRow);

        Order GetById(int id);

        void SaveChanges();
    }

    public class OrderService : IOrderService
    {
        private IOrderRepository _orderRepository;
        private IUnitOfWork _unitofwork;

        public OrderService(IOrderRepository orderRepository, IUnitOfWork unitofwork)
        {
            this._orderRepository = orderRepository;
            this._unitofwork = unitofwork;
        }

        public void Add(Order orders)
        {
            _orderRepository.Add(orders);
        }

        public void Delete(int id)
        {
            _orderRepository.Delete(id);
        }

        public IEnumerable<Order> GetAll()
        {
            return _orderRepository.GetAll();
        }

        public IEnumerable<Order> GetAllPaging(int page, int pagesize, out int totalRow)
        {
            return _orderRepository.GetMultiPaging(x => x.Status, out totalRow, page, pagesize);
        }

        public Order GetById(int id)
        {
            return _orderRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitofwork.Commit();
        }

        public void Update(Order orders)
        {
            _orderRepository.Update(orders);
        }
    }
}