using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class InventorySlotUI : MonoBehaviour
{
    public Image icon;
    public TextMeshProUGUI amountText;

    public void SetItem(Sprite itemIcon, int amount)
    {
        if (itemIcon == null)
        {
            icon.enabled = false;
            amountText.text = "";
            return;
        }

        icon.enabled = true;
        icon.sprite = itemIcon;

        if (amount > 1)
            amountText.text = amount.ToString();
        else
            amountText.text = "";
    }
}