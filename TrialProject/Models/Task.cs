using Microsoft.AspNetCore.Razor.TagHelpers;

namespace TrialProject.Models
{
    public class Task
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Complexity { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public int IdProject { get; set; }
        public string CreatStudent { get; set; }
        public int Parent { get; set; }
        public int Child { get; set; }
        public bool Visible { get; set; }
        public Student[] Students { get; set; }
    }
}
