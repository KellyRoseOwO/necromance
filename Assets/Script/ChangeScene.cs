using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSwitcher : MonoBehaviour
{
    public string sceneName;  // ime scene, ki ga nastaviš v Inspectorju

    public void SwitchScene()
    {
        if(!string.IsNullOrEmpty(sceneName))
        {
            SceneManager.LoadScene(sceneName);  // uporabi ime iz Inspectorja
        }
        else
        {
            Debug.LogWarning("Scene name ni nastavljen!");
        }
    }
}
