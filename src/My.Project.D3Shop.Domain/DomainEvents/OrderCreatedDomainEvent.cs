using NetCorePal.Extensions.Domain;
using My.Project.D3Shop.Domain.AggregatesModel.OrderAggregate;

namespace My.Project.D3Shop.Domain.DomainEvents
{
    public record OrderCreatedDomainEvent(Order Order) : IDomainEvent;
}
