using UnityEngine;
using System.Collections;

public class Spawn : MonoBehaviour {

	public GameObject ball;
	public float distance=10f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update() {

		if(Input.GetMouseButtonUp(0)) {
			Vector3 mousePos=new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance);
			mousePos=Camera.main.ScreenToWorldPoint(mousePos);
			GameObject go = Instantiate(ball, transform.position ,Quaternion.identity) as GameObject; 
			go.transform.LookAt(mousePos);
			go.GetComponent<Rigidbody>().AddForce(go.transform.forward*3500);
		
		}
	}
	void OnCollisionEnter(Collider col) {
		if (col.gameObject.tag == "plane") {
		//	Debug.Log("değdi!");
			col.isTrigger=true;
		}
	}

}

