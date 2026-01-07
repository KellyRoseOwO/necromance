using UnityEngine;

public class StartDialogueOnStart : MonoBehaviour
{
    public Dialogue dialogue;
    private GameStateManager gameState = GameStateManager.gameState;
    private bool intro;
    public UnityEngine.UI.Button exitButton;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        intro = gameState.hadIntro;

        if (!intro) {
            dialogue.startDialogue(0);
            exitButton.gameObject.SetActive(false);
            intro = true;
            gameState.hadIntro = true;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        bool isNotDone = dialogue.isPlayerInDialogue();
        Debug.Log(isNotDone);
        if (!isNotDone) {
            exitButton.gameObject.SetActive(true);
        }
    }
}
