using Blazor3D.Maths;
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
		public string ThreeDeeModel { get; set; } = string.Empty;
		public string ThreeDeeModelTexture { get; set; } = string.Empty;
		public Vector3 CameraPosition { get; set; } = new Vector3();
        public Vector3 CameraLook { get; set; } = new Vector3();
        public Vector3 ScaleFactor { get; set; } = new Vector3();

    }
	public class ProjectLoader
	{
		public static readonly Project ScoreboardProject = new()
		{
			ProjectTitle = "Scoreboard",
			ProjectHref = "projects/Scoreboard",
			ProjectDescription = "A custom scoreboard with bluetooth and manual score entry featuring an Android application, custom PCB designs and lots of 3D printing",
			ProjectMainImage = "Scoreboard-Iso.png",
			//CollapsedImage = "ScoreboardCollapsed.bmp",
			//ExplodingImage = "ScoreboardExploding.gif",
			//CollapsingImage = "ScoreboardCollapsing.gif",
			ThreeDeeModel = "CornholeScoreViewer.obj",
			ThreeDeeModelTexture = "CornholeScoreViewer.mtl",
			CameraPosition = new Vector3(300, 150, 0),
            CameraLook = new Vector3(0, 50, 0),
            ScaleFactor = new Vector3(300, 300, 300),


        };

		public static readonly Project FireworkProject = new()
		{
			ProjectTitle = "Fireworks Mortor Launcher",
			ProjectHref = "projects/Fireworks",
			ProjectDescription = "A 12 shot custom fireworks mortor launcher with bluetooth controlled app, automated timing, quick reloading connections, custom PCB designs and 3D printed enclosures.",
			ProjectMainImage = "FireworksMortor-Iso.png",
			ThreeDeeModel = "FireworkMortarRack.obj",
			ThreeDeeModelTexture = "FireworkMortarRack.mtl",
			CameraPosition = new Vector3(400, 200, 0),
			CameraLook = new Vector3(0, 50, 0),
            ScaleFactor = new Vector3(400, 400, 400),
        }; 

		public static readonly Project CombatRobot = new()
		{
			ProjectTitle = "200lb Combat Robot",
			ProjectHref = "projects/Combot",
			ProjectDescription = "Senior design project from The University of Akron. Competing in the 200lb weight class, the robot featured autonomous operation with optical distance sensors nested within its rotating weapon. The robot was capable of operating after having been flipped upside down. The autonomous operation was possible with a neural network trained in MATLAB.",
			ProjectMainImage = "CombatRobot.png",
			ThreeDeeModel = "CombatRobot.obj",
			ThreeDeeModelTexture = "CombatRobot.mtl",
			CameraPosition = new Vector3(600, 300, 0),
			CameraLook = new Vector3(0, 50, 0),
            ScaleFactor = new Vector3(500, 500, 500),
        };

		public List<Project> projects { get; set; } = new()
		{
			ScoreboardProject,
			FireworkProject,
			CombatRobot,
		};
		public Project? GetProjectByHref(string href)
		{
			return projects.Where(p => p.ProjectHref.Contains(href)).FirstOrDefault();
		}
	}
}
