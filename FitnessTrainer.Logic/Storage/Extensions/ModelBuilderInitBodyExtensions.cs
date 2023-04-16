using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TrainingManager.Logic.Storage.Domain;

namespace TrainingManager.Logic.Storage.Extensions
{
    public static class ModelBuilderInitBodyExtensions
    {
        public static void builderInitBody(this ModelBuilder builder)
        {
            builder.Entity<CategoryOfBody>().HasData(
               new CategoryOfBody
               {
                   Code = "GrudinoKlyuchichnoSosceviddnayaMyshca",
                   Name = "Грудино-ключично-сосцевиддная мышца",
                   Decsription = "Грудино-ключично-сосцевидная мышца представляет " +
                   "собой довольно крупный мышечный тяж на переднебоковой поверхности" +
                   " шеи. Располагается под подкожной мышцей шеи, отделяясь от нее шейной" +
                   " фасцией. Соединяет череп с грудиной и ключицей, разделяя шею на передний" +
                   " и задний треугольники.",
                   ShortName = "Грудино-ключично-сосцевиддная"
               },
               new CategoryOfBody
               {
                   Code = "PoluosistayaMyshcaGolovy",
                   Name = "Полуосистая мышца головы",
                   Decsription = "Полуостистая мышца головы располагается между " +
                   "поперечными отростками 5 верхних грудных позвонков и 3—4 нижних шейных " +
                   "с одной стороны и выйной площадкой затылочной кости – с другой. Посередине " +
                   "медиальной части мышцы располагается сухожильная перемычка.",
                   ShortName = "Полуосистая головная"
               },
               new CategoryOfBody
               {
                   Code = "RemennayaMyshcaGolovy",
                   Name = "Ременная мышца головы",
                   Decsription = "начинается от выйной связки, " +
                   "остистых отростков III- Vii шейного и 3 верхних " +
                   "грудных позвонков идет вверх и латерально и " +
                   "прикрепляется к боковому отделу верхней выйной " +
                   "линии и вдоль заднего края сосцевидного отростка. " +
                   "Прикрыта верхним отделом трапециевидной мышцы. При одностороннем " +
                   "сокращении мышца поворачивает голову в свою сторону, " +
                   "при двустороннем сокращении мышца разгибает шейную " +
                   "часть позвоночника и наклоняет голову назад.",
                   ShortName = "Ременная головная"
               },
               new CategoryOfBody
               {
                   Code = "MyshcaPodnimayushchayaLopatku",
                   Name = "Мышца, поднимающая лопатку",
                   Decsription = "ШМышца, поднимающая лопатку, — располагается " +
                   "под трапециевидной мышцей. Начинаясь от задних бугорков " +
                   "поперечных отростков 4 верхних шейных позвонков, четырьмя " +
                   "отдельными сухожильными пучками, соединяется " +
                   "(иногда представлена несколькими отдельными мышцами) " +
                   "идет вниз и латерально, прикрепляясь к верхнему отделу " +
                   "медиального края лопатки и верхнему углу лопатки.",
                   ShortName = "Поднимающая лопатку"
               },               
               new CategoryOfBody
               {
                   Code = "LestnichnayaMyshca",
                   Name = "Лестничная мышца",
                   Decsription = "Лестничные мышцы — мышцы шеи глубокого слоя боковой (латеральной) группы." +
                   "Лестничные мышцы поднимают верхние рёбра, действуя как мышца вдоха. При фиксированных " +
                   "рёбрах, сокращаясь с обеих сторон, они сгибают шейную часть позвоночника спереди, а при " +
                   "одностороннем сокращении сгибают и поворачивают её в свою сторону.",
                   ShortName = "Лестничная мышца"
               },
               new CategoryOfBody
               {
                   Code = "LopatochnoPodyazychnayaMyshcaNizhneeBryushko",
                   Name = "Лопаточно-подъязычная мышца, нижнее брюшко",
                   Decsription = "парная мышца передней поверхности " +
                   "шеи из группы подподъязычных. Имеет длинную уплощенную " +
                   "форму, разделена сухожилием на два брюшка.",
                   ShortName = "Лопаточно-подъязычная"
               },
               new CategoryOfBody
               {
                   Code = "TrapecividnayaMyshca",
                   Name = "Трапецивидная мышца",
                   Decsription = "Трапециеви́дная мы́шца — " +
                   "плоская широкая мышца, занимающая поверхностное " +
                   "положение в задней области шеи и в верхнем отделе спины. " +
                   "Трапециевидная мышца имеет форму треугольника, основанием " +
                   "обращённого к позвоночному столбу, а вершиной — к акромиону " +
                   "лопатки. Трапециевидные мышцы обеих сторон спины вместе, как ни " +
                   "странно, имеют форму не трапеции (так как нет пары параллельных " +
                   "краёв мышцы и пары непараллельных краёв), а дельтоида — фигуры, " +
                   "образованной двумя симметричными треугольниками.",
                   ShortName = "Трапецивидная мышца"
               },
               new CategoryOfBody
               {
                   Code = "Akromion",
                   Name = "Акромион",
                   Decsription = "Латеральный конец лопаточной кости, " +
                   "сочленяющийся с акромиальной суставной поверхностью " +
                   "ключицы. Акромион образует вершину плеча, и представляет " +
                   "собой большую, немного треугольную или прямоугольную " +
                   "продолговатую форму, сплющенную сзади,которая выступает сначала " +
                   "поперечно, а затем изгибается вперед и вверх, чтобы выступать над " +
                   "суставной впадиной .[1]",
                   ShortName = "Акромион"
               },
               new CategoryOfBody
               {
                   Code = "Klyuchica",
                   Name = "Ключица",
                   Decsription = "в анатомии человека — небольшая трубчатая " +
                   "кость S-образной формы из пояса верхней конечности, соединяющая лопатку " +
                   "с грудиной и укрепляющая плечевой пояс.",
                   ShortName = "Ключица"
               },
               new CategoryOfBody
               {
                   Code = "DeltovidnayaMyshca",
                   Name = "Дельтовидная мышца",
                   Decsription = "Дельтовидная мышца — в анатомии человека — поверхностная мышца плеча, " +
                   "образующая его наружный контур. Принимает участие в сгибании и разгибании плеча, отведении " +
                   "руки в сторону. Название «дельтовидная» происходит по схожести треугольной формы мышцы" +
                   " с греческой буквой Δ (дельта).",
                   ShortName = "Дельтовидная мышца"
               },
               new CategoryOfBody
               {
                   Code = "DeltovidnayaMyshcaPered",
                   Name = "Дельтовидная мышца. Передняя часть",
                   Decsription = "",
                   ShortName = "Дельтовидная мышца"
               },
               new CategoryOfBody
               {
                   Code = "DeltovidnayaMyshcaSrednya",
                   Name = "Дельтовидная мышца. Средняя часть.",
                   Decsription = "",
                   ShortName = "Дельтовидная мышца"
               },
               new CategoryOfBody
               {
                   Code = "DeltovidnayaMyshcaZad",
                   Name = "Дельтовидная мышца. Задняя часть.",
                   Decsription = "",
                   ShortName = "Дельтовидная мышца"
               },
               new CategoryOfBody
               {
                   Code = "BolshayaGrudnayaMyshcaGrudinoChychicnayaChast",
                   Name = "Болшая грудная мышца, ключицная часть",
                   Decsription = "",
                   ShortName = "Грудная мышца, ключицная часть"
               },
               new CategoryOfBody
               {
                   Code = "BolshayaGrudnayaMyshcaGrudinoRebernayaChast",
                   Name = "Болшая грудная мышца, грудино-реберная часть",
                   Decsription = "Крупная поверхностная мышца веерообразной формы, " +
                   "расположенная на передней поверхности груди. " +
                   "Под ней находится треугольной формы малая грудная мышца." +
                   "Грудино-реберная часть: начинается на передней поверхности грудины и хрящей верхних шести рёбер.",
                   ShortName = "Грудная мышца, грудино-реберная часть"
               },
               new CategoryOfBody
               {
                   Code = "BolshayaGrudnayaMyshcaAbdominalnayaChast",
                   Name = "Болшая грудная мышца, абдоминальная часть",
                   Decsription = "Крупная поверхностная мышца веерообразной формы, " +
                   "расположенная на передней поверхности груди. " +
                   "Под ней находится треугольной формы малая грудная мышца." +
                   "Абдоминальная часть: начинается на передней стенке прямой мышцы живота",
                   ShortName = "Грудная мышца, абдоминальная часть"
               },
               new CategoryOfBody
               {
                   Code = "Grudina",
                   Name = "Грудина",
                   Decsription = "Продолговатая плоская кость в середине груди. " +
                   "Соединяется с рёбрами при помощи хрящей, " +
                   "формируя вместе с ними грудную клетку, вмещающую" +
                   " и защищающую от внешнего воздействия лёгкие, сердце " +
                   "и важнейшие кровеносные сосуды.",
                   ShortName = "Грудина"
               },
               new CategoryOfBody
               {
                   Code = "TricepsTrekhglavayaMyshcaPlechaDlinnayaGolovka",
                   Name = "Трицепс, трехглавая мышца плеча, длинная головка",
                   Decsription = "Мышца-разгибатель задней группы плеча, " +
                   "занимает всю заднюю сторону плеча. От подсуставного " +
                   "бугорка лопатки;",
                   ShortName = "Трицепс, Трехглавая плеча, длинная гловка"
               },
               new CategoryOfBody
               {
                   Code = "TricepsTrekhglavayaMyshcaPlechaMedialnayaGolovka",
                   Name = "Трицепс, трехглавая мышца плеча, медиальная головка",
                   Decsription = "Мышца-разгибатель задней группы плеча, " +
                   "занимает всю заднюю сторону плеча. От задней поверхности " +
                   "плечевой кости, межмышечных перегородок.",
                   ShortName = "Трицепс, Трехглавая плеча, длинная гловка"
               },
               new CategoryOfBody
               {
                   Code = "TricepsTrekhglavayaMyshcaPlechaLateralnayaGolovka",
                   Name = "Трицепс, трехглавая мышца плеча, латеральная головка",
                   Decsription = "Мышца-разгибатель задней группы плеча, " +
                   "занимает всю заднюю сторону плеча. От задней поверхности плеча",
                   ShortName = "Трицепс, Трехглавая плеча, длинная гловка"
               },
               new CategoryOfBody
               {
                   Code = "BicepsDvuglavayaMyshcaPlecha",
                   Name = "Бицепс (двуглавая мышца) плеча",
                   Decsription = "Большая мышца плеча, хорошо заметна под кожей." +
                   "Сгибает плечо в плечевом суставе, предплечье в локтевом.",
                   ShortName = "Бицепс плеча"
               },
               new CategoryOfBody
               {
                   Code = "PlechevayaMyshca",
                   Name = "Плечевая мышца",
                   Decsription = "лежит глубже двуглавой мышцы плеча, начинается от " +
                   "передней поверхности плечевой кости и от обеих межмышечных перегородок, " +
                   "прикрепляется к бугристости локтевой кости.",
                   ShortName = "Плечевая мышца"
               },
               new CategoryOfBody
               {
                   Code = "PlecheluchevayaMyshca",
                   Name = "Плечелучевая мышца",
                   Decsription = "Мышца предплечья передней группы." +
                   "Сгибает предплечье в локтевом суставе и устанавливает " +
                   "лучевую кость в положении, среднем между пронацией и супинацией.",
                   ShortName = "Плечелучевая мышца"
               },              
               new CategoryOfBody
               {
                   Code = "BolshayaMyshcaSpiny",
                   Name = "Большая мышца спины",
                   Decsription = "Поверхностная мышца, занимающая всю нижнюю часть спины, " +
                   "верхние пучки в начальной части прикрыты трапециевидной мышцей." +
                   "Приводит плечо к туловищу и тянет верхнюю конечность назад к " +
                   "срединной линии, вращая её внутрь — пронация. Если верхняя " +
                   "конечность закреплена, приближает к ней туловище и может расширять " +
                   "грудную клетку, служа вспомогательной дыхательной мышцей.",
                   ShortName = "Большая мышца спины"
               },
               new CategoryOfBody
               {
                   Code = "LoktevayaMyshca",
                   Name = "Локтевая мышца",
                   Decsription = "Небольшая пирамидальная мышца, " +
                   "являющаяся как бы продолжением медиальной головки " +
                   "трёхглавой мышцы плеча. Начинается от латерального надмыщелка " +
                   "плечевой кости и от лучевой коллатеральной связки. Прикрепляется к " +
                   "задней поверхности локтевого отростка, срастаясь с капсулой локтевого " +
                   "сустава.",
                   ShortName = "Локтевая мышца"
               },
               new CategoryOfBody
               {
                   Code = "BolshayaZubchatayaMyshca",
                   Name = "Большая зубчатая мышца",
                   Decsription = "Расположена в переднем отделе грудной стенки. " +
                   "Верхняя её часть прикрыта большой грудной мышцей, нижняя расположена " +
                   "поверхностно, прикрыта грудной фасцией. Начинается 8—9 зубцами от " +
                   "наружной поверхности 8—9 рёбер, а также от сухожильной дуги между " +
                   "1-м и 11-м рёбрами. Направляется назад и вверх, покрывает наружную " +
                   "поверхность рёбер, затем подходит под лопатку и прикрепляется вдоль её " +
                   "медиального края, а также к её нижнему углу. Наиболее выражены те части" +
                   " мышцы, место прикрепления которых располагается в области нижнего " +
                   "угла лопатки.",
                   ShortName = "Большая зубчатая мышца"
               },
               new CategoryOfBody
               {
                   Code = "DlinnayaLadonnayaMyshca",
                   Name = "Длинная ладонная мышца",
                   Decsription = "имеет короткое веретенообразное брюшко и очень " +
                   "длинное сухожилие. Лежит непосредственно под кожей, внутри от " +
                   "лучевого сгибателя запястья. Начинается от плечевой кости, " +
                   "межмышечной перегородки и фасции предплечья, подойдя к кисти, " +
                   "переходит в широкий ладонный апоневроз. Относится к рудиментам " +
                   "человеческого тела. Ранее служила для лазания по деревьям у обезьян. " +
                   "Общеизвестным фактом является то, " +
                   "что приблизительно у 15 % людей отсутствует сухожилие данной мышцы.",
                   ShortName = "Длинная ладонная мышца"
               },
               new CategoryOfBody
               {
                   Code = "PoverhnostnyjSgibatelPalcevKisti",
                   Name = "Поверхностный сгибатель пальцев кисти",
                   Decsription = "Мышца передней группы предплечья." +
                   "Спереди мышца прикрыта длинной ладонной мышцей и " +
                   "лучевым сгибателем запястья, которые оставляют на " +
                   "ней след в виде борозд.",
                   ShortName = "Поверхностные сгибатель пальцев кисти"
               },
               new CategoryOfBody
               {
                   Code = "RazgebatelPalcevKisti",
                   Name = "Разгебатель пальцев кисти",
                   Decsription = "Мышца предплечья задней группы",
                   ShortName = "Разгебатель пальцев кисти"
               },
               new CategoryOfBody
               {
                   Code = "SrednyayaYagodichnayaMyshca",
                   Name = "Средняя ягодичная мышца",
                   Decsription = "",
                   ShortName = "Средняя ягодичная мышца"
               },
               new CategoryOfBody
               {
                   Code = "SrednyayaYagodichnayaMyshcaPodYagodichnojFasciej",
                   Name = "Средняя ягодичная мышца, под ягодичной фасцией",
                   Decsription = "",
                   ShortName = "Средняя ягодичная мышца, под ягодичной фасцией"
               },
               new CategoryOfBody
               {
                   Code = "BolshayaYagodichnayaMyshca",
                   Name = "Большая ягодичная мышца",
                   Decsription = "",
                   ShortName = "Большая ягодичная мышца"
               },
               new CategoryOfBody
               {
                   Code = "BolshojVertel",
                   Name = "Большой вертел",
                   Decsription = "",
                   ShortName = ""
               },
               new CategoryOfBody
               {
                   Code = "NapryagatelShirokojFascii",
                   Name = "Напрягатель широкой фасции",
                   Decsription = "",
                   ShortName = ""
               },
               new CategoryOfBody
               {
                   Code = "PodvzdoshnoBolshebercovyjTrakt",
                   Name = "Подвздошно-большеберцовый тракт",
                   Decsription = "",
                   ShortName = ""
               },
               new CategoryOfBody
               {
                   Code = "BicepsPlechaDlannayaGolovka",
                   Name = "Бицепс плеча, дланная головка",
                   Decsription = "",
                   ShortName = ""
               },
               new CategoryOfBody
               {
                   Code = "PromezhutochnayaShirokayaMyshcaBedra",
                   Name = "Промежуточная широкая мышца бедра",
                   Decsription = "",
                   ShortName = ""
               },
               new CategoryOfBody
               {
                   Code = "PodshovennayaMyshca",
                   Name = "Подшовенная мышца",
                   Decsription = "",
                   ShortName = ""
               },
                new CategoryOfBody
               {
                   Code = "BedroLateralnyjMyshchelok",
                   Name = "Бедро, латеральный мыщелок",
                   Decsription = "",
                   ShortName = ""
               },
                new CategoryOfBody
                {
                    Code = "Menisk",
                    Name = "Мениск",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "ShejkaMalobercovojKosti",
                    Name = "Шейка малоберцовой кости",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "IkronozhnayaMyshcaLateralnayaGolovka",
                    Name = "Икроножная мышца, латеральная головка",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "KambapavidnayaMyshca",
                    Name = "Камбапавидная мышца",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "DlinnayaMalobercovayaMyshca",
                    Name = "Длинная малоберцовая мышца",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "DlinnyjRazgibatelPalcevStopy",
                    Name = "Длинный разгибатель пальцев стопы",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "KorotkayaMalobercovayaMyshca",
                    Name = "Короткая малоберцовая мышца",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "TretyaMalobercovayaMyshca",
                    Name = "Третья малоберцовая мышца",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "DlinnyjRazgibatelBoshogoPalcaStopy",
                    Name = "Длинный разгибатель большого пальца стопы",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "LateralnayaLodyshka",
                    Name = "Латеральная лодышка",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "KorotkijRazgibatelBolshogopalca",
                    Name = "Короткий разгибатель большого пальца",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "KorotkijRazgibatelPalcevStopy",
                    Name = "Короткий разгибатель пальцев стопы",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "MyshcaOtvodyashchayaMizinecStopy",
                    Name = "Мышца, отводящая мизинец стопы",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "MyshcaOtvodyashchayaBolshojPalecStopy",
                    Name = "Мышца, отводящая большой палец стопы",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "PervayaPlyusnevayaKost",
                    Name = "Первая плюсневая кость",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "MedialayaKlinovidnayaKost",
                    Name = "Медиальая клиновидная кость",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Ladevidnaya",
                    Name = "Ладьевидная кость",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "TarannayaKost",
                    Name = "Таранная кость",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "MedialnayaLodyzhka",
                    Name = "Медиальная лодыжка",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "PyatochnoeSuhozhilie",
                    Name = "Пяточное сухожилие",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "DlinnyjSgibatelBolshogoPalcaStopy",
                    Name = "Длинный сгибатель большого пальца стопы",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Dlinnyjsgibatelbolshogopalcevstopy",
                    Name = "Длинный сгибатель большого пальцев стопы",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "KambalovidnayaMyshca",
                    Name = "Камбаловидная мышца",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Perednyayabolshebercovayamyshca",
                    Name = "Передняя большеберцовая мышца",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Bolshebercovayakostmedialnayapoverhnost",
                    Name = "Большеберцовая кость, медиальная поверхность",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Ikronozhnayamyshcamedialnayagolovka",
                    Name = "Икроножная мышца, медиальная головка",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Bedromedialnyjmyshchelok",
                    Name = "Бедро, медиальный мыщелок",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Nadkolennik",
                    Name = "Надколенник",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Tonkayamyshca",
                    Name = "Тонкая мышца",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "PortnyazhnayaMyshca",
                    Name = "Портняжная мышца",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Dlinnayaprivodyashchayamyshca",
                    Name = "Длинная приводящая мышца",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Pryamayamyshcabedra",
                    Name = "Прямая мышца бедра",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Piramidalnayamyshcapodaponevrozom",
                    Name = "Пирамидальная мышца, под апоневрозом",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Myshcapodnimayushchayayaichko",
                    Name = "Мышца, поднимающая яичко",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Podvzdoshnoepoyasnichnayamyshca",
                    Name = "Подвздошное поясничная мышца",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Belayaliniyazhivota",
                    Name = "Белая линия живота",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Proksimalnayafalanga",
                    Name = "Проксимальная фаланга",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Detalnayafalanga",
                    Name = "Детальная фаланга",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Vtorayapyastnayakost",
                    Name = "Вторая пястная кость",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Tenar",
                    Name = "Тенар",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Poverhostnyjsgibatelpalcevruki",
                    Name = "Поверхостный сгибатель пальцев руки",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Luchevojsgibatelzapyastya",
                    Name = "Лучевой сгибатель запястья",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Korotkijluchevojrvzgibatelzapyastya",
                    Name = "Короткий лучевой рвзгибатель запястья",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Dlinnyjluchevojrazgibatelzapyastya",
                    Name = "Длинный лучевой разгибатель запястья",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Kruglyjpronator",
                    Name = "Круглый пронатор",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "PodvzdoshnayaKost",
                    Name = "Подвздошная кость",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "PryamayaMyshcaZhivota",
                    Name = "Прямая мышца живота",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Naruzhnayakosayamyshcazhivota",
                    Name = "Наружная косая мышца живота",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Bolshayagrudnayamyshca",
                    Name = "Большая грудная мышца",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Sedmojshejnyepozvonokostistyjostrovok",
                    Name = "Седьмой шейные позвонок, остистый островок",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Trapecevidnayamyshca",
                    Name = "Трапецевидная мышца",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Grebenlopatki",
                    Name = "Гребень лопатки",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Podostnayamyshca",
                    Name = "Подостная мышца",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Malayakruglayamyshca",
                    Name = "Малая круглая мышца",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Bolshayakruglayamyshca",
                    Name = "Большая круглая мышца",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Bolshayarombovidnayamyshca",
                    Name = "Большая ромбовидная мышца",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Grudnojpozvonokostistyjostrovok",
                    Name = "Грудной позвонок, остистый островок",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Torakolyumbalnayafasciya",
                    Name = "Тораколюмбальная фасция",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Poyasnichnyjtreugolnik",
                    Name = "Поясничный треугольник",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Podvzdoshnayaost",
                    Name = "Подвздошная ость",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Krestecdorsalnayapoverhnost",
                    Name = "Крестец, дорсальная поверхность",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Polusuhozhilnayamyshca",
                    Name = "Полусухожильная мышца",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Klyuvovidnoplechevayamyshca",
                    Name = "Клювовидно-плечевая мышца",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "TricepsPlecha",
                    Name = "Трицепс плеча",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Loktevojotrostok",
                    Name = "Локтевой отросток",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Loktevojsgibatelzapyastya",
                    Name = "Локтевой сгибатель запястья",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Loktevojrazgibatelzapyastya",
                    Name = "Локтевой разгибатель запястья",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Dlinnayamyshcaotvodyashchayabolshojpaleckisti",
                    Name = "Длинная мышца, отводящая большой палец кисти",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Dlinnyjsgibatelbolshogopalcakisti",
                    Name = "Длинный сгибатель большого пальца кисти",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Gorohovdnayamyshcaotvodyashchayabolshojpaleckisti",
                    Name = "Гороховдная мышца, отводящая большой палец кисти",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Korotkayamyshcaotvodyashchayabolshojpaleckisti",
                    Name = "Короткая мышца, отводящая большой палец кисти",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Ladonnyjaponevroz",
                    Name = "Ладонный апоневроз",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Distalnayafalanga",
                    Name = "Дистальная фаланга",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Razgibatelpalcevkistisuhozhilie",
                    Name = "Разгибатель пальцев кисти, сухожилие",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Bolshayaprivodyashchayamyshchca",
                    Name = "Большая приводящая мыщца",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Lateralnayashirokayamyshcabedra",
                    Name = "Латеральная широкая мышца бедра",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Bicepsbedra",
                    Name = "Бицепс бедра",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Bedrennayakostpodkolennayapoverhnost",
                    Name = "Бедренная кость, подколенная поверхность",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Podoshvennayamyshca",
                    Name = "Подошвенная мышца",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Ikronozhnayamyshcasuhozhilie",
                    Name = "Икроножная мышца, сухожилие",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Bugristostpyatochnojkosti",
                    Name = "Бугристость пяточной кости",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Grudinopoyazychnayamyshca",
                    Name = "Грудино-поъязычная мышца",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Perednyayazubchatayamyshca",
                    Name = "Передняя зубчатая мышца",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Lateralnyjnadmyshchelok",
                    Name = "Латеральный надмыщелок",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Pupochnoekolco",
                    Name = "Пупочное кольцо",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Kosayavnutrennyayamyshcazhivota",
                    Name = "Косая внутренняя мышца живота",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Kosayavnutrennyayamyshcazhivotapodaponevrozom",
                    Name = "Косая внутренняя мышца живота (под апоневрозом)",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Podvzdoshnopoyasnichnayamyshca",
                    Name = "Подвздошно-поясничная мышца",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "GrebenchatayaMyshca",
                    Name = "Гребенчатая мышца",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Medialnayashirokayamyshcabedra",
                    Name = "Медиальная широкая мышца бедра",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Svyazkanadkolennika",
                    Name = "Связка надколенника",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "BugristostbolshebercovojKosti",
                    Name = "Бугристость большеберцовой кости",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Ikronozhnayamyshca",
                    Name = "Икроножная мышца",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Dlinnyjsgibatelpalcevstopy",
                    Name = "Длинный сгибатель пальцев стопы",
                    Decsription = "",
                    ShortName = ""
                },
                new CategoryOfBody
                {
                    Code = "Lopatochnopodyazychnayamyshcanizhneeboyushk",
                    Name = "Лопаточно-подъязычная мышца, нижнее боюшко",
                    Decsription = "",
                    ShortName = ""
                }
           );
        }


    }
}
