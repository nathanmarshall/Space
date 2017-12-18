using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public float thrust;
    public float rotationSpeed;

    private Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        thrust = 6F;
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        rb.velocity = transform.right * thrust;             
    }

    public void rotate(Vector3 prevPosition, Vector3 currentPosition) {

        currentPosition = Input.mousePosition;

        Vector3 direction = currentPosition - prevPosition;
        float distance = Vector2.Distance(currentPosition, prevPosition);
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        Quaternion rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        if (distance > 0)
        {
            transform.rotation = Quaternion.Slerp(
                transform.rotation, 
                rotation, 
                rotationSpeed * Time.deltaTime
            );
        }
    }
}
