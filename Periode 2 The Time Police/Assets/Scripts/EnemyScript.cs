using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour {
    public Transform player;
    public int MoveSpeed = 4;
    public int MaxDist = 10;
    public int MinDist = 5;
    public bool start;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (start)
        {
            transform.LookAt(player);
            if (Vector3.Distance(transform.position, player.position) >= MinDist)
            {

                transform.position += transform.forward * MoveSpeed * Time.deltaTime;



                if (Vector3.Distance(transform.position, player.position) <= MaxDist)
                {
                    //Here Call any function U want Like Shoot at here or something
                }

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
