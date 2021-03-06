using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Hippo.Models;

namespace Hippo.Repositories
{
    public interface IApplicationRepository
    {
        IEnumerable<Application> ListApplications();
        IEnumerable<Application> ListApplicationsForAllUsers();
        IEnumerable<Application> ListApplicationsByStorageId(string storageId);
        Application GetApplicationById(Guid id);
        bool ApplicationExistsById(Guid id);
        Task AddNew(Application application);
        void Update(Application application);
        void DeleteApplicationById(Guid id);
    }
}
