using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TemplateFramework.Infastructure.Migrations
{
    /// <inheritdoc />
    public partial class db5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "Price", "UpdatedAt" },
                values: new object[,]
                {
                    { -100, new DateTime(2024, 7, 18, 14, 29, 37, 431, DateTimeKind.Local).AddTicks(1599), "Ipsum adipisci cumque eum possimus.", "Intelligent Metal Pizza", 346.21m, new DateTime(2025, 6, 2, 20, 19, 55, 607, DateTimeKind.Local).AddTicks(2161) },
                    { -99, new DateTime(2024, 6, 9, 9, 7, 17, 242, DateTimeKind.Local).AddTicks(6004), "Eius quia id aut voluptas perspiciatis minus delectus.", "Handcrafted Frozen Pizza", 11.88m, new DateTime(2025, 6, 3, 8, 51, 34, 968, DateTimeKind.Local).AddTicks(7395) },
                    { -98, new DateTime(2024, 9, 24, 1, 22, 1, 926, DateTimeKind.Local).AddTicks(7837), "Tenetur id quod nam similique autem ut in recusandae.", "Generic Steel Bacon", 411.86m, new DateTime(2025, 6, 3, 6, 57, 30, 155, DateTimeKind.Local).AddTicks(3503) },
                    { -97, new DateTime(2024, 12, 17, 21, 58, 45, 764, DateTimeKind.Local).AddTicks(9150), "Quasi a quibusdam.", "Generic Granite Sausages", 511.29m, new DateTime(2025, 6, 2, 15, 28, 29, 577, DateTimeKind.Local).AddTicks(4386) },
                    { -96, new DateTime(2025, 5, 19, 18, 19, 20, 663, DateTimeKind.Local).AddTicks(8540), "Rem atque et consequuntur aliquid tempore.", "Ergonomic Concrete Chicken", 309.25m, new DateTime(2025, 6, 2, 12, 47, 31, 75, DateTimeKind.Local).AddTicks(3978) },
                    { -95, new DateTime(2024, 9, 30, 2, 41, 3, 515, DateTimeKind.Local).AddTicks(5527), "Voluptatibus similique voluptatem quod deleniti et.", "Fantastic Frozen Gloves", 672.01m, new DateTime(2025, 6, 3, 2, 29, 0, 687, DateTimeKind.Local).AddTicks(9556) },
                    { -94, new DateTime(2025, 5, 22, 2, 53, 11, 766, DateTimeKind.Local).AddTicks(6662), "Iste blanditiis omnis labore rerum omnis atque occaecati.", "Practical Wooden Sausages", 472.86m, new DateTime(2025, 6, 2, 13, 26, 17, 98, DateTimeKind.Local).AddTicks(3699) },
                    { -93, new DateTime(2025, 5, 19, 7, 59, 19, 145, DateTimeKind.Local).AddTicks(3044), "Maxime corporis aut reprehenderit aspernatur voluptas et.", "Unbranded Wooden Pizza", 287.31m, new DateTime(2025, 6, 2, 23, 8, 41, 849, DateTimeKind.Local).AddTicks(4586) },
                    { -92, new DateTime(2025, 1, 5, 21, 52, 13, 486, DateTimeKind.Local).AddTicks(6817), "Omnis praesentium sit cupiditate.", "Refined Fresh Chair", 807.24m, new DateTime(2025, 6, 2, 19, 12, 28, 47, DateTimeKind.Local).AddTicks(6286) },
                    { -91, new DateTime(2024, 6, 21, 0, 44, 3, 256, DateTimeKind.Local).AddTicks(7899), "Explicabo sed ipsa iure explicabo vitae quidem alias optio.", "Tasty Concrete Shoes", 206.32m, new DateTime(2025, 6, 2, 17, 3, 31, 885, DateTimeKind.Local).AddTicks(5680) },
                    { -90, new DateTime(2025, 4, 24, 12, 58, 53, 999, DateTimeKind.Local).AddTicks(5247), "Consequatur et alias voluptatem in nulla molestiae quaerat vero vel.", "Handmade Concrete Shirt", 358.37m, new DateTime(2025, 6, 3, 3, 11, 47, 956, DateTimeKind.Local).AddTicks(5315) },
                    { -89, new DateTime(2025, 3, 4, 20, 27, 50, 71, DateTimeKind.Local).AddTicks(3742), "Officia laborum ut qui sunt.", "Intelligent Wooden Table", 941.24m, new DateTime(2025, 6, 3, 2, 17, 56, 27, DateTimeKind.Local).AddTicks(6012) },
                    { -88, new DateTime(2025, 2, 6, 5, 2, 46, 567, DateTimeKind.Local).AddTicks(5795), "Molestiae quo et.", "Practical Steel Soap", 462.42m, new DateTime(2025, 6, 3, 4, 15, 59, 413, DateTimeKind.Local).AddTicks(3481) },
                    { -87, new DateTime(2025, 4, 9, 14, 14, 3, 350, DateTimeKind.Local).AddTicks(4282), "Quis veniam dolor molestias error dolores quo quam doloremque.", "Sleek Plastic Chair", 636.02m, new DateTime(2025, 6, 2, 18, 46, 28, 386, DateTimeKind.Local).AddTicks(1223) },
                    { -86, new DateTime(2025, 5, 29, 4, 47, 33, 826, DateTimeKind.Local).AddTicks(8633), "Inventore perferendis consectetur.", "Unbranded Rubber Fish", 210.65m, new DateTime(2025, 6, 3, 4, 37, 21, 949, DateTimeKind.Local).AddTicks(9538) },
                    { -85, new DateTime(2025, 4, 16, 19, 18, 38, 689, DateTimeKind.Local).AddTicks(5797), "Sit unde deserunt.", "Tasty Plastic Sausages", 75.91m, new DateTime(2025, 6, 2, 11, 49, 36, 371, DateTimeKind.Local).AddTicks(4561) },
                    { -84, new DateTime(2024, 7, 21, 1, 43, 19, 846, DateTimeKind.Local).AddTicks(1010), "Odit officiis qui nihil ut tempore voluptatem.", "Unbranded Concrete Keyboard", 781.50m, new DateTime(2025, 6, 3, 5, 5, 9, 463, DateTimeKind.Local).AddTicks(9948) },
                    { -83, new DateTime(2025, 1, 11, 2, 6, 29, 7, DateTimeKind.Local).AddTicks(6840), "Suscipit est et dignissimos.", "Tasty Granite Computer", 153.06m, new DateTime(2025, 6, 2, 20, 59, 5, 526, DateTimeKind.Local).AddTicks(327) },
                    { -82, new DateTime(2025, 3, 17, 2, 51, 41, 292, DateTimeKind.Local).AddTicks(3501), "Asperiores aut non mollitia quae sunt beatae voluptatem quia quia.", "Small Wooden Shoes", 243.02m, new DateTime(2025, 6, 3, 10, 47, 20, 733, DateTimeKind.Local).AddTicks(2344) },
                    { -81, new DateTime(2025, 2, 16, 23, 20, 49, 746, DateTimeKind.Local).AddTicks(474), "Eveniet beatae sit.", "Incredible Metal Car", 199.77m, new DateTime(2025, 6, 3, 3, 2, 59, 175, DateTimeKind.Local).AddTicks(4229) },
                    { -80, new DateTime(2024, 10, 9, 14, 14, 12, 257, DateTimeKind.Local).AddTicks(1099), "Aperiam quia fuga nam consequatur et voluptatem maiores.", "Sleek Soft Pants", 968.05m, new DateTime(2025, 6, 3, 0, 14, 18, 950, DateTimeKind.Local).AddTicks(3178) },
                    { -79, new DateTime(2024, 6, 22, 6, 26, 43, 518, DateTimeKind.Local).AddTicks(8642), "Sit est sunt nihil corporis.", "Ergonomic Metal Sausages", 853.34m, new DateTime(2025, 6, 3, 3, 42, 17, 512, DateTimeKind.Local).AddTicks(3144) },
                    { -78, new DateTime(2024, 10, 12, 1, 23, 42, 626, DateTimeKind.Local).AddTicks(8717), "Voluptatem sunt soluta dignissimos nesciunt distinctio nihil odit.", "Licensed Fresh Pizza", 510.81m, new DateTime(2025, 6, 2, 21, 15, 45, 689, DateTimeKind.Local).AddTicks(8112) },
                    { -77, new DateTime(2024, 7, 29, 10, 38, 42, 183, DateTimeKind.Local).AddTicks(4457), "Odit est quibusdam consequuntur dolores voluptatum et occaecati illo.", "Awesome Granite Bike", 924.15m, new DateTime(2025, 6, 2, 23, 9, 0, 411, DateTimeKind.Local).AddTicks(5906) },
                    { -76, new DateTime(2025, 2, 20, 7, 11, 12, 391, DateTimeKind.Local).AddTicks(2376), "Est molestias nihil nesciunt enim aut odio dolore necessitatibus.", "Handcrafted Cotton Pizza", 908.28m, new DateTime(2025, 6, 3, 6, 25, 10, 168, DateTimeKind.Local).AddTicks(2344) },
                    { -75, new DateTime(2024, 6, 27, 3, 36, 49, 317, DateTimeKind.Local).AddTicks(361), "Neque dolor voluptatem voluptatem vel nemo illo.", "Rustic Rubber Cheese", 157.06m, new DateTime(2025, 6, 2, 23, 46, 13, 83, DateTimeKind.Local).AddTicks(7407) },
                    { -74, new DateTime(2024, 7, 31, 23, 17, 18, 840, DateTimeKind.Local).AddTicks(4569), "Voluptatem nostrum aperiam pariatur in perferendis est dolorem.", "Sleek Metal Chicken", 602.23m, new DateTime(2025, 6, 3, 5, 51, 38, 287, DateTimeKind.Local).AddTicks(5272) },
                    { -73, new DateTime(2025, 3, 6, 1, 17, 15, 887, DateTimeKind.Local).AddTicks(6835), "Nam vel beatae velit laboriosam inventore consectetur aut id deleniti.", "Intelligent Soft Towels", 87.55m, new DateTime(2025, 6, 3, 11, 12, 17, 150, DateTimeKind.Local).AddTicks(4724) },
                    { -72, new DateTime(2024, 8, 2, 17, 24, 26, 736, DateTimeKind.Local).AddTicks(2482), "Ea omnis voluptatum nam mollitia aut est porro.", "Handcrafted Granite Keyboard", 504.90m, new DateTime(2025, 6, 2, 16, 8, 23, 269, DateTimeKind.Local).AddTicks(2007) },
                    { -71, new DateTime(2025, 4, 6, 19, 2, 20, 127, DateTimeKind.Local).AddTicks(2862), "Dolore consequatur voluptas qui.", "Small Soft Bacon", 731.00m, new DateTime(2025, 6, 3, 6, 18, 32, 806, DateTimeKind.Local).AddTicks(8544) },
                    { -70, new DateTime(2024, 6, 26, 0, 30, 57, 804, DateTimeKind.Local).AddTicks(3414), "Qui dolor et.", "Ergonomic Metal Keyboard", 246.34m, new DateTime(2025, 6, 2, 21, 31, 55, 211, DateTimeKind.Local).AddTicks(1261) },
                    { -69, new DateTime(2024, 8, 20, 22, 3, 26, 755, DateTimeKind.Local).AddTicks(9032), "Debitis quos vel quae.", "Licensed Plastic Pizza", 136.36m, new DateTime(2025, 6, 2, 15, 19, 33, 701, DateTimeKind.Local).AddTicks(6363) },
                    { -68, new DateTime(2025, 1, 22, 5, 39, 1, 749, DateTimeKind.Local).AddTicks(7048), "Inventore quia ut exercitationem saepe qui.", "Incredible Cotton Sausages", 989.31m, new DateTime(2025, 6, 2, 18, 33, 27, 614, DateTimeKind.Local).AddTicks(5972) },
                    { -67, new DateTime(2024, 10, 1, 20, 24, 27, 684, DateTimeKind.Local).AddTicks(5292), "Enim quidem enim asperiores nihil ea consequatur eum et.", "Tasty Frozen Shirt", 838.78m, new DateTime(2025, 6, 2, 23, 27, 27, 379, DateTimeKind.Local).AddTicks(8741) },
                    { -66, new DateTime(2025, 1, 24, 3, 39, 32, 982, DateTimeKind.Local).AddTicks(4485), "Ex eaque est accusantium omnis.", "Intelligent Granite Car", 626.00m, new DateTime(2025, 6, 2, 21, 14, 26, 124, DateTimeKind.Local).AddTicks(7366) },
                    { -65, new DateTime(2024, 12, 8, 23, 33, 35, 179, DateTimeKind.Local).AddTicks(2625), "Velit ut a et rem aut quam sunt blanditiis.", "Handcrafted Plastic Cheese", 369.89m, new DateTime(2025, 6, 3, 9, 39, 25, 147, DateTimeKind.Local).AddTicks(2523) },
                    { -64, new DateTime(2024, 7, 12, 15, 14, 21, 309, DateTimeKind.Local).AddTicks(8143), "Doloremque officiis quod doloremque enim quas vel.", "Handmade Plastic Computer", 353.71m, new DateTime(2025, 6, 2, 17, 49, 16, 748, DateTimeKind.Local).AddTicks(8713) },
                    { -63, new DateTime(2024, 12, 21, 17, 26, 13, 929, DateTimeKind.Local).AddTicks(4190), "Sequi voluptatem voluptatem impedit temporibus.", "Licensed Frozen Chicken", 835.08m, new DateTime(2025, 6, 2, 21, 49, 3, 34, DateTimeKind.Local).AddTicks(6930) },
                    { -62, new DateTime(2025, 4, 9, 18, 58, 47, 360, DateTimeKind.Local).AddTicks(6099), "Adipisci quia eveniet maxime deleniti omnis praesentium est.", "Refined Plastic Keyboard", 892.03m, new DateTime(2025, 6, 3, 2, 4, 13, 140, DateTimeKind.Local).AddTicks(1773) },
                    { -61, new DateTime(2024, 7, 21, 20, 46, 48, 56, DateTimeKind.Local).AddTicks(8632), "Vero et fugiat sit ad molestiae dolore.", "Handmade Soft Tuna", 648.74m, new DateTime(2025, 6, 2, 14, 31, 30, 141, DateTimeKind.Local).AddTicks(7242) },
                    { -60, new DateTime(2024, 7, 24, 11, 3, 6, 794, DateTimeKind.Local).AddTicks(3841), "Doloribus omnis et consequuntur occaecati minus.", "Refined Fresh Computer", 287.69m, new DateTime(2025, 6, 2, 23, 18, 46, 502, DateTimeKind.Local).AddTicks(1009) },
                    { -59, new DateTime(2024, 9, 4, 0, 40, 23, 411, DateTimeKind.Local).AddTicks(4733), "Id qui illo dolorem blanditiis facilis repellendus aut error molestiae.", "Handcrafted Plastic Shoes", 409.99m, new DateTime(2025, 6, 3, 5, 29, 27, 61, DateTimeKind.Local).AddTicks(8900) },
                    { -58, new DateTime(2025, 2, 6, 18, 52, 44, 157, DateTimeKind.Local).AddTicks(1827), "Mollitia voluptas sint ut eligendi in corrupti et quis itaque.", "Handmade Cotton Shirt", 100.70m, new DateTime(2025, 6, 2, 20, 25, 44, 567, DateTimeKind.Local).AddTicks(8830) },
                    { -57, new DateTime(2025, 1, 11, 22, 41, 46, 866, DateTimeKind.Local).AddTicks(8063), "Et possimus at ut quam consequatur quisquam.", "Incredible Cotton Chair", 62.04m, new DateTime(2025, 6, 2, 15, 29, 21, 666, DateTimeKind.Local).AddTicks(2278) },
                    { -56, new DateTime(2024, 9, 25, 4, 36, 8, 330, DateTimeKind.Local).AddTicks(6331), "Vitae est ea voluptas sed ut cupiditate officia magni.", "Gorgeous Fresh Chicken", 133.98m, new DateTime(2025, 6, 3, 1, 14, 32, 142, DateTimeKind.Local).AddTicks(4505) },
                    { -55, new DateTime(2025, 2, 6, 15, 57, 57, 38, DateTimeKind.Local).AddTicks(1632), "Neque laborum nobis.", "Gorgeous Rubber Cheese", 95.22m, new DateTime(2025, 6, 2, 23, 16, 0, 802, DateTimeKind.Local).AddTicks(1704) },
                    { -54, new DateTime(2024, 10, 26, 7, 25, 15, 76, DateTimeKind.Local).AddTicks(5819), "Aut maiores voluptas consectetur delectus est assumenda minus ut sint.", "Unbranded Wooden Tuna", 45.56m, new DateTime(2025, 6, 2, 14, 58, 53, 871, DateTimeKind.Local).AddTicks(1229) },
                    { -53, new DateTime(2024, 12, 14, 2, 45, 1, 286, DateTimeKind.Local).AddTicks(2204), "Rerum repellat eum iusto accusantium et harum.", "Awesome Metal Hat", 62.38m, new DateTime(2025, 6, 3, 2, 42, 40, 721, DateTimeKind.Local).AddTicks(2366) },
                    { -52, new DateTime(2025, 5, 4, 10, 11, 11, 310, DateTimeKind.Local).AddTicks(5591), "Ut suscipit qui debitis quibusdam dolor.", "Handcrafted Concrete Pants", 248.58m, new DateTime(2025, 6, 2, 21, 16, 32, 760, DateTimeKind.Local).AddTicks(4739) },
                    { -51, new DateTime(2025, 4, 6, 7, 36, 42, 611, DateTimeKind.Local).AddTicks(3562), "Et temporibus sint consequatur.", "Awesome Rubber Salad", 905.42m, new DateTime(2025, 6, 3, 1, 31, 23, 508, DateTimeKind.Local).AddTicks(1835) },
                    { -50, new DateTime(2025, 5, 28, 16, 32, 53, 458, DateTimeKind.Local).AddTicks(8754), "Facere dolores aliquid.", "Licensed Rubber Chair", 343.56m, new DateTime(2025, 6, 2, 17, 40, 1, 196, DateTimeKind.Local).AddTicks(1923) },
                    { -49, new DateTime(2024, 11, 23, 8, 26, 28, 759, DateTimeKind.Local).AddTicks(3401), "Enim porro velit ad rerum qui harum dolorum voluptatum.", "Handcrafted Metal Chair", 368.66m, new DateTime(2025, 6, 2, 23, 15, 11, 746, DateTimeKind.Local).AddTicks(8544) },
                    { -48, new DateTime(2024, 10, 4, 3, 49, 4, 311, DateTimeKind.Local).AddTicks(2196), "Excepturi culpa perspiciatis voluptatibus repellendus expedita voluptatem aspernatur.", "Small Granite Salad", 65.12m, new DateTime(2025, 6, 3, 3, 47, 43, 546, DateTimeKind.Local).AddTicks(8914) },
                    { -47, new DateTime(2025, 5, 20, 10, 32, 22, 269, DateTimeKind.Local).AddTicks(6557), "Distinctio dolorem magni.", "Practical Plastic Shirt", 53.25m, new DateTime(2025, 6, 3, 5, 25, 35, 636, DateTimeKind.Local).AddTicks(4808) },
                    { -46, new DateTime(2024, 12, 30, 23, 9, 4, 75, DateTimeKind.Local).AddTicks(8395), "Est architecto voluptatem.", "Rustic Wooden Sausages", 128.79m, new DateTime(2025, 6, 3, 8, 23, 42, 722, DateTimeKind.Local).AddTicks(9336) },
                    { -45, new DateTime(2024, 11, 18, 4, 25, 35, 853, DateTimeKind.Local).AddTicks(4839), "Deleniti quis facere quisquam veniam reiciendis ab fuga doloremque.", "Handmade Cotton Chair", 568.02m, new DateTime(2025, 6, 3, 1, 8, 57, 439, DateTimeKind.Local).AddTicks(1244) },
                    { -44, new DateTime(2025, 1, 19, 16, 39, 19, 823, DateTimeKind.Local).AddTicks(1791), "Repudiandae tenetur est.", "Incredible Steel Ball", 855.06m, new DateTime(2025, 6, 2, 23, 4, 0, 754, DateTimeKind.Local).AddTicks(7248) },
                    { -43, new DateTime(2024, 10, 10, 21, 4, 12, 909, DateTimeKind.Local).AddTicks(8445), "Ullam architecto et est ipsum sunt nemo neque.", "Incredible Rubber Car", 443.84m, new DateTime(2025, 6, 2, 14, 25, 13, 93, DateTimeKind.Local).AddTicks(2729) },
                    { -42, new DateTime(2024, 11, 27, 8, 13, 18, 203, DateTimeKind.Local).AddTicks(4498), "Ratione praesentium et excepturi odit recusandae reprehenderit.", "Handcrafted Frozen Chips", 209.97m, new DateTime(2025, 6, 3, 5, 52, 48, 390, DateTimeKind.Local).AddTicks(9944) },
                    { -41, new DateTime(2024, 10, 15, 8, 57, 54, 559, DateTimeKind.Local).AddTicks(5071), "Sint aut eos sed.", "Incredible Cotton Mouse", 211.66m, new DateTime(2025, 6, 3, 1, 54, 5, 261, DateTimeKind.Local).AddTicks(2420) },
                    { -40, new DateTime(2025, 1, 12, 16, 49, 59, 249, DateTimeKind.Local).AddTicks(6369), "Itaque perferendis iusto odio.", "Incredible Granite Chair", 275.82m, new DateTime(2025, 6, 2, 14, 9, 30, 420, DateTimeKind.Local).AddTicks(3220) },
                    { -39, new DateTime(2025, 4, 17, 20, 7, 29, 882, DateTimeKind.Local).AddTicks(6494), "Voluptates neque aut corrupti.", "Tasty Metal Shirt", 245.62m, new DateTime(2025, 6, 3, 3, 50, 57, 606, DateTimeKind.Local).AddTicks(5548) },
                    { -38, new DateTime(2024, 6, 11, 14, 11, 27, 633, DateTimeKind.Local).AddTicks(6106), "Molestiae aut voluptatem.", "Rustic Metal Bacon", 220.01m, new DateTime(2025, 6, 3, 6, 53, 11, 117, DateTimeKind.Local).AddTicks(5208) },
                    { -37, new DateTime(2024, 6, 17, 21, 4, 33, 685, DateTimeKind.Local).AddTicks(618), "Consequuntur pariatur quo dolorem in amet qui.", "Generic Cotton Mouse", 273.59m, new DateTime(2025, 6, 2, 13, 14, 3, 227, DateTimeKind.Local).AddTicks(7132) },
                    { -36, new DateTime(2024, 12, 3, 6, 59, 17, 513, DateTimeKind.Local).AddTicks(6282), "Autem quidem doloribus voluptatem quo sunt.", "Practical Cotton Fish", 328.24m, new DateTime(2025, 6, 2, 16, 48, 6, 26, DateTimeKind.Local).AddTicks(3045) },
                    { -35, new DateTime(2025, 4, 14, 0, 58, 36, 511, DateTimeKind.Local).AddTicks(4217), "Sit aliquam soluta.", "Rustic Frozen Hat", 25.93m, new DateTime(2025, 6, 2, 15, 44, 46, 857, DateTimeKind.Local).AddTicks(8271) },
                    { -34, new DateTime(2025, 3, 8, 5, 3, 1, 361, DateTimeKind.Local).AddTicks(4261), "Omnis dolorem rerum error mollitia ea rerum.", "Practical Concrete Salad", 611.51m, new DateTime(2025, 6, 2, 15, 20, 55, 612, DateTimeKind.Local).AddTicks(1118) },
                    { -33, new DateTime(2024, 10, 31, 7, 27, 37, 822, DateTimeKind.Local).AddTicks(200), "Repudiandae veritatis saepe repellendus facere.", "Handmade Frozen Table", 922.25m, new DateTime(2025, 6, 2, 23, 27, 16, 907, DateTimeKind.Local).AddTicks(7018) },
                    { -32, new DateTime(2024, 12, 22, 23, 30, 4, 565, DateTimeKind.Local).AddTicks(6733), "Qui laborum ex quos beatae fugit incidunt nihil non perspiciatis.", "Incredible Granite Mouse", 399.51m, new DateTime(2025, 6, 2, 13, 33, 23, 941, DateTimeKind.Local).AddTicks(67) },
                    { -31, new DateTime(2024, 10, 1, 20, 27, 30, 239, DateTimeKind.Local).AddTicks(1062), "Voluptatem illo quidem.", "Fantastic Soft Pants", 208.44m, new DateTime(2025, 6, 2, 17, 37, 54, 729, DateTimeKind.Local).AddTicks(1991) },
                    { -30, new DateTime(2024, 9, 25, 11, 2, 22, 450, DateTimeKind.Local).AddTicks(6881), "Et reiciendis odio minus.", "Handmade Plastic Chips", 992.58m, new DateTime(2025, 6, 2, 14, 53, 34, 334, DateTimeKind.Local).AddTicks(981) },
                    { -29, new DateTime(2024, 9, 23, 6, 19, 24, 166, DateTimeKind.Local).AddTicks(2567), "Doloremque dolore deleniti soluta.", "Incredible Wooden Pants", 850.70m, new DateTime(2025, 6, 3, 9, 20, 38, 416, DateTimeKind.Local).AddTicks(7048) },
                    { -28, new DateTime(2024, 8, 9, 16, 23, 58, 806, DateTimeKind.Local).AddTicks(4779), "Doloremque est ullam dicta.", "Small Frozen Chair", 459.33m, new DateTime(2025, 6, 3, 6, 24, 6, 495, DateTimeKind.Local).AddTicks(8080) },
                    { -27, new DateTime(2024, 9, 18, 22, 30, 40, 116, DateTimeKind.Local).AddTicks(6479), "Itaque maiores magni voluptatem unde.", "Incredible Frozen Ball", 990.06m, new DateTime(2025, 6, 3, 0, 49, 58, 451, DateTimeKind.Local).AddTicks(6206) },
                    { -26, new DateTime(2025, 3, 4, 13, 4, 23, 516, DateTimeKind.Local).AddTicks(9274), "Cumque sed et laboriosam non sit omnis dolor officia.", "Handmade Soft Bacon", 917.20m, new DateTime(2025, 6, 2, 16, 1, 36, 564, DateTimeKind.Local).AddTicks(5678) },
                    { -25, new DateTime(2024, 9, 2, 17, 51, 58, 18, DateTimeKind.Local).AddTicks(2260), "Hic ut laboriosam minima in nam quo atque dicta vitae.", "Licensed Soft Towels", 874.17m, new DateTime(2025, 6, 3, 1, 47, 32, 18, DateTimeKind.Local).AddTicks(5884) },
                    { -24, new DateTime(2025, 1, 19, 19, 21, 35, 444, DateTimeKind.Local).AddTicks(6373), "Officia ut molestiae ea laudantium numquam voluptatibus possimus.", "Sleek Frozen Soap", 973.84m, new DateTime(2025, 6, 2, 20, 49, 19, 100, DateTimeKind.Local).AddTicks(6071) },
                    { -23, new DateTime(2024, 6, 5, 1, 11, 19, 158, DateTimeKind.Local).AddTicks(5381), "Repudiandae in pariatur.", "Awesome Fresh Cheese", 876.12m, new DateTime(2025, 6, 2, 22, 20, 36, 657, DateTimeKind.Local).AddTicks(5344) },
                    { -22, new DateTime(2025, 2, 16, 8, 43, 51, 731, DateTimeKind.Local).AddTicks(2404), "Reiciendis eligendi delectus in cum dignissimos.", "Incredible Rubber Keyboard", 500.01m, new DateTime(2025, 6, 2, 12, 45, 17, 640, DateTimeKind.Local).AddTicks(6449) },
                    { -21, new DateTime(2024, 10, 1, 12, 7, 53, 377, DateTimeKind.Local).AddTicks(1254), "Exercitationem dignissimos quo atque cum dolor magnam.", "Rustic Metal Soap", 617.04m, new DateTime(2025, 6, 3, 9, 21, 29, 539, DateTimeKind.Local).AddTicks(8908) },
                    { -20, new DateTime(2024, 6, 15, 15, 53, 50, 180, DateTimeKind.Local).AddTicks(7714), "Nihil amet vel autem impedit amet in laboriosam unde.", "Unbranded Soft Soap", 945.31m, new DateTime(2025, 6, 2, 16, 31, 47, 145, DateTimeKind.Local).AddTicks(5929) },
                    { -19, new DateTime(2024, 11, 7, 3, 38, 16, 636, DateTimeKind.Local).AddTicks(9468), "Eum molestiae voluptates ipsam voluptatem nobis.", "Licensed Metal Keyboard", 358.79m, new DateTime(2025, 6, 2, 17, 58, 12, 203, DateTimeKind.Local).AddTicks(105) },
                    { -18, new DateTime(2025, 5, 20, 11, 34, 50, 610, DateTimeKind.Local).AddTicks(6011), "Dolorem facere qui qui tempore.", "Licensed Soft Computer", 467.51m, new DateTime(2025, 6, 2, 11, 25, 27, 475, DateTimeKind.Local).AddTicks(3011) },
                    { -17, new DateTime(2024, 10, 29, 6, 30, 30, 283, DateTimeKind.Local).AddTicks(5053), "Reiciendis consequatur beatae ipsam blanditiis est deserunt.", "Awesome Rubber Car", 179.42m, new DateTime(2025, 6, 2, 13, 52, 53, 404, DateTimeKind.Local).AddTicks(2258) },
                    { -16, new DateTime(2024, 12, 27, 6, 47, 13, 611, DateTimeKind.Local).AddTicks(5296), "Inventore accusantium voluptas est at.", "Handcrafted Concrete Chips", 275.21m, new DateTime(2025, 6, 3, 6, 36, 45, 228, DateTimeKind.Local).AddTicks(8773) },
                    { -15, new DateTime(2024, 10, 8, 5, 27, 46, 256, DateTimeKind.Local).AddTicks(2796), "Soluta rerum iste qui rerum qui laborum deleniti quae debitis.", "Gorgeous Rubber Computer", 422.36m, new DateTime(2025, 6, 2, 14, 46, 36, 737, DateTimeKind.Local).AddTicks(1576) },
                    { -14, new DateTime(2024, 10, 1, 20, 23, 16, 10, DateTimeKind.Local).AddTicks(5116), "Odio rerum voluptate eaque dolorem odio ipsam.", "Gorgeous Concrete Soap", 487.63m, new DateTime(2025, 6, 2, 13, 46, 48, 671, DateTimeKind.Local).AddTicks(6953) },
                    { -13, new DateTime(2024, 6, 15, 20, 3, 55, 717, DateTimeKind.Local).AddTicks(892), "Soluta autem aut illum iusto illo quidem nisi.", "Licensed Metal Chicken", 827.49m, new DateTime(2025, 6, 3, 3, 55, 48, 266, DateTimeKind.Local).AddTicks(255) },
                    { -12, new DateTime(2024, 6, 8, 10, 13, 51, 100, DateTimeKind.Local).AddTicks(9558), "Ut assumenda quidem nisi magnam accusamus ratione asperiores et.", "Small Fresh Shoes", 282.94m, new DateTime(2025, 6, 3, 6, 39, 38, 10, DateTimeKind.Local).AddTicks(8885) },
                    { -11, new DateTime(2025, 2, 5, 11, 1, 14, 685, DateTimeKind.Local).AddTicks(1660), "Aperiam aut deserunt quod nam eos.", "Tasty Wooden Ball", 712.73m, new DateTime(2025, 6, 2, 17, 34, 6, 537, DateTimeKind.Local).AddTicks(1458) },
                    { -10, new DateTime(2025, 4, 19, 13, 41, 2, 670, DateTimeKind.Local).AddTicks(7193), "Rerum saepe enim cupiditate blanditiis exercitationem est ab sed est.", "Sleek Soft Salad", 968.75m, new DateTime(2025, 6, 3, 6, 19, 55, 594, DateTimeKind.Local).AddTicks(5885) },
                    { -9, new DateTime(2024, 11, 12, 4, 32, 8, 857, DateTimeKind.Local).AddTicks(8178), "Ea temporibus non eaque suscipit dolorum dolor.", "Licensed Plastic Shirt", 710.31m, new DateTime(2025, 6, 2, 13, 33, 55, 481, DateTimeKind.Local).AddTicks(3887) },
                    { -8, new DateTime(2025, 1, 14, 8, 28, 1, 531, DateTimeKind.Local).AddTicks(5287), "Et cupiditate eveniet id.", "Practical Fresh Towels", 120.48m, new DateTime(2025, 6, 2, 16, 44, 20, 758, DateTimeKind.Local).AddTicks(2741) },
                    { -7, new DateTime(2025, 5, 8, 20, 44, 6, 511, DateTimeKind.Local).AddTicks(1835), "Architecto quisquam quo illum doloribus quaerat voluptatem quibusdam provident autem.", "Handcrafted Wooden Chair", 923.33m, new DateTime(2025, 6, 3, 7, 37, 18, 633, DateTimeKind.Local).AddTicks(8226) },
                    { -6, new DateTime(2025, 3, 27, 22, 7, 44, 191, DateTimeKind.Local).AddTicks(7710), "Quos occaecati et ut asperiores et tempore.", "Rustic Frozen Sausages", 596.92m, new DateTime(2025, 6, 2, 12, 36, 58, 777, DateTimeKind.Local).AddTicks(5161) },
                    { -5, new DateTime(2025, 1, 2, 10, 19, 13, 537, DateTimeKind.Local).AddTicks(4601), "Asperiores officia exercitationem repudiandae reprehenderit tenetur deserunt.", "Unbranded Soft Pizza", 918.71m, new DateTime(2025, 6, 3, 4, 28, 29, 869, DateTimeKind.Local).AddTicks(8238) },
                    { -4, new DateTime(2024, 8, 2, 17, 1, 19, 2, DateTimeKind.Local).AddTicks(7439), "Reprehenderit nam facilis blanditiis.", "Handmade Metal Soap", 445.29m, new DateTime(2025, 6, 2, 23, 45, 32, 595, DateTimeKind.Local).AddTicks(290) },
                    { -3, new DateTime(2025, 4, 23, 0, 44, 22, 424, DateTimeKind.Local).AddTicks(1094), "Delectus corrupti ut.", "Sleek Plastic Shirt", 543.79m, new DateTime(2025, 6, 2, 19, 10, 18, 240, DateTimeKind.Local).AddTicks(6238) },
                    { -2, new DateTime(2025, 4, 24, 7, 14, 45, 730, DateTimeKind.Local).AddTicks(8334), "A est modi provident occaecati.", "Small Concrete Pants", 652.02m, new DateTime(2025, 6, 3, 11, 4, 57, 851, DateTimeKind.Local).AddTicks(5249) },
                    { -1, new DateTime(2024, 12, 23, 14, 42, 59, 678, DateTimeKind.Local).AddTicks(8355), "Accusantium nihil occaecati accusantium inventore tenetur molestias.", "Licensed Steel Hat", 968.46m, new DateTime(2025, 6, 3, 1, 7, 42, 932, DateTimeKind.Local).AddTicks(3459) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -100);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -99);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -98);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -97);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -96);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -95);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -94);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -93);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -92);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -91);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -90);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -89);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -88);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -87);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -86);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -85);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -84);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -83);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -82);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -81);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -80);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -79);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -78);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -77);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -76);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -75);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -74);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -73);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -72);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -71);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -70);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -69);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -68);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -67);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -66);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -65);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -64);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -63);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -62);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -61);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -60);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -59);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -58);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -57);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -56);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -55);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -54);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -53);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -52);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -51);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -50);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -49);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -48);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -47);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -46);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -45);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -44);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -43);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -42);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -41);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -40);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -39);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -38);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -37);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -36);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -35);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -34);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -33);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -32);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -31);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -30);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -29);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -28);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -27);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -26);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -25);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -24);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -23);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -22);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -21);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -20);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}
