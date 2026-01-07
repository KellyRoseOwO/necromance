using UnityEngine;

public class Marjorie1_1: DialogueMaster
{

    public static string[,] thisDialogue = {
        {
            "Alchemist",
            "Welcome, weary traveller! What brings you to Solimoor?"
        },
        {
            "You",
            "..."
        },
        {
            "You",
            "You're joking, right?"
        },
        {
            "Alchemist",
            "Oh, my dear, I am not! You reak of the outside!"
        },
        {
            "You",
            "None of your business."
        },
        {
            "Alchemist",
            "My, my. There's no need to get feisty."
        },
        {
            "Marjorie",
            "My name is Marjorie. The better alchemist in Solimoor!"
        },
        {
            "You",
            "Who is the other one then? I've only seen this shop."
        },
        {
            "Marjorie",
            "My twin sister's shop is a couple of metres away from mine. Though luckily she isn't there right now!"
        },
        {
            "You",
            "I'm sorry about that..?"
        },
        {
            "Marjorie",
            "Don't be. She's horrible at her job."
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
        {return 2;}
        set
        {}
    }

}
