using ZacharyKilburn_BlazorWASM.Pages;

namespace ZacharyKilburn_BlazorWASM.Data
{
	public class Project
	{
		public string ProjectTitle { get; set; } = string.Empty;
		public string ProjectDescription { get; set; } = string.Empty;
		public string ProjectHref { get; set; } = string.Empty;
		public string ProjectMainImage { get; set; } = string.Empty;
		public string CollapsedImage { get; set; } = string.Empty;
		public string ExplodingImage { get; set; } = string.Empty;
		public string CollapsingImage { get; set; } = string.Empty;

	}
	public class ProjectLoader
	{
		public static readonly Project ScoreboardProject = new()
		{
			ProjectTitle = "Scoreboard",
			ProjectHref = "projects/Scoreboard",
			ProjectDescription = "A custom scoreboard with bluetooth and manual score entry featuring an Android application, custom PCB designs and lots of 3D printing",
			ProjectMainImage = "Scoreboard-Iso.png",
			CollapsedImage = "ScoreboardCollapsed.bmp",
			ExplodingImage = "ScoreboardExploding.gif",
			CollapsingImage = "ScoreboardCollapsing.gif",
		}; 
	
		public static readonly Project FireworkProject = new()
		{
			ProjectTitle = "Fireworks Mortor Launcher",
			ProjectHref = "projects/Fireworks",
			ProjectDescription = "A 12 shot custom fireworks mortor launcher with bluetooth controlled app, automated timing, quick reloading connections, custom PCB designs and 3D printed enclosures.",
			ProjectMainImage = "FireworksMortor-Iso.png",
		};
		public List<Project> projects { get; set; } = new()
		{
			ScoreboardProject,
			FireworkProject,
		};
		public Project? GetProjectByHref(string href)
		{
			return projects.Where(p => p.ProjectHref.Contains(href)).FirstOrDefault();
		}
	}
}
