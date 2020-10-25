using UnityEngine;

public abstract class Character : MonoBehaviour {

    /* Health, HitPoints will be shaerd reference 
    to healthBar, so they can be the same */
    public HitPoints hitPoints;
    public float startingHitPoints;
    public float maxHitPoints;


    public enum CharacterCategory
    {
        PLAYER,
        ENEMY
    }
    public CharacterCategory characterCategory;
}