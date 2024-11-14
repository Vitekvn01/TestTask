using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour, IPickup
{
    public GameObject Item3DView { get; private set; }

    public void Pickup()
    {
        throw new System.NotImplementedException();
    }

    private void Start()
    {
        Item3DView = gameObject;
    }
}
