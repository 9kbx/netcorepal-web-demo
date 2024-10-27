using My.Project.D3Shop.Domain.AggregatesModel.OrderAggregate;
using NetCorePal.Extensions.Primitives;

namespace My.Project.D3Shop.Web.Application.Commands
{
    public record CreateOrderCommand(string Name, int Price, int Count) : ICommand<OrderId>;
}
