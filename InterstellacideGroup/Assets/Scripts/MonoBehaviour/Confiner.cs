using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Confiner : Character
{
    // public HealthBar healthBarPrefab;
    // public StarDustBar starDustBarPrefab;
    // public Player EnesPrefab;

    public HealthBar healthBar;
    public StarDustBar starDustBar;
    public Player Enes;


    // public void Start()
    // {
    //     hitPoints.value = startingHitPoints;
    //     startDustPoints.value = startingStarDustPoints;

    //     healthBar.character = this;
    //     starDustBar.character = this;
    //     Enes.enes = this;
    // }

    void Awake()
    {
        hitPoints.value = startingHitPoints;
        startDustPoints.value = startingStarDustPoints;
        
        healthBar.character = this;
        starDustBar.character = this;
        Enes.enes = this;

        // healthBar = Instantiate(healthBarPrefab);
        // starDustBar = Instantiate(starDustBarPrefab);
        // Enes = Instantiate(EnesPrefab);

        
        DontDestroyOnLoad(this.gameObject);


    }
}
