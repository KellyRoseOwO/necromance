using UnityEngine;

public class Finale2_1: DialogueMaster
{

    public static string[,] thisDialogue = {
        {
            "You",
            "Carlos, I'm back..."
        },
        {
            "You",
            "I'm sorry I put you through all this."
        },
        {
            "Carlos?",
            "Hrrmmhhhh?"
        },
        {
            "You",
            "..."
        },
        {
            "You",
            "But it'll all be over soon."
        },
        {
            "You",
            "I just have to hope what Marjorie made will help..."
        },
        {
            "Carlos?",
            "Hrhhhh?"
        },
        {
            "You",
            "Here. Calm down. Drink everything. Every last drop."
        },
        {
            "You",
            "..."
        },
        {
            "You",
            "There. All done."
        },
        {
            "You",
            "Now all that's left is to wait."
        },
        {
            "You",
            "Then this'll all finally be over. Our story finally coming to an end. After all these years of dragging you along with me."
        },
        {
            "You",
            "..."
        },
        {
            "You",
            "Carlos?"
        },
        {
            "You",
            "..."
        },
        {
            "You",
            "I should have assumed as much from her."
        },
        {
            "You",
            "Or maybe I did..."
        },
        {
            "You",
            "I'm sorry for all this, Carlos."
        },
        {
            "You",
            "To die by my hand twice."
        },
        {
            "You",
            "Though, this time, I don't think I can bring you back."
        },
        {
            "You",
            "..."
        },
        {
            "You",
            "Lay peacefully."
        },
        {
            "You",
            "In the embrace of The Root."
        },
        {
            "You",
            "..."
        },
        {
            "You",
            "Goodbye."
        },
        {
            "You",
            "My one and only love."
        },
        {
            "You",
            "I'm sorry for lying to you all this time."
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
        {return 9;}
        set
        {}
    }

}
