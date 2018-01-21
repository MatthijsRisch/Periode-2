using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmScript : MonoBehaviour
{
    public Transform barrel;
    public GameObject plasmaBall;
    public GameObject plasmaBallClone;
    public float speedBullet;

	// Use this for initialization
	void Start ()
    {

	}
	
	// Update is called once per frame
	void Update ()
    {
		if (Input.GetButtonDown("Fire1"))
        {
            plasmaBallClone = Instantiate(plasmaBall, barrel.transform.position, barrel.rotation);
            plasmaBallClone.GetComponent<Rigidbody>().velocity = barrel.transform.forward * speedBullet;
            Destroy(plasmaBallClone, 3);
        }
	}
}
