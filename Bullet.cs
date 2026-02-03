using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float BulletSpeed = 1f;
    public GameObject bullet;

    void Start()
    {
        bullet.transform.Translate(0,0.5f,0);
    }

    void Update()
    {
        
        bullet.transform.Translate(Vector3.up * BulletSpeed * Time.deltaTime);
        
    }
}
