using UnityEngine;

public class Romeo1_1: DialogueMaster
{

    public static string[,] thisDialogue = {
        {
            "???",
            "All! Listen! Fall to the Roots! Let go of your mortal body!"
        },
        {
            "You",
            "You must be Romeo."
        },
        {
            "Romeo?",
            "Depends on who's asking?!"
        },
        {
            "You",
            "Just someone who wishes to ask you about something."
        },
        {
            "Romeo?",
            "Are you here to silence me?!"
        },
        {
            "You",
            "Certainly not."
        },
        {
            "You",
            "I simply wish to inqure about a pearl you might have in your possession."
        },
        {
            "Romeo",
            "In that case, I am indeed Romeo. A Priest of Rot!"
        },
        {
            "Romeo",
            "And this here."
        },
        {
            "Romeo",
            "Is my holy pearl."
        },
        {
            "You",
            "How much would it cost me to aquire it?"
        },
        {
            "Romeo",
            "A blasphemer, such as yourself?"
        },
        {
            "Romeo",
            "Your death."
        },
        {
            "You",
            "That is not something I am willing to give you just yet."
        },
        {
            "Romeo",
            "Hmmm..."
        },
        {
            "Romeo",
            "Fine."
        },
        {
            "Romeo",
            "Take it."
        },
        {
            "Romeo",
            "I've no use for it anyway."
        },
        {
            "You",
            "Just like that?"
        },
        {
            "Romeo",
            "Leave before I change my mind."
        },
        {
            "You",
            "Thank you."
        },
        {
            "You",
            "..."
        },
        {
            "You",
            "So, where is the pearl?"
        },
        {
            "Romeo",
            "Must I do everything for you blasphemer?"
        },
        {
            "Romeo",
            "Look around the barrels near the back of the church."
        },
        {
            "Romeo",
            "If no one took it, it should still be there."
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
