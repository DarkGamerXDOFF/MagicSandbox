using UnityEngine;

[CreateAssetMenu(fileName = "NewItem", menuName = "Scriptable Objects/Inventory/Item")]
public class Item : ScriptableObject
{
    public int id;
    public new string name;
    public Sprite sprite;
    public int maxStackSize;
    public int count;
}