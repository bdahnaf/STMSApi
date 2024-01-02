using STMSApi.Helper;
using STMSApi.Repos.Models;

namespace STMSApi.Service
{
    public interface ICustomerService
    {
        Task<List<TblCustomer>> GetAll();
        Task<TblCustomer> GetByCode(string code);
        Task<ApiResponse> Remove(string code);
        Task<ApiResponse> Create(TblCustomer customer);
        Task<ApiResponse> Update(TblCustomer customer, string code);


    }
}
