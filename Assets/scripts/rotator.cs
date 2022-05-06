using UnityEngine;
using System.Collections;

public class rotator : MonoBehaviour {

	public Rigidbody target;
	public float rotationSpeed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		target.transform.Rotate(Vector3.up * (Time.deltaTime*rotationSpeed));
		//transform.Rotate(Vector3.up * Time.deltaTime, Space.World);	
	}
}
