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
        public List<TblCustomer> GetAll()
        {
            return this.dataContext.TblCustomers.ToList();
        }
    }
}
