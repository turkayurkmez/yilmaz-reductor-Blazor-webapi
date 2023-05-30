using ProjectTracking.Application.DataTransferObjects.Responses;
using ProjectTracking.DataAcess.Repository;

namespace ProjectTracking.Application
{
    public class ProjectService : IProjectService
    {
        private readonly IProjectRepository projectRepository;

        public ProjectService(IProjectRepository projectRepository)
        {
            this.projectRepository = projectRepository;
        }

        public IList<ProjectListResponse> GetProjects()
        {
            var projects = projectRepository.GetEntities();
            var response = projects.Select(pr => new ProjectListResponse
            {
                CompletePercent = pr.CompletePercent,
                DepartmentId = pr.DepartmentId,
                Description = pr.Description,
                Id = pr.Id,
                Name = pr.Name,
                StartedDate = pr.StartedDate
            }).ToList();


            return response;
        }
    }
}
