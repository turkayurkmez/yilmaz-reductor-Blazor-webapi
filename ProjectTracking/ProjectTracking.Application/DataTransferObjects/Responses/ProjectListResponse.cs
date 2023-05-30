namespace ProjectTracking.Application.DataTransferObjects.Responses
{
    public class ProjectListResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime? StartedDate { get; set; }
        public double CompletePercent { get; set; }
        public int? DepartmentId { get; set; }
    }
}
