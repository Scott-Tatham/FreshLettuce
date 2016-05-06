using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rigid;
    private float moveSpeed; 
	private float jumpHeight;
	private bool isGrounded; 

	void Start()
	{
		Rigidbody rigid = GetComponent<Rigidbody>();
        moveSpeed = 10.0f;
        jumpHeight = 5.0f;
        isGrounded = true;
	}

	void Update () 
	{
		playerInput (); 
	}

	void OnCollisionEnter(Collision collidedObject)
	{
		if (collidedObject.gameObject.name == "Ground")
        {
			isGrounded = true; 
		}
	}

	private void playerInput()
	{
		{
			if  (Input.GetKey(KeyCode.W) && isGrounded == true)
            {
				rigid.AddForce(rigid.transform.forward * moveSpeed, ForceMode.Acceleration);
			}

			if  (Input.GetKey(KeyCode.S) && isGrounded == true)
            {
				rigid.AddForce(rigid.transform.forward * -moveSpeed, ForceMode.Acceleration);
			}

			if (Input.GetKey (KeyCode.D) && isGrounded == true)
            {
				rigid.AddForce(rigid.transform.right * moveSpeed, ForceMode.Acceleration);
			}

            if (Input.GetKey(KeyCode.A) && isGrounded == true)
            {
                rigid.AddForce(rigid.transform.right * -moveSpeed, ForceMode.Acceleration);
            }

            if (Input.GetKeyDown (KeyCode.Space) && isGrounded == true)
            {
				rigid.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
				isGrounded = false; 
			}
		}
	}
}