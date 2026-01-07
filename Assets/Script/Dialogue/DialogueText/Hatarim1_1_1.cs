using UnityEngine;

public class Hatarim1_1_1: DialogueMaster
{

    public static string[,] thisDialogue = {
        {
            "???",
            "The womanthat wenteth to the mines with h'r sist'r?"
        },
        {
            "You",
            "That would be the one. She told me to say 'Hi', if I ever find you."
        },
        {
            "???",
            "Yond po'r mistress. To beest gift'd life by the roots and yet beest did hold backeth by h'r attachment to the physical."
        },
        {
            "???",
            "So single mindedly focus'd on finding the sooth yond the lady cannot seeth yond which is already in front of h'r."
        },
        {
            "You",
            "I'll take your word for it..."
        },
        {
            "You",
            "Though, before I ask what I originally wanted to, I'd like to at least know what I may call you. If you'd be so kind as to share your name."
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
