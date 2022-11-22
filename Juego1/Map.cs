﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Juego1
{
    public static class Map
    {
        public static string[] CreateMap()
        {
            string row0 = "11111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";
            string row1 = "B0001000001000000000000000001000000010000000001000001010001010000000100000001010001010101000101000001";
            string row2 = "11101011101010111010111110111011101110101010111011111011101010111011111011101011101010101110101011101";
            string row3 = "10001000101010100010101000001010000000101010101000101000000000100000101010001000000000100000000010001";
            string row4 = "10111011101110111110101110111011111011101110101110101110111110111011101010111111111110111010101011111";
            string row5 = "10100000100000001010101000000000101010001000000000001000001010101000101010101000101000000010101010001";
            string row6 = "10111011101111101011101111101011101110111111111011101010111010101010101010101110101010101110111010111";
            string row7 = "10101010101010100010000010001000100010000010100010001010001000101010001010001000000010101000001000101";
            string row8 = "10101010111010111111101110101111101011101010111111111110101110101111111010111010111110111011111011101";
            string row9 = "10100010000000001000100010101000101010101000101000100000101010000000100010101010101000001010000000101";
            string row10 = "10111110111110111110111011101110111010111110101110111111111011101010101011101110101110111111101010101";
            string row11 = "10101010101010100010000000100010100010101000001000100000001010001010101000101000001010100010001010001";
            string row12 = "10101010101010111010101011111110101010101011111010101011111011101010101010101011111011111011111010111";
            string row13 = "10100010101000100000101000100000101000000000100010001000100010101010001010001000000010000000100010001";
            string row14 = "10101111101110111111111110101011111110101110111010111011101010101010101110111111101111101110101010101";
            string row15 = "10000010001000100000100000101000100000100010000010101000001000001010101010001010001010101010001010101";
            string row16 = "11101010101011101111111110101111101011111011111111101010111011101110111011111011101010101011111111111";
            string row17 = "10101010101010001000000000000000101010000010001000100010001000101000000000000000001000001010101000001";
            string row18 = "10101011101010111110101011101011101011111110101110111110111111101111111010101110101011101010101110111";
            string row19 = "10001000100000001010101010101010001000001010100000000000000010000010101010101010101000101000000010001";
            string row20 = "11101011111110111010111110101010101011111011101111101011111011111110101111111010111111101011111010101";
            string row21 = "10001000100000001000001000101010101000100000100010101010001010000000000000000000001000001010100000101";
            string row22 = "11101110111111101011101011101011101110101110111110111110101011101111101111101111111111101010111011101";
            string row23 = "10101010000000000000100010001000001010101010001010100010100010101000001000100000001000101000101010001";
            string row24 = "10101011111010111111101110111111101011111010111010101110101110111111101010111110101011111010101010101";
            string row25 = "10000010001010101000101000100010000010001000100010001000101010000010001010100000100010101010001010101";
            string row26 = "11111011101111101010101111101011101111101011101110111111111011101111101110111011101110101111111011101";
            string row27 = "10000010100000101010101000001010001000000010000010100010001000100000000000100010000010001000001010001";
            string row28 = "11111010101111101011111011101111101011101110111010111011101010111110101111111111111110111010111111101";
            string row29 = "10100000000010000000001000100010100000100010001000000010000010001000101000100010001010101010001000001";
            string row30 = "10111011101111111011111111101110111010111011101110111011111110111110111010111010101010101110101011101";
            string row31 = "10001010001000100000101000000000100010101010000010001000000000100000101010100000100000100010100000101";
            string row32 = "11101111111110101011101111101111111010101011111011111110111011111111101011101010111111111010111010101";
            string row33 = "10001010000000101010100000001010100010100000000010000010100000101000001000001010001010000010100010101";
            string row34 = "10111010111010101010111010111010111111101111111110101111111111101110111111101111111010101011101011111";
            string row35 = "10101000101010001000000010000010000010000000000010101000001000000000001010100010001010101000001010001";
            string row36 = "10101111101110111110111011101110111110111111111110111110101110101110111010111010111011111110111111101";
            string row37 = "10100000100000000010100010000010001000001000001000101010101010101000100010000010000010000000101000101";
            string row38 = "10111110111110101110101111111010101010101110111011101011101010101111101010101110101110101011101011101";
            string row39 = "10100000000000101000101000101010101010101000100010000010000010100010001000101010100000101000000000001";
            string row40 = "10101111111110101110111011101010101010111110101011111011101010111110111011101010111011101011111010111";
            string row41 = "10100010100000101000100000001010100010001010001000000000101010000000100000101000001000101000101010001";
            string row42 = "10101110111110111110101111101010111111101011111111101110111010101111101111101011111111111010101111111";
            string row43 = "10001000000000101000100000100010101010000010000010001000000010100000101000101010100010001010001000001";
            string row44 = "10111010101110101010111111111010101010101110111111101110101011101111111110101010111011101011101110111";
            string row45 = "10100010101010100010001010100010101010100010001010100010101010100010000000000000001000000000100000001";
            string row46 = "10111110111011111111111010101110101011101110101010101011101110111111111011111110111111111011111110111";
            string row47 = "10001000101000001000001010100000000010000000101000101010100000100010000000001000100000000010000000001";
            string row48 = "11111111101011101010101010101010111111111110111011111110101011101111111011101011101111111111111111111";
            string row49 = "10000010000010000010100000001010000010001010000010100010001000001000100000101010100010100010000000101";
            string row50 = "11101111101111101111101110111010101111101010111110101110101110101011101111111010101110111010111110101";
            string row51 = "10001010001010001010001010001010101010100000000010000010101010100000100000001000100000100000000010001";
            string row52 = "10111010111010111010111011111110101010111110111111101111111011101110111011111111111011111111101111111";
            string row53 = "10000000001000101000001000000010101000100000001000101000000000101000000010001000001010000010100000101";
            string row54 = "11101011101010101011101110111111101110111110101010101011101110101010111011101010101110101010111110101";
            string row55 = "10001010001010101010000000000010001000001000101010000010101010001010101000100010100000101010101010001";
            string row56 = "10111111101011101111111110101111111010101110111011111010101011111011101110101111111010111010101011101";
            string row57 = "10100010001000101000100010100010000010100010100010001010001000000000000010100010000010001000101010001";
            string row58 = "10111011101111101011111010111111111110111010101010101011101010111011111011101111111110111111101011101";
            string row59 = "10001000100000101000000010100010100010100010001000101010101010100000101010000000001010101000000010001";
            string row60 = "11111011101111101111101011111010111010111011111010111010111011101111101111111010101011101011111010111";
            string row61 = "10000000000000000000001000001000001010100010000010001000100000100010000010100010100000000000001000001";
            string row62 = "10111010111111111111101111111011101011111010111010111111101110111010101110101111111111101111111011111";
            string row63 = "10101010100010101000000010001010000010000010100010001000101010100000100010001000100010000010000000001";
            string row64 = "10101010101010101011111110111111101010111110111011101110101011111111101111111010101111101010111110101";
            string row65 = "10100010101000000010101000100010101000100010100000101000100000000000101010101010000000001010100000101";
            string row66 = "11101011111110111010101010101110111110101111111011111110111110101010111010101010111011101110111110111";
            string row67 = "10001010000000001000000010000000101010001000001000001000000010101010101010101010001010000010101010001";
            string row68 = "10111010101010111110111011101110101010111111101010111010111110101111101010101110111010111111101011101";
            string row69 = "10001010101010000010101010101010100000101000000010000010001000100000000010001000001010100010100010001";
            string row70 = "10111111111111101111101010101011101110101111101011111110111111111110101110111110101111111010111011101";
            string row71 = "10000000001010000010100000101000001000001000101010001000001010100000100010001010101000001010000000101";
            string row72 = "10101111111010111110111111111010111110111110111111101111111010101010101011101010111110111011111011111";
            string row73 = "10101000101000000010000000000010100000101010000000001010000010101010101010000000100000000000100010101";
            string row74 = "10111011101010111110111110101011111111101011101111101011111010101011111111101111111011111110111010101";
            string row75 = "10100000100010000010101010101010000010001000001010101000001000001000000000000000100000101010000000001";
            string row76 = "10101011101011111111101010111110101110111110111010101011111010111011111110111110111111101010101111111";
            string row77 = "10101000101000000010100000001010101010001010001010000000101010001010101000100000000000000000101000001";
            string row78 = "11111011111111101010111110111011101010101011101011101111101110111110101011101111101111111011101011111";
            string row79 = "10100000001000001010100010000000000010101000000000100000000010001010000000101000001000101010000010001";
            string row80 = "10101111111111101110111010111111101010101011101010111010111110111011101110101111101011101010111111101";
            string row81 = "10100000000010101000001000001010001000100010001010001010101000001000001010101000000000001010001000001";
            string row82 = "10111111111010101011101111101010111110101111101111111110101010101110111011101010101111111111101010111";
            string row83 = "10000000000010000010000010001000100010101000101000000010000010101010100000101010101010001000001010101";
            string row84 = "10111110101010101111111011111011111010111010111011111110111110111011111011111010111010101011111011101";
            string row85 = "10001000101000100010100010000010100010000010000000101000000010101000000010001010000010100000000000001";
            string row86 = "11111110101111111110101111111010101011111110101110101011111110101110111110111011111111111111111110111";
            string row87 = "10000010100010000000001000001000001010100000101000100010001010001000100010000000001000100000100000101";
            string row88 = "10111011111110101110101110111010111110101010101110101011101011101110111011101110101110111010111010101";
            string row89 = "10100000001000101010101000001010001000001010100010101000001000001010000000000010100010101010100010001";
            string row90 = "10111011101111101011101011101111111111111110111111111011111011111010111111111011101010101010111110101";
            string row91 = "10001010001010001000001010000010101000101000000000100000100000101000001000000010101000001010001000101";
            string row92 = "10111111101010101011111111101010101011101011111011111110111111101011111110111110111111101110101011101";
            string row93 = "10001010000000101010000000001000000010000000100010100010000010001010001000100000101000100010101010001";
            string row94 = "11101011101111111111111111111010111011101110101010101111111010111011101110111011101110111111101011101";
            string row95 = "10101000000010000010000010101010001000100010101000100000000010100000100000100010100000000000100010001";
            string row96 = "10111110111010111111101110101110101110101111101110111011111110111011101111111010101111111110111011111";
            string row97 = "10001010100010101000100010001000101000000010001010101000001010001010100000100000100000100000000010001";
            string row98 = "11101011101110101110101110111110111010111110111010101110111011101010111011101011101110111010111110101";
            string row99 = "1000000000000000000000000000001010001000001000001000001000000000100010000000101000001010001000000010X";
            string row100 = "11111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111111";

            //string myArr =  .GetField("row1");

            string[] map = new string[101];
            map[0] = row0;
            map[1] = row1;
            map[2] = row2;
            map[3] = row3;
            map[4] = row4;
            map[5] = row5;
            map[6] = row6;
            map[7] = row7;
            map[8] = row8;
            map[9] = row9;
            map[10] = row10;
            map[11] = row11;
            map[12] = row12;
            map[13] = row13;
            map[14] = row14;
            map[15] = row15;
            map[16] = row16;
            map[17] = row17;
            map[18] = row18;
            map[19] = row19;
            map[20] = row20;
            map[21] = row21;
            map[22] = row22;
            map[23] = row23;
            map[24] = row24;
            map[25] = row25;
            map[26] = row26;
            map[27] = row27;
            map[28] = row28;
            map[29] = row29;
            map[30] = row30;
            map[31] = row31;
            map[32] = row32;
            map[33] = row33;
            map[34] = row34;
            map[35] = row35;
            map[36] = row36;
            map[37] = row37;
            map[38] = row38;
            map[39] = row39;
            map[40] = row40;
            map[41] = row41;
            map[42] = row42;
            map[43] = row43;
            map[44] = row44;
            map[45] = row45;
            map[46] = row46;
            map[47] = row47;
            map[48] = row48;
            map[49] = row49;
            map[50] = row50;
            map[51] = row51;
            map[52] = row52;
            map[53] = row53;
            map[54] = row54;
            map[55] = row55;
            map[56] = row56;
            map[57] = row57;
            map[58] = row58;
            map[59] = row59;
            map[60] = row60;
            map[61] = row61;
            map[62] = row62;
            map[63] = row63;
            map[64] = row64;
            map[65] = row65;
            map[66] = row66;
            map[67] = row67;
            map[68] = row68;
            map[69] = row69;
            map[70] = row70;
            map[71] = row71;
            map[72] = row72;
            map[73] = row73;
            map[74] = row74;
            map[75] = row75;
            map[76] = row76;
            map[77] = row77;
            map[78] = row78;
            map[79] = row79;
            map[80] = row80;
            map[81] = row81;
            map[82] = row82;
            map[83] = row83;
            map[84] = row84;
            map[85] = row85;
            map[86] = row86;
            map[87] = row87;
            map[88] = row88;
            map[89] = row89;
            map[90] = row90;
            map[91] = row91;
            map[92] = row92;
            map[93] = row93;
            map[94] = row94;
            map[95] = row95;
            map[96] = row96;
            map[97] = row97;
            map[98] = row98;
            map[99] = row99;
            map[100] = row100;













            return map;
        }
    }
}
