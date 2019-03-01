using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public GameObject bubble;
    bool canMove = true;

    [SerializeField]
    float moveSpeed;

    private bool splitBubble = false;
    
	void Start ()
    {
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        if(canMove)
        {
            Move();
        }
	}
	
//    private void OnTriggerEnter2D(Collider2D col)
//    {
//        splitBubble = true;
//        Destroy(col.gameObject);
//        SpawnSplitBubble();
//    }


    private void SpawnSplitBubble()
    {
        var playerPos = transform.position;
        GameObject splitBubble1 = Instantiate(bubble, playerPos, Quaternion.identity) as GameObject;
        splitBubble1.name = "splittedBubble";
        Rigidbody2D rb = splitBubble1.GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(0, 5000f));
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        StartCoroutine(Split());
    }

    void Move()
    {
        float xPos = Input.GetAxis("Horizontal");
        transform.position += Vector3.right * xPos * moveSpeed * Time.deltaTime;
    }

    IEnumerator Split()
    {
        yield return new WaitForSeconds(2.0f);

        while (true)
        {
            SpawnSplitBubble();
        }
    }
}
