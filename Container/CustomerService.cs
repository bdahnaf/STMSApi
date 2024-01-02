using Microsoft.EntityFrameworkCore;
using STMSApi.Helper;
using STMSApi.Repos;
using STMSApi.Repos.Models;
using STMSApi.Service;

namespace STMSApi.Container
{
    public class CustomerService : ICustomerService
    {
        private readonly LearnDataContext dataContext;

        public CustomerService(LearnDataContext dataContext)
        {
            this.dataContext = dataContext;
        }

        public Task<ApiResponse> Create(TblCustomer customer)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TblCustomer>> GetAll()
        {
            return await this.dataContext.TblCustomers.ToListAsync();
        }

        public Task<TblCustomer> GetByCode(string code)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> Remove(string code)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponse> Update(TblCustomer customer, string code)
        {
            throw new NotImplementedException();
        }
    }
}
