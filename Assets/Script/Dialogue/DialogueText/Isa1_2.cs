using UnityEngine;

public class Isa1_2: DialogueMaster
{

    public static string[,] thisDialogue = {
        {
            "Isa",
            "Well, anyway, what did you want to talk about?"
        },
        {
            "You",
            "Just wanted to ask, if Marjorie is the only one capable of making a Vita Radicata Potion? Something about her struck me as odd."
        },
        {
            "Isa",
            "Well, I probably could mix it, if I had the ingredients in front of me, but I don't even know what those would be."
        },
        {
            "You",
            "Diver fish blood, Root extract, and a pearl."
        },
        {
            "Isa",
            "Good thing you came to me then!"
        },
        {
            "Isa",
            "While I don't know the exact recipe for a Vita Radicata Potion, I can tell you with almost 100% certainty that the ingredients you listed, would not make one."
        },
        {
            "You",
            "How can I know you aren't lying to me as well then?"
        },
        {
            "Isa",
            "Well, I'm sincerely hoping you trust me! Whoever you're trying to save with that poition, will not live, if you give them what Marjorie wanted to cook up."
        },
        {
            "You",
            "So, if I find out the correct components and bring them to you, you can make the correct potion for me?"
        },
        {
            "Isa",
            "Well, it'll cost you, but I will do my best!"
        },
        {
            "You",
            "Marjorie didn't want any type of payment..."
        },
        {
            "You",
            "Very well then. I'll go, and I'll be back with the ingredients when I find them."
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
