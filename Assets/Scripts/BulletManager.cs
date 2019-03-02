using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    public GameObject Bullet;
    public bool Shoot = false;

    private float shootSpeed;
    private GameObject bulletInstance;
    private GameObject player;

    private void Update()
    {
        if(Shoot)
        {
            bulletInstance.transform.position += Vector3.up * Time.deltaTime * shootSpeed;
        }
    }

    public void Move(float startPos, float speed)
    {
        Shoot = true;
        shootSpeed = speed;
    }

    public void SpawnBullet(Transform pos)
    {
        bulletInstance = Instantiate(Bullet);
        bulletInstance.transform.localPosition = pos.transform.localPosition;
    }
}
