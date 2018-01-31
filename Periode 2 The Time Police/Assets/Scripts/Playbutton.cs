using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playbutton : MonoBehaviour {
    public GameObject textObject;
    public GameObject fpCharacter;
    public GameObject camera;
    public GameObject arm;

    void Start()
    {
        fpCharacter.GetComponent<Character>().enabled = false;
        camera.GetComponent<CameraScript>().enabled = false;
        arm.GetComponent<ArmScript>().enabled = false;
    }

    void Update()
    {
        
    }

    public void Changetext()
    {
        fpCharacter.GetComponent<Character>().enabled = true;
        camera.GetComponent<CameraScript>().enabled = true;
        arm.GetComponent<ArmScript>().enabled = true;
        gameObject.SetActive(false);
        textObject.SetActive(false);
    }

}
