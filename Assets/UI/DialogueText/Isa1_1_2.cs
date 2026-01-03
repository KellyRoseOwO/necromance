using UnityEngine;

public class Isa1_1_2: DialogueMaster
{

    public static string[,] thisDialogue = {
        {
            "Isa",
            "Well, in that case, I don't think that's much of a hurdle, when it comes to talking with me."
        },
        {
            "You",
            "There is indeed not."
        },
        {
            "You",
            "And from my impression of you so far, I'd easier see you having a problem with her, not the other way around."
        },
        {
            "You",
            "Welp, that just comes with being a twin."
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
        {return 5;}
        set
        {}
    }

}
