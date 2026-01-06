using UnityEngine;

public class PickupItem : MonoBehaviour
{
    public string itemName = "Default Item"; 
    private bool playerNearby = false;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
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
            // add to inventory
            Inventory playerInventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();
            if (playerInventory != null)
            {
                playerInventory.AddItem(itemName);
            }

            if (audioSource != null)
                audioSource.Play();

            Destroy(gameObject, audioSource != null ? audioSource.clip.length : 0f);
        }
    }
}
