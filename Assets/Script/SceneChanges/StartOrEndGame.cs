// za permanentne spremembe scene

using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    public string sceneName;  // ime scene, ki ga nastaviš v Inspectorju
    private GameStateManager gameState = GameStateManager.gameState;

    public void SwitchScene()
    {

        if(!string.IsNullOrEmpty(sceneName))
        {
            /*gameState.inventory[0] = 0;
            gameState.inventory[1] = 0;
            gameState.inventory[2] = 0;
            gameState.inventory[3] = 0;
            gameState.inventory[4] = 0;
            gameState.inventory[5] = 0;
            gameState.isActive[0] = 1;
            gameState.isActive[1] = 0;
            gameState.isActive[2] = 1;
            gameState.isActive[3] = 1;
            gameState.MI = false;
            gameState.IH = false;
            gameState.H = false;
            gameState.hadIntro = false;*/

            SceneManager.LoadScene(sceneName);  // uporabi ime iz Inspectorja
        }
        else
        {
            Debug.LogWarning("Scene name ni nastavljen!");
        }
    }
}
