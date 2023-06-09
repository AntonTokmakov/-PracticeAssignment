namespace TrialProject.Models;

public class Project
    // данные в модели хранить уже в string или в int например статус
    // патерн обновлятор использовать в модялях можно или это уже в логике
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int IdTS { get; set; }
    public string ShortName { get; set; }
    public string Status { get; set; }
    public int[] Progress { get; set; }
    public int[] Risks { get; set; }
    public Student[] Student { get; set; }
}
