using UnityEngine;

public class Isa1_1_1: DialogueMaster
{

    public static string[,] thisDialogue = {
        {
            "Isa",
            "Not my fault she can't keep her hands to herself."
        },
        {
            "Isa",
            "Though, I do hope that isn't going to disuade you from wanting to talk with me."
        },
        {
            "Isa",
            "She's been spreading that story around Solimoor since it happened, while conveniently forgetting to mention that we were both being guided by The Root, when going down there. They wanted us to find them. Sadly we failed, only finding a neglected mermaid-like girl."
        },
        {
            "Isa",
            "I don't know where that girl is right now, but I do hope she's safe."
        },
        {
            "You",
            "Marjorie said the girl was dead."
        },
        {
            "Isa",
            "Oh? Far from it. Marjorie just doesn't know it. You might be able to find her somewhere in town. Though I've no clue where. Tell her I said 'Hi', if you see her. And be careful about what you tell her, she is impresively knowledgable."
        },
        {
            "You",
            "I'll keep all that in mind."
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
        {return 5;}
        set
        {}
    }

}
