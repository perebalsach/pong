using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour 
{

	public GameObject Bullet;

	[SerializeField]
	float SpawnInterval;

	// Use this for initialization
	void Start () 
	{
        StartShoot();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyUp(KeyCode.Space))
		{
			Shoot2();
		}
	}

	void Shoot2()
	{
		GameObject bulletInstance = Instantiate(Bullet, transform.position, Quaternion.identity);
		bulletInstance.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 1000f));
	}


	public void StartShoot()
	{
		StartCoroutine("Shoot");
	}

	public void StopShoot()
	{
		StopCoroutine("Shoot");
	}

	IEnumerator Shoot()
    {
        yield return new WaitForSeconds(2f);

        while (true)
        {
            Shoot2();
            yield return new WaitForSeconds(SpawnInterval);
        }
    }
}
