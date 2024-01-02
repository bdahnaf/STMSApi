using STMSApi.Repos.Models;

namespace STMSApi.Service
{
    public interface ICustomerService
    {
        List<TblCustomer> GetAll();
    }
}
