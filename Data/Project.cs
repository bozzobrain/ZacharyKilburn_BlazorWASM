using Blazor3D.Maths;
using System.Diagnostics;

namespace ZacharyKilburn_BlazorWASM.Data
{
	public class Project
	{
		public string ProjectTitle { get; set; } = string.Empty;
		public string ProjectDescription { get; set; } = string.Empty;
		public string ProjectHref { get; set; } = string.Empty;
        public string ProjectDate { get; set; } = string.Empty;
        public string ProjectMainImage { get; set; } = string.Empty;
		public string CollapsedImage { get; set; } = string.Empty;
		public string ExplodingImage { get; set; } = string.Empty;
        public string CollapsingImage { get; set; } = string.Empty;
		public string ThreeDeeModel { get; set; } = string.Empty;
		public string ThreeDeeModelTexture { get; set; } = string.Empty;
		public Vector3 CameraPosition { get; set; } = new Vector3();
        public Vector3 CameraLook { get; set; } = new Vector3();
        public Vector3 ScaleFactor { get; set; } = new Vector3();
        public string DownloadLink { get; set; } = string.Empty;

    }
	public class ProjectLoader
	{
		public static readonly Project ScoreboardProject = new()
		{
			ProjectTitle = "Scoreboard",
			ProjectHref = "projects/Scoreboard",
            ProjectDate = "2021",
            ProjectDescription = "A custom scoreboard with bluetooth and manual score entry featuring an Android application, custom PCB designs and lots of 3D printing",
			ProjectMainImage = "Scoreboard-Iso.png",
			//CollapsedImage = "ScoreboardCollapsed.bmp",
			//ExplodingImage = "ScoreboardExploding.gif",
			//CollapsingImage = "ScoreboardCollapsing.gif",
			ThreeDeeModel = "CornholeScoreViewer.fbx",
			ThreeDeeModelTexture = "CornholeScoreViewer.mtl",
			CameraPosition = new Vector3(300, 150, 0),
            CameraLook = new Vector3(0, 50, 0),
            ScaleFactor = new Vector3(300, 300, 300),


        };

		public static readonly Project FireworkProject = new()
		{
			ProjectTitle = "Fireworks Mortar Launcher",
			ProjectHref = "projects/Fireworks",
            ProjectDate = "2021",
            ProjectDescription = "A 12 shot custom fireworks mortar launcher with bluetooth controlled app, automated timing, quick reloading connections, custom PCB designs and 3D printed enclosures.",
			ProjectMainImage = "FireworksMortar-Iso.png",
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
            ProjectDate = "2018",
            ProjectDescription = "Senior design project from The University of Akron. " +
			"With drive wheels located outside of the body on top and bottom, the robot was capable of driving after being inverted. " +
			"Competing in the 200lb weight class, the robot was praised as the first combat robot to feature autonomous operation." +
			"Nested within the exterior rotating weapon, 8 uni-directional LIDAR sensors gathered data about the robots position within the arena. " +
			"The sensors were timed to aquire measurements while the weapon windows were not obscuring the sensor view." +
			"Measurement data was then combined into robot postition data via a neural network, trained in Matlab, running in an onboard microcontroller.",
			ProjectMainImage = "CombatRobot.png",
			ThreeDeeModel = "CombatRobot.obj",
			ThreeDeeModelTexture = "CombatRobot.mtl",
			CameraPosition = new Vector3(600, 300, 0),
			CameraLook = new Vector3(0, 50, 0),
			ScaleFactor = new Vector3(500, 500, 500),
			DownloadLink = "Autonomous Combat Robot Report.pdf",
		};

        public static readonly Project SumoRobot = new()
        {
            ProjectTitle = "Sumo Bot Competition",
            ProjectHref = "projects/Sumo",
            ProjectDate = "2013",
            ProjectDescription = "",
            ProjectMainImage = "sumo-bot2.png",
        };
		public static readonly Project EDMPowerSupply = new()
		{
			ProjectTitle = "EDM Power Supply",
			ProjectHref = "projects/EDMPSU",
			ProjectDate = "2013",
			ProjectDescription = "",
			ProjectMainImage = "EDMPSU.png",
			ThreeDeeModel = "EDMPSU-Open.obj",
			ThreeDeeModelTexture = "EDMPSU-Open.mtl",
			CameraPosition = new Vector3(600, 600, 0),
			CameraLook = new Vector3(0, 50, 0),
			ScaleFactor = new Vector3(500, 500, 500),
		};
		public static readonly Project BMEBike = new()
		{
			ProjectTitle = "Outreach - Assisted Bike Brake",
			ProjectHref = "projects/BMEBike",
			ProjectDate = "2018",
            ProjectDescription = "",
            ProjectMainImage = "BMEBike.jpg",
        };
        


        public List<Project> projects { get; set; } = new()
		{
			ScoreboardProject,
			FireworkProject,
			CombatRobot,
			SumoRobot,
            BMEBike,
			EDMPowerSupply,
		};
		public Project? GetProjectByHref(string href)
		{
			return projects.Where(p => p.ProjectHref.Contains(href)).FirstOrDefault();
		}
	}
}
