using MessagePack;
using Microsoft.EntityFrameworkCore;

namespace Tasks.Models;

[PrimaryKey("id_project")]
public class Project
{
    public int id_project { get; set; }
    public string project_name { get; set; }
    public int id_ts { get; set; }
    public string short_name { get; set; }
    public int id_status { get; set; }
    /*public Guid Id { get; set; }
    public string Name { get; set; }
    public int IdTS { get; set; }
    public string ShortName { get; set; }
    public string Status { get; set; }
    public int[] Progress { get; set; }
    public int[] Risks { get; set; }
    public Student[] Student { get; set; }*/
}
