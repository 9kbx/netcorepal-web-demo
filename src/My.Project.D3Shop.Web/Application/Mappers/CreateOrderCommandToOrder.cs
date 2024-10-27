using My.Project.D3Shop.Domain.AggregatesModel.OrderAggregate;
using My.Project.D3Shop.Web.Application.Commands;
using NetCorePal.Extensions.Mappers;

namespace My.Project.D3Shop.Web.Application.Mappers
{
    public class CreateOrderCommandToOrder : IMapper<CreateOrderCommand, Order>
    {
        public Order To(CreateOrderCommand from)
        {
            return new Order(from.Name, from.Count);
        }
    }
}
