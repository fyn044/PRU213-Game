using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    public GameObject inventoryPanel;
    public InventorySlotUI[] slots;
    public Sprite testItem;

    void Start()
    {
        inventoryPanel.SetActive(false);

        slots[0].SetItem(testItem, 5);
        slots[1].SetItem(testItem, 1);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            inventoryPanel.SetActive(!inventoryPanel.activeSelf);
        }
    }
}