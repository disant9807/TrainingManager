using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingManager.Logic.Migrations
{
    public partial class AddDataFromCategoryOfBodyFromCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Back");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Chest");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "legs");

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Akromion", null, "Латеральный конец лопаточной кости, сочленяющийся с акромиальной суставной поверхностью ключицы. Акромион образует вершину плеча, и представляет собой большую, немного треугольную или прямоугольную продолговатую форму, сплющенную сзади,которая выступает сначала поперечно, а затем изгибается вперед и вверх, чтобы выступать над суставной впадиной .[1]", false, "Акромион", "Акромион" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Bedrennayakostpodkolennayapoverhnost", null, "", false, "Бедренная кость, подколенная поверхность", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "BedroLateralnyjMyshchelok", null, "", false, "Бедро, латеральный мыщелок", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Bedromedialnyjmyshchelok", null, "", false, "Бедро, медиальный мыщелок", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Belayaliniyazhivota", null, "", false, "Белая линия живота", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Bicepsbedra", null, "", false, "Бицепс бедра", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "BicepsDvuglavayaMyshcaPlecha", null, "Большая мышца плеча, хорошо заметна под кожей.Сгибает плечо в плечевом суставе, предплечье в локтевом.", false, "Бицепс (двуглавая мышца) плеча", "Бицепс плеча" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "BicepsPlechaDlannayaGolovka", null, "", false, "Бицепс плеча, дланная головка", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Bolshayagrudnayamyshca", null, "", false, "Большая грудная мышца", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "BolshayaGrudnayaMyshcaAbdominalnayaChast", null, "Крупная поверхностная мышца веерообразной формы, расположенная на передней поверхности груди. Под ней находится треугольной формы малая грудная мышца.Абдоминальная часть: начинается на передней стенке прямой мышцы живота", false, "Болшая грудная мышца, абдоминальная часть", "Грудная мышца, абдоминальная часть" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "BolshayaGrudnayaMyshcaGrudinoRebernayaChast", null, "Крупная поверхностная мышца веерообразной формы, расположенная на передней поверхности груди. Под ней находится треугольной формы малая грудная мышца.Грудино-реберная часть: начинается на передней поверхности грудины и хрящей верхних шести рёбер.", false, "Болшая грудная мышца, грудино-реберная часть", "Грудная мышца, грудино-реберная часть" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Bolshayakruglayamyshca", null, "", false, "Большая круглая мышца", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "BolshayaMyshcaSpiny", null, "Поверхностная мышца, занимающая всю нижнюю часть спины, верхние пучки в начальной части прикрыты трапециевидной мышцей.Приводит плечо к туловищу и тянет верхнюю конечность назад к срединной линии, вращая её внутрь — пронация. Если верхняя конечность закреплена, приближает к ней туловище и может расширять грудную клетку, служа вспомогательной дыхательной мышцей.", false, "Большая мышца спины", "Большая мышца спины" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Bolshayaprivodyashchayamyshchca", null, "", false, "Большая приводящая мыщца", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Bolshayarombovidnayamyshca", null, "", false, "Большая ромбовидная мышца", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "BolshayaYagodichnayaMyshca", null, "", false, "Большая ягодичная мышца", "Большая ягодичная мышца" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "BolshayaZubchatayaMyshca", null, "Расположена в переднем отделе грудной стенки. Верхняя её часть прикрыта большой грудной мышцей, нижняя расположена поверхностно, прикрыта грудной фасцией. Начинается 8—9 зубцами от наружной поверхности 8—9 рёбер, а также от сухожильной дуги между 1-м и 11-м рёбрами. Направляется назад и вверх, покрывает наружную поверхность рёбер, затем подходит под лопатку и прикрепляется вдоль её медиального края, а также к её нижнему углу. Наиболее выражены те части мышцы, место прикрепления которых располагается в области нижнего угла лопатки.", false, "Большая зубчатая мышца", "Большая зубчатая мышца" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Bolshebercovayakostmedialnayapoverhnost", null, "", false, "Большеберцовая кость, медиальная поверхность", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "BolshojVertel", null, "", false, "Большой вертел", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "BugristostbolshebercovojKosti", null, "", false, "Бугристость большеберцовой кости", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Bugristostpyatochnojkosti", null, "", false, "Бугристость пяточной кости", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "DeltovidnayaMyshca", null, "Дельтовидная мышца — в анатомии человека — поверхностная мышца плеча, образующая его наружный контур. Принимает участие в сгибании и разгибании плеча, отведении руки в сторону. Название «дельтовидная» происходит по схожести треугольной формы мышцы с греческой буквой Δ (дельта).", false, "Дельтовидная мышца", "Дельтовидная мышца" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Detalnayafalanga", null, "", false, "Детальная фаланга", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Distalnayafalanga", null, "", false, "Дистальная фаланга", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "DlinnayaLadonnayaMyshca", null, "имеет короткое веретенообразное брюшко и очень длинное сухожилие. Лежит непосредственно под кожей, внутри от лучевого сгибателя запястья. Начинается от плечевой кости, межмышечной перегородки и фасции предплечья, подойдя к кисти, переходит в широкий ладонный апоневроз. Относится к рудиментам человеческого тела. Ранее служила для лазания по деревьям у обезьян. Общеизвестным фактом является то, что приблизительно у 15 % людей отсутствует сухожилие данной мышцы.", false, "Длинная ладонная мышца", "Длинная ладонная мышца" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "DlinnayaMalobercovayaMyshca", null, "", false, "Длинная малоберцовая мышца", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Dlinnayamyshcaotvodyashchayabolshojpaleckisti", null, "", false, "Длинная мышца, отводящая большой палец кисти", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Dlinnayaprivodyashchayamyshca", null, "", false, "Длинная приводящая мышца", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Dlinnyjluchevojrazgibatelzapyastya", null, "", false, "Длинный лучевой разгибатель запястья", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "DlinnyjRazgibatelBoshogoPalcaStopy", null, "", false, "Длинный разгибатель большого пальца стопы", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "DlinnyjRazgibatelPalcevStopy", null, "", false, "Длинный разгибатель пальцев стопы", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Dlinnyjsgibatelbolshogopalcakisti", null, "", false, "Длинный сгибатель большого пальца кисти", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "DlinnyjSgibatelBolshogoPalcaStopy", null, "", false, "Длинный сгибатель большого пальца стопы", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Dlinnyjsgibatelbolshogopalcevstopy", null, "", false, "Длинный сгибатель большого пальцев стопы", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Dlinnyjsgibatelpalcevstopy", null, "", false, "Длинный сгибатель пальцев стопы", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Gorohovdnayamyshcaotvodyashchayabolshojpaleckisti", null, "", false, "Гороховдная мышца, отводящая большой палец кисти", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "GrebenchatayaMyshca", null, "", false, "Гребенчатая мышца", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Grebenlopatki", null, "", false, "Гребень лопатки", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Grudina", null, "Продолговатая плоская кость в середине груди. Соединяется с рёбрами при помощи хрящей, формируя вместе с ними грудную клетку, вмещающую и защищающую от внешнего воздействия лёгкие, сердце и важнейшие кровеносные сосуды.", false, "Грудина", "Грудина" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "GrudinoKlyuchichnoSosceviddnayaMyshca", null, "Грудино-ключично-сосцевидная мышца представляет собой довольно крупный мышечный тяж на переднебоковой поверхности шеи. Располагается под подкожной мышцей шеи, отделяясь от нее шейной фасцией. Соединяет череп с грудиной и ключицей, разделяя шею на передний и задний треугольники.", false, "Грудино-ключично-сосцевиддная мышца", "Грудино-ключично-сосцевиддная" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Grudinopoyazychnayamyshca", null, "", false, "Грудино-поъязычная мышца", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Grudnojpozvonokostistyjostrovok", null, "", false, "Грудной позвонок, остистый островок", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Ikronozhnayamyshca", null, "", false, "Икроножная мышца", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "IkronozhnayaMyshcaLateralnayaGolovka", null, "", false, "Икроножная мышца, латеральная головка", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Ikronozhnayamyshcamedialnayagolovka", null, "", false, "Икроножная мышца, медиальная головка", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Ikronozhnayamyshcasuhozhilie", null, "", false, "Икроножная мышца, сухожилие", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "KambalovidnayaMyshca", null, "", false, "Камбаловидная мышца", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "KambapavidnayaMyshca", null, "", false, "Камбапавидная мышца", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Klyuchica", null, "в анатомии человека — небольшая трубчатая кость S-образной формы из пояса верхней конечности, соединяющая лопатку с грудиной и укрепляющая плечевой пояс.", false, "Ключица", "Ключица" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Klyuvovidnoplechevayamyshca", null, "", false, "Клювовидно-плечевая мышца", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "KorotkayaMalobercovayaMyshca", null, "", false, "Короткая малоберцовая мышца", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Korotkayamyshcaotvodyashchayabolshojpaleckisti", null, "", false, "Короткая мышца, отводящая большой палец кисти", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Korotkijluchevojrvzgibatelzapyastya", null, "", false, "Короткий лучевой рвзгибатель запястья", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "KorotkijRazgibatelBolshogopalca", null, "", false, "Короткий разгибатель большого пальца", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "KorotkijRazgibatelPalcevStopy", null, "", false, "Короткий разгибатель пальцев стопы", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Kosayavnutrennyayamyshcazhivota", null, "", false, "Косая внутренняя мышца живота", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Kosayavnutrennyayamyshcazhivotapodaponevrozom", null, "", false, "Косая внутренняя мышца живота (под апоневрозом)", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Krestecdorsalnayapoverhnost", null, "", false, "Крестец, дорсальная поверхность", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Kruglyjpronator", null, "", false, "Круглый пронатор", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Ladevidnaya", null, "", false, "Ладьевидная кость", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Ladonnyjaponevroz", null, "", false, "Ладонный апоневроз", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "LateralnayaLodyshka", null, "", false, "Латеральная лодышка", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Lateralnayashirokayamyshcabedra", null, "", false, "Латеральная широкая мышца бедра", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Lateralnyjnadmyshchelok", null, "", false, "Латеральный надмыщелок", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "LestnichnayaMyshca", null, "Лестничные мышцы — мышцы шеи глубокого слоя боковой (латеральной) группы.Лестничные мышцы поднимают верхние рёбра, действуя как мышца вдоха. При фиксированных рёбрах, сокращаясь с обеих сторон, они сгибают шейную часть позвоночника спереди, а при одностороннем сокращении сгибают и поворачивают её в свою сторону.", false, "Лестничная мышца", "Лестничная мышца" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "LoktevayaMyshca", null, "Небольшая пирамидальная мышца, являющаяся как бы продолжением медиальной головки трёхглавой мышцы плеча. Начинается от латерального надмыщелка плечевой кости и от лучевой коллатеральной связки. Прикрепляется к задней поверхности локтевого отростка, срастаясь с капсулой локтевого сустава.", false, "Локтевая мышца", "Локтевая мышца" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Loktevojotrostok", null, "", false, "Локтевой отросток", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Loktevojrazgibatelzapyastya", null, "", false, "Локтевой разгибатель запястья", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Loktevojsgibatelzapyastya", null, "", false, "Локтевой сгибатель запястья", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Lopatochnopodyazychnayamyshcanizhneeboyushk", null, "", false, "Лопаточно-подъязычная мышца, нижнее боюшко", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "LopatochnoPodyazychnayaMyshcaNizhneeBryushko", null, "парная мышца передней поверхности шеи из группы подподъязычных. Имеет длинную уплощенную форму, разделена сухожилием на два брюшка.", false, "Лопаточно-подъязычная мышца, нижнее брюшко", "Лопаточно-подъязычная" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Luchevojsgibatelzapyastya", null, "", false, "Лучевой сгибатель запястья", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Malayakruglayamyshca", null, "", false, "Малая круглая мышца", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "MedialayaKlinovidnayaKost", null, "", false, "Медиальая клиновидная кость", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "MedialnayaLodyzhka", null, "", false, "Медиальная лодыжка", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Medialnayashirokayamyshcabedra", null, "", false, "Медиальная широкая мышца бедра", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Menisk", null, "", false, "Мениск", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "MyshcaOtvodyashchayaBolshojPalecStopy", null, "", false, "Мышца, отводящая большой палец стопы", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "MyshcaOtvodyashchayaMizinecStopy", null, "", false, "Мышца, отводящая мизинец стопы", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "MyshcaPodnimayushchayaLopatku", null, "ШМышца, поднимающая лопатку, — располагается под трапециевидной мышцей. Начинаясь от задних бугорков поперечных отростков 4 верхних шейных позвонков, четырьмя отдельными сухожильными пучками, соединяется (иногда представлена несколькими отдельными мышцами) идет вниз и латерально, прикрепляясь к верхнему отделу медиального края лопатки и верхнему углу лопатки.", false, "Мышца, поднимающая лопатку", "Поднимающая лопатку" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Myshcapodnimayushchayayaichko", null, "", false, "Мышца, поднимающая яичко", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Nadkolennik", null, "", false, "Надколенник", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "NapryagatelShirokojFascii", null, "", false, "Напрягатель широкой фасции", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Naruzhnayakosayamyshcazhivota", null, "", false, "Наружная косая мышца живота", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Perednyayabolshebercovayamyshca", null, "", false, "Передняя большеберцовая мышца", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Perednyayazubchatayamyshca", null, "", false, "Передняя зубчатая мышца", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "PervayaPlyusnevayaKost", null, "", false, "Первая плюсневая кость", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Piramidalnayamyshcapodaponevrozom", null, "", false, "Пирамидальная мышца, под апоневрозом", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "PlecheluchevayaMyshca", null, "Мышца предплечья передней группы.Сгибает предплечье в локтевом суставе и устанавливает лучевую кость в положении, среднем между пронацией и супинацией.", false, "Плечелучевая мышца", "Плечелучевая мышца" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "PlechevayaMyshca", null, "лежит глубже двуглавой мышцы плеча, начинается от передней поверхности плечевой кости и от обеих межмышечных перегородок, прикрепляется к бугристости локтевой кости.", false, "Плечевая мышца", "Плечевая мышца" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Podoshvennayamyshca", null, "", false, "Подошвенная мышца", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Podostnayamyshca", null, "", false, "Подостная мышца", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "PodshovennayaMyshca", null, "", false, "Подшовенная мышца", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "PodvzdoshnayaKost", null, "", false, "Подвздошная кость", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Podvzdoshnayaost", null, "", false, "Подвздошная ость", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "PodvzdoshnoBolshebercovyjTrakt", null, "", false, "Подвздошно-большеберцовый тракт", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Podvzdoshnoepoyasnichnayamyshca", null, "", false, "Подвздошное поясничная мышца", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Podvzdoshnopoyasnichnayamyshca", null, "", false, "Подвздошно-поясничная мышца", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "PoluosistayaMyshcaGolovy", null, "Полуостистая мышца головы располагается между поперечными отростками 5 верхних грудных позвонков и 3—4 нижних шейных с одной стороны и выйной площадкой затылочной кости – с другой. Посередине медиальной части мышцы располагается сухожильная перемычка.", false, "Полуосистая мышца головы", "Полуосистая головная" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Polusuhozhilnayamyshca", null, "", false, "Полусухожильная мышца", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "PortnyazhnayaMyshca", null, "", false, "Портняжная мышца", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "PoverhnostnyjSgibatelPalcevKisti", null, "Мышца передней группы предплечья.Спереди мышца прикрыта длинной ладонной мышцей и лучевым сгибателем запястья, которые оставляют на ней след в виде борозд.", false, "Поверхностный сгибатель пальцев кисти", "Поверхностные сгибатель пальцев кисти" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Poverhostnyjsgibatelpalcevruki", null, "", false, "Поверхостный сгибатель пальцев руки", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Poyasnichnyjtreugolnik", null, "", false, "Поясничный треугольник", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Proksimalnayafalanga", null, "", false, "Проксимальная фаланга", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "PromezhutochnayaShirokayaMyshcaBedra", null, "", false, "Промежуточная широкая мышца бедра", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Pryamayamyshcabedra", null, "", false, "Прямая мышца бедра", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "PryamayaMyshcaZhivota", null, "", false, "Прямая мышца живота", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Pupochnoekolco", null, "", false, "Пупочное кольцо", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "PyatochnoeSuhozhilie", null, "", false, "Пяточное сухожилие", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "RazgebatelPalcevKisti", null, "Мышца предплечья задней группы", false, "Разгебатель пальцев кисти", "Разгебатель пальцев кисти" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Razgibatelpalcevkistisuhozhilie", null, "", false, "Разгибатель пальцев кисти, сухожилие", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "RemennayaMyshcaGolovy", null, "начинается от выйной связки, остистых отростков III- Vii шейного и 3 верхних грудных позвонков идет вверх и латерально и прикрепляется к боковому отделу верхней выйной линии и вдоль заднего края сосцевидного отростка. Прикрыта верхним отделом трапециевидной мышцы. При одностороннем сокращении мышца поворачивает голову в свою сторону, при двустороннем сокращении мышца разгибает шейную часть позвоночника и наклоняет голову назад.", false, "Ременная мышца головы", "Ременная головная" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Sedmojshejnyepozvonokostistyjostrovok", null, "", false, "Седьмой шейные позвонок, остистый островок", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "ShejkaMalobercovojKosti", null, "", false, "Шейка малоберцовой кости", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "SrednyayaYagodichnayaMyshca", null, "", false, "Средняя ягодичная мышца", "Средняя ягодичная мышца" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "SrednyayaYagodichnayaMyshcaPodYagodichnojFasciej", null, "", false, "Средняя ягодичная мышца, под ягодичной фасцией", "Средняя ягодичная мышца, под ягодичной фасцией" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Svyazkanadkolennika", null, "", false, "Связка надколенника", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "TarannayaKost", null, "", false, "Таранная кость", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Tenar", null, "", false, "Тенар", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Tonkayamyshca", null, "", false, "Тонкая мышца", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Torakolyumbalnayafasciya", null, "", false, "Тораколюмбальная фасция", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Trapecevidnayamyshca", null, "", false, "Трапецевидная мышца", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "TrapecividnayaMyshca", null, "Трапециеви́дная мы́шца — плоская широкая мышца, занимающая поверхностное положение в задней области шеи и в верхнем отделе спины. Трапециевидная мышца имеет форму треугольника, основанием обращённого к позвоночному столбу, а вершиной — к акромиону лопатки. Трапециевидные мышцы обеих сторон спины вместе, как ни странно, имеют форму не трапеции (так как нет пары параллельных краёв мышцы и пары непараллельных краёв), а дельтоида — фигуры, образованной двумя симметричными треугольниками.", false, "Трапецивидная мышца", "Трапецивидная мышца" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "TretyaMalobercovayaMyshca", null, "", false, "Третья малоберцовая мышца", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "TricepsPlecha", null, "", false, "Трицепс плеча", "" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "TricepsTrekhglavayaMyshcaPlechaDlinnayaGolovka", null, "Мышца-разгибатель задней группы плеча, занимает всю заднюю сторону плеча. От подсуставного бугорка лопатки;", false, "Трицепс, трехглавая мышца плеча, длинная головка", "Трицепс, Трехглавая плеча, длинная гловка" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "TricepsTrekhglavayaMyshcaPlechaLateralnayaGolovka", null, "Мышца-разгибатель задней группы плеча, занимает всю заднюю сторону плеча. От задней поверхности плеча", false, "Трицепс, трехглавая мышца плеча, латеральная головка", "Трицепс, Трехглавая плеча, длинная гловка" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "TricepsTrekhglavayaMyshcaPlechaMedialnayaGolovka", null, "Мышца-разгибатель задней группы плеча, занимает всю заднюю сторону плеча. От задней поверхности плечевой кости, межмышечных перегородок.", false, "Трицепс, трехглавая мышца плеча, медиальная головка", "Трицепс, Трехглавая плеча, длинная гловка" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Vtorayapyastnayakost", null, "", false, "Вторая пястная кость", "" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Akromion");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Bedrennayakostpodkolennayapoverhnost");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "BedroLateralnyjMyshchelok");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Bedromedialnyjmyshchelok");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Belayaliniyazhivota");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Bicepsbedra");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "BicepsDvuglavayaMyshcaPlecha");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "BicepsPlechaDlannayaGolovka");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Bolshayagrudnayamyshca");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "BolshayaGrudnayaMyshcaAbdominalnayaChast");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "BolshayaGrudnayaMyshcaGrudinoRebernayaChast");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Bolshayakruglayamyshca");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "BolshayaMyshcaSpiny");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Bolshayaprivodyashchayamyshchca");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Bolshayarombovidnayamyshca");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "BolshayaYagodichnayaMyshca");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "BolshayaZubchatayaMyshca");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Bolshebercovayakostmedialnayapoverhnost");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "BolshojVertel");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "BugristostbolshebercovojKosti");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Bugristostpyatochnojkosti");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "DeltovidnayaMyshca");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Detalnayafalanga");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Distalnayafalanga");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "DlinnayaLadonnayaMyshca");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "DlinnayaMalobercovayaMyshca");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Dlinnayamyshcaotvodyashchayabolshojpaleckisti");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Dlinnayaprivodyashchayamyshca");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Dlinnyjluchevojrazgibatelzapyastya");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "DlinnyjRazgibatelBoshogoPalcaStopy");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "DlinnyjRazgibatelPalcevStopy");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Dlinnyjsgibatelbolshogopalcakisti");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "DlinnyjSgibatelBolshogoPalcaStopy");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Dlinnyjsgibatelbolshogopalcevstopy");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Dlinnyjsgibatelpalcevstopy");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Gorohovdnayamyshcaotvodyashchayabolshojpaleckisti");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "GrebenchatayaMyshca");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Grebenlopatki");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Grudina");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "GrudinoKlyuchichnoSosceviddnayaMyshca");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Grudinopoyazychnayamyshca");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Grudnojpozvonokostistyjostrovok");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Ikronozhnayamyshca");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "IkronozhnayaMyshcaLateralnayaGolovka");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Ikronozhnayamyshcamedialnayagolovka");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Ikronozhnayamyshcasuhozhilie");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "KambalovidnayaMyshca");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "KambapavidnayaMyshca");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Klyuchica");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Klyuvovidnoplechevayamyshca");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "KorotkayaMalobercovayaMyshca");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Korotkayamyshcaotvodyashchayabolshojpaleckisti");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Korotkijluchevojrvzgibatelzapyastya");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "KorotkijRazgibatelBolshogopalca");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "KorotkijRazgibatelPalcevStopy");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Kosayavnutrennyayamyshcazhivota");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Kosayavnutrennyayamyshcazhivotapodaponevrozom");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Krestecdorsalnayapoverhnost");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Kruglyjpronator");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Ladevidnaya");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Ladonnyjaponevroz");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "LateralnayaLodyshka");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Lateralnayashirokayamyshcabedra");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Lateralnyjnadmyshchelok");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "LestnichnayaMyshca");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "LoktevayaMyshca");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Loktevojotrostok");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Loktevojrazgibatelzapyastya");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Loktevojsgibatelzapyastya");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Lopatochnopodyazychnayamyshcanizhneeboyushk");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "LopatochnoPodyazychnayaMyshcaNizhneeBryushko");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Luchevojsgibatelzapyastya");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Malayakruglayamyshca");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "MedialayaKlinovidnayaKost");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "MedialnayaLodyzhka");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Medialnayashirokayamyshcabedra");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Menisk");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "MyshcaOtvodyashchayaBolshojPalecStopy");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "MyshcaOtvodyashchayaMizinecStopy");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "MyshcaPodnimayushchayaLopatku");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Myshcapodnimayushchayayaichko");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Nadkolennik");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "NapryagatelShirokojFascii");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Naruzhnayakosayamyshcazhivota");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Perednyayabolshebercovayamyshca");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Perednyayazubchatayamyshca");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "PervayaPlyusnevayaKost");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Piramidalnayamyshcapodaponevrozom");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "PlecheluchevayaMyshca");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "PlechevayaMyshca");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Podoshvennayamyshca");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Podostnayamyshca");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "PodshovennayaMyshca");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "PodvzdoshnayaKost");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Podvzdoshnayaost");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "PodvzdoshnoBolshebercovyjTrakt");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Podvzdoshnoepoyasnichnayamyshca");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Podvzdoshnopoyasnichnayamyshca");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "PoluosistayaMyshcaGolovy");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Polusuhozhilnayamyshca");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "PortnyazhnayaMyshca");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "PoverhnostnyjSgibatelPalcevKisti");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Poverhostnyjsgibatelpalcevruki");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Poyasnichnyjtreugolnik");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Proksimalnayafalanga");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "PromezhutochnayaShirokayaMyshcaBedra");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Pryamayamyshcabedra");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "PryamayaMyshcaZhivota");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Pupochnoekolco");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "PyatochnoeSuhozhilie");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "RazgebatelPalcevKisti");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Razgibatelpalcevkistisuhozhilie");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "RemennayaMyshcaGolovy");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Sedmojshejnyepozvonokostistyjostrovok");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "ShejkaMalobercovojKosti");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "SrednyayaYagodichnayaMyshca");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "SrednyayaYagodichnayaMyshcaPodYagodichnojFasciej");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Svyazkanadkolennika");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "TarannayaKost");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Tenar");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Tonkayamyshca");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Torakolyumbalnayafasciya");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Trapecevidnayamyshca");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "TrapecividnayaMyshca");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "TretyaMalobercovayaMyshca");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "TricepsPlecha");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "TricepsTrekhglavayaMyshcaPlechaDlinnayaGolovka");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "TricepsTrekhglavayaMyshcaPlechaLateralnayaGolovka");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "TricepsTrekhglavayaMyshcaPlechaMedialnayaGolovka");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "Vtorayapyastnayakost");

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Back", null, "Спина", false, "Спина", "Спина" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "Chest", null, "Грудь", false, "Грудь", "Грудь" });

            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[] { "legs", null, "Ноги", false, "Ноги", "Ноги" });
        }
    }
}
