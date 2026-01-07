using UnityEngine;

public class Marjorie2_1: DialogueMaster
{

    public static string[,] thisDialogue = {
        {
            "You",
            "Here. I got everything."
        },
        {
            "Marjorie",
            "Wonderful!"
        },
        {
            "Marjorie",
            "I've already prepared most of the concoction. All that's left is to add the ingredients."
        },
        {
            "You",
            "Take them."
        },
        {
            "Marjorie",
            "Thank you, kind sir!"
        },
        {
            "Marjorie",
            "Now, just give me a few second to thoroughly mix everything together!"
        },
        {
            "Marjorie",
            "..."
        },
        {
            "Marjorie",
            "There, just a little more."
        },
        {
            "Marjorie",
            "..."
        },
        {
            "You",
            "..."
        },
        {
            "Marjorie",
            "And here you go! A Vita Radicata Potion!"
        },
        {
            "Marjorie",
            "Now, make sure to give it all to the person you wish to save. Every last drop. Anything less and The Root's hold over them will be too much."
        },
        {
            "You",
            "Got it."
        },
        {
            "You",
            "And Marjorie: words cannot express how much this means to me."
        },
        {
            "You",
            "After all this time, I'll finally be able to save the man I love."
        },
        {
            "Marjorie",
            "Off you go then! Wouldn't want to hold him for too long!"
        },
        {
            "You",
            "Yes. Goodbye. And thank you."
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
