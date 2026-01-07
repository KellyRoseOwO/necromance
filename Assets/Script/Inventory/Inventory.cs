using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> items = new List<Item>();
    private GameStateManager gameState = GameStateManager.gameState;

    public void AddItem(string itemName, Texture itemIcon, int id)
    {
        Item newItem = new Item(itemName, itemIcon, id);
        items.Add(newItem);
        Debug.Log(itemName + " added to inventory. Total items: " + items.Count);

        gameState.inventory[id] = 1;
    }

    // Item Ids:
    /*
    Diver Fish - 1
    Scarfish - 2
    Pearl - 3
    Root - 4
    */
}
