using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestroManagement.Migrations
{
    /// <inheritdoc />
    public partial class addcities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 203,
                column: "Name",
                value: "New Delhi");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 204,
                column: "Name",
                value: "Delhi");

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "UniqueId", "Name", "StateId" },
                values: new object[,]
                {
                    { 283, "Bhiwan", 12 },
                    { 284, "Yamunanaga", 12 },
                    { 285, "Panchkul", 12 },
                    { 286, "Sonipa", 12 },
                    { 287, "Bahadurgar", 12 },
                    { 288, "Jin", 12 },
                    { 289, "Sirs", 12 },
                    { 290, "Thanesa", 12 },
                    { 291, "Kaitha", 12 },
                    { 292, "Palwa", 12 },
                    { 293, "Gurgao", 12 },
                    { 294, "Faridaba", 12 },
                    { 295, "Hisa", 12 },
                    { 296, "Rohta", 12 },
                    { 297, "Panipa", 12 },
                    { 298, "Karna", 12 },
                    { 299, "Mandi Dabwal", 12 },
                    { 300, "Gohan", 12 },
                    { 301, "Narwan", 12 },
                    { 302, "Tohan", 12 },
                    { 303, "Fatehaba", 12 },
                    { 304, "Narnau", 12 },
                    { 305, "Hans", 12 },
                    { 306, "Rewar", 12 },
                    { 307, "Ladw", 12 },
                    { 308, "Sohn", 12 },
                    { 309, "Safido", 12 },
                    { 310, "Taraor", 12 },
                    { 311, "Pinjor", 12 },
                    { 312, "Samalkh", 12 },
                    { 313, "Rati", 12 },
                    { 314, "Mahendragar", 12 },
                    { 315, "Charkhi Dadr", 12 },
                    { 316, "Pehow", 12 },
                    { 317, "Shahba", 12 },
                    { 318, "Sola", 13 },
                    { 319, "Sundarnaga", 13 },
                    { 320, "Palampu", 13 },
                    { 321, "Naha", 13 },
                    { 322, "Mand", 13 },
                    { 323, "Shiml", 13 },
                    { 324, "Baramul", 14 },
                    { 325, "Jamm", 14 },
                    { 326, "Srinaga", 14 },
                    { 327, "Sopor", 14 },
                    { 328, "Anantna", 14 },
                    { 329, "Udhampu", 14 },
                    { 330, "KathUrban Agglomeratio", 14 },
                    { 331, "Rajaur", 14 },
                    { 332, "Punc", 14 },
                    { 333, "Madhupu", 15 },
                    { 334, "Chirkund", 15 },
                    { 335, "Chatr", 15 },
                    { 336, "Dumk", 15 },
                    { 337, "Gumi", 15 },
                    { 338, "Simdeg", 15 },
                    { 339, "Musaban", 15 },
                    { 340, "Mihija", 15 },
                    { 341, "Pakau", 15 },
                    { 342, "Patrat", 15 },
                    { 343, "Lohardag", 15 },
                    { 344, "Tenu dam-cum-Kathhar", 15 },
                    { 345, "Ramgar", 15 },
                    { 346, "Saund", 15 },
                    { 347, "Jhumri Tilaiy", 15 },
                    { 348, "Sahibgan", 15 },
                    { 349, "Medininagar (Daltonganj", 15 },
                    { 350, "Chaibas", 15 },
                    { 351, "Dhanba", 15 },
                    { 352, "Ranch", 15 },
                    { 353, "Jamshedpu", 15 },
                    { 354, "Bokaro Steel Cit", 15 },
                    { 355, "Phusr", 15 },
                    { 356, "Adityapu", 15 },
                    { 357, "Deogha", 15 },
                    { 358, "Hazariba", 15 },
                    { 359, "Giridi", 15 },
                    { 360, "Chikkamagalur", 16 },
                    { 361, "Udup", 16 },
                    { 362, "Mandy", 16 },
                    { 363, "Kola", 16 },
                    { 364, "Raayachur", 16 },
                    { 365, "Robertson Pe", 16 },
                    { 366, "Davanager", 16 },
                    { 367, "Belagav", 16 },
                    { 368, "Mangalur", 16 },
                    { 369, "Ballar", 16 },
                    { 370, "Shivamogg", 16 },
                    { 371, "Tumku", 16 },
                    { 372, "Hubli-Dharwa", 16 },
                    { 373, "Bengalur", 16 },
                    { 374, "Rabkavi Banhatt", 16 },
                    { 375, "Shahaba", 16 },
                    { 376, "Sirs", 16 },
                    { 377, "Tiptu", 16 },
                    { 378, "Sindhnu", 16 },
                    { 379, "Yadgi", 16 },
                    { 380, "Ramanagara", 16 },
                    { 381, "Goka", 16 },
                    { 382, "Karwa", 16 },
                    { 383, "Ranebennur", 16 },
                    { 384, "Ranibennu", 16 },
                    { 385, "Ro", 16 },
                    { 386, "Srinivaspu", 16 },
                    { 387, "Sakaleshapur", 16 },
                    { 388, "Shiggao", 16 },
                    { 389, "Sindag", 16 },
                    { 390, "Shrirangapattan", 16 },
                    { 391, "Mudabidr", 16 },
                    { 392, "Navalgun", 16 },
                    { 393, "Magad", 16 },
                    { 394, "Talikot", 16 },
                    { 395, "Mahalingapur", 16 },
                    { 396, "Seda", 16 },
                    { 397, "Shikaripu", 16 },
                    { 398, "Mudalag", 16 },
                    { 399, "Muddebiha", 16 },
                    { 400, "Pavagad", 16 },
                    { 401, "Sindhag", 16 },
                    { 402, "Sandur", 16 },
                    { 403, "Malu", 16 },
                    { 404, "Terda", 16 },
                    { 405, "Maddu", 16 },
                    { 406, "Madhugir", 16 },
                    { 407, "Tekkalakot", 16 },
                    { 408, "Afzalpu", 16 },
                    { 409, "Nargun", 16 },
                    { 410, "Tariker", 16 },
                    { 411, "Malavall", 16 },
                    { 412, "Lakshmeshwa", 16 },
                    { 413, "Ramdur", 16 },
                    { 414, "Nelamangal", 16 },
                    { 415, "Manv", 16 },
                    { 416, "Shahpu", 16 },
                    { 417, "Saundatti-Yellamm", 16 },
                    { 418, "Wad", 16 },
                    { 419, "Sidlaghatt", 16 },
                    { 420, "Sankeshwar", 16 },
                    { 421, "Madiker", 16 },
                    { 422, "Savanu", 16 },
                    { 423, "Lingsugu", 16 },
                    { 424, "Vijayapur", 16 },
                    { 425, "Puttu", 16 },
                    { 426, "Sir", 16 },
                    { 427, "Arsiker", 16 },
                    { 428, "Sagar", 16 },
                    { 429, "Nanjangu", 16 },
                    { 430, "Athn", 16 },
                    { 431, "Sirugupp", 16 },
                    { 432, "Mudho", 16 },
                    { 433, "Mulbaga", 16 },
                    { 434, "Surapur", 16 },
                    { 435, "Sadalag", 16 },
                    { 436, "Mundarg", 16 },
                    { 437, "Adya", 16 },
                    { 438, "Piriyapatn", 16 },
                    { 439, "Mysor", 17 },
                    { 440, "Thrissu", 18 },
                    { 441, "Kolla", 18 },
                    { 442, "Kozhikod", 18 },
                    { 443, "Thiruvananthapura", 18 },
                    { 444, "Koch", 18 },
                    { 445, "Alappuzh", 18 },
                    { 446, "Palakka", 18 },
                    { 447, "Malappura", 18 },
                    { 448, "Ponnan", 18 },
                    { 449, "Taliparamb", 18 },
                    { 450, "Kanhanga", 18 },
                    { 451, "Vatakar", 18 },
                    { 452, "Nedumanga", 18 },
                    { 453, "Ottappala", 18 },
                    { 454, "Kunnamkula", 18 },
                    { 455, "Kottaya", 18 },
                    { 456, "Kasarago", 18 },
                    { 457, "Kannu", 18 },
                    { 458, "Tiru", 18 },
                    { 459, "Kayamkula", 18 },
                    { 460, "Koyiland", 18 },
                    { 461, "Neyyattinkar", 18 },
                    { 462, "Shoranu", 18 },
                    { 463, "Cherthal", 18 },
                    { 464, "Nilambu", 18 },
                    { 465, "Punalu", 18 },
                    { 466, "Perinthalmann", 18 },
                    { 467, "Mattannu", 18 },
                    { 468, "Thodupuzh", 18 },
                    { 469, "Thiruvall", 18 },
                    { 470, "Changanasser", 18 },
                    { 471, "Chalakud", 18 },
                    { 472, "Kodungallu", 18 },
                    { 473, "Pappinisser", 18 },
                    { 474, "Varkal", 18 },
                    { 475, "Pathanamthitt", 18 },
                    { 476, "Paravoo", 18 },
                    { 477, "Attinga", 18 },
                    { 478, "Peringathu", 18 },
                    { 479, "Perumbavoo", 18 },
                    { 480, "Mavelikkar", 18 },
                    { 481, "Mavoo", 18 },
                    { 482, "Muvattupuzh", 18 },
                    { 483, "Adoo", 18 },
                    { 484, "Chittur-Thathamangala", 18 },
                    { 485, "Vaiko", 18 },
                    { 486, "Pala", 18 },
                    { 487, "Puthuppall", 18 },
                    { 488, "Panamatto", 18 },
                    { 489, "Guruvayoo", 18 },
                    { 490, "Panniyannu", 18 },
                    { 491, "Ra", 19 },
                    { 492, "Pal", 19 },
                    { 493, "Pachor", 19 },
                    { 494, "Mhowgao", 19 },
                    { 495, "Narsinghgar", 19 },
                    { 496, "Vijaypu", 19 },
                    { 497, "Manas", 19 },
                    { 498, "Nainpu", 19 },
                    { 499, "Prithvipu", 19 },
                    { 500, "Sohagpu", 19 },
                    { 501, "Maugan", 19 },
                    { 502, "Shamgar", 19 },
                    { 503, "Maharajpu", 19 },
                    { 504, "Multa", 19 },
                    { 505, "Nowrozabad (Khodargama", 19 },
                    { 506, "Niwar", 19 },
                    { 507, "Sausa", 19 },
                    { 508, "Rajgar", 19 },
                    { 509, "Taran", 19 },
                    { 510, "Wara Seon", 19 },
                    { 511, "Rahatgar", 19 },
                    { 512, "Panaga", 19 },
                    { 513, "Manawa", 19 },
                    { 514, "Malaj Khan", 19 },
                    { 515, "Sarangpu", 19 },
                    { 516, "Narsinghgar", 19 },
                    { 517, "Mahidpu", 19 },
                    { 518, "Pasa", 19 },
                    { 519, "Mund", 19 },
                    { 520, "Nepanaga", 19 },
                    { 521, "Seoni-Malw", 19 },
                    { 522, "Rehl", 19 },
                    { 523, "Raise", 19 },
                    { 524, "Laha", 19 },
                    { 525, "Sihor", 19 },
                    { 526, "Nowgon", 19 },
                    { 527, "Mandidee", 19 },
                    { 528, "Umari", 19 },
                    { 529, "Pors", 19 },
                    { 530, "Sanawa", 19 },
                    { 531, "Sabalgar", 19 },
                    { 532, "Maiha", 19 },
                    { 533, "Raghogarh-Vijaypu", 19 },
                    { 534, "Sendhw", 19 },
                    { 535, "Pann", 19 },
                    { 536, "Pipariy", 19 },
                    { 537, "Sidh", 19 },
                    { 538, "Siron", 19 },
                    { 539, "Pandhurn", 19 },
                    { 540, "Shujalpu", 19 },
                    { 541, "Pithampu", 19 },
                    { 542, "Alirajpu", 19 },
                    { 543, "Mandl", 19 },
                    { 544, "Sheopu", 19 },
                    { 545, "Shajapu", 19 },
                    { 546, "Shahdo", 19 },
                    { 547, "Tikamgar", 19 },
                    { 548, "Balagha", 19 },
                    { 549, "Ashok Naga", 19 },
                    { 550, "Seon", 19 },
                    { 551, "Sarn", 19 },
                    { 552, "Sehor", 19 },
                    { 553, "Mhow Cantonmen", 19 },
                    { 554, "Itars", 19 },
                    { 555, "Nagd", 19 },
                    { 556, "Singraul", 19 },
                    { 557, "Moren", 19 },
                    { 558, "Murwara (Katni", 19 },
                    { 559, "Satn", 19 },
                    { 560, "Rew", 19 },
                    { 561, "Mandsau", 19 },
                    { 562, "Neemuc", 19 },
                    { 563, "Vidish", 19 },
                    { 564, "Shivpur", 19 },
                    { 565, "Ganjbasod", 19 },
                    { 566, "Ujjai", 19 },
                    { 567, "Indor", 19 },
                    { 568, "Jabalpu", 19 },
                    { 569, "Gwalio", 19 },
                    { 570, "Bhopa", 19 },
                    { 571, "Saga", 19 },
                    { 572, "Ratla", 19 },
                    { 573, "Ichalkaranj", 20 },
                    { 574, "Parbhan", 20 },
                    { 575, "Akol", 20 },
                    { 576, "Malegao", 20 },
                    { 577, "Nanded-Waghal", 20 },
                    { 578, "Ahmednaga", 20 },
                    { 579, "Latu", 20 },
                    { 580, "Dhul", 20 },
                    { 581, "Kalyan-Dombival", 20 },
                    { 582, "Vasai-Vira", 20 },
                    { 583, "Nashi", 20 },
                    { 584, "Than", 20 },
                    { 585, "Mumba", 20 },
                    { 586, "Nagpu", 20 },
                    { 587, "Pun", 20 },
                    { 588, "Sangl", 20 },
                    { 589, "Mira-Bhayanda", 20 },
                    { 590, "Amravat", 20 },
                    { 591, "Bhiwand", 20 },
                    { 592, "Solapu", 20 },
                    { 593, "Yavatma", 20 },
                    { 594, "Panve", 20 },
                    { 595, "Amalne", 20 },
                    { 596, "Shrirampu", 20 },
                    { 597, "Ako", 20 },
                    { 598, "Pandharpu", 20 },
                    { 599, "Aurangaba", 20 },
                    { 600, "Wardh", 20 },
                    { 601, "Udgi", 20 },
                    { 602, "Nandurba", 20 },
                    { 603, "Achalpu", 20 },
                    { 604, "Osmanaba", 20 },
                    { 605, "Satar", 20 },
                    { 606, "Parl", 20 },
                    { 607, "Washi", 20 },
                    { 608, "Manma", 20 },
                    { 609, "Ambejoga", 20 },
                    { 610, "Lonavl", 20 },
                    { 611, "Wan", 20 },
                    { 612, "Shirpur-Warwad", 20 },
                    { 613, "Malkapu", 20 },
                    { 614, "Talegaon Dabhad", 20 },
                    { 615, "Anjangao", 20 },
                    { 616, "Umre", 20 },
                    { 617, "Sangamne", 20 },
                    { 618, "Uran Islampu", 20 },
                    { 619, "Pusa", 20 },
                    { 620, "Ratnagir", 20 },
                    { 621, "Arv", 20 },
                    { 622, "Manjlegao", 20 },
                    { 623, "Sillo", 20 },
                    { 624, "Wadgaon Roa", 20 },
                    { 625, "Nandur", 20 },
                    { 626, "Waror", 20 },
                    { 627, "Pachor", 20 },
                    { 628, "Tumsa", 20 },
                    { 629, "Palgha", 20 },
                    { 630, "Shegao", 20 },
                    { 631, "Phalta", 20 },
                    { 632, "Oza", 20 },
                    { 633, "Shahad", 20 },
                    { 634, "Yevl", 20 },
                    { 635, "Vit", 20 },
                    { 636, "Umarkhe", 20 },
                    { 637, "Nawapu", 20 },
                    { 638, "Tuljapu", 20 },
                    { 639, "Paitha", 20 },
                    { 640, "Rahur", 20 },
                    { 641, "Nilang", 20 },
                    { 642, "Umarg", 20 },
                    { 643, "Purn", 20 },
                    { 644, "Morsh", 20 },
                    { 645, "Sail", 20 },
                    { 646, "Vaijapu", 20 },
                    { 647, "Tasgao", 20 },
                    { 648, "Murtijapu", 20 },
                    { 649, "Wa", 20 },
                    { 650, "Pulgao", 20 },
                    { 651, "Yawa", 20 },
                    { 652, "Mehka", 20 },
                    { 653, "Mukhe", 20 },
                    { 654, "Rave", 20 },
                    { 655, "Talod", 20 },
                    { 656, "Shrigond", 20 },
                    { 657, "Shird", 20 },
                    { 658, "Pandharkaod", 20 },
                    { 659, "Shiru", 20 },
                    { 660, "Savne", 20 },
                    { 661, "Sasva", 20 },
                    { 662, "Sangol", 20 },
                    { 663, "Partu", 20 },
                    { 664, "Mangrulpi", 20 },
                    { 665, "Riso", 20 },
                    { 666, "Karja", 20 },
                    { 667, "Pe", 20 },
                    { 668, "Ura", 20 },
                    { 669, "Manwat", 20 },
                    { 670, "Satan", 20 },
                    { 671, "Sinna", 20 },
                    { 672, "Pathr", 20 },
                    { 673, "Uchgao", 20 },
                    { 674, "Rajur", 20 },
                    { 675, "Vadgaon Kasb", 20 },
                    { 676, "Tiror", 20 },
                    { 677, "Maha", 20 },
                    { 678, "Lona", 20 },
                    { 679, "Soyagao", 20 },
                    { 680, "Mangalvedh", 20 },
                    { 681, "Sawantwad", 20 },
                    { 682, "Pathard", 20 },
                    { 683, "Mu", 20 },
                    { 684, "Ramte", 20 },
                    { 685, "Paun", 20 },
                    { 686, "Nandgao", 20 },
                    { 687, "Loh", 20 },
                    { 688, "Waru", 20 },
                    { 689, "Mhaswa", 20 },
                    { 690, "Patu", 20 },
                    { 691, "Narkhe", 20 },
                    { 692, "Shendurjan", 20 },
                    { 693, "Mayang Impha", 21 },
                    { 694, "Lilon", 21 },
                    { 695, "Thouba", 21 },
                    { 696, "Impha", 21 },
                    { 697, "Shillon", 22 },
                    { 698, "Tur", 22 },
                    { 699, "Nongstoi", 22 },
                    { 700, "Lungle", 23 },
                    { 701, "Aizaw", 23 },
                    { 702, "Saih", 23 },
                    { 703, "Dimapu", 24 },
                    { 704, "Kohim", 24 },
                    { 705, "Mokokchun", 24 },
                    { 706, "Zunhebot", 24 },
                    { 707, "Tuensan", 24 },
                    { 708, "Wokh", 24 },
                    { 709, "Phulaban", 25 },
                    { 710, "Pattamunda", 25 },
                    { 711, "Sundargar", 25 },
                    { 712, "Kendrapar", 25 },
                    { 713, "Talche", 25 },
                    { 714, "Rajagangapu", 25 },
                    { 715, "Parlakhemund", 25 },
                    { 716, "Byasanaga", 25 },
                    { 717, "Titlagar", 25 },
                    { 718, "Nabarangapu", 25 },
                    { 719, "Sor", 25 },
                    { 720, "Malkangir", 25 },
                    { 721, "Rairangpu", 25 },
                    { 722, "Balangi", 25 },
                    { 723, "Jharsugud", 25 },
                    { 724, "Bhadra", 25 },
                    { 725, "Baripada Tow", 25 },
                    { 726, "Paradi", 25 },
                    { 727, "Bargar", 25 },
                    { 728, "Jatan", 25 },
                    { 729, "Kendujha", 25 },
                    { 730, "Sunabed", 25 },
                    { 731, "Rayagad", 25 },
                    { 732, "Bhawanipatn", 25 },
                    { 733, "Barbi", 25 },
                    { 734, "Dhenkana", 25 },
                    { 735, "Baleshwar Tow", 25 },
                    { 736, "Sambalpu", 25 },
                    { 737, "Pur", 25 },
                    { 738, "Brahmapu", 25 },
                    { 739, "Raurkel", 25 },
                    { 740, "Bhubaneswa", 25 },
                    { 741, "Cuttac", 25 },
                    { 742, "Tarbh", 25 },
                    { 743, "Pondicherr", 26 },
                    { 744, "Yana", 26 },
                    { 745, "Karaika", 26 },
                    { 746, "Mah", 26 },
                    { 747, "Zir", 27 },
                    { 748, "Nakoda", 27 },
                    { 749, "Nanga", 27 },
                    { 750, "Patt", 27 },
                    { 751, "Sirhind Fatehgarh Sahi", 27 },
                    { 752, "Jalandhar Cantt", 27 },
                    { 753, "Rupnaga", 27 },
                    { 754, "Firozpur Cantt", 27 },
                    { 755, "Saman", 27 },
                    { 756, "Nawanshah", 27 },
                    { 757, "Rampura Phu", 27 },
                    { 758, "Qadia", 27 },
                    { 759, "Sujanpu", 27 },
                    { 760, "Pattra", 27 },
                    { 761, "Mukeria", 27 },
                    { 762, "Morinda, Indi", 27 },
                    { 763, "Phillau", 27 },
                    { 764, "Urmar Tand", 27 },
                    { 765, "Longowa", 27 },
                    { 766, "Raiko", 27 },
                    { 767, "Faridko", 27 },
                    { 768, "Muktsa", 27 },
                    { 769, "Rajpur", 27 },
                    { 770, "Mans", 27 },
                    { 771, "Gobindgar", 27 },
                    { 772, "Khara", 27 },
                    { 773, "Gurdaspu", 27 },
                    { 774, "Sangru", 27 },
                    { 775, "Fazilk", 27 },
                    { 776, "Firozpu", 27 },
                    { 777, "Phagwar", 27 },
                    { 778, "Kapurthal", 27 },
                    { 779, "Zirakpu", 27 },
                    { 780, "Kot Kapur", 27 },
                    { 781, "Dhur", 27 },
                    { 782, "Suna", 27 },
                    { 783, "Nabh", 27 },
                    { 784, "Tarn Tara", 27 },
                    { 785, "Malou", 27 },
                    { 786, "Jagrao", 27 },
                    { 787, "Bathind", 27 },
                    { 788, "Jalandha", 27 },
                    { 789, "Amritsa", 27 },
                    { 790, "Patial", 27 },
                    { 791, "Ludhian", 27 },
                    { 792, "Batal", 27 },
                    { 793, "Pathanko", 27 },
                    { 794, "Hoshiarpu", 27 },
                    { 795, "Mohal", 27 },
                    { 796, "Barnal", 27 },
                    { 797, "Mog", 27 },
                    { 798, "Khann", 27 },
                    { 799, "Malerkotl", 27 },
                    { 800, "Talwar", 27 },
                    { 801, "Takhatgar", 28 },
                    { 802, "Pindwar", 28 },
                    { 803, "Mandalgar", 28 },
                    { 804, "Mandaw", 28 },
                    { 805, "Sadulpu", 28 },
                    { 806, "Ton", 28 },
                    { 807, "Sika", 28 },
                    { 808, "Barme", 28 },
                    { 809, "Jodhpur", 28 },
                    { 810, "Jaipur", 28 },
                    { 811, "Bikane", 28 },
                    { 812, "Udaipu", 28 },
                    { 813, "Bharatpu", 28 },
                    { 814, "Pal", 28 },
                    { 815, "Ajme", 28 },
                    { 816, "Bhilwar", 28 },
                    { 817, "Alwa", 28 },
                    { 818, "Ladn", 28 },
                    { 819, "Nimbaher", 28 },
                    { 820, "Ratangar", 28 },
                    { 821, "Nokh", 28 },
                    { 822, "Rajsaman", 28 },
                    { 823, "Suratgar", 28 },
                    { 824, "Makran", 28 },
                    { 825, "Nagau", 28 },
                    { 826, "Sawai Madhopu", 28 },
                    { 827, "Sardarshaha", 28 },
                    { 828, "Sujangar", 28 },
                    { 829, "Sheogan", 28 },
                    { 830, "Rajgarh (Alwar", 28 },
                    { 831, "Naga", 28 },
                    { 832, "Sadr", 28 },
                    { 833, "Todaraising", 28 },
                    { 834, "Sambha", 28 },
                    { 835, "Pranti", 28 },
                    { 836, "Sadulshaha", 28 },
                    { 837, "Todabhi", 28 },
                    { 838, "Reengu", 28 },
                    { 839, "Rajaldesa", 28 },
                    { 840, "Phuler", 28 },
                    { 841, "Mount Ab", 28 },
                    { 842, "Mangro", 28 },
                    { 843, "Shahpur", 28 },
                    { 844, "Raisinghnaga", 28 },
                    { 845, "Rawatsa", 28 },
                    { 846, "Rajakher", 28 },
                    { 847, "Shahpur", 28 },
                    { 848, "Malpur", 28 },
                    { 849, "Nadba", 28 },
                    { 850, "Sanchor", 28 },
                    { 851, "Lakher", 28 },
                    { 852, "Losa", 28 },
                    { 853, "Sri Madhopu", 28 },
                    { 854, "Ramngar", 28 },
                    { 855, "Udaipurwat", 28 },
                    { 856, "Sagwar", 28 },
                    { 857, "Ramganj Mand", 28 },
                    { 858, "Sumerpu", 28 },
                    { 859, "Vijainagar, Ajme", 28 },
                    { 860, "Phalod", 28 },
                    { 861, "Nathdwar", 28 },
                    { 862, "Lachhmangar", 28 },
                    { 863, "Nasiraba", 28 },
                    { 864, "Rajgarh (Churu", 28 },
                    { 865, "Noha", 28 },
                    { 866, "Rawatbhat", 28 },
                    { 867, "Sangari", 28 },
                    { 868, "Pratapgar", 28 },
                    { 869, "Siroh", 28 },
                    { 870, "Lalso", 28 },
                    { 871, "Pipar Cit", 28 },
                    { 872, "Taranaga", 28 },
                    { 873, "Pilibang", 28 },
                    { 874, "Pilan", 28 },
                    { 875, "Merta Cit", 28 },
                    { 876, "Soja", 28 },
                    { 877, "Neem-Ka-Than", 28 },
                    { 878, "Perambalu", 29 },
                    { 879, "Tiruvethipura", 29 },
                    { 880, "Rameshwara", 29 },
                    { 881, "Sivagang", 29 },
                    { 882, "Vadalu", 29 },
                    { 883, "Vellakoi", 29 },
                    { 884, "Sathyamangala", 29 },
                    { 885, "Puliyankud", 29 },
                    { 886, "Nanjikotta", 29 },
                    { 887, "Thuraiyu", 29 },
                    { 888, "Vedaranya", 29 },
                    { 889, "Usilampatt", 29 },
                    { 890, "Thirumangala", 29 },
                    { 891, "Periyakula", 29 },
                    { 892, "Pernampatt", 29 },
                    { 893, "Nandivaram-Guduvancher", 29 },
                    { 894, "Tiruttan", 29 },
                    { 895, "Rasipura", 29 },
                    { 896, "Nellikuppa", 29 },
                    { 897, "Vikramasingapura", 29 },
                    { 898, "Periyasemu", 29 },
                    { 899, "Tiruchendu", 29 },
                    { 900, "Sattu", 29 },
                    { 901, "Sirkal", 29 },
                    { 902, "Vandavas", 29 },
                    { 903, "Uthamapalaya", 29 },
                    { 904, "Vadakkuvalliyu", 29 },
                    { 905, "Tirukalukundra", 29 },
                    { 906, "Tharamangala", 29 },
                    { 907, "Tirukkoyilu", 29 },
                    { 908, "Oddanchatra", 29 },
                    { 909, "Pallada", 29 },
                    { 910, "Manachanallu", 29 },
                    { 911, "Tirupathu", 29 },
                    { 912, "Shenkotta", 29 },
                    { 913, "Vadipatt", 29 },
                    { 914, "Sholingu", 29 },
                    { 915, "Suranda", 29 },
                    { 916, "Sankar", 29 },
                    { 917, "Suriyampalaya", 29 },
                    { 918, "O' Valle", 29 },
                    { 919, "Thammampatt", 29 },
                    { 920, "Sholavanda", 29 },
                    { 921, "Namagiripetta", 29 },
                    { 922, "Tittakud", 29 },
                    { 923, "Pacod", 29 },
                    { 924, "Tharangambad", 29 },
                    { 925, "Natha", 29 },
                    { 926, "Unnamalaikada", 29 },
                    { 927, "P.N.Patt", 29 },
                    { 928, "Thiruthuraipoond", 29 },
                    { 929, "Pallapatt", 29 },
                    { 930, "Ponner", 29 },
                    { 931, "Lalgud", 29 },
                    { 932, "Viswanatha", 29 },
                    { 933, "Polu", 29 },
                    { 934, "Panagud", 29 },
                    { 935, "Uthirameru", 29 },
                    { 936, "Paramakud", 29 },
                    { 937, "Udhagamandala", 29 },
                    { 938, "Aruppukkotta", 29 },
                    { 939, "Arakkona", 29 },
                    { 940, "Tindivana", 29 },
                    { 941, "Virudhunaga", 29 },
                    { 942, "Virudhachala", 29 },
                    { 943, "Srivilliputhu", 29 },
                    { 944, "Nagapattina", 29 },
                    { 945, "Neyveli (TS", 29 },
                    { 946, "Pudukkotta", 29 },
                    { 947, "Tiruchengod", 29 },
                    { 948, "Viluppura", 29 },
                    { 949, "Theni Allinagara", 29 },
                    { 950, "Vaniyambad", 29 },
                    { 951, "Thiruvaru", 29 },
                    { 952, "Gobichettipalaya", 29 },
                    { 953, "Udumalaipetta", 29 },
                    { 954, "Panrut", 29 },
                    { 955, "Namakka", 29 },
                    { 956, "Thiruvallu", 29 },
                    { 957, "Ramanathapura", 29 },
                    { 958, "Pattukkotta", 29 },
                    { 959, "Tirupathu", 29 },
                    { 960, "Sankarankovi", 29 },
                    { 961, "Tenkas", 29 },
                    { 962, "Karu", 29 },
                    { 963, "Valpara", 29 },
                    { 964, "Palan", 29 },
                    { 965, "Tirunelvel", 29 },
                    { 966, "Tiruppu", 29 },
                    { 967, "Ranipe", 29 },
                    { 968, "Tiruchirappall", 29 },
                    { 969, "Coimbator", 29 },
                    { 970, "Sale", 29 },
                    { 971, "Madura", 29 },
                    { 972, "Chenna", 29 },
                    { 973, "Vellor", 29 },
                    { 974, "Nagercoi", 29 },
                    { 975, "Thanjavu", 29 },
                    { 976, "Kancheepura", 29 },
                    { 977, "Erod", 29 },
                    { 978, "Rajapalaya", 29 },
                    { 979, "Sivakas", 29 },
                    { 980, "Pollach", 29 },
                    { 981, "Tiruvannamala", 29 },
                    { 982, "Pallikond", 29 },
                    { 983, "Peravuran", 29 },
                    { 984, "Parangipetta", 29 },
                    { 985, "Pudupattina", 29 },
                    { 986, "Punjaipugalu", 29 },
                    { 987, "Sivagir", 29 },
                    { 988, "Thirupuvana", 29 },
                    { 989, "Padmanabhapura", 29 },
                    { 990, "Mancheria", 30 },
                    { 991, "Adilaba", 30 },
                    { 992, "Mahbubnaga", 30 },
                    { 993, "Khamma", 30 },
                    { 994, "Hyderaba", 30 },
                    { 995, "Waranga", 30 },
                    { 996, "Ramagunda", 30 },
                    { 997, "Karimnaga", 30 },
                    { 998, "Nizamaba", 30 },
                    { 999, "Koratl", 30 },
                    { 1000, "Palwanch", 30 },
                    { 1001, "Tandu", 30 },
                    { 1002, "Sircill", 30 },
                    { 1003, "Mandamarr", 30 },
                    { 1004, "Siddipe", 30 },
                    { 1005, "Sangaredd", 30 },
                    { 1006, "Bellampall", 30 },
                    { 1007, "Wanaparth", 30 },
                    { 1008, "Kagaznaga", 30 },
                    { 1009, "Gadwa", 30 },
                    { 1010, "Miryalagud", 30 },
                    { 1011, "Jagtia", 30 },
                    { 1012, "Suryape", 30 },
                    { 1013, "Bodha", 30 },
                    { 1014, "Nirma", 30 },
                    { 1015, "Kamaredd", 30 },
                    { 1016, "Kothagude", 30 },
                    { 1017, "Nagarkurnoo", 30 },
                    { 1018, "Farooqnaga", 30 },
                    { 1019, "Meda", 30 },
                    { 1020, "Narayanpe", 30 },
                    { 1021, "Bhongi", 30 },
                    { 1022, "Vikaraba", 30 },
                    { 1023, "Jangao", 30 },
                    { 1024, "Bhains", 30 },
                    { 1025, "Bhadrachala", 30 },
                    { 1026, "Kyathampall", 30 },
                    { 1027, "Manugur", 30 },
                    { 1028, "Yelland", 30 },
                    { 1029, "Sadasivpe", 30 },
                    { 1030, "Udaipu", 31 },
                    { 1031, "Pratapgar", 31 },
                    { 1032, "Dharmanaga", 31 },
                    { 1033, "Agartal", 31 },
                    { 1034, "Beloni", 31 },
                    { 1035, "Khowa", 31 },
                    { 1036, "Kailasaha", 31 },
                    { 1037, "Pithoragar", 33 },
                    { 1038, "Ramnaga", 33 },
                    { 1039, "Nainita", 33 },
                    { 1040, "Manglau", 33 },
                    { 1041, "Sitargan", 33 },
                    { 1042, "Nagl", 33 },
                    { 1043, "Paur", 33 },
                    { 1044, "Tehr", 33 },
                    { 1045, "Mussoori", 33 },
                    { 1046, "Rudrapu", 33 },
                    { 1047, "Rishikes", 33 },
                    { 1048, "Srinaga", 33 },
                    { 1049, "Kashipu", 33 },
                    { 1050, "Roorke", 33 },
                    { 1051, "Haldwani-cum-Kathgoda", 33 },
                    { 1052, "Hardwa", 33 },
                    { 1053, "Dehradu", 33 },
                    { 1054, "Bageshwa", 33 },
                    { 1055, "Adr", 34 },
                    { 1056, "Srirampor", 34 },
                    { 1057, "Monoharpu", 34 },
                    { 1058, "Mathabhang", 34 },
                    { 1059, "Asanso", 34 },
                    { 1060, "Siligur", 34 },
                    { 1061, "Kolkat", 34 },
                    { 1062, "Kharagpu", 34 },
                    { 1063, "Raghunathgan", 34 },
                    { 1064, "Naihat", 34 },
                    { 1065, "English Baza", 34 },
                    { 1066, "Baharampu", 34 },
                    { 1067, "Hugli-Chinsura", 34 },
                    { 1068, "Raigan", 34 },
                    { 1069, "Jalpaigur", 34 },
                    { 1070, "Puruli", 34 },
                    { 1071, "Darjilin", 34 },
                    { 1072, "Nabadwi", 34 },
                    { 1073, "Medinipu", 34 },
                    { 1074, "Habr", 34 },
                    { 1075, "Santipu", 34 },
                    { 1076, "Balurgha", 34 },
                    { 1077, "Ranagha", 34 },
                    { 1078, "Bankur", 34 },
                    { 1079, "Tamlu", 34 },
                    { 1080, "AlipurdUrban Agglomeration", 34 },
                    { 1081, "Arambag", 34 },
                    { 1082, "Jhargra", 34 },
                    { 1083, "Sur", 34 },
                    { 1084, "Gangarampu", 34 },
                    { 1085, "Tarakeswa", 34 },
                    { 1086, "Paschim Punropar", 34 },
                    { 1087, "Sonamukh", 34 },
                    { 1088, "PandUrban Agglomeratio", 34 },
                    { 1089, "Mainagur", 34 },
                    { 1090, "Mald", 34 },
                    { 1091, "Panchl", 34 },
                    { 1092, "Raghunathpu", 34 },
                    { 1093, "Kalimpon", 34 },
                    { 1094, "Rampurha", 34 },
                    { 1095, "Tak", 34 },
                    { 1096, "Sainthi", 34 },
                    { 1097, "Murshidaba", 34 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 729);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 743);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 744);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 745);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 746);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 747);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 748);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 750);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 752);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 753);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 754);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 757);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 758);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 759);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 760);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 765);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 766);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 767);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 768);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 769);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 770);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 771);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 773);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 774);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 775);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 776);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 778);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 779);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 780);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 781);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 782);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 783);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 784);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 785);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 786);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 787);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 788);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 789);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 790);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 791);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 792);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 793);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 794);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 795);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 797);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 798);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 799);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 800);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 801);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 802);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 803);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 804);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 805);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 806);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 807);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 808);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 809);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 810);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 811);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 812);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 813);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 814);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 815);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 816);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 817);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 818);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 819);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 820);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 821);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 822);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 823);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 824);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 825);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 826);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 827);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 828);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 829);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 830);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 831);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 832);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 833);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 834);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 835);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 836);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 837);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 838);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 839);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 840);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 841);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 842);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 843);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 844);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 845);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 846);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 847);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 848);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 849);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 850);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 851);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 852);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 853);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 854);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 855);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 856);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 857);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 858);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 859);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 860);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 861);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 862);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 863);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 864);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 865);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 866);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 867);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 868);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 869);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 870);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 871);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 872);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 873);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 874);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 875);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 876);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 877);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 878);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 879);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 880);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 881);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 882);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 883);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 884);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 885);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 886);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 887);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 888);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 889);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 890);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 891);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 892);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 893);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 894);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 895);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 896);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 897);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 898);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 899);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 900);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 901);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 902);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 903);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 904);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 905);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 906);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 907);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 908);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 909);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 910);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 911);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 912);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 913);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 914);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 915);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 916);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 917);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 918);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 919);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 920);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 921);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 922);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 923);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 924);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 925);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 926);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 927);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 928);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 929);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 930);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 931);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 932);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 933);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 934);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 935);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 936);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 937);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 938);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 939);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 940);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 941);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 942);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 943);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 944);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 945);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 946);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 947);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 948);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 949);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 950);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 951);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 952);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 953);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 954);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 955);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 956);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 957);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 958);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 959);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 960);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 961);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 962);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 963);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 964);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 965);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 966);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 967);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 968);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 969);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 970);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 971);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 972);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 973);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 974);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 975);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 976);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 977);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 978);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 979);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 980);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 981);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 982);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 983);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 984);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 985);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 986);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 987);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 988);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 989);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 990);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 991);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 992);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 993);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 994);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 995);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 996);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 997);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 998);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 999);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1000);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1001);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1002);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1003);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1004);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1005);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1006);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1007);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1008);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1009);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1010);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1011);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1012);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1013);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1014);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1015);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1016);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1017);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1018);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1019);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1020);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1021);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1022);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1023);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1024);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1025);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1026);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1027);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1028);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1029);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1030);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1031);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1032);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1033);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1034);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1035);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1036);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1037);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1038);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1039);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1040);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1041);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1042);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1043);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1044);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1045);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1046);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1047);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1048);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1049);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1050);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1051);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1052);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1053);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1054);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1055);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1056);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1057);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1058);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1059);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1060);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1061);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1062);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1063);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1064);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1065);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1066);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1067);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1068);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1069);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1070);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1071);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1072);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1073);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1074);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1075);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1076);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1077);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1078);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1079);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1080);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1081);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1082);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1083);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1084);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1085);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1086);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1087);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1088);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1089);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1090);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1091);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1092);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1093);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1094);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1095);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1096);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 1097);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 203,
                column: "Name",
                value: "New Delh");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "UniqueId",
                keyValue: 204,
                column: "Name",
                value: "Delh");
        }
    }
}
