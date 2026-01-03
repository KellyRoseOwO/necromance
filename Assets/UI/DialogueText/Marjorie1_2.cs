using UnityEngine;

public class Marjorie1_2: DialogueMaster
{

    public static string[,] thisDialogue = {
        {
            "Marjorie",
            "Now, where were we again?"
        },
        {
            "Marjorie",
            "Ah, right! I was going to ask your name."
        },
        {
            "You",
            "And I was once again going to say that it's none of your business."
        },
        {
            "Marjorie",
            "Heh."
        },
        {
            "Marjorie",
            "Nevermind that then! What brings you to my shop?"
        },
        {
            "You",
            "I heard tell that an alchemist in Solimoor is capable of making a Vita Radicata Potion."
        },
        {
            "Marjorie",
            "Hmmm..."
        },
        {
            "Marjorie",
            "Indeed you heard correctly! And I am that achemist."
        },
        {
            "You",
            "So, how much will it cost me?"
        },
        {
            "Marjorie",
            "Well, a potion of life is not something that's easy to make."
        },
        {
            "You",
            "I'm willing to pay any price necesarry."
        },
        {
            "Marjorie",
            "In that case, I only require the materials."
        },
        {
            "Marjorie",
            "I need diver fish blood, a small piece of a Root extract and a fargment of a pearl."
        },
        {
            "Marjorie",
            "You can find the diver fish near the docks.\nThe town nut, Romeo, should have a pearl on his person.\nAnd you can easily get the Root extract by cutting off a tiny pice of the roots all around town."
        },
        {
            "You",
            "That sounds too easy. What's the catch?"
        },
        {
            "Marjorie",
            "Well, not everyone can make the potion! And I would gladly do this kind gesture for you! I mean, you are trying to save someone, are you not?"
        },
        {
            "You",
            "Yes..."
        },
        {
            "Marjorie",
            "Well, in that case we have a deal. Bring me the meterials and I shall make the Vita Radicata Potion."
        },
        {
            "You",
            "I'll be back soon."
        },
        {
            "Marjorie",
            "I'm counting on it!"
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
