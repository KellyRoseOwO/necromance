using UnityEngine;

public class Isa1_1: DialogueMaster
{

    public static string[,] thisDialogue = {
        {
            "Isa",
            "Hi there! I'm Isa. The other alchemist in town."
        },
        {
            "Isa",
            "I'm surprised you wanted to come visit me after talking with my sister. I overheard her talking to someone, though I don't know exactly what about."
        },
        {
            "Isa",
            "Out of curiosity: what did she spin about me this time?"
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
        {return 4;}
        set
        {}
    }

}
