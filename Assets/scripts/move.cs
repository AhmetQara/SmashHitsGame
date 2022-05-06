using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

	public Rigidbody spawn;
	public float speed;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		spawn.velocity = new Vector3 (0, 0, speed);
	}
}
