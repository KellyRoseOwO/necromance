using UnityEngine;

public class Marjorie1_1_1: DialogueMaster
{

    public static string[,] thisDialogue = {
        {
            "Marjorie",
            "Ugh!"
        },
        {
            "Marjorie",
            "I'm sorry, do you not want to do business with me?"
        },
        {
            "You",
            "I do. I was just curious what she had done to make you detest her."
        },
        {
            "Marjorie",
            "Fine. But you better not regret asking."
        },
        {
            "Marjorie",
            "A couple of years back, we went down into the mines below Solimoor together. She desperately wanted to find the physical body of the Root and I decided to acompany her."
        },
        {
            "Marjorie",
            "Much to her dismay, all she found was the corpse of a young girl. Who somehow went outside for long enough to get partially turned and came back here part fish, only to die alone."
        },
        {
            "Marjorie",
            "But that didn't stop her from forcing me to evaluate the obvious corpse!"
        },
        {
            "Marjorie",
            "And what did that lead to?! Me having to chop off my own hand due to an outer infection."
        },
        {
            "Marjorie",
            "And she didn't even care to help stop the bleeding. All she could think about and talk about was the Root!"
        },
        {
            "Marjorie",
            "Does that help clear it up?"
        },
        {
            "You",
            "Thank you. It does."
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
        {return 3;}
        set
        {}
    }

}
