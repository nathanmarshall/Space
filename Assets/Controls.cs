using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour {

    private Vector3 playerPrevPosition;
    private Vector3 playerCurrentPosition;
    private Vector3 weaponPrevPosition;
    private Vector3 weaponCurrentPosition;
    private float   angle;

    public Movement playerMovment;
    public Movement weaponMovment;
    public Weapon weapon;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButton(0))
        {
            playerCurrentPosition = Input.mousePosition;
            playerMovment.rotate(playerPrevPosition, playerCurrentPosition);
            playerPrevPosition = playerCurrentPosition;
        }

        if (Input.GetMouseButton(1))
        {
            weaponCurrentPosition = Input.mousePosition;
            weaponMovment.rotate(weaponPrevPosition, weaponCurrentPosition);
            weapon.fire(weaponPrevPosition, weaponCurrentPosition);
            weaponPrevPosition = weaponCurrentPosition;
        }
    }
}
