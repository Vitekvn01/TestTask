using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Inventory : MonoBehaviour, IService
{
    private List<Item> _items = new List<Item>();

    private void Awake()
    {
        ServiceLocator.RegisterService<Inventory>(this);
    }
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
