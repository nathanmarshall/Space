using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chase : MonoBehaviour {

    public Transform Player;

    private float clamp = 0.75f;
    private Vector3 prevPosition;

	// Use this for initialization
	void Start () {
     
	}
	
	// Update is called once per frame
	void Update () {

    }

    public void move(Vector3 delta)
    {
        Vector3 transformDelta = prevPosition - Player.position; 
        Vector3 position = transform.position + transformDelta + delta;
        Vector3 offset = position - Player.position;
        transform.position = Player.position + Vector3.ClampMagnitude(offset, clamp);
        prevPosition = Player.position;
    }
}
