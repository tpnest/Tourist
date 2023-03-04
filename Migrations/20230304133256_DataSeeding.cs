using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Tourist.Migrations
{
    /// <inheritdoc />
    public partial class DataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TouristRoutes",
                columns: new[] { "Id", "CreateTime", "DepartureTime", "Description", "DiscountPresent", "Features", "Fees", "Notes", "OriginalPrice", "Title", "UpdateTime" },
                values: new object[,]
                {
                    { new Guid("2fd5c361-8922-e2cc-c7f9-cbbbfc8a3c5b"), new DateTime(1990, 2, 10, 4, 27, 45, 0, DateTimeKind.Unspecified), new DateTime(1984, 1, 12, 21, 32, 45, 0, DateTimeKind.Unspecified), "把应带安员快定质集论五府却也成型了。", 0.20000000000000001, "当那月些两电车利工层天切事示之之政。速等青价中好持化学称周志它心。至片特提非变光使点志标段儿龙是。非华细调马省处式党然时示入酸再。", "些所连层象我关无快它装集色在来目。下拉要者文该第界参书关式商。压和力证反面长个儿然酸眼除回儿西感。情给易王任里高联上期再必术算。等们是离置被影统劳验住我阶切连存。质数适年及连上度例少太养准厂实。真一因红先没法心状比长教。", "社南年圆里统采示支难面干中规状业马。", 4264m, "京亲三", new DateTime(2015, 1, 7, 0, 22, 27, 0, DateTimeKind.Unspecified) },
                    { new Guid("3dca99de-c725-be2c-2c1c-dc85ce83ee3b"), new DateTime(1999, 5, 27, 1, 38, 19, 0, DateTimeKind.Unspecified), new DateTime(2013, 3, 5, 20, 41, 55, 0, DateTimeKind.Unspecified), "然很资所示到半反权方十第老。", 0.29999999999999999, "今全国众方过细节劳安满年七。五品高要联六况民想合空比于外增除共道。值江验己指区反阶验发增马空全例。声类北山列比元质边白即新求。成从形个置联法现院新火出反代元员商。相根何二入见常入们等县识。", "事王太众东只路少重委儿直据中。县两由五程解定向家了本定节话导格小数。最南命面办效群领照选公连例加相。适政众只回动究认队学划际应打低统传阶。率济元无格基标面提联标张所万把效。速整手市龙必史东养金真团方土道。其亲市过按九反好资上或联族建集理越。", "你克调装个容连儿直县清叫则和打。", 1254m, "就音公理群", new DateTime(2016, 2, 24, 3, 8, 44, 0, DateTimeKind.Unspecified) },
                    { new Guid("3ed189fb-8c42-e494-79cf-82dddd0a0aa3"), new DateTime(1978, 6, 11, 8, 12, 50, 0, DateTimeKind.Unspecified), new DateTime(2019, 9, 13, 20, 2, 30, 0, DateTimeKind.Unspecified), "府然派信直对能受离得所温反。", 0.40000000000000002, "清新间白群子技线员走次手。线别究离地具制北以除队电广织属个。少却大两目精小矿和周果时较便。族路件三做且音员支话律列老集。以查构走把战使林该调你性个收身名通。", "市完色美新当却三等亲消关花深。本该教斯养科处放称车广属白关连发。团大识系研史划究越张义段白包话。织活历通加声向们物斗料须器心通。", "金相内工条根律联正律身示领。", 45412m, "花业率再往存", new DateTime(2011, 9, 29, 16, 41, 57, 0, DateTimeKind.Unspecified) },
                    { new Guid("603e803f-ccfa-dbe4-4c1d-f75fa4a8beaf"), new DateTime(2022, 1, 30, 10, 50, 31, 0, DateTimeKind.Unspecified), new DateTime(1990, 5, 11, 9, 28, 55, 0, DateTimeKind.Unspecified), "受南部清八速许率四离府铁团面处。", 0.40000000000000002, "约非系运斗维维头再于北按结易律队机离。条可见金指证着到素产车识回声市。成感支想住空象见类放发上问。维者多元火即知调去府再要主马但山。上火单当毛子极到年温以着生。用小间状铁取育当整周厂九农。完响基革件口决物则号手老织整带压质何。", "带该阶马他然四如学就约平任十。上红育市反广养矿很米着不产周养。议体育机着响米结还七从华并入处料手一。实思边白争万由龙料用传声示。容众极情易时设十快状技存海置风自。须期长求社二都真深代越适般由在局容。从决带阶京住活少要信社己细处于极备。", "命育文度上确各支目治调县活前只。", 54555m, "观斯两没据办", new DateTime(1981, 12, 29, 2, 56, 43, 0, DateTimeKind.Unspecified) },
                    { new Guid("73e6dcc5-9def-e835-dcea-36f2959dc1dd"), new DateTime(1991, 11, 17, 21, 28, 55, 0, DateTimeKind.Unspecified), new DateTime(2018, 2, 12, 16, 12, 21, 0, DateTimeKind.Unspecified), "西很最科天什使布基经八及于史民类于毛。", 0.10000000000000001, "众响两压心万老们子问和张算平科。的通候维京关织约少无与还成。列得开新之王产需设标决名难受按月。成原油及真局事情须划种实断。完下为间业型主然今于其再革很治再就。", "事易场织使题阶说江工细由眼各她来。东知声果而里林也石气向方圆阶约调。身因传力思今它区重打手况从下听发。有指心术争军名话这养造话后选已会制。", "过何拉标叫做门第器王型用众取。", 565m, "求学直王毛非", new DateTime(1996, 11, 9, 0, 32, 50, 0, DateTimeKind.Unspecified) },
                    { new Guid("cb7abc8a-6cf2-fbe3-4ff3-dfc8c67cb1fe"), new DateTime(1972, 10, 27, 9, 57, 29, 0, DateTimeKind.Unspecified), new DateTime(1975, 3, 31, 0, 44, 59, 0, DateTimeKind.Unspecified), "至权今米状治般目每团北总商。", 0.40000000000000002, "争深分有来务存边能然指厂工么我。立成了数龙离示并强号外住立易进青严。重还改色多主青志团回在调土。精离集飞个织国局物成争目领前听万。", "石济约性号最你它低层队斯么品己部。情拉示何清委识方权龙空周身准场。目组更打则断增识斗眼列确月革多好多体。离极大结术离低四身新用导世院。果元非小先声片必收效同数深个同看。土难群色图存县量受该面光。", "打口三报已中类定具三五计式场权法。", 5623m, "光而军积", new DateTime(2015, 10, 10, 19, 8, 23, 0, DateTimeKind.Unspecified) },
                    { new Guid("cfcd0d3f-7fdd-fe67-a34a-ef4e6fc2f86b"), new DateTime(1987, 10, 17, 18, 26, 43, 0, DateTimeKind.Unspecified), new DateTime(2019, 3, 9, 14, 10, 22, 0, DateTimeKind.Unspecified), "位家至个能原构接土往引重毛积度。", 0.5, "每安油先区少过全作此群何相。备现将造青强原打且空命动义参。活维文知定建作车置目思示。做以她每却又流展都却先照查。取因众战回极约管只住清带群来化。学名单界期气进决已育心何命车。", "家清历身局几次科在展身回经族。利成器解劳五支起得飞任住商。林看市达同感多斯而基相名适报。义容经增始此太细八性到证放速土。", "算红时引白青型重市老火增叫引南前走。", 1859m, "计合极构化照", new DateTime(1988, 12, 21, 18, 52, 1, 0, DateTimeKind.Unspecified) },
                    { new Guid("e5a4c0fa-1c63-fdef-0ec6-cd28553deeb5"), new DateTime(2005, 1, 31, 9, 57, 13, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 11, 13, 20, 20, 0, DateTimeKind.Unspecified), "候查维此和济设能还即太其定拉。", 0.40000000000000002, "结都区近维把所外个划我置。声百离已拉国比连八都快土毛自以。走什需都话员油较于管命器当便万电。义自亲别等气切院准边七空力严取转机层。众厂许持安程型果府备方成出风收展为前。专向民再被对声何红本山同较间开资才。", "高人后马备也如克率同值率两土即。发定南存并文有整验马百性清。口南需接县阶矿其后计位求很号。及王快效断新取也活满外许本要要青。得出得义术里他后正计府节之消。色指查边但色况现林照准机美将教引由。", "积广作效林本运斗导共己带且。", 4562m, "第较至回", new DateTime(2012, 1, 8, 18, 48, 10, 0, DateTimeKind.Unspecified) },
                    { new Guid("f1ad8abe-dc73-2348-42a7-d4f8ffa59b5e"), new DateTime(2008, 5, 17, 21, 23, 32, 0, DateTimeKind.Unspecified), new DateTime(1996, 2, 17, 22, 5, 59, 0, DateTimeKind.Unspecified), "律东今权十细他置龙存起三边价接该。", 0.80000000000000004, "主文单号得下相设民始红多命。入每并道位入断分光过加界元。际千确做算则支入几向车具工。该候克接眼离强京基下证向育面天转如信。世状保方进学单务被起位十手他子相。", "角始况力化他资求派感转达细。相水列织来示白线七验便族需元生太民。意发行光角结把史全实委命全。手代上细精民不县用院角书行南究最。省百观又认身他所例七管百两受。", "前农眼收现然满处拉指音运。", 256.5m, "面该知水干是", new DateTime(2011, 5, 16, 14, 49, 47, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "TouristRoutePictures",
                columns: new[] { "Id", "TouristRouteId", "Url" },
                values: new object[,]
                {
                    { 1, new Guid("cfcd0d3f-7fdd-fe67-a34a-ef4e6fc2f86b"), "http://dummyimage.com/180x150" },
                    { 2, new Guid("cfcd0d3f-7fdd-fe67-a34a-ef4e6fc2f86b"), "http://dummyimage.com/180x150" },
                    { 3, new Guid("cfcd0d3f-7fdd-fe67-a34a-ef4e6fc2f86b"), "http://dummyimage.com/180x150" },
                    { 4, new Guid("cfcd0d3f-7fdd-fe67-a34a-ef4e6fc2f86b"), "http://dummyimage.com/180x150" },
                    { 5, new Guid("f1ad8abe-dc73-2348-42a7-d4f8ffa59b5e"), "http://dummyimage.com/728x90" },
                    { 6, new Guid("2fd5c361-8922-e2cc-c7f9-cbbbfc8a3c5b"), "http://dummyimage.com/728x90" },
                    { 7, new Guid("2fd5c361-8922-e2cc-c7f9-cbbbfc8a3c5b"), "http://dummyimage.com/728x90" },
                    { 8, new Guid("2fd5c361-8922-e2cc-c7f9-cbbbfc8a3c5b"), "http://dummyimage.com/728x90" },
                    { 9, new Guid("2fd5c361-8922-e2cc-c7f9-cbbbfc8a3c5b"), "http://dummyimage.com/120x240" },
                    { 10, new Guid("2fd5c361-8922-e2cc-c7f9-cbbbfc8a3c5b"), "http://dummyimage.com/120x240" },
                    { 11, new Guid("e5a4c0fa-1c63-fdef-0ec6-cd28553deeb5"), "http://dummyimage.com/120x240" },
                    { 12, new Guid("e5a4c0fa-1c63-fdef-0ec6-cd28553deeb5"), "http://dummyimage.com/120x240" },
                    { 13, new Guid("e5a4c0fa-1c63-fdef-0ec6-cd28553deeb5"), "http://dummyimage.com/728x90" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "TouristRoutePictures",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("3dca99de-c725-be2c-2c1c-dc85ce83ee3b"));

            migrationBuilder.DeleteData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("3ed189fb-8c42-e494-79cf-82dddd0a0aa3"));

            migrationBuilder.DeleteData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("603e803f-ccfa-dbe4-4c1d-f75fa4a8beaf"));

            migrationBuilder.DeleteData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("73e6dcc5-9def-e835-dcea-36f2959dc1dd"));

            migrationBuilder.DeleteData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("cb7abc8a-6cf2-fbe3-4ff3-dfc8c67cb1fe"));

            migrationBuilder.DeleteData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("2fd5c361-8922-e2cc-c7f9-cbbbfc8a3c5b"));

            migrationBuilder.DeleteData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("cfcd0d3f-7fdd-fe67-a34a-ef4e6fc2f86b"));

            migrationBuilder.DeleteData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("e5a4c0fa-1c63-fdef-0ec6-cd28553deeb5"));

            migrationBuilder.DeleteData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("f1ad8abe-dc73-2348-42a7-d4f8ffa59b5e"));
        }
    }
}
