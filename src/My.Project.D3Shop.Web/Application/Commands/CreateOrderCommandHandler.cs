using My.Project.D3Shop.Domain.AggregatesModel.OrderAggregate;
using My.Project.D3Shop.Infrastructure.Repositories;
using My.Project.D3Shop.Web.Application.IntegrationEventHandlers;
using NetCorePal.Extensions.Mappers;
using NetCorePal.Extensions.Primitives;
using NetCorePal.Extensions.Repository;

namespace My.Project.D3Shop.Web.Application.Commands
{
    public class CreateOrderCommandHandler(IOrderRepository orderRepository, IMapperProvider mapperProvider, ILogger<OrderPaidIntegrationEventHandler> logger) : ICommandHandler<CreateOrderCommand, OrderId>
    {

        public async Task<OrderId> Handle(CreateOrderCommand request, CancellationToken cancellationToken)
        {
            var order = request.MapTo<Order>(mapperProvider);
            order = await orderRepository.AddAsync(order, cancellationToken);
            logger.LogInformation("order created, id:{orderId}", order.Id);
            return order.Id;
        }
    }
}
