using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PickupPopupUI : MonoBehaviour
{
    public GameObject popupPanel;          // The panel itself
    public TextMeshProUGUI popupText;      // Text component
    public RawImage popupImage;            // RawImage component inside panel
    public float showTime = 2f;

    public void ShowPopup(string itemName, Texture itemTexture)
    {
        popupText.text = "Picked up " + itemName;

        if (popupImage != null)
            popupImage.texture = itemTexture; // <--- assign the item texture here

        popupPanel.SetActive(true);

        CancelInvoke();
        Invoke(nameof(Hide), showTime);
    }

    private void Hide()
    {
        popupPanel.SetActive(false);
    }
}
