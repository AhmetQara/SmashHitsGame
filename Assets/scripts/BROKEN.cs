
using UnityEngine;
using System.Collections;

public class broke : MonoBehaviour
{
	public Transform brokenObject;
	public float magnitudeCol, radius, power, upwards;
	
	private void OnCollisionEnter(Collision collision)
	{
		if (collision.relativeVelocity.magnitude > magnitudeCol)
		{
			Destroy(gameObject);
			Instantiate(brokenObject, transform.position, Quaternion.Euler(new Vector3(0, 90, 0)));

			brokenObject.localScale = transform.localScale;
			Vector3 explosionPos = transform.position;
			Collider[] colliders = Physics.OverlapSphere (explosionPos, radius);
			
			foreach (Collider hit in colliders)
			{
				if (hit.GetComponent<Rigidbody>())
				{
					hit.GetComponent<Rigidbody>().AddExplosionForce(power*collision.relativeVelocity.magnitude, explosionPos, radius, upwards);
				}
			}
		}
	}
}