using ProjectTracking.DataAcess.Data;
using ProjectTracking.Entities;

namespace ProjectTracking.DataAcess.Repository
{
    public class EFProjectRepository : IProjectRepository
    {
        private readonly TrackerDbContext dbContext;

        public EFProjectRepository(TrackerDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IList<Project> GetEntities()
        {
            return dbContext.Projects.ToList();
        }

        public IList<Project> GetProjectsByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
