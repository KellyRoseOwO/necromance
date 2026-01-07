using UnityEngine;

public class Interact : MonoBehaviour
{

    public int interactionID;
    /*
    0 - Marjorie
    1 - Isa
    2 - Romeo
    3 - Hatarim
    */
    private bool playerNearby = false;
    public Dialogue dialogue;

    private GameStateManager gameState = GameStateManager.gameState;


    private void Start()
    {
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            playerNearby = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
            playerNearby = false;
    }

    private void Update()
    {
        bool inDialogue = dialogue.isPlayerInDialogue();
        if (playerNearby && Input.GetKeyDown(KeyCode.Return) && !inDialogue && gameState.isActive[interactionID] != 0)
        {
            switch(interactionID) {
                case 0:
                    if (gameState.inventory[0] == 1 // Marjorie2_1
                    && gameState.inventory[2] == 1 
                    && gameState.inventory[3] == 1 
                    && gameState.isActive[0] == 2) {
                        dialogue.startDialogue(5);
                        gameState.inventory[4] = 1;
                        gameState.isActive[0] = 0;
                        gameState.isActive[1] = 0;
                        gameState.isActive[2] = 0;
                        gameState.isActive[3] = 0;
                    } else if (gameState.isActive[0] == 1) {
                        dialogue.startDialogue(1); // Marjorie1_1
                        gameState.isActive[0] = 2;
                        gameState.isActive[1] = 1;
                        gameState.isActive[2] = 1;
                        gameState.isActive[3] = 0;
                    }
                    break;
                case 1:
                    if (gameState.inventory[1] == 1 // Isa2_1
                    && gameState.inventory[2] == 1
                    && gameState.inventory[3] == 1
                    && gameState.inventory[3] == 1
                    && gameState.H
                    && gameState.isActive[1] == 2) {
                        dialogue.startDialogue(6);
                        gameState.inventory[5] = 1;
                        gameState.isActive[0] = 0;
                        gameState.isActive[1] = 0;
                        gameState.isActive[2] = 0;
                        gameState.isActive[3] = 0;
                    } else if (gameState.isActive[1] == 1) {
                        dialogue.startDialogue(2); // Isa1_1
                        gameState.isActive[1] = 2;
                        gameState.isActive[3] = 1;
                    }
                    break;
                case 2:
                    dialogue.startDialogue(3); // Romeo1_1
                    gameState.isActive[2] = 0;
                    break;
                case 3:
                    dialogue.startDialogue(4); // Hatarim1_1
                    gameState.isActive[3] = 0;
                    gameState.H = true;
                    break;
            }
        }
    }
}
