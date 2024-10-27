using My.Project.D3Shop.Domain.DomainEvents;
using My.Project.D3Shop.Web.Application.Commands;
using MediatR;
using NetCorePal.Extensions.Domain;

namespace My.Project.D3Shop.Web.Application.DomainEventHandlers
{
    internal class OrderCreatedDomainEventHandler(IMediator mediator) : IDomainEventHandler<OrderCreatedDomainEvent>
    {
        public Task Handle(OrderCreatedDomainEvent notification, CancellationToken cancellationToken)
        {
            return mediator.Send(new DeliverGoodsCommand(notification.Order.Id), cancellationToken);
        }
    }
}