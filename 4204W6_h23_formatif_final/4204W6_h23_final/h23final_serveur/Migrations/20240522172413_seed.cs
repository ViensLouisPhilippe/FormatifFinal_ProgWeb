using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace h23final_serveur.Migrations
{
    public partial class seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "2d85dd0c-a7a9-445c-9aab-f2aa2cdf832a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "25096e56-1bb7-4bfc-a280-e87a61386e46", "AQAAAAEAACcQAAAAEOmmTOgWHTHpanEXFlfCAp82pkISPklXkUFvW101r5YwfdKTOEAigXE3gTXT33KTZA==", "074e0975-bd4f-4da5-8f1e-2be691e704da" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1f252bc-dde0-4a45-a92b-e8612f117a40", "AQAAAAEAACcQAAAAEIwbp32PtxBDnD9m8pDqlUYZbuMB0rLj/jNqIRQAWEgXuqQcRmTEBFbNXmolT5uulw==", "b49b90e0-44d1-49bd-afaf-9cd55c8c923c" });

            migrationBuilder.InsertData(
                table: "Reaction",
                columns: new[] { "Id", "FileName", "MessageId", "MimeType", "Quantity" },
                values: new object[] { 3, "eggplant.png", 1, "image/png", 1 });

            migrationBuilder.InsertData(
                table: "ReactionUser",
                columns: new[] { "ReactionsId", "UsersId" },
                values: new object[] { 3, "11111111-1111-1111-1111-111111111112" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ReactionUser",
                keyColumns: new[] { "ReactionsId", "UsersId" },
                keyValues: new object[] { 3, "11111111-1111-1111-1111-111111111112" });

            migrationBuilder.DeleteData(
                table: "Reaction",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1",
                column: "ConcurrencyStamp",
                value: "dff44e91-a3e2-4040-91fc-0f0434e45e19");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111111",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6bb9ff4d-bbbe-489e-bc86-9b7272d0ac32", "AQAAAAEAACcQAAAAENTw27ceMxuDsaCfdPLKBsyvGlQTDwOR2dz1ujzn45kxFC2lf1hyTDy1p4RsHNxgRg==", "92e2ca66-6672-430a-8543-1b6282d2fd02" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "11111111-1111-1111-1111-111111111112",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7380fb66-a50c-44a9-88bf-d4381fce3ad9", "AQAAAAEAACcQAAAAEOrt2WKzR1XNP3cjiX/xQTrWe6oi4qSQxzf+cLJnah+zVE00TAn6IuSohiwxGi4m0w==", "52a6a83f-e604-4314-8383-ba9cc175baf5" });
        }
    }
}
