using Blazor3D.Maths;
using System.Diagnostics;
using ZacharyKilburn_BlazorWASM.Pages;

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
        public ThreeDView? ThreeDView { get; set; } = null;
        public HyperLink? Link { get; set; } = null;
        public string DownloadLink { get; set; } = string.Empty;
        public List<ProjectSubPage> SubPages { get; set; } = new List<ProjectSubPage>();

    }
    public class ProjectLoader
    {
        public static readonly Project ScoreboardProject = new()
        {
            ProjectTitle = "Scoreboard",
            ProjectHref = "projects/Scoreboard",
            ProjectDate = "2021",
            ProjectDescription = "A custom scoreboard with bluetooth and manual score entry featuring an Android application, custom PCB designs and lots of 3D printing",
            ProjectMainImage = "CornholeScoreViewer/Scoreboard-Iso.png",

            SubPages = new List<ProjectSubPage>()
            {
                new ProjectSubPage() {
                SubPageTitle = "App",
                SubPageHref = "Android",
                SubPageImage = "CornholeScoreViewer/AndroidFootballScreen.png",
                SubPageDescription = "Android app to control the ScoreViewer",
                },
                new ProjectSubPage() {
                SubPageTitle = "3D",
                SubPageDescription = "One of the 8 LED segments",
                threeDViews = new List<ThreeDView> {
                     new ThreeDView()
                    {
                        ThreeDeeViewName = "Scorebord",
                        ThreeDeeModel = "CornholeScoreViewer/CornholeScoreViewer.fbx",
                        CameraPosition = new Vector3(20, 10, 0),
                        CameraLook = new Vector3(0, 0, 0),
                        ScaleFactor = new Vector3(20, 20, 20),
                    },
                    new ThreeDView()
                    {
                        ThreeDeeViewName = "LED Collapsed",
                        ThreeDeeModel = "CornholeScoreViewer/LEDDigit-Collapsed.fbx",
                        CameraPosition = new Vector3(3, 2.5, 0),
                        CameraLook = new Vector3(0, 3, 0),
                        ScaleFactor = new Vector3(6,6,6),
                    },
                    new ThreeDView()
                    {
                        ThreeDeeViewName = "LED Exploded",
                        ThreeDeeModel = "CornholeScoreViewer/LEDDigit-Exploded.fbx",
                        CameraPosition = new Vector3(3, 3, 0),
                        CameraLook = new Vector3(0, 3, 0),
                        ScaleFactor = new Vector3(8, 8, 8),
                    },
                },

            },
            new ProjectSubPage()
            {
                SubPageTitle = "Boards",
                SubPageHref = "Boards",
                ContainedBoardDesigns = new List<String>()
                {
                    "Z3",
                    "Z21",
                   "Z25",
                    "Z26",
                    "Z27",
                    "Z28",
                },
            },
            },


        };

        public static readonly Project FireworkProject = new()
        {
            ProjectTitle = "Fireworks Mortar Launcher",
            ProjectHref = "projects/Fireworks",
            ProjectDate = "2021",
            ProjectDescription = "A 12 shot custom fireworks mortar launcher with bluetooth controlled app, automated timing, quick reloading connections, custom PCB designs and 3D printed enclosures.",
            ProjectMainImage = "FireworksMortar-Iso.png",

            SubPages = new List<ProjectSubPage>()
            {
                new ProjectSubPage() {
                SubPageTitle = "App",
                SubPageHref = "Android",
                SubPageImage = "FireworksMortar/FireworksMortarAndroid.png",
                SubPageDescription = "Android app to control the ScoreViewer",
                },
                new ProjectSubPage() {
                SubPageTitle = "3D",
                threeDViews = new List<ThreeDView> {
                       new ThreeDView()
                        {
                            ThreeDeeViewName = "Mortar Rack",
                            ThreeDeeModel = "FireworksMortar/FireworksMortarRack.fbx",
                            CameraPosition = new Vector3(20, 10, 0),
                            CameraLook = new Vector3(0, 0, 0),
                            ScaleFactor = new Vector3(20, 20, 20),
                        },
                        new ThreeDView()   
                        {
                            ThreeDeeViewName = "Electronics Box",
                            ThreeDeeModel = "FireworksMortar/FireworksElectronicsBox.fbx",
                            CameraPosition = new Vector3(3, 3, 0),
                            CameraLook = new Vector3(0, 3, 0),
                            ScaleFactor = new Vector3(8, 8, 8),
                        }
                    }
                },
                new ProjectSubPage() {
                SubPageTitle = "Boards",
                SubPageHref = "Boards",
            ContainedBoardDesigns = new List<string>()
                {
                   "Z22",
                    "Z23",
                    "Z24",
                },
                },

            },

        };

        public static readonly Project CombatRobot = new()
        {
            ProjectTitle = "200lb Combat Robot",
            ProjectHref = "projects/Combot",
            ProjectDate = "2018",
            ProjectDescription = "Senior Capstone project from The University of Akron. The robot received the name Nigel (Thornberry) for no obvious reason. Nigel competed in linkstart href=http://robogames.net/index.php hrefend RoboGames linkend, a robotics competition in San Mateo, California. \n\n" +
            "hstart Design hend" +
            "Nigel had drive wheels that protruded outside of the body on top and bottom, meaning that the robot was capable of driving after being inverted, which often occurs when other robots try to flip their opponent into the air. " +
            "Yielding a 60lb spinning outer shell as an impacting weapon, two impacting hammers layered with solid steel provided a rigid and powerful weapon for Nigel. " +
            "The hammers would reach a max speed of 400mph when the shell was fully energized. " +
            "Driving the shell was the 8HP, Angi 95R motor, commonly used for EV vehicle applications. " +
            "While this posed serious control challenges, there was even more to Nigel than just a punishing weapon design. \n\n" +
            "hstart Autonomous Operation hend" +
            "Competing in the 200lb weight class, Nigel was praised as the first combat robot in the competition to feature autonomous operation. " +
            "Nested within the exterior rotating weapon, 8 uni-directional LIDAR sensors gathered data about the robots position within the arena. " +
            "The sensors were timed to aquire measurements while the weapon windows were not obscuring the sensor view. " +
            "Measurement data was then combined into robot postition data via a neural network, trained in Matlab, running in an onboard microcontroller.",
            ProjectMainImage = "CombatRobot.png",
       
            DownloadLink = "Autonomous Combat Robot Report.pdf",
            SubPages = new List<ProjectSubPage>()
            {
                new ProjectSubPage()
                {
                    SubPageTitle = "3D",
                    SubPageHref = "3D",
                    threeDViews = new List<ThreeDView> {
                          new ThreeDView()
                        {
                            ThreeDeeViewName = "Combat Robot",
                            ThreeDeeModel = "CombatRobot.obj",
                            CameraPosition = new Vector3(600, 300, 0),
                            CameraLook = new Vector3(0, 50, 0),
                            ScaleFactor = new Vector3(500, 500, 500),
                        },
                          
                        }
                }
            },
        };

        public static readonly Project SumoRobot = new()
        {
            ProjectTitle = "Sumo Bot Competition",
            ProjectHref = "projects/Sumo",
            ProjectDate = "2013",
            ProjectDescription = "Competiting at RoboGames in San Mateo, California. As a team of three members, my role was for the software development. The team took 2nd place at the compeition.",
            ProjectMainImage = "sumo-bot2.png",
        };
        public static readonly Project EDMPowerSupply = new()
        {
            ProjectTitle = "EDM Power Supply",
            ProjectHref = "projects/EDMPSU",
            ProjectDate = "2013",
            ProjectDescription = "Designed as part of a contract engineering assignment, the EDM PSU was conceived as a variable AC/DC power supply intended for use with a CNC controlled manufacturing machine." +
            "Providing constant current / constant voltage over the range of 10-100V and 5mA - 10A. \n\n" +
            "While never fully validated by the client, and not short of its limitations, it was a challenging project that functioned well during bench testing.",
            ProjectMainImage = "EDMPSU.png",
           
            SubPages = new List<ProjectSubPage>()
            {new ProjectSubPage()
                {
                    SubPageTitle = "3D",
                    SubPageHref = "3D",
                    threeDViews = new List<ThreeDView> {
                         new ThreeDView()
                        {
                            ThreeDeeViewName = "EDM PSU",
                            ThreeDeeModel = "EDMPSU-Open.obj",
                            CameraPosition = new Vector3(600, 600, 0),
                            CameraLook = new Vector3(0, 50, 0),
                            ScaleFactor = new Vector3(500, 500, 500),
                        },

                        }
                },
                new ProjectSubPage() {
                SubPageTitle = "Boards",
                SubPageHref = "Boards",
            ContainedBoardDesigns = new List<string>()
                {
                    "Z1",
                    "Z2",
                },
                },
            },
        };
        public static readonly Project BMEBike = new()
        {
            ProjectTitle = "Outreach - Assisted Bike Brake",
            ProjectHref = "projects/BMEBike",
            ProjectDate = "2018",
            ProjectDescription = "A small team of The University of Akron engineering students designed/constructed a local boy a device that helped him utilize a bicycle despite his disability." +
            "The design consisted of an assisted braking method powered by batteries and a servo as well as larger pedals with straps for holding his feet into the pedals.",
            ProjectMainImage = "BMEBike.jpg",
            Link = new HyperLink()
            {
                Link = "https://www.thepostnewspapers.com/norton/local_news/students-help-design-assemble-bike-for-norton-boy/article_7bab3de4-eaf0-575a-aa62-1edae7f0d13b.html",
                Name = "Article"
            },
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
    public class ProjectSubPage
    {
        public string SubPageTitle = string.Empty;
        public string SubPageImage = string.Empty;
        public string SubPageHref = string.Empty;
        public string SubPageDescription = string.Empty;
        public List<ThreeDView> threeDViews { get; set; } = new List<ThreeDView>();
        public List<string>? ContainedBoardDesigns { get; set; } = null;
    }

    public class ThreeDView
    {
        public string ThreeDeeViewName { get; set; } = string.Empty;
        public string ThreeDeeModel { get; set; } = string.Empty;
        public Vector3 CameraPosition { get; set; } = new Vector3();
        public Vector3 CameraLook { get; set; } = new Vector3();
        public Vector3 ScaleFactor { get; set; } = new Vector3();

    }
    public class HyperLink
    {
        public string Name { get; set; } = string.Empty;
        public string Link { get; set; } = string.Empty;
    }
}
