using CommonOps;
using SplitCost.Models;

namespace SplitCost.Services
{
    public interface IExpenseServices
    {
        Task<StandardResponse<dynamic>> AddExpense(AddExpenseRequest expense);
        Task<StandardResponse<dynamic>> GetIndividualExpensesFromGroup(int groupId);
        Task<StandardResponse<dynamic>> GetTotalGroupExpenses(int groupId);
        Task<StandardResponse<dynamic>> GetUserExpenseDetails(int userId);

    }
}
