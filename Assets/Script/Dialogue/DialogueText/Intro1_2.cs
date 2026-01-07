using UnityEngine;

public class Intro1_2 : DialogueMaster
{
     
     
     string[,] thisDialogue = {
        {
            "You",
            "Just..."
        },
        {
            "You",
            "Just... give me a second to get up? I'll be right there."
        },
        {
            "You",
            "..."
        },
        {
            "You",
            "Ugh. Okay. I'm up. How've you been, Carlos?"
        },
        {
            "Carlos?",
            "Uggghhhhhh..?"
        },
        {
            "You",
            "I know I shouldn't expect an answer out of you, but can you really blame me for trying?"
        },
        {
            "Carlos?",
            "Mhhhhaghhh..."
        },
        {
            "You",
            "..."
        },
        {
            "You",
            "I'm sorry..."
        },
        {
            "You",
            "..."
        },
        {
            "You",
            "I'm going to make this right... I promise you..."
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
