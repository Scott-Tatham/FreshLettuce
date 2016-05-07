using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
	public GameObject cam;
    public Rigidbody rigid;

    private float moveSpeed;
	private float jumpHeight;
    private bool isGrounded;

	private RaycastHit hit;
	private float distance = 1f;
	private Vector3 dir = new Vector3(0, -1, 0);

	void Start()
	{
		Rigidbody rigid = GetComponent<Rigidbody>();

        moveSpeed = 15.0f;
        jumpHeight = 10.0f;
        isGrounded = true;
}

	void Update () 
	{
		playerInput (); 
		GroundCheck ();
	}
		
	void GroundCheck()
	{
		if(Physics.Raycast(transform.position, dir, out hit, distance))
		{
			isGrounded = true;
		}

		else
		{
			isGrounded = false;
		}
	}
		
	private void playerInput()
	{
		{
			if  (Input.GetKey(KeyCode.W))
            {
				rigid.AddForce(cam.transform.forward * moveSpeed, ForceMode.Acceleration);
			}

			if  (Input.GetKey(KeyCode.S))
            {
				rigid.AddForce (cam.transform.forward * -moveSpeed, ForceMode.Acceleration);
			}

			if (Input.GetKey (KeyCode.D))
            {
				rigid.AddForce(cam.transform.right * moveSpeed, ForceMode.Acceleration);
			}

            if (Input.GetKey(KeyCode.A))
            {
                rigid.AddForce(cam.transform.right * -moveSpeed, ForceMode.Acceleration);
            }

            if (Input.GetKeyDown (KeyCode.Space) && isGrounded == true)
            {
				rigid.AddForce(Vector3.up * jumpHeight, ForceMode.Impulse);
				isGrounded = false; 
			}
		}
	}
} 