using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponUpgrade : MonoBehaviour
{

    public Sprite upgradedGun;
    public int cuPoints;
    private const int pointsGoal = 3;
    // Update is called once per frame
    void Update()
    {
        if (cuPoints >= pointsGoal)
        {
            this.gameObject.GetComponent<SpriteRenderer>().sprite = upgradedGun;
        }
    }
}
