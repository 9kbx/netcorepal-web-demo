using My.Project.D3Shop.Domain.AggregatesModel.OrderAggregate;

namespace My.Project.D3Shop.Web.Application.IntegrationEventHandlers
{
    public record OrderPaidIntegrationEvent(OrderId OrderId);
}
