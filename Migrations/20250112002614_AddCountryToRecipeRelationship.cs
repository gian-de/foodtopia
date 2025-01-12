using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace foodtopia.Migrations
{
    /// <inheritdoc />
    public partial class AddCountryToRecipeRelationship : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("00d039ac-65ba-4c88-8776-e66d80aeda59"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("01f4ac5c-11cb-46a3-b455-4c27c05cdca9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("038605c3-9499-4205-a0ac-f71ef43b47b3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0a34bbde-21c7-4746-8714-721a0c0597b3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("13488b4b-539a-40ca-a40b-bea362bdbd1b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("16ddc3e7-9748-477e-b7c0-8d503b992e2e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("18e8ff81-6234-4aa6-902e-69cefb26aca5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1d8a47a1-1130-4ad4-8f4d-4e3c300d89ec"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1dca600a-c5f0-45a9-be79-5e86b8b68f0e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("20d93819-4e82-4eee-b56d-20f08d2e0c5b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("273719f6-22df-400b-99b8-6d499a7a2f9e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2ca071fb-0cd8-4962-b85c-7342f9353e43"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("31f03777-3e94-402d-b4eb-c7c6e9903108"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("33195fed-3b63-46fb-b49c-15f7caf6ed1c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3a95d925-25cd-4073-bccb-78f58cc3fc4c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3ddd41b8-7ba7-4945-9c00-0b496f0953af"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("413520ac-6f4b-45df-bd96-5e2aefed0be0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("463671c5-fc34-4294-b600-92ced08b4a41"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("48cb1fe1-dc53-4297-ab4c-d83b8515fbe5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("4ffd1636-b9c1-47aa-b20e-0d02a5182348"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("5456e649-bf0a-4507-b60d-251aa750cc4c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("597558ac-0f1c-4eeb-8751-71bf881d3d78"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("59784003-0163-470e-8238-e63c2be3ebb0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("63a80847-172c-41e9-b35f-40d8c1237ab1"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("63dee376-5006-44fc-a763-730cd9bbff8a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("65284b4a-374a-4144-9509-3598b4c270fd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6e12219e-44e5-495a-8fbc-d0f74848014b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("732f69b7-13c1-449c-ac71-502bb36512e8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("76009c1d-0de7-44e7-a8ca-bd9d6a0a816b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("779f2d29-d9da-46d8-a78f-e6ca5a393a5b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("77bce5a9-8530-4a4c-92bf-1b922efaf625"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7a6b2878-a943-4d1f-b7ab-458caeb158e8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7b1b2a17-156a-413d-b57e-c49fead48e22"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7f8cc654-9cea-46c9-af92-ae1ee272677a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("802f65b6-6c64-494f-a1eb-802d5cc594d6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8249285d-6244-4de6-a79a-55ca989bed88"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8549307c-e92b-4c90-899c-35e67eb02732"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("86c98c7f-35f2-44e7-b44c-a2603cfd17c2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("86e7903b-1f81-4534-8f6a-1cb6b7ad5782"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8b8aab18-f234-4919-b233-e27e6485811e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8bd372dc-061f-4bfa-ae4e-53b726330f1b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8c7a2ce6-9f2f-4bdd-83d6-b24801310760"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8ccb0c9f-5ade-4e99-b4e7-9e9809d20682"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8ed7b64f-1a56-4d9d-ba35-fd2f83047f1e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8ffc8e08-3a94-4da1-a504-1cd3cb08eff5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("902d5369-17e0-45b9-9367-9ced0cedeb6c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("962dea70-2f53-4753-8ea4-52cbb31d4175"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("96b22919-3f04-43b3-a4c2-f9691e523936"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("99e67deb-d8aa-48cf-b011-afc6e37ad21d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9b880c26-de06-41b1-8579-e31b7c70ebef"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9c738db6-b1b0-4367-8173-30f60b8550fb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9e42a217-8054-4cee-8b7a-087fe95a79f9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9eb0882c-e56c-4a7e-8c03-e1997f1b787e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a05f52e8-51f7-4626-8329-feb7f5cb5249"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a308e22f-bf3c-4787-97ba-ed2baf1db7ba"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a6ddb27c-0eba-4c64-b926-95a839ce03e8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b61f5b0d-a6b5-4189-9af2-3752028727ed"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("beeb07ec-a1f2-474f-aaca-67e544db05b3"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bf94588a-8cb3-46d9-a17e-5878cdafe268"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c28bd523-8245-46bf-83fa-8c1e95a764e4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c3dbc242-ab34-4c47-9707-a2195187915e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c7be5a6f-4a9a-4da4-8910-7e3f9355f3cb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cf88669c-827f-463a-a6cf-75cb10faa93b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("d37b096d-86dc-4deb-ba2a-ed067b1d3cc2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("da874b21-e67c-4560-993b-e61c4ea282fd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dfe7829b-4d19-4db5-ae73-d896709e3d33"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e60e384e-a7cf-411a-9362-76d0aeec619b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("eb014b54-2b8e-4ce8-ac17-d0b14c60e1ae"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f1269377-754b-437e-b8e2-3c3b26d160d7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f30dd8f5-4c4a-4eb4-b28d-0e559b1dea75"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f3e6e63c-a7a0-4090-9326-ccd5e2dc5008"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f79788fc-c9a9-4f15-9ea3-ce375205d15c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f9899140-d549-4c9e-8d05-e12b5ea83623"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fbbee294-de2d-4f6a-93ab-b6df3853e64a"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("624aaf79-8a0a-4e07-b7ae-3228ac6b8bd9"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("d3d4f946-ad13-4c2b-960e-9cea2cc38329"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("e393ee0f-750e-4073-b3d9-e63bf19ab5fe"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("5051f18a-8618-4beb-b97b-e8e624ab2200"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("60c30f84-d112-4c80-9837-e97600a43434"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("95a60176-994b-42f7-a5e0-10dafa06da2f"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("b4308569-9e4e-43c4-b211-329eadf3e62b"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("d0468a9c-b3ef-42f8-823a-6fb4adb003ec"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("e45c3910-4120-4c3f-a73c-9fd7841ffbab"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("ee9d51cd-6663-4fe0-8219-c4aa83967adc"));

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ImagePath", "Name", "Slug" },
                values: new object[,]
                {
                    { new Guid("01578fe3-4933-4153-9ec1-50cd5762a2e8"), "images/flags/vietnam.svg", "Vietnam", "vietnam" },
                    { new Guid("046b8e9f-4055-4e59-8414-2b675af1b380"), "images/flags/egypt.svg", "Egypt", "egypt" },
                    { new Guid("09eafec3-8c30-48bc-9c49-9c146d3f8363"), "images/flags/israel.svg", "Israel", "israel" },
                    { new Guid("0b1764f9-80da-4cae-b900-4faca3f87b3a"), "images/flags/france.svg", "France", "france" },
                    { new Guid("0f7409ab-d36c-4696-9a85-9cabea829e5b"), "images/flags/norway.svg", "Norway", "norway" },
                    { new Guid("1748659f-78ed-4d55-913b-5f086be32871"), "images/flags/australia.svg", "Australia", "australia" },
                    { new Guid("1c14e1c5-a4d1-43d1-bda7-e2bb0a19ac32"), "images/flags/india.svg", "India", "india" },
                    { new Guid("1c8fc373-77ea-4f2a-b9bc-eecad5c9960d"), "images/flags/azerbaijan.svg", "Azerbaijan", "azerbaijan" },
                    { new Guid("20baa712-8026-41a9-ad0b-335ef8b6345f"), "images/flags/dominican_republic.svg", "Dominican Republic", "dominica-republic" },
                    { new Guid("20f71b82-eb8a-4988-b23a-02ca4d7e1e3d"), "images/flags/iceland.svg", "Iceland", "iceland" },
                    { new Guid("21367964-fb52-408c-96e9-c39f95022354"), "images/flags/el_salvador.svg", "El Salvador", "el-salvador" },
                    { new Guid("214085d3-f12f-4f4d-8c8e-466af2744516"), "images/flags/armenia.svg", "Armenia", "armenia" },
                    { new Guid("223a2cbc-789c-4524-932c-8089f44724eb"), "images/flags/guatemala.svg", "Guatemala", "guatemala" },
                    { new Guid("24535263-c259-478d-a9a2-43a6e6fc19e2"), "images/flags/bahamas.svg", "Bahamas", "bahamas" },
                    { new Guid("2637d187-5fce-4de9-8179-49e8d5abfb97"), "images/flags/germany.svg", "Germany", "germany" },
                    { new Guid("2773fb1c-486d-47ca-a162-651f0a0a5ecb"), "images/flags/austria.svg", "Austria", "austria" },
                    { new Guid("289e48e9-c338-4003-ae16-370426ff1092"), "images/flags/pakistan.svg", "Pakistan", "pakistan" },
                    { new Guid("29ccf4b4-46f8-4b6c-998d-39fbb374f06b"), "images/flags/antigua_barbuda.svg", "Antigua & Barbuda", "antigua-and-barbuda" },
                    { new Guid("3032500c-c5c3-463a-9a22-bf82774fe298"), "images/flags/argentina.svg", "Argentina", "argentina" },
                    { new Guid("3048dd59-ae9d-4566-a557-31fa3b9cbedd"), "images/flags/belgium.svg", "Belgium", "belgium" },
                    { new Guid("30f2cb34-b256-409d-a1fb-ae045a2bc94b"), "images/flags/portugal.svg", "Portugal", "portugal" },
                    { new Guid("3331ed87-8502-4d2f-9812-69682cf6d2e8"), "images/flags/russia.svg", "Russia", "russia" },
                    { new Guid("34867253-ed32-4b19-9e82-982a838a231e"), "images/flags/canada.svg", "Canada", "canada" },
                    { new Guid("3c320333-e4a1-4acb-a65e-83b6fb6e9524"), "images/flags/uk.svg", "UK", "united-kingdom" },
                    { new Guid("488d2e29-8bf3-4a09-8245-f46e3dc543f5"), "images/flags/panama.svg", "Panama", "panama" },
                    { new Guid("50527195-f6e0-4a35-8cb1-6257cf471132"), "images/flags/palestine.svg", "Palestine", "palestine" },
                    { new Guid("521b1965-11ea-4218-8fcc-a81794769d3d"), "images/flags/andorra.svg", "Andorra", "andorra" },
                    { new Guid("536999bb-dc41-431f-be0f-58fb54a3e029"), "images/flags/brazil.svg", "Brazil", "brazil" },
                    { new Guid("596dd9b7-699f-49cd-ab7e-29afae8d97df"), "images/flags/albania.svg", "Albania", "albania" },
                    { new Guid("612806b8-0f89-4202-b385-f9094ed3576c"), "images/flags/chile.svg", "Chile", "chile" },
                    { new Guid("617ced29-4c90-4070-accd-01438fc5168a"), "images/flags/ireland.svg", "Ireland", "ireland" },
                    { new Guid("67ac2314-ed0c-449c-9bcf-0bf65a6d4391"), "images/flags/philippines.svg", "Philippines", "philippines" },
                    { new Guid("684ace13-0121-492d-a6dd-0dc3e3293704"), "images/flags/peru.svg", "Peru", "peru" },
                    { new Guid("6b86d383-ec9e-4f79-a854-81269452e488"), "images/flags/nigeria.svg", "Nigeria", "nigeria" },
                    { new Guid("72345cda-4598-4dfd-9749-d1b7b13f273f"), "images/flags/trinidad&tobago.svg", "Trinidad & Tobago", "trinidad-and-tobago" },
                    { new Guid("73bad6da-6063-4cab-8fd9-6c88b610c581"), "images/flags/cuba.svg", "Cuba", "cuba" },
                    { new Guid("7409315a-e16e-4a12-8f51-e22a73881e34"), "images/flags/mexico.svg", "Mexico", "mexico" },
                    { new Guid("8058b0d2-f7c8-4f1f-8b49-6f79aa4e6bcf"), "images/flags/jamaica.svg", "Jamaica", "jamaica" },
                    { new Guid("860052db-1690-4ae7-b419-6fcfebaea268"), "images/flags/bolivia.svg", "Bolivia", "bolivia" },
                    { new Guid("8995e0a0-418c-4864-996a-b534307ba1c4"), "images/flags/hungary.svg", "Hungary", "hungary" },
                    { new Guid("8cfeb3a2-db28-40b9-b2c5-13d9f6375547"), "images/flags/poland.svg", "Poland", "poland" },
                    { new Guid("8df92431-576b-4355-9d39-6a7a1de66486"), "images/flags/morocco.svg", "Morocco", "morocco" },
                    { new Guid("8f255e1b-72ff-4557-aca6-a410c6ef28a9"), "images/flags/china.svg", "China", "china" },
                    { new Guid("8fb273a3-c660-426d-8c22-362473781871"), "images/flags/ukraine.svg", "Ukraine", "ukraine" },
                    { new Guid("8fee3b9e-1085-46da-a3fd-9207cd11d655"), "images/flags/saudi_arabia.svg", "Saudi Arabia", "saudi-arabia" },
                    { new Guid("928ef8dd-0fa6-4869-81b2-bfc707f0fcd0"), "images/flags/denmark.svg", "Denmark", "denmark" },
                    { new Guid("98ddb29a-0a34-4553-baad-dacf1eb06703"), "images/flags/greece.svg", "Greece", "greece" },
                    { new Guid("9a052808-fcc3-4cb3-9fcb-e7b02e747021"), "images/flags/qatar.svg", "Qatar", "qatar" },
                    { new Guid("9e86a69f-58f7-4abf-a5d6-c3461fee8889"), "images/flags/finland.svg", "Finland", "finland" },
                    { new Guid("9ed31919-2a90-4a27-90af-c61613d76d08"), "images/flags/colombia.svg", "Colombia", "colombia" },
                    { new Guid("a43532e6-7e4d-4af3-bc04-1272602a971f"), "images/flags/ghana.svg", "Ghana", "ghana" },
                    { new Guid("b1f6f5e5-2694-4ce5-877e-ca2d930dd733"), "images/flags/cameroon.svg", "Cameroon", "cameroon" },
                    { new Guid("b8379cf3-b897-4786-8a66-1e6c090441ef"), "images/flags/serbia.svg", "Serbia", "serbia" },
                    { new Guid("ba153247-01e0-4ef0-ad10-70bebba17a67"), "images/flags/fiji.svg", "Fiji", "fiji" },
                    { new Guid("bd565c63-0327-4d44-9986-5ee2ef3878bc"), "images/flags/spain.svg", "Spain", "spain" },
                    { new Guid("bf4a34e6-497e-4ddb-b535-927734d5841b"), "images/flags/south_korea.svg", "South Korea", "south-korea" },
                    { new Guid("c6fc08a4-ea24-4549-812e-9d2a7b6ccf4d"), "images/flags/kuwait.svg", "Kuwait", "kuwait" },
                    { new Guid("cb81bcee-15db-4ff4-afea-d5058210892c"), "images/flags/turkey.svg", "Turkey", "turkey" },
                    { new Guid("da0c9509-1957-488f-9045-2d5fa40764c4"), "images/flags/japan.svg", "Japan", "japan" },
                    { new Guid("db3d717e-c53a-4b5e-98e6-824ef620de62"), "images/flags/monaco.svg", "Monaco", "monaco" },
                    { new Guid("dcfbd07f-1370-4f68-a605-26a9cbf845cc"), "images/flags/ecuador.svg", "Ecuador", "ecuador" },
                    { new Guid("dd43945c-56a8-4216-b1ac-4c3c33d05a11"), "images/flags/sweden.svg", "Sweden", "sweden" },
                    { new Guid("dd4cbc86-d78f-4c2b-878a-a48d7e85b7e6"), "images/flags/afghanistan.svg", "Afghanistan", "afghanistan" },
                    { new Guid("df68c932-9fa2-4c83-ac96-53c3f7307723"), "images/flags/croatia.svg", "Croatia", "croatia" },
                    { new Guid("df818785-2928-407c-ada0-5150d767eb20"), "images/flags/costa_rica.svg", "Costa Rica", "costa-rica" },
                    { new Guid("e1bd80cf-f5a1-4152-b330-431b907467a8"), "images/flags/netherlands.svg", "Netherlands", "netherlands" },
                    { new Guid("e22a76ba-dcab-4b1b-a892-0d58370022e0"), "images/flags/algeria.svg", "Algeria", "algeria" },
                    { new Guid("e2cd761b-91e0-47fd-be00-4e99705c87e7"), "images/flags/angola.svg", "Angola", "angola" },
                    { new Guid("e9415484-edca-4aad-aca7-515162e940d9"), "images/flags/south_africa.svg", "South Africa", "south-africa" },
                    { new Guid("f7de96ed-44df-4aa3-807b-0d55bd3c0c6c"), "images/flags/kosovo.svg", "Kosovo", "kosovo" },
                    { new Guid("f8ec6753-1784-4c82-89e3-e7ea33eb76b0"), "images/flags/thailand.svg", "Thailand", "thailand" },
                    { new Guid("f8f486fe-c7b9-49b0-9e49-888d62cb3c43"), "images/flags/italy.svg", "Italy", "italy" },
                    { new Guid("faacc565-75bb-4366-8f43-08b2002d3179"), "images/flags/venezuela.svg", "Venezuela", "venezuela" },
                    { new Guid("fe6ce064-f562-4f48-bcd4-d98c9aaa37f3"), "images/flags/uae.svg", "UAE", "united-arab-emirates" }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Measurement", "Name", "Quantity", "RecipeId" },
                values: new object[,]
                {
                    { new Guid("2e4b6890-70fb-43d4-af7e-44cb4133ce71"), "cup", "Sauce", 1m, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8") },
                    { new Guid("8ff4c97a-1ed7-49fc-8028-b82fee63a446"), "cups", "Flour", 2m, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8") },
                    { new Guid("c3834b89-3efd-490f-970a-00e740f7b6a3"), "", "Egg", 2m, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8") }
                });

            migrationBuilder.InsertData(
                table: "Instructions",
                columns: new[] { "Id", "Order", "RecipeId", "Step" },
                values: new object[,]
                {
                    { new Guid("17419084-b1da-4603-9a36-bd8436b60d79"), 3, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"), "Add arrowroot starch to mixing bowl and other spices of your choosing." },
                    { new Guid("60515924-4e5a-4e19-9b6f-86fbfdcc3b12"), 6, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"), "Place back into the over for 12-15 minutes." },
                    { new Guid("62ae9bf3-85ca-4a5a-b0e3-9f66f87b1f5d"), 5, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"), "Layer the sauce, then the cheese and lastly the toppings." },
                    { new Guid("802b167b-f508-43c7-bdf9-e4cf2f49578b"), 7, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"), "Let the pizza cool for at least 5 minutes and enjoy!" },
                    { new Guid("b29c1c9c-15fa-4a72-b288-3a00bf610453"), 1, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"), "Crack eggs and add to mixing bowl." },
                    { new Guid("cd48476c-c275-4815-85c8-d2ff52aee99b"), 2, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"), "Whisk until eggs form into a foam-like white texture." },
                    { new Guid("e192eb4d-9926-4e6e-b274-a55bb6abf58a"), 4, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"), "Place inside the over that has been preheated to 350 degrees Fahrenheit for 8-10 minutes." }
                });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 12, 0, 26, 13, 909, DateTimeKind.Utc).AddTicks(7990));

            migrationBuilder.CreateIndex(
                name: "IX_Countries_Name",
                table: "Countries",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Countries_Name",
                table: "Countries");

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("01578fe3-4933-4153-9ec1-50cd5762a2e8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("046b8e9f-4055-4e59-8414-2b675af1b380"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("09eafec3-8c30-48bc-9c49-9c146d3f8363"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0b1764f9-80da-4cae-b900-4faca3f87b3a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("0f7409ab-d36c-4696-9a85-9cabea829e5b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1748659f-78ed-4d55-913b-5f086be32871"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1c14e1c5-a4d1-43d1-bda7-e2bb0a19ac32"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("1c8fc373-77ea-4f2a-b9bc-eecad5c9960d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("20baa712-8026-41a9-ad0b-335ef8b6345f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("20f71b82-eb8a-4988-b23a-02ca4d7e1e3d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("21367964-fb52-408c-96e9-c39f95022354"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("214085d3-f12f-4f4d-8c8e-466af2744516"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("223a2cbc-789c-4524-932c-8089f44724eb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("24535263-c259-478d-a9a2-43a6e6fc19e2"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2637d187-5fce-4de9-8179-49e8d5abfb97"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("2773fb1c-486d-47ca-a162-651f0a0a5ecb"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("289e48e9-c338-4003-ae16-370426ff1092"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("29ccf4b4-46f8-4b6c-998d-39fbb374f06b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3032500c-c5c3-463a-9a22-bf82774fe298"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3048dd59-ae9d-4566-a557-31fa3b9cbedd"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("30f2cb34-b256-409d-a1fb-ae045a2bc94b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3331ed87-8502-4d2f-9812-69682cf6d2e8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("34867253-ed32-4b19-9e82-982a838a231e"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("3c320333-e4a1-4acb-a65e-83b6fb6e9524"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("488d2e29-8bf3-4a09-8245-f46e3dc543f5"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("50527195-f6e0-4a35-8cb1-6257cf471132"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("521b1965-11ea-4218-8fcc-a81794769d3d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("536999bb-dc41-431f-be0f-58fb54a3e029"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("596dd9b7-699f-49cd-ab7e-29afae8d97df"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("612806b8-0f89-4202-b385-f9094ed3576c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("617ced29-4c90-4070-accd-01438fc5168a"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("67ac2314-ed0c-449c-9bcf-0bf65a6d4391"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("684ace13-0121-492d-a6dd-0dc3e3293704"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("6b86d383-ec9e-4f79-a854-81269452e488"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("72345cda-4598-4dfd-9749-d1b7b13f273f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("73bad6da-6063-4cab-8fd9-6c88b610c581"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("7409315a-e16e-4a12-8f51-e22a73881e34"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8058b0d2-f7c8-4f1f-8b49-6f79aa4e6bcf"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("860052db-1690-4ae7-b419-6fcfebaea268"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8995e0a0-418c-4864-996a-b534307ba1c4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8cfeb3a2-db28-40b9-b2c5-13d9f6375547"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8df92431-576b-4355-9d39-6a7a1de66486"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8f255e1b-72ff-4557-aca6-a410c6ef28a9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8fb273a3-c660-426d-8c22-362473781871"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("8fee3b9e-1085-46da-a3fd-9207cd11d655"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("928ef8dd-0fa6-4869-81b2-bfc707f0fcd0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("98ddb29a-0a34-4553-baad-dacf1eb06703"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9a052808-fcc3-4cb3-9fcb-e7b02e747021"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9e86a69f-58f7-4abf-a5d6-c3461fee8889"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("9ed31919-2a90-4a27-90af-c61613d76d08"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("a43532e6-7e4d-4af3-bc04-1272602a971f"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b1f6f5e5-2694-4ce5-877e-ca2d930dd733"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("b8379cf3-b897-4786-8a66-1e6c090441ef"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("ba153247-01e0-4ef0-ad10-70bebba17a67"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bd565c63-0327-4d44-9986-5ee2ef3878bc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("bf4a34e6-497e-4ddb-b535-927734d5841b"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("c6fc08a4-ea24-4549-812e-9d2a7b6ccf4d"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("cb81bcee-15db-4ff4-afea-d5058210892c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("da0c9509-1957-488f-9045-2d5fa40764c4"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("db3d717e-c53a-4b5e-98e6-824ef620de62"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dcfbd07f-1370-4f68-a605-26a9cbf845cc"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dd43945c-56a8-4216-b1ac-4c3c33d05a11"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("dd4cbc86-d78f-4c2b-878a-a48d7e85b7e6"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("df68c932-9fa2-4c83-ac96-53c3f7307723"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("df818785-2928-407c-ada0-5150d767eb20"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e1bd80cf-f5a1-4152-b330-431b907467a8"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e22a76ba-dcab-4b1b-a892-0d58370022e0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e2cd761b-91e0-47fd-be00-4e99705c87e7"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("e9415484-edca-4aad-aca7-515162e940d9"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f7de96ed-44df-4aa3-807b-0d55bd3c0c6c"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f8ec6753-1784-4c82-89e3-e7ea33eb76b0"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("f8f486fe-c7b9-49b0-9e49-888d62cb3c43"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("faacc565-75bb-4366-8f43-08b2002d3179"));

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: new Guid("fe6ce064-f562-4f48-bcd4-d98c9aaa37f3"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("2e4b6890-70fb-43d4-af7e-44cb4133ce71"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("8ff4c97a-1ed7-49fc-8028-b82fee63a446"));

            migrationBuilder.DeleteData(
                table: "Ingredients",
                keyColumn: "Id",
                keyValue: new Guid("c3834b89-3efd-490f-970a-00e740f7b6a3"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("17419084-b1da-4603-9a36-bd8436b60d79"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("60515924-4e5a-4e19-9b6f-86fbfdcc3b12"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("62ae9bf3-85ca-4a5a-b0e3-9f66f87b1f5d"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("802b167b-f508-43c7-bdf9-e4cf2f49578b"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("b29c1c9c-15fa-4a72-b288-3a00bf610453"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("cd48476c-c275-4815-85c8-d2ff52aee99b"));

            migrationBuilder.DeleteData(
                table: "Instructions",
                keyColumn: "Id",
                keyValue: new Guid("e192eb4d-9926-4e6e-b274-a55bb6abf58a"));

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "ImagePath", "Name", "Slug" },
                values: new object[,]
                {
                    { new Guid("00d039ac-65ba-4c88-8776-e66d80aeda59"), "images/flags/vietnam.svg", "Vietnam", "vietnam" },
                    { new Guid("01f4ac5c-11cb-46a3-b455-4c27c05cdca9"), "images/flags/guatemala.svg", "Guatemala", "guatemala" },
                    { new Guid("038605c3-9499-4205-a0ac-f71ef43b47b3"), "images/flags/algeria.svg", "Algeria", "algeria" },
                    { new Guid("0a34bbde-21c7-4746-8714-721a0c0597b3"), "images/flags/uk.svg", "UK", "united-kingdom" },
                    { new Guid("13488b4b-539a-40ca-a40b-bea362bdbd1b"), "images/flags/norway.svg", "Norway", "norway" },
                    { new Guid("16ddc3e7-9748-477e-b7c0-8d503b992e2e"), "images/flags/saudi_arabia.svg", "Saudi Arabia", "saudi-arabia" },
                    { new Guid("18e8ff81-6234-4aa6-902e-69cefb26aca5"), "images/flags/finland.svg", "Finland", "finland" },
                    { new Guid("1d8a47a1-1130-4ad4-8f4d-4e3c300d89ec"), "images/flags/colombia.svg", "Colombia", "colombia" },
                    { new Guid("1dca600a-c5f0-45a9-be79-5e86b8b68f0e"), "images/flags/austria.svg", "Austria", "austria" },
                    { new Guid("20d93819-4e82-4eee-b56d-20f08d2e0c5b"), "images/flags/mexico.svg", "Mexico", "mexico" },
                    { new Guid("273719f6-22df-400b-99b8-6d499a7a2f9e"), "images/flags/nigeria.svg", "Nigeria", "nigeria" },
                    { new Guid("2ca071fb-0cd8-4962-b85c-7342f9353e43"), "images/flags/ukraine.svg", "Ukraine", "ukraine" },
                    { new Guid("31f03777-3e94-402d-b4eb-c7c6e9903108"), "images/flags/chile.svg", "Chile", "chile" },
                    { new Guid("33195fed-3b63-46fb-b49c-15f7caf6ed1c"), "images/flags/hungary.svg", "Hungary", "hungary" },
                    { new Guid("3a95d925-25cd-4073-bccb-78f58cc3fc4c"), "images/flags/denmark.svg", "Denmark", "denmark" },
                    { new Guid("3ddd41b8-7ba7-4945-9c00-0b496f0953af"), "images/flags/kosovo.svg", "Kosovo", "kosovo" },
                    { new Guid("413520ac-6f4b-45df-bd96-5e2aefed0be0"), "images/flags/japan.svg", "Japan", "japan" },
                    { new Guid("463671c5-fc34-4294-b600-92ced08b4a41"), "images/flags/croatia.svg", "Croatia", "croatia" },
                    { new Guid("48cb1fe1-dc53-4297-ab4c-d83b8515fbe5"), "images/flags/israel.svg", "Israel", "israel" },
                    { new Guid("4ffd1636-b9c1-47aa-b20e-0d02a5182348"), "images/flags/albania.svg", "Albania", "albania" },
                    { new Guid("5456e649-bf0a-4507-b60d-251aa750cc4c"), "images/flags/palestine.svg", "Palestine", "palestine" },
                    { new Guid("597558ac-0f1c-4eeb-8751-71bf881d3d78"), "images/flags/cameroon.svg", "Cameroon", "cameroon" },
                    { new Guid("59784003-0163-470e-8238-e63c2be3ebb0"), "images/flags/china.svg", "China", "china" },
                    { new Guid("63a80847-172c-41e9-b35f-40d8c1237ab1"), "images/flags/pakistan.svg", "Pakistan", "pakistan" },
                    { new Guid("63dee376-5006-44fc-a763-730cd9bbff8a"), "images/flags/canada.svg", "Canada", "canada" },
                    { new Guid("65284b4a-374a-4144-9509-3598b4c270fd"), "images/flags/peru.svg", "Peru", "peru" },
                    { new Guid("6e12219e-44e5-495a-8fbc-d0f74848014b"), "images/flags/bahamas.svg", "Bahamas", "bahamas" },
                    { new Guid("732f69b7-13c1-449c-ac71-502bb36512e8"), "images/flags/india.svg", "India", "india" },
                    { new Guid("76009c1d-0de7-44e7-a8ca-bd9d6a0a816b"), "images/flags/italy.svg", "Italy", "italy" },
                    { new Guid("779f2d29-d9da-46d8-a78f-e6ca5a393a5b"), "images/flags/venezuela.svg", "Venezuela", "venezuela" },
                    { new Guid("77bce5a9-8530-4a4c-92bf-1b922efaf625"), "images/flags/turkey.svg", "Turkey", "turkey" },
                    { new Guid("7a6b2878-a943-4d1f-b7ab-458caeb158e8"), "images/flags/ireland.svg", "Ireland", "ireland" },
                    { new Guid("7b1b2a17-156a-413d-b57e-c49fead48e22"), "images/flags/ghana.svg", "Ghana", "ghana" },
                    { new Guid("7f8cc654-9cea-46c9-af92-ae1ee272677a"), "images/flags/philippines.svg", "Philippines", "philippines" },
                    { new Guid("802f65b6-6c64-494f-a1eb-802d5cc594d6"), "images/flags/portugal.svg", "Portugal", "portugal" },
                    { new Guid("8249285d-6244-4de6-a79a-55ca989bed88"), "images/flags/afghanistan.svg", "Afghanistan", "afghanistan" },
                    { new Guid("8549307c-e92b-4c90-899c-35e67eb02732"), "images/flags/monaco.svg", "Monaco", "monaco" },
                    { new Guid("86c98c7f-35f2-44e7-b44c-a2603cfd17c2"), "images/flags/kuwait.svg", "Kuwait", "kuwait" },
                    { new Guid("86e7903b-1f81-4534-8f6a-1cb6b7ad5782"), "images/flags/serbia.svg", "Serbia", "serbia" },
                    { new Guid("8b8aab18-f234-4919-b233-e27e6485811e"), "images/flags/australia.svg", "Australia", "australia" },
                    { new Guid("8bd372dc-061f-4bfa-ae4e-53b726330f1b"), "images/flags/azerbaijan.svg", "Azerbaijan", "azerbaijan" },
                    { new Guid("8c7a2ce6-9f2f-4bdd-83d6-b24801310760"), "images/flags/germany.svg", "Germany", "germany" },
                    { new Guid("8ccb0c9f-5ade-4e99-b4e7-9e9809d20682"), "images/flags/poland.svg", "Poland", "poland" },
                    { new Guid("8ed7b64f-1a56-4d9d-ba35-fd2f83047f1e"), "images/flags/netherlands.svg", "Netherlands", "netherlands" },
                    { new Guid("8ffc8e08-3a94-4da1-a504-1cd3cb08eff5"), "images/flags/france.svg", "France", "france" },
                    { new Guid("902d5369-17e0-45b9-9367-9ced0cedeb6c"), "images/flags/angola.svg", "Angola", "angola" },
                    { new Guid("962dea70-2f53-4753-8ea4-52cbb31d4175"), "images/flags/brazil.svg", "Brazil", "brazil" },
                    { new Guid("96b22919-3f04-43b3-a4c2-f9691e523936"), "images/flags/jamaica.svg", "Jamaica", "jamaica" },
                    { new Guid("99e67deb-d8aa-48cf-b011-afc6e37ad21d"), "images/flags/costa_rica.svg", "Costa Rica", "costa-rica" },
                    { new Guid("9b880c26-de06-41b1-8579-e31b7c70ebef"), "images/flags/cuba.svg", "Cuba", "cuba" },
                    { new Guid("9c738db6-b1b0-4367-8173-30f60b8550fb"), "images/flags/qatar.svg", "Qatar", "qatar" },
                    { new Guid("9e42a217-8054-4cee-8b7a-087fe95a79f9"), "images/flags/argentina.svg", "Argentina", "argentina" },
                    { new Guid("9eb0882c-e56c-4a7e-8c03-e1997f1b787e"), "images/flags/iceland.svg", "Iceland", "iceland" },
                    { new Guid("a05f52e8-51f7-4626-8329-feb7f5cb5249"), "images/flags/south_korea.svg", "South Korea", "south-korea" },
                    { new Guid("a308e22f-bf3c-4787-97ba-ed2baf1db7ba"), "images/flags/armenia.svg", "Armenia", "armenia" },
                    { new Guid("a6ddb27c-0eba-4c64-b926-95a839ce03e8"), "images/flags/dominican_republic.svg", "Dominican Republic", "dominica-republic" },
                    { new Guid("b61f5b0d-a6b5-4189-9af2-3752028727ed"), "images/flags/thailand.svg", "Thailand", "thailand" },
                    { new Guid("beeb07ec-a1f2-474f-aaca-67e544db05b3"), "images/flags/antigua_barbuda.svg", "Antigua & Barbuda", "antigua-and-barbuda" },
                    { new Guid("bf94588a-8cb3-46d9-a17e-5878cdafe268"), "images/flags/panama.svg", "Panama", "panama" },
                    { new Guid("c28bd523-8245-46bf-83fa-8c1e95a764e4"), "images/flags/trinidad&tobago.svg", "Trinidad & Tobago", "trinidad-and-tobago" },
                    { new Guid("c3dbc242-ab34-4c47-9707-a2195187915e"), "images/flags/south_africa.svg", "South Africa", "south-africa" },
                    { new Guid("c7be5a6f-4a9a-4da4-8910-7e3f9355f3cb"), "images/flags/egypt.svg", "Egypt", "egypt" },
                    { new Guid("cf88669c-827f-463a-a6cf-75cb10faa93b"), "images/flags/el_salvador.svg", "El Salvador", "el-salvador" },
                    { new Guid("d37b096d-86dc-4deb-ba2a-ed067b1d3cc2"), "images/flags/russia.svg", "Russia", "russia" },
                    { new Guid("da874b21-e67c-4560-993b-e61c4ea282fd"), "images/flags/uae.svg", "UAE", "united-arab-emirates" },
                    { new Guid("dfe7829b-4d19-4db5-ae73-d896709e3d33"), "images/flags/spain.svg", "Spain", "spain" },
                    { new Guid("e60e384e-a7cf-411a-9362-76d0aeec619b"), "images/flags/belgium.svg", "Belgium", "belgium" },
                    { new Guid("eb014b54-2b8e-4ce8-ac17-d0b14c60e1ae"), "images/flags/greece.svg", "Greece", "greece" },
                    { new Guid("f1269377-754b-437e-b8e2-3c3b26d160d7"), "images/flags/fiji.svg", "Fiji", "fiji" },
                    { new Guid("f30dd8f5-4c4a-4eb4-b28d-0e559b1dea75"), "images/flags/sweden.svg", "Sweden", "sweden" },
                    { new Guid("f3e6e63c-a7a0-4090-9326-ccd5e2dc5008"), "images/flags/morocco.svg", "Morocco", "morocco" },
                    { new Guid("f79788fc-c9a9-4f15-9ea3-ce375205d15c"), "images/flags/andorra.svg", "Andorra", "andorra" },
                    { new Guid("f9899140-d549-4c9e-8d05-e12b5ea83623"), "images/flags/ecuador.svg", "Ecuador", "ecuador" },
                    { new Guid("fbbee294-de2d-4f6a-93ab-b6df3853e64a"), "images/flags/bolivia.svg", "Bolivia", "bolivia" }
                });

            migrationBuilder.InsertData(
                table: "Ingredients",
                columns: new[] { "Id", "Measurement", "Name", "Quantity", "RecipeId" },
                values: new object[,]
                {
                    { new Guid("624aaf79-8a0a-4e07-b7ae-3228ac6b8bd9"), "cups", "Flour", 2m, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8") },
                    { new Guid("d3d4f946-ad13-4c2b-960e-9cea2cc38329"), "cup", "Sauce", 1m, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8") },
                    { new Guid("e393ee0f-750e-4073-b3d9-e63bf19ab5fe"), "", "Egg", 2m, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8") }
                });

            migrationBuilder.InsertData(
                table: "Instructions",
                columns: new[] { "Id", "Order", "RecipeId", "Step" },
                values: new object[,]
                {
                    { new Guid("5051f18a-8618-4beb-b97b-e8e624ab2200"), 2, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"), "Whisk until eggs form into a foam-like white texture." },
                    { new Guid("60c30f84-d112-4c80-9837-e97600a43434"), 1, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"), "Crack eggs and add to mixing bowl." },
                    { new Guid("95a60176-994b-42f7-a5e0-10dafa06da2f"), 3, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"), "Add arrowroot starch to mixing bowl and other spices of your choosing." },
                    { new Guid("b4308569-9e4e-43c4-b211-329eadf3e62b"), 4, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"), "Place inside the over that has been preheated to 350 degrees Fahrenheit for 8-10 minutes." },
                    { new Guid("d0468a9c-b3ef-42f8-823a-6fb4adb003ec"), 6, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"), "Place back into the over for 12-15 minutes." },
                    { new Guid("e45c3910-4120-4c3f-a73c-9fd7841ffbab"), 7, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"), "Let the pizza cool for at least 5 minutes and enjoy!" },
                    { new Guid("ee9d51cd-6663-4fe0-8219-c4aa83967adc"), 5, new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"), "Layer the sauce, then the cheese and lastly the toppings." }
                });

            migrationBuilder.UpdateData(
                table: "Recipes",
                keyColumn: "Id",
                keyValue: new Guid("3968256e-9c61-4415-bfe2-4c1092be12d8"),
                column: "PublishedAt",
                value: new DateTime(2025, 1, 9, 14, 56, 34, 295, DateTimeKind.Utc).AddTicks(6180));
        }
    }
}
