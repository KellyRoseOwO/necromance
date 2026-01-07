using UnityEngine;

public class Hatarim1_1: DialogueMaster
{

    public static string[,] thisDialogue = {
        {
            "You",
            "Hello? Is anyone down there?"
        },
        {
            "???",
            "Has't thee cometh to tryeth and slayeth me?"
        },
        {
            "You",
            "I have not. I caught the whiff of something I recognise down there so I thought I might as well check."
        },
        {
            "???",
            "I am not familiar with thee. Howev'r, thee doth has't Carlos' stench on thee."
        },
        {
            "You",
            "You know Carlos?"
        },
        {
            "???",
            "I haven't hath met him, but I has't hath heard of him."
        },
        {
            "You",
            "What do you know about him then?"
        },
        {
            "???",
            "I'm s'rry f'r bringing t up."
        },
        {
            "You",
            "Don't be. I'd simply like to hear what you know about him."
        },
        {
            "???",
            "Not much beside what the roots has't whisp'r'd to me."
        },
        {
            "You",
            "Yes?"
        },
        {
            "???",
            "Nothing m're."
        },
        {
            "You",
            "Well, I won't ask any further."
        },
        {
            "???",
            "I can't bid thee any m're."
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
        {return 6;}
        set
        {}
    }

}
