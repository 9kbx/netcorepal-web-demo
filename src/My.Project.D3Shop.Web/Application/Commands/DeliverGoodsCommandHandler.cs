using My.Project.D3Shop.Domain.AggregatesModel.DeliverAggregate;
using My.Project.D3Shop.Infrastructure.Repositories;
using NetCorePal.Extensions.Primitives;

namespace My.Project.D3Shop.Web.Application.Commands
{
    public class DeliverGoodsCommandHandler(IDeliverRecordRepository deliverRecordRepository) : ICommandHandler<DeliverGoodsCommand, DeliverRecordId>
    {
        public Task<DeliverRecordId> Handle(DeliverGoodsCommand request, CancellationToken cancellationToken)
        {
            var record = new DeliverRecord(request.OrderId);
            deliverRecordRepository.Add(record);
            return Task.FromResult(record.Id);
        }
    }
}
