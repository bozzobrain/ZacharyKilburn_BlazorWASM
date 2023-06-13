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
        public string ProjectSubImage { get; set; } = string.Empty;
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
            ProjectDate = "2021-Current",
            ProjectDescription = "Motivated by constantly forgetting the score when playing cornhole as well as a deep need for a new project, the bluethooth enabled portable scoreboard was born. " +
            "\n\nhstart Design hend" +
            "Based on an old PCB designed for my neopixel project, the scoreboard is powered by 3 26650 LiFeP04 cells in a custom 3D printed package. " +
            "Initially developed using 8 copies of the large 7 segment displays using SMT LEDs, a trip outside showed that the SMT LEDs did not pack the punch necessary to cut throught the sun on a bright day, so it was back to the drawing board. " +
            "\n\nhstart Remote Controlled hend" +
            "A bluefruit BLE device was added and an android app build to allow for remote control of the scoreboard, when walking is just too much work. " +
            "\n\nhstart More Revisions To Come hend" + 
            "Revision 2 was updated utilizing all of the same 3D prints, but integrating much brighter through-hole LEDs, unconventionally bent into position to allow for clearance within the 3D printed fixturing. " +
			"A future revision will likely be make to customize the controller to allow for additional I/O to monitor the battery voltages to warn the user of impending battery death. Sill use this regularly in the backyard with the cornhole boards.",
            ProjectMainImage = "CornholeScoreViewer/Scoreboard-Iso.png",

            SubPages = new List<ProjectSubPage>()
            {
                new ProjectSubPage() {
                SubPageTitle = "Schematic",
                SubPagePDF = "CornholeScoreViewer/CornholeScoreViewer-Schematic.pdf",
                },
                new ProjectSubPage() {
                SubPageTitle = "App",
                SubPageHref = "Android",
                SubPageImage = "CornholeScoreViewer/AndroidFootballScreen.png",
                SubPageDescription = "The scoreboard can be controlled either from the buttons located on the top of the unit, or via a custom android app over bluetooth. While the app does lack some aethetic appeal, the functionality allows you to control the scoreboard from a distance. " +
                    "Since the LEDs of the scoreboard are based on the Neopixel WS2811 controller, RGB LEDs can be tailored to whatever team colors you want, both through the buttons or the app. ",
                },
                new ProjectSubPage() {
                SubPageTitle = "3D",
                SubPageDescription = "One of the 8 LED segments",
                threeDViews = new List<ThreeDView> {
                     new ThreeDView()
                    {
                        ThreeDeeViewName = "Scoreboard",
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
            ProjectDate = "2021-Current",
            ProjectDescription = "I was always wishing there was a better way to launch more fireworks faster on the 4th of July. Instead of doing what most others do and just wiring a long fuse to multiple cannons, I decided to use my engineering mind to create something much more exciting. " +
            "\n\n hstart Design hend" +
            "This 12 shot custom fireworks mortar launcher features a bluetooth controlled app, variable timing delays, manual shot selection, quick reloading connections, custom PCB designs and 3D printed enclosures. " +
            "\n\n hstart Electronics Box hend" +
            "The quick disconnecting control unit slides onto a bracket allowing for removal for charging, updaing firmware and housing inside when done shooting off the fireworks. ",
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
            ProjectDate = "2017-2018",
            ProjectDescription = "Senior Capstone project from The University of Akron. The robot received the name Nigel (Thornberry) for no obvious reason. Nigel competed in linkstart href=http://robogames.net/index.php hrefend RoboGames linkend, a robotics competition in San Mateo, California. \n\n" +
            "\n\n hstart Design hend" +
            "Nigel had drive wheels that protruded outside of the body on top and bottom, meaning that the robot was capable of driving after being inverted, which often occurs when other robots try to flip their opponent into the air. " +
            "Wielding a 60lb spinning outer shell as an impacting weapon, two impacting hammers layered with solid steel provided a rigid and powerful weapon for Nigel. " +
            "The hammers would reach a max speed of 400mph when the shell was fully energized. " +
            "Driving the shell was the 8HP, Angi 95R motor, commonly used for EV vehicle applications. " +
            "While this posed serious control challenges, there was even more to Nigel than just a punishing weapon design." +
            "\n\n hstart Autonomous Operation hend" +
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
            ProjectDescription = "Competiting locally at linkstart href=https://www.thenrc.org/ hrefend National Robotic Challenge linkend  and in a larger competition called linkstart href=http://robogames.net/index.php hrefend RoboGames linkend in San Mateo, California, this robot purpose was a Sumo Robot, competiting against the competition to be the last robot inside of the ring." +
            "\n\n hstart Design hend" +
            "Utilizing ultrasonic sensors to locate the opponent, it is a compeition of speed and force. As a team of three members, my role was to develop the software to acquire the sensor information and control the motiion of the robot accordingly. " +
            "Our robot was arduino based and electrically build using COTS items (since we were freshman in college). " +
            "With the limitation of a weight limit and knowing that the arena would be constructed from steel, we placed two large neodynium magnets on the bottom of the robot to effectively increase the weight of the robot. " +
            "\n\n hstart Software Design hend" +
            "The two forward facing ultrasonic sensors give a distance measurement to the closest object. " +
            "By omitting distances that extended beyond the maximum distance possible within the arena, detecting the opponents location was relatively easy. " +
            "While there were no objects within range, the tactic was simple; Spin in circles until there is something close to you." +
            "\n\n hstart Quick Boot Time hend" +
            "The onboard Arduino typically utilizes a bootloader at reset or power-on that typically causes the onboard microcontroller to wait about 4-5 seconds for a program to be loaded. " +
            "By removing this bootloader and directly placing the code at the start of program memory we gained a significant advantage over the competition. " +
            "\n\n hstart Compeition Results hend" +
            "Our quick boot time, larger effective weight and simple control loop resulted in our team being nominated and winning the Honda Innovation Award at NRC and taking 2nd place in our weight class at RoboGames." +
            "\n\n hstart Video hend" +
            "See the linkstart href=https://youtu.be/CH-LgnNnuQQ hrefend Video linkend here.",
            ProjectMainImage = "sumo-bot2.png",
        };
        public static readonly Project EDMPowerSupply = new()
        {
            ProjectTitle = "EDM Power Supply",
            ProjectHref = "projects/EDMPSU",
            ProjectDate = "2013",
            ProjectDescription = "Designed as part of a contract engineering assignment, the EDM PSU was conceived as a variable AC/DC power supply intended for use with a CNC controlled manufacturing machine." +
            "\n\n hstart Design hend" +
            "Providing constant current / constant voltage over the range of 10-100V and 5mA - 10A. It was enclosed in a industrial cabinet and featured custom circuit boards for the AC/DC conversion and a second custom PCB for the HMI.  \n\n" +
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
            ProjectDescription = "A small team of The University of Akron engineering students designed/constructed a handicapable assisted bicycle that helped a local boy with spinocerebellar ataxia able to ride. " +
            "\n\n hstart Design hend" +
            "Westley had difficulty controlling the bicycle brakes by pedaling backward, so we engineered a motor to pull a handbrake for him with the press of a button. " +
            "In addition 3D printed pedal adapters were made to strap his feet to the pedals to help him maintain control and balance while riding. " +
            "\n\n hstart My Role hend" +
            "I was involved in the design of the electrically assisted braking mechanism consisting of a power supply, servo for pulling the brake cable and a power recoving generator. " +
            "The battery was modestly sized so a wheel driven generator and a circuit to charge the batteries from it helped to extend the life of the batteries. " +
            "\n\n hstart Article hend" +
			"View the linkstart href=https://www.thepostnewspapers.com/norton/local_news/students-help-design-assemble-bike-for-norton-boy/article_7bab3de4-eaf0-575a-aa62-1edae7f0d13b.html hrefend Newspaper Article linkend",
            ProjectMainImage = "BMEBike.jpg",
       
        };



        public List<Project> projects { get; set; } = new()
        {
            ScoreboardProject,
            FireworkProject,
            CombatRobot,
            BMEBike,
            SumoRobot,
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
        public string SubPagePDF = string.Empty;
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
