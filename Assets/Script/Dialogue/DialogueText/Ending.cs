using UnityEngine;
using TMPro;

public class Ending : MonoBehaviour
{
    public TextMeshProUGUI text;
    public TextMeshProUGUI endingType;
    private GameStateManager gameState = GameStateManager.gameState;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (gameState.inventory[4] == 1) {
            endingType.text = "Bad Ending";
            text.text = "Carlos died as he drank the 'Vita Radicata Potion'\nThere is nothing holding you back anymore...\nAnd nothing to keep you afloat either...";
        } else {
            endingType.text = "Good Ending";
            text.text = "Carlos drank the Vita Radicata Potion and regained his soul!\nHowever, for the effect to take hold for longer than a couple of seconds, you had to die.\nBut at least you died happy.\nYou were able to bring your lover back and save him.\nAnd this time he's not going to die!";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
