[System.Serializable]
public class InventorySlot
{
    public ItemData item;
    public int amount;

    public void AddAmount(int value)
    {
        amount += value;
    }
}