using OrgOffering.Data;
using OrgOffering.Models;
using System.Linq;

namespace OrgOffering.Repository
{
    public class ServiceRepository : GenericRepository<Service>,
IServiceRepository
    {
        public ServiceRepository(CMPG323Context context) : base(context)
        {
        }
        public Service GetMostRecentService()
        {
            return _context.Service.OrderByDescending(service =>
           service.CreatedDate).FirstOrDefault();
        }
    }
}
