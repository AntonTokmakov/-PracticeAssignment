using Tasks.Models;
using TrialProject.Controller.Controllers;

namespace TrialProject.UseCase
{
    public interface IProjectService
    {
        void AddProject(Project project);
        void UpdateProject(Project project);
        Project GetProjectById(int id);
        IEnumerable<Project> GetProjects();
        void DeleteProject(int id);
    }
}
