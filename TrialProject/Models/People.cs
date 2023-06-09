namespace TrialProject.Models
{
    public class People
    {
        public Guid id { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string otchestvo { get; set; }

        /*public People(string name, string lastName, string otchestvo)
        {
            this.name = name;
            this.lastName = lastName;
            this.otchestvo = otchestvo;
        }*/
    }
}
