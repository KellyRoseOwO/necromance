using UnityEngine;

public class GameStateManager : MonoBehaviour
{
    public static GameStateManager gameState;
    public bool hadIntro = false;

    public int[] inventory = {0, 0, 0, 0, 0, 0};
    // inventory[4] = bad end
    // inventory[5] = good end
    // Item Ids:
    /*
    Diver Fish - 0
    Scarfish - 1
    Pearl - 2
    Root - 3
    */
    
    public int[] isActive = {1, 0, 0, 0};
    /*
    0 - Marjorie
    1 - Isa
    2 - Romeo
    3 - Hatarim
    */

    public bool MI = false;
    public bool IH = false;
    public bool H = false;

    void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        gameState = this;
    }

    void Update() {
        Debug.Log(string.Format("{0} {1} {2} {3} {4} {5}", gameState.inventory[0], gameState.inventory[1], gameState.inventory[2], 
        gameState.inventory[3], gameState.inventory[4], gameState.inventory[5]));
    }
}
