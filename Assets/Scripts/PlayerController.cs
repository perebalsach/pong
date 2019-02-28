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
    void splitBubbles()
    {
        GameObject splitBubble1 = Instantiate(bubble, transform.position, transform.rotation);
        //splitBubble1.AddComponent<Rigidbody2D>();
        Rigidbody2D rb = splitBubble1.GetComponent<Rigidbody2D>();
        rb.AddForce(new Vector2(0, 10f));
        splitBubble = false;
    }

    void Move()
    {
        float xPos = Input.GetAxis("Horizontal");
        transform.position += Vector3.right * xPos * moveSpeed * Time.deltaTime;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        splitBubble = true;
    }
}
