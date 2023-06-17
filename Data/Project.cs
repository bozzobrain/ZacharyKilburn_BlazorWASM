﻿using Blazor3D.Maths;
using System.Diagnostics;
using ZacharyKilburn_BlazorWASM.Pages;

namespace ZacharyKilburn_BlazorWASM.Data
{
	public class Project
	{
		public string ProjectTitle { get; set; } = string.Empty;
		public string ProjectTitleShort { get; set; } = string.Empty;
		public string ProjectDescription { get; set; } = string.Empty;
		public string ProjectHref { get; set; } = string.Empty;
		public string ProjectDate { get; set; } = string.Empty;
		public string ProjectMainVideoLink { get; set; } = string.Empty;
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
			ProjectDescription = "hstart Project Description hend Motivated by constantly forgetting the score when playing cornhole as well as a deep need for a new project, the bluethooth enabled portable scoreboard was born. " +
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
				threeDViews = new List<ThreeDView> {
					 new ThreeDView()
					{
						ThreeDeeViewName = "Scoreboard",
						ThreeDeeModel = "CornholeScoreViewer/CornholeScoreViewer.fbx",
						CameraPosition = new Vector3(3, 10, 0),
						CameraLook = new Vector3(0, 9, 0),
						ScaleFactor = new Vector3(9, 9, 9),
					},
					new ThreeDView()
					{
						ThreeDeeViewName = "LED Collapsed",
						ThreeDeeModel = "CornholeScoreViewer/LEDDigit-Collapsed.fbx",
						CameraPosition = new Vector3(3, 0.5, 0),
						CameraLook = new Vector3(0, 0, 0),
						ScaleFactor = new Vector3(5,5,5),
					},
					new ThreeDView()
					{
						ThreeDeeViewName = "LED Exploded",
						ThreeDeeModel = "CornholeScoreViewer/LEDDigit-Exploded.fbx",
						CameraPosition = new Vector3(3, 6.75, 0),
						CameraLook = new Vector3(0, 5.5, 0),
						ScaleFactor = new Vector3(5, 5, 5),
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
			ProjectTitleShort = "Mortar",
			ProjectHref = "projects/Fireworks",
			ProjectDate = "2021-Current",
			ProjectDescription = "hstart Project Description hend I was always wishing there was a better way to launch more fireworks faster on the 4th of July. " +
			"Instead of doing what most others do and just wiring a long fuse to multiple cannons, I decided to use my engineering mind to create something much more exciting. " +
			"\n\n hstart Design hend" +
			"This 12 shot custom fireworks mortar launcher features a bluetooth controlled app, variable timing delays, manual shot selection, quick reloading connections, custom PCB designs and 3D printed enclosures. " +
			"\n\n hstart Electronics Box hend" +
			"The quick disconnecting control unit slides onto a bracket allowing for removal for charging, updaing firmware and housing inside when done shooting off the fireworks. ",
			ProjectMainImage = "FireworksMortar/FireworksMortar-Iso.png",

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
							CameraPosition = new Vector3(17, 3, 0),
							CameraLook = new Vector3(0, 0, 0),
							ScaleFactor = new Vector3(16, 16, 16),
						},
						new ThreeDView()
						{
							ThreeDeeViewName = "Electronics Box",
							ThreeDeeModel = "FireworksMortar/FireworksElectronicsBox.fbx",
							CameraPosition = new Vector3(3, 4, 0),
							CameraLook = new Vector3(0, 3, 0),
							ScaleFactor = new Vector3(7, 7,7),
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
			ProjectDescription = "hstart Project Description hend Senior Capstone project from The University of Akron. " +
			"The robot received the name Nigel (Thornberry) for no obvious reason. " +
			"Nigel competed in linkstart href=http://robogames.net/index.php hrefend RoboGameslinkend, a robotics competition in San Mateo, California." +
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
			ProjectMainImage = "CombatRobot/CombatRobot.png",

			DownloadLink = "CombatRobot/Autonomous Combat Robot Report.pdf",
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
							ThreeDeeModel = "CombatRobot/CombatRobot.fbx",
							CameraPosition = new Vector3(20, 10, 0),
							CameraLook = new Vector3(0, 6, 0),
							ScaleFactor = new Vector3(15, 15, 15),
						},

						}
				}
			},
		};

		//
		public static readonly Project NeoPixelFFT = new()
		{
			ProjectTitle = "NeoPixel FFT",
			ProjectHref = "projects/NeoFFT",
			ProjectTitleShort = "Neo FFT",
			ProjectDate = "2020",
			ProjectMainVideoLink = "https://youtube.com/embed/daN55iL3Ups",
			ProjectDescription = "hstart Project Description hend" +
			"I had used the addressable NeoPixel strands during multiple projects, and had an understanding of what an discrete FFT could provide. " +
			"After contemplating exactly how I was going to implement an audio spectrum visualizer, I decided that I could combine the two of these into a whole room dance party." +
			"\n\n hstart Design hend" +
			"Originally bench tested on the arduino platform using the" +
			"linkstart href=boards/Z3 hrefendNeoPixel Boardlinkend." +
			"I quickly realized that the 16MHz AVR core was not going to have the umph necessary for the discrete FFT processing, it simply couldn't handle the floating point math. " +
			"I then decided to design a new PCB, the" +
			"linkstart href=boards/Z4 hrefendPIC32 Boardlinkend" +
			" to utilize the PIC32MZ as a general development platform for myself. " +
			"In order to get the PIC32 board interfacing with the 5V logic, I designed the " +
			"linkstart href=boards/Z7 hrefendLevel Translator Boardlinkend" +
			" as a general use voltage level translator." +
			"After getting the code up and running in the new PIC core, I had myself a working project.",
			ProjectMainImage = "NeoPixelFFT/NeoPixelFFT.png",
			SubPages = new List<ProjectSubPage>()
			{
				
				new ProjectSubPage() {
				SubPageTitle = "Boards",
				SubPageHref = "Boards",
				ContainedBoardDesigns = new List<string>()
					{
						"Z3",
						"Z4",
						"Z7",
					},
				},
			},
		};
		public static readonly Project SumoRobot = new()
		{
			ProjectTitle = "Sumo Bot",
			ProjectHref = "projects/Sumo",
			ProjectDate = "2013",
			ProjectDescription = "hstart Project Description hend Competiting locally at linkstart href=https://www.thenrc.org/ hrefend National Robotic Challenge linkend  and in a larger competition called linkstart href=http://robogames.net/index.php hrefend RoboGames linkend in San Mateo, California, this robot purpose was a Sumo Robot, competiting against the competition to be the last robot inside of the ring." +
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
			ProjectMainImage = "SumoBot/sumo-bot2.png",
		};

		public static readonly Project IndexFan = new()
		{
			ProjectTitle = "Index Frunk Fan",
			ProjectTitleShort = "Frunk Fan",
			ProjectHref = "projects/IndexFan",
			ProjectDate = "2020",
			ProjectDescription = "hstart Project Description hend " +
			"After playing VR for hours on end with the Valve Index, I would get very hot and so would the electronics. " +
			"The front side of the headset features an expansion bay with a USB port embedded into the plastic." +
			"While there were some online modules, some with LED and some with fans in them, I decided to try to design my own." +
			"I grabbed the calipers and made some educated guesses on curvatures, clearances and dimensions. " +
		  "\n\n hstart Design hend" +
		  "Due to the tight packaging of the enclosing area as well as a limited height, it was proved to be a difficult engineering problem. " +
			"I selected a fan, " +
			"linkstart href=https://www.delta-fan.com/products/BFB0305MA-CR00.html hrefend Dekta Electronics BFB0305MA-Alinkend," +
			" that had the correct profile that could fit within the enclosed area and blow sideways into a slotted area, pushing pressure into the electronics enclosure. " +
			"I designed a board that would surround the fan and provide a mounting profile, but struggled with the height of the fan compared to the USB port. " +
			"A small USB interface board with a vertical header allowed the fan holder to float above the USB interface. " +
		  "\n\n hstart Results hend" +
			"Overall the design provided a little bit of airflow into the enclosure and lowered the temperature of my face during long playtimes. " +
			"It was definitely a project I would consider a success." +
			"imgstart IndexFrunk/IndexFrunkInstalled.jpg imgend",


			ProjectMainImage = "IndexFrunk/IndexFrunkBoardStack.png",
			SubPages = new List<ProjectSubPage>()
			{
				new ProjectSubPage()
				{
					SubPageTitle = "3D",
					SubPageHref = "3D",
					threeDViews = new List<ThreeDView> {
						  new ThreeDView()
						{
							ThreeDeeViewName = "Frunk Fan Module",
							ThreeDeeModel = "IndexFrunk/IndexFrunkFan.fbx",
							CameraPosition = new Vector3(7.5, 0.2, 0),
							CameraLook = new Vector3(0, 0.5, 0),
							ScaleFactor = new Vector3(1.3, 1.3, 1.3),
						},

						}
				},
				new ProjectSubPage() {
				SubPageTitle = "Boards",
				SubPageHref = "Boards",
				ContainedBoardDesigns = new List<string>()
					{
						"Z18",
						"Z19",
					},
				},
			},
		};

		public static readonly Project EDMPowerSupply = new()
		{
			ProjectTitle = "EDM Power Supply",
			ProjectTitleShort = "EDM PSU",
			ProjectHref = "projects/EDMPSU",
			ProjectDate = "2013",
			ProjectDescription = "hstart Project Description hend Designed as part of a contract engineering assignment, the EDM PSU was conceived as a variable AC/DC power supply intended for use with a CNC controlled manufacturing machine." +
			"\n\n hstart Design hend" +
			"Providing constant current / constant voltage over the range of 10-100V and 5mA - 10A. It was enclosed in a industrial cabinet and featured custom circuit boards for the AC/DC conversion and a second custom PCB for the HMI.  \n\n" +
			"While never fully validated by the client, and not short of its limitations, it was a challenging project that functioned well during bench testing.",
			ProjectMainImage = "EDMPSU/EDMPSU.png",

			SubPages = new List<ProjectSubPage>()
			{
				new ProjectSubPage()
				{
					SubPageTitle = "3D",
					SubPageHref = "3D",
					threeDViews = new List<ThreeDView> {
						 new ThreeDView()
						{
							ThreeDeeViewName = "EDM PSU",
							ThreeDeeModel = "EDMPSU/EDMPSU.fbx",
							CameraPosition = new Vector3(10, 0, 0),
							CameraLook = new Vector3(0, -1, 0),
							ScaleFactor = new Vector3(10, 10, 10),
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
			ProjectTitle = "Outreach - Bicycle Brake",
			ProjectHref = "projects/BMEBike",
			ProjectDate = "2018",
			ProjectDescription = "hstart Project Description hend A small team of The University of Akron engineering students designed/constructed a handicapable assisted bicycle that helped a local boy with spinocerebellar ataxia able to ride. " +
			"\n\n hstart Design hend" +
			"Westley had difficulty controlling the bicycle brakes by pedaling backward, so we engineered a motor to pull a handbrake for him with the press of a button. " +
			"In addition 3D printed pedal adapters were made to strap his feet to the pedals to help him maintain control and balance while riding. " +
			"\n\n hstart My Role hend" +
			"I was involved in the design of the electrically assisted braking mechanism consisting of a power supply, servo for pulling the brake cable and a power recoving generator. " +
			"The battery was modestly sized so a wheel driven generator and a circuit to charge the batteries from it helped to extend the life of the batteries. " +
			"\n\n hstart Article hend" +
			"View the linkstart href=https://www.thepostnewspapers.com/norton/local_news/students-help-design-assemble-bike-for-norton-boy/article_7bab3de4-eaf0-575a-aa62-1edae7f0d13b.html hrefend Newspaper Article linkend",
			ProjectMainImage = "BMEBike/BMEBike.jpg",

		};



		public List<Project> projects { get; set; } = new()
		{
			ScoreboardProject,
			FireworkProject,
			IndexFan,
			NeoPixelFFT,
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
