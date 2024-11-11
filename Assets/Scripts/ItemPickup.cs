using UnityEngine;

public class ItemPickup : MonoBehaviour
{
    private bool isInRange = false;  // Is the player close to the item?
    private Inventory playerInventory;  // Reference to the player's inventory

    private Item item;  // Reference to the item component

    void Start()
    {
        // Find the player's inventory by tag
        playerInventory = GameObject.FindGameObjectWithTag("Player").GetComponent<Inventory>();

        // Get the Item component attached to this GameObject (assumed to be attached)
        item = GetComponent<Item>();
    }

    void Update()
    {
        // If the player is in range and presses Q, pick up the item
        if (isInRange && Input.GetKeyDown(KeyCode.Q))
        {
            playerInventory.AddItem(item);  // Add the item to the player's inventory
            Destroy(gameObject);  // Destroy the item from the scene
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))  // Check if the player is near the item
        {
            isInRange = true;  // Player is within range to pick up the item
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))  // Check if the player leaves the item range
        {
            isInRange = false;  // Player is no longer near the item
        }
    }
}
