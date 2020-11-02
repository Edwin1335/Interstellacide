using UnityEngine;

public class Weapon2 : MonoBehaviour
{
    private Transform aimTransform;
    public Transform firePoint; //point of fire from gun
    public int damage = 10; //damage enemy takes 
    public GameObject bulletPrefab;
    public float fireRate = 0.5f;
    private float nextFire = 0.0f;


    private void Awake()
    {
        if(!PauseMenu.GamePause){
            aimTransform = transform.Find("Aim");
        }

    }

    // Update is called once per frame
    void Update()
    {
<<<<<<< HEAD
        if(Input.GetKey(KeyCode.Mouse0)){
            if(!PauseMenu.GamePause){
                Instantiate(bulletPrefab,firePoint.position, firePoint.rotation);
            }
            // Shoot();

            HandleAiming();
=======
        if (Input.GetKey(KeyCode.Mouse0) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
>>>>>>> 01d59506d55314083b9ecb7d3b354fe3b76a7133
        }
        // if(Input.GetKey(KeyCode.Mouse0)){
        //     HandleAiming();
        // }
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
