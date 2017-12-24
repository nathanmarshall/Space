using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour {

    public GameObject projectile;
    public Transform turretTransform;
    public float rateOfFire;

    private float lastShot;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = new Vector2(
            turretTransform.position.x,
            turretTransform.position.y
        );
    }

    public void fire()
    {
        if (Time.time > lastShot + rateOfFire)
        {
            GameObject clone;
            clone = Instantiate(projectile, transform.position, transform.rotation);
            clone.GetComponent<Rigidbody2D>().velocity = transform.right * 30;
            lastShot = Time.time;
        }
    }
}
