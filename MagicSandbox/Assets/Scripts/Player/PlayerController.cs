using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    public Inventory primaryInventory;
    public Inventory secondaryInvetory;

    public GameObject inventory;
    public Color pColor;
    public Color sColor;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
            ToggleInventory(InventoryMode.PRIMARY);
        else if (Input.GetKeyDown(KeyCode.F))
            ToggleInventory(InventoryMode.SECONDARY);
    }

    private void ToggleInventory(InventoryMode mode)
    {
        if (inventory.activeSelf)
            inventory.SetActive(false);
        else
        {
            inventory.SetActive(true);

            switch (mode)
            {
                case InventoryMode.PRIMARY:
                    inventory.GetComponent<Image>().color = pColor;
                    break;
                case InventoryMode.SECONDARY:
                    inventory.GetComponent<Image>().color = sColor;
                    break;
                default:
                    break;
            }
        }
    }
}

public enum InventoryMode
{
    PRIMARY,
    SECONDARY
}
