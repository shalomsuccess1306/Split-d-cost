using CommonOps;
using SplitCost.Models;

namespace SplitCost.Services
{
    public interface IGroupServices
    {
        Task<StandardResponse<dynamic>> CreateGroup(GroupDTO model);
        Task<StandardResponse<dynamic>> AddMemberToGroup(GroupMemberDTO model);
        Task<StandardResponse<Groups>> GetGroupById(int groupId);
    }
}
