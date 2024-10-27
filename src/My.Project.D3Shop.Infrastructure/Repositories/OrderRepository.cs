using NetCorePal.Extensions.Repository.EntityFrameworkCore;
using My.Project.D3Shop.Domain.AggregatesModel.OrderAggregate;
using NetCorePal.Extensions.Repository;

namespace My.Project.D3Shop.Infrastructure.Repositories
{

    public interface IOrderRepository : IRepository<Order, OrderId>
    {

    }


    public class OrderRepository(ApplicationDbContext context) : RepositoryBase<Order, OrderId, ApplicationDbContext>(context), IOrderRepository
    {
    }
}
