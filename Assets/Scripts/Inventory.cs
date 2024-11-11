using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<Item> items = new List<Item>();  // List of items in the inventory

    // Add item to inventory
    public void AddItem(Item item)
    {
        items.Add(item);  // Add the item to the inventory list
        Debug.Log(item.itemName + " has been added to the inventory.");
    }
}
