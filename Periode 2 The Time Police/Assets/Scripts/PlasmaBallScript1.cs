using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlasmaBallScript1 : MonoBehaviour {
    public float xSpeed = 0;
    public float ySpeed = 0;
    public float zSpeed = 0;
    public GameObject explosion;
    public GameObject explosionClone;

    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update () {
        transform.Rotate
            (
            xSpeed * Time.deltaTime,
            ySpeed * Time.deltaTime,
            zSpeed * Time.deltaTime
            );
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Destroyable")
        {
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == ("Enemy"))
        {
            Destroy(collision.gameObject);
        }
        Destroy(gameObject);
        explosionClone = Instantiate(explosion, transform.position, transform.rotation);
        Destroy(explosionClone, 2);
    }
}
