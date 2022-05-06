using UnityEngine;
using System.Collections;

public class LevelManager : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void LevelUp () {
		Application.LoadLevel(1);
			
	}


	void OnTriggerEnter(Collider col) {
		if (col.gameObject.tag == "ball") {
			Debug.Log ("level up");
			Invoke("LevelUp", 1);
		}
	}
}
