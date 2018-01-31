using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RickRoll : MonoBehaviour {
    public GameObject soundBox;
    public GameObject fpCharacter;
    public GameObject camera;
    public GameObject arm;
    public GameObject wonText;

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "PlasmaBall")
        {
            Instantiate(soundBox, transform.position, transform.rotation);
            fpCharacter.GetComponent<Character>().enabled = false;
            camera.GetComponent<CameraScript>().enabled = false;
            arm.GetComponent<ArmScript>().enabled = false;
            wonText.SetActive(true);

        }
        
    }
}
