using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

	public Transform target;
	public float smooting;

	Vector3 offset;

	void Start()
	{
		offset = transform.position - target.position;
	}

	void FixedUpdate()
	{
		Vector3 targetCampos = target.position + offset;
		transform.position = Vector3.Lerp (transform.position, targetCampos, smooting * Time.deltaTime);
	}
}
