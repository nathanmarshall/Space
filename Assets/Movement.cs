using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float thrust;
    public float rotationSpeed;
    public Transform Chase;

    private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
	}

    // Update is called once per frame
    void Update()
    {
        rb.AddForce(transform.right * thrust);
        // rotate();    
    }

    public void rotate() {

        transform.position = Vector2.MoveTowards(
            new Vector2(transform.position.x, transform.position.y),
            Chase.position, 
            3 * Time.deltaTime
        );

        //Vector3 direction = delta;
        //float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        //Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        //transform.rotation = Quaternion.Slerp(
        //transform.rotation, 
        //rotation, 
        //rotationSpeed * Time.deltaTime
        //);
    }
}
