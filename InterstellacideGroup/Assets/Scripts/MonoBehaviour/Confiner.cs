using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Confiner : Character
{
    public HealthBar healthBarPrefab;
    public StarDustBar starDustBarPrefab;
    public Player EnesPrefab;

    Player Enes;
    HealthBar healthBar;
    StarDustBar starDustBar;

    public void Start()
    {
        // DontDestroyOnLoad(healthBar);
        // DontDestroyOnLoad(starDustBar);
        // DontDestroyOnLoad(Enes);
        DontDestroyOnLoad(this.gameObject);
    }

    void Awake()
    {
        hitPoints.value = startingHitPoints;
        startDustPoints.value = startingStarDustPoints;


        healthBar = Instantiate(healthBarPrefab);
        starDustBar = Instantiate(starDustBarPrefab);
        Enes = Instantiate(EnesPrefab);
        DontDestroyOnLoad(this.gameObject);



        healthBar.character = this;
        starDustBar.character = this;
        Enes.enes = this;
    
    }
}
