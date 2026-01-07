using UnityEngine;

public class Finale1_1: DialogueMaster
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
            "We never should have gone after the Untethered..."
        },
        {
            "You",
            "I'm sorry you had to stay a living corpse for this long."
        },
        {
            "You",
            "But I don't regret bringing you back."
        },
        {
            "You",
            "Especially now that I have this. A Vita Radicata Potion."
        },
        {
            "Carlos?",
            "..."
        },
        {
            "Carlos?",
            "ARRRRAARARAAAAAHAHAHHHHHHHHHHHHHHHHHHHHH!"
        },
        {
            "You",
            "There's no need to scream anymore. Just take this one single drop."
        },
        {
            "You",
            "..."
        },
        {
            "You",
            "And here you go."
        },
        {
            "You",
            "Now there's just one last thing to do."
        },
        {
            "You",
            "AHHHH!"
        },
        {
            "You",
            "Huh..."
        },
        {
            "You",
            "Ha..."
        },
        {
            "You",
            "I'm sorry Carlos..."
        },
        {
            "You",
            "This is how I atone for my mistake..."
        },
        {
            "Carlos?",
            "Arh..."
        },
        {
            "Carlos?",
            "ARHHHHHH!"
        },
        {
            "Carlos",
            "Huff..."
        },
        {
            "Carlos",
            "I..."
        },
        {
            "You",
            "I'm happy I at least get to hear you speak one last time."
        },
        {
            "Carlos",
            "What..."
        },
        {
            "Carlos",
            "Are you..."
        },
        {
            "Carlos",
            "Going on about..?"
        },
        {
            "Carlos",
            "Why is my throat so sore?"
        },
        {
            "Carlos",
            "Do you have any..."
        },
        {
            "Carlos",
            "Water..?"
        },
        {
            "You",
            "..."
        },
        {
            "Carlos",
            "Wait! You're bleeding!"
        },
        {
            "Carlos",
            "What happened?! Let me patch you up!"
        },
        {
            "You",
            "Don't!"
        },
        {
            "You",
            "I did this to myself..."
        },
        {
            "Carlos",
            "Okay, you're an idiot! Screw my throat, I'm fixing you up right now! I'm not having you dying on me."
        },
        {
            "You",
            "I said don't!"
        },
        {
            "Carlos",
            "I'm not losing you!"
        },
        {
            "You",
            "Well, I've already lost you once... Don't make it happen again..."
        },
        {
            "Carlos",
            "What do you mean?"
        },
        {
            "You",
            "The Untethered..."
        },
        {
            "Carlos",
            "..."
        }, 
        {
            "Carlos",
            "We didn't win, did we?"
        },
        {
            "You",
            "No, we did not..."
        },
        {
            "Carlos",
            "And you kept my body tethered to this world this whole time."
        },
        {
            "You",
            "I love you."
        },
        {
            "Carlos",
            "What are you going on about?"
        },
        {
            "You",
            "I know I've never been open about my feelings, but I need you to hear that before I bleed out."
        },
        {
            "You",
            "I love you, Carlos..."
        },
        {
            "Carlos",
            "I..."
        },
        {
            "Carlos",
            "Love you as well..."
        },
        {
            "Carlos",
            "I always have."
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
        {return 8;}
        set
        {}
    }

}
