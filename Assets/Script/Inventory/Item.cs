using UnityEngine;

[System.Serializable]
public class Item
{
    public string itemName;
    public Texture itemIcon;
    public int id;

    public Item(string name, Texture icon, int id)
    {
        itemName = name;
        itemIcon = icon;
        id = id;
    }
}
