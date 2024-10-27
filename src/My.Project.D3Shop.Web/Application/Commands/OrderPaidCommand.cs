using NetCorePal.Extensions.Primitives;

namespace My.Project.D3Shop.Web.Application.Commands
{
    public record class OrderPaidCommand(long OrderId) : ICommand;
}
