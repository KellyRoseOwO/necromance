using UnityEngine;

public class PickupItem : MonoBehaviour
{
    public string itemName = "Default Item";
    public Texture itemIcon;
    private bool playerNearby = false;
    private AudioSource audioSource;

    private PickupPopupUI popupUI;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        popupUI = FindObjectOfType<PickupPopupUI>();
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
        if (playerNearby && Input.GetKeyDown(KeyCode.Return))
        {
            Inventory playerInventory =
                GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();

            if (playerInventory != null)
            {
                playerInventory.AddItem(itemName, itemIcon);

        
            }

            if (popupUI != null)
            {
                popupUI.ShowPopup(itemName, itemIcon);

           
            }

            if (audioSource != null)
                audioSource.Play();

            Destroy(gameObject, audioSource != null ? audioSource.clip.length : 0f);
        }
    }
}
