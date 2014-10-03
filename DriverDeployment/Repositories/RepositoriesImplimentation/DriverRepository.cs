using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using DriverDeployment.Model;
using log4net;

namespace DriverDeployment.Repositories.RepositoriesImplimentation
{
    public enum EntityStatus { Active = 0, New = 1, Inactive = 2, Deleted = 3 }

   public class DriverRepository : IBaseRepository<Driver> , IDriverRepository
   {
       protected static readonly ILog _log = log4net.LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
       private DriverDatabaseContext _ctx;


       public DriverRepository(DriverDatabaseContext ctx)
       {
           _ctx = ctx;
       }


        public IEnumerable<Model.Driver> GetAll(bool includeDeactivated = false)
        {
            _log.Debug("Get all Drivers");
            IQueryable<Driver> allDrivers = _ctx.Drivers.Where(s => s.Id != null);
            return allDrivers;
        }
        public Guid Save(Model.Driver entity)
        {
            throw new NotImplementedException();
        }

        public void SetInactive(Driver entity)
        {
           Driver selectedDriver = _ctx.Drivers.FirstOrDefault(s => s.Id == entity.Id);

            if (selectedDriver != null)
            {
                entity.Status = (int) EntityStatus.Active;

            }

        }

        public void SetActive(Model.Driver entity)
        {
            throw new NotImplementedException();
        }

        public void SetAsDeleted(Model.Driver entity)
        {
            throw new NotImplementedException();
        }

        public Model.Driver GetById(Guid id, bool includeDeactivated = false)
        {
            throw new NotImplementedException();
        }

        public DateTime GetLastTimeItemUpdated()
        {
            throw new NotImplementedException();
        }

        public int GetCount(bool includeDeactivated = false)
        {
            throw new NotImplementedException();
        }

        public IPagenatedList<Model.Driver> GetAll(int currentPage, int itemPerPage, string searchText, bool includeDeactivated = false)
        {
            throw new NotImplementedException();
        }

       
    }
}
