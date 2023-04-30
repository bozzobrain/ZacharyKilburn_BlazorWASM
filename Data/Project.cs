using ZacharyKilburn_BlazorWASM.Pages;

namespace ZacharyKilburn_BlazorWASM.Data
{
    public class Project
    {
        public string ProjectTitle { get; set; } = string.Empty;
        public string ProjectDescription { get; set; } = string.Empty;
        public string ProjectHref { get; set; } = string.Empty;
       
    }
    public class ProjectLoader
	{
		public List<Project> projects { get; set; } = new();
		public void LoadProjects()
        {
            if (projects.Count == 0)
            {
                Project p = new Project();
                p.ProjectTitle = "Scoreboard";
                p.ProjectHref = "Scoreboard";
                p.ProjectDescription = "A custom scoreboard with bluetooth and manual score entry featuring an Android application, custom PCB designs and lots of 3D printing";
                projects.Add(p);
            }
        }
        public Project? GetProjectByHref(string href)
        {
            return projects.Where(p=> p.ProjectHref == href).FirstOrDefault();
        }
    }
}
