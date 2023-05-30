﻿namespace ProjectTracking.Entities
{
    public class TaskInProject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime ExpectedDate { get; set; }
        public int? ProjectId { get; set; }
        public bool IsDone { get; set; }

    }
}