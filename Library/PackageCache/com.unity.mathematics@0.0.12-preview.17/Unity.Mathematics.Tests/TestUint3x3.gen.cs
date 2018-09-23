// GENERATED CODE
using NUnit.Framework;
using static Unity.Mathematics.math;
namespace Unity.Mathematics.Tests
{
    [TestFixture]
    public class TestUint3x3
    {
        [Test]
        public void uint3x3_operator_equal_wide_wide()
        {
            uint3x3 a0 = uint3x3(2105871082, 35218899, 1550755093, 764676020, 606743782, 1208156098, 1023640014, 1038468316, 1416064367);
            uint3x3 b0 = uint3x3(1477587886, 579629692, 540974792, 208405066, 2063397938, 1060167409, 362592601, 2097545362, 277670088);
            bool3x3 r0 = bool3x3(false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            uint3x3 a1 = uint3x3(727143393, 2061243891, 184669837, 1303661760, 2044073738, 370395888, 1822916805, 1076983135, 345215866);
            uint3x3 b1 = uint3x3(426944490, 901076223, 857900673, 1548779757, 325265488, 312658571, 176373760, 2052378097, 858156597);
            bool3x3 r1 = bool3x3(false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            uint3x3 a2 = uint3x3(833676277, 1987782708, 1481088614, 1364754268, 93639636, 1850596922, 2073471507, 1745989448, 28118669);
            uint3x3 b2 = uint3x3(982817797, 1252095508, 882634538, 1959142806, 72495800, 1077678183, 1729269763, 1607675346, 1813461519);
            bool3x3 r2 = bool3x3(false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            uint3x3 a3 = uint3x3(1267554232, 1292918049, 1423451579, 644384701, 1985492825, 240481133, 2130667921, 17376735, 1263869085);
            uint3x3 b3 = uint3x3(1204794859, 1324801873, 1975336, 439410532, 294085211, 1031782338, 1118745564, 180311719, 433246570);
            bool3x3 r3 = bool3x3(false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void uint3x3_operator_equal_wide_scalar()
        {
            uint3x3 a0 = uint3x3(437822262, 2020661134, 541786900, 853113810, 23716499, 179951405, 1409026299, 948838849, 953202998);
            uint b0 = (1332833578);
            bool3x3 r0 = bool3x3(false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            uint3x3 a1 = uint3x3(691955848, 1851546137, 712957637, 2028784869, 1049962241, 1836975611, 1016802970, 390120467, 464814777);
            uint b1 = (1926262965);
            bool3x3 r1 = bool3x3(false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            uint3x3 a2 = uint3x3(1451642042, 152339338, 808355440, 660053867, 597354173, 67320270, 151461188, 35153827, 602895443);
            uint b2 = (289137869);
            bool3x3 r2 = bool3x3(false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            uint3x3 a3 = uint3x3(186996278, 1031574999, 1697392883, 1463742000, 857785521, 611116281, 594150729, 375387566, 1984352551);
            uint b3 = (129611815);
            bool3x3 r3 = bool3x3(false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void uint3x3_operator_equal_scalar_wide()
        {
            uint a0 = (542329200);
            uint3x3 b0 = uint3x3(1115584594, 684107773, 1928988941, 890709324, 641152437, 1410341302, 497505660, 1068223109, 2014009435);
            bool3x3 r0 = bool3x3(false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 == b0, r0);

            uint a1 = (213835595);
            uint3x3 b1 = uint3x3(1592428361, 1819361470, 448650623, 1942175642, 64377057, 1485938610, 1146305380, 1312317120, 263290348);
            bool3x3 r1 = bool3x3(false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a1 == b1, r1);

            uint a2 = (812663708);
            uint3x3 b2 = uint3x3(1585209188, 40646617, 1378718922, 1957797737, 873652576, 1780082094, 1513270921, 2095980581, 1413074719);
            bool3x3 r2 = bool3x3(false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 == b2, r2);

            uint a3 = (1387984261);
            uint3x3 b3 = uint3x3(1547119354, 924385171, 1253636050, 1477542688, 969120167, 591812191, 856880926, 1114040166, 2107388425);
            bool3x3 r3 = bool3x3(false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 == b3, r3);
        }

        [Test]
        public void uint3x3_operator_not_equal_wide_wide()
        {
            uint3x3 a0 = uint3x3(1977284100, 1293292704, 1547283851, 422428953, 195833190, 1711544892, 5606053, 737069074, 647386678);
            uint3x3 b0 = uint3x3(1514195556, 957972049, 507667364, 581861672, 1128094576, 940096636, 57559040, 181752616, 962017320);
            bool3x3 r0 = bool3x3(true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            uint3x3 a1 = uint3x3(13079405, 1413841590, 1076166545, 1211445174, 1289303469, 1436402489, 1129570126, 1566836685, 1343313905);
            uint3x3 b1 = uint3x3(1762015406, 1107218953, 2042026522, 836002288, 570272309, 2112081980, 1500634658, 1787808345, 566425667);
            bool3x3 r1 = bool3x3(true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            uint3x3 a2 = uint3x3(329259205, 1774944480, 33906739, 2055853627, 2035015372, 1702756001, 1164186087, 329853698, 769052491);
            uint3x3 b2 = uint3x3(2037529609, 1520589840, 266793699, 538816359, 2075474643, 553571317, 218264354, 654754196, 1392180230);
            bool3x3 r2 = bool3x3(true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            uint3x3 a3 = uint3x3(1893312730, 438029011, 1894010522, 1365847542, 1292942830, 2146008097, 1520743598, 861728782, 1999977058);
            uint3x3 b3 = uint3x3(870065147, 1398749829, 711281563, 1999640291, 231234857, 210910234, 365281355, 170643407, 757340716);
            bool3x3 r3 = bool3x3(true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void uint3x3_operator_not_equal_wide_scalar()
        {
            uint3x3 a0 = uint3x3(1038269360, 1427812625, 103361237, 1347017023, 1523584313, 150442802, 660334527, 719113717, 262959423);
            uint b0 = (768873026);
            bool3x3 r0 = bool3x3(true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            uint3x3 a1 = uint3x3(484398043, 226568494, 507918242, 1702162286, 923269270, 166187260, 114581840, 1045389187, 1648095254);
            uint b1 = (506946952);
            bool3x3 r1 = bool3x3(true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            uint3x3 a2 = uint3x3(1461803977, 1317840133, 2146927809, 1557151164, 1284033253, 1345705546, 1747302566, 611028295, 1368046109);
            uint b2 = (61801615);
            bool3x3 r2 = bool3x3(true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            uint3x3 a3 = uint3x3(1848036266, 373992983, 289537519, 1388743060, 146455100, 1854553487, 872755032, 2113020512, 1062447442);
            uint b3 = (2025452920);
            bool3x3 r3 = bool3x3(true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void uint3x3_operator_not_equal_scalar_wide()
        {
            uint a0 = (1652127596);
            uint3x3 b0 = uint3x3(953791238, 271722683, 1278885987, 735128017, 112416504, 25967222, 1761444475, 1844594536, 1199122922);
            bool3x3 r0 = bool3x3(true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 != b0, r0);

            uint a1 = (634219279);
            uint3x3 b1 = uint3x3(942501101, 67161343, 969944293, 833229499, 1304301133, 704045745, 345012334, 1253134152, 325772538);
            bool3x3 r1 = bool3x3(true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 != b1, r1);

            uint a2 = (855127202);
            uint3x3 b2 = uint3x3(793668881, 1584481616, 1101301152, 276853534, 987168816, 1258105989, 362645228, 293978043, 1772395973);
            bool3x3 r2 = bool3x3(true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a2 != b2, r2);

            uint a3 = (1692007315);
            uint3x3 b3 = uint3x3(681268929, 1535518457, 595209334, 25745185, 1278016813, 2125682481, 2037751005, 1405297618, 1825546885);
            bool3x3 r3 = bool3x3(true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 != b3, r3);
        }

        [Test]
        public void uint3x3_operator_less_wide_wide()
        {
            uint3x3 a0 = uint3x3(1486550609, 1779244308, 1602148045, 1614085440, 1975613414, 942838342, 1092279031, 373677431, 1419098312);
            uint3x3 b0 = uint3x3(97842578, 536551311, 413528975, 1838293684, 1283898480, 1456599961, 1080278602, 529676676, 156584048);
            bool3x3 r0 = bool3x3(false, false, false, true, false, true, false, true, false);
            TestUtils.AreEqual(a0 < b0, r0);

            uint3x3 a1 = uint3x3(337757077, 1081797900, 1336745069, 840685445, 1220554047, 2013681746, 192965012, 532043965, 1000693402);
            uint3x3 b1 = uint3x3(117348799, 246927124, 1916615924, 1731071394, 1328098431, 1014995792, 480319327, 1765937053, 1333997067);
            bool3x3 r1 = bool3x3(false, false, true, true, true, false, true, true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            uint3x3 a2 = uint3x3(927236048, 1215860000, 780607596, 1882056852, 1354146545, 2135295778, 1145973790, 1938006975, 895882838);
            uint3x3 b2 = uint3x3(688515308, 1856106947, 1303906227, 646821776, 1169473993, 316770064, 1518155802, 416732703, 529193056);
            bool3x3 r2 = bool3x3(false, true, true, false, false, false, true, false, false);
            TestUtils.AreEqual(a2 < b2, r2);

            uint3x3 a3 = uint3x3(2006524299, 908581156, 1843349513, 1340458575, 1972095585, 1090933468, 924555996, 79585200, 1749924275);
            uint3x3 b3 = uint3x3(1239623485, 2010112031, 2018560298, 285987009, 960617622, 462519015, 1473825625, 1187164011, 730583004);
            bool3x3 r3 = bool3x3(false, true, true, false, false, false, true, true, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void uint3x3_operator_less_wide_scalar()
        {
            uint3x3 a0 = uint3x3(796797557, 670113454, 933579492, 278884514, 318174822, 1117630673, 741886928, 1990922600, 1030849597);
            uint b0 = (746564682);
            bool3x3 r0 = bool3x3(false, true, false, true, true, false, true, false, false);
            TestUtils.AreEqual(a0 < b0, r0);

            uint3x3 a1 = uint3x3(1546212312, 1648393417, 1857132231, 1909506562, 1294006045, 952084157, 1303736668, 845460171, 979430272);
            uint b1 = (1718582899);
            bool3x3 r1 = bool3x3(true, true, false, false, true, true, true, true, true);
            TestUtils.AreEqual(a1 < b1, r1);

            uint3x3 a2 = uint3x3(1368236640, 1434668705, 659552739, 1058492383, 165694933, 1204097259, 922212691, 281328069, 24629507);
            uint b2 = (24980695);
            bool3x3 r2 = bool3x3(false, false, false, false, false, false, false, false, true);
            TestUtils.AreEqual(a2 < b2, r2);

            uint3x3 a3 = uint3x3(1386458568, 1498707004, 1650355158, 1213017950, 1650457461, 759932777, 1542997846, 1227393490, 1520634374);
            uint b3 = (1325149699);
            bool3x3 r3 = bool3x3(false, false, false, true, false, true, false, true, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void uint3x3_operator_less_scalar_wide()
        {
            uint a0 = (186400299);
            uint3x3 b0 = uint3x3(1881344229, 813834467, 1254886626, 1353590345, 1412343685, 1555571443, 1540508298, 1735458634, 135888070);
            bool3x3 r0 = bool3x3(true, true, true, true, true, true, true, true, false);
            TestUtils.AreEqual(a0 < b0, r0);

            uint a1 = (1643818742);
            uint3x3 b1 = uint3x3(248291654, 1739560105, 728539891, 480507742, 1696553040, 540223931, 1840493353, 146833656, 798115946);
            bool3x3 r1 = bool3x3(false, true, false, false, true, false, true, false, false);
            TestUtils.AreEqual(a1 < b1, r1);

            uint a2 = (2002002066);
            uint3x3 b2 = uint3x3(1011261705, 783550942, 1093071215, 598253401, 1432416562, 1863582169, 103622950, 775175960, 116908309);
            bool3x3 r2 = bool3x3(false, false, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a2 < b2, r2);

            uint a3 = (1213433625);
            uint3x3 b3 = uint3x3(1428954824, 1760442490, 1208143947, 751820805, 1491872302, 560004484, 2065157473, 310839658, 697329242);
            bool3x3 r3 = bool3x3(true, true, false, false, true, false, true, false, false);
            TestUtils.AreEqual(a3 < b3, r3);
        }

        [Test]
        public void uint3x3_operator_greater_wide_wide()
        {
            uint3x3 a0 = uint3x3(2087717754, 1725569452, 1298066182, 1693943616, 1319019629, 70674491, 1042499725, 1002821508, 1021857133);
            uint3x3 b0 = uint3x3(85148514, 293632137, 1151128249, 409440398, 1115020183, 1508500597, 1834583302, 1755218534, 1788761753);
            bool3x3 r0 = bool3x3(true, true, true, true, true, false, false, false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            uint3x3 a1 = uint3x3(1744374599, 821751047, 467646903, 2029731638, 1377214212, 1207816926, 474621063, 20781266, 366593779);
            uint3x3 b1 = uint3x3(1128238489, 834223713, 1578743290, 1647150256, 1756397855, 1131080201, 1208965204, 1495161099, 1283714281);
            bool3x3 r1 = bool3x3(true, false, false, true, false, true, false, false, false);
            TestUtils.AreEqual(a1 > b1, r1);

            uint3x3 a2 = uint3x3(2068457387, 10181449, 793634464, 144474612, 99947390, 930377263, 683686232, 742803073, 918292048);
            uint3x3 b2 = uint3x3(908051907, 412849651, 815822687, 730271942, 40756039, 883326140, 476260632, 1024136446, 1440596667);
            bool3x3 r2 = bool3x3(true, false, false, false, true, true, true, false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            uint3x3 a3 = uint3x3(875621429, 1764985258, 411384146, 1921397684, 1349107119, 640399120, 1487719331, 1467989523, 1834244794);
            uint3x3 b3 = uint3x3(1253494041, 146826162, 1798399573, 2085029408, 187939428, 1009192934, 1694822273, 1866590874, 113805226);
            bool3x3 r3 = bool3x3(false, true, false, false, true, false, false, false, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void uint3x3_operator_greater_wide_scalar()
        {
            uint3x3 a0 = uint3x3(1208626274, 239697208, 1979453345, 1253474001, 1590192876, 1487911635, 1673945595, 1662650098, 222749855);
            uint b0 = (1715176566);
            bool3x3 r0 = bool3x3(false, false, true, false, false, false, false, false, false);
            TestUtils.AreEqual(a0 > b0, r0);

            uint3x3 a1 = uint3x3(1433540517, 1773305960, 1850273578, 206147145, 325913453, 333381537, 1905567362, 2053577491, 570397194);
            uint b1 = (566635217);
            bool3x3 r1 = bool3x3(true, true, true, false, false, false, true, true, true);
            TestUtils.AreEqual(a1 > b1, r1);

            uint3x3 a2 = uint3x3(2128431130, 529971908, 1663525234, 1972984241, 1587865063, 488268523, 121921923, 812076921, 181082921);
            uint b2 = (1735325311);
            bool3x3 r2 = bool3x3(true, false, false, true, false, false, false, false, false);
            TestUtils.AreEqual(a2 > b2, r2);

            uint3x3 a3 = uint3x3(1281638484, 116518997, 1397728785, 1924199337, 742950077, 1463993051, 1598027926, 842851852, 160842093);
            uint b3 = (1818357732);
            bool3x3 r3 = bool3x3(false, false, false, true, false, false, false, false, false);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void uint3x3_operator_greater_scalar_wide()
        {
            uint a0 = (480938827);
            uint3x3 b0 = uint3x3(1824731899, 921496110, 586859044, 946430596, 1231356727, 1390167458, 1785807092, 28949024, 2037899283);
            bool3x3 r0 = bool3x3(false, false, false, false, false, false, false, true, false);
            TestUtils.AreEqual(a0 > b0, r0);

            uint a1 = (595656760);
            uint3x3 b1 = uint3x3(1778095771, 1233500439, 1696302238, 1445965340, 484020151, 1586962841, 1361740714, 265628948, 2003122957);
            bool3x3 r1 = bool3x3(false, false, false, false, true, false, false, true, false);
            TestUtils.AreEqual(a1 > b1, r1);

            uint a2 = (332267433);
            uint3x3 b2 = uint3x3(1128353075, 377919478, 982113135, 1117675960, 630865591, 1550679736, 895945757, 287025687, 643452096);
            bool3x3 r2 = bool3x3(false, false, false, false, false, false, false, true, false);
            TestUtils.AreEqual(a2 > b2, r2);

            uint a3 = (660504007);
            uint3x3 b3 = uint3x3(613135893, 633307118, 514276792, 1377364317, 84491736, 746768197, 1282879723, 589415384, 363082240);
            bool3x3 r3 = bool3x3(true, true, true, false, true, false, false, true, true);
            TestUtils.AreEqual(a3 > b3, r3);
        }

        [Test]
        public void uint3x3_operator_less_equal_wide_wide()
        {
            uint3x3 a0 = uint3x3(154092149, 1515170149, 1083970332, 785807178, 1401094881, 310537627, 868328962, 1990816725, 2035349541);
            uint3x3 b0 = uint3x3(77984380, 1712054191, 1566203809, 254834519, 450519938, 389457083, 1298669505, 207343167, 1214449047);
            bool3x3 r0 = bool3x3(false, true, true, false, false, true, true, false, false);
            TestUtils.AreEqual(a0 <= b0, r0);

            uint3x3 a1 = uint3x3(457043352, 1123282035, 1001842946, 1387761992, 195272789, 659549000, 888761458, 283706617, 1790185840);
            uint3x3 b1 = uint3x3(2059561026, 896534357, 1897470050, 521075677, 1848221945, 374708019, 1573731118, 2093466449, 1660210829);
            bool3x3 r1 = bool3x3(true, false, true, false, true, false, true, true, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            uint3x3 a2 = uint3x3(899029812, 848317418, 1743712447, 1504407474, 1798441490, 1902791952, 606340844, 1994437705, 301831413);
            uint3x3 b2 = uint3x3(1568778785, 1352157589, 1212771905, 1457525058, 1493446008, 1784768208, 1993422493, 1378671664, 1447376929);
            bool3x3 r2 = bool3x3(true, true, false, false, false, false, true, false, true);
            TestUtils.AreEqual(a2 <= b2, r2);

            uint3x3 a3 = uint3x3(654230470, 1223625081, 324292199, 1370931020, 1742769166, 1709242127, 105750466, 1655967312, 1455797002);
            uint3x3 b3 = uint3x3(1405041439, 1765183746, 562894655, 1085068880, 1026386862, 884290156, 922346160, 330605896, 466570756);
            bool3x3 r3 = bool3x3(true, true, true, false, false, false, true, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void uint3x3_operator_less_equal_wide_scalar()
        {
            uint3x3 a0 = uint3x3(1479531977, 1427983411, 415250630, 1245345407, 1112546666, 1072990632, 1579912858, 101048307, 1070894375);
            uint b0 = (2004563877);
            bool3x3 r0 = bool3x3(true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            uint3x3 a1 = uint3x3(509818792, 85452501, 518127023, 1246249980, 1097326500, 1964410699, 1968139888, 1191853379, 662096238);
            uint b1 = (1910488590);
            bool3x3 r1 = bool3x3(true, true, true, true, true, false, false, true, true);
            TestUtils.AreEqual(a1 <= b1, r1);

            uint3x3 a2 = uint3x3(1140643434, 155343473, 995927387, 974873240, 1773400038, 497436329, 1825940497, 527516420, 1477043363);
            uint b2 = (754434551);
            bool3x3 r2 = bool3x3(false, true, false, false, false, true, false, true, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            uint3x3 a3 = uint3x3(1378470734, 37188105, 839762283, 781102710, 766321672, 1145011483, 139031840, 127837780, 817806943);
            uint b3 = (96190147);
            bool3x3 r3 = bool3x3(false, true, false, false, false, false, false, false, false);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void uint3x3_operator_less_equal_scalar_wide()
        {
            uint a0 = (1899193992);
            uint3x3 b0 = uint3x3(915011820, 980913757, 1337699683, 1476321359, 1102143668, 660493983, 184664508, 381579707, 1954892821);
            bool3x3 r0 = bool3x3(false, false, false, false, false, false, false, false, true);
            TestUtils.AreEqual(a0 <= b0, r0);

            uint a1 = (1295090571);
            uint3x3 b1 = uint3x3(1440368586, 1696003686, 88708652, 1332251857, 1310713644, 2112132784, 48951945, 1888568027, 39340955);
            bool3x3 r1 = bool3x3(true, true, false, true, true, true, false, true, false);
            TestUtils.AreEqual(a1 <= b1, r1);

            uint a2 = (1108242207);
            uint3x3 b2 = uint3x3(260777425, 593122164, 291471959, 253457314, 1264570386, 699618012, 927735863, 2063158939, 932253787);
            bool3x3 r2 = bool3x3(false, false, false, false, true, false, false, true, false);
            TestUtils.AreEqual(a2 <= b2, r2);

            uint a3 = (1168754049);
            uint3x3 b3 = uint3x3(749328788, 1882694892, 168499987, 378173027, 339963627, 832906712, 559482768, 53067420, 1895722478);
            bool3x3 r3 = bool3x3(false, true, false, false, false, false, false, false, true);
            TestUtils.AreEqual(a3 <= b3, r3);
        }

        [Test]
        public void uint3x3_operator_greater_equal_wide_wide()
        {
            uint3x3 a0 = uint3x3(8538378, 2131749726, 265427108, 523609761, 994991818, 839709564, 101288202, 1886280970, 2032074826);
            uint3x3 b0 = uint3x3(903145828, 1697992986, 1432491982, 169789504, 1059357300, 1744255222, 1606584463, 1905414425, 1448794969);
            bool3x3 r0 = bool3x3(false, true, false, true, false, false, false, false, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            uint3x3 a1 = uint3x3(631221455, 1456286159, 961342752, 424526026, 788481984, 1662488497, 870326690, 708712581, 1260182701);
            uint3x3 b1 = uint3x3(136181998, 1678754836, 2069656857, 398982689, 243317404, 740939613, 1894753119, 301760792, 1260647988);
            bool3x3 r1 = bool3x3(true, false, false, true, true, true, false, true, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            uint3x3 a2 = uint3x3(1165630721, 138247561, 1108650168, 1933222913, 672493999, 1541402159, 1921596027, 1557351956, 147242547);
            uint3x3 b2 = uint3x3(3608523, 52576030, 903420465, 1648820371, 627296845, 1679808907, 1719102039, 1718081638, 655586949);
            bool3x3 r2 = bool3x3(true, true, true, true, true, false, true, false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            uint3x3 a3 = uint3x3(892772168, 2089286723, 1273466960, 644009998, 654784654, 189030610, 1035542641, 346401762, 739783704);
            uint3x3 b3 = uint3x3(477267189, 62092869, 2013928066, 280292357, 254052205, 1092440092, 1947011057, 625632982, 2028466303);
            bool3x3 r3 = bool3x3(true, true, false, true, true, false, false, false, false);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void uint3x3_operator_greater_equal_wide_scalar()
        {
            uint3x3 a0 = uint3x3(2049236663, 182691143, 634973382, 1197012109, 439837565, 1367606469, 1108037359, 351147187, 1898505669);
            uint b0 = (1061998015);
            bool3x3 r0 = bool3x3(true, false, false, true, false, true, true, false, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            uint3x3 a1 = uint3x3(411667685, 4652390, 996159180, 2111455181, 727766399, 96217144, 814085575, 1525995206, 1293933760);
            uint b1 = (1998610091);
            bool3x3 r1 = bool3x3(false, false, false, true, false, false, false, false, false);
            TestUtils.AreEqual(a1 >= b1, r1);

            uint3x3 a2 = uint3x3(1732973229, 899444524, 1023753195, 1373738074, 518164359, 717850464, 1765188600, 1826820341, 527594558);
            uint b2 = (1473283041);
            bool3x3 r2 = bool3x3(true, false, false, false, false, false, true, true, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            uint3x3 a3 = uint3x3(1816542874, 1143596061, 1819554651, 160724539, 993212636, 878086499, 363122662, 1989978759, 2145562949);
            uint b3 = (839185150);
            bool3x3 r3 = bool3x3(true, true, true, false, true, true, false, true, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void uint3x3_operator_greater_equal_scalar_wide()
        {
            uint a0 = (1859811087);
            uint3x3 b0 = uint3x3(1070365918, 1783869452, 830091760, 377157428, 327199016, 90384229, 1154649706, 376758501, 1079802834);
            bool3x3 r0 = bool3x3(true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a0 >= b0, r0);

            uint a1 = (2054742898);
            uint3x3 b1 = uint3x3(1328349472, 434061447, 951207723, 598695892, 975131651, 1714007943, 177416473, 1267232721, 31082860);
            bool3x3 r1 = bool3x3(true, true, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a1 >= b1, r1);

            uint a2 = (216791741);
            uint3x3 b2 = uint3x3(119054289, 1905107583, 89559116, 55041824, 691334141, 462326883, 1658303669, 914628512, 1134364322);
            bool3x3 r2 = bool3x3(true, false, true, true, false, false, false, false, false);
            TestUtils.AreEqual(a2 >= b2, r2);

            uint a3 = (1677134711);
            uint3x3 b3 = uint3x3(1955614770, 2067009301, 1454405405, 299467282, 1584922149, 561776357, 564147844, 398216936, 1478439642);
            bool3x3 r3 = bool3x3(false, false, true, true, true, true, true, true, true);
            TestUtils.AreEqual(a3 >= b3, r3);
        }

        [Test]
        public void uint3x3_operator_add_wide_wide()
        {
            uint3x3 a0 = uint3x3(2135171378, 21433296, 1954723494, 683604307, 1054212315, 1762680995, 1963655852, 1257853062, 2043493600);
            uint3x3 b0 = uint3x3(1013431952, 366718162, 359290756, 1393163294, 1962236872, 1263270041, 1862666629, 1077447887, 821693806);
            uint3x3 r0 = uint3x3(3148603330, 388151458, 2314014250, 2076767601, 3016449187, 3025951036, 3826322481, 2335300949, 2865187406);
            TestUtils.AreEqual(a0 + b0, r0);

            uint3x3 a1 = uint3x3(976898058, 1915056423, 121374462, 1218855698, 700538222, 1702057277, 1788251699, 1534939160, 398651016);
            uint3x3 b1 = uint3x3(487316539, 350922520, 1583012528, 1951595076, 1024851344, 874302782, 1383969588, 1767968088, 900721406);
            uint3x3 r1 = uint3x3(1464214597, 2265978943, 1704386990, 3170450774, 1725389566, 2576360059, 3172221287, 3302907248, 1299372422);
            TestUtils.AreEqual(a1 + b1, r1);

            uint3x3 a2 = uint3x3(1674272498, 374510467, 824322986, 1217622199, 1122376670, 642613771, 1097903998, 359042741, 929182687);
            uint3x3 b2 = uint3x3(1659790033, 1792273749, 443844328, 633981449, 2010244807, 335566991, 521931102, 544297835, 1681549647);
            uint3x3 r2 = uint3x3(3334062531, 2166784216, 1268167314, 1851603648, 3132621477, 978180762, 1619835100, 903340576, 2610732334);
            TestUtils.AreEqual(a2 + b2, r2);

            uint3x3 a3 = uint3x3(1713065399, 892057490, 1295346111, 1806236181, 1838589664, 173985173, 1875814528, 1464015613, 1550659036);
            uint3x3 b3 = uint3x3(1784248858, 585904415, 3128418, 1806236610, 179909533, 378711407, 195687764, 357131656, 383703567);
            uint3x3 r3 = uint3x3(3497314257, 1477961905, 1298474529, 3612472791, 2018499197, 552696580, 2071502292, 1821147269, 1934362603);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void uint3x3_operator_add_wide_scalar()
        {
            uint3x3 a0 = uint3x3(665815972, 1783729250, 1591678394, 1284528538, 977850224, 71069732, 1138577680, 1200356017, 565982008);
            uint b0 = (1334043849);
            uint3x3 r0 = uint3x3(1999859821, 3117773099, 2925722243, 2618572387, 2311894073, 1405113581, 2472621529, 2534399866, 1900025857);
            TestUtils.AreEqual(a0 + b0, r0);

            uint3x3 a1 = uint3x3(1246759684, 57252642, 678921480, 625943813, 512157429, 1470648741, 1490096953, 1467033531, 182608093);
            uint b1 = (1088001167);
            uint3x3 r1 = uint3x3(2334760851, 1145253809, 1766922647, 1713944980, 1600158596, 2558649908, 2578098120, 2555034698, 1270609260);
            TestUtils.AreEqual(a1 + b1, r1);

            uint3x3 a2 = uint3x3(1707296407, 1333833947, 653973063, 1139546735, 1834005844, 184572739, 1980578280, 1858520040, 97099208);
            uint b2 = (1703724354);
            uint3x3 r2 = uint3x3(3411020761, 3037558301, 2357697417, 2843271089, 3537730198, 1888297093, 3684302634, 3562244394, 1800823562);
            TestUtils.AreEqual(a2 + b2, r2);

            uint3x3 a3 = uint3x3(421437295, 166844260, 1568146789, 82548613, 533562157, 1464065228, 716600557, 831997894, 861575416);
            uint b3 = (1251829854);
            uint3x3 r3 = uint3x3(1673267149, 1418674114, 2819976643, 1334378467, 1785392011, 2715895082, 1968430411, 2083827748, 2113405270);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void uint3x3_operator_add_scalar_wide()
        {
            uint a0 = (359966320);
            uint3x3 b0 = uint3x3(2146146202, 767103309, 851002415, 311531406, 1491262941, 1016891373, 1954228994, 1671335850, 727870747);
            uint3x3 r0 = uint3x3(2506112522, 1127069629, 1210968735, 671497726, 1851229261, 1376857693, 2314195314, 2031302170, 1087837067);
            TestUtils.AreEqual(a0 + b0, r0);

            uint a1 = (551151834);
            uint3x3 b1 = uint3x3(1390261152, 1699060326, 115021619, 1964440175, 440700758, 1556692550, 185414255, 933106731, 1217866784);
            uint3x3 r1 = uint3x3(1941412986, 2250212160, 666173453, 2515592009, 991852592, 2107844384, 736566089, 1484258565, 1769018618);
            TestUtils.AreEqual(a1 + b1, r1);

            uint a2 = (729761881);
            uint3x3 b2 = uint3x3(1742597318, 1090109152, 1467373815, 1066072609, 138237856, 634834665, 993603553, 347587889, 2050191349);
            uint3x3 r2 = uint3x3(2472359199, 1819871033, 2197135696, 1795834490, 867999737, 1364596546, 1723365434, 1077349770, 2779953230);
            TestUtils.AreEqual(a2 + b2, r2);

            uint a3 = (670698672);
            uint3x3 b3 = uint3x3(1658205080, 1874808705, 2082982954, 869839589, 118460267, 2126166073, 1826004041, 1976984739, 1612682951);
            uint3x3 r3 = uint3x3(2328903752, 2545507377, 2753681626, 1540538261, 789158939, 2796864745, 2496702713, 2647683411, 2283381623);
            TestUtils.AreEqual(a3 + b3, r3);
        }

        [Test]
        public void uint3x3_operator_sub_wide_wide()
        {
            uint3x3 a0 = uint3x3(1410318491, 1097280168, 1827039044, 28881338, 328720965, 875487868, 212936325, 231977215, 1740021315);
            uint3x3 b0 = uint3x3(1315897366, 799052018, 1580289673, 1094686261, 1954325726, 1197734816, 229886366, 915679176, 1746884850);
            uint3x3 r0 = uint3x3(94421125, 298228150, 246749371, 3229162373, 2669362535, 3972720348, 4278017255, 3611265335, 4288103761);
            TestUtils.AreEqual(a0 - b0, r0);

            uint3x3 a1 = uint3x3(2011295463, 48079003, 591379285, 1125909359, 1842588095, 848561896, 614448464, 2067598029, 1618238416);
            uint3x3 b1 = uint3x3(918743925, 1007797419, 257421324, 287249342, 1617287463, 1653916102, 123586847, 502107404, 672875302);
            uint3x3 r1 = uint3x3(1092551538, 3335248880, 333957961, 838660017, 225300632, 3489613090, 490861617, 1565490625, 945363114);
            TestUtils.AreEqual(a1 - b1, r1);

            uint3x3 a2 = uint3x3(318516219, 1090119767, 1991095823, 949592162, 1951912339, 1457818751, 1642553126, 2114366549, 1420516260);
            uint3x3 b2 = uint3x3(1256481116, 1975569142, 1794443030, 1327558915, 330955394, 1596041731, 1069074732, 1120817099, 2076417364);
            uint3x3 r2 = uint3x3(3357002399, 3409517921, 196652793, 3917000543, 1620956945, 4156744316, 573478394, 993549450, 3639066192);
            TestUtils.AreEqual(a2 - b2, r2);

            uint3x3 a3 = uint3x3(596841760, 724518081, 1820626306, 1885185225, 246124365, 1339877262, 1277620434, 759131597, 597162957);
            uint3x3 b3 = uint3x3(402521072, 839858844, 1539789702, 559077522, 822288510, 751901021, 1858312568, 1706585560, 483540199);
            uint3x3 r3 = uint3x3(194320688, 4179626533, 280836604, 1326107703, 3718803151, 587976241, 3714275162, 3347513333, 113622758);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void uint3x3_operator_sub_wide_scalar()
        {
            uint3x3 a0 = uint3x3(1508669340, 1594795463, 266707545, 643102647, 287705008, 1475644328, 1113286221, 979450511, 2082174113);
            uint b0 = (998008471);
            uint3x3 r0 = uint3x3(510660869, 596786992, 3563666370, 3940061472, 3584663833, 477635857, 115277750, 4276409336, 1084165642);
            TestUtils.AreEqual(a0 - b0, r0);

            uint3x3 a1 = uint3x3(1108005498, 999244508, 1806482044, 1994553647, 2101812429, 1482736902, 266654115, 1470212363, 1190349300);
            uint b1 = (304369206);
            uint3x3 r1 = uint3x3(803636292, 694875302, 1502112838, 1690184441, 1797443223, 1178367696, 4257252205, 1165843157, 885980094);
            TestUtils.AreEqual(a1 - b1, r1);

            uint3x3 a2 = uint3x3(958542155, 1738124835, 499527536, 1612473406, 1696960099, 1287292743, 1360229454, 1032360376, 1779621585);
            uint b2 = (1185075537);
            uint3x3 r2 = uint3x3(4068433914, 553049298, 3609419295, 427397869, 511884562, 102217206, 175153917, 4142252135, 594546048);
            TestUtils.AreEqual(a2 - b2, r2);

            uint3x3 a3 = uint3x3(964948785, 94254551, 968533883, 2075770560, 946189008, 1074604044, 1171596880, 1033389665, 1905912138);
            uint b3 = (1739264125);
            uint3x3 r3 = uint3x3(3520651956, 2649957722, 3524237054, 336506435, 3501892179, 3630307215, 3727300051, 3589092836, 166648013);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void uint3x3_operator_sub_scalar_wide()
        {
            uint a0 = (893369501);
            uint3x3 b0 = uint3x3(2051906184, 1699714311, 442603706, 1735141684, 274533585, 811580259, 1196354320, 1524097023, 533621527);
            uint3x3 r0 = uint3x3(3136430613, 3488622486, 450765795, 3453195113, 618835916, 81789242, 3991982477, 3664239774, 359747974);
            TestUtils.AreEqual(a0 - b0, r0);

            uint a1 = (2080845793);
            uint3x3 b1 = uint3x3(143958837, 1620668660, 1135989346, 1367044745, 554088609, 552670373, 1265516124, 1254902543, 1857695581);
            uint3x3 r1 = uint3x3(1936886956, 460177133, 944856447, 713801048, 1526757184, 1528175420, 815329669, 825943250, 223150212);
            TestUtils.AreEqual(a1 - b1, r1);

            uint a2 = (1619865274);
            uint3x3 b2 = uint3x3(1313559400, 99812999, 843597298, 420111239, 1299949060, 531009038, 1103306550, 104920105, 1137308312);
            uint3x3 r2 = uint3x3(306305874, 1520052275, 776267976, 1199754035, 319916214, 1088856236, 516558724, 1514945169, 482556962);
            TestUtils.AreEqual(a2 - b2, r2);

            uint a3 = (1207332725);
            uint3x3 b3 = uint3x3(103438360, 1157123503, 1174401240, 701247193, 1498366995, 467017290, 109208355, 1594646461, 1252691221);
            uint3x3 r3 = uint3x3(1103894365, 50209222, 32931485, 506085532, 4003933026, 740315435, 1098124370, 3907653560, 4249608800);
            TestUtils.AreEqual(a3 - b3, r3);
        }

        [Test]
        public void uint3x3_operator_mul_wide_wide()
        {
            uint3x3 a0 = uint3x3(61417577, 219585476, 1362520891, 1511084277, 1481211272, 58211871, 1459591173, 567624644, 1169935583);
            uint3x3 b0 = uint3x3(578042444, 1620527213, 200516468, 309339115, 542853019, 299467282, 1479641221, 1428338601, 1497302909);
            uint3x3 r0 = uint3x3(2868103468, 1326150260, 3304073148, 2972110823, 1973926232, 88546350, 3431047833, 3712145508, 556671459);
            TestUtils.AreEqual(a0 * b0, r0);

            uint3x3 a1 = uint3x3(1835691886, 385626539, 85934842, 522856538, 278370196, 289217012, 2083410174, 1293162798, 1939730122);
            uint3x3 b1 = uint3x3(1596889147, 427413842, 265122693, 689376654, 1120457204, 516903000, 873091659, 1353196495, 1384773500);
            uint3x3 r1 = uint3x3(1098186330, 1848083398, 4236646882, 2005201900, 651971856, 2573806560, 4184807018, 4175537714, 3758002136);
            TestUtils.AreEqual(a1 * b1, r1);

            uint3x3 a2 = uint3x3(2075923048, 1116477212, 1686101741, 783310758, 248585944, 1093377716, 797038788, 1838048120, 1892922904);
            uint3x3 b2 = uint3x3(1596528529, 2122329305, 1033200564, 996795088, 1137754930, 232014195, 1080950243, 1613216909, 463529448);
            uint3x3 r2 = uint3x3(2245379304, 3535300284, 1443849636, 550781664, 3335949872, 3941859036, 3201362380, 264300824, 4173364672);
            TestUtils.AreEqual(a2 * b2, r2);

            uint3x3 a3 = uint3x3(1952024781, 492107602, 1097670675, 2069629919, 20122103, 606926492, 1153788131, 1687394746, 1499899200);
            uint3x3 b3 = uint3x3(1781487382, 2101946430, 673144237, 390627073, 964308272, 1332603859, 106394678, 1330334791, 1720890701);
            uint3x3 r3 = uint3x3(1825729694, 4053448156, 3048379351, 2230824159, 4043852112, 1004304020, 3964664802, 638638742, 892728384);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void uint3x3_operator_mul_wide_scalar()
        {
            uint3x3 a0 = uint3x3(871746615, 492532311, 570557670, 2142306629, 1610315153, 1526163563, 118471734, 257439514, 364291059);
            uint b0 = (442064533);
            uint3x3 r0 = uint3x3(338365955, 1081376419, 2565819870, 3279557417, 3421481829, 4119466055, 3456786286, 513646114, 1627104879);
            TestUtils.AreEqual(a0 * b0, r0);

            uint3x3 a1 = uint3x3(1186560810, 1357601203, 638897141, 268562104, 1007838321, 1163240135, 1619806399, 1444659979, 1127580168);
            uint b1 = (1584938026);
            uint3x3 r1 = uint3x3(989596900, 898280286, 2953765426, 2323925552, 3179738762, 3514521766, 4086870870, 426546126, 1963013456);
            TestUtils.AreEqual(a1 * b1, r1);

            uint3x3 a2 = uint3x3(464517916, 745488654, 636691139, 1851670006, 357357967, 1095280227, 702779195, 945802744, 1464398841);
            uint b2 = (1508043166);
            uint3x3 r2 = uint3x3(2900457288, 4215006372, 836300634, 498803668, 3736038722, 3098332186, 3974437226, 176674576, 937833646);
            TestUtils.AreEqual(a2 * b2, r2);

            uint3x3 a3 = uint3x3(51061000, 407442471, 638315697, 1889264235, 584402164, 1343048690, 2144106255, 1634890111, 425282134);
            uint b3 = (802418971);
            uint3x3 r3 = uint3x3(2111636440, 550688541, 3522664363, 3821575241, 327416252, 4233876614, 3640831381, 3768026981, 3393703186);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void uint3x3_operator_mul_scalar_wide()
        {
            uint a0 = (1152242766);
            uint3x3 b0 = uint3x3(1276636134, 2105929407, 499007702, 124002565, 1956335172, 1288034953, 832676555, 337389733, 99268757);
            uint3x3 r0 = uint3x3(2165463060, 999811634, 1179056436, 3493540742, 404105400, 1339492798, 3913201114, 3183347270, 2131796326);
            TestUtils.AreEqual(a0 * b0, r0);

            uint a1 = (2005055247);
            uint3x3 b1 = uint3x3(2011389505, 1348110859, 399689191, 2007606374, 2076691289, 1825721194, 769885235, 153314735, 1066325369);
            uint3x3 r1 = uint3x3(2729770191, 2761028517, 4045388169, 759270394, 3041102135, 1175400758, 716911613, 3533770305, 2053767447);
            TestUtils.AreEqual(a1 * b1, r1);

            uint a2 = (84289667);
            uint3x3 b2 = uint3x3(984486192, 1325213504, 1643957457, 1576395620, 2095980601, 907671947, 836919582, 1412159342, 2037926630);
            uint3x3 r2 = uint3x3(2430749584, 623711680, 2252568307, 3367173164, 20538667, 1317693985, 3266863706, 514616650, 866534322);
            TestUtils.AreEqual(a2 * b2, r2);

            uint a3 = (366590562);
            uint3x3 b3 = uint3x3(493177763, 2058824164, 497936968, 2136548816, 1211907591, 2113626509, 345443734, 353147704, 688487056);
            uint3x3 r3 = uint3x3(1441161830, 1154593096, 936640400, 2733218208, 2467288238, 547408378, 1943547756, 1645353840, 1287490336);
            TestUtils.AreEqual(a3 * b3, r3);
        }

        [Test]
        public void uint3x3_operator_div_wide_wide()
        {
            uint3x3 a0 = uint3x3(333171510, 858154903, 1181365836, 671357749, 1090606752, 803759420, 788404166, 296807814, 575260195);
            uint3x3 b0 = uint3x3(698897823, 440199998, 655557473, 1658534285, 2127220100, 315653188, 1814290360, 992173243, 914851653);
            uint3x3 r0 = uint3x3(0, 1, 1, 0, 0, 2, 0, 0, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            uint3x3 a1 = uint3x3(166625280, 1493729000, 1831739736, 200852358, 129983172, 500176108, 472051781, 414699094, 1446535974);
            uint3x3 b1 = uint3x3(664340325, 224323977, 246981573, 285573983, 819471609, 2012476015, 1783179572, 223253978, 169515029);
            uint3x3 r1 = uint3x3(0, 6, 7, 0, 0, 0, 0, 1, 8);
            TestUtils.AreEqual(a1 / b1, r1);

            uint3x3 a2 = uint3x3(1278480457, 930910505, 263295881, 1626759436, 450830871, 21439121, 521337599, 127756712, 200601965);
            uint3x3 b2 = uint3x3(1694929006, 1992168131, 1155972447, 1768506696, 422325410, 1508417406, 605462475, 66917170, 2014683461);
            uint3x3 r2 = uint3x3(0, 0, 0, 0, 1, 0, 0, 1, 0);
            TestUtils.AreEqual(a2 / b2, r2);

            uint3x3 a3 = uint3x3(412554396, 1014641734, 239347640, 525574301, 1158358177, 1655168319, 2048437741, 367754386, 1861176433);
            uint3x3 b3 = uint3x3(108847533, 611173330, 895791853, 1999369787, 1225614384, 1168063495, 565150188, 127292785, 1027814836);
            uint3x3 r3 = uint3x3(3, 1, 0, 0, 0, 1, 3, 2, 1);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void uint3x3_operator_div_wide_scalar()
        {
            uint3x3 a0 = uint3x3(1433072926, 1073958635, 1195142312, 536596719, 1274375693, 464756346, 806462546, 906504670, 1380905136);
            uint b0 = (1434025872);
            uint3x3 r0 = uint3x3(0, 0, 0, 0, 0, 0, 0, 0, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            uint3x3 a1 = uint3x3(25493909, 123300377, 643754735, 2084019932, 2047825037, 458304263, 741331531, 466443901, 2110004616);
            uint b1 = (1196815948);
            uint3x3 r1 = uint3x3(0, 0, 0, 1, 1, 0, 0, 0, 1);
            TestUtils.AreEqual(a1 / b1, r1);

            uint3x3 a2 = uint3x3(1500687214, 1617154145, 2040203220, 2103351724, 485536709, 402141749, 1477264254, 1629069474, 1549487015);
            uint b2 = (1453264263);
            uint3x3 r2 = uint3x3(1, 1, 1, 1, 0, 0, 1, 1, 1);
            TestUtils.AreEqual(a2 / b2, r2);

            uint3x3 a3 = uint3x3(670594363, 155415284, 207130003, 1596922206, 1730223836, 1528374182, 1878500631, 1245757182, 1471308702);
            uint b3 = (2040479674);
            uint3x3 r3 = uint3x3(0, 0, 0, 0, 0, 0, 0, 0, 0);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void uint3x3_operator_div_scalar_wide()
        {
            uint a0 = (519165704);
            uint3x3 b0 = uint3x3(1295178177, 775214121, 467772046, 1156881598, 310396565, 759759959, 243837702, 1616314235, 1053470225);
            uint3x3 r0 = uint3x3(0, 0, 1, 0, 1, 0, 2, 0, 0);
            TestUtils.AreEqual(a0 / b0, r0);

            uint a1 = (1320630160);
            uint3x3 b1 = uint3x3(378773841, 4223608, 1971105754, 2054406020, 219939614, 1603672651, 2006134295, 888535397, 1493077923);
            uint3x3 r1 = uint3x3(3, 312, 0, 0, 6, 0, 0, 1, 0);
            TestUtils.AreEqual(a1 / b1, r1);

            uint a2 = (615835131);
            uint3x3 b2 = uint3x3(1045603945, 452709946, 1074919059, 467037221, 1485241506, 1775728786, 481521341, 68149923, 80867357);
            uint3x3 r2 = uint3x3(0, 1, 0, 1, 0, 0, 1, 9, 7);
            TestUtils.AreEqual(a2 / b2, r2);

            uint a3 = (1294049272);
            uint3x3 b3 = uint3x3(470535313, 1235850199, 631464286, 687722755, 412827650, 1258012095, 1286792622, 1799223034, 766890491);
            uint3x3 r3 = uint3x3(2, 1, 2, 1, 3, 1, 1, 0, 1);
            TestUtils.AreEqual(a3 / b3, r3);
        }

        [Test]
        public void uint3x3_operator_mod_wide_wide()
        {
            uint3x3 a0 = uint3x3(258342924, 1454754891, 723352342, 1981431473, 531756042, 716993627, 1667903349, 1331097004, 1776856101);
            uint3x3 b0 = uint3x3(1990080167, 1197348066, 651970512, 1659454050, 241005212, 1866255454, 1440101415, 595220963, 408818410);
            uint3x3 r0 = uint3x3(258342924, 257406825, 71381830, 321977423, 49745618, 716993627, 227801934, 140655078, 141582461);
            TestUtils.AreEqual(a0 % b0, r0);

            uint3x3 a1 = uint3x3(17598216, 1474345080, 1681376293, 813624265, 1617478722, 498370451, 780075943, 1754430321, 653235398);
            uint3x3 b1 = uint3x3(198222574, 549504274, 239973807, 321398087, 658171840, 1511495237, 1048325585, 1126739824, 666641241);
            uint3x3 r1 = uint3x3(17598216, 375336532, 1559644, 170828091, 301135042, 498370451, 780075943, 627690497, 653235398);
            TestUtils.AreEqual(a1 % b1, r1);

            uint3x3 a2 = uint3x3(1517128354, 966216200, 590067427, 1283434795, 1910903650, 1125967790, 1180537254, 308567230, 543945394);
            uint3x3 b2 = uint3x3(38017598, 418797691, 618700513, 1941062990, 158556432, 1081063558, 427329468, 148111230, 1251162672);
            uint3x3 r2 = uint3x3(34442032, 128620818, 590067427, 1283434795, 8226466, 44904232, 325878318, 12344770, 543945394);
            TestUtils.AreEqual(a2 % b2, r2);

            uint3x3 a3 = uint3x3(483834400, 308703874, 383723801, 1181975437, 1161083599, 1608412916, 111825133, 786866017, 1225576256);
            uint3x3 b3 = uint3x3(1856322297, 1214781084, 401954255, 1323259633, 1167744452, 1816151689, 541163525, 664455763, 1738838503);
            uint3x3 r3 = uint3x3(483834400, 308703874, 383723801, 1181975437, 1161083599, 1608412916, 111825133, 122410254, 1225576256);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void uint3x3_operator_mod_wide_scalar()
        {
            uint3x3 a0 = uint3x3(560988938, 629524514, 767711194, 434281967, 1399805893, 792916846, 1663690927, 598661916, 1776636144);
            uint b0 = (1156862367);
            uint3x3 r0 = uint3x3(560988938, 629524514, 767711194, 434281967, 242943526, 792916846, 506828560, 598661916, 619773777);
            TestUtils.AreEqual(a0 % b0, r0);

            uint3x3 a1 = uint3x3(1287035793, 475209785, 327476870, 1617696916, 379853074, 477430114, 858399046, 712734431, 1506629323);
            uint b1 = (1743722161);
            uint3x3 r1 = uint3x3(1287035793, 475209785, 327476870, 1617696916, 379853074, 477430114, 858399046, 712734431, 1506629323);
            TestUtils.AreEqual(a1 % b1, r1);

            uint3x3 a2 = uint3x3(199829950, 1986626876, 1351725413, 1549678101, 431765276, 1315833792, 1664893153, 615834034, 780055604);
            uint b2 = (362269020);
            uint3x3 r2 = uint3x3(199829950, 175281776, 264918353, 100602021, 69496256, 229026732, 215817073, 253565014, 55517564);
            TestUtils.AreEqual(a2 % b2, r2);

            uint3x3 a3 = uint3x3(104179235, 1810536428, 1747026206, 1799535061, 875754431, 2049775667, 303673867, 93301056, 1944511005);
            uint b3 = (629966219);
            uint3x3 r3 = uint3x3(104179235, 550603990, 487093768, 539602623, 245788212, 159877010, 303673867, 93301056, 54612348);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void uint3x3_operator_mod_scalar_wide()
        {
            uint a0 = (933347930);
            uint3x3 b0 = uint3x3(549923387, 243114953, 1884274390, 1428033594, 655531454, 1622674954, 1107563514, 1614111094, 914801920);
            uint3x3 r0 = uint3x3(383424543, 204003071, 933347930, 933347930, 277816476, 933347930, 933347930, 933347930, 18546010);
            TestUtils.AreEqual(a0 % b0, r0);

            uint a1 = (1432263179);
            uint3x3 b1 = uint3x3(564431096, 1967013901, 1709750152, 1080102613, 13120773, 2042535998, 1505698002, 1640058084, 974167554);
            uint3x3 r1 = uint3x3(303400987, 1432263179, 1432263179, 352160566, 2098922, 1432263179, 1432263179, 1432263179, 458095625);
            TestUtils.AreEqual(a1 % b1, r1);

            uint a2 = (758635306);
            uint3x3 b2 = uint3x3(1387264978, 611743343, 1139002766, 1913935748, 1086810076, 991846486, 922870408, 35007468, 891877602);
            uint3x3 r2 = uint3x3(758635306, 146891963, 758635306, 758635306, 758635306, 758635306, 758635306, 23478478, 758635306);
            TestUtils.AreEqual(a2 % b2, r2);

            uint a3 = (157349181);
            uint3x3 b3 = uint3x3(83267982, 801093706, 546272767, 1665089132, 1889242068, 1179889796, 1690033703, 1333252321, 1960636489);
            uint3x3 r3 = uint3x3(74081199, 157349181, 157349181, 157349181, 157349181, 157349181, 157349181, 157349181, 157349181);
            TestUtils.AreEqual(a3 % b3, r3);
        }

        [Test]
        public void uint3x3_operator_plus()
        {
            uint3x3 a0 = uint3x3(195392567, 222719748, 1002351013, 1570765263, 109389333, 1515950277, 1689763402, 291471785, 264115671);
            uint3x3 r0 = uint3x3(195392567, 222719748, 1002351013, 1570765263, 109389333, 1515950277, 1689763402, 291471785, 264115671);
            TestUtils.AreEqual(+a0, r0);

            uint3x3 a1 = uint3x3(1084131995, 2131702223, 715660442, 1995564647, 69731564, 1317851903, 1957501908, 531426536, 2012985092);
            uint3x3 r1 = uint3x3(1084131995, 2131702223, 715660442, 1995564647, 69731564, 1317851903, 1957501908, 531426536, 2012985092);
            TestUtils.AreEqual(+a1, r1);

            uint3x3 a2 = uint3x3(1334133318, 935436165, 1575048895, 2119066258, 781435471, 1659000230, 1301861249, 1153431944, 1360657696);
            uint3x3 r2 = uint3x3(1334133318, 935436165, 1575048895, 2119066258, 781435471, 1659000230, 1301861249, 1153431944, 1360657696);
            TestUtils.AreEqual(+a2, r2);

            uint3x3 a3 = uint3x3(578750954, 1791553179, 1288641627, 735146513, 328684789, 1370099515, 1575634098, 36481877, 1832055170);
            uint3x3 r3 = uint3x3(578750954, 1791553179, 1288641627, 735146513, 328684789, 1370099515, 1575634098, 36481877, 1832055170);
            TestUtils.AreEqual(+a3, r3);
        }

        [Test]
        public void uint3x3_operator_neg()
        {
            uint3x3 a0 = uint3x3(1385088677, 94114564, 1350664872, 1458616659, 2067164853, 218122493, 958484951, 270553961, 446497525);
            uint3x3 r0 = uint3x3(2909878619, 4200852732, 2944302424, 2836350637, 2227802443, 4076844803, 3336482345, 4024413335, 3848469771);
            TestUtils.AreEqual(-a0, r0);

            uint3x3 a1 = uint3x3(270503114, 1427605822, 2051940607, 1434247484, 485368391, 908365416, 1742096480, 990033169, 1368056141);
            uint3x3 r1 = uint3x3(4024464182, 2867361474, 2243026689, 2860719812, 3809598905, 3386601880, 2552870816, 3304934127, 2926911155);
            TestUtils.AreEqual(-a1, r1);

            uint3x3 a2 = uint3x3(1350976157, 1934372287, 576597401, 785136322, 559205611, 1959833280, 162379661, 1200036971, 95281343);
            uint3x3 r2 = uint3x3(2943991139, 2360595009, 3718369895, 3509830974, 3735761685, 2335134016, 4132587635, 3094930325, 4199685953);
            TestUtils.AreEqual(-a2, r2);

            uint3x3 a3 = uint3x3(1969004480, 252975075, 1961335692, 1607042487, 832886233, 1300359361, 8438338, 431498011, 1534415387);
            uint3x3 r3 = uint3x3(2325962816, 4041992221, 2333631604, 2687924809, 3462081063, 2994607935, 4286528958, 3863469285, 2760551909);
            TestUtils.AreEqual(-a3, r3);
        }

        [Test]
        public void uint3x3_operator_prefix_inc()
        {
            uint3x3 a0 = uint3x3(780471723, 954741756, 272723451, 2142862245, 606294309, 1514814550, 250124151, 444189162, 1833356994);
            uint3x3 r0 = uint3x3(780471724, 954741757, 272723452, 2142862246, 606294310, 1514814551, 250124152, 444189163, 1833356995);
            TestUtils.AreEqual(++a0, r0);

            uint3x3 a1 = uint3x3(1915989169, 129540735, 1584496757, 1170613526, 986715680, 1701179230, 1397451003, 483952900, 1494652811);
            uint3x3 r1 = uint3x3(1915989170, 129540736, 1584496758, 1170613527, 986715681, 1701179231, 1397451004, 483952901, 1494652812);
            TestUtils.AreEqual(++a1, r1);

            uint3x3 a2 = uint3x3(1268688387, 453850931, 1112537171, 621362788, 2063486914, 1612870531, 1161037742, 1083861484, 1583359796);
            uint3x3 r2 = uint3x3(1268688388, 453850932, 1112537172, 621362789, 2063486915, 1612870532, 1161037743, 1083861485, 1583359797);
            TestUtils.AreEqual(++a2, r2);

            uint3x3 a3 = uint3x3(82587894, 72436569, 1094485773, 912422931, 1011314676, 261771874, 2042016403, 1102472175, 976635804);
            uint3x3 r3 = uint3x3(82587895, 72436570, 1094485774, 912422932, 1011314677, 261771875, 2042016404, 1102472176, 976635805);
            TestUtils.AreEqual(++a3, r3);
        }

        [Test]
        public void uint3x3_operator_postfix_inc()
        {
            uint3x3 a0 = uint3x3(241865086, 2145821641, 1596166022, 803592338, 529551271, 1656767229, 903047443, 1213663244, 1425753247);
            uint3x3 r0 = uint3x3(241865086, 2145821641, 1596166022, 803592338, 529551271, 1656767229, 903047443, 1213663244, 1425753247);
            TestUtils.AreEqual(a0++, r0);

            uint3x3 a1 = uint3x3(1384002775, 1159795446, 1343289659, 1227160199, 947635082, 137930180, 451018043, 1634297552, 2009552507);
            uint3x3 r1 = uint3x3(1384002775, 1159795446, 1343289659, 1227160199, 947635082, 137930180, 451018043, 1634297552, 2009552507);
            TestUtils.AreEqual(a1++, r1);

            uint3x3 a2 = uint3x3(1176922170, 2381860, 2062858295, 715101397, 1725384327, 446867079, 2101314783, 1460883320, 1683365096);
            uint3x3 r2 = uint3x3(1176922170, 2381860, 2062858295, 715101397, 1725384327, 446867079, 2101314783, 1460883320, 1683365096);
            TestUtils.AreEqual(a2++, r2);

            uint3x3 a3 = uint3x3(1319511974, 1938539756, 592683318, 1576213022, 1150548583, 904484472, 253685095, 70826818, 1423673637);
            uint3x3 r3 = uint3x3(1319511974, 1938539756, 592683318, 1576213022, 1150548583, 904484472, 253685095, 70826818, 1423673637);
            TestUtils.AreEqual(a3++, r3);
        }

        [Test]
        public void uint3x3_operator_prefix_dec()
        {
            uint3x3 a0 = uint3x3(1331961415, 1612382200, 1401591249, 2042075388, 1757136546, 1895858159, 1467742422, 578341664, 1336115745);
            uint3x3 r0 = uint3x3(1331961414, 1612382199, 1401591248, 2042075387, 1757136545, 1895858158, 1467742421, 578341663, 1336115744);
            TestUtils.AreEqual(--a0, r0);

            uint3x3 a1 = uint3x3(2059077641, 1862369220, 312317355, 1027543764, 1595492535, 1426262619, 1426620468, 674685792, 1423852012);
            uint3x3 r1 = uint3x3(2059077640, 1862369219, 312317354, 1027543763, 1595492534, 1426262618, 1426620467, 674685791, 1423852011);
            TestUtils.AreEqual(--a1, r1);

            uint3x3 a2 = uint3x3(1459529624, 107501474, 1261583506, 512900840, 1496855314, 777588547, 617644613, 1487639376, 625907330);
            uint3x3 r2 = uint3x3(1459529623, 107501473, 1261583505, 512900839, 1496855313, 777588546, 617644612, 1487639375, 625907329);
            TestUtils.AreEqual(--a2, r2);

            uint3x3 a3 = uint3x3(1452782388, 2076275981, 120447533, 262357170, 1887136873, 412907314, 846648478, 473291493, 286048219);
            uint3x3 r3 = uint3x3(1452782387, 2076275980, 120447532, 262357169, 1887136872, 412907313, 846648477, 473291492, 286048218);
            TestUtils.AreEqual(--a3, r3);
        }

        [Test]
        public void uint3x3_operator_postfix_dec()
        {
            uint3x3 a0 = uint3x3(1870005937, 1708534798, 704493460, 462940703, 2060593573, 228744869, 940247280, 1818778351, 1015253889);
            uint3x3 r0 = uint3x3(1870005937, 1708534798, 704493460, 462940703, 2060593573, 228744869, 940247280, 1818778351, 1015253889);
            TestUtils.AreEqual(a0--, r0);

            uint3x3 a1 = uint3x3(862428933, 2080259851, 653673271, 140452688, 1928164223, 1760916301, 1174531383, 634036198, 993137684);
            uint3x3 r1 = uint3x3(862428933, 2080259851, 653673271, 140452688, 1928164223, 1760916301, 1174531383, 634036198, 993137684);
            TestUtils.AreEqual(a1--, r1);

            uint3x3 a2 = uint3x3(1669210509, 1393579866, 471308632, 620865961, 220103745, 1407678826, 319906934, 1426931482, 488775250);
            uint3x3 r2 = uint3x3(1669210509, 1393579866, 471308632, 620865961, 220103745, 1407678826, 319906934, 1426931482, 488775250);
            TestUtils.AreEqual(a2--, r2);

            uint3x3 a3 = uint3x3(1681733117, 2060905976, 636358505, 1379709480, 451326084, 497925052, 549367303, 925145385, 55306458);
            uint3x3 r3 = uint3x3(1681733117, 2060905976, 636358505, 1379709480, 451326084, 497925052, 549367303, 925145385, 55306458);
            TestUtils.AreEqual(a3--, r3);
        }

        [Test]
        public void uint3x3_operator_bitwise_and_wide_wide()
        {
            uint3x3 a0 = uint3x3(1055241304, 859321394, 1088358961, 2090949513, 300561740, 651904515, 1331035868, 2012752753, 1298126656);
            uint3x3 b0 = uint3x3(749698416, 748105424, 1842764797, 9990577, 1989102105, 1666634755, 58116798, 868036607, 1420638875);
            uint3x3 r0 = uint3x3(749024336, 537928720, 1087769137, 8409473, 277479432, 575816707, 55888540, 867707761, 1141707264);
            TestUtils.AreEqual(a0 & b0, r0);

            uint3x3 a1 = uint3x3(53199569, 1752363533, 1303061302, 1929998247, 1504941434, 470682792, 713577376, 1493231658, 1340884669);
            uint3x3 b1 = uint3x3(1308767169, 564040763, 478617502, 806150474, 674015378, 1505309955, 36064977, 1779639327, 808650076);
            uint3x3 r1 = uint3x3(33686209, 538087433, 209912598, 805855490, 136347666, 403178496, 33571456, 1207967754, 2098204);
            TestUtils.AreEqual(a1 & b1, r1);

            uint3x3 a2 = uint3x3(1577921467, 44846626, 1105094388, 1143008413, 333009589, 2116296009, 2067254825, 121795325, 2122365250);
            uint3x3 b2 = uint3x3(1634437037, 1997568501, 1930853951, 1901503461, 1508772523, 2010961769, 1495957269, 1914669725, 1263994006);
            uint3x3 r2 = uint3x3(1074332585, 33572896, 1091986996, 1073782917, 298320545, 1979979081, 1495420417, 33686173, 1241513986);
            TestUtils.AreEqual(a2 & b2, r2);

            uint3x3 a3 = uint3x3(1088796653, 1594120761, 965590824, 337823363, 1686791432, 1275524729, 173403097, 864715776, 1437598787);
            uint3x3 b3 = uint3x3(491200541, 380703892, 282208487, 1416934135, 942735432, 615839538, 1698880188, 1204102677, 1811173266);
            uint3x3 r3 = uint3x3(4530189, 369102864, 276834336, 337674883, 536870920, 67434032, 4246168, 58721280, 1102054402);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void uint3x3_operator_bitwise_and_wide_scalar()
        {
            uint3x3 a0 = uint3x3(1513158868, 284695609, 734595037, 1566510707, 1601252476, 84213838, 314333543, 430856908, 753481263);
            uint b0 = (1173647397);
            uint3x3 r0 = uint3x3(1076916228, 15732769, 29360133, 1163132961, 1164976164, 84148228, 11816997, 27545604, 81801253);
            TestUtils.AreEqual(a0 & b0, r0);

            uint3x3 a1 = uint3x3(327392481, 2143619546, 1873208293, 126982769, 651482651, 1383096952, 1689107088, 1368301071, 366962092);
            uint b1 = (1619794917);
            uint3x3 r1 = uint3x3(8394977, 1619265984, 1619264485, 8395361, 545526273, 1073742432, 1619794560, 1082923525, 9175460);
            TestUtils.AreEqual(a1 & b1, r1);

            uint3x3 a2 = uint3x3(1729929586, 1914435619, 1592791064, 2047510829, 678485991, 586400261, 771972179, 309059606, 131945492);
            uint b2 = (989550739);
            uint3x3 r2 = uint3x3(571998226, 840652803, 451940368, 973735937, 678451331, 586366977, 704862227, 309018642, 47796240);
            TestUtils.AreEqual(a2 & b2, r2);

            uint3x3 a3 = uint3x3(1707451796, 1943201012, 558008097, 1070093422, 34324916, 258102213, 1800249857, 922911179, 1719705954);
            uint b3 = (394184188);
            uint3x3 r3 = uint3x3(88376724, 324191476, 21136672, 390612076, 34259380, 123879876, 55345152, 386040264, 100696416);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void uint3x3_operator_bitwise_and_scalar_wide()
        {
            uint a0 = (477163326);
            uint3x3 b0 = uint3x3(110453385, 703240362, 2075630560, 1884904031, 1734899436, 947945203, 1664399051, 458879298, 158491426);
            uint3x3 r0 = uint3x3(68182536, 140544042, 405834528, 273697310, 73426476, 402681394, 3188234, 407953666, 141583138);
            TestUtils.AreEqual(a0 & b0, r0);

            uint a1 = (79772356);
            uint3x3 b1 = uint3x3(2054527944, 202228212, 359225061, 639811396, 1821945318, 1821303024, 2030124055, 1985961756, 579780373);
            uint3x3 r1 = uint3x3(4266688, 67174596, 71373508, 67123780, 75507908, 75505856, 79876, 71375364, 8403460);
            TestUtils.AreEqual(a1 & b1, r1);

            uint a2 = (2061831301);
            uint3x3 b2 = uint3x3(1139618293, 1145191868, 1121606282, 1414714065, 688688277, 1508875606, 664318814, 2092766410, 1010043618);
            uint3x3 r2 = uint3x3(1122304133, 1077939332, 1119881344, 1346371713, 671353989, 1491405828, 578813956, 2024080512, 941885568);
            TestUtils.AreEqual(a2 & b2, r2);

            uint a3 = (599967779);
            uint3x3 b3 = uint3x3(47076367, 1325716015, 1119912335, 2083412385, 1805692137, 1689798540, 265665838, 1616867488, 244288538);
            uint3x3 r3 = uint3x3(46284803, 50380835, 46170115, 537020449, 595626017, 545275904, 62949410, 541212704, 42108930);
            TestUtils.AreEqual(a3 & b3, r3);
        }

        [Test]
        public void uint3x3_operator_bitwise_or_wide_wide()
        {
            uint3x3 a0 = uint3x3(1920951869, 1750772852, 1420019191, 732977093, 1169579447, 229437930, 1966721348, 2039812323, 113550869);
            uint3x3 b0 = uint3x3(214585254, 275414367, 858759675, 190211455, 1218691723, 2129565457, 1862809466, 495728846, 868064152);
            uint3x3 r0 = uint3x3(2130669503, 2021326207, 2008016383, 737572863, 1303895999, 2146367483, 2134507390, 2107455727, 939376541);
            TestUtils.AreEqual(a0 | b0, r0);

            uint3x3 a1 = uint3x3(1912038362, 1569990624, 1490718227, 1686257697, 2137727522, 1569900650, 856504729, 2033376384, 2086259889);
            uint3x3 b1 = uint3x3(1756913766, 933656055, 247722084, 1884195075, 1804207631, 1913174711, 1815920856, 1226577606, 1696467642);
            uint3x3 r1 = uint3x3(2046780414, 2142664695, 1591475831, 1959708963, 2146117167, 2140863231, 2134768089, 2034163398, 2103430843);
            TestUtils.AreEqual(a1 | b1, r1);

            uint3x3 a2 = uint3x3(671790684, 1189001916, 1756048437, 417084592, 2024165808, 966008272, 2031026290, 1461019191, 1071959084);
            uint3x3 b2 = uint3x3(186912044, 1778908130, 1461256625, 1142152181, 272117331, 1162254035, 870448102, 1845053992, 257334526);
            uint3x3 r2 = uint3x3(724483964, 1860172798, 2142973365, 1558183925, 2025750515, 2111217619, 2079325174, 2147314239, 1073143038);
            TestUtils.AreEqual(a2 | b2, r2);

            uint3x3 a3 = uint3x3(1645847295, 871350674, 736640317, 868515800, 767794452, 362186994, 96189073, 1924033224, 1971421809);
            uint3x3 b3 = uint3x3(987295814, 1503050768, 1683307763, 1076253109, 1403888383, 561000721, 740143742, 343344681, 2074122472);
            uint3x3 r3 = uint3x3(2061103871, 2080374162, 1878867455, 1944485885, 2146418687, 905361907, 767539967, 1996451561, 2141297401);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void uint3x3_operator_bitwise_or_wide_scalar()
        {
            uint3x3 a0 = uint3x3(1295304853, 1307252624, 350194630, 1128063578, 1774824542, 2085245467, 1988423804, 999162350, 2110327307);
            uint b0 = (1305527136);
            uint3x3 r0 = uint3x3(1307888629, 1308350448, 1574947814, 1341973370, 1842999166, 2111492987, 2144662396, 2145305582, 2111425387);
            TestUtils.AreEqual(a0 | b0, r0);

            uint3x3 a1 = uint3x3(1050875188, 1317039676, 228656898, 41280811, 1536908787, 606786773, 1739461580, 2040936581, 1350320187);
            uint b1 = (341855232);
            uint3x3 r1 = uint3x3(1055087924, 1591766588, 501305090, 376827179, 1610309107, 879418581, 2012110796, 2112257157, 1417432123);
            TestUtils.AreEqual(a1 | b1, r1);

            uint3x3 a2 = uint3x3(1377874553, 1496806239, 1732466858, 1535976093, 375675620, 1614193383, 226059393, 697385997, 112556963);
            uint b2 = (1522262112);
            uint3x3 r2 = uint3x3(1522266745, 1539306367, 2147219690, 1539302141, 1593834212, 2059395815, 1610343649, 2075911277, 1589640163);
            TestUtils.AreEqual(a2 | b2, r2);

            uint3x3 a3 = uint3x3(1614163749, 1370656810, 1286074530, 1155438844, 1835671387, 440002979, 1569359727, 5393691, 774282482);
            uint b3 = (1583289054);
            uint3x3 r3 = uint3x3(2122268671, 1610584830, 1593832190, 1591712510, 2139037663, 1585445887, 1608488959, 1583308767, 2122292990);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void uint3x3_operator_bitwise_or_scalar_wide()
        {
            uint a0 = (1768627592);
            uint3x3 b0 = uint3x3(1849658052, 1759912154, 729979455, 975926310, 1987690876, 1809506714, 1160695341, 408963395, 314072711);
            uint3x3 r0 = uint3x3(1870634956, 1777286618, 1810603967, 2070642094, 2138824188, 1811676570, 1836048301, 2037079499, 2080071567);
            TestUtils.AreEqual(a0 | b0, r0);

            uint a1 = (1560007537);
            uint3x3 b1 = uint3x3(1709003416, 977086639, 1448375596, 1689568808, 595543345, 559778387, 621080913, 438994183, 1742637145);
            uint3x3 r1 = uint3x3(2113917945, 2130705407, 1593833341, 2097141625, 2147473265, 2113919859, 2113926001, 1593562999, 2147474297);
            TestUtils.AreEqual(a1 | b1, r1);

            uint a2 = (1219409263);
            uint3x3 b2 = uint3x3(1602932494, 1204461702, 2111538444, 836730895, 1207638621, 802100209, 1089077339, 1315030334, 249047666);
            uint3x3 r2 = uint3x3(1605304175, 1341044207, 2113910127, 2046801263, 1342160767, 1877981183, 1223603583, 1324348799, 1325318015);
            TestUtils.AreEqual(a2 | b2, r2);

            uint a3 = (1604790897);
            uint3x3 b3 = uint3x3(1848168086, 347254235, 1777613639, 1876731927, 842785732, 1023558747, 1567635900, 1888818835, 1681286114);
            uint3x3 r3 = uint3x3(2142236407, 1605873659, 2146909047, 2147461751, 2143284213, 2141679227, 1610038269, 2142715635, 2142727155);
            TestUtils.AreEqual(a3 | b3, r3);
        }

        [Test]
        public void uint3x3_operator_bitwise_xor_wide_wide()
        {
            uint3x3 a0 = uint3x3(1843655608, 362425681, 640805534, 1342040268, 945678755, 980321850, 390165019, 1682422658, 303897251);
            uint3x3 b0 = uint3x3(1422803441, 1234691140, 119589253, 1101464929, 121896337, 1880109018, 1000210266, 1718938232, 464406940);
            uint3x3 r0 = uint3x3(959296073, 1544407317, 554771227, 240840109, 1058935858, 1249815008, 752651585, 36917754, 162747199);
            TestUtils.AreEqual(a0 ^ b0, r0);

            uint3x3 a1 = uint3x3(230477768, 1103646442, 1503102919, 26631152, 1016475570, 1862440929, 379588576, 1943580404, 691527166);
            uint3x3 b1 = uint3x3(884337881, 34199854, 1430659227, 126415540, 1069919967, 1810763253, 2082802224, 941097951, 27782297);
            uint3x3 r1 = uint3x3(956900113, 1136760772, 215066460, 102672708, 55804269, 82614804, 1787102672, 1270918443, 680538471);
            TestUtils.AreEqual(a1 ^ b1, r1);

            uint3x3 a2 = uint3x3(723280696, 497086939, 1640104913, 893178410, 1596765788, 664096470, 2043360590, 799560121, 287637604);
            uint3x3 b2 = uint3x3(156353074, 607061607, 470737131, 1151564598, 8268481, 434405645, 519003095, 1880915120, 608970922);
            uint3x3 r2 = uint3x3(575512842, 965736380, 2110579514, 1906288924, 1599249565, 1047646171, 1730440857, 1605643529, 896084174);
            TestUtils.AreEqual(a2 ^ b2, r2);

            uint3x3 a3 = uint3x3(696169196, 2067184169, 1208059988, 1250597330, 1386507647, 1889791408, 2084012261, 308683100, 995657536);
            uint3x3 b3 = uint3x3(1809455754, 1079250101, 514389994, 272120301, 1282399149, 1045003273, 1596550715, 1654640361, 147544177);
            uint3x3 r3 = uint3x3(1118087270, 996325020, 1453948862, 1521655871, 516667090, 1323995577, 589229790, 1895428021, 865328945);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void uint3x3_operator_bitwise_xor_wide_scalar()
        {
            uint3x3 a0 = uint3x3(169345668, 176087064, 2084362901, 1663924004, 193851255, 517476661, 905336222, 863800783, 365003873);
            uint b0 = (354464228);
            uint3x3 r0 = uint3x3(523809632, 526275068, 1763470193, 1980614336, 514678419, 200843473, 550954106, 643578923, 14759301);
            TestUtils.AreEqual(a0 ^ b0, r0);

            uint3x3 a1 = uint3x3(835837496, 1464576786, 625604047, 1700827127, 2003392824, 1481813598, 1077374714, 1043379893, 1991576049);
            uint b1 = (954341348);
            uint3x3 r1 = uint3x3(154388956, 1873394934, 497803819, 1568839699, 1334529756, 1622194618, 2027256094, 114467153, 1314332181);
            TestUtils.AreEqual(a1 ^ b1, r1);

            uint3x3 a2 = uint3x3(781860967, 1196907956, 858716109, 858484213, 178843494, 1223183458, 866652388, 1771693181, 1206307664);
            uint b2 = (60088394);
            uint3x3 r2 = uint3x3(755933229, 1153678846, 817502087, 817860031, 154930988, 1266461736, 809300142, 1779237943, 1148332826);
            TestUtils.AreEqual(a2 ^ b2, r2);

            uint3x3 a3 = uint3x3(2037729583, 497725784, 1367278685, 962962860, 906632547, 1570278596, 1744797352, 574677361, 1363709514);
            uint b3 = (1324393116);
            uint3x3 r3 = uint3x3(931523507, 1398412228, 529508033, 2006255408, 2029699071, 325594712, 688905268, 1823491053, 532163798);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void uint3x3_operator_bitwise_xor_scalar_wide()
        {
            uint a0 = (1361775641);
            uint3x3 b0 = uint3x3(1452773578, 459050892, 1986218254, 1689037698, 999278344, 1229114508, 1087843538, 733699740, 106187872);
            uint3x3 r0 = uint3x3(129801427, 1249346453, 659047703, 898082715, 1789184785, 409583765, 301736139, 2056278661, 1467957369);
            TestUtils.AreEqual(a0 ^ b0, r0);

            uint a1 = (1533632738);
            uint3x3 b1 = uint3x3(1107817672, 492506236, 597602329, 1439603382, 1001169118, 1231718216, 1693179077, 1050897427, 1796435561);
            uint3x3 r1 = uint3x3(426677290, 1177709726, 2029506811, 245889620, 1623572540, 302245802, 1065532455, 1707740401, 813305483);
            TestUtils.AreEqual(a1 ^ b1, r1);

            uint a2 = (1100532547);
            uint3x3 b2 = uint3x3(2106589181, 79691722, 851486414, 381749210, 1743618507, 2038827673, 1680906962, 161437943, 171927307);
            uint3x3 r2 = uint3x3(1008153790, 1160197257, 1935175053, 1465502873, 645221000, 941539802, 631787921, 1208456116, 1269279816);
            TestUtils.AreEqual(a2 ^ b2, r2);

            uint a3 = (277703584);
            uint3x3 b3 = uint3x3(1344718195, 1634011177, 28540247, 1205447252, 150341716, 899457210, 1927941858, 1213321665, 1943899052);
            uint3x3 r3 = uint3x3(1084993235, 1911055241, 289281783, 1465172468, 410739700, 621923098, 1650943298, 1490860641, 1666244620);
            TestUtils.AreEqual(a3 ^ b3, r3);
        }

        [Test]
        public void uint3x3_operator_left_shift()
        {
            uint3x3 a0 = uint3x3(1129100049, 829482269, 1571297368, 443753193, 1872142968, 249554593, 892627436, 980302862, 62369727);
            int b0 = (218351941);
            uint3x3 r0 = uint3x3(1771463200, 773628832, 3036875520, 1315200288, 4074000128, 3690779680, 2794274176, 1304920512, 1995831264);
            TestUtils.AreEqual(a0 << b0, r0);

            uint3x3 a1 = uint3x3(849916599, 108441902, 1959056531, 1779118882, 1451674188, 2082026915, 1149883636, 1380536034, 186532735);
            int b1 = (1271350845);
            uint3x3 r1 = uint3x3(3758096384, 3221225472, 1610612736, 1073741824, 2147483648, 1610612736, 2147483648, 1073741824, 3758096384);
            TestUtils.AreEqual(a1 << b1, r1);

            uint3x3 a2 = uint3x3(1487486874, 752067504, 1647167336, 772453640, 456967739, 947384545, 1463252873, 1315516161, 640579158);
            int b2 = (1498738574);
            uint3x3 r2 = uint3x3(1340506112, 3907780608, 1910112256, 2906783744, 831438848, 4231544832, 3722592256, 1270890496, 2643820544);
            TestUtils.AreEqual(a2 << b2, r2);

            uint3x3 a3 = uint3x3(56630178, 2142944517, 565484033, 965161323, 1634169280, 1821547426, 1959741996, 1189216014, 2088913234);
            int b3 = (1650899378);
            uint3x3 r3 = uint3x3(1854406656, 4094951424, 1745092608, 3316383744, 3338665984, 1854406656, 682622976, 4231528448, 625475584);
            TestUtils.AreEqual(a3 << b3, r3);
        }

        [Test]
        public void uint3x3_operator_right_shift()
        {
            uint3x3 a0 = uint3x3(809126085, 908563670, 763568837, 1986717290, 1174507510, 646821842, 1242726074, 390811632, 1521420393);
            int b0 = (994800051);
            uint3x3 r0 = uint3x3(1543, 1732, 1456, 3789, 2240, 1233, 2370, 745, 2901);
            TestUtils.AreEqual(a0 >> b0, r0);

            uint3x3 a1 = uint3x3(1923166649, 400863878, 667378673, 1611921244, 307750782, 479442287, 2014389412, 1673938174, 1075916177);
            int b1 = (102096936);
            uint3x3 r1 = uint3x3(7512369, 1565874, 2606947, 6296567, 1202151, 1872821, 7868708, 6538820, 4202797);
            TestUtils.AreEqual(a1 >> b1, r1);

            uint3x3 a2 = uint3x3(1248577253, 813936577, 848976170, 500930883, 662405800, 126875849, 1103917083, 1199000503, 955487090);
            int b2 = (848199210);
            uint3x3 r2 = uint3x3(1219313, 794859, 829078, 489190, 646880, 123902, 1078044, 1170898, 933092);
            TestUtils.AreEqual(a2 >> b2, r2);

            uint3x3 a3 = uint3x3(1013356510, 185228398, 87452680, 2021602226, 1401766495, 275199908, 664576720, 363706280, 1600231415);
            int b3 = (391605984);
            uint3x3 r3 = uint3x3(1013356510, 185228398, 87452680, 2021602226, 1401766495, 275199908, 664576720, 363706280, 1600231415);
            TestUtils.AreEqual(a3 >> b3, r3);
        }

        [Test]
        public void uint3x3_operator_bitwise_not()
        {
            uint3x3 a0 = uint3x3(111796841, 603562399, 745091931, 853183268, 1110916612, 381888399, 1891338755, 1506860135, 771210628);
            uint3x3 r0 = uint3x3(4183170454, 3691404896, 3549875364, 3441784027, 3184050683, 3913078896, 2403628540, 2788107160, 3523756667);
            TestUtils.AreEqual(~a0, r0);

            uint3x3 a1 = uint3x3(787710759, 96456785, 916013379, 203444882, 1172294211, 1020232736, 683852713, 375158799, 881353367);
            uint3x3 r1 = uint3x3(3507256536, 4198510510, 3378953916, 4091522413, 3122673084, 3274734559, 3611114582, 3919808496, 3413613928);
            TestUtils.AreEqual(~a1, r1);

            uint3x3 a2 = uint3x3(1218471344, 592898220, 443427914, 1385118179, 215320517, 860122767, 1411266016, 1349739899, 686325107);
            uint3x3 r2 = uint3x3(3076495951, 3702069075, 3851539381, 2909849116, 4079646778, 3434844528, 2883701279, 2945227396, 3608642188);
            TestUtils.AreEqual(~a2, r2);

            uint3x3 a3 = uint3x3(829984855, 319233142, 156019905, 1467719681, 1193642973, 957020051, 610113447, 1906177458, 1022824453);
            uint3x3 r3 = uint3x3(3464982440, 3975734153, 4138947390, 2827247614, 3101324322, 3337947244, 3684853848, 2388789837, 3272142842);
            TestUtils.AreEqual(~a3, r3);
        }


    }
}
