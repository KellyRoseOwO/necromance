using UnityEngine;

public class LightUpNPC : MonoBehaviour
{

    private GameStateManager gameState = GameStateManager.gameState;
    public Light thisLight;
    public int NPCID = -1;
    public int brightness = 2;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (
        (gameState.isActive[NPCID] == 1) ||
        (gameState.inventory[0] == 1 && gameState.inventory[2] == 1 && gameState.inventory[3] == 1 && gameState.isActive[0] == 2 && gameState.isActive[NPCID] == 2) ||
        (gameState.inventory[1] == 1 && gameState.inventory[2] == 1 && gameState.inventory[3] == 1 && gameState.inventory[3] == 1 && gameState.H && gameState.isActive[NPCID] == 2)
        ) {
            thisLight.range = brightness;      
        } else {
            thisLight.range = 0;
        }


    }
}
