using UnityEngine;

public class Player : Character
{
    public void Start()
	{

	}

    // used when player collider interacts with another collider
    // use this to customize behavior when two objects collide
    // method is called when player overlaps with a trigger collider

	void OnTriggerEnter2D(Collider2D collision)
    {
        //if collision object has  tag "CanBePickedUp", aka coins, hearts, etc...
        if (collision.gameObject.CompareTag("CanBePickedUp"))
        {
            //store reference to scriptable object
            //pass in consumable script in getComponent
            Item hitObject = collision.gameObject.GetComponent<Consumable>().item;


            if (hitObject != null)
            {
                print("Hit: " + hitObject.objectName);

                switch (hitObject.itemType)
                {
                    case Item.ItemType.COIN:
                        break;
                    case Item.ItemType.HEALTH:
                    //if it collided with heart adjust health points
                        AdjustHitPoints(hitObject.quantity); 
                        break;
                    default:
                        break;
                }
                // item is picked up and dissappears
                collision.gameObject.SetActive(false);
            }

        }
    }

    public void AdjustHitPoints(int amount)
    {
        hitPoints = hitPoints + amount;
        print("Adjusted hitpoints by: " + amount + ". New value: " + hitPoints);
    }
}