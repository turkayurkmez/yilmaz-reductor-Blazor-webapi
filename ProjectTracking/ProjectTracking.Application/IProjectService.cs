using ProjectTracking.Application.DataTransferObjects.Responses;

namespace ProjectTracking.Application
{
    public interface IProjectService
    {
        IList<ProjectListResponse> GetProjects();
    }
}
