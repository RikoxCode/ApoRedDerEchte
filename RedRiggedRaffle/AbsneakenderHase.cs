namespace RedRiggedRaffle;

//     _    _                          _                  _           _   _
//    / \  | |__  ___ _ __   ___  __ _| | _____ _ __   __| | ___ _ __| | | | __ _ ___  ___
//   / _ \ | '_ \/ __| '_ \ / _ \/ _` | |/ / _ \ '_ \ / _` |/ _ \ '__| |_| |/ _` / __|/ _ \
//  / ___ \| |_) \__ \ | | |  __/ (_| |   <  __/ | | | (_| |  __/ |  |  _  | (_| \__ \  __/
// /_/   \_\_.__/|___/_| |_|\___|\__,_|_|\_\___|_| |_|\__,_|\___|_|  |_| |_|\__,_|___/\___|
public class AbsneakenderHase
{
    private List<string> brokieMokies;
    private List<GewinnbarerHase> gewinnbareHasen;

    public AbsneakenderHase(List<string> brokieMokies, List<GewinnbarerHase> gewinnbareHasen)
    {
        this.brokieMokies = brokieMokies;
        this.gewinnbareHasen = gewinnbareHasen;
    }

    //  _____________________________ 
    // < Finger weg von meinem Code! >
    //  ----------------------------- 
    //       \                    / \  //\
    //        \    |\___/|      /   \//  \\
    //             /0  0  \__  /    //  | \ \    
    //            /     /  \/_/    //   |  \  \  
    //            @_^_@'/   \/_   //    |   \   \ 
    //            //_^_/     \/_ //     |    \    \
    //         ( //) |        \///      |     \     \
    //       ( / /) _|_ /   )  //       |      \     _\
    //     ( // /) '/,_ _ _/  ( ; -.    |    _ _\.-~        .-~~~^-.
    //   (( / / )) ,-{        _      `-.|.-~-.           .~         `.
    //  (( // / ))  '/\      /                 ~-. _ .-~      .-~^-.  \
    //  (( /// ))      `.   {            }                   /      \  \
    //   (( / ))     .----~-.\        \-'                 .~         \  `. \^-.
    //              ///.----..>        \             _ -~             `.  ^-`  ^-_
    //                ///-._ _ _ _ _ _ _}^ - - - - ~                     ~-- ,.-~
    //                                                                   /.-~
    public Dictionary<string, string> Absneaken()
    {
        var richieMichies = new Dictionary<string, string>();
        var mokieBrokies = new List<string>();
        var zufaelligerHase = new Random();
        while (brokieMokies.Count > 0)
        {
            int rang = zufaelligerHase.Next() % brokieMokies.Count;
            mokieBrokies.Add(brokieMokies[rang]);
            brokieMokies.RemoveAt(rang);
        }
        while (gewinnbareHasen.Count > 0 && mokieBrokies.Count > 0)
        {
            var gewonnenerHase = gewinnbareHasen[0];
            var gewinnenderHase = mokieBrokies[0];
            richieMichies[gewinnenderHase] = gewonnenerHase.Hase;
            mokieBrokies.RemoveAt(0);
            if (gewonnenerHase.ZahlenmaessigerHase > 0)
            {
                gewinnbareHasen.RemoveAt(0);
            }
            else
            {
                gewinnbareHasen[0].ZahlenmaessigerHase--;
            }
        }
        return richieMichies;
    }
}
