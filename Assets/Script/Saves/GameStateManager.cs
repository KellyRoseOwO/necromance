using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    public static GameStateManager gameState;
    public bool hadIntro = false;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        gameState = this;
    }
}
