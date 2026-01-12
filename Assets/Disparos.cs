using UnityEngine;

public class Disparos : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;

    public float shootDelay = 0.5f;
    private float nextShootTime = 0f;

    void Update()
    {
        if (Input.GetKey(KeyCode.Space) && Time.time >= nextShootTime)
        {
            Shoot();
            nextShootTime = Time.time + shootDelay;
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
}
