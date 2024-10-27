﻿using My.Project.D3Shop.Infrastructure.Repositories;
using NetCorePal.Extensions.Primitives;

namespace My.Project.D3Shop.Web.Application.Commands
{
    public class OrderPaidCommandHandler(IOrderRepository orderRepository) : ICommandHandler<OrderPaidCommand>
    {
        public async Task Handle(OrderPaidCommand request, CancellationToken cancellationToken)
        {
            var order = await orderRepository.GetAsync(request.OrderId, cancellationToken) ?? throw new KnownException($"未找到订单，OrderId = {request.OrderId}");
            order.OrderPaid();
        }
    }
}