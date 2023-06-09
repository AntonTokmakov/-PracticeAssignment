using TrialProject.Models;

namespace TrialProject.Controllers.Repositories
{
    public class SQLProjectRepository : IRepository<Project>
    {
        ProjectContext db;

        public SQLProjectRepository()
        {
            this.db = new ProjectContext();
        }

        public void Create(Project project)
        {
            db.Add(project);
        }

        public void Delete(int id)
        {
            Project project = db.Projects.Find(id);
            if (project == null)
               db.Remove(project);
        }

        public Project GetItem(int id)
        {
            return db.Projects.Find(id);
        }

        public IEnumerable<Project> GetItemList()
        {
            return db.Projects;
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Project project)
        {
            db.Update(project);
        }
    }
}
