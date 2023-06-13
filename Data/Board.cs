namespace ZacharyKilburn_BlazorWASM.Data
{
    public class Board
    {
		public string BoardPN { get; set; } = string.Empty;
        public string BoardTitle { get; set; } = string.Empty;
        public string BoardDescription { get; set; } = string.Empty;
        public string BoardHref { get; set; } = string.Empty;
        public string BoardMainImage { get; set; } = string.Empty;
        public string BoardPDF { get; set; } = string.Empty;
        public List<Project>? Projects { get; set; }
    }

    public class BoardLoader
	{
		public static readonly Board Z1 = new()
		{
			BoardPN = "Z1",
			BoardTitle = "Power Supply",
			BoardHref = "boards/Z1",
			BoardMainImage = "Z1-PowerSupply.png",
			BoardPDF = "Z1 - PowerSupply.pdf",
            BoardDescription =
            "This power supply board... makes me very nostaglic for knowing as little as I did at the time. While this board did work, its approach was very different to the approach that I would take considering the 5 years of experience that I have now." +
			" Somehow this board did not immediately blow up while testing. Anyway, I digress. AC input to the board was filtered and rectified into a large capacitor bank and then fed to a buck regulator that could be controlled by " +
            "linkstart href=boards/Z2 hrefend Z2 - Brainbox linkend " +
			". " +
			"Its intention was to be the power supply of an EDM CNC unit. Probably one of the scariest devices I have built and it never did get its chance to do some serious regulation and power delivery. The YouTuber that this was created for is still making videos," +
			"so I am very sure he is still alive, but the unit never did get the chance to have its own video. We all have to start our design experience somewhere.",
            Projects = new()
            {
                ProjectLoader.EDMPowerSupply,
            },
        };
		public static readonly Board Z2 = new()
        {
            BoardPN = "Z2",
            BoardTitle = "Brainbox",
			BoardHref = "boards/Z2",
			BoardMainImage = "Z2-Brainbox.png",
            BoardPDF = "Z2 - Brainbox.pdf",
            BoardDescription =
            "This board was build with purpose in mind. As both a HMI device and control unit for the EDM Power Supply project, this board served as the face of the enclosure. It also interfaced with the " +
            "linkstart href=boards/Z1 hrefend Z1 - Power Supply board linkend" +
			" to " +
			"gather feedback and close the loop for the constant voltage and constant current control.",
            Projects = new()
            {
                ProjectLoader.EDMPowerSupply,
            },
        };
		public static readonly Board Z3 = new()
        {
            BoardPN = "Z3",
            BoardTitle = "Neopixel",
			BoardHref = "boards/Z3",
			BoardMainImage = "Z3-NeopixelBoard.png",
            BoardPDF = "Z3 - Neopixel Board.pdf",
            BoardDescription =
            "The initial NeoPixel driving board, build on the Arduino platform architecture. It has served its purpose being a quick time-to-market development platform that for some reason I tend to use in my designs, " +
			"despite my general disagreement that Arduino is a true engineering platform. It definitely has its place. This board also accepts a microphone input and amplifier front end to allow for timing NeoPixel effects with" +
			" incomming audio patterns. Although anything more complicated seriously suffered from the limitations of the AVR core, the " +
            "linkstart href=boards/Z4 hrefend Z4 - PIC32 board linkend" +
			"solved some of these problems.",
        };
		public static readonly Board Z4 = new()
        {
            BoardPN = "Z4",
            BoardTitle = "PIC32 Board",
			BoardHref = "boards/Z4",
			BoardMainImage = "Z4-PIC32Board.png",
            BoardPDF = "Z4 - PIC32 Board.pdf",
            BoardDescription =
            "This board was build to support some of the NeoPixel audio sampling workload I was playing with on the Arduino platform. " +
			"It turns out that attempting to push 16MHz architectures to perform FFT maths can be a major bottleneck in your development process. " +
			"With the PIC32s internal floating point ALU, it really accelerated the computation rate for realtime FFT approximations with its analog front end. " +
			"The board was also build to be generic enough to provide a platform for developing any other crazy ideas that came to mind.",
        };
		public static readonly Board Z5 = new()
        {
            BoardPN = "Z5",
            BoardTitle = "RF Amp",
			BoardHref = "boards/Z5",
			BoardMainImage = "Z5-RFAmp.png",
            BoardPDF = "Z5 - RF Amp.pdf",
			BoardDescription =
			"A research concept piece that allows for amplification of RF signals " +
			"for monitoring with an embedded controller. " +
			"More of a curiousity and fun project that never really went into " +
			"a finalized version. Maybe more usage coming in the future",
		};
		public static readonly Board Z6 = new()
        {
            BoardPN = "Z6",
            BoardTitle = "RF Amp Array",
			BoardHref = "boards/Z6",
			BoardMainImage = "Z6-RFAmpArray.png",
            BoardPDF = "Z6 - RF Amp Array Board.pdf",
			BoardDescription =
			"Board was never actually ordered, due to cost and lack of pushing the project further. "+
			"This board would adapt to 16 of the " +
            "linkstart href=boards/Z5 hrefend Z5 - RF Amp boards linkend" +
			" in an array to measure " +
			"RF signals in a 2D plane, providing an 4x4 pixel image of RF power " +
			"Still very curious if there would be any value in this, especially without " +
			"a super fast sampling front end to actually gather any meaningful data",
		};
		public static readonly Board Z7 = new()
        {
            BoardPN = "Z7",
            BoardTitle = "Level Translator",
			BoardHref = "boards/Z7",
			BoardMainImage = "Z7-LevelTranslator.png",
            BoardPDF = "Z7 - Level Translator.pdf",
			BoardDescription =
			"This board has actually come in handy multiple times when needing to level translate signals between different voltage domains on an odds and ends project. " +
			" " +
			"Based on the " +
            "linkstart href=https://www.ti.com/product/SN74LV4T125 hrefend SN74LV4T125 linkend, " +
			"the board supports 4 channels of up-converting from 2 volts up to 5V signals with 16mA of drive current. " +
			"Measuring a meager 1.1\" x 0.74\" makes it an awesome tool to have lying around when you get into a bind. " +
			"I have also found use for this board when I have a weak driving signal that needs to drive a moderate load.",
		};
		public static readonly Board Z12 = new()
        {
            BoardPN = "Z12",
            BoardTitle = "Neopixel V2",
			BoardHref = "boards/Z12",
			BoardMainImage = "Z12-NeopixelBoardV2.png",
            BoardPDF = "Z12 - Neopixel Board V2.pdf",
			BoardDescription =
			"The second generation Neopixel driving board with many new features " +
			"The board was actually never procured, and there are likely show stopping issues " +
			"with it that have yet to be discovered",
		};
		public static readonly Board Z18 = new()
        {
            BoardPN = "Z18",
            BoardTitle = "Index Frunk Fan",
			BoardHref = "boards/Z18",
			BoardMainImage = "Z18-IndexFrunkFan.png",
            BoardPDF = "Z18 - Index Frunk Fan.pdf",
            BoardDescription =
            "Just before 2019's eruption of stay at home happened, I ordered myself a Valve Index VR headset. " +
            "Over the next 2 years I got a lot of time playing some pretty sweaty games. I decided to design and build my own solution for cooling myself during extended play. Combined with " +
            "linkstart href=boards/Z19 hrefend Z19 - Index Frunk Power linkend, " +
            "this design inserts into the front of the index and provides a bit of airflow, benefiting both the electronics in the headset, and the VR players sweaty forehead."
        };
		public static readonly Board Z19 = new()
        {
            BoardPN = "Z19",
            BoardTitle = "Index Frunk Power",
			BoardHref = "boards/Z19",
			BoardMainImage = "Z19-IndexFrunkPower.png",
            BoardPDF = "Z19 - Index Frunk Power.pdf",
            BoardDescription =
            "Just before 2019's eruption of stay at home happened, I ordered myself a Valve Index VR headset. " +
			"Over the next 2 years I got a lot of time playing some pretty sweaty games. I decided to design and build my own solution for cooling myself during extended play. Combined with " +
            "linkstart href=boards/Z18 hrefend Z18 - Index Frunk Fan linkend, " +
			"this design inserts into the front of the index and provides a bit of airflow, benefiting both the electronics in the headset, and the VR players sweaty forehead."
        };
		public static readonly Board Z20 = new()
        {
            BoardPN = "Z20",
            BoardTitle = "ESP Breakout",
			BoardHref = "boards/Z20",
			BoardMainImage = "Z20-ESPBreakout.png",
            BoardPDF = "Z20 - ESP32 Breakout.pdf",
            BoardDescription =
            "This board was intended to be a development platform for some projects that I had been dreaming up involving smart home and other remote control ideas that I had been playing with. Very similar to " +
            "linkstart href=boards/Z21 hrefend Z21 - ESP Holder linkend, " +
			"except that this variant was intended to utilize the SMT package to simplify the BOM cost of the platform. " +
            "I'm 100% sure that I never ordered this, and for that, I feel much shame. It will live on in my data library and my heart. "
        };
		public static readonly Board Z21 = new()
        {
            BoardPN = "Z21",
            BoardTitle = "ESP Holder",
			BoardHref = "boards/Z21",
			BoardMainImage = "Z21-ESPHolder.png",
            BoardPDF = "Z21 - ESP32 Holder.pdf",
            BoardDescription =
            "This board was intended to be a development platform for some projects that I had been dreaming up involving smart home and other remote control ideas that I had been playing with. " +
			"I'm 99% sure that I never ordered this but dont quote me on it. I would have to check the stockroom. "
        };
		public static readonly Board Z22 = new()
        {
            BoardPN = "Z22",
            BoardTitle = "Relay Platform",
			BoardHref = "boards/Z22",
			BoardMainImage = "Z22-RelayPlatform.png",
            BoardPDF = "Z22 - Relay Platform.pdf",
            BoardDescription =
            "Build specifically for the fireworks mortar project, this board was the backbone of the fireworks ignitor. Its job was to take 5V CMOS control signals to actuate relays that would short the battery terminals over a small electric ignitor. While the battery is sure to complain about the sudden short appearing on it for a very brief moment," +
			" it would be relieved a few microseconds later when the filament bursts into sparky flames and opens the circuit. Not sure what the lifetime of these relays will be over time, but surely they are a wear component when it comes to firework goodness.",

            Projects = new()
			{
				ProjectLoader.FireworkProject,
			}
		};
		public static readonly Board Z23 = new()
        {
            BoardPN = "Z23",
            BoardTitle = "Quick Connect",
			BoardHref = "boards/Z23",
			BoardMainImage = "Z23-QuickConnect2Pos.png",
            BoardPDF = "Z23 - Quick Connect 2Pos.pdf",
            BoardDescription =
            "Build specifically for the fireworks mortar project, this small interconnect board provides what was planned to be a rapid connection point for firework ignitors to be connected between reloads of the mortar tubes. " +
			"Hindsight showed that these quick connectors were not as robust as one would have hoped, or nearly as easy to insert wires into when the sun goes down (typically when you are reloading fireworks). A new revision is definitely necessary to improve this in the future, " +
			"but that is what engineering is all about, right?",

            Projects = new()
			{
				ProjectLoader.FireworkProject,
			},
		};
		public static readonly Board Z24 = new()
        {
            BoardPN = "Z24",
            BoardTitle = "Arduino Mega Adapter",
			BoardHref = "boards/Z24",
			BoardMainImage = "Z24-ArduinoMegaAdapter.png",
            BoardPDF = "Z24 - Arduino Mega Adapter.pdf",
            BoardDescription =
            "Somewhat customized for use in the Firework Mortar Launcher, I wanted a way to breakout multiple I/O to a connector that was more robust than jamming 0.1\" dupont leads into an arduino. " +
            "This breakout board provides 30 I/O in a better format using linkstart href=https://www.molex.com/en-us/products/connectors/wire-to-board-connectors/clik-mate-connectors hrefend Molex Clik-Mate linkend connectors, as well as providing the ability to inject power for the" +
            "arduino using a locking connector, another molex favorite, the linkstart href=https://www.molex.com/en-us/products/connectors/wire-to-board-connectors/micro-fit-connectors hrefend Micro-Fit linkend ",

            Projects = new()
			{
				ProjectLoader.FireworkProject,
			},
		};
		public static readonly Board Z25 = new()
        {
            BoardPN = "Z25",
            BoardTitle = "Adafruit Bluefruit Adapter",
			BoardHref = "boards/Z25",
			BoardMainImage = "Z25-AdafruitBluefruitBreakout.png",
            BoardPDF = "Z25 - Adafruit Bluefruit LE UART Breakout Board.pdf",
            BoardDescription =
            "A very simple breakout board to breakout linkstart href=https://www.adafruit.com/product/2479 hrefend Adafruits bluetooth adapter linkend. Need I say anymore? I mean it breaks out the 0.1\" header to something more palatable for use inside of builds. " +
            "I should mentio that I am very partial to the linkstart href=https://www.molex.com/en-us/products/connectors/wire-to-board-connectors/clik-mate-connectors hrefend Molex Clik-Mate linkend connector for its positive locking and reasonable pitch for 24-30AWG.",


            Projects = new()
			{
				ProjectLoader.ScoreboardProject,
				ProjectLoader.FireworkProject,
			},
		};
		public static readonly Board Z26 = new()
        {
            BoardPN = "Z26",
            BoardTitle = "5V DC-DC",
			BoardHref = "boards/Z26",
			BoardMainImage = "Z26-TPS84A20DCDCConverter.png",
            BoardPDF = "Z26 - TPS84A20 DC-DC Converter.pdf",
            BoardDescription =
            "While I have only used this regulator for a single design so far, I was always finding myself needing a 5 volt source from batteries, and was tenative to use USB power banks when I needed higher currents. " +
            "Introducing the linkstart href=https://www.ti.com/product/TPS84A20 hrefend TPS84A20 linkend capable of regulating up to 17 volts down to 5 with a current up to 10A. No more wishing I had more power.. yet." +
			"While its a very simple design, simple is usually better.",


            Projects = new()
			{
				ProjectLoader.ScoreboardProject,
			},
		};
		public static readonly Board Z27 = new()
        {
            BoardPN = "Z27",
            BoardTitle = "7-Seg LED Digit",
			BoardHref = "boards/Z27",
			BoardMainImage = "Z27-LEDDigit.png",
            BoardPDF = "Z27 - LED Digit Board.pdf",
            BoardDescription =
            "For when you want a 7-segment display that is larger than most COTS devices on Digi-Key, just make your own. " +
            "At least thats what I thought when it came to designing my own scoreboard." +
			" Featuring 14 SMT linkstart href=https://www.adafruit.com/product/1655 hrefend NeoPixel 5050 RGB LEDs linkend, each of the segments of this 7-segment LED has 2 light sources that can provide any color. " +
			"With two connectors allowing for daisy channing panels, as long as you have the current to support its operation, you can have as many 6in (150mm) digits you would like!",

            Projects = new()
			{
				ProjectLoader.ScoreboardProject,
			},
		};
		public static readonly Board Z28 = new()
        {
            BoardPN = "Z28",
            BoardTitle = "7-Seg LED Digit TH",
			BoardHref = "boards/Z28",
			BoardMainImage = "Z28-LEDDigitTH.png",
            BoardPDF = "Z28 - LED Digit TH Board.pdf",
			BoardDescription = 
            "This 7-Segment Display was an unconventional iteration of the LED Digit Board  " +
            "with the functional change being the brightness of the LEDs. " +
			"Based on the linkstart href=https://cdn-shop.adafruit.com/datasheets/WS2811.pdf hrefend WS2811 linkend chip which is the same chipset embedded into the NeoPixel LEDs used in " +
            "linkstart href=boards/Z27 hrefend Z27 - LED Digit Board linkend" +
            " " +
            "When it comes to viewing the 7-Segment digit in a well lit environment it " +
            "would be difficult to see the segments using the prior versions SMT LEDs " +
            " " +
            "By changing to through hole LEDs, bending them with a jig and inserting from the " +
            "rear of the board, it was possible to keep all of the existing mechanical structure " +
            "and simply drop in the new revision into the existing product." +
            "",
            Projects = new()
            {
                ProjectLoader.ScoreboardProject,
            },
		};
		public static List<Board> Boards { get; set; } = new()
        {
			Z28,
			Z27,
			Z26,
			Z25,
			Z24,
			Z23,
			Z22,
			Z21,
			Z20,
			Z19,
			Z18,
			Z12,
			Z7,
			Z6,
			Z5,
			Z4,
			Z3,
			Z2,
			Z1,

        };
		public static Board? GetBoardByHref(string href)
		{
			return Boards.Where(p => p.BoardHref.Contains(href)).FirstOrDefault();
		}
		public static Board? GetBoardByPN(string PN)
		{
			return Boards.Where(p => p.BoardPN == PN).FirstOrDefault();
		}
	}
}
