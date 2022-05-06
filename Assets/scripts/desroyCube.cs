using UnityEngine;
using System.Collections;

 

public class desroyCube : MonoBehaviour {
	
	void OnCollisionEnter (Collision col) {
		if (col.gameObject.tag == "target") {
			Destroy (col.gameObject);
			BallCounter.ballCount +=2;
		}
		}
}
