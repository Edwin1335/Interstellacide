using UnityEngine;

public class Player : Character
{
    //  public Inventory inventoryPrefab;
    // Inventory inventory;



    public HealthBar healthBarPrefab;
    public StarDustBar starDustBarPrefab;
    HealthBar healthBar;
    StarDustBar starDustBar;

    public void Start()
    {
        hitPoints.value = startingHitPoints;
        startDustPoints.value = startingStarDustPoints;
        // inventory = Instantiate(inventoryPrefab);
        healthBar = Instantiate(healthBarPrefab);
        starDustBar = Instantiate(starDustBarPrefab);
        healthBar.character = this;
        starDustBar.character = this;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("CanBePickedUp"))
        {
            Item hitObject = collision.gameObject.GetComponent<Consumable>().item;

            if (hitObject != null)
            {
                bool shouldDisappear = false;

                switch (hitObject.itemType)
                {
                    case Item.ItemType.HEALTH:
                        shouldDisappear = IncreaseHitPoints(hitObject.quantity);
                        break;
                    case Item.ItemType.STARDUST:
                        shouldDisappear = IncreaseStarDustPoints(hitObject.quantity);
                        break;
                    default:
                        break;
                }

                if (shouldDisappear)
                {
                    collision.gameObject.SetActive(false);
                }
            }
        }
        if (collision.gameObject.CompareTag("DamageUfoAlien"))
        {
            print("HIT PLAYER");
            DecreaseHitPoints(2);
        }
    }

    public bool IncreaseHitPoints(int amount)
    {
        if (hitPoints.value < maxHitPoints)
        {
            hitPoints.value = hitPoints.value + amount;
            print("Adjusted HP by: " + amount + ". New value: " + hitPoints.value);
            return true;
        }
        print("didnt adjust hitpoints");
        return false;
    }
    public bool IncreaseStarDustPoints(int amount)
    {
        if (startDustPoints.value< maxStarDustPoints)
        {
            startDustPoints.value= startDustPoints.value+ amount;
            print("Adjusted star dust points by: " + amount + ". New value: " + startDustPoints.value);
            return true;
        }
        print("didnt adjust stardust points");
        return false;
    }
    public bool DecreaseHitPoints(int amount)
    {
        if (hitPoints.value != 0)
        {
            hitPoints.value = hitPoints.value - amount;
            print("Adjusted HP by: " + amount + ". New value: " + hitPoints.value);
            return true;
        }
        print("didnt adjust hitpoints");
        return false;
    }
}