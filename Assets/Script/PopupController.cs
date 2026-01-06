using UnityEngine;

public class PopupController : MonoBehaviour
{
    public GameObject popupPanel; 

    public void OpenPopup()
    {
        if (popupPanel != null)
            popupPanel.SetActive(true);
        else
            Debug.LogError("Popup panel not assigned!");
    }

    public void ClosePopup()
    {
        if (popupPanel != null)
            popupPanel.SetActive(false);
    }
}
