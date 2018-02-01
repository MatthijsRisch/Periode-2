using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {
    public Transform player;
    public int moveSpeed = 4;
    public int maxDist = 1;
    public int minDist = 1;
    public bool start;

    // Use this for initialization
    void Start () {
		
	}
	
	void FixedUpdate () {

        if (start)
        {
            transform.LookAt(player);
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
            if (Vector3.Distance(transform.position, player.position) >= minDist)
            {

                



                
            }
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            start = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            start = false;
        }
    }
}
