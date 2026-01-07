using UnityEngine;

public class Hatarim1_2: DialogueMaster
{

    public static string[,] thisDialogue = {
        {
            "???",
            "V'ry well then."
        },
        {
            "???",
            "You may call me Hatarim."
        },
        {
            "You",
            "Okay, Hatarim, there is something I wanted to ask you."
        },
        {
            "You",
            "What are the ingredients for a Vita Radicata Potion?"
        },
        {
            "Hatarim?",
            "Scarfish blood, extracteth from the roots, a pearl,"
        },
        {
            "You",
            "That's only one off from what Marjorie told me."
        },
        {
            "Hatarim?",
            "And a life off'r'd in returneth."
        },
        {
            "You",
            "..."
        },
        {
            "You",
            "Thank you... Hatarim."
        },
        {
            "You",
            "In that case I know what I must do."
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
        {return 0;}
        set
        {}
    }

}
