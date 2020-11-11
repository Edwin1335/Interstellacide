using UnityEngine;

public class Weapon2 : MonoBehaviour
{
    private Transform aimTransform;
    public Transform firePoint; //point of fire from gun
    public int damage = 10; //damage enemy takes 
    public GameObject bulletPrefab;
    public float fireRate = 0.5f;
    private float nextFire = 0.0f;

    private const int pointGoal = 3;
    public int cuPoints = 0;

    private void Awake()
    {
        if(!PauseMenu.GamePause){
            aimTransform = transform.Find("Aim");
        }

    }

    // Update is called once per frame
    void Update()
    {
        if(!PauseMenu.GamePause){
            if (Input.GetKey(KeyCode.Mouse0) && Time.time > nextFire)
            {
                nextFire = Time.time + fireRate;
                Instantiate(bulletPrefab,firePoint.position, firePoint.rotation);
            }
            HandleAiming();
        }
        // if player is using upgraded weapon
        if(cuPoints >= pointGoal)
        {
            damage = 20;
        }
    }

    private void HandleAiming()
    {
        //Get the Screen positions of the object
        Vector2 positionOnScreen = Camera.main.WorldToViewportPoint(transform.position);

        //Get the Screen position of the mouse
        Vector2 mouseOnScreen = (Vector2)Camera.main.ScreenToViewportPoint(Input.mousePosition);

        //Get the angle between the points
        float angle = AngleBetweenTwoPoints(positionOnScreen, mouseOnScreen) - 180f;

        //Ta Daaa
        aimTransform.rotation = Quaternion.Euler(new Vector3(0f, 0f, angle));
    }

    float AngleBetweenTwoPoints(Vector3 a, Vector3 b)
    {
        return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
    }
}
