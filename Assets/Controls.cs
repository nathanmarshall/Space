using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour {

    public Chase chase;

    private Vector3 prevPosition;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Vector3 detlaPosition = new Vector3(0, 0, 0);

        if (
            Input.touchCount > 0 &&
            Input.GetTouch(0).phase == TouchPhase.Moved
        )
        {
            Vector3 position = Camera.main.ScreenToWorldPoint(
                Input.GetTouch(0).position
            );
            detlaPosition = position - prevPosition;
            prevPosition = position;
        }

        chase.move(detlaPosition);
    }
}
