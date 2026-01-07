using UnityEngine;

public class Marjorie1_1_2 : DialogueMaster
{

    public static string[,] thisDialogue = {
        {
            "Marjorie",
            "You didn't strike me as the nice kind."
        },
        {
            "Marjorie",
            "Anyway, I appreciate not being pried into."
        },
        {
            "You",
            "I'm just here to do business."
        },
        {
            "Marjorie",
            "I am however, interested in how you managed to make it all the way through the sea to Solimoor. And by the looks of it, you managed to do so without a single infection!"
        },
        {
            "Marjorie",
            "Are you perhaps a Root Whisperer?"
        },
        {
            "Marjorie",
            "No. You don't have that smell about you. Unlike crazy old Romeo down the street."
        },
        {
            "Marjorie",
            "No. You're a Necromancer, aren't you?"
        },
        {
            "You",
            "I didn't pry into you, so I'd appreciate it if you didn't pry into me."
        },
        {
            "Marjorie",
            "Of course, of course, I apologise, kind sir!"
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
