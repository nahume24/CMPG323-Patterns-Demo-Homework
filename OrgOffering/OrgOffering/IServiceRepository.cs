using OrgOffering.Models;

namespace OrgOffering
{
    
    public interface IServiceRepository : IGenericRepository<Service>
    {
        Service GetMostRecentService();
    }
}
