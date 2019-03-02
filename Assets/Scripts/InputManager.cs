using UnityEngine;
using System.Collections;

public class InputManager : MonoBehaviour
{
    public GameObject player;
    public GameObject Bullet;
    public float playerMoveSpeed;
    public float bulletMoveSpeed;

    private bool canMove = false;

    BulletManager bulletManager;
    BubbleManager bubbleManager;
    PlayerManager playerManager;

    
    void Start()
    {
        bulletManager = GetComponent<BulletManager>();
        bubbleManager = GetComponent<BubbleManager>();
        playerManager = GetComponent<PlayerManager>();

        canMove = true;
    }

    void Update()
    {
        
        if(Input.GetKeyUp(KeyCode.Space))
        {
            Transform playerPos = GetComponent<PlayerManager>().transform;
            bulletManager.SpawnBullet(playerPos);
            bulletManager.Move(playerPos.localPosition.x, bulletMoveSpeed);
        }

        if (canMove)
        {
            playerManager.Move(playerMoveSpeed);
        }
    }
}
