using NetCorePal.Extensions.Repository.EntityFrameworkCore;
using NetCorePal.Extensions.Repository;
using My.Project.D3Shop.Domain.AggregatesModel.DeliverAggregate;

namespace My.Project.D3Shop.Infrastructure.Repositories
{
    public interface IDeliverRecordRepository : IRepository<DeliverRecord, DeliverRecordId>
    {

    }

    public class DeliverRecordRepository(ApplicationDbContext context) : RepositoryBase<DeliverRecord, DeliverRecordId, ApplicationDbContext>(context), IDeliverRecordRepository
    {
    }
}
