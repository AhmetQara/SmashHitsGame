using UnityEngine;
using System.Collections;

public class destroyer : MonoBehaviour {

	// destroy ball after 10 seconds
	void Update () {
		GameObject[] gameObjects = GameObject.FindGameObjectsWithTag("ball");
		foreach (GameObject target in gameObjects) {
			GameObject.Destroy(target,10);

	// destroy cubes after 10 seconds
		GameObject[] gameObjectsCube = GameObject.FindGameObjectsWithTag("cube");
			foreach (GameObject cube in gameObjectsCube) {
				GameObject.Destroy(cube,10);
		}
	}
}
}