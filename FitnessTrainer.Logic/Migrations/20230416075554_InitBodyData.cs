using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TrainingManager.Logic.Migrations
{
    /// <inheritdoc />
    public partial class InitBodyData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CategoryOfBody",
                columns: new[] { "Code", "AvatarId", "Decsription", "IsArchived", "Name", "ShortName" },
                values: new object[,]
                {
                    { "Akromion", null, "Латеральный конец лопаточной кости, сочленяющийся с акромиальной суставной поверхностью ключицы. Акромион образует вершину плеча, и представляет собой большую, немного треугольную или прямоугольную продолговатую форму, сплющенную сзади,которая выступает сначала поперечно, а затем изгибается вперед и вверх, чтобы выступать над суставной впадиной .[1]", false, "Акромион", "Акромион" },
                    { "Bedrennayakostpodkolennayapoverhnost", null, "", false, "Бедренная кость, подколенная поверхность", "" },
                    { "BedroLateralnyjMyshchelok", null, "", false, "Бедро, латеральный мыщелок", "" },
                    { "Bedromedialnyjmyshchelok", null, "", false, "Бедро, медиальный мыщелок", "" },
                    { "Belayaliniyazhivota", null, "", false, "Белая линия живота", "" },
                    { "Bicepsbedra", null, "", false, "Бицепс бедра", "" },
                    { "BicepsDvuglavayaMyshcaPlecha", null, "Большая мышца плеча, хорошо заметна под кожей.Сгибает плечо в плечевом суставе, предплечье в локтевом.", false, "Бицепс (двуглавая мышца) плеча", "Бицепс плеча" },
                    { "BicepsPlechaDlannayaGolovka", null, "", false, "Бицепс плеча, дланная головка", "" },
                    { "Bolshayagrudnayamyshca", null, "", false, "Большая грудная мышца", "" },
                    { "BolshayaGrudnayaMyshcaAbdominalnayaChast", null, "Крупная поверхностная мышца веерообразной формы, расположенная на передней поверхности груди. Под ней находится треугольной формы малая грудная мышца.Абдоминальная часть: начинается на передней стенке прямой мышцы живота", false, "Болшая грудная мышца, абдоминальная часть", "Грудная мышца, абдоминальная часть" },
                    { "BolshayaGrudnayaMyshcaGrudinoChychicnayaChast", null, "", false, "Болшая грудная мышца, ключицная часть", "Грудная мышца, ключицная часть" },
                    { "BolshayaGrudnayaMyshcaGrudinoRebernayaChast", null, "Крупная поверхностная мышца веерообразной формы, расположенная на передней поверхности груди. Под ней находится треугольной формы малая грудная мышца.Грудино-реберная часть: начинается на передней поверхности грудины и хрящей верхних шести рёбер.", false, "Болшая грудная мышца, грудино-реберная часть", "Грудная мышца, грудино-реберная часть" },
                    { "Bolshayakruglayamyshca", null, "", false, "Большая круглая мышца", "" },
                    { "BolshayaMyshcaSpiny", null, "Поверхностная мышца, занимающая всю нижнюю часть спины, верхние пучки в начальной части прикрыты трапециевидной мышцей.Приводит плечо к туловищу и тянет верхнюю конечность назад к срединной линии, вращая её внутрь — пронация. Если верхняя конечность закреплена, приближает к ней туловище и может расширять грудную клетку, служа вспомогательной дыхательной мышцей.", false, "Большая мышца спины", "Большая мышца спины" },
                    { "Bolshayaprivodyashchayamyshchca", null, "", false, "Большая приводящая мыщца", "" },
                    { "Bolshayarombovidnayamyshca", null, "", false, "Большая ромбовидная мышца", "" },
                    { "BolshayaYagodichnayaMyshca", null, "", false, "Большая ягодичная мышца", "Большая ягодичная мышца" },
                    { "BolshayaZubchatayaMyshca", null, "Расположена в переднем отделе грудной стенки. Верхняя её часть прикрыта большой грудной мышцей, нижняя расположена поверхностно, прикрыта грудной фасцией. Начинается 8—9 зубцами от наружной поверхности 8—9 рёбер, а также от сухожильной дуги между 1-м и 11-м рёбрами. Направляется назад и вверх, покрывает наружную поверхность рёбер, затем подходит под лопатку и прикрепляется вдоль её медиального края, а также к её нижнему углу. Наиболее выражены те части мышцы, место прикрепления которых располагается в области нижнего угла лопатки.", false, "Большая зубчатая мышца", "Большая зубчатая мышца" },
                    { "Bolshebercovayakostmedialnayapoverhnost", null, "", false, "Большеберцовая кость, медиальная поверхность", "" },
                    { "BolshojVertel", null, "", false, "Большой вертел", "" },
                    { "BugristostbolshebercovojKosti", null, "", false, "Бугристость большеберцовой кости", "" },
                    { "Bugristostpyatochnojkosti", null, "", false, "Бугристость пяточной кости", "" },
                    { "DeltovidnayaMyshca", null, "Дельтовидная мышца — в анатомии человека — поверхностная мышца плеча, образующая его наружный контур. Принимает участие в сгибании и разгибании плеча, отведении руки в сторону. Название «дельтовидная» происходит по схожести треугольной формы мышцы с греческой буквой Δ (дельта).", false, "Дельтовидная мышца", "Дельтовидная мышца" },
                    { "DeltovidnayaMyshcaPered", null, "", false, "Дельтовидная мышца. Передняя часть", "Дельтовидная мышца" },
                    { "DeltovidnayaMyshcaSrednya", null, "", false, "Дельтовидная мышца. Средняя часть.", "Дельтовидная мышца" },
                    { "DeltovidnayaMyshcaZad", null, "", false, "Дельтовидная мышца. Задняя часть.", "Дельтовидная мышца" },
                    { "Detalnayafalanga", null, "", false, "Детальная фаланга", "" },
                    { "Distalnayafalanga", null, "", false, "Дистальная фаланга", "" },
                    { "DlinnayaLadonnayaMyshca", null, "имеет короткое веретенообразное брюшко и очень длинное сухожилие. Лежит непосредственно под кожей, внутри от лучевого сгибателя запястья. Начинается от плечевой кости, межмышечной перегородки и фасции предплечья, подойдя к кисти, переходит в широкий ладонный апоневроз. Относится к рудиментам человеческого тела. Ранее служила для лазания по деревьям у обезьян. Общеизвестным фактом является то, что приблизительно у 15 % людей отсутствует сухожилие данной мышцы.", false, "Длинная ладонная мышца", "Длинная ладонная мышца" },
                    { "DlinnayaMalobercovayaMyshca", null, "", false, "Длинная малоберцовая мышца", "" },
                    { "Dlinnayamyshcaotvodyashchayabolshojpaleckisti", null, "", false, "Длинная мышца, отводящая большой палец кисти", "" },
                    { "Dlinnayaprivodyashchayamyshca", null, "", false, "Длинная приводящая мышца", "" },
                    { "Dlinnyjluchevojrazgibatelzapyastya", null, "", false, "Длинный лучевой разгибатель запястья", "" },
                    { "DlinnyjRazgibatelBoshogoPalcaStopy", null, "", false, "Длинный разгибатель большого пальца стопы", "" },
                    { "DlinnyjRazgibatelPalcevStopy", null, "", false, "Длинный разгибатель пальцев стопы", "" },
                    { "Dlinnyjsgibatelbolshogopalcakisti", null, "", false, "Длинный сгибатель большого пальца кисти", "" },
                    { "DlinnyjSgibatelBolshogoPalcaStopy", null, "", false, "Длинный сгибатель большого пальца стопы", "" },
                    { "Dlinnyjsgibatelbolshogopalcevstopy", null, "", false, "Длинный сгибатель большого пальцев стопы", "" },
                    { "Dlinnyjsgibatelpalcevstopy", null, "", false, "Длинный сгибатель пальцев стопы", "" },
                    { "Gorohovdnayamyshcaotvodyashchayabolshojpaleckisti", null, "", false, "Гороховдная мышца, отводящая большой палец кисти", "" },
                    { "GrebenchatayaMyshca", null, "", false, "Гребенчатая мышца", "" },
                    { "Grebenlopatki", null, "", false, "Гребень лопатки", "" },
                    { "Grudina", null, "Продолговатая плоская кость в середине груди. Соединяется с рёбрами при помощи хрящей, формируя вместе с ними грудную клетку, вмещающую и защищающую от внешнего воздействия лёгкие, сердце и важнейшие кровеносные сосуды.", false, "Грудина", "Грудина" },
                    { "GrudinoKlyuchichnoSosceviddnayaMyshca", null, "Грудино-ключично-сосцевидная мышца представляет собой довольно крупный мышечный тяж на переднебоковой поверхности шеи. Располагается под подкожной мышцей шеи, отделяясь от нее шейной фасцией. Соединяет череп с грудиной и ключицей, разделяя шею на передний и задний треугольники.", false, "Грудино-ключично-сосцевиддная мышца", "Грудино-ключично-сосцевиддная" },
                    { "Grudinopoyazychnayamyshca", null, "", false, "Грудино-поъязычная мышца", "" },
                    { "Grudnojpozvonokostistyjostrovok", null, "", false, "Грудной позвонок, остистый островок", "" },
                    { "Ikronozhnayamyshca", null, "", false, "Икроножная мышца", "" },
                    { "IkronozhnayaMyshcaLateralnayaGolovka", null, "", false, "Икроножная мышца, латеральная головка", "" },
                    { "Ikronozhnayamyshcamedialnayagolovka", null, "", false, "Икроножная мышца, медиальная головка", "" },
                    { "Ikronozhnayamyshcasuhozhilie", null, "", false, "Икроножная мышца, сухожилие", "" },
                    { "KambalovidnayaMyshca", null, "", false, "Камбаловидная мышца", "" },
                    { "KambapavidnayaMyshca", null, "", false, "Камбапавидная мышца", "" },
                    { "Klyuchica", null, "в анатомии человека — небольшая трубчатая кость S-образной формы из пояса верхней конечности, соединяющая лопатку с грудиной и укрепляющая плечевой пояс.", false, "Ключица", "Ключица" },
                    { "Klyuvovidnoplechevayamyshca", null, "", false, "Клювовидно-плечевая мышца", "" },
                    { "KorotkayaMalobercovayaMyshca", null, "", false, "Короткая малоберцовая мышца", "" },
                    { "Korotkayamyshcaotvodyashchayabolshojpaleckisti", null, "", false, "Короткая мышца, отводящая большой палец кисти", "" },
                    { "Korotkijluchevojrvzgibatelzapyastya", null, "", false, "Короткий лучевой рвзгибатель запястья", "" },
                    { "KorotkijRazgibatelBolshogopalca", null, "", false, "Короткий разгибатель большого пальца", "" },
                    { "KorotkijRazgibatelPalcevStopy", null, "", false, "Короткий разгибатель пальцев стопы", "" },
                    { "Kosayavnutrennyayamyshcazhivota", null, "", false, "Косая внутренняя мышца живота", "" },
                    { "Kosayavnutrennyayamyshcazhivotapodaponevrozom", null, "", false, "Косая внутренняя мышца живота (под апоневрозом)", "" },
                    { "Krestecdorsalnayapoverhnost", null, "", false, "Крестец, дорсальная поверхность", "" },
                    { "Kruglyjpronator", null, "", false, "Круглый пронатор", "" },
                    { "Ladevidnaya", null, "", false, "Ладьевидная кость", "" },
                    { "Ladonnyjaponevroz", null, "", false, "Ладонный апоневроз", "" },
                    { "LateralnayaLodyshka", null, "", false, "Латеральная лодышка", "" },
                    { "Lateralnayashirokayamyshcabedra", null, "", false, "Латеральная широкая мышца бедра", "" },
                    { "Lateralnyjnadmyshchelok", null, "", false, "Латеральный надмыщелок", "" },
                    { "LestnichnayaMyshca", null, "Лестничные мышцы — мышцы шеи глубокого слоя боковой (латеральной) группы.Лестничные мышцы поднимают верхние рёбра, действуя как мышца вдоха. При фиксированных рёбрах, сокращаясь с обеих сторон, они сгибают шейную часть позвоночника спереди, а при одностороннем сокращении сгибают и поворачивают её в свою сторону.", false, "Лестничная мышца", "Лестничная мышца" },
                    { "LoktevayaMyshca", null, "Небольшая пирамидальная мышца, являющаяся как бы продолжением медиальной головки трёхглавой мышцы плеча. Начинается от латерального надмыщелка плечевой кости и от лучевой коллатеральной связки. Прикрепляется к задней поверхности локтевого отростка, срастаясь с капсулой локтевого сустава.", false, "Локтевая мышца", "Локтевая мышца" },
                    { "Loktevojotrostok", null, "", false, "Локтевой отросток", "" },
                    { "Loktevojrazgibatelzapyastya", null, "", false, "Локтевой разгибатель запястья", "" },
                    { "Loktevojsgibatelzapyastya", null, "", false, "Локтевой сгибатель запястья", "" },
                    { "Lopatochnopodyazychnayamyshcanizhneeboyushk", null, "", false, "Лопаточно-подъязычная мышца, нижнее боюшко", "" },
                    { "LopatochnoPodyazychnayaMyshcaNizhneeBryushko", null, "парная мышца передней поверхности шеи из группы подподъязычных. Имеет длинную уплощенную форму, разделена сухожилием на два брюшка.", false, "Лопаточно-подъязычная мышца, нижнее брюшко", "Лопаточно-подъязычная" },
                    { "Luchevojsgibatelzapyastya", null, "", false, "Лучевой сгибатель запястья", "" },
                    { "Malayakruglayamyshca", null, "", false, "Малая круглая мышца", "" },
                    { "MedialayaKlinovidnayaKost", null, "", false, "Медиальая клиновидная кость", "" },
                    { "MedialnayaLodyzhka", null, "", false, "Медиальная лодыжка", "" },
                    { "Medialnayashirokayamyshcabedra", null, "", false, "Медиальная широкая мышца бедра", "" },
                    { "Menisk", null, "", false, "Мениск", "" },
                    { "MyshcaOtvodyashchayaBolshojPalecStopy", null, "", false, "Мышца, отводящая большой палец стопы", "" },
                    { "MyshcaOtvodyashchayaMizinecStopy", null, "", false, "Мышца, отводящая мизинец стопы", "" },
                    { "MyshcaPodnimayushchayaLopatku", null, "ШМышца, поднимающая лопатку, — располагается под трапециевидной мышцей. Начинаясь от задних бугорков поперечных отростков 4 верхних шейных позвонков, четырьмя отдельными сухожильными пучками, соединяется (иногда представлена несколькими отдельными мышцами) идет вниз и латерально, прикрепляясь к верхнему отделу медиального края лопатки и верхнему углу лопатки.", false, "Мышца, поднимающая лопатку", "Поднимающая лопатку" },
                    { "Myshcapodnimayushchayayaichko", null, "", false, "Мышца, поднимающая яичко", "" },
                    { "Nadkolennik", null, "", false, "Надколенник", "" },
                    { "NapryagatelShirokojFascii", null, "", false, "Напрягатель широкой фасции", "" },
                    { "Naruzhnayakosayamyshcazhivota", null, "", false, "Наружная косая мышца живота", "" },
                    { "Perednyayabolshebercovayamyshca", null, "", false, "Передняя большеберцовая мышца", "" },
                    { "Perednyayazubchatayamyshca", null, "", false, "Передняя зубчатая мышца", "" },
                    { "PervayaPlyusnevayaKost", null, "", false, "Первая плюсневая кость", "" },
                    { "Piramidalnayamyshcapodaponevrozom", null, "", false, "Пирамидальная мышца, под апоневрозом", "" },
                    { "PlecheluchevayaMyshca", null, "Мышца предплечья передней группы.Сгибает предплечье в локтевом суставе и устанавливает лучевую кость в положении, среднем между пронацией и супинацией.", false, "Плечелучевая мышца", "Плечелучевая мышца" },
                    { "PlechevayaMyshca", null, "лежит глубже двуглавой мышцы плеча, начинается от передней поверхности плечевой кости и от обеих межмышечных перегородок, прикрепляется к бугристости локтевой кости.", false, "Плечевая мышца", "Плечевая мышца" },
                    { "Podoshvennayamyshca", null, "", false, "Подошвенная мышца", "" },
                    { "Podostnayamyshca", null, "", false, "Подостная мышца", "" },
                    { "PodshovennayaMyshca", null, "", false, "Подшовенная мышца", "" },
                    { "PodvzdoshnayaKost", null, "", false, "Подвздошная кость", "" },
                    { "Podvzdoshnayaost", null, "", false, "Подвздошная ость", "" },
                    { "PodvzdoshnoBolshebercovyjTrakt", null, "", false, "Подвздошно-большеберцовый тракт", "" },
                    { "Podvzdoshnoepoyasnichnayamyshca", null, "", false, "Подвздошное поясничная мышца", "" },
                    { "Podvzdoshnopoyasnichnayamyshca", null, "", false, "Подвздошно-поясничная мышца", "" },
                    { "PoluosistayaMyshcaGolovy", null, "Полуостистая мышца головы располагается между поперечными отростками 5 верхних грудных позвонков и 3—4 нижних шейных с одной стороны и выйной площадкой затылочной кости – с другой. Посередине медиальной части мышцы располагается сухожильная перемычка.", false, "Полуосистая мышца головы", "Полуосистая головная" },
                    { "Polusuhozhilnayamyshca", null, "", false, "Полусухожильная мышца", "" },
                    { "PortnyazhnayaMyshca", null, "", false, "Портняжная мышца", "" },
                    { "PoverhnostnyjSgibatelPalcevKisti", null, "Мышца передней группы предплечья.Спереди мышца прикрыта длинной ладонной мышцей и лучевым сгибателем запястья, которые оставляют на ней след в виде борозд.", false, "Поверхностный сгибатель пальцев кисти", "Поверхностные сгибатель пальцев кисти" },
                    { "Poverhostnyjsgibatelpalcevruki", null, "", false, "Поверхостный сгибатель пальцев руки", "" },
                    { "Poyasnichnyjtreugolnik", null, "", false, "Поясничный треугольник", "" },
                    { "Proksimalnayafalanga", null, "", false, "Проксимальная фаланга", "" },
                    { "PromezhutochnayaShirokayaMyshcaBedra", null, "", false, "Промежуточная широкая мышца бедра", "" },
                    { "Pryamayamyshcabedra", null, "", false, "Прямая мышца бедра", "" },
                    { "PryamayaMyshcaZhivota", null, "", false, "Прямая мышца живота", "" },
                    { "Pupochnoekolco", null, "", false, "Пупочное кольцо", "" },
                    { "PyatochnoeSuhozhilie", null, "", false, "Пяточное сухожилие", "" },
                    { "RazgebatelPalcevKisti", null, "Мышца предплечья задней группы", false, "Разгебатель пальцев кисти", "Разгебатель пальцев кисти" },
                    { "Razgibatelpalcevkistisuhozhilie", null, "", false, "Разгибатель пальцев кисти, сухожилие", "" },
                    { "RemennayaMyshcaGolovy", null, "начинается от выйной связки, остистых отростков III- Vii шейного и 3 верхних грудных позвонков идет вверх и латерально и прикрепляется к боковому отделу верхней выйной линии и вдоль заднего края сосцевидного отростка. Прикрыта верхним отделом трапециевидной мышцы. При одностороннем сокращении мышца поворачивает голову в свою сторону, при двустороннем сокращении мышца разгибает шейную часть позвоночника и наклоняет голову назад.", false, "Ременная мышца головы", "Ременная головная" },
                    { "Sedmojshejnyepozvonokostistyjostrovok", null, "", false, "Седьмой шейные позвонок, остистый островок", "" },
                    { "ShejkaMalobercovojKosti", null, "", false, "Шейка малоберцовой кости", "" },
                    { "SrednyayaYagodichnayaMyshca", null, "", false, "Средняя ягодичная мышца", "Средняя ягодичная мышца" },
                    { "SrednyayaYagodichnayaMyshcaPodYagodichnojFasciej", null, "", false, "Средняя ягодичная мышца, под ягодичной фасцией", "Средняя ягодичная мышца, под ягодичной фасцией" },
                    { "Svyazkanadkolennika", null, "", false, "Связка надколенника", "" },
                    { "TarannayaKost", null, "", false, "Таранная кость", "" },
                    { "Tenar", null, "", false, "Тенар", "" },
                    { "Tonkayamyshca", null, "", false, "Тонкая мышца", "" },
                    { "Torakolyumbalnayafasciya", null, "", false, "Тораколюмбальная фасция", "" },
                    { "Trapecevidnayamyshca", null, "", false, "Трапецевидная мышца", "" },
                    { "TrapecividnayaMyshca", null, "Трапециеви́дная мы́шца — плоская широкая мышца, занимающая поверхностное положение в задней области шеи и в верхнем отделе спины. Трапециевидная мышца имеет форму треугольника, основанием обращённого к позвоночному столбу, а вершиной — к акромиону лопатки. Трапециевидные мышцы обеих сторон спины вместе, как ни странно, имеют форму не трапеции (так как нет пары параллельных краёв мышцы и пары непараллельных краёв), а дельтоида — фигуры, образованной двумя симметричными треугольниками.", false, "Трапецивидная мышца", "Трапецивидная мышца" },
                    { "TretyaMalobercovayaMyshca", null, "", false, "Третья малоберцовая мышца", "" },
                    { "TricepsPlecha", null, "", false, "Трицепс плеча", "" },
                    { "TricepsTrekhglavayaMyshcaPlechaDlinnayaGolovka", null, "Мышца-разгибатель задней группы плеча, занимает всю заднюю сторону плеча. От подсуставного бугорка лопатки;", false, "Трицепс, трехглавая мышца плеча, длинная головка", "Трицепс, Трехглавая плеча, длинная гловка" },
                    { "TricepsTrekhglavayaMyshcaPlechaLateralnayaGolovka", null, "Мышца-разгибатель задней группы плеча, занимает всю заднюю сторону плеча. От задней поверхности плеча", false, "Трицепс, трехглавая мышца плеча, латеральная головка", "Трицепс, Трехглавая плеча, длинная гловка" },
                    { "TricepsTrekhglavayaMyshcaPlechaMedialnayaGolovka", null, "Мышца-разгибатель задней группы плеча, занимает всю заднюю сторону плеча. От задней поверхности плечевой кости, межмышечных перегородок.", false, "Трицепс, трехглавая мышца плеча, медиальная головка", "Трицепс, Трехглавая плеча, длинная гловка" },
                    { "Vtorayapyastnayakost", null, "", false, "Вторая пястная кость", "" }
                });
        }

        /// <inheritdoc />
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
                keyValue: "BolshayaGrudnayaMyshcaGrudinoChychicnayaChast");

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
                keyValue: "DeltovidnayaMyshcaPered");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "DeltovidnayaMyshcaSrednya");

            migrationBuilder.DeleteData(
                table: "CategoryOfBody",
                keyColumn: "Code",
                keyValue: "DeltovidnayaMyshcaZad");

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
        }
    }
}
