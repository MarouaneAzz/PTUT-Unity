using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{

    public Rigidbody rb;

    private Vector3 jumping;

    private bool isFalling;

    public float jumpHeight = 5f;


    // Use this for initialization
    void Start()
    {
        jumping = new Vector3(0f, jumpHeight, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isFalling)
        {
            jump();

        }
        isFalling = true;
    }

    private void jump()
    {
        /*rb.AddForce(jumpHeight*Time.deltaTime*jumping,ForceMode.Impulse);*/
        rb.velocity = jumping;
    }
    private void OnCollisionStay()
    {
        isFalling = false;
    }

}