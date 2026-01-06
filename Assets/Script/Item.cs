using UnityEngine;

[System.Serializable]
public class Item
{
    public string itemName;
    public Texture itemIcon;

    public Item(string name, Texture icon)
    {
        itemName = name;
        itemIcon = icon;
    }
}
