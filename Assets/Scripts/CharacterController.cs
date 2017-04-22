using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {
    public float Speed;
    public float Jump;
    bool jumping;
    float move;
    Rigidbody2D body;
    public Transform RayOriginRight;
    public Transform RayOriginLeft;
    public float RayLength;
    public float RotationSpeed;
    public float Gravity;
    // Use this for initialization
    void Start () {
        body = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        move = Input.GetAxis("Horizontal");
        if (!Physics2D.Raycast(RayOriginLeft.position, Vector2.down, RayLength))
        {
            if (!jumping)
            {
                body.MoveRotation(body.rotation + RotationSpeed);
            }
            body.AddForce(Gravity * -transform.up);
        }
        if (!Physics2D.Raycast(RayOriginRight.position, Vector2.down, RayLength))
        {
            if (!jumping)
            {
                body.MoveRotation(body.rotation - RotationSpeed);
            }
            
            body.AddForce(Gravity * -transform.up);
        }

        if(Physics2D.Raycast(RayOriginLeft.position, Vector2.down, RayLength) && Physics2D.Raycast(RayOriginRight.position, Vector2.down, RayLength))
        {
            body.velocity = new Vector2(0,0);
            jumping = false;
        }

        if (Input.GetButtonDown("Jump"))
        {
            if (!jumping)
            {
                body.AddForce(transform.up * Jump);
                jumping = true;
            }

        }

        if (move != 0 && !jumping)
        {
            body.velocity = Speed * move * transform.right;
        }
    }

    void Orthogonalize()
    {

    }
}
