using UnityEngine;
using System.Collections;

public class PortalScript : MonoBehaviour
{
    private Vector3 targetLocation;
    public Transform door;

	void OnTriggerEnter(Collider col)
	{
		if(col.transform.CompareTag("Player"))
		{
            if (door.transform.position.z > 0)
            {
                targetLocation = new Vector3(door.transform.position.x, door.transform.position.y, door.transform.position.z - 1);
                Debug.Log("Poof");
                col.transform.position = targetLocation;
            }

            else
            {
                targetLocation = new Vector3(door.transform.position.x, door.transform.position.y, door.transform.position.z + 1);
                Debug.Log("Poof");
                col.transform.position = targetLocation;
            }
		}
	}
}