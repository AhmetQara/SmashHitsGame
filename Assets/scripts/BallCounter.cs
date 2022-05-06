using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BallCounter : MonoBehaviour {

	public static int ballCount=99;
	public Text ballCounterText;
	// Use this for initialization
	void Start () {

		GameObject spawn = GameObject.Find("ball");
		BallCounter spawnScript = spawn.GetComponent<BallCounter>();
		spawnScript.enabled = false;
		
	}

	void DestroyBall() {
		GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("spawn");
		foreach (GameObject spawn in gameObjects) {
			GameObject.Destroy(spawn);
		}
	}
	
	// Update is called once per frame
	void Update () {
		ballCounterText.text = ballCount.ToString ();
		if (Input.GetMouseButtonUp (0) && ballCount>0 && ballCount!=0) {
			ballCount -= 1;
		} else {
			//Invoke("DestroyBall", 1.5f);

			}
		}
	}
