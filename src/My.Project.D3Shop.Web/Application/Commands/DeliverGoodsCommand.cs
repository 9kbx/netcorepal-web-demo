﻿using My.Project.D3Shop.Domain.AggregatesModel.DeliverAggregate;
using My.Project.D3Shop.Domain.AggregatesModel.OrderAggregate;
using NetCorePal.Extensions.Primitives;

namespace My.Project.D3Shop.Web.Application.Commands
{
    public record DeliverGoodsCommand(OrderId OrderId) : ICommand<DeliverRecordId>;
}
