using My.Project.D3Shop.Domain.AggregatesModel.OrderAggregate;
using NetCorePal.Extensions.Domain;

namespace My.Project.D3Shop.Domain.DomainEvents;

public record OrderPaidDomainEvent(Order Order) : IDomainEvent;