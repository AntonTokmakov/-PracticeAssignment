using Microsoft.EntityFrameworkCore;
using TrialProject.Models;
using TrialProject;

namespace TrialProject.Controllers.Repositories
{
    public class ProjectContext : DbContext
    {
        //public ProjectContext(DbContextOptions<ProjectContext> options) : base(options) { }

        public DbSet<Project> Projects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=ProjectManagement;User Id=postgres;Password=56001;");
        }

        internal void Remote(int id)
        {
            throw new NotImplementedException();
        }
    }
}
