// Project:         Daggerfall Tools For Unity
// Copyright:       Copyright (C) 2009-2021 Daggerfall Workshop
// Web Site:        http://www.dfworkshop.net
// License:         MIT License (http://www.opensource.org/licenses/mit-license.php)
// Source Code:     https://github.com/Interkarma/daggerfall-unity
// Original Author: Ferital (ferital@yahoo.fr)
// Contributors:    
// 
// Notes:
//

using DaggerfallConnect.Utility;

/// <summary>
/// Patch to apply to ARCH3D.BSA after loading. This fixes
/// some models, especially incorrect UV coordinates.
/// </summary>
namespace DaggerfallConnect.Arena2
{
    class Arch3dPatch
    {
        // Model fixes applied to the memory buffer at runtime
        static public readonly PatchList patch = new PatchList
        {
            // Model 262 (Weapon store exterior wall on the right
            // side of the door (e.g. The Count's Arsenal, Newtale, Bhoriane)
            {14515830, 0, 252},

            // Model 116 (house exterior wall)
            {22229232, 0, 4},
            {22229240, 0, 252},
            {22229248, 0, 0},

            // Model 117 (house entrance door)
            {25344340, 0, 4},
            {25344348, 0, 252},
            {25344358, 0, 8},

            // Model 123 (general store exterior wall)
            {25374440, 0, 0},
            {25374448, 0, 0},

            // Model 125 (house entrance door)
            {25382922, 0, 0},
            {25382930, 0},
            {25382940, 0, 8},

            // Model 212 (house entrance door)
            {7148716, 0, 4},
            {7148724, 0},
            {7148734, 0, 8},

            // Model 216 (pawn shop exterior)
            {7174300, 0, 252},

            // Model 223 (Mages Guild exterior wall)
            {7251676, 0, 252},

            // Model 246 (pawn shop exterior)
            {21187136, 0, 0},
            {21187144, 0, 8},
            {21187712, 0, 0},
            {21187720, 0, 8},

            // Model 253 (Tavern exterior)
            {7142104, 0, 0},
            {7142112, 0, 248},
            {7142472, 0, 0},
            {7142480, 0, 240},
            {7142648, 0, 0},
            {7142656, 0, 248},
            {7143000, 0, 0},
            {7143280, 0, 8},
            {7143288, 0, 8},

            // Model 327 (house roof)
            {25416396, 128, 84},
            {25416406, 0, 0, 0, 8},
            {25416414, 0, 0, 168, 250},
            {25416422, 0, 1, 88, 5},
            {25416428, 128, 84},
            {25416460, 128, 84},
            {25416470, 0, 9, 0, 8},
            {25416478, 0, 255, 168, 250},
            {25416486, 0, 0, 88, 5},

            // Model 408 (desert palace exterior)
            {17589796, 0, 0, 0, 0},
            {17589804, 0, 0, 240, 247},
            {17589812, 0, 252, 0, 0},
            {17590780, 0, 0, 0, 240},
            {17590788, 192, 252},
            {17590798, 64, 7},
            {17595444, 0, 0, 0, 244},
            {17595454, 0, 4},
            {17595460, 0, 4},
            {17595908, 0, 0, 0, 0},
            {17595916, 0, 252},
            {17595924, 192, 252, 32, 0},

            // Model 446 (city gates floor)
            {10892904, 130, 158},

            // Model 447 (city gates floor)
            {10900788, 130, 158},

            // Model 521 (gates of Daggerfall castle)
            {11692198, 0, 0},
            {11692206, 0, 252},
            {11692216, 0, 8},
            {11692414, 0, 4},
            {11692424, 0, 8},
            {11692766, 0, 0},
            {11692774, 0, 252},
            {11692784, 0, 8},
            {11692870, 0, 4},
            {11692880, 0, 8},
            {11692958, 0, 0},
            {11692966, 0, 252},
            {11692976, 0, 8},
            {11693062, 0, 4},
            {11693072, 0, 8},

            // Model 524 (battlements of Daggerfall castle)
            {18501962, 96, 2, 86, 253},
            {18501970, 64, 255, 171, 254},

            // Model 713 (dungeon exterior windows)
            {11060492, 0, 0},

            // Model 725 (dungeon exterior bridge)
            {13255810, 0, 0},
            {13255818, 0, 8},

            // Model 729 (left door of dungeon main entrance)
            {13243060, 2, 28},

            // Model 761 (house exterior wall)
            {19367896, 0, 4},
            {19367904, 0, 252},
            {19367912, 0, 0},

            // Model 910 (small ship)
            {14723956, 224, 252},
            {14723964, 192, 252, 0, 0},
            {14723972, 80, 1, 112, 6},
            {14724006, 176, 5},
            {14724012, 16, 10, 192, 0},
            {14724036, 8, 3},
            {14724044, 120, 254, 128, 252},
            {14724052, 128, 254},
            {14724076, 8, 3, 0, 0},
            {14724084, 248, 252, 128, 252},
            {14724140, 192, 254, 48, 31},
            {14724148, 112, 254},
            {14724158, 48, 0},
            {14724170, 128, 33},
            {14724188, 208, 2, 0, 0},
            {14724196, 0, 0, 192, 4},
            {14724316, 240, 246, 216, 5},
            {14724324, 16, 7, 56, 5},
            {14724332, 0, 2},
            {14724388, 80, 7, 32, 21},
            {14724396, 176, 248, 240, 253},
            {14724404, 0, 254},
            {14725804, 0, 2, 0, 4},
            {14725812, 0, 254, 0, 0},
            {14725820, 0, 0, 0, 252},
            {14725996, 162, 1, 40, 6},
            {14726004, 192, 252, 184, 254},
            {14726012, 216, 255, 24, 4},
            {14726100, 130, 7, 224, 4},
            {14726108, 16, 253, 0, 0},
            {14726116, 160, 254, 72, 1},
            {14726156, 178, 13, 224, 4},
            {14726164, 40, 0, 184, 254},
            {14726172, 168, 249, 0, 0},
            {14726268, 32, 3, 208, 254},
            {14726292, 32, 3, 208, 2},
            {14726300, 224, 252, 48, 1},
            {14726308, 8, 15},
            {14726332, 176, 4},
            {14726342, 208, 2},
            {14726348, 88, 10, 48, 1},
            {14726388, 0, 6},
            {14726428, 0, 4},
            {14726468, 0, 4},
            {14726508, 0, 6},
            {14726692, 240, 3, 176, 2},
            {14726702, 0, 252},
            {14726708, 16, 254, 80, 1},
            {14726732, 240, 3, 176, 2},
            {14726740, 16, 254, 80, 254},
            {14726748, 0, 254},
            {14726774, 0, 1},
            {14726782, 0, 255},
            {14726788, 16, 254, 176, 254},
            {14726796, 0, 0},
            {14726820, 0, 2, 0, 0},
            {14726828, 240, 1, 176, 254},
            {14727132, 40, 253, 88, 254},
            {14727140, 112, 254, 0, 0},
            {14727148, 0, 0, 48, 0},
            {14727172, 232, 249, 144, 245},
            {14727180, 144, 254, 200, 8},
            {14727188, 32, 3},
            {14727470, 168, 0},
            {14727476, 16, 253},
            {14727500, 0, 0, 0, 0},
            {14727508, 8, 5, 0, 0},
            {14727516, 8, 255, 136, 247},
            {14727572, 48, 253, 96, 31},
            {14727580, 80, 255},
            {14727588, 128, 3, 152, 7},
            {14727596, 128, 3},
            {14727628, 0, 0, 184, 254},
            {14727636, 168, 249, 0, 0},
            {14727746, 128, 33},
            {14727756, 200, 255, 80, 6},
            {14727766, 0, 249},
            {14727772, 56, 0, 176, 0},
            {14727786, 128, 33},
            {14727804, 200, 255, 80, 255},
            {14727812, 8, 3},
            {14727846, 128, 3},
            {14727852, 128, 1},
            {14727868, 128, 1, 128, 3},
            {14727876, 136, 1, 128, 252},
            {14727884, 248, 252},
            {14727910, 166, 0},
            {14727916, 240, 25},
            {14727940, 240, 25, 166, 0},
            {14727948, 112, 255, 90, 255},
            {14727974, 184, 0},
            {14727980, 240, 25},
            {14728044, 240, 25, 0, 0},
            {14728052, 0, 0, 184, 0},
            {14728076, 240, 25, 184, 0},
            {14728084, 16, 230},
            {14728708, 0, 0},
            {14728716, 72, 253},
            {14728726, 94, 7},
            {14728798, 96, 0},
            {14728804, 184, 2},
            {14728894, 94, 7},
            {14728900, 184, 2},
            {14728934, 96, 0},
            {14728940, 168, 22},
            {14728974, 184, 0},
            {14728980, 168, 22},
            {14729044, 168, 22, 0, 0},
            {14729052, 0, 0, 88, 0},
            {14729086, 144, 6},
            {14729092, 48, 3},
            {14729146, 6, 25},
            {14729166, 160, 255},
            {14729172, 208, 252},
            {14729260, 48, 3, 0, 0},
            {14729268, 0, 0, 134, 6},
            {14729292, 240, 250, 112, 6},
            {14729300, 32, 15, 0, 0},
            {14729308, 240, 245, 64, 255},
            {14729484, 240, 250, 112, 6},
            {14729492, 176, 254, 144, 249},
            {14729500, 0, 0, 240, 8},
            {14729524, 96, 11, 240, 8},
            {14729534, 16, 247},
            {14729540, 176, 254, 112, 6},
            {14729604, 0, 254},
            {14729612, 240, 248, 200, 250},
            {14729620, 192, 1, 72, 15},
            {14729654, 0, 8},
            {14729660, 80, 7, 16, 2},
            {14729980, 0, 0},
            {14729988, 0, 4},
            {14729998, 0, 8},
            {14732148, 134, 254, 0, 255},
            {14732156, 0, 0, 0, 1},
            {14732292, 128, 0},
            {14732302, 0, 1},
            {14732308, 122, 1, 0, 255},
            {14732340, 122, 1},
            {14733244, 0, 2, 0, 0},
            {14733252, 0, 0, 0, 4},

            // Models 8016 to 8816 (room stretched floor)
            {304418, 250, 23},
            {304426, 6, 232},
            {304436, 0, 40},
            {6742068, 250, 23},
            {6742076, 6, 232},
            {6742086, 0, 40},
            {25240182, 250, 23},
            {25240190, 6, 232},
            {25240200, 0, 40},
            {25781794, 250, 23},
            {25781802, 6, 232},
            {25781812, 0, 40},
            {25830584, 250, 23},
            {25830592, 6, 232},
            {25830602, 0, 40},
            {26032948, 250, 23},
            {26032956, 6, 232},
            {26032966, 0, 40},
            {26082160, 250, 23},
            {26082168, 6, 232},
            {26082178, 0, 40},
            {20176732, 250, 23},
            {20176740, 6, 232},
            {20176750, 0, 40},
            {8590878, 250, 23},
            {8590886, 6, 232},
            {8590896, 0, 40},

            // Model 20022 (city wall interior door)
            {3837730, 0, 4, 0, 8},
            {3837738, 0, 0, 0, 248},
            {3837746, 0, 252, 0, 0},
            {3838322, 0, 4, 0, 0},
            {3838330, 0, 252, 0, 0},
            {3838338, 0, 0, 0, 8},

            // Model 20025 (city wall entrance interior doors)
            {3864026, 0, 4, 0, 8},
            {3864034, 0, 0, 0, 248},
            {3864042, 0, 252, 0, 0},
            {3864386, 0, 4, 0, 0},
            {3864394, 0, 252, 0, 0},
            {3864402, 0, 0, 0, 8},

            // Models 31006 to 31806 (interior pillars)
            {4753834, 96, 0},
            {4753858, 160, 7},
            {4753874, 96, 0},
            {23952242, 96, 0},
            {23952266, 160, 7},
            {23952282, 96, 0},
            {23910206, 96, 0},
            {23910230, 160, 7},
            {23910246, 96, 0},
            {4111054, 96, 0},
            {4111078, 160, 7},
            {4111094, 96, 0},
            {23961310, 96, 0},
            {23961334, 160, 7},
            {23961350, 96, 0},
            {4335416, 96, 0},
            {4335440, 160, 7},
            {4335456, 96, 0},
            {4399378, 96, 0},
            {4399402, 160, 7},
            {4399418, 96, 0},
            {4487558, 96, 0},
            {4487582, 160, 7},
            {4487598, 96, 0},
            {4552976, 96, 0},
            {4553000, 160, 7},
            {4553016, 96, 0},

            // Models 31024 to 31824 (interior pillars)
            {4686110, 160, 7},
            {4686126, 96, 0},
            {4686166, 96, 0},
            {23889662, 160, 7},
            {23889678, 96, 0},
            {23889718, 96, 0},
            {23790088, 160, 7},
            {23790104, 96, 0},
            {23790144, 96, 0},
            {4248542, 160, 7},
            {4248558, 96, 0},
            {4248598, 96, 0},
            {4315092, 160, 7},
            {4315108, 96, 0},
            {4315148, 96, 0},
            {4380780, 160, 7},
            {4380796, 96, 0},
            {4380836, 96, 0},
            {4473052, 160, 7},
            {4473068, 96, 0},
            {4473108, 96, 0},
            {4521806, 160, 7},
            {4521822, 96, 0},
            {4521862, 96, 0},
            {4595526, 160, 7},
            {4595542, 96, 0},
            {4595582, 96, 0},

            // Models 31025 to 31825 (interior pillars)
            {4692998, 96, 0},
            {4693022, 160, 7},
            {4693038, 96, 0},
            {4693190, 96, 0},
            {4693214, 160, 7},
            {4693230, 96, 0},
            {23894648, 96, 0},
            {23894672, 160, 7},
            {23894688, 96, 0},
            {23894840, 96, 0},
            {23894864, 160, 7},
            {23894880, 96, 0},
            {23782104, 96, 0},
            {23782128, 160, 7},
            {23782144, 96, 0},
            {23782296, 96, 0},
            {23782320, 160, 7},
            {23782336, 96, 0},
            {4258554, 96, 0},
            {4258578, 160, 7},
            {4258594, 96, 0},
            {4258746, 96, 0},
            {4258770, 160, 7},
            {4258786, 96, 0},
            {4320078, 96, 0},
            {4320102, 160, 7},
            {4320118, 96, 0},
            {4320270, 96, 0},
            {4320294, 160, 7},
            {4320310, 96, 0},
            {4361826, 96, 0},
            {4361850, 160, 7},
            {4361866, 96, 0},
            {4362018, 96, 0},
            {4362042, 160, 7},
            {4362058, 96, 0},
            {4474670, 96, 0},
            {4474694, 160, 7},
            {4474710, 96, 0},
            {4474862, 96, 0},
            {4474886, 160, 7},
            {4474902, 96, 0},
            {4533012, 96, 0},
            {4533036, 160, 7},
            {4533052, 96, 0},
            {4533204, 96, 0},
            {4533228, 160, 7},
            {4533244, 96, 0},
            {4597144, 96, 0},
            {4597168, 160, 7},
            {4597184, 96, 0},
            {4597336, 96, 0},
            {4597360, 160, 7},
            {4597376, 96, 0},

            // Models 31026 to 31826 (interior pillars)
            {4677152, 96, 0},
            {4677176, 160, 7},
            {4677192, 96, 0},
            {23896760, 96, 0},
            {23896784, 160, 7},
            {23896800, 96, 0},
            {23791426, 96, 0},
            {23791450, 160, 7},
            {23791466, 96, 0},
            {4254966, 96, 0},
            {4254990, 160, 7},
            {4255006, 96, 0},
            {4322190, 96, 0},
            {4322214, 160, 7},
            {4322230, 96, 0},
            {4382118, 96, 0},
            {4382142, 160, 7},
            {4382158, 96, 0},
            {4476782, 96, 0},
            {4476806, 160, 7},
            {4476822, 96, 0},
            {4535124, 96, 0},
            {4535148, 160, 7},
            {4535164, 96, 0},
            {4599256, 96, 0},
            {4599280, 160, 7},
            {4599296, 96, 0},

            // Models 31027 to 31827 (interior pillars and entrance panels)
            {4687432, 160, 7},
            {4687850, 0, 8},
            {4687866, 0, 248},
            {4687890, 0, 8},
            {4687906, 64, 250},
            {4687938, 80, 2},
            {23869380, 160, 7},
            {23869798, 0, 8},
            {23869814, 0, 248},
            {23869838, 0, 8},
            {23869854, 64, 250},
            {23869886, 80, 2},
            {23793232, 160, 7},
            {23793650, 0, 8},
            {23793666, 0, 248},
            {23793690, 0, 8},
            {23793706, 64, 250},
            {23793738, 80, 2},
            {4260650, 160, 7},
            {4261068, 0, 8},
            {4261084, 0, 248},
            {4261108, 0, 8},
            {4261124, 64, 250},
            {4261156, 80, 2},
            {4325674, 160, 7},
            {4326092, 0, 8},
            {4326108, 0, 248},
            {4326132, 0, 8},
            {4326148, 64, 250},
            {4326180, 80, 2},
            {4383924, 160, 7},
            {4384342, 0, 8},
            {4384358, 0, 248},
            {4384382, 0, 8},
            {4384398, 64, 250},
            {4384430, 80, 2},
            {4478588, 160, 7},
            {4479006, 0, 8},
            {4479022, 0, 248},
            {4479046, 0, 8},
            {4479062, 64, 250},
            {4479094, 80, 2},
            {4540544, 160, 7},
            {4540962, 0, 8},
            {4540978, 0, 248},
            {4541002, 0, 8},
            {4541018, 64, 250},
            {4541050, 80, 2},
            {4601062, 160, 7},
            {4601480, 0, 8},
            {4601496, 0, 248},
            {4601520, 0, 8},
            {4601536, 64, 250},
            {4601568, 80, 2},

            // Models 31028 to 31828 (interior pillars)
            {4695150, 160, 7},
            {23901178, 160, 7},
            {23797534, 160, 7},
            {4264952, 160, 7},
            {4327564, 160, 7},
            {4385814, 160, 7},
            {4480478, 160, 7},
            {4538108, 160, 7},
            {4602952, 160, 7},

            // Models 31030 to 31830 (interior pillars)
            {4697874, 160, 7},
            {4697890, 96, 0},
            {23899732, 160, 7},
            {23899748, 96, 0},
            {23796088, 160, 7},
            {23796104, 96, 0},
            {4263506, 160, 7},
            {4263522, 96, 0},
            {4324284, 160, 7},
            {4324300, 96, 0},
            {4392066, 160, 7},
            {4392082, 96, 0},
            {26104918, 160, 7},
            {26104934, 96, 0},
            {4542666, 160, 7},
            {4542682, 96, 0},
            {26109528, 160, 7},
            {26109544, 96, 0},

            // Models 31031 to 31831 (interior pillar)
            {4704888, 176, 11},
            {23537874, 176, 11},
            {23541102, 176, 11},
            {4108214, 176, 11},
            {25413688, 176, 11},
            {26103172, 176, 11},
            {26106316, 176, 11},
            {26107782, 176, 11},
            {26110926, 176, 11},

            // Model 43202 (ruined tombstone)
            {25432632, 64, 11},
            {25432638, 96, 16},
            {25432652, 128, 20},
            {25432662, 0, 0},
            {25432678, 64, 11},
            {25432718, 96, 16},
            {25432758, 64, 11},
            {25432798, 96, 16},
            {25432824, 0, 1},
            {25432832, 0, 1},
            {25432838, 64, 9},
            {25432864, 0, 2},
            {25432872, 0, 1},
            {25432878, 64, 9},
            {25432904, 0, 3},
            {25432912, 0, 1},
            {25432918, 64, 9},
            {25432952, 0, 1},
            {25432958, 64, 9},
            {25432992, 0, 1},
            {25432998, 64, 9},
            {25433024, 0, 1},
            {25433032, 0, 1},
            {25433038, 64, 9},
            {25433064, 0, 2},
            {25433072, 0, 1},
            {25433078, 64, 9},
            {25433104, 0, 3},
            {25433112, 0, 1},
            {25433118, 64, 9},
            {25433152, 0, 1},
            {25433158, 64, 9},
            {25433192, 0, 1},
            {25433198, 64, 9},
            {25433224, 0, 1},
            {25433232, 0, 1},
            {25433238, 64, 9},
            {25433264, 0, 2},
            {25433272, 0, 1},
            {25433278, 64, 9},
            {25433304, 0, 3},
            {25433312, 0, 1},
            {25433318, 64, 9},
            {25433352, 0, 1},
            {25433358, 64, 9},
            {25433392, 0, 1},
            {25433398, 64, 9},
            {25433430, 128, 255, 224, 0},
            {25433438, 0, 5, 224, 2},
            {25433462, 128, 255, 224, 0},
            {25433470, 192, 255, 192, 0},
            {25433478, 0, 5},
            {25433494, 128, 255, 224, 0},
            {25433502, 192, 4, 192, 0},
            {25433510, 64, 0, 64, 255},
            {25433526, 64, 255, 160, 1},
            {25433534, 96, 0, 224, 0},
            {25433542, 224, 4},
            {25433558, 64, 255, 160, 1},
            {25433566, 64, 5, 224, 0},
            {25433574, 192, 255, 32, 255},
            {25433580, 131, 20},
            {25433590, 96, 5, 0, 254},
            {25433598, 128, 255, 32, 255},
            {25433606, 32, 251, 224, 2},
            {25433624, 0, 255},
            {25433630, 224, 255, 0, 1},
            {25433638, 0, 5},
            {25433656, 0, 255},
            {25433662, 224, 4, 0, 1},
            {25433670, 0, 0, 0, 255},
            {25433694, 128, 0, 64, 0},
            {25433702, 192, 255, 128, 0},
            {25433718, 192, 255, 192, 0},
            {25433726, 64, 0, 64, 255},
            {25433734, 64, 0, 192, 0},
            {25433750, 64, 0, 192, 0},
            {25433758, 96, 0, 128, 0},
            {25433766, 128, 255, 96, 0},
            {25433782, 128, 0, 64, 0},
            {25433790, 32, 0, 0, 1},
            {25433798, 160, 255, 128, 255},
            {25433804, 130, 70},
            {25433814, 128, 0, 64, 0},
            {25433822, 128, 255, 192, 255},
            {25433830, 32, 0, 192, 0},
            {25433836, 130, 70},
            {25433854, 192, 255, 192, 0},
            {25433862, 96, 0},
            {25433868, 130, 70},
            {25433878, 192, 255, 192, 0},
            {25433886, 64, 0, 224, 0},
            {25433894, 32, 0, 32, 255},
            {25433900, 130, 70},
            {25433912, 160, 1},
            {25433918, 128, 0, 160, 255},
            {25433926, 160, 255, 128, 255},
            {25433932, 130, 70},
            {25433942, 128, 0, 64, 1},
            {25433952, 0, 255},
            {25433958, 160, 255, 128, 0},
            {25433984, 0, 1},
            {25433990, 192, 1},
            {25434024, 0, 1},
            {25434030, 192, 1},
            {25434056, 0, 3},
            {25434064, 0, 1},
            {25434070, 192, 1},
            {25434096, 0, 2},
            {25434104, 0, 1},
            {25434110, 192, 1},
            {25434136, 0, 1},
            {25434144, 0, 1},
            {25434150, 192, 1},
            {25434182, 0, 255, 192, 255},
            {25434190, 192, 0, 96, 255},
            {25434214, 224, 255, 96, 254},
            {25434222, 192, 0, 192, 0},
            {25434230, 32, 255},
            {25434254, 0, 255, 192, 255},
            {25434264, 0, 255},
            {25434270, 192, 0, 96, 0},
            {25434294, 96, 4, 224, 5},
            {25434302, 224, 0},
            {25434344, 224, 11},
            {25434350, 96, 1},
            {25434364, 129, 20},
            {25434384, 224, 0},
            {25434390, 96, 1},
            {25434404, 129, 20},
            {25434416, 80, 7},
            {25434424, 80, 7},
            {25434430, 96, 1},
            {25434464, 80, 7},
            {25434470, 96, 1},
            {25434504, 224, 0},
            {25434510, 96, 1},
            {25434544, 224, 11},
            {25434550, 224, 0},
            {25434638, 160, 13, 0, 0},
            {25434646, 0, 0, 128, 1},
            {25434678, 230, 0, 0, 0},
            {25434686, 0, 0, 128, 1},
            {25434718, 224, 7, 0, 0},
            {25434726, 0, 0, 128, 1},
            {25434758, 32, 8, 0, 0},
            {25434766, 0, 0, 128, 1},
            {25434798, 0, 1, 0, 0},
            {25434806, 0, 0, 128, 1},
            {25434838, 224, 6, 192, 11},
            {25434846, 192, 0, 128, 255},
            {25434888, 160, 2},
            {25434894, 64, 15},
            {25434908, 128, 20},
            {25434928, 0, 1},
            {25434934, 160, 2},
            {25434948, 128, 20},
            {25434968, 0, 1},
            {25434974, 64, 15},
            {25434988, 128, 20},
            {25435008, 0, 1},
            {25435014, 160, 2},
            {25435028, 128, 20},
            {25435048, 0, 1},
            {25435054, 64, 15},
            {25435088, 64, 15},
            {25435094, 160, 2},
            {25435128, 128, 2},
            {25435134, 32, 2},
            {25435148, 128, 20},
            {25435168, 0, 1},
            {25435174, 128, 2},
            {25435188, 128, 20},
            {25435208, 0, 1},
            {25435214, 32, 2},
            {25435228, 128, 20},
            {25435248, 0, 1},
            {25435254, 128, 2},
            {25435268, 128, 20},
            {25435288, 0, 1},
            {25435294, 32, 2},
            {25435308, 128, 20},
            {25435328, 32, 2},
            {25435334, 128, 2},
            {25435368, 64, 4},
            {25435374, 224, 0},
            {25435446, 192, 2, 0, 3},
            {25435454, 96, 252},
            {25435488, 0, 3},
            {25435494, 64, 4},
            {25435528, 0, 3},
            {25435534, 160, 3},
            {25435548, 131, 20},
            {25435566, 128, 0, 192, 0},
            {25435574, 224, 4, 64, 253},
            {25435590, 32, 0, 160, 1},
            {25435598, 160, 255, 32, 255},
            {25435606, 128, 0},

            // Model 56300 (dungeon stair 1)
            {17690922, 0, 1},
            {17690962, 0, 1},
            {17691002, 0, 1},
            {17691042, 0, 1},
            {17691082, 0, 1},
            {17691122, 0, 1},
            {17691162, 0, 1},
            {17691202, 0, 1},
            {17691242, 0, 1},
            {17691282, 0, 1},
            {17691322, 0, 1},
            {17691362, 0, 1},
            {17691402, 0, 1},
            {17691442, 0, 1},
            {17691482, 0, 1},
            {17691522, 0, 1},
            {17691562, 0, 1},
            {17691602, 0, 1},
            {17691642, 0, 1},
            {17691682, 0, 1},
            {17691722, 0, 1},
            {17691762, 0, 1},
            {17691802, 0, 1},
            {17691842, 0, 1},

            // Model 56301 (dungeon stair 2)
            {15255314, 0, 1},
            {15255354, 0, 1},
            {15255394, 0, 1},
            {15255434, 0, 1},
            {15255474, 0, 1},
            {15255514, 0, 1},
            {15255554, 0, 1},
            {15255594, 0, 1},
            {15255634, 0, 1},
            {15255674, 0, 1},
            {15255714, 0, 1},
            {15255754, 0, 1},
            {15255794, 0, 1},
            {15255834, 0, 1},
            {15255874, 0, 1},
            {15255914, 0, 1},
            {15255954, 0, 1},
            {15255994, 0, 1},
            {15256034, 0, 1},
            {15256074, 0, 1},
            {15256114, 0, 1},
            {15256154, 0, 1},
            {15256194, 0, 1},
            {15256234, 0, 1},

            // Model 58055 (small dungeon wall)
            {1265962, 236, 3, 0, 4},
            {1265970, 80, 248, 0, 0},
            {1265978, 0, 0, 0, 252},

            // Model 58015 (dungeon pyramid top)
            {130588, 2, 62},

            // Model 58016 (dungeon pyramid top)
            {15564282, 2, 62},
            {15564292, 24, 12, 124, 5},
            {15564300, 244, 249, 144, 0},
            {15564308, 12, 6},

            // Model 60504 (dungeon harrow grooves)
            {14963514, 0, 1},
            {14963538, 0, 10},
            {14963548, 0, 6},
            {14963554, 0, 1},
            {14963594, 0, 1},
            {14963608, 0, 61},
            {14963618, 224, 2},
            {14963628, 0, 6},
            {14963634, 0, 1},

            // Model 61030 (dungeon corridor slope)
            {13820330, 0, 0, 0, 54},
            {13820338, 0, 28, 0, 208},
            {13820348, 0, 250},
            {13820370, 0, 2},
            {13820410, 0, 0},
            {13820418, 0, 252},
            {13820428, 0, 6},
            {13820570, 0, 32, 0, 54},
            {13820578, 0, 4},
            {13820586, 0, 24, 0, 202},
            {13820610, 0, 2, 0, 0},
            {13820620, 0, 254},
            {13820650, 0, 28, 0, 48},
            {13820658, 0, 228, 0, 208},
            {13820666, 0, 24, 0, 54},

            // Model 61218 (dungeon stair)
            {14038186, 0, 0, 0, 240},
            {14038196, 0, 250},
            {14038204, 0, 16},
            {14038234, 0, 0, 0, 0},
            {14038244, 0, 240},
            {14038252, 0, 6},
            {14038394, 0, 0, 96, 1},
            {14038404, 160, 254},
            {14038412, 240, 7},
            {14038434, 80, 248, 240, 7},
            {14038444, 16, 8},
            {14038464, 0, 62},
            {14038476, 240, 253},
            {14038484, 16, 8},
            {14038492, 0, 240},
            {14038496, 0, 62},
            {14038508, 96, 247},
            {14038516, 144, 6},
            {14038536, 0, 62},
            {14038548, 0, 6},
            {14038556, 240, 247},
            {14038564, 64, 1},

            // Model 63032 (dungeon Y junction)
            {15428034, 0, 0, 0, 6},
            {15428042, 0, 250, 0, 250},
            {15428050, 0},
            {15428083, 0},
            {15428090, 0, 2},
            {15428098, 0, 8},
            {15428202, 0, 2, 0, 0},
            {15428210, 0},

            // Model 63138 (dungeon corridor with two doors)
            {20645602, 0, 0, 0, 0},
            {20645610, 0, 0, 0, 252},
            {20645618, 0, 252},

            // Model 63156 (dungeon corridor)
            {1830694, 0, 2, 192, 12},
            {1830704, 48, 11},
            {1830710, 0, 4, 192, 2},

            // Model 67016 (dungeon stairs)
            {15311274, 0, 0},
            {15311280, 0, 16, 0, 8},
            {15311290, 0, 252},
            {15311314, 0, 0},
            {15311320, 0, 16, 0, 248},
            {15311330, 0, 252},
            {15311402, 240, 3},
            {15311408, 128, 0},
            {15311482, 240, 3},
            {15311488, 128, 0},
            {15311562, 240, 3},
            {15311568, 128, 0},
            {15311642, 240, 3},
            {15311648, 128, 0},
            {15311722, 240, 3},
            {15311728, 128, 0},
            {15311802, 240, 3},
            {15311808, 128, 0},
            {15311882, 240, 3},
            {15311888, 128, 0},
            {15311962, 240, 3},
            {15311968, 128, 0},

            // Model 67027 (dungeon corridor slope)
            {17630334, 3, 60},
            {17630374, 3, 60},
            {17630414, 2, 60},
            {17630454, 2, 60},

            // Model 67119 (dungeon stairs)
            {16020866, 0, 1},
            {16020946, 56, 0},
            {16020954, 144, 1},

            // Model 67124 (dungeon corridor slope)
            {16024804, 0, 0},
            {16024812, 0, 4},
            {16024820, 0, 252},
            {16024844, 0, 0},
            {16024852, 0, 252},
            {16024860, 0, 252},

            // Model 69008 (dungeon sewer junction)
            {15615452, 2, 11},
            {15615462, 0, 16, 0, 0},
            {15615470, 0, 250, 0, 0},
            {15615478, 0, 246, 0, 4},
            {15615492, 2, 11},
            {15615502, 0, 0, 0, 0},
            {15615510, 0, 0, 0, 4},
            {15615518, 0, 10, 0, 252},
            {15615534, 0, 16, 0, 6},
            {15615542, 0, 0, 0, 250},
            {15615550, 0, 240, 0, 0},
            {15615574, 0, 16, 0, 2},
            {15615582, 0, 0, 0, 254},
            {15615590, 0, 240, 0, 0},
            {15615614, 0, 10, 0, 2},
            {15615622, 0, 6, 0, 0},
            {15615630, 0, 0, 0, 254},
            {15615654, 0, 10, 0, 6},
            {15615662, 0, 6, 0, 0},
            {15615670, 0, 0, 0, 250},
            {15615694, 0, 6, 0, 0},
            {15615702, 0, 250, 0, 0},
            {15615710, 0, 0, 0, 6},
            {15615734, 0, 6, 0, 0},
            {15615742, 0, 250, 0, 0},
            {15615750, 0, 0, 0, 2},
            {15615764, 131, 11},
            {15615774, 0, 0, 0, 4},
            {15615782, 0, 16, 0, 0},
            {15615790, 0, 0, 0, 252},
            {15615804, 131, 11},
            {15615814, 0, 0, 0, 0},
            {15615822, 0, 0, 0, 4},
            {15615830, 0, 10, 0, 252},
            {15615854, 0, 5, 0, 254},
            {15615862, 0, 1, 0, 250},
            {15615870, 0, 253, 0, 8},
            {15615886, 0, 6, 0, 248},
            {15615894, 0, 253, 0, 1},
            {15615902, 0, 0, 0, 7},
            {15615908, 131, 11},
            {15615918, 0, 6, 0, 4},
            {15615926, 0, 4, 0, 0},
            {15615934, 0, 0, 0, 253},
            {15615958, 0, 11, 0, 254},
            {15615966, 0, 2, 0, 2},
            {15615974, 0, 0, 0, 249},
            {15615998, 0, 10, 0, 0},
            {15616006, 0, 3, 0, 0},
            {15616014, 0, 254, 0, 254},
            {15616020, 2, 11},
            {15616030, 0, 10, 0, 4},
            {15616038, 0, 0, 0, 253},
            {15616046, 0, 252, 0, 0},
            {15616070, 0, 0, 0, 0},
            {15616078, 0, 3, 0, 0},
            {15616086, 0, 0, 0, 249},
            {15616100, 2, 11},
            {15616110, 144, 9, 0, 254},
            {15616118, 224, 252, 0, 0},
            {15616126, 144, 255, 0, 3},
            {15616140, 131, 11},
            {15616150, 0, 6, 0, 1},
            {15616158, 0, 4, 0, 0},
            {15616166, 144, 255, 0, 253},
            {15616190, 0, 16, 0, 0},
            {15616198, 0, 0, 96, 250},
            {15616206, 0, 253, 160, 254},
            {15616230, 0, 3, 0, 0},
            {15616238, 0, 3, 0, 0},
            {15616246, 0, 255, 0, 254},

            // Model 69011 (dungeon sewer dead end)
            {13837870, 128, 11},
            {13837904, 128, 11},

            // Model 70505 (dungeon room stretched wall)
            {13806055, 8},
        };
    }
}
