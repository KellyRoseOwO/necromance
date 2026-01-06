using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> items = new List<Item>();

    public void AddItem(string itemName, Texture itemIcon)
    {
        Item newItem = new Item(itemName, itemIcon);
        items.Add(newItem);
        Debug.Log(itemName + " added to inventory. Total items: " + items.Count);
    }
}
