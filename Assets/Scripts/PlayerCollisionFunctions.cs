using UnityEngine;
using System.Collections;

public class PlayerCollisionFunctions : MonoBehaviour
{
	public GameObject door;
	public GameObject doorHinge;
	private Animator animator;

	void Start()
	{
		animator = doorHinge.GetComponent<Animator>();
	}

	public void OnTriggerEnter(Collider col)
	{
		if (col.tag == "DoorTrigger")
        {
			door.SetActive (true);
			animator.SetBool("isOpened", true);
        }

        else
        {
			animator.SetBool("isOpened", false);
		}
	}
}
