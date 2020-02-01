using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmFrontEnd
{
	class PaletteHelper
	{
		public static BindingList<FormPalette> BuiltInPalettes()
		{
			return new BindingList<FormPalette>()
			{
				new FormPalette()
				{
					Name = "ib_jul01_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =  194, G =   1, B =   1},
						new PaletteEntry() { Step = 94, R =    1, G =  29, B =  18},
						new PaletteEntry() { Step = 132, R =   57, G = 131, B =  28},
						new PaletteEntry() { Step = 255, R =  113, G =   1, B =   1},
					}
				},

				new FormPalette()
				{
					Name = "es_vintage_57_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R = 2, G =   1, B =   1},
						new PaletteEntry() { Step = 53, R = 18, G =   1, B =   0},
						new PaletteEntry() { Step = 104, R = 69, G =  29, B =   1},
						new PaletteEntry() { Step = 153, R =  167, G = 135, B =  10},
						new PaletteEntry() { Step = 255, R =   46, G =  56,  B = 4},
					}
				},

				new FormPalette()
				{
					Name = "es_vintage_01_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =    4, G =   1, B =  1},
						new PaletteEntry() { Step = 51, R =   16, G =   0, B =   1},
						new PaletteEntry() { Step = 76, R =   97, G = 104, B =   3},
						new PaletteEntry() { Step = 101, R =  255, G = 131, B =  19},
						new PaletteEntry() { Step = 127, R =   67, G =   9, B =   4},
						new PaletteEntry() { Step = 153, R =   16, G =   0, B =   1},
						new PaletteEntry() { Step = 229, R =    4, G =   1, B =   1},
						new PaletteEntry() { Step = 255, R =    4, G =   1, B =   1},
					}
				},

				new FormPalette()
				{
					Name = "es_rivendell_15_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =    1, G =  14, B =   5},
						new PaletteEntry() { Step = 101, R =   16, G =  36, B =  14},
						new PaletteEntry() { Step = 165, R =   56, G =  68, B =  30},
						new PaletteEntry() { Step = 242, R =  150, G = 156, B =  99},
						new PaletteEntry() { Step = 255, R =  150, G = 156, B =  99},
					}
				},

				new FormPalette()
				{
					Name = "rgi_15_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =    4, G =   1, B =  31},
						new PaletteEntry() { Step = 31, R =   55, G =   1, B =  16},
						new PaletteEntry() { Step = 63, R =  197, G =   3, B =   7},
						new PaletteEntry() { Step = 95, R =   59, G =   2, B =  17},
						new PaletteEntry() { Step = 127, R =    6, G =   2, B =  34},
						new PaletteEntry() { Step = 159, R =   39, G =   6, B =  33},
						new PaletteEntry() { Step = 191, R =  112, G =  13, B =  32},
						new PaletteEntry() { Step = 223, R =   56, G =   9, B =  35},
						new PaletteEntry() { Step = 255, R =   22, G =   6, B =  38},
					}
				},

				new FormPalette()
				{
					Name = "retro2_16_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =  188, G = 135, B =   1},
						new PaletteEntry() { Step = 255, R =   46, G =   7, B =   1},
					}
				},

				new FormPalette()
				{
					Name = "Analogous_1_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =    3, G =   0, B = 255},
						new PaletteEntry() { Step = 63, R =   23, G =   0, B = 255},
						new PaletteEntry() { Step = 127, R =   67, G =   0, B = 255},
						new PaletteEntry() { Step = 191, R =  142, G =   0, B =  45},
						new PaletteEntry() { Step = 255, R =  255, G =   0, B =   0},
					}
				},

				new FormPalette()
				{
					Name = "es_pinksplash_08_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =  126, G =  11, B = 255},
						new PaletteEntry() { Step = 127, R =  197, G =   1, B =  22},
						new PaletteEntry() { Step = 175, R =  210, G = 157, B = 172},
						new PaletteEntry() { Step = 221, R =  157, G =   3, B = 112},
						new PaletteEntry() { Step = 255, R =  157, G =   3, B = 112},
					}
				},

				new FormPalette()
				{
					Name = "es_pinksplash_07_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =  229, G =   1, B =   1},
						new PaletteEntry() { Step = 61, R =  242, G =   4, B =  63},
						new PaletteEntry() { Step = 101, R =  255, G =  12, B = 255},
						new PaletteEntry() { Step = 127, R =  249, G =  81, B = 252},
						new PaletteEntry() { Step = 153, R =  255, G =  11, B = 235},
						new PaletteEntry() { Step = 193, R =  244, G =   5, B =  68},
						new PaletteEntry() { Step = 255, R =  232, G =   1, B =   5},
					}
				},

				new FormPalette()
				{
					Name = "Coral_reef_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =   40, G = 199, B = 197},
						new PaletteEntry() { Step = 50, R =   10, G = 152, B = 155},
						new PaletteEntry() { Step = 96, R =    1, G = 111, B = 120},
						new PaletteEntry() { Step = 96, R =   43, G = 127, B = 162},
						new PaletteEntry() { Step = 139, R =   10, G =  73, B = 111},
						new PaletteEntry() { Step = 255, R =    1, G =  34, B =  71},
					}
				},

				new FormPalette()
				{
					Name = "es_ocean_breeze_068_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =  100, G = 156, B = 153},
						new PaletteEntry() { Step = 51, R =    1, G =  99, B = 137},
						new PaletteEntry() { Step = 101, R =    1, G =  68, B =  84},
						new PaletteEntry() { Step = 104, R =   35, G = 142, B = 168},
						new PaletteEntry() { Step = 178, R =    0, G =  63, B = 117},
						new PaletteEntry() { Step = 255, R =    1, G =  10, B =  10},
					}
				},

				new FormPalette()
				{
					Name = "es_ocean_breeze_036_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =    1, G =   6, B =   7},
						new PaletteEntry() { Step = 89, R =    1, G =  99, B = 111},
						new PaletteEntry() { Step = 153, R =  144, G = 209, B = 255},
						new PaletteEntry() { Step = 255, R =    0, G =  73, B =  82},
					}
				},

				new FormPalette()
				{
					Name = "departure_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =    8, G =   3, B =   0},
						new PaletteEntry() { Step = 42, R =   23, G =   7, B =   0},
						new PaletteEntry() { Step = 63, R =   75, G =  38, B =   6},
						new PaletteEntry() { Step = 84, R =  169, G =  99, B =  38},
						new PaletteEntry() { Step = 106, R =  213, G = 169, B = 119},
						new PaletteEntry() { Step = 116, R =  255, G = 255, B = 255},
						new PaletteEntry() { Step = 138, R =  135, G = 255, B = 138},
						new PaletteEntry() { Step = 148, R =   22, G = 255, B =  24},
						new PaletteEntry() { Step = 170, R =    0, G = 255, B =   0},
						new PaletteEntry() { Step = 191, R =    0, G = 136, B =   0},
						new PaletteEntry() { Step = 212, R =    0, G =  55, B =   0},
						new PaletteEntry() { Step = 255, R =    0, G =  55, B =   0},
					}
				},

				new FormPalette()
				{
					Name = "es_landscape_64_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =    0, G =   0, B =   0},
						new PaletteEntry() { Step = 37, R =    2, G =  25, B =   1},
						new PaletteEntry() { Step = 76, R =   15, G = 115, B =   5},
						new PaletteEntry() { Step = 127, R =   79, G = 213, B =   1},
						new PaletteEntry() { Step = 128, R =  126, G = 211, B =  47},
						new PaletteEntry() { Step = 130, R =  188, G = 209, B = 247},
						new PaletteEntry() { Step = 153, R =  144, G = 182, B = 205},
						new PaletteEntry() { Step = 204, R =   59, G = 117, B = 250},
						new PaletteEntry() { Step = 255, R =    1, G =  37, B = 192},
					}
				},

				new FormPalette()
				{
					Name = "es_landscape_33_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =    1, G =   5, B =   0},
						new PaletteEntry() { Step = 19, R =   32, G =  23, B =   1},
						new PaletteEntry() { Step = 38, R =  161, G =  55, B =   1},
						new PaletteEntry() { Step = 63, R =  229, G = 144, B =   1},
						new PaletteEntry() { Step = 66, R =   39, G = 142, B =  74},
						new PaletteEntry() { Step = 255, R =    1, G =   4, B =   1},
					}
				},

				new FormPalette()
				{
					Name = "rainbowsherbet_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =  255, G =  33, B =   4},
						new PaletteEntry() { Step = 43, R =  255, G =  68, B =  25},
						new PaletteEntry() { Step = 86, R =  255, G =   7, B =  25},
						new PaletteEntry() { Step = 127, R =  255, G =  82, B = 103},
						new PaletteEntry() { Step = 170, R =  255, G = 255, B = 242},
						new PaletteEntry() { Step = 209, R =   42, G = 255, B =  22},
						new PaletteEntry() { Step = 255, R =   87, G = 255, B =  65},
					}
				},

				new FormPalette()
				{
					Name = "gr65_hult_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =  247, G = 176, B = 247},
						new PaletteEntry() { Step = 48, R =  255, G = 136, B = 255},
						new PaletteEntry() { Step = 89, R =  220, G =  29, B = 226},
						new PaletteEntry() { Step = 160, R =    7, G =  82, B = 178},
						new PaletteEntry() { Step = 216, R =    1, G = 124, B = 109},
						new PaletteEntry() { Step = 255, R =    1, G = 124, B = 109},
					}
				},

				new FormPalette()
				{
					Name = "gr64_hult_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =    1, G = 124, B = 109},
						new PaletteEntry() { Step = 66, R =    1, G =  93, B =  79},
						new PaletteEntry() { Step = 104, R =   52, G =  65, B =   1},
						new PaletteEntry() { Step = 130, R =  115, G = 127, B =   1},
						new PaletteEntry() { Step = 150, R =   52, G =  65, B =   1},
						new PaletteEntry() { Step = 201, R =    1, G =  86, B =  72},
						new PaletteEntry() { Step = 239, R =    0, G =  55, B =  45},
						new PaletteEntry() { Step = 255, R =    0, G =  55, B =  45},
					}
				},

				new FormPalette()
				{
					Name = "GMT_drywet_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =   47, G =  30, B =   2},
						new PaletteEntry() { Step = 42, R =  213, G = 147, B =  24},
						new PaletteEntry() { Step = 84, R =  103, G = 219, B =  52},
						new PaletteEntry() { Step = 127, R =    3, G = 219, B = 207},
						new PaletteEntry() { Step = 170, R =    1, G =  48, B = 214},
						new PaletteEntry() { Step = 212, R =    1, G =   1, B = 111},
						new PaletteEntry() { Step = 255, R =    1, G =   7, B =  33},
					}
				},

				new FormPalette()
				{
					Name = "ib15_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =  113, G =  91, B = 147},
						new PaletteEntry() { Step = 72, R =  157, G =  88, B =  78},
						new PaletteEntry() { Step = 89, R =  208, G =  85, B =  33},
						new PaletteEntry() { Step = 107, R =  255, G =  29, B =  11},
						new PaletteEntry() { Step = 141, R =  137, G =  31, B =  39},
						new PaletteEntry() { Step = 255, R =   59, G =  33, B =  89},
					}
				},

				new FormPalette()
				{
					Name = "Fuschia_7_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =   43, G =   3, B = 153},
						new PaletteEntry() { Step = 63, R =  100, G =   4, B = 103},
						new PaletteEntry() { Step = 127, R =  188, G =   5, B =  66},
						new PaletteEntry() { Step = 191, R =  161, G =  11, B = 115},
						new PaletteEntry() { Step = 255, R =  135, G =  20, B = 182},
					}
				},

				new FormPalette()
				{
					Name = "es_emerald_dragon_08_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =   97, G = 255, B =   1},
						new PaletteEntry() { Step = 101, R =   47, G = 133, B =   1},
						new PaletteEntry() { Step = 178, R =   13, G =  43, B =   1},
						new PaletteEntry() { Step = 255, R =    2, G =  10, B =   1},
					}
				},

				new FormPalette()
				{
					Name = "lava_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =    0, G =   0, B =   0},
						new PaletteEntry() { Step = 46, R =   18, G =   0, B =   0},
						new PaletteEntry() { Step = 96, R =  113, G =   0, B =   0},
						new PaletteEntry() { Step = 108, R =  142, G =   3, B =   1},
						new PaletteEntry() { Step = 119, R =  175, G =  17, B =   1},
						new PaletteEntry() { Step = 146, R =  213, G =  44, B =   2},
						new PaletteEntry() { Step = 174, R =  255, G =  82, B =   4},
						new PaletteEntry() { Step = 188, R =  255, G = 115, B =   4},
						new PaletteEntry() { Step = 202, R =  255, G = 156, B =   4},
						new PaletteEntry() { Step = 218, R =  255, G = 203, B =   4},
						new PaletteEntry() { Step = 234, R =  255, G = 255, B =   4},
						new PaletteEntry() { Step = 244, R =  255, G = 255, B =  71},
						new PaletteEntry() { Step = 255, R =  255, G = 255, B = 255},
					}
				},

				new FormPalette()
				{
					Name = "fire_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =    1, G =   1, B =   0},
						new PaletteEntry() { Step = 76, R =   32, G =   5, B =   0},
						new PaletteEntry() { Step = 146, R =  192, G =  24, B =   0},
						new PaletteEntry() { Step = 197, R =  220, G = 105, B =   5},
						new PaletteEntry() { Step = 240, R =  252, G = 255, B =  31},
						new PaletteEntry() { Step = 250, R =  252, G = 255, B = 111},
						new PaletteEntry() { Step = 255, R =  255, G = 255, B = 255},
					}
				},

				new FormPalette()
				{
					Name = "Colorfull_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =   10, G =  85, B =   5},
						new PaletteEntry() { Step = 25, R =   29, G = 109, B =  18},
						new PaletteEntry() { Step = 60, R =   59, G = 138, B =  42},
						new PaletteEntry() { Step = 93, R =   83, G =  99, B =  52},
						new PaletteEntry() { Step = 106, R =  110, G =  66, B =  64},
						new PaletteEntry() { Step = 109, R =  123, G =  49, B =  65},
						new PaletteEntry() { Step = 113, R =  139, G =  35, B =  66},
						new PaletteEntry() { Step = 116, R =  192, G = 117, B =  98},
						new PaletteEntry() { Step = 124, R =  255, G = 255, B = 137},
						new PaletteEntry() { Step = 168, R =  100, G = 180, B = 155},
						new PaletteEntry() { Step = 255, R =   22, G = 121, B = 174},
					}
				},

				new FormPalette()
				{
					Name = "Magenta_Evening_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =   71, G =  27, B =  39},
						new PaletteEntry() { Step = 31, R =  130, G =  11, B =  51},
						new PaletteEntry() { Step = 63, R =  213, G =   2, B =  64},
						new PaletteEntry() { Step = 70, R =  232, G =   1, B =  66},
						new PaletteEntry() { Step = 76, R =  252, G =   1, B =  69},
						new PaletteEntry() { Step = 108, R =  123, G =   2, B =  51},
						new PaletteEntry() { Step = 255, R =   46, G =   9, B =  35},
					}
				},

				new FormPalette()
				{
					Name = "Pink_Purple_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =   19, G =   2, B =  39},
						new PaletteEntry() { Step = 25, R =   26, G =   4, B =  45},
						new PaletteEntry() { Step = 51, R =   33, G =   6, B =  52},
						new PaletteEntry() { Step = 76, R =   68, G =  62, B = 125},
						new PaletteEntry() { Step = 102, R =  118, G = 187, B = 240},
						new PaletteEntry() { Step = 109, R =  163, G = 215, B = 247},
						new PaletteEntry() { Step = 114, R =  217, G = 244, B = 255},
						new PaletteEntry() { Step = 122, R =  159, G = 149, B = 221},
						new PaletteEntry() { Step = 149, R =  113, G =  78, B = 188},
						new PaletteEntry() { Step = 183, R =  128, G =  57, B = 155},
						new PaletteEntry() { Step = 255, R =  146, G =  40, B = 123},
					}
				},

				new FormPalette()
				{
					Name = "Sunset_Real_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =  120, G =   0, B =   0},
						new PaletteEntry() { Step = 22, R =  179, G =  22, B =   0},
						new PaletteEntry() { Step = 51, R =  255, G = 104, B =   0},
						new PaletteEntry() { Step = 85, R =  167, G =  22, B =  18},
						new PaletteEntry() { Step = 135, R =  100, G =   0, B = 103},
						new PaletteEntry() { Step = 198, R =   16, G =   0, B = 130},
						new PaletteEntry() { Step = 255, R =    0, G =   0, B = 160},
					}
				},


				new FormPalette()
				{
					Name = "es_autumn_19_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =   26, G =   1, B =   1},
						new PaletteEntry() { Step = 51, R =   67, G =   4, B =   1},
						new PaletteEntry() { Step = 84, R =  118, G =  14, B =   1},
						new PaletteEntry() { Step = 104, R =  137, G = 152, B =  52},
						new PaletteEntry() { Step = 112, R =  113, G =  65, B =   1},
						new PaletteEntry() { Step = 122, R =  133, G = 149, B =  59},
						new PaletteEntry() { Step = 124, R =  137, G = 152, B =  52},
						new PaletteEntry() { Step = 135, R =  113, G =  65, B =   1},
						new PaletteEntry() { Step = 142, R =  139, G = 154, B =  46},
						new PaletteEntry() { Step = 163, R =  113, G =  13, B =   1},
						new PaletteEntry() { Step = 204, R =   55, G =   3, B =   1},
						new PaletteEntry() { Step = 249, R =   17, G =   1, B =   1},
						new PaletteEntry() { Step = 255, R =   17, G =   1, B =   1},
					}
				},

				new FormPalette()
				{
					Name = "BlacK_Blue_Magenta_White_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =    0, G =   0, B =   0},
						new PaletteEntry() { Step = 42, R =    0, G =   0, B =  45},
						new PaletteEntry() { Step = 84, R =    0, G =   0, B = 255},
						new PaletteEntry() { Step = 127, R =   42, G =   0, B = 255},
						new PaletteEntry() { Step = 170, R =  255, G =   0, B = 255},
						new PaletteEntry() { Step = 212, R =  255, G =  55, B = 255},
						new PaletteEntry() { Step = 255, R =  255, G = 255, B = 255},
					}
				},

				new FormPalette()
				{
					Name = "BlacK_Magenta_Red_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =    0, G =   0, B =   0},
						new PaletteEntry() { Step = 63, R =   42, G =   0, B =  45},
						new PaletteEntry() { Step = 127, R =  255, G =   0, B = 255},
						new PaletteEntry() { Step = 191, R =  255, G =   0, B =  45},
						new PaletteEntry() { Step = 255, R =  255, G =   0, B =   0},
					}
				},

				new FormPalette()
				{
					Name = "BlacK_Red_Magenta_Yellow_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =    0, G =   0, B =   0},
						new PaletteEntry() { Step = 42, R =   42, G =   0, B =   0},
						new PaletteEntry() { Step = 84, R =  255, G =   0, B =   0},
						new PaletteEntry() { Step = 127, R =  255, G =   0, B =  45},
						new PaletteEntry() { Step = 170, R =  255, G =   0, B = 255},
						new PaletteEntry() { Step = 212, R =  255, G =  55, B =  45},
						new PaletteEntry() { Step = 255, R =  255, G = 255, B =   0},
					}
				},

				new FormPalette()
				{
					Name = "Blue_Cyan_Yellow_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =    0, G =   0, B = 255},
						new PaletteEntry() { Step = 63, R =    0, G =  55, B = 255},
						new PaletteEntry() { Step = 127, R =    0, G = 255, B = 255},
						new PaletteEntry() { Step = 191, R =   42, G = 255, B =  45},
						new PaletteEntry() { Step = 255, R =  255, G = 255, B =   0},
					}
				},

				new FormPalette()
				{
					Name = "bhw1_greeny_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =    0, G =   0, B =   0},
						new PaletteEntry() { Step = 39, R =    7, G =  55, B =   8},
						new PaletteEntry() { Step = 99, R =   42, G = 255, B =  45},
						new PaletteEntry() { Step = 153, R =    7, G =  55, B =   8},
						new PaletteEntry() { Step = 255, R =    0, G =   0, B =   0},
					}
				},

				new FormPalette()
				{
					Name = "bhw1_26_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =  107, G =   1, B = 205},
						new PaletteEntry() { Step = 35, R =  255, G = 255, B = 255},
						new PaletteEntry() { Step = 73, R =  107, G =   1, B = 205},
						new PaletteEntry() { Step = 107, R =   10, G = 149, B = 210},
						new PaletteEntry() { Step = 130, R =  255, G = 255, B = 255},
						new PaletteEntry() { Step = 153, R =   10, G = 149, B = 210},
						new PaletteEntry() { Step = 170, R =   27, G = 175, B = 119},
						new PaletteEntry() { Step = 198, R =   53, G = 203, B =  56},
						new PaletteEntry() { Step = 207, R =  132, G = 229, B = 135},
						new PaletteEntry() { Step = 219, R =  255, G = 255, B = 255},
						new PaletteEntry() { Step = 231, R =  132, G = 229, B = 135},
						new PaletteEntry() { Step = 252, R =   53, G = 203, B =  56},
						new PaletteEntry() { Step = 255, R =   53, G = 203, B =  56},
					}
				},

				new FormPalette()
				{
					Name = "bhw1_28_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =   75, G =   1, B = 221},
						new PaletteEntry() { Step = 30, R =  252, G =  73, B = 255},
						new PaletteEntry() { Step = 48, R =  169, G =   0, B = 242},
						new PaletteEntry() { Step = 119, R =    0, G = 149, B = 242},
						new PaletteEntry() { Step = 170, R =   43, G =   0, B = 242},
						new PaletteEntry() { Step = 206, R =  252, G =  73, B = 255},
						new PaletteEntry() { Step = 232, R =   78, G =  12, B = 214},
						new PaletteEntry() { Step = 255, R =    0, G = 149, B = 242},
					}
				},

				new FormPalette()
				{
					Name = "bhw2_23_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =    0, G =   0, B =   0},
						new PaletteEntry() { Step = 66, R =   57, G = 227, B = 233},
						new PaletteEntry() { Step = 96, R =  255, G = 255, B =   8},
						new PaletteEntry() { Step = 124, R =  255, G = 255, B = 255},
						new PaletteEntry() { Step = 153, R =  255, G = 255, B =   8},
						new PaletteEntry() { Step = 188, R =   57, G = 227, B = 233},
						new PaletteEntry() { Step = 255, R =    0, G =   0, B =   0},
					}
				},

				new FormPalette()
				{
					Name = "bhw2_22_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =    0, G =   0, B =   0},
						new PaletteEntry() { Step = 99, R =  227, G =   1, B =   1},
						new PaletteEntry() { Step = 130, R =  249, G = 199, B =  95},
						new PaletteEntry() { Step = 155, R =  227, G =   1, B =   1},
						new PaletteEntry() { Step = 255, R =    0, G =   0, B =   0},
					}
				},
				new FormPalette()
				{
					Name = "bhw2_49_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =    9, G =  15, B =  15},
						new PaletteEntry() { Step = 40, R =    0, G =  55, B =  45},
						new PaletteEntry() { Step = 86, R =    9, G =  15, B =  15},
						new PaletteEntry() { Step = 130, R =   29, G =  41, B =  62},
						new PaletteEntry() { Step = 170, R =    9, G =  15, B =  15},
						new PaletteEntry() { Step = 211, R =   64, G =   8, B = 199},
						new PaletteEntry() { Step = 255, R =    6, G =   1, B =  22},
					}
				},

				new FormPalette()
				{
					Name = "bhw2_10_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =    0, G =  12, B =   0},
						new PaletteEntry() { Step = 61, R =  153, G = 239, B = 112},
						new PaletteEntry() { Step = 127, R =    0, G =  12, B =   0},
						new PaletteEntry() { Step = 165, R =  106, G = 239, B =   2},
						new PaletteEntry() { Step = 196, R =  167, G = 229, B =  71},
						new PaletteEntry() { Step = 229, R =  106, G = 239, B =   2},
						new PaletteEntry() { Step = 255, R =    0, G =  12, B =   0},
					}
				},

				new FormPalette()
				{
					Name = "bhw2_14_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =    0, G =   0, B =   8},
						new PaletteEntry() { Step = 45, R =    0, G =   0, B =  45},
						new PaletteEntry() { Step = 79, R =    7, G =  12, B = 255},
						new PaletteEntry() { Step = 119, R =   42, G =  55, B = 255},
						new PaletteEntry() { Step = 158, R =    7, G =  12, B = 255},
						new PaletteEntry() { Step = 209, R =    0, G =   0, B =  45},
						new PaletteEntry() { Step = 255, R =    0, G =   0, B =   8},
					}
				},

				new FormPalette()
				{
					Name = "bhw3_21_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =    1, G =  40, B =  98},
						new PaletteEntry() { Step = 48, R =    1, G =  65, B =  68},
						new PaletteEntry() { Step = 76, R =    2, G = 161, B =  96},
						new PaletteEntry() { Step = 104, R =    0, G =  81, B =  25},
						new PaletteEntry() { Step = 130, R =   65, G = 182, B =  82},
						new PaletteEntry() { Step = 153, R =    0, G =  86, B = 170},
						new PaletteEntry() { Step = 181, R =   17, G = 207, B = 182},
						new PaletteEntry() { Step = 204, R =   17, G = 207, B = 182},
						new PaletteEntry() { Step = 255, R =    1, G =  23, B =  46},
					}
				},

				new FormPalette()
				{
					Name = "bhw3_30_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =    1, G =   4, B =   1},
						new PaletteEntry() { Step = 12, R =    1, G =  28, B =   2},
						new PaletteEntry() { Step = 28, R =   16, G =  68, B =  11},
						new PaletteEntry() { Step = 58, R =   18, G =  11, B =  28},
						new PaletteEntry() { Step = 79, R =   31, G =  27, B =  48},
						new PaletteEntry() { Step = 96, R =    2, G =  13, B =  34},
						new PaletteEntry() { Step = 117, R =   30, G =  86, B = 123},
						new PaletteEntry() { Step = 135, R =    2, G =  42, B =  62},
						new PaletteEntry() { Step = 153, R =   74, G = 128, B = 155},
						new PaletteEntry() { Step = 181, R =   60, G =  31, B =  41},
						new PaletteEntry() { Step = 214, R =  167, G = 211, B = 223},
						new PaletteEntry() { Step = 237, R =  179, G =  70, B =  78},
						new PaletteEntry() { Step = 255, R =   57, G =   2, B =   7},
					}
				},

				new FormPalette()
				{
					Name = "vibrant_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =  255, G = 255, B = 255},
						new PaletteEntry() { Step = 30, R =    1, G = 144, B =  29},
						new PaletteEntry() { Step = 71, R =  229, G = 246, B =  12},
						new PaletteEntry() { Step = 119, R =  255, G =   1, B =   8},
						new PaletteEntry() { Step = 165, R =  184, G =   1, B = 203},
						new PaletteEntry() { Step = 214, R =    3, G =  28, B = 250},
						new PaletteEntry() { Step = 255, R =    0, G =   0, B =   0},
					}
				},

				new FormPalette()
				{
					Name = "cw1_029_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =   12, G =  80, B = 210},
						new PaletteEntry() { Step = 127, R =  255, G = 235, B =  19},
						new PaletteEntry() { Step = 255, R =  224, G =  66, B =  15},
					}
				},

				new FormPalette()
				{
					Name = "alarm_p4_0_2_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =  227, G = 255, B = 223},
						new PaletteEntry() { Step = 12, R =  255, G =  36, B =   4},
						new PaletteEntry() { Step = 25, R =  255, G =   2, B =   1},
						new PaletteEntry() { Step = 38, R =  255, G =   1, B =  16},
						new PaletteEntry() { Step = 51, R =  255, G =   1, B =  98},
						new PaletteEntry() { Step = 63, R =  255, G =   1, B = 230},
						new PaletteEntry() { Step = 76, R =  140, G =   1, B = 255},
						new PaletteEntry() { Step = 89, R =   63, G =   1, B = 255},
						new PaletteEntry() { Step = 102, R =   24, G =   1, B = 255},
						new PaletteEntry() { Step = 114, R =    5, G =   1, B = 255},
						new PaletteEntry() { Step = 127, R =    1, G =   1, B = 255},
						new PaletteEntry() { Step = 140, R =    1, G =   4, B = 255},
						new PaletteEntry() { Step = 153, R =    1, G =  16, B = 255},
						new PaletteEntry() { Step = 165, R =    1, G =  36, B = 255},
						new PaletteEntry() { Step = 178, R =    1, G =  62, B = 255},
						new PaletteEntry() { Step = 191, R =    1, G =  95, B = 255},
						new PaletteEntry() { Step = 204, R =    1, G = 131, B = 255},
						new PaletteEntry() { Step = 216, R =    1, G = 173, B = 255},
						new PaletteEntry() { Step = 229, R =    1, G = 221, B = 255},
						new PaletteEntry() { Step = 242, R =    1, G = 255, B = 235},
						new PaletteEntry() { Step = 255, R =    1, G = 255, B = 186},
					}
				},

				new FormPalette()
				{
					Name = "Ribbon_Colors_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =  227, G =   2, B =   9},
						new PaletteEntry() { Step = 31, R =  194, G =  51, B =   9},
						new PaletteEntry() { Step = 63, R =  167, G = 175, B =   8},
						new PaletteEntry() { Step = 95, R =   27, G = 209, B =  78},
						new PaletteEntry() { Step = 127, R =    1, G = 248, B = 247},
						new PaletteEntry() { Step = 159, R =    1, G =  78, B = 166},
						new PaletteEntry() { Step = 191, R =    1, G =   5, B = 102},
						new PaletteEntry() { Step = 223, R =   42, G =  79, B =  18},
						new PaletteEntry() { Step = 255, R =  255, G = 255, B =   0},
					}
				},

				new FormPalette()
				{
					Name = "Orange_to_Purple_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =  208, G =  50, B =   1},
						new PaletteEntry() { Step = 127, R =  146, G =  27, B =  45},
						new PaletteEntry() { Step = 255, R =   97, G =  12, B = 178},
					}
				},

				new FormPalette()
				{
					Name = "Fire_1_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =  255, G =   0, B =   0},
						new PaletteEntry() { Step = 127, R =  255, G =  55, B =   0},
						new PaletteEntry() { Step = 255, R =  255, G = 255, B =   0},
					}
				},

				new FormPalette()
				{
					Name = "standard_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =    0, G =   0, B =   0},
						new PaletteEntry() { Step = 84, R =   10, G =  17, B = 255},
						new PaletteEntry() { Step = 84, R =    0, G =  17, B =   0},
						new PaletteEntry() { Step = 169, R =   10, G = 255, B =  12},
						new PaletteEntry() { Step = 169, R =   10, G =   0, B =   0},
						new PaletteEntry() { Step = 255, R =  255, G =  17, B =  12},
					}
				},

				new FormPalette()
				{
					Name = "a_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =    0, G =   0, B =   0},
						new PaletteEntry() { Step = 31, R =    0, G =  55, B =   0},
						new PaletteEntry() { Step = 63, R =    0, G = 255, B =  45},
						new PaletteEntry() { Step = 127, R =  255, G =   0, B = 255},
						new PaletteEntry() { Step = 163, R =  255, G =   0, B =  45},
						new PaletteEntry() { Step = 196, R =  255, G =   0, B =   0},
						new PaletteEntry() { Step = 255, R =  255, G = 255, B =   0},
					}
				},

				new FormPalette()
				{
					Name = "b_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =    0, G =   0, B =   0},
						new PaletteEntry() { Step = 63, R =    0, G =   0, B = 255},
						new PaletteEntry() { Step = 127, R =  255, G =   0, B =   0},
						new PaletteEntry() { Step = 191, R =  255, G = 255, B =   0},
						new PaletteEntry() { Step = 255, R =  255, G = 255, B = 255},
					}
				},

				new FormPalette()
				{
					Name = "es_emerald_dragon_01_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =    1, G =   1, B =   1},
						new PaletteEntry() { Step = 79, R =    1, G =  19, B =   7},
						new PaletteEntry() { Step = 130, R =    1, G =  59, B =  25},
						new PaletteEntry() { Step = 229, R =   28, G = 255, B = 255},
						new PaletteEntry() { Step = 255, R =   28, G = 255, B = 255},
					}
				},

				new FormPalette()
				{
					Name = "es_landscape_59_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =  215, G = 114, B =   9},
						new PaletteEntry() { Step = 51, R =  255, G = 182, B =  34},
						new PaletteEntry() { Step = 89, R =  255, G = 205, B =  48},
						new PaletteEntry() { Step = 94, R =  213, G = 229, B = 210},
						new PaletteEntry() { Step = 153, R =  106, G = 161, B = 145},
						new PaletteEntry() { Step = 204, R =   20, G = 101, B = 111},
						new PaletteEntry() { Step = 255, R =    1, G =  48, B =  75},
					}
				},

				new FormPalette()
				{
					Name = "es_seadreams_09_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =  121, G = 136, B = 125},
						new PaletteEntry() { Step = 58, R =   34, G =  97, B = 166},
						new PaletteEntry() { Step = 101, R =    2, G =  66, B = 212},
						new PaletteEntry() { Step = 119, R =    2, G =  29, B = 182},
						new PaletteEntry() { Step = 153, R =    3, G =   8, B = 153},
						new PaletteEntry() { Step = 255, R =   82, G = 107, B = 178},
					}
				},

				new FormPalette()
				{
					Name = "froth316_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =  247, G =   0, B =   0},
						new PaletteEntry() { Step = 17, R =  247, G =   0, B =   0},
						new PaletteEntry() { Step = 17, R =  157, G =   0, B =   0},
						new PaletteEntry() { Step = 33, R =  157, G =   0, B =   0},
						new PaletteEntry() { Step = 33, R =   86, G =   0, B =   0},
						new PaletteEntry() { Step = 51, R =   86, G =   0, B =   0},
						new PaletteEntry() { Step = 51, R =   39, G =   0, B =   0},
						new PaletteEntry() { Step = 68, R =   39, G =   0, B =   0},
						new PaletteEntry() { Step = 68, R =   12, G =   0, B =   0},
						new PaletteEntry() { Step = 84, R =   12, G =   0, B =   0},
						new PaletteEntry() { Step = 84, R =    0, G = 248, B =   0},
						new PaletteEntry() { Step = 102, R =    0, G = 248, B =   0},
						new PaletteEntry() { Step = 102, R =    0, G = 169, B =   0},
						new PaletteEntry() { Step = 119, R =    0, G = 169, B =   0},
						new PaletteEntry() { Step = 119, R =    0, G = 101, B =   0},
						new PaletteEntry() { Step = 135, R =    0, G = 101, B =   0},
						new PaletteEntry() { Step = 135, R =    0, G =  52, B =   0},
						new PaletteEntry() { Step = 153, R =    0, G =  52, B =   0},
						new PaletteEntry() { Step = 153, R =    0, G =  19, B =   0},
						new PaletteEntry() { Step = 170, R =    0, G =  19, B =   0},
						new PaletteEntry() { Step = 170, R =    0, G =   0, B = 247},
						new PaletteEntry() { Step = 186, R =    0, G =   0, B = 247},
						new PaletteEntry() { Step = 186, R =    0, G =   0, B = 160},
						new PaletteEntry() { Step = 204, R =    0, G =   0, B = 160},
						new PaletteEntry() { Step = 204, R =    0, G =   0, B =  89},
						new PaletteEntry() { Step = 221, R =    0, G =   0, B =  89},
						new PaletteEntry() { Step = 221, R =    0, G =   0, B =  42},
						new PaletteEntry() { Step = 237, R =    0, G =   0, B =  42},
						new PaletteEntry() { Step = 237, R =    0, G =   0, B =  14},
						new PaletteEntry() { Step = 255, R =    0, G =   0, B =  14},
					}
				},

				new FormPalette()
				{
					Name = "Skydye11_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =          8, G =    0, B =    4},
						new PaletteEntry() { Step = 1, R =          8, G =    0, B =    4},
						new PaletteEntry() { Step = 2, R =         12, G =    0, B =    8},
						new PaletteEntry() { Step = 3, R =         16, G =    0, B =   12},
						new PaletteEntry() { Step = 4, R =         20, G =    0, B =   12},
						new PaletteEntry() { Step = 5, R =         20, G =    0, B =   16},
						new PaletteEntry() { Step = 6, R =         24, G =    0, B =   16},
						new PaletteEntry() { Step = 7, R =         28, G =    0, B =   20},
						new PaletteEntry() { Step = 9, R =         28, G =    0, B =   20},
						new PaletteEntry() { Step = 10, R =        32, G =    0, B =   24},
						new PaletteEntry() { Step = 11, R =        36, G =    0, B =   24},
						new PaletteEntry() { Step = 12, R =        36, G =    0, B =   28},
						new PaletteEntry() { Step = 13, R =        40, G =    0, B =   28},
						new PaletteEntry() { Step = 14, R =        44, G =    0, B =   32},
						new PaletteEntry() { Step = 15, R =        48, G =    0, B =   36},
						new PaletteEntry() { Step = 16, R =        52, G =    0, B =   36},
						new PaletteEntry() { Step = 17, R =        56, G =    0, B =   40},
						new PaletteEntry() { Step = 18, R =        60, G =    0, B =   44},
						new PaletteEntry() { Step = 20, R =        60, G =    0, B =   44},
						new PaletteEntry() { Step = 21, R =        64, G =    0, B =   48},
						new PaletteEntry() { Step = 22, R =        68, G =    0, B =   52},
						new PaletteEntry() { Step = 23, R =        72, G =    0, B =   52},
						new PaletteEntry() { Step = 24, R =        76, G =    0, B =   56},
						new PaletteEntry() { Step = 25, R =        76, G =    4, B =   56},
						new PaletteEntry() { Step = 26, R =        80, G =    4, B =   60},
						new PaletteEntry() { Step = 27, R =        84, G =    4, B =   60},
						new PaletteEntry() { Step = 28, R =        88, G =    4, B =   64},
						new PaletteEntry() { Step = 29, R =        92, G =    4, B =   68},
						new PaletteEntry() { Step = 30, R =        96, G =    8, B =   72},
						new PaletteEntry() { Step = 31, R =        96, G =    8, B =   76},
						new PaletteEntry() { Step = 32, R =        92, G =    8, B =   80},
						new PaletteEntry() { Step = 33, R =        88, G =    8, B =   84},
						new PaletteEntry() { Step = 34, R =        84, G =    8, B =   92},
						new PaletteEntry() { Step = 35, R =        84, G =    8, B =   96},
						new PaletteEntry() { Step = 36, R =        80, G =    8, B =  104},
						new PaletteEntry() { Step = 37, R =        76, G =    8, B =  108},
						new PaletteEntry() { Step = 38, R =        72, G =    8, B =  112},
						new PaletteEntry() { Step = 39, R =        72, G =    8, B =  120},
						new PaletteEntry() { Step = 40, R =        68, G =    8, B =  124},
						new PaletteEntry() { Step = 41, R =        64, G =    8, B =  132},
						new PaletteEntry() { Step = 42, R =        60, G =    8, B =  136},
						new PaletteEntry() { Step = 43, R =        60, G =    8, B =  144},
						new PaletteEntry() { Step = 44, R =        56, G =    8, B =  148},
						new PaletteEntry() { Step = 45, R =        52, G =    8, B =  152},
						new PaletteEntry() { Step = 46, R =        48, G =    8, B =  160},
						new PaletteEntry() { Step = 47, R =        48, G =    4, B =  164},
						new PaletteEntry() { Step = 48, R =        44, G =    4, B =  172},
						new PaletteEntry() { Step = 49, R =        40, G =    4, B =  176},
						new PaletteEntry() { Step = 50, R =        36, G =    4, B =  180},
						new PaletteEntry() { Step = 51, R =        36, G =    4, B =  188},
						new PaletteEntry() { Step = 52, R =        32, G =    4, B =  192},
						new PaletteEntry() { Step = 53, R =        28, G =    4, B =  200},
						new PaletteEntry() { Step = 54, R =        24, G =    4, B =  204},
						new PaletteEntry() { Step = 55, R =        24, G =    4, B =  212},
						new PaletteEntry() { Step = 56, R =        20, G =    4, B =  216},
						new PaletteEntry() { Step = 57, R =        16, G =    4, B =  220},
						new PaletteEntry() { Step = 58, R =        12, G =    4, B =  228},
						new PaletteEntry() { Step = 59, R =        12, G =    4, B =  232},
						new PaletteEntry() { Step = 60, R =         8, G =    4, B =  240},
						new PaletteEntry() { Step = 61, R =         4, G =    4, B =  244},
						new PaletteEntry() { Step = 62, R =         0, G =    0, B =  252},
						new PaletteEntry() { Step = 63, R =         0, G =    4, B =  248},
						new PaletteEntry() { Step = 64, R =         0, G =   12, B =  244},
						new PaletteEntry() { Step = 65, R =         0, G =   20, B =  240},
						new PaletteEntry() { Step = 66, R =         0, G =   28, B =  236},
						new PaletteEntry() { Step = 67, R =         0, G =   36, B =  232},
						new PaletteEntry() { Step = 68, R =         0, G =   44, B =  228},
						new PaletteEntry() { Step = 69, R =         0, G =   52, B =  224},
						new PaletteEntry() { Step = 70, R =         0, G =   60, B =  220},
						new PaletteEntry() { Step = 71, R =         0, G =   68, B =  216},
						new PaletteEntry() { Step = 72, R =         0, G =   76, B =  212},
						new PaletteEntry() { Step = 73, R =         0, G =   84, B =  208},
						new PaletteEntry() { Step = 74, R =         0, G =   92, B =  204},
						new PaletteEntry() { Step = 75, R =         0, G =  100, B =  200},
						new PaletteEntry() { Step = 76, R =         0, G =  108, B =  196},
						new PaletteEntry() { Step = 77, R =         0, G =  116, B =  192},
						new PaletteEntry() { Step = 78, R =         0, G =  124, B =  188},
						new PaletteEntry() { Step = 79, R =         0, G =  132, B =  184},
						new PaletteEntry() { Step = 80, R =         0, G =  140, B =  180},
						new PaletteEntry() { Step = 81, R =         0, G =  148, B =  176},
						new PaletteEntry() { Step = 82, R =         0, G =  156, B =  172},
						new PaletteEntry() { Step = 83, R =         0, G =  164, B =  168},
						new PaletteEntry() { Step = 84, R =         0, G =  172, B =  164},
						new PaletteEntry() { Step = 85, R =         0, G =  180, B =  160},
						new PaletteEntry() { Step = 86, R =         0, G =  188, B =  156},
						new PaletteEntry() { Step = 87, R =         0, G =  196, B =  152},
						new PaletteEntry() { Step = 88, R =         0, G =  204, B =  148},
						new PaletteEntry() { Step = 89, R =         0, G =  212, B =  144},
						new PaletteEntry() { Step = 90, R =         0, G =  220, B =  140},
						new PaletteEntry() { Step = 91, R =         0, G =  228, B =  136},
						new PaletteEntry() { Step = 92, R =         0, G =  236, B =  132},
						new PaletteEntry() { Step = 93, R =         0, G =  232, B =  124},
						new PaletteEntry() { Step = 94, R =         0, G =  224, B =  120},
						new PaletteEntry() { Step = 95, R =         0, G =  220, B =  112},
						new PaletteEntry() { Step = 96, R =         0, G =  216, B =  104},
						new PaletteEntry() { Step = 97, R =         0, G =  208, B =   96},
						new PaletteEntry() { Step = 98, R =         0, G =  200, B =   92},
						new PaletteEntry() { Step = 99, R =         0, G =  192, B =   88},
						new PaletteEntry() { Step = 100, R =        0, G =  184, B =   80},
						new PaletteEntry() { Step = 101, R =        0, G =  172, B =   76},
						new PaletteEntry() { Step = 102, R =        0, G =  164, B =   68},
						new PaletteEntry() { Step = 103, R =        0, G =  156, B =   64},
						new PaletteEntry() { Step = 104, R =        0, G =  148, B =   56},
						new PaletteEntry() { Step = 105, R =        0, G =  140, B =   52},
						new PaletteEntry() { Step = 106, R =        0, G =  128, B =   44},
						new PaletteEntry() { Step = 107, R =        0, G =  120, B =   40},
						new PaletteEntry() { Step = 108, R =        0, G =  112, B =   32},
						new PaletteEntry() { Step = 109, R =        0, G =  104, B =   28},
						new PaletteEntry() { Step = 110, R =        0, G =   92, B =   20},
						new PaletteEntry() { Step = 111, R =        0, G =   84, B =   16},
						new PaletteEntry() { Step = 112, R =        0, G =   76, B =    8},
						new PaletteEntry() { Step = 113, R =        0, G =   64, B =    0},
						new PaletteEntry() { Step = 114, R =        0, G =   60, B =    0},
						new PaletteEntry() { Step = 115, R =        0, G =   56, B =    0},
						new PaletteEntry() { Step = 116, R =        0, G =   52, B =    0},
						new PaletteEntry() { Step = 117, R =        0, G =   48, B =    0},
						new PaletteEntry() { Step = 118, R =        0, G =   44, B =    0},
						new PaletteEntry() { Step = 119, R =        0, G =   40, B =    0},
						new PaletteEntry() { Step = 120, R =        0, G =   36, B =    0},
						new PaletteEntry() { Step = 121, R =        4, G =   32, B =    0},
						new PaletteEntry() { Step = 122, R =        4, G =   28, B =    0},
						new PaletteEntry() { Step = 123, R =        4, G =   24, B =    0},
						new PaletteEntry() { Step = 124, R =        4, G =   20, B =    0},
						new PaletteEntry() { Step = 125, R =        4, G =   16, B =    0},
						new PaletteEntry() { Step = 126, R =        4, G =   12, B =    0},
						new PaletteEntry() { Step = 127, R =        4, G =    8, B =    0},
						new PaletteEntry() { Step = 128, R =        4, G =    4, B =    0},
						new PaletteEntry() { Step = 129, R =        8, G =    0, B =    4},
						new PaletteEntry() { Step = 130, R =       12, G =    0, B =    8},
						new PaletteEntry() { Step = 131, R =       16, G =    0, B =   12},
						new PaletteEntry() { Step = 132, R =       20, G =    0, B =   12},
						new PaletteEntry() { Step = 133, R =       20, G =    0, B =   16},
						new PaletteEntry() { Step = 134, R =       24, G =    0, B =   16},
						new PaletteEntry() { Step = 135, R =       28, G =    0, B =   20},
						new PaletteEntry() { Step = 136, R =       32, G =    0, B =   20},
						new PaletteEntry() { Step = 137, R =       32, G =    0, B =   24},
						new PaletteEntry() { Step = 138, R =       36, G =    0, B =   24},
						new PaletteEntry() { Step = 139, R =       40, G =    0, B =   28},
						new PaletteEntry() { Step = 140, R =       44, G =    0, B =   32},
						new PaletteEntry() { Step = 141, R =       48, G =    0, B =   36},
						new PaletteEntry() { Step = 142, R =       52, G =    4, B =   36},
						new PaletteEntry() { Step = 143, R =       56, G =    4, B =   40},
						new PaletteEntry() { Step = 145, R =       56, G =    4, B =   40},
						new PaletteEntry() { Step = 146, R =       60, G =    4, B =   44},
						new PaletteEntry() { Step = 147, R =       64, G =    4, B =   48},
						new PaletteEntry() { Step = 148, R =       68, G =    4, B =   48},
						new PaletteEntry() { Step = 149, R =       68, G =    4, B =   52},
						new PaletteEntry() { Step = 150, R =       72, G =    4, B =   52},
						new PaletteEntry() { Step = 151, R =       76, G =    4, B =   56},
						new PaletteEntry() { Step = 152, R =       80, G =    4, B =   56},
						new PaletteEntry() { Step = 153, R =       80, G =    4, B =   60},
						new PaletteEntry() { Step = 154, R =       84, G =    4, B =   60},
						new PaletteEntry() { Step = 155, R =       88, G =    4, B =   64},
						new PaletteEntry() { Step = 156, R =       92, G =    4, B =   68},
						new PaletteEntry() { Step = 157, R =       96, G =    8, B =   72},
						new PaletteEntry() { Step = 158, R =       96, G =    8, B =   76},
						new PaletteEntry() { Step = 159, R =      104, G =    8, B =   72},
						new PaletteEntry() { Step = 160, R =      112, G =    8, B =   68},
						new PaletteEntry() { Step = 161, R =      124, G =    8, B =   64},
						new PaletteEntry() { Step = 162, R =      132, G =    8, B =   60},
						new PaletteEntry() { Step = 163, R =      144, G =    8, B =   52},
						new PaletteEntry() { Step = 164, R =      152, G =    8, B =   48},
						new PaletteEntry() { Step = 165, R =      164, G =    8, B =   44},
						new PaletteEntry() { Step = 166, R =      172, G =    8, B =   40},
						new PaletteEntry() { Step = 167, R =      180, G =    4, B =   36},
						new PaletteEntry() { Step = 168, R =      192, G =    4, B =   32},
						new PaletteEntry() { Step = 169, R =      200, G =    4, B =   28},
						new PaletteEntry() { Step = 170, R =      212, G =    4, B =   20},
						new PaletteEntry() { Step = 171, R =      220, G =    4, B =   16},
						new PaletteEntry() { Step = 172, R =      232, G =    4, B =   12},
						new PaletteEntry() { Step = 173, R =      240, G =    4, B =    8},
						new PaletteEntry() { Step = 174, R =      252, G =    0, B =    0},
						new PaletteEntry() { Step = 175, R =      252, G =    8, B =    0},
						new PaletteEntry() { Step = 176, R =      252, G =   20, B =    0},
						new PaletteEntry() { Step = 177, R =      252, G =   28, B =    0},
						new PaletteEntry() { Step = 178, R =      252, G =   40, B =    0},
						new PaletteEntry() { Step = 179, R =      252, G =   48, B =    0},
						new PaletteEntry() { Step = 180, R =      252, G =   60, B =    0},
						new PaletteEntry() { Step = 181, R =      252, G =   68, B =    0},
						new PaletteEntry() { Step = 182, R =      252, G =   80, B =    0},
						new PaletteEntry() { Step = 183, R =      252, G =   88, B =    0},
						new PaletteEntry() { Step = 184, R =      252, G =  100, B =    0},
						new PaletteEntry() { Step = 185, R =      252, G =  108, B =    0},
						new PaletteEntry() { Step = 186, R =      252, G =  120, B =    0},
						new PaletteEntry() { Step = 187, R =      252, G =  132, B =    0},
						new PaletteEntry() { Step = 188, R =      252, G =  140, B =    0},
						new PaletteEntry() { Step = 189, R =      252, G =  152, B =    0},
						new PaletteEntry() { Step = 190, R =      252, G =  160, B =    0},
						new PaletteEntry() { Step = 191, R =      252, G =  172, B =    0},
						new PaletteEntry() { Step = 192, R =      252, G =  180, B =    0},
						new PaletteEntry() { Step = 193, R =      252, G =  192, B =    0},
						new PaletteEntry() { Step = 194, R =      252, G =  200, B =    0},
						new PaletteEntry() { Step = 195, R =      252, G =  212, B =    0},
						new PaletteEntry() { Step = 196, R =      252, G =  220, B =    0},
						new PaletteEntry() { Step = 197, R =      252, G =  232, B =    0},
						new PaletteEntry() { Step = 198, R =      252, G =  240, B =    0},
						new PaletteEntry() { Step = 199, R =      252, G =  252, B =    0},
						new PaletteEntry() { Step = 200, R =      252, G =  240, B =    0},
						new PaletteEntry() { Step = 201, R =      252, G =  232, B =    0},
						new PaletteEntry() { Step = 202, R =      252, G =  220, B =    0},
						new PaletteEntry() { Step = 203, R =      252, G =  208, B =    0},
						new PaletteEntry() { Step = 204, R =      252, G =  196, B =    0},
						new PaletteEntry() { Step = 205, R =      252, G =  188, B =    0},
						new PaletteEntry() { Step = 206, R =      252, G =  176, B =    0},
						new PaletteEntry() { Step = 207, R =      252, G =  164, B =    0},
						new PaletteEntry() { Step = 208, R =      252, G =  152, B =    0},
						new PaletteEntry() { Step = 209, R =      252, G =  144, B =    0},
						new PaletteEntry() { Step = 210, R =      252, G =  132, B =    0},
						new PaletteEntry() { Step = 211, R =      252, G =  120, B =    0},
						new PaletteEntry() { Step = 212, R =      252, G =  112, B =    0},
						new PaletteEntry() { Step = 213, R =      252, G =  100, B =    0},
						new PaletteEntry() { Step = 214, R =      252, G =   88, B =    0},
						new PaletteEntry() { Step = 215, R =      252, G =   76, B =    0},
						new PaletteEntry() { Step = 216, R =      252, G =   68, B =    0},
						new PaletteEntry() { Step = 217, R =      252, G =   56, B =    0},
						new PaletteEntry() { Step = 218, R =      252, G =   44, B =    0},
						new PaletteEntry() { Step = 219, R =      252, G =   32, B =    0},
						new PaletteEntry() { Step = 220, R =      252, G =   24, B =    0},
						new PaletteEntry() { Step = 221, R =      252, G =   12, B =    0},
						new PaletteEntry() { Step = 222, R =      252, G =    0, B =    0},
						new PaletteEntry() { Step = 223, R =      244, G =    0, B =    4},
						new PaletteEntry() { Step = 224, R =      236, G =    0, B =    8},
						new PaletteEntry() { Step = 225, R =      224, G =    0, B =   12},
						new PaletteEntry() { Step = 226, R =      216, G =    0, B =   16},
						new PaletteEntry() { Step = 227, R =      204, G =    0, B =   24},
						new PaletteEntry() { Step = 228, R =      196, G =    0, B =   28},
						new PaletteEntry() { Step = 229, R =      184, G =    0, B =   32},
						new PaletteEntry() { Step = 230, R =      176, G =    4, B =   36},
						new PaletteEntry() { Step = 231, R =      168, G =    4, B =   40},
						new PaletteEntry() { Step = 232, R =      156, G =    4, B =   44},
						new PaletteEntry() { Step = 233, R =      148, G =    4, B =   48},
						new PaletteEntry() { Step = 234, R =      136, G =    4, B =   56},
						new PaletteEntry() { Step = 235, R =      128, G =    4, B =   60},
						new PaletteEntry() { Step = 236, R =      116, G =    4, B =   64},
						new PaletteEntry() { Step = 237, R =      108, G =    4, B =   68},
						new PaletteEntry() { Step = 238, R =       96, G =    8, B =   76},
						new PaletteEntry() { Step = 239, R =       92, G =    8, B =   72},
						new PaletteEntry() { Step = 240, R =       84, G =    8, B =   68},
						new PaletteEntry() { Step = 241, R =       80, G =    8, B =   64},
						new PaletteEntry() { Step = 242, R =       72, G =    8, B =   56},
						new PaletteEntry() { Step = 243, R =       68, G =    4, B =   52},
						new PaletteEntry() { Step = 244, R =       60, G =    4, B =   48},
						new PaletteEntry() { Step = 245, R =       56, G =    4, B =   44},
						new PaletteEntry() { Step = 246, R =       48, G =    4, B =   40},
						new PaletteEntry() { Step = 247, R =       44, G =    4, B =   32},
						new PaletteEntry() { Step = 248, R =       36, G =    4, B =   28},
						new PaletteEntry() { Step = 249, R =       32, G =    4, B =   24},
						new PaletteEntry() { Step = 250, R =       24, G =    4, B =   20},
						new PaletteEntry() { Step = 251, R =       20, G =    0, B =   16},
						new PaletteEntry() { Step = 252, R =       12, G =    0, B =    8},
						new PaletteEntry() { Step = 253, R =        0, G =    0, B =    0},
						new PaletteEntry() { Step = 254, R =        4, G =    0, B =    4},
						new PaletteEntry() { Step = 255, R =        4, G =    0, B =    4},
					}
				},

				new FormPalette()
				{
					Name = "Wizzl019_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0 , R = 140, G = 20, B = 172 },
						new PaletteEntry() { Step = 1 , R = 140, G = 20, B = 172 },
						new PaletteEntry() { Step = 2 , R = 148, G = 20, B = 184 },
						new PaletteEntry() { Step = 3 , R = 160, G = 16, B = 200 },
						new PaletteEntry() { Step = 4 , R = 156, G = 16, B = 196 },
						new PaletteEntry() { Step = 5 , R = 152, G = 16, B = 188 },
						new PaletteEntry() { Step = 6 , R = 148, G = 16, B = 180 },
						new PaletteEntry() { Step = 7 , R = 140, G = 12, B = 172 },
						new PaletteEntry() { Step = 8 , R = 136, G = 12, B = 164 },
						new PaletteEntry() { Step = 9 , R = 132, G = 12, B = 156 },
						new PaletteEntry() { Step = 10, R =       128, G =   12, B =  148},
						new PaletteEntry() { Step = 11, R =       120, G =    8, B =  140},
						new PaletteEntry() { Step = 12, R =       116, G =    8, B =  136},
						new PaletteEntry() { Step = 13, R =       112, G =    8, B =  128},
						new PaletteEntry() { Step = 14, R =       108, G =    8, B =  120},
						new PaletteEntry() { Step = 15, R =       100, G =    4, B =  112},
						new PaletteEntry() { Step = 16, R =        96, G =    4, B =  104},
						new PaletteEntry() { Step = 17, R =        92, G =    4, B =   96},
						new PaletteEntry() { Step = 18, R =        88, G =    4, B =   88},
						new PaletteEntry() { Step = 19, R =        80, G =    0, B =   80},
						new PaletteEntry() { Step = 20, R =        84, G =    4, B =   76},
						new PaletteEntry() { Step = 21, R =        92, G =   12, B =   72},
						new PaletteEntry() { Step = 22, R =       100, G =   20, B =   68},
						new PaletteEntry() { Step = 23, R =       108, G =   28, B =   60},
						new PaletteEntry() { Step = 24, R =       116, G =   36, B =   56},
						new PaletteEntry() { Step = 25, R =       124, G =   44, B =   52},
						new PaletteEntry() { Step = 26, R =       132, G =   52, B =   48},
						new PaletteEntry() { Step = 27, R =       140, G =   60, B =   40},
						new PaletteEntry() { Step = 28, R =       144, G =   64, B =   36},
						new PaletteEntry() { Step = 29, R =       152, G =   72, B =   32},
						new PaletteEntry() { Step = 30, R =       160, G =   80, B =   28},
						new PaletteEntry() { Step = 31, R =       168, G =   88, B =   20},
						new PaletteEntry() { Step = 32, R =       176, G =   96, B =   16},
						new PaletteEntry() { Step = 33, R =       184, G =  104, B =   12},
						new PaletteEntry() { Step = 34, R =       192, G =  112, B =    8},
						new PaletteEntry() { Step = 35, R =       200, G =  120, B =    0},
						new PaletteEntry() { Step = 36, R =       196, G =  116, B =    0},
						new PaletteEntry() { Step = 37, R =       188, G =  112, B =    0},
						new PaletteEntry() { Step = 38, R =       180, G =  108, B =    0},
						new PaletteEntry() { Step = 39, R =       172, G =  100, B =    0},
						new PaletteEntry() { Step = 40, R =       164, G =   96, B =    0},
						new PaletteEntry() { Step = 41, R =       156, G =   92, B =    0},
						new PaletteEntry() { Step = 42, R =       148, G =   88, B =    0},
						new PaletteEntry() { Step = 43, R =       140, G =   80, B =    0},
						new PaletteEntry() { Step = 44, R =       136, G =   76, B =    0},
						new PaletteEntry() { Step = 45, R =       128, G =   72, B =    0},
						new PaletteEntry() { Step = 46, R =       120, G =   68, B =    0},
						new PaletteEntry() { Step = 47, R =       112, G =   60, B =    0},
						new PaletteEntry() { Step = 48, R =       104, G =   56, B =    0},
						new PaletteEntry() { Step = 49, R =        96, G =   52, B =    0},
						new PaletteEntry() { Step = 50, R =        88, G =   48, B =    0},
						new PaletteEntry() { Step = 51, R =        80, G =   40, B =    0},
						new PaletteEntry() { Step = 52, R =        76, G =   48, B =    4},
						new PaletteEntry() { Step = 53, R =        72, G =   60, B =    8},
						new PaletteEntry() { Step = 54, R =        68, G =   68, B =   12},
						new PaletteEntry() { Step = 55, R =        60, G =   80, B =   20},
						new PaletteEntry() { Step = 56, R =        56, G =   88, B =   24},
						new PaletteEntry() { Step = 57, R =        52, G =  100, B =   28},
						new PaletteEntry() { Step = 58, R =        48, G =  108, B =   32},
						new PaletteEntry() { Step = 59, R =        40, G =  120, B =   40},
						new PaletteEntry() { Step = 60, R =        36, G =  128, B =   44},
						new PaletteEntry() { Step = 61, R =        32, G =  140, B =   48},
						new PaletteEntry() { Step = 62, R =        28, G =  148, B =   52},
						new PaletteEntry() { Step = 63, R =        20, G =  160, B =   60},
						new PaletteEntry() { Step = 64, R =        16, G =  168, B =   64},
						new PaletteEntry() { Step = 65, R =        12, G =  180, B =   68},
						new PaletteEntry() { Step = 66, R =         8, G =  188, B =   72},
						new PaletteEntry() { Step = 67, R =         0, G =  200, B =   80},
						new PaletteEntry() { Step = 68, R =         0, G =  192, B =   76},
						new PaletteEntry() { Step = 69, R =         0, G =  180, B =   72},
						new PaletteEntry() { Step = 70, R =         0, G =  172, B =   68},
						new PaletteEntry() { Step = 71, R =         0, G =  160, B =   60},
						new PaletteEntry() { Step = 72, R =         0, G =  152, B =   56},
						new PaletteEntry() { Step = 73, R =         0, G =  140, B =   52},
						new PaletteEntry() { Step = 74, R =         0, G =  132, B =   48},
						new PaletteEntry() { Step = 75, R =         0, G =  120, B =   40},
						new PaletteEntry() { Step = 76, R =         0, G =  112, B =   36},
						new PaletteEntry() { Step = 77, R =         0, G =  100, B =   32},
						new PaletteEntry() { Step = 78, R =         0, G =   92, B =   28},
						new PaletteEntry() { Step = 79, R =         0, G =   80, B =   20},
						new PaletteEntry() { Step = 80, R =         0, G =   72, B =   16},
						new PaletteEntry() { Step = 81, R =         0, G =   60, B =   12},
						new PaletteEntry() { Step = 82, R =         0, G =   52, B =    8},
						new PaletteEntry() { Step = 83, R =         0, G =   40, B =    0},
						new PaletteEntry() { Step = 84, R =         0, G =   40, B =   12},
						new PaletteEntry() { Step = 85, R =         4, G =   36, B =   28},
						new PaletteEntry() { Step = 86, R =         4, G =   36, B =   44},
						new PaletteEntry() { Step = 87, R =         8, G =   32, B =   60},
						new PaletteEntry() { Step = 88, R =        12, G =   28, B =   72},
						new PaletteEntry() { Step = 89, R =        12, G =   28, B =   88},
						new PaletteEntry() { Step = 90, R =        16, G =   24, B =  104},
						new PaletteEntry() { Step = 91, R =        20, G =   20, B =  120},
						new PaletteEntry() { Step = 92, R =        20, G =   20, B =  132},
						new PaletteEntry() { Step = 93, R =        24, G =   16, B =  148},
						new PaletteEntry() { Step = 94, R =        24, G =   16, B =  164},
						new PaletteEntry() { Step = 95, R =        28, G =   12, B =  180},
						new PaletteEntry() { Step = 96, R =        32, G =    8, B =  192},
						new PaletteEntry() { Step = 97, R =        32, G =    8, B =  208},
						new PaletteEntry() { Step = 98, R =        36, G =    4, B =  224},
						new PaletteEntry() { Step = 99, R =        40, G =    0, B =  240},
						new PaletteEntry() { Step = 100, R =       40, G =    0, B =  232},
						new PaletteEntry() { Step = 101, R =       36, G =    0, B =  220},
						new PaletteEntry() { Step = 102, R =       36, G =    0, B =  212},
						new PaletteEntry() { Step = 103, R =       32, G =    0, B =  200},
						new PaletteEntry() { Step = 104, R =       28, G =    0, B =  192},
						new PaletteEntry() { Step = 105, R =       28, G =    0, B =  180},
						new PaletteEntry() { Step = 106, R =       24, G =    0, B =  172},
						new PaletteEntry() { Step = 107, R =       20, G =    0, B =  160},
						new PaletteEntry() { Step = 108, R =       20, G =    0, B =  152},
						new PaletteEntry() { Step = 109, R =       16, G =    0, B =  140},
						new PaletteEntry() { Step = 110, R =       16, G =    0, B =  132},
						new PaletteEntry() { Step = 111, R =       12, G =    0, B =  120},
						new PaletteEntry() { Step = 112, R =        8, G =    0, B =  112},
						new PaletteEntry() { Step = 113, R =        8, G =    0, B =  100},
						new PaletteEntry() { Step = 114, R =        4, G =    0, B =   92},
						new PaletteEntry() { Step = 115, R =        0, G =    0, B =   80},
						new PaletteEntry() { Step = 116, R =       12, G =    0, B =   84},
						new PaletteEntry() { Step = 117, R =       24, G =    0, B =   92},
						new PaletteEntry() { Step = 118, R =       36, G =    0, B =  100},
						new PaletteEntry() { Step = 119, R =       48, G =    0, B =  108},
						new PaletteEntry() { Step = 120, R =       60, G =    0, B =  116},
						new PaletteEntry() { Step = 121, R =       72, G =    0, B =  124},
						new PaletteEntry() { Step = 122, R =       84, G =    0, B =  132},
						new PaletteEntry() { Step = 123, R =      100, G =    0, B =  140},
						new PaletteEntry() { Step = 124, R =      112, G =    0, B =  144},
						new PaletteEntry() { Step = 125, R =      124, G =    0, B =  152},
						new PaletteEntry() { Step = 126, R =      136, G =    0, B =  160},
						new PaletteEntry() { Step = 127, R =      148, G =    0, B =  168},
						new PaletteEntry() { Step = 128, R =      160, G =    0, B =  176},
						new PaletteEntry() { Step = 129, R =      172, G =    0, B =  184},
						new PaletteEntry() { Step = 130, R =      184, G =    0, B =  192},
						new PaletteEntry() { Step = 131, R =      200, G =    0, B =  200},
						new PaletteEntry() { Step = 132, R =      192, G =    0, B =  192},
						new PaletteEntry() { Step = 133, R =      180, G =    0, B =  180},
						new PaletteEntry() { Step = 134, R =      172, G =    0, B =  172},
						new PaletteEntry() { Step = 135, R =      160, G =    0, B =  160},
						new PaletteEntry() { Step = 136, R =      152, G =    0, B =  152},
						new PaletteEntry() { Step = 137, R =      140, G =    0, B =  140},
						new PaletteEntry() { Step = 138, R =      132, G =    0, B =  132},
						new PaletteEntry() { Step = 139, R =      120, G =    0, B =  120},
						new PaletteEntry() { Step = 140, R =      112, G =    0, B =  112},
						new PaletteEntry() { Step = 141, R =      100, G =    0, B =  100},
						new PaletteEntry() { Step = 142, R =       92, G =    0, B =   92},
						new PaletteEntry() { Step = 143, R =       80, G =    0, B =   80},
						new PaletteEntry() { Step = 144, R =       72, G =    0, B =   72},
						new PaletteEntry() { Step = 145, R =       60, G =    0, B =   60},
						new PaletteEntry() { Step = 146, R =       52, G =    0, B =   52},
						new PaletteEntry() { Step = 147, R =       40, G =    0, B =   40},
						new PaletteEntry() { Step = 148, R =       52, G =    0, B =   40},
						new PaletteEntry() { Step = 149, R =       64, G =    0, B =   40},
						new PaletteEntry() { Step = 150, R =       76, G =    0, B =   40},
						new PaletteEntry() { Step = 151, R =       88, G =    0, B =   40},
						new PaletteEntry() { Step = 152, R =      100, G =    0, B =   40},
						new PaletteEntry() { Step = 153, R =      112, G =    0, B =   40},
						new PaletteEntry() { Step = 154, R =      124, G =    0, B =   40},
						new PaletteEntry() { Step = 155, R =      140, G =    0, B =   36},
						new PaletteEntry() { Step = 156, R =      152, G =    0, B =   36},
						new PaletteEntry() { Step = 157, R =      164, G =    0, B =   36},
						new PaletteEntry() { Step = 158, R =      176, G =    0, B =   36},
						new PaletteEntry() { Step = 159, R =      188, G =    0, B =   36},
						new PaletteEntry() { Step = 160, R =      200, G =    0, B =   36},
						new PaletteEntry() { Step = 161, R =      212, G =    0, B =   36},
						new PaletteEntry() { Step = 162, R =      224, G =    0, B =   36},
						new PaletteEntry() { Step = 163, R =      240, G =    0, B =   32},
						new PaletteEntry() { Step = 164, R =      232, G =    0, B =   32},
						new PaletteEntry() { Step = 165, R =      220, G =    0, B =   28},
						new PaletteEntry() { Step = 166, R =      212, G =    0, B =   28},
						new PaletteEntry() { Step = 167, R =      200, G =    0, B =   24},
						new PaletteEntry() { Step = 168, R =      192, G =    0, B =   24},
						new PaletteEntry() { Step = 169, R =      180, G =    0, B =   20},
						new PaletteEntry() { Step = 170, R =      172, G =    0, B =   20},
						new PaletteEntry() { Step = 171, R =      160, G =    0, B =   16},
						new PaletteEntry() { Step = 172, R =      152, G =    0, B =   16},
						new PaletteEntry() { Step = 173, R =      140, G =    0, B =   12},
						new PaletteEntry() { Step = 174, R =      132, G =    0, B =   12},
						new PaletteEntry() { Step = 175, R =      120, G =    0, B =    8},
						new PaletteEntry() { Step = 176, R =      112, G =    0, B =    8},
						new PaletteEntry() { Step = 177, R =      100, G =    0, B =    4},
						new PaletteEntry() { Step = 178, R =       92, G =    0, B =    4},
						new PaletteEntry() { Step = 179, R =       80, G =    0, B =    0},
						new PaletteEntry() { Step = 180, R =       88, G =    8, B =    0},
						new PaletteEntry() { Step = 181, R =       96, G =   16, B =    0},
						new PaletteEntry() { Step = 182, R =      104, G =   24, B =    0},
						new PaletteEntry() { Step = 183, R =      116, G =   32, B =    0},
						new PaletteEntry() { Step = 184, R =      124, G =   40, B =    0},
						new PaletteEntry() { Step = 185, R =      132, G =   48, B =    0},
						new PaletteEntry() { Step = 186, R =      140, G =   56, B =    0},
						new PaletteEntry() { Step = 187, R =      152, G =   64, B =    0},
						new PaletteEntry() { Step = 188, R =      160, G =   72, B =    0},
						new PaletteEntry() { Step = 189, R =      168, G =   80, B =    0},
						new PaletteEntry() { Step = 190, R =      176, G =   88, B =    0},
						new PaletteEntry() { Step = 191, R =      188, G =   96, B =    0},
						new PaletteEntry() { Step = 192, R =      196, G =  104, B =    0},
						new PaletteEntry() { Step = 193, R =      204, G =  112, B =    0},
						new PaletteEntry() { Step = 194, R =      212, G =  120, B =    0},
						new PaletteEntry() { Step = 195, R =      224, G =  128, B =    0},
						new PaletteEntry() { Step = 196, R =      216, G =  124, B =    0},
						new PaletteEntry() { Step = 197, R =      204, G =  116, B =    0},
						new PaletteEntry() { Step = 198, R =      192, G =  112, B =    0},
						new PaletteEntry() { Step = 199, R =      180, G =  104, B =    0},
						new PaletteEntry() { Step = 200, R =      168, G =  100, B =    0},
						new PaletteEntry() { Step = 201, R =      160, G =   92, B =    0},
						new PaletteEntry() { Step = 202, R =      148, G =   88, B =    0},
						new PaletteEntry() { Step = 203, R =      136, G =   80, B =    0},
						new PaletteEntry() { Step = 204, R =      124, G =   72, B =    0},
						new PaletteEntry() { Step = 205, R =      112, G =   68, B =    0},
						new PaletteEntry() { Step = 206, R =      104, G =   60, B =    0},
						new PaletteEntry() { Step = 207, R =       92, G =   56, B =    0},
						new PaletteEntry() { Step = 208, R =       80, G =   48, B =    0},
						new PaletteEntry() { Step = 209, R =       68, G =   44, B =    0},
						new PaletteEntry() { Step = 210, R =       56, G =   36, B =    0},
						new PaletteEntry() { Step = 211, R =       64, G =   36, B =    8},
						new PaletteEntry() { Step = 212, R =       76, G =   36, B =   20},
						new PaletteEntry() { Step = 213, R =       88, G =   36, B =   28},
						new PaletteEntry() { Step = 214, R =      100, G =   32, B =   40},
						new PaletteEntry() { Step = 215, R =      112, G =   32, B =   48},
						new PaletteEntry() { Step = 216, R =      124, G =   32, B =   60},
						new PaletteEntry() { Step = 217, R =      136, G =   32, B =   68},
						new PaletteEntry() { Step = 218, R =      148, G =   28, B =   80},
						new PaletteEntry() { Step = 219, R =      156, G =   28, B =   88},
						new PaletteEntry() { Step = 220, R =      168, G =   28, B =  100},
						new PaletteEntry() { Step = 221, R =      180, G =   28, B =  108},
						new PaletteEntry() { Step = 222, R =      192, G =   24, B =  120},
						new PaletteEntry() { Step = 223, R =      204, G =   24, B =  128},
						new PaletteEntry() { Step = 224, R =      216, G =   24, B =  140},
						new PaletteEntry() { Step = 225, R =      228, G =   24, B =  148},
						new PaletteEntry() { Step = 226, R =      240, G =   20, B =  160},
						new PaletteEntry() { Step = 227, R =      228, G =   20, B =  152},
						new PaletteEntry() { Step = 228, R =      212, G =   20, B =  140},
						new PaletteEntry() { Step = 229, R =      196, G =   24, B =  132},
						new PaletteEntry() { Step = 230, R =      180, G =   24, B =  120},
						new PaletteEntry() { Step = 231, R =      168, G =   24, B =  112},
						new PaletteEntry() { Step = 232, R =      152, G =   28, B =  100},
						new PaletteEntry() { Step = 233, R =      136, G =   28, B =   92},
						new PaletteEntry() { Step = 234, R =      120, G =   32, B =   80},
						new PaletteEntry() { Step = 235, R =      108, G =   32, B =   72},
						new PaletteEntry() { Step = 236, R =       92, G =   32, B =   60},
						new PaletteEntry() { Step = 237, R =       76, G =   36, B =   52},
						new PaletteEntry() { Step = 238, R =       60, G =   36, B =   40},
						new PaletteEntry() { Step = 239, R =       48, G =   36, B =   32},
						new PaletteEntry() { Step = 240, R =       32, G =   40, B =   20},
						new PaletteEntry() { Step = 241, R =       16, G =   40, B =   12},
						new PaletteEntry() { Step = 242, R =        0, G =   44, B =    0},
						new PaletteEntry() { Step = 243, R =        8, G =   44, B =   12},
						new PaletteEntry() { Step = 244, R =       20, G =   44, B =   24},
						new PaletteEntry() { Step = 245, R =       28, G =   40, B =   36},
						new PaletteEntry() { Step = 246, R =       40, G =   40, B =   48},
						new PaletteEntry() { Step = 247, R =       48, G =   36, B =   60},
						new PaletteEntry() { Step = 248, R =       60, G =   36, B =   72},
						new PaletteEntry() { Step = 249, R =       68, G =   32, B =   84},
						new PaletteEntry() { Step = 250, R =       80, G =   32, B =  100},
						new PaletteEntry() { Step = 251, R =       88, G =   32, B =  112},
						new PaletteEntry() { Step = 252, R =      100, G =   28, B =  124},
						new PaletteEntry() { Step = 253, R =      108, G =   28, B =  136},
						new PaletteEntry() { Step = 254, R =      120, G =   24, B =  148},
						new PaletteEntry() { Step = 255, R =      128, G =   24, B =  160},
					}
				},

				new FormPalette()
				{
					Name = "Tropical_Colors_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =    1, G =   4, B =   1},
						new PaletteEntry() { Step = 14, R =    1, G =  10, B =   1},
						new PaletteEntry() { Step = 21, R =    1, G =  19, B =   0},
						new PaletteEntry() { Step = 35, R =    1, G =  42, B =   1},
						new PaletteEntry() { Step = 49, R =    3, G =  75, B =   1},
						new PaletteEntry() { Step = 59, R =   56, G = 103, B =   1},
						new PaletteEntry() { Step = 70, R =  208, G = 135, B =   4},
						new PaletteEntry() { Step = 84, R =  217, G =  54, B =   2},
						new PaletteEntry() { Step = 98, R =  224, G =  10, B =   1},
						new PaletteEntry() { Step = 130, R =  117, G =  15, B =   3},
						new PaletteEntry() { Step = 141, R =   48, G =  20, B =   6},
						new PaletteEntry() { Step = 155, R =   42, G =  18, B =  77},
						new PaletteEntry() { Step = 170, R =   36, G =  17, B = 255},
						new PaletteEntry() { Step = 197, R =   55, G =  97, B = 242},
						new PaletteEntry() { Step = 210, R =   80, G = 255, B = 228},
						new PaletteEntry() { Step = 220, R =   47, G = 219, B =  77},
						new PaletteEntry() { Step = 225, R =   24, G = 187, B =  10},
						new PaletteEntry() { Step = 228, R =   24, G = 180, B =   9},
						new PaletteEntry() { Step = 230, R =   24, G = 171, B =   8},
						new PaletteEntry() { Step = 232, R =   23, G = 161, B =   6},
						new PaletteEntry() { Step = 235, R =   23, G = 149, B =   5},
						new PaletteEntry() { Step = 237, R =   22, G = 136, B =   4},
						new PaletteEntry() { Step = 240, R =   22, G = 124, B =   2},
						new PaletteEntry() { Step = 242, R =   21, G = 112, B =   1},
						new PaletteEntry() { Step = 245, R =   21, G = 100, B =   1},
						new PaletteEntry() { Step = 247, R =   20, G =  88, B =   1},
						new PaletteEntry() { Step = 250, R =   19, G =  77, B =   1},
						new PaletteEntry() { Step = 252, R =   19, G =  66, B =   1},
						new PaletteEntry() { Step = 255, R =   18, G =  55, B =   0},
					}
				},

				new FormPalette()
				{
					Name = "GMT_seafloor_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =   25, G =   0, B = 109},
						new PaletteEntry() { Step = 10, R =   28, G =   0, B = 119},
						new PaletteEntry() { Step = 21, R =   32, G =   0, B = 127},
						new PaletteEntry() { Step = 31, R =   35, G =   0, B = 140},
						new PaletteEntry() { Step = 42, R =   27, G =   1, B = 145},
						new PaletteEntry() { Step = 53, R =   20, G =   1, B = 151},
						new PaletteEntry() { Step = 74, R =   14, G =   4, B = 156},
						new PaletteEntry() { Step = 84, R =    9, G =   9, B = 164},
						new PaletteEntry() { Step = 95, R =    5, G =  15, B = 170},
						new PaletteEntry() { Step = 106, R =    2, G =  24, B = 176},
						new PaletteEntry() { Step = 116, R =    1, G =  35, B = 182},
						new PaletteEntry() { Step = 138, R =    1, G =  49, B = 188},
						new PaletteEntry() { Step = 148, R =    0, G =  66, B = 197},
						new PaletteEntry() { Step = 159, R =    1, G =  79, B = 203},
						new PaletteEntry() { Step = 170, R =    3, G =  93, B = 210},
						new PaletteEntry() { Step = 180, R =   10, G = 109, B = 216},
						new PaletteEntry() { Step = 191, R =   24, G = 128, B = 223},
						new PaletteEntry() { Step = 212, R =   43, G = 149, B = 230},
						new PaletteEntry() { Step = 223, R =   72, G = 173, B = 240},
						new PaletteEntry() { Step = 233, R =  112, G = 197, B = 247},
						new PaletteEntry() { Step = 244, R =  163, G = 225, B = 255},
						new PaletteEntry() { Step = 255, R =  220, G = 248, B = 255},
					}
				},

				new FormPalette()
				{
					Name = "slope_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =  255, G = 255, B = 255},
						new PaletteEntry() { Step = 5, R =  255, G = 255, B =   0},
						new PaletteEntry() { Step = 14, R =    0, G = 255, B =   0},
						new PaletteEntry() { Step = 28, R =    0, G = 255, B = 255},
						new PaletteEntry() { Step = 42, R =    0, G =   0, B = 255},
						new PaletteEntry() { Step = 84, R =  255, G =   0, B = 255},
						new PaletteEntry() { Step = 141, R =  255, G =   0, B =   0},
						new PaletteEntry() { Step = 255, R =    0, G =   0, B =   0},
					}
				},

				new FormPalette()
				{
					Name = "ofaurora_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =  255, G = 241, B = 242},
						new PaletteEntry() { Step = 10, R =  237, G =   1, B =   9},
						new PaletteEntry() { Step = 15, R =   42, G =   1, B =   2},
						new PaletteEntry() { Step = 22, R =    1, G =   1, B =   1},
						new PaletteEntry() { Step = 35, R =  237, G =   1, B =   9},
						new PaletteEntry() { Step = 48, R =  255, G = 241, B = 242},
						new PaletteEntry() { Step = 58, R =  239, G =  57, B =   1},
						new PaletteEntry() { Step = 66, R =    1, G =   1, B =   1},
						new PaletteEntry() { Step = 76, R =  239, G =  57, B =   1},
						new PaletteEntry() { Step = 84, R =  255, G = 241, B = 242},
						new PaletteEntry() { Step = 94, R =  242, G = 217, B =   1},
						new PaletteEntry() { Step = 101, R =    1, G =   1, B =   1},
						new PaletteEntry() { Step = 109, R =  242, G = 217, B =   1},
						new PaletteEntry() { Step = 119, R =  255, G = 241, B = 242},
						new PaletteEntry() { Step = 127, R =    9, G = 144, B =  36},
						new PaletteEntry() { Step = 132, R =    1, G =   1, B =   1},
						new PaletteEntry() { Step = 140, R =    9, G = 144, B =  36},
						new PaletteEntry() { Step = 147, R =  255, G = 241, B = 242},
						new PaletteEntry() { Step = 158, R =    1, G = 156, B = 186},
						new PaletteEntry() { Step = 168, R =    1, G =   1, B =   1},
						new PaletteEntry() { Step = 178, R =    1, G = 156, B = 186},
						new PaletteEntry() { Step = 186, R =  255, G = 241, B = 242},
						new PaletteEntry() { Step = 198, R =   16, G =  13, B = 255},
						new PaletteEntry() { Step = 206, R =    1, G =   1, B =   1},
						new PaletteEntry() { Step = 216, R =   16, G =  13, B = 255},
						new PaletteEntry() { Step = 224, R =  255, G = 241, B = 242},
						new PaletteEntry() { Step = 234, R =   78, G =   1, B = 156},
						new PaletteEntry() { Step = 237, R =   14, G =   1, B =  30},
						new PaletteEntry() { Step = 239, R =    1, G =   1, B =   1},
						new PaletteEntry() { Step = 244, R =   78, G =   1, B = 156},
						new PaletteEntry() { Step = 255, R =  255, G = 241, B = 242},
					}
				},

				new FormPalette()
				{
					Name = "hallows_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =    1, G =   1, B =   1},
						new PaletteEntry() { Step = 20, R =  247, G =  28, B =   1},
						new PaletteEntry() { Step = 25, R =  234, G = 136, B =   3},
						new PaletteEntry() { Step = 35, R =    1, G =   1, B =   1},
						new PaletteEntry() { Step = 48, R =  247, G =  28, B =   1},
						new PaletteEntry() { Step = 51, R =  234, G = 136, B =   3},
						new PaletteEntry() { Step = 61, R =    1, G =   1, B =   1},
						new PaletteEntry() { Step = 76, R =  247, G =  28, B =   1},
						new PaletteEntry() { Step = 91, R =  244, G = 176, B =   1},
						new PaletteEntry() { Step = 107, R =  234, G = 136, B =   3},
						new PaletteEntry() { Step = 122, R =    1, G =   1, B =   1},
						new PaletteEntry() { Step = 140, R =  234, G = 136, B =   3},
						new PaletteEntry() { Step = 153, R =  244, G = 176, B =   1},
						new PaletteEntry() { Step = 168, R =  247, G =  28, B =   1},
						new PaletteEntry() { Step = 186, R =    1, G =   1, B =   1},
						new PaletteEntry() { Step = 196, R =  247, G =  28, B =   1},
						new PaletteEntry() { Step = 204, R =  234, G = 136, B =   3},
						new PaletteEntry() { Step = 216, R =    1, G =   1, B =   1},
						new PaletteEntry() { Step = 229, R =  234, G = 136, B =   3},
						new PaletteEntry() { Step = 239, R =  247, G =  28, B =   1},
						new PaletteEntry() { Step = 249, R =    1, G =   1, B =   1},
						new PaletteEntry() { Step = 255, R =    1, G =   1, B =   1},
					}
				},

				new FormPalette()
				{
					Name = "sea_treasure_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =    1, G =  13, B =   5},
						new PaletteEntry() { Step = 25, R =    3, G =  57, B =  25},
						new PaletteEntry() { Step = 45, R =   18, G = 191, B = 172},
						new PaletteEntry() { Step = 61, R =    2, G =  29, B =  12},
						new PaletteEntry() { Step = 76, R =    3, G =  57, B =  25},
						new PaletteEntry() { Step = 101, R =   18, G = 191, B = 172},
						new PaletteEntry() { Step = 124, R =   10, G =  54, B =  20},
						new PaletteEntry() { Step = 153, R =    1, G =  30, B =  12},
						new PaletteEntry() { Step = 178, R =   10, G =  14, B =  22},
						new PaletteEntry() { Step = 209, R =    9, G =  93, B =  47},
						new PaletteEntry() { Step = 232, R =    8, G =  55, B =  22},
						new PaletteEntry() { Step = 255, R =    1, G =  13, B =   5},
					}
				},

				new FormPalette()
				{
					Name = "Secondary_01a_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =    3, G =   0, B = 255},
						new PaletteEntry() { Step = 63, R =   67, G =   7, B =  45},
						new PaletteEntry() { Step = 127, R =  255, G =  33, B =   0},
						new PaletteEntry() { Step = 191, R =   42, G = 115, B =   1},
						new PaletteEntry() { Step = 255, R =    0, G = 255, B =   1},
					}
				},

				new FormPalette()
				{
					Name = "Split_03_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =    0, G =  18, B = 123},
						new PaletteEntry() { Step = 63, R =    0, G =  75, B =  29},
						new PaletteEntry() { Step = 127, R =    0, G = 178, B =   1},
						new PaletteEntry() { Step = 191, R =   27, G =  48, B =   1},
						new PaletteEntry() { Step = 255, R =  167, G =   1, B =   2},
					}
				},

				new FormPalette()
				{
					Name = "rainbow_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =   255, G =   0, B =   0 },//  Red
                        new PaletteEntry() { Step = 32, R =   171, G =  85, B =   0 },//  Orange
                        new PaletteEntry() { Step = 64, R =   171, G = 171, B =   0},//  Yellow
                        new PaletteEntry() { Step = 96, R =     0, G = 255, B =   0},//  Green
                        new PaletteEntry() { Step = 128, R =     0, G = 171, B =  85},//  Aqua
                        new PaletteEntry() { Step = 160, R =     0, G =   0, B = 255},//  Blue
                        new PaletteEntry() { Step = 192, R =    85, G =   0, B = 171},//  Purple
                        new PaletteEntry() { Step = 224, R =   171, G =   0, B =  85},//  Pink
                        new PaletteEntry() { Step = 255, R =   255, G =   0, B =   0},
					}
				},
				new FormPalette()
				{
					Name = "cloudcolors_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =    0, G =  0, B =  255},
						new PaletteEntry() { Step = 15, R =  0, G =  0, B =  139},
						new PaletteEntry() { Step = 111, R =  0, G =  0, B =  139},
						new PaletteEntry() { Step = 127, R =  0, G =  0, B =  255},
						new PaletteEntry() { Step = 143, R =  0, G =  0, B =  139},
						new PaletteEntry() { Step = 159, R =  135, G =  206, B =  250},
						new PaletteEntry() { Step = 175, R =  135, G =  206, B =  250},
						new PaletteEntry() { Step = 191, R =  173, G =  216, B =  230},
						new PaletteEntry() { Step = 207, R =  200, G =  200, B =  200},
						new PaletteEntry() { Step = 223, R =  173, G =  216, B =  230},
						new PaletteEntry() { Step = 239, R =  135, G =  206, B =  235},
						new PaletteEntry() { Step = 255, R =  0, G =  191, B =  255},
					}
				},

				new FormPalette()
								{
									Name = "cequal_gp",
									Entries = {
						new PaletteEntry() { Step = 0, R =  1, G =  1, B =  1},
						new PaletteEntry() { Step = 36, R =  1, G =  3, B =  1},
						new PaletteEntry() { Step = 76, R =  1, G =  41, B =  123},
						new PaletteEntry() { Step = 112, R =  59, G =  1, B =  252},
						new PaletteEntry() { Step = 127, R =  117, G =  1, B =  180},
						new PaletteEntry() { Step = 172, R =  239, G =  81, B =  1},
						new PaletteEntry() { Step = 195, R =  252, G =  180, B =  1},
						new PaletteEntry() { Step = 222, R =  252, G =  250, B =  147},
						new PaletteEntry() { Step = 255, R =  252, G =  252, B =  252},
					}
				},

				new FormPalette()
				{
					Name = "purple_flower_gp",
					Entries =
					{
						new PaletteEntry() { Step = 0, R =    0, G =   0, B =   0},
						new PaletteEntry() { Step = 66, R =   20, G =   4, B =  45},
						new PaletteEntry() { Step = 132, R =  121, G =  20, B = 255},
						new PaletteEntry() { Step = 180, R =  179, G =  73, B = 255},
						new PaletteEntry() { Step = 228, R =  255, G = 164, B = 255},
						new PaletteEntry() { Step = 241, R =  255, G = 207, B = 255},
						new PaletteEntry() { Step = 255, R =  255, G = 255, B = 255},
					}
				},

				new FormPalette()
				{
					Name = "fierce_ice_gp",
					Entries = {
						new PaletteEntry() { Step = 0, R = 0, G = 0, B = 0 },
					new PaletteEntry() { Step = 59, R = 0, G = 7, B = 45 },
					new PaletteEntry() { Step = 119, R = 0, G = 33, B = 255 },
					new PaletteEntry() { Step = 149, R = 3, G = 82, B = 255 },
					new PaletteEntry() { Step = 180, R = 23, G = 156, B = 255 },
					new PaletteEntry() { Step = 217, R = 100, G = 203, B = 255 },
					new PaletteEntry() { Step = 255, R = 255, G = 255, B = 255 },

				}
				},

				new FormPalette()
						{
							Name = "blueice_gp",
							Entries = {
						new PaletteEntry() { Step = 0, R = 0, G = 0, B = 0 },
						new PaletteEntry() { Step = 31, R = 1, G = 2, B = 15 },
						new PaletteEntry() { Step = 63, R = 1, G = 10, B = 89 },
						new PaletteEntry() { Step = 66, R = 1, G = 12, B = 93 },
						new PaletteEntry() { Step = 68, R = 1, G = 13, B = 96 },
						new PaletteEntry() { Step = 71, R = 1, G = 15, B = 100 },
						new PaletteEntry() { Step = 73, R = 1, G = 16, B = 105 },
						new PaletteEntry() { Step = 76, R = 1, G = 18, B = 108 },
						new PaletteEntry() { Step = 78, R = 1, G = 20, B = 112 },
						new PaletteEntry() { Step = 81, R = 1, G = 22, B = 115 },
						new PaletteEntry() { Step = 83, R = 1, G = 23, B = 120 },
						new PaletteEntry() { Step = 86, R = 1, G = 26, B = 123 },
						new PaletteEntry() { Step = 88, R = 1, G = 29, B = 128 },
						new PaletteEntry() { Step = 91, R = 1, G = 31, B = 132 },
						new PaletteEntry() { Step = 93, R = 1, G = 33, B = 137 },
						new PaletteEntry() { Step = 96, R = 1, G = 36, B = 140 },
						new PaletteEntry() { Step = 98, R = 1, G = 40, B = 145 },
						new PaletteEntry() { Step = 101, R = 1, G = 43, B = 151 },
						new PaletteEntry() { Step = 103, R = 1, G = 46, B = 155 },
						new PaletteEntry() { Step = 106, R = 1, G = 50, B = 160 },
						new PaletteEntry() { Step = 108, R = 1, G = 54, B = 164 },
						new PaletteEntry() { Step = 111, R = 1, G = 56, B = 166 },
						new PaletteEntry() { Step = 113, R = 1, G = 60, B = 170 },
						new PaletteEntry() { Step = 116, R = 1, G = 65, B = 172 },
						new PaletteEntry() { Step = 118, R = 1, G = 69, B = 174 },
						new PaletteEntry() { Step = 121, R = 1, G = 72, B = 178 },
						new PaletteEntry() { Step = 123, R = 1, G = 77, B = 180 },
						new PaletteEntry() { Step = 126, R = 1, G = 81, B = 182 },
						new PaletteEntry() { Step = 128, R = 1, G = 86, B = 184 },
						new PaletteEntry() { Step = 131, R = 1, G = 91, B = 188 },
						new PaletteEntry() { Step = 134, R = 1, G = 96, B = 190 },
						new PaletteEntry() { Step = 136, R = 1, G = 101, B = 192 },
						new PaletteEntry() { Step = 139, R = 1, G = 107, B = 197 },
						new PaletteEntry() { Step = 141, R = 1, G = 112, B = 199 },
						new PaletteEntry() { Step = 144, R = 1, G = 118, B = 201 },
						new PaletteEntry() { Step = 146, R = 1, G = 124, B = 203 },
						new PaletteEntry() { Step = 149, R = 1, G = 130, B = 207 },
						new PaletteEntry() { Step = 151, R = 1, G = 138, B = 210 },
						new PaletteEntry() { Step = 154, R = 1, G = 144, B = 212 },
						new PaletteEntry() { Step = 156, R = 1, G = 151, B = 214 },
						new PaletteEntry() { Step = 159, R = 1, G = 159, B = 219 },
						new PaletteEntry() { Step = 161, R = 1, G = 166, B = 221 },
						new PaletteEntry() { Step = 164, R = 1, G = 173, B = 223 },
						new PaletteEntry() { Step = 166, R = 1, G = 182, B = 228 },
						new PaletteEntry() { Step = 169, R = 1, G = 189, B = 230 },
						new PaletteEntry() { Step = 171, R = 1, G = 199, B = 233 },
						new PaletteEntry() { Step = 174, R = 1, G = 207, B = 235 },
						new PaletteEntry() { Step = 176, R = 1, G = 217, B = 240 },
						new PaletteEntry() { Step = 179, R = 1, G = 225, B = 242 },
						new PaletteEntry() { Step = 181, R = 1, G = 235, B = 245 },
						new PaletteEntry() { Step = 184, R = 2, G = 246, B = 247 },
						new PaletteEntry() { Step = 186, R = 2, G = 252, B = 247 },
						new PaletteEntry() { Step = 189, R = 2, G = 255, B = 242 },
						new PaletteEntry() { Step = 222, R = 61, G = 255, B = 247 },
						new PaletteEntry() { Step = 255, R = 255, G = 255, B = 255 },
					}
				},

				new FormPalette()
					{
						Name = "twilight_gp",
						Entries = {
						new PaletteEntry() { Step = 0, R = 0, G = 0, B = 0 },
						new PaletteEntry() { Step = 2, R = 1, G = 1, B = 1 },
						new PaletteEntry() { Step = 5, R = 1, G = 1, B = 1 },
						new PaletteEntry() { Step = 7, R = 1, G = 1, B = 1 },
						new PaletteEntry() { Step = 10, R = 1, G = 1, B = 1 },
						new PaletteEntry() { Step = 12, R = 1, G = 1, B = 1 },
						new PaletteEntry() { Step = 15, R = 1, G = 1, B = 1 },
						new PaletteEntry() { Step = 17, R = 1, G = 1, B = 1 },
						new PaletteEntry() { Step = 20, R = 1, G = 1, B = 1 },
						new PaletteEntry() { Step = 22, R = 1, G = 1, B = 1 },
						new PaletteEntry() { Step = 25, R = 1, G = 1, B = 1 },
						new PaletteEntry() { Step = 27, R = 1, G = 1, B = 1 },
						new PaletteEntry() { Step = 30, R = 1, G = 1, B = 1 },
						new PaletteEntry() { Step = 32, R = 1, G = 2, B = 1 },
						new PaletteEntry() { Step = 35, R = 1, G = 2, B = 1 },
						new PaletteEntry() { Step = 37, R = 1, G = 2, B = 1 },
						new PaletteEntry() { Step = 40, R = 2, G = 3, B = 2 },
						new PaletteEntry() { Step = 42, R = 2, G = 3, B = 2 },
						new PaletteEntry() { Step = 45, R = 2, G = 3, B = 2 },
						new PaletteEntry() { Step = 47, R = 3, G = 4, B = 3 },
						new PaletteEntry() { Step = 50, R = 3, G = 4, B = 3 },
						new PaletteEntry() { Step = 53, R = 4, G = 5, B = 4 },
						new PaletteEntry() { Step = 55, R = 4, G = 5, B = 4 },
						new PaletteEntry() { Step = 58, R = 5, G = 5, B = 5 },
						new PaletteEntry() { Step = 60, R = 6, G = 6, B = 6 },
						new PaletteEntry() { Step = 63, R = 6, G = 6, B = 6 },
						new PaletteEntry() { Step = 65, R = 7, G = 7, B = 7 },
						new PaletteEntry() { Step = 68, R = 8, G = 7, B = 8 },
						new PaletteEntry() { Step = 70, R = 9, G = 8, B = 9 },
						new PaletteEntry() { Step = 73, R = 9, G = 8, B = 10 },
						new PaletteEntry() { Step = 75, R = 10, G = 8, B = 11 },
						new PaletteEntry() { Step = 78, R = 11, G = 9, B = 13 },
						new PaletteEntry() { Step = 80, R = 12, G = 9, B = 14 },
						new PaletteEntry() { Step = 83, R = 13, G = 9, B = 15 },
						new PaletteEntry() { Step = 85, R = 14, G = 10, B = 16 },
						new PaletteEntry() { Step = 88, R = 14, G = 10, B = 17 },
						new PaletteEntry() { Step = 133, R = 17, G = 14, B = 51 },
						new PaletteEntry() { Step = 136, R = 16, G = 14, B = 52 },
						new PaletteEntry() { Step = 138, R = 15, G = 14, B = 55 },
						new PaletteEntry() { Step = 141, R = 14, G = 14, B = 57 },
						new PaletteEntry() { Step = 143, R = 13, G = 14, B = 61 },
						new PaletteEntry() { Step = 146, R = 12, G = 14, B = 63 },
						new PaletteEntry() { Step = 149, R = 12, G = 14, B = 66 },
						new PaletteEntry() { Step = 151, R = 10, G = 13, B = 69 },
						new PaletteEntry() { Step = 154, R = 10, G = 13, B = 72 },
						new PaletteEntry() { Step = 156, R = 9, G = 13, B = 75 },
						new PaletteEntry() { Step = 159, R = 8, G = 13, B = 78 },
						new PaletteEntry() { Step = 161, R = 7, G = 14, B = 82 },
						new PaletteEntry() { Step = 164, R = 7, G = 16, B = 84 },
						new PaletteEntry() { Step = 166, R = 7, G = 17, B = 88 },
						new PaletteEntry() { Step = 169, R = 7, G = 19, B = 91 },
						new PaletteEntry() { Step = 171, R = 7, G = 21, B = 95 },
						new PaletteEntry() { Step = 174, R = 7, G = 22, B = 98 },
						new PaletteEntry() { Step = 176, R = 7, G = 25, B = 102 },
						new PaletteEntry() { Step = 179, R = 6, G = 27, B = 105 },
						new PaletteEntry() { Step = 181, R = 6, G = 29, B = 109 },
						new PaletteEntry() { Step = 184, R = 6, G = 32, B = 112 },
						new PaletteEntry() { Step = 186, R = 7, G = 37, B = 117 },
						new PaletteEntry() { Step = 189, R = 8, G = 42, B = 120 },
						new PaletteEntry() { Step = 191, R = 9, G = 47, B = 125 },
						new PaletteEntry() { Step = 194, R = 10, G = 54, B = 128 },
						new PaletteEntry() { Step = 196, R = 11, G = 59, B = 132 },
						new PaletteEntry() { Step = 199, R = 12, G = 66, B = 137 },
						new PaletteEntry() { Step = 201, R = 14, G = 73, B = 140 },
						new PaletteEntry() { Step = 204, R = 16, G = 80, B = 145 },
						new PaletteEntry() { Step = 206, R = 18, G = 87, B = 149 },
						new PaletteEntry() { Step = 208, R = 20, G = 95, B = 153 },
						new PaletteEntry() { Step = 211, R = 22, G = 103, B = 158 },
						new PaletteEntry() { Step = 213, R = 24, G = 111, B = 162 },
						new PaletteEntry() { Step = 216, R = 27, G = 119, B = 168 },
						new PaletteEntry() { Step = 218, R = 30, G = 128, B = 172 },
						new PaletteEntry() { Step = 221, R = 32, G = 138, B = 176 },
						new PaletteEntry() { Step = 223, R = 35, G = 147, B = 182 },
						new PaletteEntry() { Step = 226, R = 39, G = 156, B = 186 },
						new PaletteEntry() { Step = 228, R = 42, G = 166, B = 192 },
						new PaletteEntry() { Step = 231, R = 46, G = 176, B = 197 },
						new PaletteEntry() { Step = 233, R = 52, G = 182, B = 201 },
						new PaletteEntry() { Step = 235, R = 58, G = 187, B = 207 },
						new PaletteEntry() { Step = 238, R = 65, G = 193, B = 212 },
						new PaletteEntry() { Step = 240, R = 73, G = 199, B = 219 },
						new PaletteEntry() { Step = 242, R = 80, G = 205, B = 223 },
						new PaletteEntry() { Step = 245, R = 90, G = 213, B = 230 },
						new PaletteEntry() { Step = 247, R = 100, G = 219, B = 235 },
						new PaletteEntry() { Step = 250, R = 109, G = 225, B = 242 },
						new PaletteEntry() { Step = 252, R = 120, G = 231, B = 247 },
						new PaletteEntry() { Step = 255, R = 132, G = 237, B = 255 },

					}
				},

				new FormPalette()
				{
					Name = "green_gp",
					Entries = {
						new PaletteEntry() { Step = 0, R = 0, G = 0, B = 0 },
						new PaletteEntry() { Step = 63, R = 0, G = 17, B = 0 },
						new PaletteEntry() { Step = 126, R = 0, G = 82, B = 0 },
						new PaletteEntry() { Step = 155, R = 0, G = 128, B = 0 },
						new PaletteEntry() { Step = 184, R = 0, G = 186, B = 0 },
						new PaletteEntry() { Step = 219, R = 42, G = 219, B = 45 },
						new PaletteEntry() { Step = 255, R = 255, G = 255, B = 255 },

					}
				},

				new FormPalette()
				{
					Name = "ultraviolet_mold_gp",
					Entries = {
						new PaletteEntry() { Step = 0, R = 0, G = 0, B = 0 },
						new PaletteEntry() { Step = 2, R = 1, G = 1, B = 1 },
						new PaletteEntry() { Step = 5, R = 1, G = 1, B = 1 },
						new PaletteEntry() { Step = 7, R = 1, G = 1, B = 1 },
						new PaletteEntry() { Step = 10, R = 1, G = 1, B = 1 },
						new PaletteEntry() { Step = 12, R = 1, G = 1, B = 1 },
						new PaletteEntry() { Step = 15, R = 1, G = 1, B = 1 },
						new PaletteEntry() { Step = 17, R = 1, G = 1, B = 1 },
						new PaletteEntry() { Step = 20, R = 1, G = 1, B = 1 },
						new PaletteEntry() { Step = 22, R = 1, G = 1, B = 1 },
						new PaletteEntry() { Step = 25, R = 1, G = 1, B = 1 },
						new PaletteEntry() { Step = 27, R = 1, G = 1, B = 1 },
						new PaletteEntry() { Step = 30, R = 1, G = 1, B = 1 },
						new PaletteEntry() { Step = 32, R = 1, G = 2, B = 1 },
						new PaletteEntry() { Step = 35, R = 1, G = 2, B = 1 },
						new PaletteEntry() { Step = 37, R = 1, G = 2, B = 2 },
						new PaletteEntry() { Step = 40, R = 2, G = 3, B = 2 },
						new PaletteEntry() { Step = 42, R = 2, G = 3, B = 2 },
						new PaletteEntry() { Step = 45, R = 2, G = 3, B = 3 },
						new PaletteEntry() { Step = 47, R = 3, G = 4, B = 3 },
						new PaletteEntry() { Step = 50, R = 3, G = 4, B = 4 },
						new PaletteEntry() { Step = 53, R = 3, G = 4, B = 5 },
						new PaletteEntry() { Step = 55, R = 4, G = 5, B = 5 },
						new PaletteEntry() { Step = 58, R = 4, G = 5, B = 6 },
						new PaletteEntry() { Step = 60, R = 4, G = 5, B = 7 },
						new PaletteEntry() { Step = 63, R = 5, G = 6, B = 7 },
						new PaletteEntry() { Step = 65, R = 5, G = 6, B = 8 },
						new PaletteEntry() { Step = 68, R = 5, G = 7, B = 9 },
						new PaletteEntry() { Step = 70, R = 5, G = 7, B = 10 },
						new PaletteEntry() { Step = 73, R = 6, G = 8, B = 11 },
						new PaletteEntry() { Step = 75, R = 6, G = 8, B = 12 },
						new PaletteEntry() { Step = 78, R = 6, G = 8, B = 13 },
						new PaletteEntry() { Step = 80, R = 6, G = 9, B = 14 },
						new PaletteEntry() { Step = 83, R = 6, G = 9, B = 15 },
						new PaletteEntry() { Step = 85, R = 6, G = 9, B = 16 },
						new PaletteEntry() { Step = 131, R = 7, G = 52, B = 48 },
						new PaletteEntry() { Step = 133, R = 7, G = 57, B = 51 },
						new PaletteEntry() { Step = 136, R = 7, G = 63, B = 52 },
						new PaletteEntry() { Step = 138, R = 7, G = 67, B = 52 },
						new PaletteEntry() { Step = 141, R = 7, G = 69, B = 50 },
						new PaletteEntry() { Step = 143, R = 7, G = 72, B = 48 },
						new PaletteEntry() { Step = 146, R = 7, G = 74, B = 46 },
						new PaletteEntry() { Step = 148, R = 7, G = 78, B = 43 },
						new PaletteEntry() { Step = 151, R = 6, G = 80, B = 41 },
						new PaletteEntry() { Step = 154, R = 6, G = 84, B = 37 },
						new PaletteEntry() { Step = 156, R = 6, G = 87, B = 34 },
						new PaletteEntry() { Step = 159, R = 6, G = 90, B = 31 },
						new PaletteEntry() { Step = 161, R = 6, G = 93, B = 28 },
						new PaletteEntry() { Step = 164, R = 5, G = 96, B = 25 },
						new PaletteEntry() { Step = 166, R = 5, G = 100, B = 22 },
						new PaletteEntry() { Step = 169, R = 5, G = 103, B = 18 },
						new PaletteEntry() { Step = 171, R = 5, G = 107, B = 15 },
						new PaletteEntry() { Step = 174, R = 5, G = 109, B = 13 },
						new PaletteEntry() { Step = 176, R = 5, G = 114, B = 10 },
						new PaletteEntry() { Step = 179, R = 4, G = 117, B = 7 },
						new PaletteEntry() { Step = 181, R = 4, G = 121, B = 5 },
						new PaletteEntry() { Step = 184, R = 5, G = 124, B = 5 },
						new PaletteEntry() { Step = 186, R = 7, G = 128, B = 4 },
						new PaletteEntry() { Step = 189, R = 9, G = 131, B = 4 },
						new PaletteEntry() { Step = 191, R = 12, G = 136, B = 4 },
						new PaletteEntry() { Step = 194, R = 16, G = 139, B = 4 },
						new PaletteEntry() { Step = 196, R = 20, G = 144, B = 3 },
						new PaletteEntry() { Step = 199, R = 25, G = 147, B = 3 },
						new PaletteEntry() { Step = 201, R = 30, G = 152, B = 3 },
						new PaletteEntry() { Step = 204, R = 38, G = 157, B = 3 },
						new PaletteEntry() { Step = 207, R = 46, G = 161, B = 2 },
						new PaletteEntry() { Step = 209, R = 55, G = 166, B = 2 },
						new PaletteEntry() { Step = 212, R = 67, G = 169, B = 2 },
						new PaletteEntry() { Step = 214, R = 80, G = 175, B = 2 },
						new PaletteEntry() { Step = 217, R = 95, G = 178, B = 1 },
						new PaletteEntry() { Step = 219, R = 113, G = 184, B = 1 },
						new PaletteEntry() { Step = 222, R = 133, G = 187, B = 1 },
						new PaletteEntry() { Step = 224, R = 157, G = 193, B = 1 },
						new PaletteEntry() { Step = 227, R = 184, G = 197, B = 1 },
						new PaletteEntry() { Step = 229, R = 194, G = 184, B = 1 },
						new PaletteEntry() { Step = 232, R = 199, G = 168, B = 1 },
						new PaletteEntry() { Step = 234, R = 206, G = 152, B = 1 },
						new PaletteEntry() { Step = 237, R = 210, G = 135, B = 1 },
						new PaletteEntry() { Step = 239, R = 217, G = 119, B = 1 },
						new PaletteEntry() { Step = 242, R = 222, G = 103, B = 1 },
						new PaletteEntry() { Step = 244, R = 229, G = 88, B = 1 },
						new PaletteEntry() { Step = 247, R = 234, G = 73, B = 1 },
						new PaletteEntry() { Step = 249, R = 242, G = 59, B = 1 },
						new PaletteEntry() { Step = 252, R = 247, G = 47, B = 1 },
						new PaletteEntry() { Step = 255, R = 255, G = 36, B = 1 },

					}
				},

				new FormPalette()
				{
					Name = "apple_green_gp",
					Entries = {
						new PaletteEntry() { Step = 0, R = 0, G = 0, B = 0 },
						new PaletteEntry() { Step = 2, R = 1, G = 1, B = 1 },
						new PaletteEntry() { Step = 4, R = 1, G = 1, B = 1 },
						new PaletteEntry() { Step = 7, R = 1, G = 1, B = 1 },
						new PaletteEntry() { Step = 10, R = 1, G = 1, B = 1 },
						new PaletteEntry() { Step = 12, R = 1, G = 1, B = 1 },
						new PaletteEntry() { Step = 15, R = 1, G = 1, B = 1 },
						new PaletteEntry() { Step = 17, R = 1, G = 1, B = 1 },
						new PaletteEntry() { Step = 20, R = 1, G = 1, B = 1 },
						new PaletteEntry() { Step = 22, R = 1, G = 1, B = 1 },
						new PaletteEntry() { Step = 25, R = 1, G = 1, B = 1 },
						new PaletteEntry() { Step = 27, R = 1, G = 1, B = 1 },
						new PaletteEntry() { Step = 30, R = 1, G = 2, B = 1 },
						new PaletteEntry() { Step = 32, R = 1, G = 2, B = 1 },
						new PaletteEntry() { Step = 35, R = 1, G = 3, B = 1 },
						new PaletteEntry() { Step = 37, R = 1, G = 3, B = 1 },
						new PaletteEntry() { Step = 40, R = 1, G = 4, B = 1 },
						new PaletteEntry() { Step = 42, R = 1, G = 5, B = 1 },
						new PaletteEntry() { Step = 45, R = 1, G = 5, B = 1 },
						new PaletteEntry() { Step = 47, R = 1, G = 6, B = 1 },
						new PaletteEntry() { Step = 50, R = 1, G = 7, B = 1 },
						new PaletteEntry() { Step = 52, R = 1, G = 8, B = 1 },
						new PaletteEntry() { Step = 55, R = 1, G = 8, B = 1 },
						new PaletteEntry() { Step = 57, R = 1, G = 9, B = 2 },
						new PaletteEntry() { Step = 60, R = 1, G = 10, B = 2 },
						new PaletteEntry() { Step = 62, R = 1, G = 11, B = 3 },
						new PaletteEntry() { Step = 65, R = 1, G = 12, B = 4 },
						new PaletteEntry() { Step = 67, R = 1, G = 13, B = 5 },
						new PaletteEntry() { Step = 70, R = 1, G = 14, B = 7 },
						new PaletteEntry() { Step = 72, R = 1, G = 16, B = 7 },
						new PaletteEntry() { Step = 75, R = 1, G = 17, B = 8 },
						new PaletteEntry() { Step = 77, R = 1, G = 18, B = 8 },
						new PaletteEntry() { Step = 80, R = 1, G = 19, B = 8 },
						new PaletteEntry() { Step = 82, R = 1, G = 21, B = 9 },
						new PaletteEntry() { Step = 85, R = 1, G = 22, B = 9 },
						new PaletteEntry() { Step = 87, R = 1, G = 24, B = 9 },
						new PaletteEntry() { Step = 130, R = 1, G = 58, B = 8 },
						new PaletteEntry() { Step = 133, R = 1, G = 60, B = 7 },
						new PaletteEntry() { Step = 135, R = 1, G = 63, B = 7 },
						new PaletteEntry() { Step = 138, R = 1, G = 66, B = 6 },
						new PaletteEntry() { Step = 141, R = 1, G = 69, B = 6 },
						new PaletteEntry() { Step = 143, R = 1, G = 71, B = 5 },
						new PaletteEntry() { Step = 146, R = 1, G = 74, B = 5 },
						new PaletteEntry() { Step = 148, R = 1, G = 78, B = 4 },
						new PaletteEntry() { Step = 151, R = 1, G = 80, B = 4 },
						new PaletteEntry() { Step = 153, R = 1, G = 84, B = 3 },
						new PaletteEntry() { Step = 156, R = 1, G = 86, B = 3 },
						new PaletteEntry() { Step = 158, R = 1, G = 90, B = 2 },
						new PaletteEntry() { Step = 161, R = 1, G = 92, B = 2 },
						new PaletteEntry() { Step = 163, R = 1, G = 96, B = 1 },
						new PaletteEntry() { Step = 166, R = 1, G = 99, B = 1 },
						new PaletteEntry() { Step = 168, R = 1, G = 103, B = 1 },
						new PaletteEntry() { Step = 171, R = 1, G = 105, B = 1 },
						new PaletteEntry() { Step = 173, R = 2, G = 109, B = 1 },
						new PaletteEntry() { Step = 176, R = 2, G = 112, B = 1 },
						new PaletteEntry() { Step = 179, R = 3, G = 117, B = 1 },
						new PaletteEntry() { Step = 181, R = 3, G = 119, B = 1 },
						new PaletteEntry() { Step = 184, R = 4, G = 124, B = 1 },
						new PaletteEntry() { Step = 186, R = 5, G = 128, B = 1 },
						new PaletteEntry() { Step = 189, R = 5, G = 131, B = 1 },
						new PaletteEntry() { Step = 191, R = 6, G = 136, B = 1 },
						new PaletteEntry() { Step = 194, R = 7, G = 139, B = 1 },
						new PaletteEntry() { Step = 196, R = 9, G = 144, B = 1 },
						new PaletteEntry() { Step = 199, R = 10, G = 147, B = 1 },
						new PaletteEntry() { Step = 201, R = 11, G = 152, B = 1 },
						new PaletteEntry() { Step = 204, R = 13, G = 156, B = 1 },
						new PaletteEntry() { Step = 206, R = 15, G = 161, B = 1 },
						new PaletteEntry() { Step = 209, R = 17, G = 164, B = 1 },
						new PaletteEntry() { Step = 211, R = 19, G = 169, B = 1 },
						new PaletteEntry() { Step = 214, R = 22, G = 173, B = 1 },
						new PaletteEntry() { Step = 217, R = 24, G = 178, B = 1 },
						new PaletteEntry() { Step = 219, R = 27, G = 184, B = 1 },
						new PaletteEntry() { Step = 222, R = 31, G = 187, B = 1 },
						new PaletteEntry() { Step = 224, R = 35, G = 193, B = 1 },
						new PaletteEntry() { Step = 227, R = 39, G = 197, B = 1 },
						new PaletteEntry() { Step = 229, R = 44, G = 203, B = 1 },
						new PaletteEntry() { Step = 232, R = 49, G = 207, B = 1 },
						new PaletteEntry() { Step = 234, R = 54, G = 213, B = 1 },
						new PaletteEntry() { Step = 237, R = 60, G = 217, B = 1 },
						new PaletteEntry() { Step = 239, R = 67, G = 223, B = 1 },
						new PaletteEntry() { Step = 242, R = 74, G = 227, B = 1 },
						new PaletteEntry() { Step = 244, R = 82, G = 233, B = 1 },
						new PaletteEntry() { Step = 247, R = 91, G = 237, B = 1 },
						new PaletteEntry() { Step = 249, R = 100, G = 244, B = 1 },
						new PaletteEntry() { Step = 252, R = 110, G = 248, B = 1 },
						new PaletteEntry() { Step = 255, R = 121, G = 255, B = 0 },

					}
				},

				new FormPalette()
				{
					Name = "faint_rainbow_gp",
					Entries = {
						new PaletteEntry() { Step = 0, R = 67, G = 0, B = 71 },
						new PaletteEntry() { Step = 2, R = 69, G = 1, B = 65 },
						new PaletteEntry() { Step = 5, R = 72, G = 1, B = 59 },
						new PaletteEntry() { Step = 7, R = 74, G = 1, B = 53 },
						new PaletteEntry() { Step = 10, R = 77, G = 1, B = 48 },
						new PaletteEntry() { Step = 12, R = 78, G = 1, B = 43 },
						new PaletteEntry() { Step = 15, R = 80, G = 1, B = 38 },
						new PaletteEntry() { Step = 17, R = 83, G = 1, B = 34 },
						new PaletteEntry() { Step = 20, R = 86, G = 1, B = 29 },
						new PaletteEntry() { Step = 22, R = 88, G = 1, B = 25 },
						new PaletteEntry() { Step = 25, R = 91, G = 1, B = 22 },
						new PaletteEntry() { Step = 27, R = 94, G = 1, B = 18 },
						new PaletteEntry() { Step = 30, R = 97, G = 1, B = 15 },
						new PaletteEntry() { Step = 32, R = 98, G = 1, B = 12 },
						new PaletteEntry() { Step = 35, R = 101, G = 1, B = 10 },
						new PaletteEntry() { Step = 37, R = 104, G = 1, B = 7 },
						new PaletteEntry() { Step = 40, R = 107, G = 1, B = 5 },
						new PaletteEntry() { Step = 42, R = 110, G = 1, B = 4 },
						new PaletteEntry() { Step = 45, R = 113, G = 1, B = 2 },
						new PaletteEntry() { Step = 47, R = 117, G = 1, B = 1 },
						new PaletteEntry() { Step = 50, R = 120, G = 1, B = 1 },
						new PaletteEntry() { Step = 53, R = 121, G = 1, B = 1 },
						new PaletteEntry() { Step = 55, R = 125, G = 1, B = 1 },
						new PaletteEntry() { Step = 58, R = 128, G = 1, B = 1 },
						new PaletteEntry() { Step = 60, R = 132, G = 3, B = 1 },
						new PaletteEntry() { Step = 63, R = 135, G = 5, B = 1 },
						new PaletteEntry() { Step = 65, R = 139, G = 8, B = 1 },
						new PaletteEntry() { Step = 68, R = 142, G = 12, B = 1 },
						new PaletteEntry() { Step = 70, R = 144, G = 14, B = 1 },
						new PaletteEntry() { Step = 73, R = 144, G = 16, B = 1 },
						new PaletteEntry() { Step = 75, R = 146, G = 17, B = 1 },
						new PaletteEntry() { Step = 78, R = 148, G = 19, B = 1 },
						new PaletteEntry() { Step = 80, R = 148, G = 22, B = 1 },
						new PaletteEntry() { Step = 83, R = 150, G = 23, B = 1 },
						new PaletteEntry() { Step = 85, R = 152, G = 26, B = 1 },
						new PaletteEntry() { Step = 131, R = 175, G = 88, B = 1 },
						new PaletteEntry() { Step = 133, R = 177, G = 93, B = 1 },
						new PaletteEntry() { Step = 136, R = 179, G = 99, B = 1 },
						new PaletteEntry() { Step = 138, R = 179, G = 104, B = 1 },
						new PaletteEntry() { Step = 141, R = 182, G = 108, B = 1 },
						new PaletteEntry() { Step = 143, R = 184, G = 114, B = 1 },
						new PaletteEntry() { Step = 146, R = 184, G = 119, B = 1 },
						new PaletteEntry() { Step = 148, R = 186, G = 125, B = 1 },
						new PaletteEntry() { Step = 151, R = 188, G = 131, B = 1 },
						new PaletteEntry() { Step = 154, R = 188, G = 138, B = 1 },
						new PaletteEntry() { Step = 156, R = 190, G = 144, B = 1 },
						new PaletteEntry() { Step = 159, R = 192, G = 151, B = 1 },
						new PaletteEntry() { Step = 161, R = 192, G = 157, B = 1 },
						new PaletteEntry() { Step = 164, R = 194, G = 164, B = 1 },
						new PaletteEntry() { Step = 166, R = 197, G = 171, B = 1 },
						new PaletteEntry() { Step = 169, R = 199, G = 178, B = 1 },
						new PaletteEntry() { Step = 171, R = 199, G = 186, B = 1 },
						new PaletteEntry() { Step = 174, R = 201, G = 193, B = 1 },
						new PaletteEntry() { Step = 176, R = 203, G = 201, B = 2 },
						new PaletteEntry() { Step = 179, R = 203, G = 209, B = 2 },
						new PaletteEntry() { Step = 181, R = 201, G = 213, B = 2 },
						new PaletteEntry() { Step = 184, R = 197, G = 215, B = 2 },
						new PaletteEntry() { Step = 186, R = 190, G = 215, B = 2 },
						new PaletteEntry() { Step = 189, R = 184, G = 217, B = 2 },
						new PaletteEntry() { Step = 191, R = 179, G = 219, B = 2 },
						new PaletteEntry() { Step = 194, R = 173, G = 219, B = 2 },
						new PaletteEntry() { Step = 196, R = 167, G = 221, B = 2 },
						new PaletteEntry() { Step = 199, R = 161, G = 223, B = 2 },
						new PaletteEntry() { Step = 201, R = 157, G = 223, B = 2 },
						new PaletteEntry() { Step = 204, R = 152, G = 225, B = 2 },
						new PaletteEntry() { Step = 207, R = 146, G = 227, B = 2 },
						new PaletteEntry() { Step = 209, R = 142, G = 229, B = 2 },
						new PaletteEntry() { Step = 212, R = 137, G = 229, B = 2 },
						new PaletteEntry() { Step = 214, R = 132, G = 231, B = 3 },
						new PaletteEntry() { Step = 217, R = 126, G = 233, B = 3 },
						new PaletteEntry() { Step = 219, R = 121, G = 233, B = 3 },
						new PaletteEntry() { Step = 222, R = 118, G = 235, B = 3 },
						new PaletteEntry() { Step = 224, R = 113, G = 237, B = 3 },
						new PaletteEntry() { Step = 227, R = 109, G = 237, B = 3 },
						new PaletteEntry() { Step = 229, R = 104, G = 239, B = 3 },
						new PaletteEntry() { Step = 232, R = 101, G = 241, B = 3 },
						new PaletteEntry() { Step = 234, R = 97, G = 241, B = 3 },
						new PaletteEntry() { Step = 237, R = 92, G = 244, B = 3 },
						new PaletteEntry() { Step = 239, R = 88, G = 246, B = 3 },
						new PaletteEntry() { Step = 242, R = 84, G = 248, B = 4 },
						new PaletteEntry() { Step = 244, R = 80, G = 248, B = 4 },
						new PaletteEntry() { Step = 247, R = 78, G = 250, B = 4 },
						new PaletteEntry() { Step = 249, R = 74, G = 252, B = 4 },
						new PaletteEntry() { Step = 252, R = 71, G = 252, B = 4 },
						new PaletteEntry() { Step = 255, R = 67, G = 255, B = 4 },

					}
				},

				new FormPalette()
				{
					Name = "otis_gp",
					Entries = {
						new PaletteEntry() { Step = 0, R = 26, G = 1, B = 89 },
						new PaletteEntry() { Step = 127, R = 17, G = 193, B = 0 },
						new PaletteEntry() { Step = 216, R = 0, G = 34, B = 98 },
						new PaletteEntry() { Step = 255, R = 0, G = 34, B = 98 },

					}
				},

				new FormPalette()
				{
					Name = "parrot_gp",
					Entries = {
						new PaletteEntry() { Step = 0, R = 126, G = 0, B = 1 },
						new PaletteEntry() { Step = 114, R = 197, G = 168, B = 16 },
						new PaletteEntry() { Step = 140, R = 197, G = 168, B = 16 },
						new PaletteEntry() { Step = 216, R = 0, G = 2, B = 32 },
						new PaletteEntry() { Step = 255, R = 0, G = 2, B = 32 },

					}
				},



				new FormPalette()
				{
					Name = "scoutie_gp",
					Entries = {
						new PaletteEntry() { Step = 0, R = 255, G = 156, B = 0 },
						new PaletteEntry() { Step = 127, R = 0, G = 195, B = 18 },
						new PaletteEntry() { Step = 216, R = 1, G = 0, B = 39 },
						new PaletteEntry() { Step = 255, R = 1, G = 0, B = 39 },

					}
				},

				new FormPalette()
				{
					Name = "sunlitwave_gp",
					Entries = {
						new PaletteEntry() { Step = 0, R = 5, G = 9, B = 84 },
						new PaletteEntry() { Step = 45, R = 37, G = 24, B = 111 },
						new PaletteEntry() { Step = 81, R = 16, G = 5, B = 59 },
						new PaletteEntry() { Step = 112, R = 24, G = 1, B = 20 },
						new PaletteEntry() { Step = 150, R = 34, G = 1, B = 2 },
						new PaletteEntry() { Step = 198, R = 175, G = 36, B = 7 },
						new PaletteEntry() { Step = 237, R = 208, G = 104, B = 16 },
						new PaletteEntry() { Step = 255, R = 239, G = 211, B = 158 },

					}
				},

				new FormPalette()
				{
					Name = "GMT_cool_gp",
					Entries = {
						new PaletteEntry() { Step = 0, R = 0, G = 255, B = 255 },
						new PaletteEntry() { Step = 255, R = 255, G = 0, B = 255 },

					}
				},
				new FormPalette()
				{
					Name = "bhw1_sunconure_gp",
					Entries = {
						new PaletteEntry() { Step = 0, R = 20, G = 223, B = 13 },
						new PaletteEntry() { Step = 160, R = 232, G = 65, B = 1 },
						new PaletteEntry() { Step = 252, R = 232, G = 5, B = 1 },
						new PaletteEntry() { Step = 255, R = 232, G = 5, B = 1 },

					}
				},

				new FormPalette()
				{
					Name = "bhw1_05_gp",
					Entries= {
						new PaletteEntry() { Step = 0, R = 1, G = 221, B = 53 },
						new PaletteEntry() { Step = 255, R = 73, G = 3, B = 178 },

					}
				},

				new FormPalette()
				{
					Name = "bhw2_turq_gp",
					Entries = {
						new PaletteEntry() { Step = 0, R = 1, G = 33, B = 95 },
						new PaletteEntry() { Step = 38, R = 1, G = 107, B = 37 },
						new PaletteEntry() { Step = 76, R = 42, G = 255, B = 45 },
						new PaletteEntry() { Step = 127, R = 255, G = 255, B = 45 },
						new PaletteEntry() { Step = 178, R = 42, G = 255, B = 45 },
						new PaletteEntry() { Step = 216, R = 1, G = 107, B = 37 },
						new PaletteEntry() { Step = 255, R = 1, G = 33, B = 95 },

					}
				},

				new FormPalette()
				{
					Name = "bhw3_13_gp",
					Entries = {
						new PaletteEntry() { Step = 0, R = 3, G = 6, B = 72 },
						new PaletteEntry() { Step = 38, R = 12, G = 50, B = 188 },
						new PaletteEntry() { Step = 109, R = 217, G = 35, B = 1 },
						new PaletteEntry() { Step = 135, R = 242, G = 175, B = 12 },
						new PaletteEntry() { Step = 178, R = 161, G = 32, B = 87 },
						new PaletteEntry() { Step = 255, R = 24, G = 6, B = 108 },

					}
				},

				new FormPalette()
				{
					Name = "bhw3_61_gp",
					Entries = {
						new PaletteEntry() { Step = 0, R = 14, G = 1, B = 27 },
						new PaletteEntry() { Step = 48, R = 17, G = 1, B = 88 },
						new PaletteEntry() { Step = 104, R = 1, G = 88, B = 156 },
						new PaletteEntry() { Step = 160, R = 1, G = 54, B = 42 },
						new PaletteEntry() { Step = 219, R = 9, G = 235, B = 52 },
						new PaletteEntry() { Step = 255, R = 139, G = 235, B = 233 },

					}
				},

				new FormPalette()
				{
					Name = "bhw3_34_gp",
					Entries = {
						new PaletteEntry() { Step = 0, R = 29, G = 112, B = 205 },
						new PaletteEntry() { Step = 48, R = 92, G = 255, B = 250 },
						new PaletteEntry() { Step = 91, R = 52, G = 223, B = 12 },
						new PaletteEntry() { Step = 124, R = 4, G = 13, B = 21 },
						new PaletteEntry() { Step = 183, R = 9, G = 103, B = 15 },
						new PaletteEntry() { Step = 216, R = 10, G = 80, B = 2 },
						new PaletteEntry() { Step = 255, R = 38, G = 255, B = 52 },

					}
				},

				new FormPalette()
				{
					Name = "bhw4_009_gp",
					Entries = {
						new PaletteEntry() { Step = 0, R = 66, G = 186, B = 192 },
						new PaletteEntry() { Step = 43, R = 1, G = 22, B = 71 },
						new PaletteEntry() { Step = 79, R = 2, G = 104, B = 142 },
						new PaletteEntry() { Step = 117, R = 66, G = 186, B = 192 },
						new PaletteEntry() { Step = 147, R = 2, G = 104, B = 142 },
						new PaletteEntry() { Step = 186, R = 1, G = 22, B = 71 },
						new PaletteEntry() { Step = 224, R = 2, G = 104, B = 142 },
						new PaletteEntry() { Step = 255, R = 4, G = 27, B = 28 },

					}
				},

				new FormPalette()
				{
					Name = "es_emerald_dragon_09_gp",
					Entries = {
						new PaletteEntry() { Step = 0, R = 1, G = 1, B = 1 },
						new PaletteEntry() { Step = 76, R = 1, G = 2, B = 1 },
						new PaletteEntry() { Step = 153, R = 10, G = 47, B = 1 },
						new PaletteEntry() { Step = 255, R = 97, G = 255, B = 1 },

					}
				},

				new FormPalette()
				{
					Name = "xanidu_2_gp",
					Entries = {
						new PaletteEntry() { Step = 0, R = 118, G = 161, B = 226 },
						new PaletteEntry() { Step = 53, R = 79, G = 1, B = 162 },
						new PaletteEntry() { Step = 94, R = 67, G = 1, B = 7 },
						new PaletteEntry() { Step = 132, R = 1, G = 55, B = 156 },
						new PaletteEntry() { Step = 173, R = 1, G = 127, B = 61 },
						new PaletteEntry() { Step = 211, R = 39, G = 45, B = 72 },
						new PaletteEntry() { Step = 255, R = 118, G = 161, B = 226 },

					}
				},

				new FormPalette()
				{
					Name = "water1_gp",
					Entries = {
						new PaletteEntry() { Step = 0, R = 1, G = 1, B = 46 },
						new PaletteEntry() { Step = 28, R = 79, G = 136, B = 190 },
						new PaletteEntry() { Step = 53, R = 16, G = 81, B = 184 },
						new PaletteEntry() { Step = 73, R = 79, G = 136, B = 190 },
						new PaletteEntry() { Step = 99, R = 75, G = 201, B = 233 },
						new PaletteEntry() { Step = 124, R = 6, G = 12, B = 103 },
						new PaletteEntry() { Step = 158, R = 75, G = 201, B = 233 },
						new PaletteEntry() { Step = 186, R = 84, G = 109, B = 108 },
						new PaletteEntry() { Step = 198, R = 16, G = 81, B = 184 },
						new PaletteEntry() { Step = 232, R = 79, G = 136, B = 190 },
						new PaletteEntry() { Step = 255, R = 1, G = 1, B = 46 },

					}
				},

				new FormPalette()
				{
					Name = "stratosphere_sunset_gp",
					Entries = {
						new PaletteEntry() { Step = 0, R = 1, G = 2, B = 9 },
						new PaletteEntry() { Step = 4, R = 1, G = 2, B = 9 },
						new PaletteEntry() { Step = 8, R = 1, G = 2, B = 10 },
						new PaletteEntry() { Step = 13, R = 1, G = 2, B = 11 },
						new PaletteEntry() { Step = 17, R = 1, G = 2, B = 11 },
						new PaletteEntry() { Step = 21, R = 1, G = 3, B = 13 },
						new PaletteEntry() { Step = 26, R = 1, G = 3, B = 15 },
						new PaletteEntry() { Step = 30, R = 1, G = 3, B = 16 },
						new PaletteEntry() { Step = 35, R = 1, G = 4, B = 18 },
						new PaletteEntry() { Step = 39, R = 1, G = 4, B = 19 },
						new PaletteEntry() { Step = 43, R = 1, G = 4, B = 21 },
						new PaletteEntry() { Step = 48, R = 1, G = 5, B = 23 },
						new PaletteEntry() { Step = 52, R = 1, G = 5, B = 27 },
						new PaletteEntry() { Step = 57, R = 1, G = 6, B = 32 },
						new PaletteEntry() { Step = 61, R = 1, G = 7, B = 38 },
						new PaletteEntry() { Step = 65, R = 1, G = 9, B = 49 },
						new PaletteEntry() { Step = 70, R = 1, G = 11, B = 61 },
						new PaletteEntry() { Step = 74, R = 1, G = 17, B = 80 },
						new PaletteEntry() { Step = 79, R = 1, G = 23, B = 103 },
						new PaletteEntry() { Step = 83, R = 1, G = 31, B = 135 },
						new PaletteEntry() { Step = 87, R = 2, G = 42, B = 172 },
						new PaletteEntry() { Step = 92, R = 4, G = 48, B = 190 },
						new PaletteEntry() { Step = 96, R = 9, G = 54, B = 210 },
						new PaletteEntry() { Step = 101, R = 11, G = 55, B = 214 },
						new PaletteEntry() { Step = 105, R = 13, G = 58, B = 221 },
						new PaletteEntry() { Step = 109, R = 16, G = 60, B = 219 },
						new PaletteEntry() { Step = 114, R = 19, G = 62, B = 216 },
						new PaletteEntry() { Step = 118, R = 24, G = 66, B = 210 },
						new PaletteEntry() { Step = 123, R = 30, G = 69, B = 201 },
						new PaletteEntry() { Step = 127, R = 35, G = 70, B = 180 },
						new PaletteEntry() { Step = 131, R = 39, G = 70, B = 162 },
						new PaletteEntry() { Step = 136, R = 64, G = 84, B = 144 },
						new PaletteEntry() { Step = 140, R = 97, G = 97, B = 128 },
						new PaletteEntry() { Step = 145, R = 148, G = 121, B = 123 },
						new PaletteEntry() { Step = 149, R = 210, G = 146, B = 119 },
						new PaletteEntry() { Step = 153, R = 184, G = 122, B = 92 },
						new PaletteEntry() { Step = 158, R = 159, G = 100, B = 69 },
						new PaletteEntry() { Step = 162, R = 133, G = 68, B = 33 },
						new PaletteEntry() { Step = 167, R = 110, G = 42, B = 11 },
						new PaletteEntry() { Step = 171, R = 152, G = 53, B = 6 },
						new PaletteEntry() { Step = 175, R = 203, G = 65, B = 3 },
						new PaletteEntry() { Step = 180, R = 222, G = 99, B = 5 },
						new PaletteEntry() { Step = 184, R = 242, G = 142, B = 7 },
						new PaletteEntry() { Step = 189, R = 222, G = 122, B = 5 },
						new PaletteEntry() { Step = 193, R = 203, G = 105, B = 3 },
						new PaletteEntry() { Step = 197, R = 208, G = 73, B = 1 },
						new PaletteEntry() { Step = 202, R = 210, G = 48, B = 1 },
						new PaletteEntry() { Step = 206, R = 222, G = 45, B = 1 },
						new PaletteEntry() { Step = 211, R = 234, G = 42, B = 1 },
						new PaletteEntry() { Step = 215, R = 150, G = 23, B = 1 },
						new PaletteEntry() { Step = 219, R = 86, G = 10, B = 1 },
						new PaletteEntry() { Step = 224, R = 35, G = 3, B = 1 },
						new PaletteEntry() { Step = 228, R = 9, G = 1, B = 1 },
						new PaletteEntry() { Step = 233, R = 4, G = 1, B = 1 },
						new PaletteEntry() { Step = 237, R = 1, G = 1, B = 1 },
						new PaletteEntry() { Step = 241, R = 1, G = 1, B = 1 },
						new PaletteEntry() { Step = 246, R = 1, G = 1, B = 1 },
						new PaletteEntry() { Step = 250, R = 1, G = 1, B = 1 },
						new PaletteEntry() { Step = 255, R = 1, G = 1, B = 1 },

					}
				},

				new FormPalette()
				{
					Name = "RedsandCyans_gp",
					Entries = {
						new PaletteEntry() { Step = 0, R = 15, G = 96, B = 135 },
						new PaletteEntry() { Step = 78, R = 40, G = 87, B = 74 },
						new PaletteEntry() { Step = 102, R = 83, G = 80, B = 34 },
						new PaletteEntry() { Step = 114, R = 113, G = 71, B = 29 },
						new PaletteEntry() { Step = 127, R = 150, G = 63, B = 25 },
						new PaletteEntry() { Step = 143, R = 60, G = 79, B = 66 },
						new PaletteEntry() { Step = 182, R = 15, G = 96, B = 135 },
						new PaletteEntry() { Step = 223, R = 15, G = 96, B = 135 },
						new PaletteEntry() { Step = 255, R = 15, G = 96, B = 135 },

					}
				},

				new FormPalette()
				{
					Name = "Cyan_Magenta_Blue_gp",
					Entries = {
						new PaletteEntry() { Step = 0, R = 0, G = 255, B = 255 },
						new PaletteEntry() { Step = 63, R = 42, G = 55, B = 255 },
						new PaletteEntry() { Step = 127, R = 255, G = 0, B = 255 },
						new PaletteEntry() { Step = 191, R = 42, G = 0, B = 255 },
						new PaletteEntry() { Step = 255, R = 0, G = 0, B = 255 },

					}
				},

				new FormPalette()
				{
					Name = "Complementary_01a_gp)",
					Entries = {
						new PaletteEntry() { Step = 0, R = 0, G = 33, B = 255 },
						new PaletteEntry() { Step = 127, R = 42, G = 33, B = 45 },
						new PaletteEntry() { Step = 255, R = 255, G = 33, B = 0 },

					}
				},

				new FormPalette()
				{
					Name = "cyberpunk_neon_gp)",
					Entries = {
						new PaletteEntry() { Step = 0, R = 113, G = 28, B = 145 },
						new PaletteEntry() { Step = 63, R = 234, G = 0, B = 217 },
						new PaletteEntry() { Step = 127, R = 10, G = 189, B = 198 },
						new PaletteEntry() { Step = 191, R = 19, G = 62, B = 124 },
						new PaletteEntry() { Step = 255, R = 9, G = 24, B = 51 },

					}
				},


				new FormPalette()
				{
					Name = "blade_runner_2049_gp",
					Entries = {
						new PaletteEntry() { Step = 0, R = 201, G = 80, B = 173 },
						new PaletteEntry() { Step = 25, R = 171, G = 57, B = 155 },
						new PaletteEntry() { Step = 50, R = 104, G = 35, B = 115 },
						new PaletteEntry() { Step = 75, R = 94, G = 33, B = 110 },
						new PaletteEntry() { Step = 100, R = 127, G = 120, B = 172 },
						new PaletteEntry() { Step = 125, R = 77, G = 141, B = 169 },
						new PaletteEntry() { Step = 160, R = 116, G = 85, B = 178 },
						new PaletteEntry() { Step = 170, R = 20, G = 27, B = 115 },
						new PaletteEntry() { Step = 200, R = 75, G = 21, B = 73 },
						new PaletteEntry() { Step = 255, R = 44, G = 9, B = 42 },

					}
				},

				new FormPalette()
				{
					Name = "blue_fire_gp",
					Entries = {
						new PaletteEntry() { Step = 0, R = 0, G = 0, B = 0 },
						new PaletteEntry() { Step = 64, R = 0, G = 0, B = 255 },
						new PaletteEntry() { Step = 200, R = 0, G = 255, B = 255 },
						new PaletteEntry() { Step = 255, R = 255, G = 255, B = 255 },

					}
				},

				new FormPalette()
				{
					Name = "purplefly_gp",
					Entries = {
						new PaletteEntry() { Step = 0, R = 0, G = 0, B = 0 },
						new PaletteEntry() { Step = 63, R = 239, G = 0, B = 122 },
						new PaletteEntry() { Step = 191, R = 252, G = 255, B = 78 },
						new PaletteEntry() { Step = 255, R = 0, G = 0, B = 0 },

					}
				},

				new FormPalette()
				{
					Name = "rainbow2_gp",
					Entries = {
						new PaletteEntry() { Step = 0, R = 126, G = 1, B = 142 },
						new PaletteEntry() { Step = 25, R = 171, G = 1, B = 26 },
						new PaletteEntry() { Step = 48, R = 224, G = 9, B = 1 },
						new PaletteEntry() { Step = 71, R = 237, G = 138, B = 1 },
						new PaletteEntry() { Step = 94, R = 52, G = 173, B = 1 },
						new PaletteEntry() { Step = 117, R = 1, G = 201, B = 1 },
						new PaletteEntry() { Step = 140, R = 1, G = 211, B = 54 },
						new PaletteEntry() { Step = 163, R = 1, G = 124, B = 168 },
						new PaletteEntry() { Step = 186, R = 1, G = 8, B = 149 },
						new PaletteEntry() { Step = 209, R = 12, G = 1, B = 151 },
						new PaletteEntry() { Step = 232, R = 12, G = 1, B = 151 },
						new PaletteEntry() { Step = 255, R = 171, G = 1, B = 190 },

					}
				}
			};
		}
	}
}
