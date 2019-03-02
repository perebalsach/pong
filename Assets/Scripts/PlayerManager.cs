using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

    //public GameObject bubble;
    //bool canMove = true;

    //[SerializeField]
    //float moveSpeed;

    //private bool splitBubble = false;
    
	void Start ()
    {
	}
	
	// Update is called once per frame
	void Update ()
    {
        //if(canMove)
        //{
        //    Move();
        //}

        //if(Input.GetKeyUp(KeyCode.Space))
        //{
        //    BulletController bullet = GetComponent<BulletController>();
        //    bullet.Shoot();

        //}       
	}

    //private void SpawnSplitBubble()
    //{
    //    var playerPos = transform.position;
    //    GameObject splitBubble1 = Instantiate(bubble, playerPos, Quaternion.identity) as GameObject;

    //    Rigidbody2D rb = splitBubble1.GetComponent<Rigidbody2D>();
    //    splitBubble1.name = "splittedBubble";

    //    rb.AddForce(new Vector2(0, 5000f));
    //}

    //private void OnCollisionEnter2D(Collision2D other)
    //{
    //    StartCoroutine(Split());
    //}

    //void Move()
    //{
    //    float xPos = Input.GetAxis("Horizontal");
    //    transform.position += Vector3.right * xPos * moveSpeed * Time.deltaTime;
    //}

    //IEnumerator Split()
    //{
    //    yield return new WaitForSeconds(2.0f);

    //    while (true)
    //    {
    //        SpawnSplitBubble();
    //    }
    //}
    public void Move(float speed)
    {
        float xPos = Input.GetAxis("Horizontal");
        transform.position += Vector3.right * xPos * speed * Time.deltaTime;
    }
}
