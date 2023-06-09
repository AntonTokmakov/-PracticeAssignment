namespace TrialProject.Models
{
    public class Student : People
    {
        public Guid Id { get; set; }
        public string Teacher { get; set; }
        public int CreatingTask { get; set; }
    }
}
