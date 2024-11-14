using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UIElements;

public class DropZone : MonoBehaviour, IInteractivuble
{
    [SerializeField] private Transform SpawnPos;
    public void Interactive()
    {

        Inventory inventory = ServiceLocator.GetService<Inventory>();


        if (inventory.GetItems().Count > 0)
        {

            Item itemToDrop = inventory.GetItems().FirstOrDefault();

            if (itemToDrop != null)
            {

                itemToDrop.Item3DView.SetActive(true);
                itemToDrop.Item3DView.transform.position = SpawnPos.position;

                inventory.RemoveItem(itemToDrop);




                Debug.Log("Item dropped!");
            }
        }
    }

}
