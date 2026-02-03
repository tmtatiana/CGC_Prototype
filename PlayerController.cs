using UnityEngine;
using System.Collections;



public class PlayerController : MonoBehaviour
{

    public float MovementSpeed = 2f;
    public float TurnSpeed = 0.5f;
    public GameObject tank;
    public GameObject bullet;
    public float BulletCooldown = 1f;
    private GameObject bulletClone;
    private bool isShooting = false;

    void Update()
    {
       Movement();
       if (Input.GetKey(KeyCode.Space) && !isShooting)
       {
            StartCoroutine(ShootCooldown());
       }
    }

    IEnumerator ShootCooldown()
    {
        isShooting = true;
        Shooting();
        yield return new WaitForSeconds(BulletCooldown);
        isShooting = false;

    }

    void Shooting()
    {
        bulletClone = Instantiate(bullet, transform.position, transform.rotation);
        Destroy(bulletClone,3f);

    }

    void Movement()
    {
     if (Input.GetKey(KeyCode.W))
        {
             transform.Translate(Vector3.up * MovementSpeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.A))
        {
             transform.Rotate(0,0,TurnSpeed);
        }

        if (Input.GetKey(KeyCode.D))
        {
             transform.Rotate(0,0,-TurnSpeed);
        }
    }
}
