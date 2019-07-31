using UnityEngine;
using System.Collections;

public class FollowCam : MonoBehaviour {

	public Transform player;
	Vector3 offset;
	public float damping = 1;

	// Use this for initialization
	void Start () {
		offset = player.position - transform.position;	
	}

	// Update is called once per frame
	void Update () {
		float currentAngle = transform.eulerAngles.y;
		float desiredAngle = player.eulerAngles.y;
		float angle = Mathf.LerpAngle (currentAngle, desiredAngle, damping);

		Quaternion turnRotation = Quaternion.Euler (0f, angle, 0f);
		transform.position = player.position - (turnRotation * offset);
			
		transform.LookAt (player);
	}
}
