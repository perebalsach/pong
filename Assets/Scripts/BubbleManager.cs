﻿using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;


public class BubbleManager : MonoBehaviour {

 //   public GameObject []bubbles;
 //   public bool GameOver = true;

 //   [SerializeField]
 //   float SpawnInterval;

 //   [SerializeField]
 //   float SpawnRangeDistance;

	//void Start ()
 //   {
 //       StartSpawnBubbles();
	//}
	
	//void Update ()
 //   {
	//}

 //   void SpawnBubble()
 //   {
 //       int bubbleId = Random.Range(0, bubbles.Length);

 //       float randNum = Random.Range(-SpawnRangeDistance, SpawnRangeDistance);
 //       Vector3 randPos = new Vector3(randNum, transform.position.y, transform.position.z);

 //       Instantiate(bubbles[bubbleId], randPos, Quaternion.identity);
 //   }

 //   IEnumerator SpawnBubbles()
 //   {
 //       yield return new WaitForSeconds(2f);

 //       while (true)
 //       {
 //           SpawnBubble();
 //           yield return new WaitForSeconds(SpawnInterval);
 //       }
 //   }

 //   public void StartSpawnBubbles()
 //   {
 //       StartCoroutine("SpawnBubbles");
 //   }

 //   public void StopSpawnBubbles()
 //   {
 //       StopCoroutine("SpawnBubbles");
 //   }
}
