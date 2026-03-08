using System.Collections.Generic;
using UnityEngine;

public class InventoryManager : MonoBehaviour
{
    public static InventoryManager Instance;

    public List<InventorySlot> slots = new List<InventorySlot>();
    public int inventorySize = 10;

    private void Awake()
    {
        Instance = this;

        for (int i = 0; i < inventorySize; i++)
        {
            slots.Add(new InventorySlot());
        }
    }

    public void AddItem(ItemData item)
    {
        // N?u stackable và ?ã có trong túi
        if (item.isStackable)
        {
            foreach (var slot in slots)
            {
                if (slot.item == item)
                {
                    slot.AddAmount(1);
                    return;
                }
            }
        }

        // Tìm slot tr?ng
        foreach (var slot in slots)
        {
            if (slot.item == null)
            {
                slot.item = item;
                slot.amount = 1;
                return;
            }
        }

        Debug.Log("Inventory Full!");
    }
}