namespace RedRiggedRaffle;

//   ____               _             _                         _   _                
//  / ___| _____      _(_)_ __  _ __ | |__   __ _ _ __ ___ _ __| | | | __ _ ___  ___ 
// | |  _ / _ \ \ /\ / / | '_ \| '_ \| '_ \ / _` | '__/ _ \ '__| |_| |/ _` / __|/ _ \
// | |_| |  __/\ V  V /| | | | | | | | |_) | (_| | | |  __/ |  |  _  | (_| \__ \  __/
//  \____|\___| \_/\_/ |_|_| |_|_| |_|_.__/ \__,_|_|  \___|_|  |_| |_|\__,_|___/\___|
public class GewinnbarerHase
{
    public string Hase { get; }

    public int ZahlenmaessigerHase { get; set; }

    //  _________________________ 
    // < Mich kann man gewinnen! >
    //  ------------------------- 
    //   \
    //    \   \
    //         \ /\
    //         ( )
    //       .( o ).
    // 
    public GewinnbarerHase(string hase, int hasen)
    {
        Hase = hase;
        ZahlenmaessigerHase = hasen;
    }
}
