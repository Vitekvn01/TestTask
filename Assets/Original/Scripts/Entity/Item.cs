using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class Item : MonoBehaviour, IInteractivuble
{
    public GameObject Item3DView { get; private set; }

    private void Start()
    {
        Item3DView = gameObject;
    }
    public void Interactive()
    {
        Inventory inventory = ServiceLocator.GetService<Inventory>();
        inventory.AddItem(this);

        // ���������� ������� ����� �������
        Item3DView.SetActive(false);
    }
}
