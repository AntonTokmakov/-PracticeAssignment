namespace TrialProject.Controller.Controllers
{
    public interface IProjectController
    {
        void AddProject(ProjectDto projectDto);
        void UpdateProject(ProjectDto projectDto);
        ProjectDto GetProjectById(int id);
        IEnumerable<ProjectDto> GetAllProjects();
        void DeleteProject(int id);
    }
}
