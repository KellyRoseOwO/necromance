using UnityEngine;

public class Isa2_1: DialogueMaster
{

    public static string[,] thisDialogue = {
        {
            "You",
            "Isa, I'm back."
        },
        {
            "You",
            "I managed to find everything for the real potion. Your mermaid friend was quite a help to me."
        },
        {
            "Isa",
            "That's good and all, but quicky hand over everything, before Marjorie catches onto what we're doing."
        },
        {
            "You",
            "Here. Take it."
        },
        {
            "Isa",
            "Okay. Just give me a couple of seconds..."
        },
        {
            "Isa",
            "..."
        },
        {
            "Isa",
            "Okay, here you go. A single drop into their mouth should be enough."
        },
        {
            "Isa",
            "And hurry up. I can tell The Root is going to consume them soon, if you don't do anything."
        },
        {
            "You",
            "Thank you. Let me just give you your payment. How much did you want again?"
        },
        {
            "Isa",
            "No! Go!"
        },
        {
            "Isa",
            "You don't have the time! Get to them! Then come back to pay."
        },
        {
            "You",
            "..."
        },
        {
            "You",
            "I'll be back as soon as I can."
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
