namespace EnumWithDetails
{
    public class Program
    {

        enum FootballPositions : byte
        {
            GoalKeeper = 0,
            LeftDefender = 2,
            RightDefender = 3,
            LeftBack = 4,
            RightBack = 5,
            CenterDefensiveMidFielder = 6,
            CenterMidFielder = 7,
            LeftMidFielder = 8,
            RightMidFielder = 9,
            LeftWing = 10,
            RightWing = 11,
            CenterOffensiveMidFielder = 12,
            Finisher = 13

        }



        static void Main(string[] args)
        {
            FootballPositions footballPositions = new FootballPositions();
            FootballPositions footballPositions1 = (FootballPositions)4; // INT DEĞERİ YA DA NUMERİC DEĞERİ ENUM KARŞILIĞI OLARAK ALABİLİYORUZ
            FootballPositions footballPositions2 = FootballPositions.Finisher;


            Console.WriteLine(footballPositions);
            Console.WriteLine(footballPositions1);
            Console.WriteLine(footballPositions2);

            switch (footballPositions)                               //YANİ İSİM ASLINDA ASIL DEĞERDİR ONUN KONTROLÜ GEÇERLİDİR
            {                                                        //YANİ İSİM ASLINDA ASIL DEĞERDİR ONUN KONTROLÜ GEÇERLİDİR
                case FootballPositions.GoalKeeper:                   //YANİ İSİM ASLINDA ASIL DEĞERDİR ONUN KONTROLÜ GEÇERLİDİR
                    break;                                           //YANİ İSİM ASLINDA ASIL DEĞERDİR ONUN KONTROLÜ GEÇERLİDİR
                case FootballPositions.LeftDefender:                 //YANİ İSİM ASLINDA ASIL DEĞERDİR ONUN KONTROLÜ GEÇERLİDİR
                    break;                                           //YANİ İSİM ASLINDA ASIL DEĞERDİR ONUN KONTROLÜ GEÇERLİDİR
                case FootballPositions.RightDefender:                //YANİ İSİM ASLINDA ASIL DEĞERDİR ONUN KONTROLÜ GEÇERLİDİR
                    break;                                           //YANİ İSİM ASLINDA ASIL DEĞERDİR ONUN KONTROLÜ GEÇERLİDİR
                case FootballPositions.LeftBack:                     //YANİ İSİM ASLINDA ASIL DEĞERDİR ONUN KONTROLÜ GEÇERLİDİR
                    break;                                           //YANİ İSİM ASLINDA ASIL DEĞERDİR ONUN KONTROLÜ GEÇERLİDİR
                case FootballPositions.RightBack:                    //YANİ İSİM ASLINDA ASIL DEĞERDİR ONUN KONTROLÜ GEÇERLİDİR
                    break;                                           //YANİ İSİM ASLINDA ASIL DEĞERDİR ONUN KONTROLÜ GEÇERLİDİR
                case FootballPositions.CenterDefensiveMidFielder:    //YANİ İSİM ASLINDA ASIL DEĞERDİR ONUN KONTROLÜ GEÇERLİDİR
                    break;                                           //YANİ İSİM ASLINDA ASIL DEĞERDİR ONUN KONTROLÜ GEÇERLİDİR
                case FootballPositions.CenterMidFielder:             //YANİ İSİM ASLINDA ASIL DEĞERDİR ONUN KONTROLÜ GEÇERLİDİR
                    break;                                           //YANİ İSİM ASLINDA ASIL DEĞERDİR ONUN KONTROLÜ GEÇERLİDİR
                case FootballPositions.LeftMidFielder:               //YANİ İSİM ASLINDA ASIL DEĞERDİR ONUN KONTROLÜ GEÇERLİDİR
                    break;                                           //YANİ İSİM ASLINDA ASIL DEĞERDİR ONUN KONTROLÜ GEÇERLİDİR
                case FootballPositions.RightMidFielder:              //YANİ İSİM ASLINDA ASIL DEĞERDİR ONUN KONTROLÜ GEÇERLİDİR
                    break;                                           //YANİ İSİM ASLINDA ASIL DEĞERDİR ONUN KONTROLÜ GEÇERLİDİR
                case FootballPositions.LeftWing:                     //YANİ İSİM ASLINDA ASIL DEĞERDİR ONUN KONTROLÜ GEÇERLİDİR
                    break;                                           //YANİ İSİM ASLINDA ASIL DEĞERDİR ONUN KONTROLÜ GEÇERLİDİR
                case FootballPositions.RightWing:                    //YANİ İSİM ASLINDA ASIL DEĞERDİR ONUN KONTROLÜ GEÇERLİDİR
                    break;                                           //YANİ İSİM ASLINDA ASIL DEĞERDİR ONUN KONTROLÜ GEÇERLİDİR
                case FootballPositions.CenterOffensiveMidFielder:    //YANİ İSİM ASLINDA ASIL DEĞERDİR ONUN KONTROLÜ GEÇERLİDİR
                    break;                                           //YANİ İSİM ASLINDA ASIL DEĞERDİR ONUN KONTROLÜ GEÇERLİDİR
                case FootballPositions.Finisher:                     //YANİ İSİM ASLINDA ASIL DEĞERDİR ONUN KONTROLÜ GEÇERLİDİR
                    break;                                           //YANİ İSİM ASLINDA ASIL DEĞERDİR ONUN KONTROLÜ GEÇERLİDİR
                default:                                             //YANİ İSİM ASLINDA ASIL DEĞERDİR ONUN KONTROLÜ GEÇERLİDİR
                    break;
            }
            FootballPositions fb = footballPositions1;         //Enum yapısı da değer tiplidir o yüzden fbnin değeri değişmedi
            footballPositions1 = (FootballPositions)7;         //Enum yapısı da değer tiplidir o yüzden fbnin değeri değişmedi
            Console.WriteLine(fb);                             //Enum yapısı da değer tiplidir o yüzden fbnin değeri değişmedi

            Console.WriteLine(Enum.GetUnderlyingType(footballPositions.GetType()));
            Console.WriteLine(typeof(FootballPositions));
            Console.WriteLine(Enum.GetUnderlyingType(typeof(FootballPositions)));


            Console.ReadKey();
        }
    }
}
