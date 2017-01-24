using System.Threading.Tasks;
using Abp.Application.Services;
using Jh.MooShu.Roles.Dto;

namespace Jh.MooShu.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
