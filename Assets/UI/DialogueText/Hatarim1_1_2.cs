using UnityEngine;

public class Hatarim1_1_2: DialogueMaster
{

    public static string[,] thisDialogue = {
        {
            "???",
            "The roots mainly whisp'r to me of loss."
        },
        {
            "???",
            "I've hath heard of Carlos' loss, of Romeo's loss."
        },
        {
            "???",
            "Though, anon yond I'm talking with thee, thee has't a similar air about thee."
        },
        {
            "???",
            "Prithee bid me of thy loss."
        },
        {
            "You",
            "Carlos and I travelled the sea in search of something."
        },
        {
            "You",
            "But in the process, he was killed, while I remained alive."
        },
        {
            "You",
            "So, I brought him back to life."
        },
        {
            "You",
            "But, while his body is now once again alive, his soul isn't there anymore. Or it's buried deep beneath. I don't really know wich of the two is true."
        },
        {
            "You",
            "There. That's my loss. Are you satisfied?"
        },
        {
            "???",
            "T is forsooth sufficient. But I can bid thee, his soul hast been hath kept particularly closeth to the roots since coequal bef're his passing."
        },
        {
            "You",
            "Considering how much I've shared with you, I think I deserve to at least know your name."
        }
    };
    
    public override string[,] dialogue
    {
        get
        {return thisDialogue;}
        set
        {}
    }

    public override int onEnd
    {
        get
        {return 7;}
        set
        {}
    }

}
