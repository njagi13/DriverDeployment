using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriverDeployment.Repositories
{
    interface IBaseRepository<T> where T : class
    {
        Guid Save(T entity);

        void SetInactive(T entity);
        void SetActive(T entity);
        void SetAsDeleted(T entity);

        T GetById(Guid id, bool includeDeactivated = false);

        DateTime GetLastTimeItemUpdated();
        int GetCount(bool includeDeactivated = false);
        IPagenatedList<T> GetAll(int currentPage, int itemPerPage, string searchText, bool includeDeactivated = false);
    }
}
