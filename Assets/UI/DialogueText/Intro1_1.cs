using UnityEngine;

public class Intro1_1 : DialogueMaster
{
    
    private string[,] thisDialogue = {
        {
            "???",
            "Hhh..."
        },
        {
            "???",
            "Hhh... Ah... Hmph..."
        },
        {
            "???",
            "AAAAAAAAAAAA!!!"
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
        {return 1;}
        set{}
    }

}
