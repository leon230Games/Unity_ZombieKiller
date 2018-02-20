using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSphere : MonoBehaviour {

    public float speed = 5f;

    InputController playerInput;

    public Vector3 movement = Vector3.zero;

    public Transform target;

    // Use this for initialization
    void Start () {
        playerInput = GameManager.instance.inputController;
	}
	
	// Update is called once per frame
	void Update () {
        //transform.Rotate(Vector3.back * Time.deltaTime * speed);
        if (playerInput.Vertical != 0 || playerInput.Horizontal != 0)
        {
            movement.x = playerInput.Horizontal * speed;
            movement.z = playerInput.Vertical * speed;
            movement = Vector3.ClampMagnitude(movement, speed);

            Quaternion tmp = target.rotation;
            target.eulerAngles = new Vector3(0, target.eulerAngles.y, 0);
            movement = target.TransformDirection(movement);
            target.rotation = tmp;

            // face movement direction
            //transform.rotation = Quaternion.LookRotation(movement);
            Quaternion direction = Quaternion.LookRotation(movement);
            transform.rotation = Quaternion.Lerp(transform.rotation,
                direction, speed * Time.deltaTime);
        }



    }
}
