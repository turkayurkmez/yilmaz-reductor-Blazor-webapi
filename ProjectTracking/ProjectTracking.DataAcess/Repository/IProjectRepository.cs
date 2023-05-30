using ProjectTracking.Entities;

namespace ProjectTracking.DataAcess.Repository
{
    public interface IProjectRepository : IRepository<Project>
    {
        IList<Project> GetProjectsByName(string name);
    }
}
