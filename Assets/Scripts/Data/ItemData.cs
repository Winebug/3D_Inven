using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "New Item/item data")]
public class ItemData : ScriptableObject
{
    public string itemName;
    public string description;
    public Sprite itemIcon;
}