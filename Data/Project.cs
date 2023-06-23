using Blazor3D.Maths;
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
		public string ProjectFacebook { get; set; } = string.Empty;
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
			ProjectDescription = "hstart Project Description hend " +
					"Motivated by constantly forgetting the score when playing cornhole as well as a deep need for a new project, the Bluetooth enabled portable scoreboard was born. " +
					"\n\nhstart Design hend" +
					"Based on an old PCB designed for my " +
					"linkstart href=projects/NeoFFT hrefend NeoPixel projectlinkend" +
					", the scoreboard is powered by 3 26650 LiFeP04 cells in a custom 3D printed package. " +
					"Initially developed using 8 copies of the large " +
					"linkstart href=boards/Z27 hrefend 7 segment displays linkend" +
					"using SMT LEDs, a trip outside showed that the SMT LEDs did not pack the punch necessary to cut through the sun on a bright day, so it was back to the drawing board. " +
					"\n\nhstart Firmware hend" +
					"See my code linkstart href=https://github.com/bozzobrain/CornholeScoreViewer hrefend herelinkend" +
					"\n\nhstart Remote Controlled hend" +
					"The linkstart href=https://www.adafruit.com/product/2479 hrefend Adafruit Bluefruitlinkend adapter " +
					"was added and an android app build to allow for remote control of the scoreboard, when walking is just too much work. " +
					"\n\nhstart Revisions hend" +
					"Revision 2 was updated utilizing all the same 3D prints but integrating much brighter " +
					"linkstart href=boards/Z28 hrefend through-hole LEDslinkend" +
					", unconventionally bent into position to allow for clearance within the 3D printed fixturing. " +
					"A future revision will likely be made to customize the controller to allow for additional I/O to monitor the battery voltages to warn the user of impending battery death. " +
					"I still use this regularly in the backyard with the cornhole boards." +
					"paraend",
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
				SubPageDescription = "hstart Android hend" + 
						"The scoreboard can be controlled either from the buttons located on the top of the unit, or via a custom android app over bluetooth. " +
						"While the app does lack some aethetic appeal, the functionality allows you to control the scoreboard from a distance. " +
						"Since the LEDs of the scoreboard are based on the Neopixel WS2811 controller, RGB LEDs can be tailored to whatever team colors you want, both through the buttons or the app. "+
						"\n\nhstart Software hend" + 
						"See my code linkstart href=https://github.com/bozzobrain/ScoreviewerAndroid hrefend herelinkend"+
						"paraend",
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
					"This 12 shot custom fireworks mortar launcher features a Bluetooth controlled app, variable timing delays, manual shot selection, quick reloading connections, custom PCB designs and 3D printed enclosures. " +
					"\n\n hstart Electronics Box hend" +
					"The quick disconnecting control unit slides onto a bracket allowing for removal for charging, updating firmware and housing inside when done shooting off the fireworks. " +
					"\n\nhstart Software hend" +
					"View the Arduino control code linkstart href=https://github.com/bozzobrain/FireworkMortarLauncher hrefend herelinkend" + 
					"paraend",
            ProjectMainImage = "FireworksMortar/FireworksMortar-Iso.png",

			SubPages = new List<ProjectSubPage>()
			{
				new ProjectSubPage() {
				SubPageTitle = "App",
				SubPageHref = "Android",
				SubPageImage = "FireworksMortar/FireworksMortarAndroid.png",
				SubPageDescription = "hstart Android hend" + 
						"The Fireworks Mortar Launcher is primarily controlled through an app that allows for control of each tube independently. " +
						"It also allows for launching all of the tubes in a sequenced manner with variable timing between each of the tubes being ignited. " +
						"So if you want to launch all 12 mortars in rapid fire or select only a single tube to be launched, all can be done from a safe distance with the custom app. " +
						"\n\nhstart Software hend" +
						"View my questionable source code linkstart href=https://github.com/bozzobrain/FireworksControllerAndroid hrefend herelinkend"+
						"paraend",
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
					"Nested within the exterior rotating weapon, 8 unidirectional LIDAR sensors gathered data about the robot's position within the arena. " +
					"The sensors were timed to acquire measurements while the weapon windows were not obscuring the sensor view. " +
					"Measurement data was then combined into robot position data via a neural network, trained in Matlab, running in an onboard microcontroller." +
					"\n\n hstart Software hend" +
					"View the linkstart href=https://bitbucket.org/zkilburn/workspace/projects/CR hrefend Repositorylinkend" +
					"paraend",
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
					"I had used the addressable NeoPixel strands during multiple projects, and had an understanding of what a discrete FFT could provide. " +
					"After contemplating exactly how I was going to implement an audio spectrum visualizer, I decided that I could combine the two of these into a whole room dance party." +
					"\n\n hstart Design hend" +
					"Originally bench tested on the Arduino platform using the " +
					"linkstart href=boards/Z3 hrefendNeoPixel Boardlinkend. " +
					"I quickly realized that the 16MHz AVR core was not going to have the umph necessary for the discrete FFT processing, it simply couldn't handle the floating-point math. " +
					"After trying to port the FFT to the Arduino Due (" +
					"linkstart href=https://github.com/bozzobrain/FFT_Due hrefend See the codelinkend" +
					") to increase the cycles per second, I gave up and decided to design a new PCB with a more powerful processor. " +
					"The linkstart href=boards/Z4 hrefendPIC32 Boardlinkend" +
					" utilizes the PIC32MZ, and was made for this project and as a general development platform for myself. " +
					"To get the 3.3V PIC32 board interfacing with the 5V logic, I designed the " +
					"linkstart href=boards/Z7 hrefendLevel Translator Boardlinkend" +
					" as a general use voltage level translator. " +
					"After getting the code up and running in the new PIC core, I had myself a working project." +
					"\n\nhstart Software hend" +
					"View the PIC32 code linkstart href=https://github.com/bozzobrain/FFT_PIC32/tree/master hrefend herelinkend" +
					"paraend",
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
			ProjectDescription = "hstart Project Description hend " +
					"Competing locally at linkstart href=https://www.thenrc.org/ hrefend National Robotic Challenge linkend  and in a larger competition called linkstart href=http://robogames.net/index.php hrefend RoboGames linkend in San Mateo, California, this robot was built to be a Sumo Robot. " +
					"It was built to be the last robot inside of the ring, forcing the opponent out autonomously. " +
					"\n\n hstart Design hend" +
					"Utilizing ultrasonic sensors to locate the opponent, it is a competition of speed and force. " +
					"As a team of three members, my role was to develop the software to acquire the sensor information and control the motion of the robot accordingly. " +
					"Our robot was Arduino based and electrically built using COTS items (since we were freshman in college). " +
					"With the limitation of a weight limit and knowing that the arena would be constructed from steel, we placed two large neodymium magnets on the bottom of the robot to effectively increase the weight of the robot. " +
					"\n\n hstart Software Design hend" +
					"The two forward facing ultrasonic sensors give a distance measurement to the closest object. " +
					"By omitting distances that extended beyond the maximum distance possible within the arena, detecting the opponent's location was relatively easy. " +
					"While there were no objects within range, the tactic was simple; Spin in circles until there is something close to you." +
					"\n\n hstart Quick Boot Time hend" +
					"The onboard Arduino typically utilizes a bootloader at reset or power-on that typically causes the onboard microcontroller to wait about 4-5 seconds for a program to be loaded. " +
					"By removing this bootloader and directly placing the code at the start of program memory we gained a significant advantage over the competition. " +
					"\n\n hstart Competition Results hend" +
					"Our quick boot time, larger effective weight and simple control loop resulted in our team being nominated and winning the Honda Innovation Award at NRC and taking 2nd place in our weight class at RoboGames." +
					"\n\n hstart Video hend" +
					"See the linkstart href=https://youtu.be/CH-LgnNnuQQ hrefend Video linkend here." +
					"paraend",
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
					"The front side of the headset features an expansion bay with a USB port embedded into the plastic. " +
					"While there were some online modules, some with LED and some with fans in them, I decided to try to design my own. " +
					"I grabbed the calipers and made some educated guesses on curvatures, clearances and dimensions. " +
					"\n\n hstart Design hend" +
					"Due to the tight packaging of the enclosed area as well as a limited height, it was proved to be a difficult engineering problem. " +
					"I selected a fan, " +
					"linkstart href=https://www.delta-fan.com/products/BFB0305MA-CR00.html hrefend Delta Electronics BFB0305MA-Alinkend," +
					" that had the correct profile that could fit within the enclosed area and blow sideways into a slotted area, pushing pressure into the electronics enclosure. " +
					"I designed a board that would surround the fan and provide a mounting profile but struggled with the height of the fan compared to the USB port. " +
					"A small USB interface board with a vertical header allowed the fan holder to float above the USB interface. " +
					"\n\n hstart Results hend" +
					"Overall, the design provided a little bit of airflow into the enclosure and lowered the temperature of my face during long playtimes. " +
					"It was a project I would consider a success." +
					"imgstart IndexFrunk/IndexFrunkInstalled.jpg imgend" +
					"paraend",
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
			ProjectDescription = "hstart Project Description hend " +
			"Designed as part of a contract engineering assignment, the EDM PSU was conceived as a variable AC/DC power supply intended for use with a CNC controlled manufacturing machine." +
			"\n\n hstart Design hend" +
			"Providing constant current / constant voltage over the range of 10-100V and 5mA - 10A. It was enclosed in a industrial cabinet and featured custom circuit boards for the AC/DC conversion and a second custom PCB for the HMI.  \n\n" +
			"While never fully validated by the client, and not short of its limitations, it was a challenging project that functioned well during bench testing." +
            "paraend",
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
			ProjectDescription = "hstart Project Description hend " +
				"A small team of The University of Akron engineering students designed/constructed a handi-capable assisted bicycle that helped a local boy with spinocerebellar ataxia able to ride. " +
					
				"\n\n hstart Design hend" +
				"Westley had difficulty controlling the bicycle brakes by pedaling backward, so we engineered a motor to pull a handbrake for him with the press of a button. " +
				"In addition, 3D printed pedal adapters were made to strap his feet to the pedals to help him maintain control and balance while riding. " +

				"\n\n hstart My Role hend" +
				"I was involved in the design of the electrically assisted braking mechanism consisting of a power supply, servo for pulling the brake cable and a power recovering generator. " +
				"The battery was modestly sized so a wheel driven generator and a circuit to charge the batteries from it helped to extend the life of the batteries. " +
				"In addition to all of the electrical systems, I also created the software that controlled and monitored all of the systems." +

				"\n\n hstart Software hend" +
				"View the linkstart href=https://bitbucket.org/zkilburn/workspace/projects/BBB hrefend Repositorylinkend" + 
			
				"\n\n hstart Article hend" +
				"View the linkstart href=https://www.thepostnewspapers.com/norton/local_news/students-help-design-assemble-bike-for-norton-boy/article_7bab3de4-eaf0-575a-aa62-1edae7f0d13b.html hrefend Newspaper Article linkend" +
				"paraend",
            ProjectMainImage = "BMEBike/BMEBike.jpg",

		};

		public static readonly Project NASARMC = new()
		{
			ProjectTitle = "NASA RMC",
			ProjectHref = "projects/NASARMC",
			ProjectMainImage = "CHRISTEE/CHRISTEE.png",
			ProjectMainVideoLink = "https://youtube.com/embed/ltmr64m7aK0",
			ProjectDate = "2013-2018",
			ProjectFacebook = "https://www.facebook.com/UANASArobotics",
			ProjectDescription = "hstart Project Description hend" +
					"The concept for the competition was to design, build and compete with a mining robot built in the spirit of NASA's goal to mine elements from the surface of other planets prior to humans arriving. " +
					"Since there are elements trapped within the regolith, robots could harvest these elements for use when humans arrive. " +
					"These elements include fuels that could be used for rockets, air to breath and water to drink." +	
					"\n\n hstart The Competitionhend" +
					"The arena was an environmentally controlled space with simulated regolith that is very abrasive and difficult to manage when it comes to electronics and moving components. " +
					"Remotely piloting the robot was a threshold with the objective being an autonomous operation. " +
					"This was due to the delay for communications that would occur when interfacing with a system on another planet. "+
					"\n\n hstart My Role hend" +
					"I spent 5 years both as a member of the team and as the team leader. " +
					"I had a long run with the team, learning a lot about software, electrical and mechanical integration. " +
					"In addition to practical design experience, I got a crash course in leadership, leading up to 60 members during a single year." +
					"\n\n hstart STACEE - 2013 - 2014hend" +
					"As a software team member during my first year of competition, I got acquainted with the team and it workings. " +
					"The team was awarded 10th place overall during the competition." +
					"\n\n hstart CHRISTEE - 2014 - 2015hend" +
					"My second year I took over the development of the software as the leader of the software team. " +
					"Our goal was to get the autonomous operation functional, and we made great strides by enabling autonomous sub-routines in the robot to do more of the complex tasks. " +
					"I was able to bring the group together and lead them to a 2nd place finish, the best of any year prior and to come in my time. " +
					"\n\n hstart CHRISTEE - 2015 - 2016hend" +
					"Upon taking over the team, I had to learn how to manage personnel, navigate the university's inner workings and motivate a group of volunteer students. " +
					"Continuing the development on CHRISTEE, the design was polished, and a second design was started in the background. " +
					"Due to extensive work on the communications protocol, we were awarded the Effective Communications Award for our minimal use of bandwidth during the competition round. " +
					"The University of Akron placed 12th overall, while grabbing 5th place for the Systems Engineering Paper. " +
					"\n\n hstart SPACEE - 2016 - 2017hend" +
					"The team began attempting to overhaul the design that we had been recycling to introduce some new and novel ideas. " +
					"The University of Akron placed 10th overall. " +
					"\n\n hstart ROCKEE - 2017 - 2018hend" +
					"I relinquished my role as team leader to allow for younger team members to take over before I graduated to provide guidance and shift control to the younger group before I left the team. " +
					"The University of Akron team was awarded 5th place overall in the competition." +
					"\n\n hstart Software hend" +
					"View the linkstart href=https://bitbucket.org/zkilburn/workspace/projects/NR hrefend Repositorylinkend" +
					"paraend",

            SubPages = new List<ProjectSubPage>()
			{
				new ProjectSubPage()
				{
					SubPageTitle = "CHRISTEE",
					SubPageImage= "CHRISTEE/CHRISTEE.png",
					SubPageDescription="hstart Design hend" +
					"Sharing many of the design concepts from her sister STACEE, CHRISTEE (Celestial High-Powered Robotic Intelligence System Timely Excavating Elements) would also feature a track for mobility. " +
					"The bucket design also remained a staple of the design due to its simplicity and low failure rate. " +
					"Slightly tuning the depth of the bucket and the addition of a plow were the biggest changes from the previous design." +
					"\n\n hstart My Role hend" +
					"During 2014, my second year, I was the lead software developer, and worked to introduce some autonomous features and improve the communications protocol with the robot. " +
					"Following that year, 2015 would be my first leadership experience, where I led a group of roughly 30 members to NASA's Kennedy Space Center for competition." +
					"\n\n hstart Competition Results hend" +
					"During the 2014-2015 year, my work on the communication and autonomy subsystems led to the team being awarded the Effective Communications Award, having the lowest bandwidth utilized across all teams. " +
					"My first year as the team lead, the team and CHRISTEE performed extremely well, and we took home 2nd place out of 50 teams across the nation. " +
					"\n\n hstart Interview hend" +
					"View the linkstart href=https://www.youtube.com/watch?v=tCAUiAGvK-Q hrefend Interviewlinkend"+
					"\n\n hstart Software hend" +
					"View the linkstart href=https://bitbucket.org/zkilburn/workspace/projects/NR hrefend Repositorylinkend"+
					"paraend",



                },
				new ProjectSubPage() {
					SubPageTitle = "STACEE",
					SubPageImage= "STACEE/STACEE.png",
					SubPageDescription="hstart Design hend" +
					"Featuring a tracked design, STACEE (Systematic Technical Automaton Collecting Extraterrestrial Elements) would have a wide surface area of contact, allowing her to stay on top of the somewhat fluid terrain. " +
					"A simple bucket allowed for minimal dynamic systems that would introduce points of failure. " +
					"Once dirt was placed in the bucket, it could continue to elevate the bucket and dump the material out the backside of the robot, allowing the robot to never make a full rotation during the mining cycle." +
					"\n\n hstart My Role hend" +
					"As my first year of competition, my role was somewhat limited to being a developer for autonomous operation. " +
					"\n\n hstart Software hend" +
					"View the linkstart href=https://bitbucket.org/zkilburn/workspace/projects/NR hrefend Repositorylinkend"+
					"paraend",

                },
			},
		};



		public List<Project> projects { get; set; } = new()
		{
			NASARMC,
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
