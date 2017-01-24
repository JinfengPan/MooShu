using System.Threading.Tasks;
using Abp.Application.Services;
using Jh.MooShu.Sessions.Dto;

namespace Jh.MooShu.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
