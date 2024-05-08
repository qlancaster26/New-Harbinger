using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace New_Harbinger.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    CharacterId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Species = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Affiliation = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.CharacterId);
                });

            migrationBuilder.CreateTable(
                name: "Quests",
                columns: table => new
                {
                    QuestId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Type = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quests", x => x.QuestId);
                });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "Affiliation", "Name", "Species" },
                values: new object[,]
                {
                    { 1, "Jedi", "Rey Skywalker", "Human" },
                    { 2, "Scoundrel", "Fin", "Human" },
                    { 3, "Rebel", "Po Dameron", "Human" },
                    { 4, "Exile", "Metra Surik", "Human" },
                    { 5, "Scout", "Zaalbarr", "Wookie" },
                    { 6, "Bounty Hunter", "Greedo", "Rodian" },
                    { 7, "Assassin", "Hk-47", "Droid" },
                    { 8, "Mandalorian", "Bralor Starkiller", "Human" },
                    { 9, "Jedi", "Ahsoka Tano", "Twilek" },
                    { 10, "Mandalorian", "Din Djarin", "Human" },
                    { 11, "Sith Lord", "Sheev Palpatine", "Human" },
                    { 12, "Sith Lord", "Darth Malak", "Human" },
                    { 13, "Jedi", "Cal Kestis", "Human" },
                    { 14, "Jedi", "Master Vrook", "Human" },
                    { 15, "Marauder", "Sleemo Lacerus", "Zabraak" },
                    { 16, "Jedi Historian", "Atris", "Human" },
                    { 17, "Jedi", "Quade Lancaster", "Human" },
                    { 18, "Clone", "Boba Fett", "Human" },
                    { 19, "General", "Carth Onasi", "Human" },
                    { 20, "Scoundrel", "Mission Vao", "Twilek" },
                    { 21, "Mandalorian", "Canderous Ordo", "Human" },
                    { 22, "Mandalorian", "Bo-Katan Kryze", "Human" },
                    { 23, "Pilot", "Jek Porkins", "Human" },
                    { 24, "Sith Admiral", "Piett", "Human" },
                    { 25, "Inquistor", "Trilla", "Human" }
                });

            migrationBuilder.InsertData(
                table: "Quests",
                columns: new[] { "QuestId", "Description", "Title", "Type" },
                values: new object[,]
                {
                    { 1, "Quest begins where Rey has a premonition", "Jaku", "Main Quest" },
                    { 2, "Char Meets Master Atris", "Academy on Telos", "Main Quest" },
                    { 3, "Char travels to Jedha in search of holocron", "Memories Unlimited", "Main Quest" },
                    { 4, "Char comes face to face with an inquisitor", "Trouble on Tanalor", "Main Quest" },
                    { 5, "Rey meets char outside shuttle for news", "Back to Jaku", "Main Quest" },
                    { 6, "Char begins reliving inquistor standoff", "A disturbance in the force", "Main Quest" },
                    { 7, "The spirit of palpatine endures", "Palpatine Returns", "Main Quest" },
                    { 8, "beyond the astroid belt a star destroyer is found", "Rebel Forces Engage Defectors", "Main Quest" },
                    { 9, "Po meets Meetra Surik a Jedi exile living among mandalorians", "Po Dameron crash lands on Dxun", "Main Quest" },
                    { 10, "surviving imperials flee to planet beneath burning star destroyer", "Jek Porkins pulls forces back", "Main Quest" },
                    { 11, "An unexpected answer from a new threat", "Piett calls for reinforcements", "Main Quest" },
                    { 12, "Darth Malak emerges from the outer rim with inquisitors", "The Leviathan", "Main Quest" },
                    { 13, "Po and Meetra search for imperial crash landers", "Dxun Jungle", "Main Quest" },
                    { 14, "Atris continues Quades jedi training", "Back to Telos", "Side Quest" },
                    { 15, "Rey begins searching for the new sith threat", "An Old Order", "Main Quest" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Quests");
        }
    }
}
