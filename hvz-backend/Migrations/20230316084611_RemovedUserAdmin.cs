using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace hvz_backend.Migrations
{
    /// <inheritdoc />
    public partial class RemovedUserAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_Admins_AdminId",
                table: "Games");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Users_UserId",
                table: "Players");

            migrationBuilder.DropTable(
                name: "Admins");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Players_UserId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Games_AdminId",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Chats_GameId",
                table: "Chats");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Players",
                newName: "UserID");

            migrationBuilder.RenameColumn(
                name: "AdminId",
                table: "Games",
                newName: "AdminID");

            migrationBuilder.AlterColumn<string>(
                name: "UserID",
                table: "Players",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "AdminID",
                table: "Games",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                column: "AdminID",
                value: "a4b0e985-cdb0-4752-ba07-1ee7334d3391");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                column: "AdminID",
                value: "a4b0e985-cdb0-4752-ba07-1ee7334d3391");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                column: "AdminID",
                value: "f4553ac1-daa8-4064-841c-a5f5e107c336");

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                column: "AdminID",
                value: "a2cba5cb-667b-4566-a367-a1c62e7b8fd5");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserID",
                value: "acc85530-f88c-4de6-86e2-083bc5f86641");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserID",
                value: "d19c226a-22fb-4e6f-81a4-c1d153f929b7");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserID",
                value: "40885ab0-a5bb-4d76-a5d5-5db34156912b");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4,
                column: "UserID",
                value: "70a4f7b8-a619-438f-b309-fd333a9e8577");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5,
                column: "UserID",
                value: "1861c804-6669-49bb-b35b-5b2c191b850c");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6,
                column: "UserID",
                value: "245b9d79-0aa1-435d-9878-4896744f221b");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7,
                column: "UserID",
                value: "25b14121-60e7-4126-9926-34ccefc08ec2");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8,
                column: "UserID",
                value: "f52236fb-2ab2-4345-bfe5-bfa82b776cf1");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9,
                column: "UserID",
                value: "1e660e8f-893c-4224-82af-8f80d332d4a6");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 10,
                column: "UserID",
                value: "fb55b851-bfeb-4781-8e8a-bc2af03fea63");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 11,
                column: "UserID",
                value: "f8c97264f-0c1b-4dca-9cc3-fe786f8f0962");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 12,
                column: "UserID",
                value: "203837e7-29b9-400f-bdd8-5094abb4f3ab");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 13,
                column: "UserID",
                value: "f0ecd9f5-ee43-4fbf-bc01-7a6f6d6e52a2");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 14,
                column: "UserID",
                value: "1ca26c1d-7737-44aa-abc3-4120d1e84cde");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 15,
                column: "UserID",
                value: "87e22096-fce7-413d-a9e7-1ae785ef39ac");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 16,
                column: "UserID",
                value: "da02dda1-0510-4f20-8cd7-1e22c6e4321e");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 17,
                column: "UserID",
                value: "61bb9ef9-9f9e-4ce5-b466-4add87940ed8");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 18,
                column: "UserID",
                value: "ed860bdc-50ff-4637-81c2-af42cba90f54");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 19,
                column: "UserID",
                value: "db7df012-1f85-44f4-a6b8-6bf95bc9b715");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 20,
                column: "UserID",
                value: "d676b8d0-8353-4e0e-900c-335719b031eb");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 21,
                column: "UserID",
                value: "7c303786-36f5-410d-bae1-8fbcb92c6603");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 22,
                column: "UserID",
                value: "1d270eb6-53bf-440b-8eb9-c71feedf49dd");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 23,
                column: "UserID",
                value: "ba89254d-974f-4d64-abe8-8c2ddeabc1b7");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 24,
                column: "UserID",
                value: "49c024eb-d205-4587-bfd6-e5dbfb1702f3");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 25,
                column: "UserID",
                value: "43f44f34-5ee1-4b80-95c2-0cf2c2cb0776");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 26,
                column: "UserID",
                value: "b25e5332-0308-4e1c-b137-dae33588ea6c");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 27,
                column: "UserID",
                value: "0920e3c1-f978-4b70-a7f5-9c766595b475");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 28,
                column: "UserID",
                value: "7b6371fd-a26f-41b0-9056-c793ff7e07d6");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 29,
                column: "UserID",
                value: "6251cd7b-0a79-49e6-b4f2-b153bf21ac97");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 30,
                column: "UserID",
                value: "a56481e5-9c6a-4aef-9e07-c534a33f0097");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 31,
                column: "UserID",
                value: "2454c85a-b5b1-4c08-b265-e8e5a7ced4b7");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 32,
                column: "UserID",
                value: "10db85db-9750-415f-b6f3-333bdd678758");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 33,
                column: "UserID",
                value: "e386781a-bda7-4dba-a504-10999ed91267");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 34,
                column: "UserID",
                value: "01731ab5-8f28-4a7b-afe7-c892fc5bd8d9");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 35,
                column: "UserID",
                value: "a7551a99-7573-4abc-afae-b7186d35fb5a");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 36,
                column: "UserID",
                value: "542189b8-9df5-41d4-aece-5bff052a53f9");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 37,
                column: "UserID",
                value: "bbf55298-5e22-49a3-945c-b4d79346a3ed");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 38,
                column: "UserID",
                value: "dba845f7-fd61-4f1a-b8a6-4c67de2e8612");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 39,
                column: "UserID",
                value: "02e94a01-3d77-477f-8598-a87a0a91ea1a");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 40,
                column: "UserID",
                value: "430d1e90-27d9-47ca-afa9-8f6c41d1e272");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 41,
                column: "UserID",
                value: "7596aaf8-c8a6-449a-be88-e2e0263e51de");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 42,
                column: "UserID",
                value: "eb78fe31-2baf-495c-bf32-6ac91a050d7e");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 43,
                column: "UserID",
                value: "56e015d1-9ddf-4b6b-bc56-47b481696b04");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 44,
                column: "UserID",
                value: "587e6433-36f0-4ec3-825f-318aecf427fb");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 45,
                column: "UserID",
                value: "726f19c4-d67e-4584-aaf9-eb74eb9a6309");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 46,
                column: "UserID",
                value: "98ae3b89-2b66-4113-b369-b06e7af7960e");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 47,
                column: "UserID",
                value: "c6561be2-a927-4cb4-86ad-42867a09f06d");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 48,
                column: "UserID",
                value: "247cb94a-606a-44b2-968f-244f26544797");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 49,
                column: "UserID",
                value: "38de1747-35cf-41d0-a275-e6a5e84b0b2e");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 50,
                column: "UserID",
                value: "9ce13bc9-7f8b-4be8-97c7-bd8d9370deb0");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 51,
                column: "UserID",
                value: "9d394a75-27a0-4a21-b5f3-e0938da2725c");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 52,
                column: "UserID",
                value: "99000a0c-b069-4f61-9edd-0fc69a8accce");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 53,
                column: "UserID",
                value: "4afba9be-cd98-4070-9cb2-de3aa91e7203");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 54,
                column: "UserID",
                value: "8e942c88-8b46-451c-a594-1029e59ffffe");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 55,
                column: "UserID",
                value: "bf84285f-8bea-4639-bff5-404812e17e02");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 56,
                column: "UserID",
                value: "6f90589f-df6b-4e3e-8adb-3986b1b1ae20");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 57,
                column: "UserID",
                value: "c1dec74f-fc72-4f64-8cd1-4c35c48dba4b");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 58,
                column: "UserID",
                value: "00a13984-f498-4161-b448-ada0d47b86d4");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 59,
                column: "UserID",
                value: "4306cf6f-f263-4bcc-a5af-5a4083bf2700");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 60,
                column: "UserID",
                value: "4655a760-e6b2-4035-b39c-cf1156f4a0fa");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 61,
                column: "UserID",
                value: "8fd9439a-d6f1-42e0-9d7e-04c8e8a0554b");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 62,
                column: "UserID",
                value: "4fef8bff-b177-4919-a3b1-8d5b81bccedd");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 63,
                column: "UserID",
                value: "82f60c88-dfcf-4993-96ca-a68188a6a109");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 64,
                column: "UserID",
                value: "135ac31d-9dd8-4ebf-b1ea-8e530e86dfc3");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 65,
                column: "UserID",
                value: "fd9ea2b3-f9a3-447b-a614-ef6c44f4b0c6");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 66,
                column: "UserID",
                value: "b12a9834-293d-47d3-b6b4-5f8f57c1d092");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 67,
                column: "UserID",
                value: "75eaa26a-6552-4822-8973-94948ccafb22");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 68,
                column: "UserID",
                value: "1a91b5d0-06df-4eb6-911d-2ce1a9766a9b");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 69,
                column: "UserID",
                value: "215a49a4-d9b5-4e86-86ba-35d69781649e");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 70,
                column: "UserID",
                value: "5f70e435-d750-4961-a790-704312ae1336");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 71,
                column: "UserID",
                value: "d19c226a-22fb-4e6f-81a4-c1d153f929b7");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 72,
                column: "UserID",
                value: "70a4f7b8-a619-438f-b309-fd333a9e8577");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 73,
                column: "UserID",
                value: "1861c804-6669-49bb-b35b-5b2c191b850c");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 74,
                column: "UserID",
                value: "245b9d79-0aa1-435d-9878-4896744f221b");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 75,
                column: "UserID",
                value: "f52236fb-2ab2-4345-bfe5-bfa82b776cf1");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 76,
                column: "UserID",
                value: "fb55b851-bfeb-4781-8e8a-bc2af03fea63");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 77,
                column: "UserID",
                value: "203837e7-29b9-400f-bdd8-5094abb4f3ab");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 78,
                column: "UserID",
                value: "1ca26c1d-7737-44aa-abc3-4120d1e84cde");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 79,
                column: "UserID",
                value: "87e22096-fce7-413d-a9e7-1ae785ef39ac");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 80,
                column: "UserID",
                value: "61bb9ef9-9f9e-4ce5-b466-4add87940ed8");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 81,
                column: "UserID",
                value: "db7df012-1f85-44f4-a6b8-6bf95bc9b715");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 82,
                column: "UserID",
                value: "d676b8d0-8353-4e0e-900c-335719b031eb");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 83,
                column: "UserID",
                value: "7c303786-36f5-410d-bae1-8fbcb92c6603");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 84,
                column: "UserID",
                value: "ba89254d-974f-4d64-abe8-8c2ddeabc1b7");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 85,
                column: "UserID",
                value: "43f44f34-5ee1-4b80-95c2-0cf2c2cb0776");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 86,
                column: "UserID",
                value: "0920e3c1-f978-4b70-a7f5-9c766595b475");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 87,
                column: "UserID",
                value: "6251cd7b-0a79-49e6-b4f2-b153bf21ac97");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 88,
                column: "UserID",
                value: "a56481e5-9c6a-4aef-9e07-c534a33f0097");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 89,
                column: "UserID",
                value: "10db85db-9750-415f-b6f3-333bdd678758");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 90,
                column: "UserID",
                value: "01731ab5-8f28-4a7b-afe7-c892fc5bd8d9");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 91,
                column: "UserID",
                value: "a7551a99-7573-4abc-afae-b7186d35fb5a");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 92,
                column: "UserID",
                value: "bbf55298-5e22-49a3-945c-b4d79346a3ed");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 93,
                column: "UserID",
                value: "02e94a01-3d77-477f-8598-a87a0a91ea1a");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 94,
                column: "UserID",
                value: "7596aaf8-c8a6-449a-be88-e2e0263e51de");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 95,
                column: "UserID",
                value: "eb78fe31-2baf-495c-bf32-6ac91a050d7e");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 96,
                column: "UserID",
                value: "587e6433-36f0-4ec3-825f-318aecf427fb");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 97,
                column: "UserID",
                value: "98ae3b89-2b66-4113-b369-b06e7af7960e");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 98,
                column: "UserID",
                value: "c6561be2-a927-4cb4-86ad-42867a09f06d");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 99,
                column: "UserID",
                value: "38de1747-35cf-41d0-a275-e6a5e84b0b2e");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 100,
                column: "UserID",
                value: "9d394a75-27a0-4a21-b5f3-e0938da2725c");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 101,
                column: "UserID",
                value: "4afba9be-cd98-4070-9cb2-de3aa91e7203");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 102,
                column: "UserID",
                value: "8e942c88-8b46-451c-a594-1029e59ffffe");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 103,
                column: "UserID",
                value: "6f90589f-df6b-4e3e-8adb-3986b1b1ae20");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 104,
                column: "UserID",
                value: "4306cf6f-f263-4bcc-a5af-5a4083bf2700");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 105,
                column: "UserID",
                value: "8fd9439a-d6f1-42e0-9d7e-04c8e8a0554b");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 106,
                column: "UserID",
                value: "4fef8bff-b177-4919-a3b1-8d5b81bccedd");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 107,
                column: "UserID",
                value: "135ac31d-9dd8-4ebf-b1ea-8e530e86dfc3");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 108,
                column: "UserID",
                value: "75eaa26a-6552-4822-8973-94948ccafb22");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 109,
                column: "UserID",
                value: "215a49a4-d9b5-4e86-86ba-35d69781649e");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 110,
                column: "UserID",
                value: "5f70e435-d750-4961-a790-704312ae1336");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 111,
                column: "UserID",
                value: "70a4f7b8-a619-438f-b309-fd333a9e8577");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 112,
                column: "UserID",
                value: "1861c804-6669-49bb-b35b-5b2c191b850c");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 113,
                column: "UserID",
                value: "fb55b851-bfeb-4781-8e8a-bc2af03fea63");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 114,
                column: "UserID",
                value: "61bb9ef9-9f9e-4ce5-b466-4add87940ed8");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 115,
                column: "UserID",
                value: "db7df012-1f85-44f4-a6b8-6bf95bc9b715");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 116,
                column: "UserID",
                value: "7c303786-36f5-410d-bae1-8fbcb92c6603");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 117,
                column: "UserID",
                value: "ba89254d-974f-4d64-abe8-8c2ddeabc1b7");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 118,
                column: "UserID",
                value: "6251cd7b-0a79-49e6-b4f2-b153bf21ac97");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 119,
                column: "UserID",
                value: "a56481e5-9c6a-4aef-9e07-c534a33f0097");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 120,
                column: "UserID",
                value: "10db85db-9750-415f-b6f3-333bdd678758");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 121,
                column: "UserID",
                value: "01731ab5-8f28-4a7b-afe7-c892fc5bd8d9");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 122,
                column: "UserID",
                value: "a7551a99-7573-4abc-afae-b7186d35fb5a");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 123,
                column: "UserID",
                value: "bbf55298-5e22-49a3-945c-b4d79346a3ed");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 124,
                column: "UserID",
                value: "7596aaf8-c8a6-449a-be88-e2e0263e51de");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 125,
                column: "UserID",
                value: "eb78fe31-2baf-495c-bf32-6ac91a050d7e");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 126,
                column: "UserID",
                value: "98ae3b89-2b66-4113-b369-b06e7af7960e");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 127,
                column: "UserID",
                value: "c6561be2-a927-4cb4-86ad-42867a09f06d");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 128,
                column: "UserID",
                value: "9d394a75-27a0-4a21-b5f3-e0938da2725c");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 129,
                column: "UserID",
                value: "4afba9be-cd98-4070-9cb2-de3aa91e7203");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 130,
                column: "UserID",
                value: "6f90589f-df6b-4e3e-8adb-3986b1b1ae20");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 131,
                column: "UserID",
                value: "4306cf6f-f263-4bcc-a5af-5a4083bf2700");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 132,
                column: "UserID",
                value: "4fef8bff-b177-4919-a3b1-8d5b81bccedd");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 133,
                column: "UserID",
                value: "75eaa26a-6552-4822-8973-94948ccafb22");

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 134,
                column: "UserID",
                value: "215a49a4-d9b5-4e86-86ba-35d69781649e");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_GameId",
                table: "Chats",
                column: "GameId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Chats_GameId",
                table: "Chats");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Players",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "AdminID",
                table: "Games",
                newName: "AdminId");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Players",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "AdminId",
                table: "Games",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Admins",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Admins", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NickName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    State = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Admins",
                columns: new[] { "Id", "FirstName", "LastName", "Status" },
                values: new object[,]
                {
                    { 1, "René", "Dam Marcker", 0 },
                    { 2, "Thomas", "Osterhammel", 0 },
                    { 3, "Anja", "Fausing Wilstrup Sundebo", 0 },
                    { 4, "Michael", "Neergaard", 0 }
                });

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 1,
                column: "AdminId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 2,
                column: "AdminId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 3,
                column: "AdminId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Games",
                keyColumn: "Id",
                keyValue: 4,
                column: "AdminId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                column: "UserId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2,
                column: "UserId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 3,
                column: "UserId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 4,
                column: "UserId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 5,
                column: "UserId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 6,
                column: "UserId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 7,
                column: "UserId",
                value: 7);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 8,
                column: "UserId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 9,
                column: "UserId",
                value: 9);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 10,
                column: "UserId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 11,
                column: "UserId",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 12,
                column: "UserId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 13,
                column: "UserId",
                value: 13);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 14,
                column: "UserId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 15,
                column: "UserId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 16,
                column: "UserId",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 17,
                column: "UserId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 18,
                column: "UserId",
                value: 18);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 19,
                column: "UserId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 20,
                column: "UserId",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 21,
                column: "UserId",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 22,
                column: "UserId",
                value: 22);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 23,
                column: "UserId",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 24,
                column: "UserId",
                value: 24);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 25,
                column: "UserId",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 26,
                column: "UserId",
                value: 26);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 27,
                column: "UserId",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 28,
                column: "UserId",
                value: 28);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 29,
                column: "UserId",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 30,
                column: "UserId",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 31,
                column: "UserId",
                value: 31);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 32,
                column: "UserId",
                value: 32);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 33,
                column: "UserId",
                value: 33);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 34,
                column: "UserId",
                value: 34);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 35,
                column: "UserId",
                value: 35);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 36,
                column: "UserId",
                value: 36);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 37,
                column: "UserId",
                value: 37);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 38,
                column: "UserId",
                value: 38);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 39,
                column: "UserId",
                value: 39);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 40,
                column: "UserId",
                value: 40);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 41,
                column: "UserId",
                value: 41);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 42,
                column: "UserId",
                value: 42);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 43,
                column: "UserId",
                value: 43);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 44,
                column: "UserId",
                value: 44);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 45,
                column: "UserId",
                value: 45);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 46,
                column: "UserId",
                value: 46);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 47,
                column: "UserId",
                value: 47);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 48,
                column: "UserId",
                value: 48);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 49,
                column: "UserId",
                value: 49);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 50,
                column: "UserId",
                value: 50);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 51,
                column: "UserId",
                value: 51);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 52,
                column: "UserId",
                value: 52);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 53,
                column: "UserId",
                value: 53);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 54,
                column: "UserId",
                value: 54);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 55,
                column: "UserId",
                value: 55);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 56,
                column: "UserId",
                value: 56);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 57,
                column: "UserId",
                value: 57);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 58,
                column: "UserId",
                value: 58);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 59,
                column: "UserId",
                value: 59);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 60,
                column: "UserId",
                value: 60);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 61,
                column: "UserId",
                value: 61);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 62,
                column: "UserId",
                value: 62);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 63,
                column: "UserId",
                value: 63);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 64,
                column: "UserId",
                value: 64);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 65,
                column: "UserId",
                value: 65);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 66,
                column: "UserId",
                value: 66);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 67,
                column: "UserId",
                value: 67);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 68,
                column: "UserId",
                value: 68);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 69,
                column: "UserId",
                value: 69);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 70,
                column: "UserId",
                value: 70);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 71,
                column: "UserId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 72,
                column: "UserId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 73,
                column: "UserId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 74,
                column: "UserId",
                value: 6);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 75,
                column: "UserId",
                value: 8);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 76,
                column: "UserId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 77,
                column: "UserId",
                value: 12);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 78,
                column: "UserId",
                value: 14);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 79,
                column: "UserId",
                value: 15);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 80,
                column: "UserId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 81,
                column: "UserId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 82,
                column: "UserId",
                value: 20);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 83,
                column: "UserId",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 84,
                column: "UserId",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 85,
                column: "UserId",
                value: 25);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 86,
                column: "UserId",
                value: 27);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 87,
                column: "UserId",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 88,
                column: "UserId",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 89,
                column: "UserId",
                value: 32);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 90,
                column: "UserId",
                value: 34);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 91,
                column: "UserId",
                value: 35);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 92,
                column: "UserId",
                value: 37);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 93,
                column: "UserId",
                value: 39);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 94,
                column: "UserId",
                value: 41);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 95,
                column: "UserId",
                value: 42);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 96,
                column: "UserId",
                value: 44);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 97,
                column: "UserId",
                value: 46);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 98,
                column: "UserId",
                value: 47);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 99,
                column: "UserId",
                value: 49);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 100,
                column: "UserId",
                value: 51);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 101,
                column: "UserId",
                value: 53);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 102,
                column: "UserId",
                value: 54);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 103,
                column: "UserId",
                value: 56);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 104,
                column: "UserId",
                value: 59);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 105,
                column: "UserId",
                value: 61);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 106,
                column: "UserId",
                value: 62);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 107,
                column: "UserId",
                value: 64);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 108,
                column: "UserId",
                value: 67);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 109,
                column: "UserId",
                value: 69);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 110,
                column: "UserId",
                value: 70);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 111,
                column: "UserId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 112,
                column: "UserId",
                value: 5);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 113,
                column: "UserId",
                value: 10);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 114,
                column: "UserId",
                value: 17);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 115,
                column: "UserId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 116,
                column: "UserId",
                value: 21);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 117,
                column: "UserId",
                value: 23);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 118,
                column: "UserId",
                value: 29);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 119,
                column: "UserId",
                value: 30);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 120,
                column: "UserId",
                value: 32);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 121,
                column: "UserId",
                value: 34);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 122,
                column: "UserId",
                value: 35);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 123,
                column: "UserId",
                value: 37);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 124,
                column: "UserId",
                value: 41);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 125,
                column: "UserId",
                value: 42);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 126,
                column: "UserId",
                value: 46);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 127,
                column: "UserId",
                value: 47);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 128,
                column: "UserId",
                value: 51);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 129,
                column: "UserId",
                value: 53);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 130,
                column: "UserId",
                value: 56);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 131,
                column: "UserId",
                value: 59);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 132,
                column: "UserId",
                value: 62);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 133,
                column: "UserId",
                value: 67);

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 134,
                column: "UserId",
                value: 69);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "FirstName", "LastName", "NickName", "State" },
                values: new object[,]
                {
                    { 1, "Ethan", "Johnson", "Rainbow", null },
                    { 2, "Olivia", "Brown", "Kratos", null },
                    { 3, "Liam", "Martinez", "Sub-Zero", null },
                    { 4, "Emma", "Rodriguez", "Link", null },
                    { 5, "Noah", "Lee", "Zelda", null },
                    { 6, "Ava", "Davis", "Master Chief", null },
                    { 7, "William", "Wilson", "Solid Snake", null },
                    { 8, "Sophia", "Thompson", "AlbertWesker", null },
                    { 9, "James", "White", "Cloud", null },
                    { 10, "Mia", "Hernandez", "Aloy", null },
                    { 11, "Lucas", "Garcia", "Trevor", null },
                    { 12, "Isabella", "Smith", "Dante", null },
                    { 13, "Mason", "Brown", "LaraCroft", null },
                    { 14, "Sophia", "Gonzalez", "John Marston", null },
                    { 15, "Logan", "Perez", "Sam Fisher", null },
                    { 16, "Chloe", "Davis", "Max Payne", null },
                    { 17, "Benjamin", "Wilson", "Nemesis", null },
                    { 18, "Avery", "Taylor", "Ellie", null },
                    { 19, "Evelyn", "Anderson", "Commander Shepard", null },
                    { 20, "Daniel", "Hernandez", "Jill Valentine", null },
                    { 21, "Caleb", "Moore", "Leon S. Kennedy", null },
                    { 22, "Abigail", "Gomez", "Nathan Drake", null },
                    { 23, "Ethan", "Campbell", "Sonic the Hedgehog", null },
                    { 24, "Hannah", "Parker", "Ezio Auditore", null },
                    { 25, "Alexander", "Allen", "Geralt of Rivia", null },
                    { 26, "Madison", "King", "Samus Aran", null },
                    { 27, "Joseph", "Wright", "Raiden", null },
                    { 28, "Avery", "Scott", "Ezra", null },
                    { 29, "Sofia", "Green", "Daenerys", null },
                    { 30, "Christopher", "Baker", "Neo", null },
                    { 31, "Ella", "Adams", "Trinity", null },
                    { 32, "Joshua", "Nelson", "Blade", null },
                    { 33, "Avery", "Carter", "Ripley", null },
                    { 34, "Grace", "Mitchell", "Arya", null },
                    { 35, "Samuel", "Turner", "Wolverine", null },
                    { 36, "Victoria", "Phillips", "Leia", null },
                    { 37, "David", "Campbell", "Spartan", null },
                    { 38, "Aria", "Garcia", "Katniss", null },
                    { 39, "Daniel", "Cruz", "Nikita", null },
                    { 40, "Brianna", "Perez", "Triss", null },
                    { 41, "Joseph", "Bailey", "Indiana", null },
                    { 42, "Audrey", "Evans", "Rip Hunter", null },
                    { 43, "Jacob", "Rivera", "Kraven", null },
                    { 44, "Avery", "Cooper", "Harley", null },
                    { 45, "Natalie", "Reyes", "Mystique", null },
                    { 46, "Elijah", "Collins", "Hannibal", null },
                    { 47, "Elizabeth", "Lee", "Xena", null },
                    { 48, "Benjamin", "Gonzalez", "Bane", null },
                    { 49, "Aaliyah", "Martinez", "Riddick", null },
                    { 50, "Ethan", "Walker", "Morpheus", null },
                    { 51, "Avery", "Hall", "Gambit", null },
                    { 52, "Emily", "Allen", "Violet", null },
                    { 53, "William", "Garcia", "Nathan Hale", null },
                    { 54, "Grace", "Wilson", "Evelyn Salt", null },
                    { 55, "Gabriel", "Anderson", "Spartacus", null },
                    { 56, "Chloe", "Taylor", "Alice Abernathy", null },
                    { 57, "Samuel", "Brown", "Captain John Price", null },
                    { 58, "Lily", "Moore", "Elsa", null },
                    { 59, "David", "Lopez", "Marcus Fenix", null },
                    { 60, "Sofia", "Johnson", "Lena Oxton", null },
                    { 61, "Noah", "Davis", "Chris Redfield", null },
                    { 62, "Avery", "Harris", "Doomguy", null },
                    { 63, "Mia", "Thomas", "Katniss Everdeen", null },
                    { 64, "Daniel", "Allen", "Jason Brody", null },
                    { 65, "Aria", "Young", "Mako Mori", null },
                    { 66, "Jacob", "Nelson", "Ezra Bridger", null },
                    { 67, "Charlotte", "Sanchez", "Rey", null },
                    { 68, "Logan", "Parker", "Geralt of Rivia", null },
                    { 69, "Olivia", "Mitchell", "Wonder Woman", null },
                    { 70, "Caleb", "Clark", "Altair Ibn-La'Ahad", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Players_UserId",
                table: "Players",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Games_AdminId",
                table: "Games",
                column: "AdminId");

            migrationBuilder.CreateIndex(
                name: "IX_Chats_GameId",
                table: "Chats",
                column: "GameId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Games_Admins_AdminId",
                table: "Games",
                column: "AdminId",
                principalTable: "Admins",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Users_UserId",
                table: "Players",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
