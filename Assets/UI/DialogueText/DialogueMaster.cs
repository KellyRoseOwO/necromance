using UnityEngine;

public abstract class DialogueMaster : MonoBehaviour
{
    public abstract string[,] dialogue {get; set;}
    public abstract int onEnd {get; set;}
}
