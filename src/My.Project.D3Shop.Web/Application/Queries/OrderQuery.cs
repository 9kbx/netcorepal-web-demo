using My.Project.D3Shop.Domain;
using My.Project.D3Shop.Domain.AggregatesModel.OrderAggregate;
using My.Project.D3Shop.Infrastructure;
using System.Threading;

namespace My.Project.D3Shop.Web.Application.Queries
{
    public class OrderQuery(ApplicationDbContext applicationDbContext)
    {
        public async Task<Order?> QueryOrder(OrderId orderId, CancellationToken cancellationToken)
        {
            return await applicationDbContext.Orders.FindAsync(new object[] { orderId }, cancellationToken);
        }
    }
}
