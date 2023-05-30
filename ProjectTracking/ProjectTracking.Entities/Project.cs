namespace ProjectTracking.Entities
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public DateTime? StartedDate { get; set; }
        public double CompletePercent { get; set; }
        public int? DepartmentId { get; set; }
        public Department? Department { get; set; }
        public ICollection<TaskInProject>? Tasks { get; set; }

    }
}
