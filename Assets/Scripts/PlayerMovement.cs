using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    private float moveVertical;
    private float moveHorizontal;
    private Vector3 movement;
    public float speed = 1;

    private void Start()
    {
        
        
    }
    // Update is called once per frame
    void FixedUpdate ()
    {
        moveVertical = Input.GetAxis("Vertical");
        moveHorizontal = Input.GetAxis("Horizontal");
        movement = new Vector3(moveHorizontal, 0f, moveVertical);
        rb.AddForce(movement * Time.deltaTime * speed) ;
	}
}
