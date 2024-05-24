namespace RedRiggedRaffle.Demo;

// __     __        _
// \ \   / /__ _ __| | ___  ___ _   _ _ __   __ _
//  \ \ / / _ \ '__| |/ _ \/ __| | | | '_ \ / _` |
//   \ V /  __/ |  | | (_) \__ \ |_| | | | | (_| |
//    \_/ \___|_|  |_|\___/|___/\__,_|_| |_|\__, |
//                                          |___/
public class Verlosung
{
    //  __________________________________ 
    // < Main-Methode des Main-Characters >
    //  ---------------------------------- 
    //    \         __------~~-,
    //     \      ,'            ,
    //           /               \
    //          /                :
    //         |                  '
    //         |                  |
    //         |                  |
    //          |   _--           |
    //          _| =-.     .-.   ||
    //          o|/o/       _.   |
    //          /  ~          \ |
    //        (____@)  ___~    |
    //           |_===~~~.`    |
    //        _______.--~     |
    //        \________       |
    //                 \      |
    //               __/-___-- -__
    //              /            _ \
    public static void Main(string[] args)
    {
        var redArmy = new List<string>() {
            "@Gangsta2007", "@LockeDerBoss", "@MiiMiiSeinBruder", "@AlphaKevin", "@RedSoldier499",
            "@Louisa12", "@Drachenlord", "@Tanzverbot", "@tiger10ab", "@kaesekrokette99", "@fortnite4ever",
            "@ColdplayFan", "@Sören2013", "@MichiJackson", "@Ronaldo7", "@SonGoku2011", "@NarutoBoy2000",
            "@Diggah69", "@roflomat", "@waifu_weeb", "@derp", "@MaxPower9000", "@MikrowellenPizza2006"
        };
        var fiktivePreise = new List<GewinnbarerHase>() {
            new GewinnbarerHase("iPhone 16", 1),
            new GewinnbarerHase("PlayStation 5", 3),
            new GewinnbarerHase("10 kg Haribo", 5),
            new GewinnbarerHase("gebrauchte Sneaker", 3),
        };
        var luckyMuckies = new AbsneakenderHase(redArmy, fiktivePreise).Absneaken();
        foreach (var opfer in luckyMuckies.Keys)
        {
            Console.WriteLine($"{opfer} gewinnt {luckyMuckies[opfer]}");
        }
    }
}
