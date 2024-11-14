using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private List<Item> _items = new List<Item>();

    public void AddItem(Item item)
    {
        _items.Add(item);
    }

    public void RemoveItem(Item item)
    {
        _items.Remove(item);
    }

    public bool HasItem(Item item)
    {
        return _items.Contains(item);
    }

    public List<Item> GetItems()
    {
        return _items;
    }
}
