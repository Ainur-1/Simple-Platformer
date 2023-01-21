using UnityEngine;

public class Shooting : MonoBehaviour
{
    public GameObject Projectile;
    Vector3 direction;
    private Rigidbody2D ProjectileRB;

    private void Start()
    {
        ProjectileRB = Projectile.GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        ShootLogic();
        
    }

    private void ShootLogic()
    {
        if (Input.GetAxis("Fire1") > 0)
        {
            direction = Input.mousePosition - direction;
            Instantiate(Projectile, transform);
            ProjectileRB.AddForce(direction);
        }
    }
}
