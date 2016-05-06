using UnityEngine;
using System.Collections;

public class PortalScript : MonoBehaviour
{
    private Vector3 targetLocation;
    public Vector3 jumpSize;

	void OnTriggerEnter(Collider col)
	{
		if (col.transform.CompareTag("Player"))
		{
            Debug.Log("Poof!");
            targetLocation = col.transform.position - jumpSize;
			col.transform.position = targetLocation;
		}
	}
}