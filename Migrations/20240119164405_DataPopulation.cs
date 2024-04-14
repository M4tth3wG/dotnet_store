using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNet_lab_lista_10.Migrations
{
    public partial class DataPopulation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Beverages" },
                    { 2, "Cosmetics" },
                    { 3, "Food" },
                    { 4, "Electronics" }
                });

            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "Id", "CategoryId", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 4, 1, null, "Article_4", 4.0 },
                    { 634, 3, null, "Article_634", 634.0 },
                    { 638, 3, null, "Article_638", 638.0 },
                    { 642, 3, null, "Article_642", 642.0 },
                    { 646, 3, null, "Article_646", 646.0 },
                    { 650, 3, null, "Article_650", 650.0 },
                    { 654, 3, null, "Article_654", 654.0 },
                    { 658, 3, null, "Article_658", 658.0 },
                    { 662, 3, null, "Article_662", 662.0 },
                    { 666, 3, null, "Article_666", 666.0 },
                    { 670, 3, null, "Article_670", 670.0 },
                    { 674, 3, null, "Article_674", 674.0 },
                    { 678, 3, null, "Article_678", 678.0 },
                    { 682, 3, null, "Article_682", 682.0 },
                    { 686, 3, null, "Article_686", 686.0 },
                    { 690, 3, null, "Article_690", 690.0 },
                    { 694, 3, null, "Article_694", 694.0 },
                    { 698, 3, null, "Article_698", 698.0 },
                    { 702, 3, null, "Article_702", 702.0 },
                    { 706, 3, null, "Article_706", 706.0 },
                    { 710, 3, null, "Article_710", 710.0 },
                    { 714, 3, null, "Article_714", 714.0 },
                    { 718, 3, null, "Article_718", 718.0 },
                    { 722, 3, null, "Article_722", 722.0 },
                    { 726, 3, null, "Article_726", 726.0 },
                    { 730, 3, null, "Article_730", 730.0 },
                    { 734, 3, null, "Article_734", 734.0 },
                    { 738, 3, null, "Article_738", 738.0 },
                    { 630, 3, null, "Article_630", 630.0 },
                    { 742, 3, null, "Article_742", 742.0 },
                    { 626, 3, null, "Article_626", 626.0 },
                    { 618, 3, null, "Article_618", 618.0 },
                    { 510, 3, null, "Article_510", 510.0 },
                    { 514, 3, null, "Article_514", 514.0 },
                    { 518, 3, null, "Article_518", 518.0 },
                    { 522, 3, null, "Article_522", 522.0 },
                    { 526, 3, null, "Article_526", 526.0 },
                    { 530, 3, null, "Article_530", 530.0 },
                    { 534, 3, null, "Article_534", 534.0 },
                    { 538, 3, null, "Article_538", 538.0 },
                    { 542, 3, null, "Article_542", 542.0 },
                    { 546, 3, null, "Article_546", 546.0 }
                });

            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "Id", "CategoryId", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 550, 3, null, "Article_550", 550.0 },
                    { 554, 3, null, "Article_554", 554.0 },
                    { 558, 3, null, "Article_558", 558.0 },
                    { 562, 3, null, "Article_562", 562.0 },
                    { 566, 3, null, "Article_566", 566.0 },
                    { 570, 3, null, "Article_570", 570.0 },
                    { 574, 3, null, "Article_574", 574.0 },
                    { 578, 3, null, "Article_578", 578.0 },
                    { 582, 3, null, "Article_582", 582.0 },
                    { 586, 3, null, "Article_586", 586.0 },
                    { 590, 3, null, "Article_590", 590.0 },
                    { 594, 3, null, "Article_594", 594.0 },
                    { 598, 3, null, "Article_598", 598.0 },
                    { 602, 3, null, "Article_602", 602.0 },
                    { 606, 3, null, "Article_606", 606.0 },
                    { 610, 3, null, "Article_610", 610.0 },
                    { 614, 3, null, "Article_614", 614.0 },
                    { 622, 3, null, "Article_622", 622.0 },
                    { 746, 3, null, "Article_746", 746.0 },
                    { 750, 3, null, "Article_750", 750.0 },
                    { 754, 3, null, "Article_754", 754.0 },
                    { 886, 3, null, "Article_886", 886.0 },
                    { 890, 3, null, "Article_890", 890.0 },
                    { 894, 3, null, "Article_894", 894.0 },
                    { 898, 3, null, "Article_898", 898.0 },
                    { 902, 3, null, "Article_902", 902.0 },
                    { 906, 3, null, "Article_906", 906.0 },
                    { 910, 3, null, "Article_910", 910.0 },
                    { 914, 3, null, "Article_914", 914.0 },
                    { 918, 3, null, "Article_918", 918.0 },
                    { 922, 3, null, "Article_922", 922.0 },
                    { 926, 3, null, "Article_926", 926.0 },
                    { 930, 3, null, "Article_930", 930.0 },
                    { 934, 3, null, "Article_934", 934.0 },
                    { 938, 3, null, "Article_938", 938.0 },
                    { 942, 3, null, "Article_942", 942.0 },
                    { 946, 3, null, "Article_946", 946.0 },
                    { 950, 3, null, "Article_950", 950.0 },
                    { 954, 3, null, "Article_954", 954.0 },
                    { 958, 3, null, "Article_958", 958.0 },
                    { 962, 3, null, "Article_962", 962.0 },
                    { 966, 3, null, "Article_966", 966.0 }
                });

            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "Id", "CategoryId", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 970, 3, null, "Article_970", 970.0 },
                    { 974, 3, null, "Article_974", 974.0 },
                    { 978, 3, null, "Article_978", 978.0 },
                    { 982, 3, null, "Article_982", 982.0 },
                    { 986, 3, null, "Article_986", 986.0 },
                    { 990, 3, null, "Article_990", 990.0 },
                    { 882, 3, null, "Article_882", 882.0 },
                    { 878, 3, null, "Article_878", 878.0 },
                    { 874, 3, null, "Article_874", 874.0 },
                    { 870, 3, null, "Article_870", 870.0 },
                    { 758, 3, null, "Article_758", 758.0 },
                    { 762, 3, null, "Article_762", 762.0 },
                    { 766, 3, null, "Article_766", 766.0 },
                    { 770, 3, null, "Article_770", 770.0 },
                    { 774, 3, null, "Article_774", 774.0 },
                    { 778, 3, null, "Article_778", 778.0 },
                    { 782, 3, null, "Article_782", 782.0 },
                    { 786, 3, null, "Article_786", 786.0 },
                    { 790, 3, null, "Article_790", 790.0 },
                    { 794, 3, null, "Article_794", 794.0 },
                    { 798, 3, null, "Article_798", 798.0 },
                    { 802, 3, null, "Article_802", 802.0 },
                    { 806, 3, null, "Article_806", 806.0 },
                    { 506, 3, null, "Article_506", 506.0 },
                    { 810, 3, null, "Article_810", 810.0 },
                    { 818, 3, null, "Article_818", 818.0 },
                    { 822, 3, null, "Article_822", 822.0 },
                    { 826, 3, null, "Article_826", 826.0 },
                    { 830, 3, null, "Article_830", 830.0 },
                    { 834, 3, null, "Article_834", 834.0 },
                    { 838, 3, null, "Article_838", 838.0 },
                    { 842, 3, null, "Article_842", 842.0 },
                    { 846, 3, null, "Article_846", 846.0 },
                    { 850, 3, null, "Article_850", 850.0 },
                    { 854, 3, null, "Article_854", 854.0 },
                    { 858, 3, null, "Article_858", 858.0 },
                    { 862, 3, null, "Article_862", 862.0 },
                    { 866, 3, null, "Article_866", 866.0 },
                    { 814, 3, null, "Article_814", 814.0 },
                    { 994, 3, null, "Article_994", 994.0 },
                    { 502, 3, null, "Article_502", 502.0 },
                    { 494, 3, null, "Article_494", 494.0 }
                });

            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "Id", "CategoryId", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 134, 3, null, "Article_134", 134.0 },
                    { 138, 3, null, "Article_138", 138.0 },
                    { 142, 3, null, "Article_142", 142.0 },
                    { 146, 3, null, "Article_146", 146.0 },
                    { 150, 3, null, "Article_150", 150.0 },
                    { 154, 3, null, "Article_154", 154.0 },
                    { 158, 3, null, "Article_158", 158.0 },
                    { 162, 3, null, "Article_162", 162.0 },
                    { 166, 3, null, "Article_166", 166.0 },
                    { 170, 3, null, "Article_170", 170.0 },
                    { 174, 3, null, "Article_174", 174.0 },
                    { 178, 3, null, "Article_178", 178.0 },
                    { 182, 3, null, "Article_182", 182.0 },
                    { 186, 3, null, "Article_186", 186.0 },
                    { 190, 3, null, "Article_190", 190.0 },
                    { 194, 3, null, "Article_194", 194.0 },
                    { 198, 3, null, "Article_198", 198.0 },
                    { 202, 3, null, "Article_202", 202.0 },
                    { 206, 3, null, "Article_206", 206.0 },
                    { 210, 3, null, "Article_210", 210.0 },
                    { 214, 3, null, "Article_214", 214.0 },
                    { 218, 3, null, "Article_218", 218.0 },
                    { 222, 3, null, "Article_222", 222.0 },
                    { 226, 3, null, "Article_226", 226.0 },
                    { 230, 3, null, "Article_230", 230.0 },
                    { 234, 3, null, "Article_234", 234.0 },
                    { 238, 3, null, "Article_238", 238.0 },
                    { 130, 3, null, "Article_130", 130.0 },
                    { 242, 3, null, "Article_242", 242.0 },
                    { 126, 3, null, "Article_126", 126.0 },
                    { 118, 3, null, "Article_118", 118.0 },
                    { 10, 3, null, "Article_10", 10.0 },
                    { 14, 3, null, "Article_14", 14.0 },
                    { 18, 3, null, "Article_18", 18.0 },
                    { 22, 3, null, "Article_22", 22.0 },
                    { 26, 3, null, "Article_26", 26.0 },
                    { 30, 3, null, "Article_30", 30.0 },
                    { 34, 3, null, "Article_34", 34.0 },
                    { 38, 3, null, "Article_38", 38.0 },
                    { 42, 3, null, "Article_42", 42.0 },
                    { 46, 3, null, "Article_46", 46.0 },
                    { 50, 3, null, "Article_50", 50.0 }
                });

            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "Id", "CategoryId", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 54, 3, null, "Article_54", 54.0 },
                    { 58, 3, null, "Article_58", 58.0 },
                    { 62, 3, null, "Article_62", 62.0 },
                    { 66, 3, null, "Article_66", 66.0 },
                    { 70, 3, null, "Article_70", 70.0 },
                    { 74, 3, null, "Article_74", 74.0 },
                    { 78, 3, null, "Article_78", 78.0 },
                    { 82, 3, null, "Article_82", 82.0 },
                    { 86, 3, null, "Article_86", 86.0 },
                    { 90, 3, null, "Article_90", 90.0 },
                    { 94, 3, null, "Article_94", 94.0 },
                    { 98, 3, null, "Article_98", 98.0 },
                    { 102, 3, null, "Article_102", 102.0 },
                    { 106, 3, null, "Article_106", 106.0 },
                    { 110, 3, null, "Article_110", 110.0 },
                    { 114, 3, null, "Article_114", 114.0 },
                    { 122, 3, null, "Article_122", 122.0 },
                    { 246, 3, null, "Article_246", 246.0 },
                    { 250, 3, null, "Article_250", 250.0 },
                    { 254, 3, null, "Article_254", 254.0 },
                    { 386, 3, null, "Article_386", 386.0 },
                    { 390, 3, null, "Article_390", 390.0 },
                    { 394, 3, null, "Article_394", 394.0 },
                    { 398, 3, null, "Article_398", 398.0 },
                    { 402, 3, null, "Article_402", 402.0 },
                    { 406, 3, null, "Article_406", 406.0 },
                    { 410, 3, null, "Article_410", 410.0 },
                    { 414, 3, null, "Article_414", 414.0 },
                    { 418, 3, null, "Article_418", 418.0 },
                    { 422, 3, null, "Article_422", 422.0 },
                    { 426, 3, null, "Article_426", 426.0 },
                    { 430, 3, null, "Article_430", 430.0 },
                    { 434, 3, null, "Article_434", 434.0 },
                    { 438, 3, null, "Article_438", 438.0 },
                    { 442, 3, null, "Article_442", 442.0 },
                    { 446, 3, null, "Article_446", 446.0 },
                    { 450, 3, null, "Article_450", 450.0 },
                    { 454, 3, null, "Article_454", 454.0 },
                    { 458, 3, null, "Article_458", 458.0 },
                    { 462, 3, null, "Article_462", 462.0 },
                    { 466, 3, null, "Article_466", 466.0 },
                    { 470, 3, null, "Article_470", 470.0 }
                });

            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "Id", "CategoryId", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 474, 3, null, "Article_474", 474.0 },
                    { 478, 3, null, "Article_478", 478.0 },
                    { 482, 3, null, "Article_482", 482.0 },
                    { 486, 3, null, "Article_486", 486.0 },
                    { 490, 3, null, "Article_490", 490.0 },
                    { 382, 3, null, "Article_382", 382.0 },
                    { 378, 3, null, "Article_378", 378.0 },
                    { 374, 3, null, "Article_374", 374.0 },
                    { 370, 3, null, "Article_370", 370.0 },
                    { 258, 3, null, "Article_258", 258.0 },
                    { 262, 3, null, "Article_262", 262.0 },
                    { 266, 3, null, "Article_266", 266.0 },
                    { 270, 3, null, "Article_270", 270.0 },
                    { 274, 3, null, "Article_274", 274.0 },
                    { 278, 3, null, "Article_278", 278.0 },
                    { 282, 3, null, "Article_282", 282.0 },
                    { 286, 3, null, "Article_286", 286.0 },
                    { 290, 3, null, "Article_290", 290.0 },
                    { 294, 3, null, "Article_294", 294.0 },
                    { 298, 3, null, "Article_298", 298.0 },
                    { 302, 3, null, "Article_302", 302.0 },
                    { 306, 3, null, "Article_306", 306.0 },
                    { 498, 3, null, "Article_498", 498.0 },
                    { 310, 3, null, "Article_310", 310.0 },
                    { 318, 3, null, "Article_318", 318.0 },
                    { 322, 3, null, "Article_322", 322.0 },
                    { 326, 3, null, "Article_326", 326.0 },
                    { 330, 3, null, "Article_330", 330.0 },
                    { 334, 3, null, "Article_334", 334.0 },
                    { 338, 3, null, "Article_338", 338.0 },
                    { 342, 3, null, "Article_342", 342.0 },
                    { 346, 3, null, "Article_346", 346.0 },
                    { 350, 3, null, "Article_350", 350.0 },
                    { 354, 3, null, "Article_354", 354.0 },
                    { 358, 3, null, "Article_358", 358.0 },
                    { 362, 3, null, "Article_362", 362.0 },
                    { 366, 3, null, "Article_366", 366.0 },
                    { 314, 3, null, "Article_314", 314.0 },
                    { 6, 3, null, "Article_6", 6.0 },
                    { 998, 3, null, "Article_998", 998.0 },
                    { 7, 4, null, "Article_7", 7.0 },
                    { 635, 4, null, "Article_635", 635.0 }
                });

            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "Id", "CategoryId", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 639, 4, null, "Article_639", 639.0 },
                    { 643, 4, null, "Article_643", 643.0 },
                    { 647, 4, null, "Article_647", 647.0 },
                    { 651, 4, null, "Article_651", 651.0 },
                    { 655, 4, null, "Article_655", 655.0 },
                    { 659, 4, null, "Article_659", 659.0 },
                    { 663, 4, null, "Article_663", 663.0 },
                    { 667, 4, null, "Article_667", 667.0 },
                    { 671, 4, null, "Article_671", 671.0 },
                    { 675, 4, null, "Article_675", 675.0 },
                    { 679, 4, null, "Article_679", 679.0 },
                    { 683, 4, null, "Article_683", 683.0 },
                    { 687, 4, null, "Article_687", 687.0 },
                    { 691, 4, null, "Article_691", 691.0 },
                    { 695, 4, null, "Article_695", 695.0 },
                    { 699, 4, null, "Article_699", 699.0 },
                    { 703, 4, null, "Article_703", 703.0 },
                    { 707, 4, null, "Article_707", 707.0 },
                    { 711, 4, null, "Article_711", 711.0 },
                    { 715, 4, null, "Article_715", 715.0 },
                    { 719, 4, null, "Article_719", 719.0 },
                    { 723, 4, null, "Article_723", 723.0 },
                    { 727, 4, null, "Article_727", 727.0 },
                    { 731, 4, null, "Article_731", 731.0 },
                    { 735, 4, null, "Article_735", 735.0 },
                    { 739, 4, null, "Article_739", 739.0 },
                    { 631, 4, null, "Article_631", 631.0 },
                    { 743, 4, null, "Article_743", 743.0 },
                    { 627, 4, null, "Article_627", 627.0 },
                    { 619, 4, null, "Article_619", 619.0 },
                    { 511, 4, null, "Article_511", 511.0 },
                    { 515, 4, null, "Article_515", 515.0 },
                    { 519, 4, null, "Article_519", 519.0 },
                    { 523, 4, null, "Article_523", 523.0 },
                    { 527, 4, null, "Article_527", 527.0 },
                    { 531, 4, null, "Article_531", 531.0 },
                    { 535, 4, null, "Article_535", 535.0 },
                    { 539, 4, null, "Article_539", 539.0 },
                    { 543, 4, null, "Article_543", 543.0 },
                    { 547, 4, null, "Article_547", 547.0 },
                    { 551, 4, null, "Article_551", 551.0 },
                    { 555, 4, null, "Article_555", 555.0 }
                });

            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "Id", "CategoryId", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 559, 4, null, "Article_559", 559.0 },
                    { 563, 4, null, "Article_563", 563.0 },
                    { 567, 4, null, "Article_567", 567.0 },
                    { 571, 4, null, "Article_571", 571.0 },
                    { 575, 4, null, "Article_575", 575.0 },
                    { 579, 4, null, "Article_579", 579.0 },
                    { 583, 4, null, "Article_583", 583.0 },
                    { 587, 4, null, "Article_587", 587.0 },
                    { 591, 4, null, "Article_591", 591.0 },
                    { 595, 4, null, "Article_595", 595.0 },
                    { 599, 4, null, "Article_599", 599.0 },
                    { 603, 4, null, "Article_603", 603.0 },
                    { 607, 4, null, "Article_607", 607.0 },
                    { 611, 4, null, "Article_611", 611.0 },
                    { 615, 4, null, "Article_615", 615.0 },
                    { 623, 4, null, "Article_623", 623.0 },
                    { 747, 4, null, "Article_747", 747.0 },
                    { 751, 4, null, "Article_751", 751.0 },
                    { 755, 4, null, "Article_755", 755.0 },
                    { 887, 4, null, "Article_887", 887.0 },
                    { 891, 4, null, "Article_891", 891.0 },
                    { 895, 4, null, "Article_895", 895.0 },
                    { 899, 4, null, "Article_899", 899.0 },
                    { 903, 4, null, "Article_903", 903.0 },
                    { 907, 4, null, "Article_907", 907.0 },
                    { 911, 4, null, "Article_911", 911.0 },
                    { 915, 4, null, "Article_915", 915.0 },
                    { 919, 4, null, "Article_919", 919.0 },
                    { 923, 4, null, "Article_923", 923.0 },
                    { 927, 4, null, "Article_927", 927.0 },
                    { 931, 4, null, "Article_931", 931.0 },
                    { 935, 4, null, "Article_935", 935.0 },
                    { 939, 4, null, "Article_939", 939.0 },
                    { 943, 4, null, "Article_943", 943.0 },
                    { 947, 4, null, "Article_947", 947.0 },
                    { 951, 4, null, "Article_951", 951.0 },
                    { 955, 4, null, "Article_955", 955.0 },
                    { 959, 4, null, "Article_959", 959.0 },
                    { 963, 4, null, "Article_963", 963.0 },
                    { 967, 4, null, "Article_967", 967.0 },
                    { 971, 4, null, "Article_971", 971.0 },
                    { 975, 4, null, "Article_975", 975.0 }
                });

            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "Id", "CategoryId", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 979, 4, null, "Article_979", 979.0 },
                    { 983, 4, null, "Article_983", 983.0 },
                    { 987, 4, null, "Article_987", 987.0 },
                    { 991, 4, null, "Article_991", 991.0 },
                    { 883, 4, null, "Article_883", 883.0 },
                    { 879, 4, null, "Article_879", 879.0 },
                    { 875, 4, null, "Article_875", 875.0 },
                    { 871, 4, null, "Article_871", 871.0 },
                    { 759, 4, null, "Article_759", 759.0 },
                    { 763, 4, null, "Article_763", 763.0 },
                    { 767, 4, null, "Article_767", 767.0 },
                    { 771, 4, null, "Article_771", 771.0 },
                    { 775, 4, null, "Article_775", 775.0 },
                    { 779, 4, null, "Article_779", 779.0 },
                    { 783, 4, null, "Article_783", 783.0 },
                    { 787, 4, null, "Article_787", 787.0 },
                    { 791, 4, null, "Article_791", 791.0 },
                    { 795, 4, null, "Article_795", 795.0 },
                    { 799, 4, null, "Article_799", 799.0 },
                    { 803, 4, null, "Article_803", 803.0 },
                    { 807, 4, null, "Article_807", 807.0 },
                    { 507, 4, null, "Article_507", 507.0 },
                    { 811, 4, null, "Article_811", 811.0 },
                    { 819, 4, null, "Article_819", 819.0 },
                    { 823, 4, null, "Article_823", 823.0 },
                    { 827, 4, null, "Article_827", 827.0 },
                    { 831, 4, null, "Article_831", 831.0 },
                    { 835, 4, null, "Article_835", 835.0 },
                    { 839, 4, null, "Article_839", 839.0 },
                    { 843, 4, null, "Article_843", 843.0 },
                    { 847, 4, null, "Article_847", 847.0 },
                    { 851, 4, null, "Article_851", 851.0 },
                    { 855, 4, null, "Article_855", 855.0 },
                    { 859, 4, null, "Article_859", 859.0 },
                    { 863, 4, null, "Article_863", 863.0 },
                    { 867, 4, null, "Article_867", 867.0 },
                    { 815, 4, null, "Article_815", 815.0 },
                    { 3, 4, null, "Article_3", 3.0 },
                    { 503, 4, null, "Article_503", 503.0 },
                    { 495, 4, null, "Article_495", 495.0 },
                    { 135, 4, null, "Article_135", 135.0 },
                    { 139, 4, null, "Article_139", 139.0 }
                });

            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "Id", "CategoryId", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 143, 4, null, "Article_143", 143.0 },
                    { 147, 4, null, "Article_147", 147.0 },
                    { 151, 4, null, "Article_151", 151.0 },
                    { 155, 4, null, "Article_155", 155.0 },
                    { 159, 4, null, "Article_159", 159.0 },
                    { 163, 4, null, "Article_163", 163.0 },
                    { 167, 4, null, "Article_167", 167.0 },
                    { 171, 4, null, "Article_171", 171.0 },
                    { 175, 4, null, "Article_175", 175.0 },
                    { 179, 4, null, "Article_179", 179.0 },
                    { 183, 4, null, "Article_183", 183.0 },
                    { 187, 4, null, "Article_187", 187.0 },
                    { 191, 4, null, "Article_191", 191.0 },
                    { 195, 4, null, "Article_195", 195.0 },
                    { 199, 4, null, "Article_199", 199.0 },
                    { 203, 4, null, "Article_203", 203.0 },
                    { 207, 4, null, "Article_207", 207.0 },
                    { 211, 4, null, "Article_211", 211.0 },
                    { 215, 4, null, "Article_215", 215.0 },
                    { 219, 4, null, "Article_219", 219.0 },
                    { 223, 4, null, "Article_223", 223.0 },
                    { 227, 4, null, "Article_227", 227.0 },
                    { 231, 4, null, "Article_231", 231.0 },
                    { 235, 4, null, "Article_235", 235.0 },
                    { 239, 4, null, "Article_239", 239.0 },
                    { 131, 4, null, "Article_131", 131.0 },
                    { 243, 4, null, "Article_243", 243.0 },
                    { 127, 4, null, "Article_127", 127.0 },
                    { 119, 4, null, "Article_119", 119.0 },
                    { 11, 4, null, "Article_11", 11.0 },
                    { 15, 4, null, "Article_15", 15.0 },
                    { 19, 4, null, "Article_19", 19.0 },
                    { 23, 4, null, "Article_23", 23.0 },
                    { 27, 4, null, "Article_27", 27.0 },
                    { 31, 4, null, "Article_31", 31.0 },
                    { 35, 4, null, "Article_35", 35.0 },
                    { 39, 4, null, "Article_39", 39.0 },
                    { 43, 4, null, "Article_43", 43.0 },
                    { 47, 4, null, "Article_47", 47.0 },
                    { 51, 4, null, "Article_51", 51.0 },
                    { 55, 4, null, "Article_55", 55.0 },
                    { 59, 4, null, "Article_59", 59.0 }
                });

            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "Id", "CategoryId", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 63, 4, null, "Article_63", 63.0 },
                    { 67, 4, null, "Article_67", 67.0 },
                    { 71, 4, null, "Article_71", 71.0 },
                    { 75, 4, null, "Article_75", 75.0 },
                    { 79, 4, null, "Article_79", 79.0 },
                    { 83, 4, null, "Article_83", 83.0 },
                    { 87, 4, null, "Article_87", 87.0 },
                    { 91, 4, null, "Article_91", 91.0 },
                    { 95, 4, null, "Article_95", 95.0 },
                    { 99, 4, null, "Article_99", 99.0 },
                    { 103, 4, null, "Article_103", 103.0 },
                    { 107, 4, null, "Article_107", 107.0 },
                    { 111, 4, null, "Article_111", 111.0 },
                    { 115, 4, null, "Article_115", 115.0 },
                    { 123, 4, null, "Article_123", 123.0 },
                    { 247, 4, null, "Article_247", 247.0 },
                    { 251, 4, null, "Article_251", 251.0 },
                    { 255, 4, null, "Article_255", 255.0 },
                    { 387, 4, null, "Article_387", 387.0 },
                    { 391, 4, null, "Article_391", 391.0 },
                    { 395, 4, null, "Article_395", 395.0 },
                    { 399, 4, null, "Article_399", 399.0 },
                    { 403, 4, null, "Article_403", 403.0 },
                    { 407, 4, null, "Article_407", 407.0 },
                    { 411, 4, null, "Article_411", 411.0 },
                    { 415, 4, null, "Article_415", 415.0 },
                    { 419, 4, null, "Article_419", 419.0 },
                    { 423, 4, null, "Article_423", 423.0 },
                    { 427, 4, null, "Article_427", 427.0 },
                    { 431, 4, null, "Article_431", 431.0 },
                    { 435, 4, null, "Article_435", 435.0 },
                    { 439, 4, null, "Article_439", 439.0 },
                    { 443, 4, null, "Article_443", 443.0 },
                    { 447, 4, null, "Article_447", 447.0 },
                    { 451, 4, null, "Article_451", 451.0 },
                    { 455, 4, null, "Article_455", 455.0 },
                    { 459, 4, null, "Article_459", 459.0 },
                    { 463, 4, null, "Article_463", 463.0 },
                    { 467, 4, null, "Article_467", 467.0 },
                    { 471, 4, null, "Article_471", 471.0 },
                    { 475, 4, null, "Article_475", 475.0 },
                    { 479, 4, null, "Article_479", 479.0 }
                });

            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "Id", "CategoryId", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 483, 4, null, "Article_483", 483.0 },
                    { 487, 4, null, "Article_487", 487.0 },
                    { 491, 4, null, "Article_491", 491.0 },
                    { 383, 4, null, "Article_383", 383.0 },
                    { 379, 4, null, "Article_379", 379.0 },
                    { 375, 4, null, "Article_375", 375.0 },
                    { 371, 4, null, "Article_371", 371.0 },
                    { 259, 4, null, "Article_259", 259.0 },
                    { 263, 4, null, "Article_263", 263.0 },
                    { 267, 4, null, "Article_267", 267.0 },
                    { 271, 4, null, "Article_271", 271.0 },
                    { 275, 4, null, "Article_275", 275.0 },
                    { 279, 4, null, "Article_279", 279.0 },
                    { 283, 4, null, "Article_283", 283.0 },
                    { 287, 4, null, "Article_287", 287.0 },
                    { 291, 4, null, "Article_291", 291.0 },
                    { 295, 4, null, "Article_295", 295.0 },
                    { 299, 4, null, "Article_299", 299.0 },
                    { 303, 4, null, "Article_303", 303.0 },
                    { 307, 4, null, "Article_307", 307.0 },
                    { 499, 4, null, "Article_499", 499.0 },
                    { 311, 4, null, "Article_311", 311.0 },
                    { 319, 4, null, "Article_319", 319.0 },
                    { 323, 4, null, "Article_323", 323.0 },
                    { 327, 4, null, "Article_327", 327.0 },
                    { 331, 4, null, "Article_331", 331.0 },
                    { 335, 4, null, "Article_335", 335.0 },
                    { 339, 4, null, "Article_339", 339.0 },
                    { 343, 4, null, "Article_343", 343.0 },
                    { 347, 4, null, "Article_347", 347.0 },
                    { 351, 4, null, "Article_351", 351.0 },
                    { 355, 4, null, "Article_355", 355.0 },
                    { 359, 4, null, "Article_359", 359.0 },
                    { 363, 4, null, "Article_363", 363.0 },
                    { 367, 4, null, "Article_367", 367.0 },
                    { 315, 4, null, "Article_315", 315.0 },
                    { 2, 3, null, "Article_2", 2.0 },
                    { 997, 2, null, "Article_997", 997.0 },
                    { 993, 2, null, "Article_993", 993.0 },
                    { 632, 1, null, "Article_632", 632.0 },
                    { 636, 1, null, "Article_636", 636.0 },
                    { 640, 1, null, "Article_640", 640.0 }
                });

            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "Id", "CategoryId", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 644, 1, null, "Article_644", 644.0 },
                    { 648, 1, null, "Article_648", 648.0 },
                    { 652, 1, null, "Article_652", 652.0 },
                    { 656, 1, null, "Article_656", 656.0 },
                    { 660, 1, null, "Article_660", 660.0 },
                    { 664, 1, null, "Article_664", 664.0 },
                    { 668, 1, null, "Article_668", 668.0 },
                    { 672, 1, null, "Article_672", 672.0 },
                    { 676, 1, null, "Article_676", 676.0 },
                    { 680, 1, null, "Article_680", 680.0 },
                    { 684, 1, null, "Article_684", 684.0 },
                    { 688, 1, null, "Article_688", 688.0 },
                    { 692, 1, null, "Article_692", 692.0 },
                    { 696, 1, null, "Article_696", 696.0 },
                    { 700, 1, null, "Article_700", 700.0 },
                    { 704, 1, null, "Article_704", 704.0 },
                    { 708, 1, null, "Article_708", 708.0 },
                    { 712, 1, null, "Article_712", 712.0 },
                    { 716, 1, null, "Article_716", 716.0 },
                    { 720, 1, null, "Article_720", 720.0 },
                    { 724, 1, null, "Article_724", 724.0 },
                    { 728, 1, null, "Article_728", 728.0 },
                    { 732, 1, null, "Article_732", 732.0 },
                    { 736, 1, null, "Article_736", 736.0 },
                    { 628, 1, null, "Article_628", 628.0 },
                    { 740, 1, null, "Article_740", 740.0 },
                    { 624, 1, null, "Article_624", 624.0 },
                    { 616, 1, null, "Article_616", 616.0 },
                    { 508, 1, null, "Article_508", 508.0 },
                    { 512, 1, null, "Article_512", 512.0 },
                    { 516, 1, null, "Article_516", 516.0 },
                    { 520, 1, null, "Article_520", 520.0 },
                    { 524, 1, null, "Article_524", 524.0 },
                    { 528, 1, null, "Article_528", 528.0 },
                    { 532, 1, null, "Article_532", 532.0 },
                    { 536, 1, null, "Article_536", 536.0 },
                    { 540, 1, null, "Article_540", 540.0 },
                    { 544, 1, null, "Article_544", 544.0 },
                    { 548, 1, null, "Article_548", 548.0 },
                    { 552, 1, null, "Article_552", 552.0 },
                    { 556, 1, null, "Article_556", 556.0 },
                    { 560, 1, null, "Article_560", 560.0 }
                });

            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "Id", "CategoryId", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 564, 1, null, "Article_564", 564.0 },
                    { 568, 1, null, "Article_568", 568.0 },
                    { 572, 1, null, "Article_572", 572.0 },
                    { 576, 1, null, "Article_576", 576.0 },
                    { 580, 1, null, "Article_580", 580.0 },
                    { 584, 1, null, "Article_584", 584.0 },
                    { 588, 1, null, "Article_588", 588.0 },
                    { 592, 1, null, "Article_592", 592.0 },
                    { 596, 1, null, "Article_596", 596.0 },
                    { 600, 1, null, "Article_600", 600.0 },
                    { 604, 1, null, "Article_604", 604.0 },
                    { 608, 1, null, "Article_608", 608.0 },
                    { 612, 1, null, "Article_612", 612.0 },
                    { 620, 1, null, "Article_620", 620.0 },
                    { 744, 1, null, "Article_744", 744.0 },
                    { 748, 1, null, "Article_748", 748.0 },
                    { 752, 1, null, "Article_752", 752.0 },
                    { 884, 1, null, "Article_884", 884.0 },
                    { 888, 1, null, "Article_888", 888.0 },
                    { 892, 1, null, "Article_892", 892.0 },
                    { 896, 1, null, "Article_896", 896.0 },
                    { 900, 1, null, "Article_900", 900.0 },
                    { 904, 1, null, "Article_904", 904.0 },
                    { 908, 1, null, "Article_908", 908.0 },
                    { 912, 1, null, "Article_912", 912.0 },
                    { 916, 1, null, "Article_916", 916.0 },
                    { 920, 1, null, "Article_920", 920.0 },
                    { 924, 1, null, "Article_924", 924.0 },
                    { 928, 1, null, "Article_928", 928.0 },
                    { 932, 1, null, "Article_932", 932.0 },
                    { 936, 1, null, "Article_936", 936.0 },
                    { 940, 1, null, "Article_940", 940.0 },
                    { 944, 1, null, "Article_944", 944.0 },
                    { 948, 1, null, "Article_948", 948.0 },
                    { 952, 1, null, "Article_952", 952.0 },
                    { 956, 1, null, "Article_956", 956.0 },
                    { 960, 1, null, "Article_960", 960.0 },
                    { 964, 1, null, "Article_964", 964.0 },
                    { 968, 1, null, "Article_968", 968.0 },
                    { 972, 1, null, "Article_972", 972.0 },
                    { 976, 1, null, "Article_976", 976.0 },
                    { 980, 1, null, "Article_980", 980.0 }
                });

            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "Id", "CategoryId", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 984, 1, null, "Article_984", 984.0 },
                    { 988, 1, null, "Article_988", 988.0 },
                    { 880, 1, null, "Article_880", 880.0 },
                    { 876, 1, null, "Article_876", 876.0 },
                    { 872, 1, null, "Article_872", 872.0 },
                    { 868, 1, null, "Article_868", 868.0 },
                    { 756, 1, null, "Article_756", 756.0 },
                    { 760, 1, null, "Article_760", 760.0 },
                    { 764, 1, null, "Article_764", 764.0 },
                    { 768, 1, null, "Article_768", 768.0 },
                    { 772, 1, null, "Article_772", 772.0 },
                    { 776, 1, null, "Article_776", 776.0 },
                    { 780, 1, null, "Article_780", 780.0 },
                    { 784, 1, null, "Article_784", 784.0 },
                    { 788, 1, null, "Article_788", 788.0 },
                    { 792, 1, null, "Article_792", 792.0 },
                    { 796, 1, null, "Article_796", 796.0 },
                    { 800, 1, null, "Article_800", 800.0 },
                    { 804, 1, null, "Article_804", 804.0 },
                    { 504, 1, null, "Article_504", 504.0 },
                    { 808, 1, null, "Article_808", 808.0 },
                    { 816, 1, null, "Article_816", 816.0 },
                    { 820, 1, null, "Article_820", 820.0 },
                    { 824, 1, null, "Article_824", 824.0 },
                    { 828, 1, null, "Article_828", 828.0 },
                    { 832, 1, null, "Article_832", 832.0 },
                    { 836, 1, null, "Article_836", 836.0 },
                    { 840, 1, null, "Article_840", 840.0 },
                    { 844, 1, null, "Article_844", 844.0 },
                    { 848, 1, null, "Article_848", 848.0 },
                    { 852, 1, null, "Article_852", 852.0 },
                    { 856, 1, null, "Article_856", 856.0 },
                    { 860, 1, null, "Article_860", 860.0 },
                    { 864, 1, null, "Article_864", 864.0 },
                    { 812, 1, null, "Article_812", 812.0 },
                    { 992, 1, null, "Article_992", 992.0 },
                    { 500, 1, null, "Article_500", 500.0 },
                    { 492, 1, null, "Article_492", 492.0 },
                    { 132, 1, null, "Article_132", 132.0 },
                    { 136, 1, null, "Article_136", 136.0 },
                    { 140, 1, null, "Article_140", 140.0 },
                    { 144, 1, null, "Article_144", 144.0 }
                });

            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "Id", "CategoryId", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 148, 1, null, "Article_148", 148.0 },
                    { 152, 1, null, "Article_152", 152.0 },
                    { 156, 1, null, "Article_156", 156.0 },
                    { 160, 1, null, "Article_160", 160.0 },
                    { 164, 1, null, "Article_164", 164.0 },
                    { 168, 1, null, "Article_168", 168.0 },
                    { 172, 1, null, "Article_172", 172.0 },
                    { 176, 1, null, "Article_176", 176.0 },
                    { 180, 1, null, "Article_180", 180.0 },
                    { 184, 1, null, "Article_184", 184.0 },
                    { 188, 1, null, "Article_188", 188.0 },
                    { 192, 1, null, "Article_192", 192.0 },
                    { 196, 1, null, "Article_196", 196.0 },
                    { 200, 1, null, "Article_200", 200.0 },
                    { 204, 1, null, "Article_204", 204.0 },
                    { 208, 1, null, "Article_208", 208.0 },
                    { 212, 1, null, "Article_212", 212.0 },
                    { 216, 1, null, "Article_216", 216.0 },
                    { 220, 1, null, "Article_220", 220.0 },
                    { 224, 1, null, "Article_224", 224.0 },
                    { 228, 1, null, "Article_228", 228.0 },
                    { 232, 1, null, "Article_232", 232.0 },
                    { 236, 1, null, "Article_236", 236.0 },
                    { 128, 1, null, "Article_128", 128.0 },
                    { 240, 1, null, "Article_240", 240.0 },
                    { 124, 1, null, "Article_124", 124.0 },
                    { 116, 1, null, "Article_116", 116.0 },
                    { 8, 1, null, "Article_8", 8.0 },
                    { 12, 1, null, "Article_12", 12.0 },
                    { 16, 1, null, "Article_16", 16.0 },
                    { 20, 1, null, "Article_20", 20.0 },
                    { 24, 1, null, "Article_24", 24.0 },
                    { 28, 1, null, "Article_28", 28.0 },
                    { 32, 1, null, "Article_32", 32.0 },
                    { 36, 1, null, "Article_36", 36.0 },
                    { 40, 1, null, "Article_40", 40.0 },
                    { 44, 1, null, "Article_44", 44.0 },
                    { 48, 1, null, "Article_48", 48.0 },
                    { 52, 1, null, "Article_52", 52.0 },
                    { 56, 1, null, "Article_56", 56.0 },
                    { 60, 1, null, "Article_60", 60.0 },
                    { 64, 1, null, "Article_64", 64.0 }
                });

            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "Id", "CategoryId", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 68, 1, null, "Article_68", 68.0 },
                    { 72, 1, null, "Article_72", 72.0 },
                    { 76, 1, null, "Article_76", 76.0 },
                    { 80, 1, null, "Article_80", 80.0 },
                    { 84, 1, null, "Article_84", 84.0 },
                    { 88, 1, null, "Article_88", 88.0 },
                    { 92, 1, null, "Article_92", 92.0 },
                    { 96, 1, null, "Article_96", 96.0 },
                    { 100, 1, null, "Article_100", 100.0 },
                    { 104, 1, null, "Article_104", 104.0 },
                    { 108, 1, null, "Article_108", 108.0 },
                    { 112, 1, null, "Article_112", 112.0 },
                    { 120, 1, null, "Article_120", 120.0 },
                    { 244, 1, null, "Article_244", 244.0 },
                    { 248, 1, null, "Article_248", 248.0 },
                    { 252, 1, null, "Article_252", 252.0 },
                    { 384, 1, null, "Article_384", 384.0 },
                    { 388, 1, null, "Article_388", 388.0 },
                    { 392, 1, null, "Article_392", 392.0 },
                    { 396, 1, null, "Article_396", 396.0 },
                    { 400, 1, null, "Article_400", 400.0 },
                    { 404, 1, null, "Article_404", 404.0 },
                    { 408, 1, null, "Article_408", 408.0 },
                    { 412, 1, null, "Article_412", 412.0 },
                    { 416, 1, null, "Article_416", 416.0 },
                    { 420, 1, null, "Article_420", 420.0 },
                    { 424, 1, null, "Article_424", 424.0 },
                    { 428, 1, null, "Article_428", 428.0 },
                    { 432, 1, null, "Article_432", 432.0 },
                    { 436, 1, null, "Article_436", 436.0 },
                    { 440, 1, null, "Article_440", 440.0 },
                    { 444, 1, null, "Article_444", 444.0 },
                    { 448, 1, null, "Article_448", 448.0 },
                    { 452, 1, null, "Article_452", 452.0 },
                    { 456, 1, null, "Article_456", 456.0 },
                    { 460, 1, null, "Article_460", 460.0 },
                    { 464, 1, null, "Article_464", 464.0 },
                    { 468, 1, null, "Article_468", 468.0 },
                    { 472, 1, null, "Article_472", 472.0 },
                    { 476, 1, null, "Article_476", 476.0 },
                    { 480, 1, null, "Article_480", 480.0 },
                    { 484, 1, null, "Article_484", 484.0 }
                });

            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "Id", "CategoryId", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 488, 1, null, "Article_488", 488.0 },
                    { 380, 1, null, "Article_380", 380.0 },
                    { 376, 1, null, "Article_376", 376.0 },
                    { 372, 1, null, "Article_372", 372.0 },
                    { 368, 1, null, "Article_368", 368.0 },
                    { 256, 1, null, "Article_256", 256.0 },
                    { 260, 1, null, "Article_260", 260.0 },
                    { 264, 1, null, "Article_264", 264.0 },
                    { 268, 1, null, "Article_268", 268.0 },
                    { 272, 1, null, "Article_272", 272.0 },
                    { 276, 1, null, "Article_276", 276.0 },
                    { 280, 1, null, "Article_280", 280.0 },
                    { 284, 1, null, "Article_284", 284.0 },
                    { 288, 1, null, "Article_288", 288.0 },
                    { 292, 1, null, "Article_292", 292.0 },
                    { 296, 1, null, "Article_296", 296.0 },
                    { 300, 1, null, "Article_300", 300.0 },
                    { 304, 1, null, "Article_304", 304.0 },
                    { 496, 1, null, "Article_496", 496.0 },
                    { 308, 1, null, "Article_308", 308.0 },
                    { 316, 1, null, "Article_316", 316.0 },
                    { 320, 1, null, "Article_320", 320.0 },
                    { 324, 1, null, "Article_324", 324.0 },
                    { 328, 1, null, "Article_328", 328.0 },
                    { 332, 1, null, "Article_332", 332.0 },
                    { 336, 1, null, "Article_336", 336.0 },
                    { 340, 1, null, "Article_340", 340.0 },
                    { 344, 1, null, "Article_344", 344.0 },
                    { 348, 1, null, "Article_348", 348.0 },
                    { 352, 1, null, "Article_352", 352.0 },
                    { 356, 1, null, "Article_356", 356.0 },
                    { 360, 1, null, "Article_360", 360.0 },
                    { 364, 1, null, "Article_364", 364.0 },
                    { 312, 1, null, "Article_312", 312.0 },
                    { 996, 1, null, "Article_996", 996.0 },
                    { 1000, 1, null, "Article_1000", 1000.0 },
                    { 1, 2, null, "Article_1", 1.0 },
                    { 633, 2, null, "Article_633", 633.0 },
                    { 637, 2, null, "Article_637", 637.0 },
                    { 641, 2, null, "Article_641", 641.0 },
                    { 645, 2, null, "Article_645", 645.0 },
                    { 649, 2, null, "Article_649", 649.0 }
                });

            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "Id", "CategoryId", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 653, 2, null, "Article_653", 653.0 },
                    { 657, 2, null, "Article_657", 657.0 },
                    { 661, 2, null, "Article_661", 661.0 },
                    { 665, 2, null, "Article_665", 665.0 },
                    { 669, 2, null, "Article_669", 669.0 },
                    { 673, 2, null, "Article_673", 673.0 },
                    { 677, 2, null, "Article_677", 677.0 },
                    { 681, 2, null, "Article_681", 681.0 },
                    { 685, 2, null, "Article_685", 685.0 },
                    { 689, 2, null, "Article_689", 689.0 },
                    { 693, 2, null, "Article_693", 693.0 },
                    { 697, 2, null, "Article_697", 697.0 },
                    { 701, 2, null, "Article_701", 701.0 },
                    { 705, 2, null, "Article_705", 705.0 },
                    { 709, 2, null, "Article_709", 709.0 },
                    { 713, 2, null, "Article_713", 713.0 },
                    { 717, 2, null, "Article_717", 717.0 },
                    { 721, 2, null, "Article_721", 721.0 },
                    { 725, 2, null, "Article_725", 725.0 },
                    { 729, 2, null, "Article_729", 729.0 },
                    { 733, 2, null, "Article_733", 733.0 },
                    { 737, 2, null, "Article_737", 737.0 },
                    { 629, 2, null, "Article_629", 629.0 },
                    { 741, 2, null, "Article_741", 741.0 },
                    { 625, 2, null, "Article_625", 625.0 },
                    { 617, 2, null, "Article_617", 617.0 },
                    { 509, 2, null, "Article_509", 509.0 },
                    { 513, 2, null, "Article_513", 513.0 },
                    { 517, 2, null, "Article_517", 517.0 },
                    { 521, 2, null, "Article_521", 521.0 },
                    { 525, 2, null, "Article_525", 525.0 },
                    { 529, 2, null, "Article_529", 529.0 },
                    { 533, 2, null, "Article_533", 533.0 },
                    { 537, 2, null, "Article_537", 537.0 },
                    { 541, 2, null, "Article_541", 541.0 },
                    { 545, 2, null, "Article_545", 545.0 },
                    { 549, 2, null, "Article_549", 549.0 },
                    { 553, 2, null, "Article_553", 553.0 },
                    { 557, 2, null, "Article_557", 557.0 },
                    { 561, 2, null, "Article_561", 561.0 },
                    { 565, 2, null, "Article_565", 565.0 },
                    { 569, 2, null, "Article_569", 569.0 }
                });

            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "Id", "CategoryId", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 573, 2, null, "Article_573", 573.0 },
                    { 577, 2, null, "Article_577", 577.0 },
                    { 581, 2, null, "Article_581", 581.0 },
                    { 585, 2, null, "Article_585", 585.0 },
                    { 589, 2, null, "Article_589", 589.0 },
                    { 593, 2, null, "Article_593", 593.0 },
                    { 597, 2, null, "Article_597", 597.0 },
                    { 601, 2, null, "Article_601", 601.0 },
                    { 605, 2, null, "Article_605", 605.0 },
                    { 609, 2, null, "Article_609", 609.0 },
                    { 613, 2, null, "Article_613", 613.0 },
                    { 621, 2, null, "Article_621", 621.0 },
                    { 745, 2, null, "Article_745", 745.0 },
                    { 749, 2, null, "Article_749", 749.0 },
                    { 753, 2, null, "Article_753", 753.0 },
                    { 885, 2, null, "Article_885", 885.0 },
                    { 889, 2, null, "Article_889", 889.0 },
                    { 893, 2, null, "Article_893", 893.0 },
                    { 897, 2, null, "Article_897", 897.0 },
                    { 901, 2, null, "Article_901", 901.0 },
                    { 905, 2, null, "Article_905", 905.0 },
                    { 909, 2, null, "Article_909", 909.0 },
                    { 913, 2, null, "Article_913", 913.0 },
                    { 917, 2, null, "Article_917", 917.0 },
                    { 921, 2, null, "Article_921", 921.0 },
                    { 925, 2, null, "Article_925", 925.0 },
                    { 929, 2, null, "Article_929", 929.0 },
                    { 933, 2, null, "Article_933", 933.0 },
                    { 937, 2, null, "Article_937", 937.0 },
                    { 941, 2, null, "Article_941", 941.0 },
                    { 945, 2, null, "Article_945", 945.0 },
                    { 949, 2, null, "Article_949", 949.0 },
                    { 953, 2, null, "Article_953", 953.0 },
                    { 957, 2, null, "Article_957", 957.0 },
                    { 961, 2, null, "Article_961", 961.0 },
                    { 965, 2, null, "Article_965", 965.0 },
                    { 969, 2, null, "Article_969", 969.0 },
                    { 973, 2, null, "Article_973", 973.0 },
                    { 977, 2, null, "Article_977", 977.0 },
                    { 981, 2, null, "Article_981", 981.0 },
                    { 985, 2, null, "Article_985", 985.0 },
                    { 989, 2, null, "Article_989", 989.0 }
                });

            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "Id", "CategoryId", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 881, 2, null, "Article_881", 881.0 },
                    { 877, 2, null, "Article_877", 877.0 },
                    { 873, 2, null, "Article_873", 873.0 },
                    { 869, 2, null, "Article_869", 869.0 },
                    { 757, 2, null, "Article_757", 757.0 },
                    { 761, 2, null, "Article_761", 761.0 },
                    { 765, 2, null, "Article_765", 765.0 },
                    { 769, 2, null, "Article_769", 769.0 },
                    { 773, 2, null, "Article_773", 773.0 },
                    { 777, 2, null, "Article_777", 777.0 },
                    { 781, 2, null, "Article_781", 781.0 },
                    { 785, 2, null, "Article_785", 785.0 },
                    { 789, 2, null, "Article_789", 789.0 },
                    { 793, 2, null, "Article_793", 793.0 },
                    { 797, 2, null, "Article_797", 797.0 },
                    { 801, 2, null, "Article_801", 801.0 },
                    { 805, 2, null, "Article_805", 805.0 },
                    { 505, 2, null, "Article_505", 505.0 },
                    { 809, 2, null, "Article_809", 809.0 },
                    { 817, 2, null, "Article_817", 817.0 },
                    { 821, 2, null, "Article_821", 821.0 },
                    { 825, 2, null, "Article_825", 825.0 },
                    { 829, 2, null, "Article_829", 829.0 },
                    { 833, 2, null, "Article_833", 833.0 },
                    { 837, 2, null, "Article_837", 837.0 },
                    { 841, 2, null, "Article_841", 841.0 },
                    { 845, 2, null, "Article_845", 845.0 },
                    { 849, 2, null, "Article_849", 849.0 },
                    { 853, 2, null, "Article_853", 853.0 },
                    { 857, 2, null, "Article_857", 857.0 },
                    { 861, 2, null, "Article_861", 861.0 },
                    { 865, 2, null, "Article_865", 865.0 },
                    { 813, 2, null, "Article_813", 813.0 },
                    { 501, 2, null, "Article_501", 501.0 },
                    { 497, 2, null, "Article_497", 497.0 },
                    { 493, 2, null, "Article_493", 493.0 },
                    { 133, 2, null, "Article_133", 133.0 },
                    { 137, 2, null, "Article_137", 137.0 },
                    { 141, 2, null, "Article_141", 141.0 },
                    { 145, 2, null, "Article_145", 145.0 },
                    { 149, 2, null, "Article_149", 149.0 },
                    { 153, 2, null, "Article_153", 153.0 }
                });

            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "Id", "CategoryId", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 157, 2, null, "Article_157", 157.0 },
                    { 161, 2, null, "Article_161", 161.0 },
                    { 165, 2, null, "Article_165", 165.0 },
                    { 169, 2, null, "Article_169", 169.0 },
                    { 173, 2, null, "Article_173", 173.0 },
                    { 177, 2, null, "Article_177", 177.0 },
                    { 181, 2, null, "Article_181", 181.0 },
                    { 185, 2, null, "Article_185", 185.0 },
                    { 189, 2, null, "Article_189", 189.0 },
                    { 193, 2, null, "Article_193", 193.0 },
                    { 197, 2, null, "Article_197", 197.0 },
                    { 201, 2, null, "Article_201", 201.0 },
                    { 205, 2, null, "Article_205", 205.0 },
                    { 209, 2, null, "Article_209", 209.0 },
                    { 213, 2, null, "Article_213", 213.0 },
                    { 217, 2, null, "Article_217", 217.0 },
                    { 221, 2, null, "Article_221", 221.0 },
                    { 225, 2, null, "Article_225", 225.0 },
                    { 229, 2, null, "Article_229", 229.0 },
                    { 233, 2, null, "Article_233", 233.0 },
                    { 237, 2, null, "Article_237", 237.0 },
                    { 129, 2, null, "Article_129", 129.0 },
                    { 125, 2, null, "Article_125", 125.0 },
                    { 121, 2, null, "Article_121", 121.0 },
                    { 117, 2, null, "Article_117", 117.0 },
                    { 5, 2, null, "Article_5", 5.0 },
                    { 9, 2, null, "Article_9", 9.0 },
                    { 13, 2, null, "Article_13", 13.0 },
                    { 17, 2, null, "Article_17", 17.0 },
                    { 21, 2, null, "Article_21", 21.0 },
                    { 25, 2, null, "Article_25", 25.0 },
                    { 29, 2, null, "Article_29", 29.0 },
                    { 33, 2, null, "Article_33", 33.0 },
                    { 37, 2, null, "Article_37", 37.0 },
                    { 41, 2, null, "Article_41", 41.0 },
                    { 45, 2, null, "Article_45", 45.0 },
                    { 49, 2, null, "Article_49", 49.0 },
                    { 53, 2, null, "Article_53", 53.0 },
                    { 241, 2, null, "Article_241", 241.0 },
                    { 57, 2, null, "Article_57", 57.0 },
                    { 65, 2, null, "Article_65", 65.0 },
                    { 69, 2, null, "Article_69", 69.0 }
                });

            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "Id", "CategoryId", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 73, 2, null, "Article_73", 73.0 },
                    { 77, 2, null, "Article_77", 77.0 },
                    { 81, 2, null, "Article_81", 81.0 },
                    { 85, 2, null, "Article_85", 85.0 },
                    { 89, 2, null, "Article_89", 89.0 },
                    { 93, 2, null, "Article_93", 93.0 },
                    { 97, 2, null, "Article_97", 97.0 },
                    { 101, 2, null, "Article_101", 101.0 },
                    { 105, 2, null, "Article_105", 105.0 },
                    { 109, 2, null, "Article_109", 109.0 },
                    { 113, 2, null, "Article_113", 113.0 },
                    { 61, 2, null, "Article_61", 61.0 },
                    { 995, 4, null, "Article_995", 995.0 },
                    { 245, 2, null, "Article_245", 245.0 },
                    { 253, 2, null, "Article_253", 253.0 },
                    { 385, 2, null, "Article_385", 385.0 },
                    { 389, 2, null, "Article_389", 389.0 },
                    { 393, 2, null, "Article_393", 393.0 },
                    { 397, 2, null, "Article_397", 397.0 },
                    { 401, 2, null, "Article_401", 401.0 },
                    { 405, 2, null, "Article_405", 405.0 },
                    { 409, 2, null, "Article_409", 409.0 },
                    { 413, 2, null, "Article_413", 413.0 },
                    { 417, 2, null, "Article_417", 417.0 },
                    { 421, 2, null, "Article_421", 421.0 },
                    { 425, 2, null, "Article_425", 425.0 },
                    { 429, 2, null, "Article_429", 429.0 },
                    { 433, 2, null, "Article_433", 433.0 },
                    { 437, 2, null, "Article_437", 437.0 },
                    { 441, 2, null, "Article_441", 441.0 },
                    { 445, 2, null, "Article_445", 445.0 },
                    { 449, 2, null, "Article_449", 449.0 },
                    { 453, 2, null, "Article_453", 453.0 },
                    { 457, 2, null, "Article_457", 457.0 },
                    { 461, 2, null, "Article_461", 461.0 },
                    { 465, 2, null, "Article_465", 465.0 },
                    { 469, 2, null, "Article_469", 469.0 },
                    { 473, 2, null, "Article_473", 473.0 },
                    { 477, 2, null, "Article_477", 477.0 },
                    { 481, 2, null, "Article_481", 481.0 },
                    { 485, 2, null, "Article_485", 485.0 },
                    { 489, 2, null, "Article_489", 489.0 }
                });

            migrationBuilder.InsertData(
                table: "Article",
                columns: new[] { "Id", "CategoryId", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 381, 2, null, "Article_381", 381.0 },
                    { 377, 2, null, "Article_377", 377.0 },
                    { 373, 2, null, "Article_373", 373.0 },
                    { 369, 2, null, "Article_369", 369.0 },
                    { 257, 2, null, "Article_257", 257.0 },
                    { 261, 2, null, "Article_261", 261.0 },
                    { 265, 2, null, "Article_265", 265.0 },
                    { 269, 2, null, "Article_269", 269.0 },
                    { 273, 2, null, "Article_273", 273.0 },
                    { 277, 2, null, "Article_277", 277.0 },
                    { 281, 2, null, "Article_281", 281.0 },
                    { 285, 2, null, "Article_285", 285.0 },
                    { 289, 2, null, "Article_289", 289.0 },
                    { 293, 2, null, "Article_293", 293.0 },
                    { 297, 2, null, "Article_297", 297.0 },
                    { 301, 2, null, "Article_301", 301.0 },
                    { 305, 2, null, "Article_305", 305.0 },
                    { 249, 2, null, "Article_249", 249.0 },
                    { 309, 2, null, "Article_309", 309.0 },
                    { 317, 2, null, "Article_317", 317.0 },
                    { 321, 2, null, "Article_321", 321.0 },
                    { 325, 2, null, "Article_325", 325.0 },
                    { 329, 2, null, "Article_329", 329.0 },
                    { 333, 2, null, "Article_333", 333.0 },
                    { 337, 2, null, "Article_337", 337.0 },
                    { 341, 2, null, "Article_341", 341.0 },
                    { 345, 2, null, "Article_345", 345.0 },
                    { 349, 2, null, "Article_349", 349.0 },
                    { 353, 2, null, "Article_353", 353.0 },
                    { 357, 2, null, "Article_357", 357.0 },
                    { 361, 2, null, "Article_361", 361.0 },
                    { 365, 2, null, "Article_365", 365.0 },
                    { 313, 2, null, "Article_313", 313.0 },
                    { 999, 4, null, "Article_999", 999.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 729);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 743);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 744);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 745);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 746);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 747);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 748);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 750);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 752);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 753);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 754);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 757);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 758);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 759);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 760);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 765);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 766);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 767);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 768);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 769);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 770);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 771);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 773);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 774);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 775);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 776);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 778);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 779);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 780);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 781);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 782);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 783);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 784);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 785);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 786);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 787);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 788);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 789);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 790);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 791);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 792);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 793);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 794);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 795);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 797);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 798);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 799);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 800);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 801);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 802);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 803);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 804);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 805);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 806);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 807);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 808);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 809);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 810);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 811);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 812);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 813);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 814);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 815);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 816);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 817);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 818);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 819);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 820);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 821);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 822);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 823);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 824);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 825);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 826);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 827);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 828);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 829);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 830);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 831);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 832);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 833);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 834);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 835);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 836);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 837);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 838);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 839);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 840);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 841);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 842);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 843);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 844);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 845);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 846);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 847);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 848);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 849);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 850);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 851);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 852);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 853);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 854);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 855);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 856);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 857);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 858);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 859);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 860);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 861);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 862);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 863);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 864);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 865);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 866);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 867);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 868);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 869);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 870);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 871);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 872);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 873);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 874);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 875);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 876);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 877);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 878);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 879);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 880);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 881);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 882);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 883);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 884);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 885);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 886);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 887);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 888);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 889);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 890);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 891);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 892);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 893);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 894);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 895);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 896);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 897);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 898);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 899);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 900);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 901);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 902);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 903);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 904);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 905);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 906);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 907);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 908);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 909);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 910);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 911);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 912);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 913);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 914);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 915);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 916);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 917);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 918);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 919);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 920);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 921);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 922);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 923);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 924);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 925);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 926);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 927);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 928);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 929);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 930);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 931);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 932);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 933);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 934);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 935);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 936);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 937);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 938);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 939);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 940);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 941);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 942);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 943);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 944);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 945);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 946);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 947);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 948);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 949);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 950);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 951);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 952);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 953);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 954);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 955);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 956);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 957);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 958);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 959);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 960);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 961);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 962);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 963);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 964);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 965);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 966);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 967);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 968);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 969);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 970);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 971);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 972);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 973);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 974);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 975);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 976);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 977);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 978);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 979);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 980);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 981);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 982);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 983);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 984);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 985);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 986);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 987);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 988);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 989);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 990);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 991);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 992);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 993);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 994);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 995);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 996);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 997);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 998);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 999);

            migrationBuilder.DeleteData(
                table: "Article",
                keyColumn: "Id",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
