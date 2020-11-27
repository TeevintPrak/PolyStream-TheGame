using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform playerTF;
    public Vector3 offset;
    public float smoothSpeed = 10f;
	public Menu menu;
	
	void start()
	{
		menu = GetComponent<Menu>();
	}
	
    void FixedUpdate() //Will run after Update
    {
        Vector3 targetPosition = transform.position = playerTF.position + offset; //Gets the desired position of the camera following the player
        Vector3 travelPosition = Vector3.Lerp(transform.position, targetPosition, smoothSpeed * Time.deltaTime); //Set the travel position the camera to the player, but lags behind
        transform.position = travelPosition; //Assign the new position to the current position so it can start moving and laggin behind a bit to make it smooth.
		if (Input.GetKey("f"))
        {
            menu.RestartLevel(); 
        }
	}
}
