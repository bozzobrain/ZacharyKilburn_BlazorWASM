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
		};
		public static readonly Board Z2 = new()
        {
            BoardPN = "Z2",
            BoardTitle = "Brainbox",
			BoardHref = "boards/Z2",
			BoardMainImage = "Z2-Brainbox.png",
            BoardPDF = "Z2 - Brainbox.pdf",
        };
		public static readonly Board Z3 = new()
        {
            BoardPN = "Z3",
            BoardTitle = "Neopixel",
			BoardHref = "boards/Z3",
			BoardMainImage = "Z3-NeopixelBoard.png",
            BoardPDF = "Z3 - Neopixel Board.pdf",
        };
		public static readonly Board Z4 = new()
        {
            BoardPN = "Z4",
            BoardTitle = "PIC32 Board",
			BoardHref = "boards/Z4",
			BoardMainImage = "Z4-PIC32Board.png",
            BoardPDF = "Z4 - PIC32 Board.pdf",
        };
		public static readonly Board Z5 = new()
        {
            BoardPN = "Z5",
            BoardTitle = "RF Amp",
			BoardHref = "boards/Z5",
			BoardMainImage = "Z5-RFAmp.png",
            BoardPDF = "Z5 - RF Amp.pdf",
			BoardDescription =
			"A research concept piece that allows for amplification of RF signals\n" +
			"for monitoring with an embedded controller.\n" +
			"\n" +
			"More of a curiousity and fun project that never really went into\n" +
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
			"Board was never actually ordered, due to cost and lack of pushing\n" +
			"the project further.\n" +
			"\n" +
			"This board would adapt to 16 of the Z5 - RF Amp boards in an array to measure\n" +
			"RF signals in a 2D plane, providing an 4x4 pixel image of RF power\n" +
			"\n" +
			"Still very curious if there would be any value in this, especially without\n" +
			"A super fast sampling front end to actually gather any meaningful data",
		};
		public static readonly Board Z7 = new()
        {
            BoardPN = "Z7",
            BoardTitle = "Level Translator",
			BoardHref = "boards/Z7",
			BoardMainImage = "Z7-LevelTranslator.png",
            BoardPDF = "Z7 - Level Translator.pdf",
			BoardDescription =
			"This board has actually come in handy multiple times when needing to level translate signals\n" +
			"between different voltage domains on an odds and ends project\n" +
			"\n" +
			"Supporting 4 channels of up-converting from XX volts up to 5V signals with 16mA\n" +
			"of drive current, the Level Translator board measures XXinches by XX inches\n" +
			"making it an awesome tool to have lying around when you get into a bind.\n" +
			"\n" +
			"This board also can satisfy the need to buffer a weak signal for driving\n" +
			"a heavier load.",
		};
		public static readonly Board Z12 = new()
        {
            BoardPN = "Z12",
            BoardTitle = "Neopixel V2",
			BoardHref = "boards/Z12",
			BoardMainImage = "Z12-NeopixelBoardV2.png",
            BoardPDF = "Z12 - Neopixel Board V2.pdf",
			BoardDescription =
			"The second generation Neopixel driving board with many new features\n" +
			"The board was actually never procured, and there are likely show stopping issues\n" +
			"with it that have yet to be discovered",
		};
		public static readonly Board Z18 = new()
        {
            BoardPN = "Z18",
            BoardTitle = "Index Frunk Fan",
			BoardHref = "boards/Z18",
			BoardMainImage = "Z18-IndexFrunkFan.png",
            BoardPDF = "Z18 - Index Frunk Fan.pdf",
        };
		public static readonly Board Z19 = new()
        {
            BoardPN = "Z19",
            BoardTitle = "Index Frunk Power",
			BoardHref = "boards/Z19",
			BoardMainImage = "Z19-IndexFrunkPower.png",
            BoardPDF = "Z19 - Index Frunk Power.pdf",
        };
		public static readonly Board Z20 = new()
        {
            BoardPN = "Z20",
            BoardTitle = "ESP Breakout",
			BoardHref = "boards/Z20",
			BoardMainImage = "Z20-ESPBreakout.png",
            BoardPDF = "Z20 - ESP32 Breakout.pdf",
        };
		public static readonly Board Z21 = new()
        {
            BoardPN = "Z21",
            BoardTitle = "ESP Holder",
			BoardHref = "boards/Z21",
			BoardMainImage = "Z21-ESPHolder.png",
            BoardPDF = "Z21 - ESP32 Holder.pdf",
        };
		public static readonly Board Z22 = new()
        {
            BoardPN = "Z22",
            BoardTitle = "Relay Platform",
			BoardHref = "boards/Z22",
			BoardMainImage = "Z22-RelayPlatform.png",
            BoardPDF = "Z22 - Relay Platform.pdf",
			Projects = new()
			{
				ProjectLoader.FireworkProject,
			},
		};
		public static readonly Board Z23 = new()
        {
            BoardPN = "Z23",
            BoardTitle = "Quick Connect",
			BoardHref = "boards/Z23",
			BoardMainImage = "Z23-QuickConnect2Pos.png",
            BoardPDF = "Z23 - Quick Connect 2Pos.pdf",
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
            "This 7-Segment Display was an unconventional iteration of the LED Digit Board\n " +
            "with the functional change being the brightness of the LEDs\n" +
            "\n" +
            "When it comes to viewing the 7-Segment digit in a well lit environment it\n" +
            "would be difficult to see the segments using the prior versions SMT LEDs\n" +
            "\n" +
            "By changing to through hole LEDs, bending them with a jig and inserting from the\n" +
            "rear of the board, it was possible to keep all of the existing mechanical structure\n" +
            "and simply drop in the new revision into the existing product.",
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
