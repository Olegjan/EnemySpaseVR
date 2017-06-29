using UnityEngine;
using System.Collections;
public class MoveBulletObjectScript : MonoBehaviour {
	
	public Transform PlaceAsteroidButton;
	public float BulletSpeed; 
	public GameObject MainAnimationScriptObject; 

	void Update () {
		if (Vector3.Distance(transform.position, PlaceAsteroidButton.position) < 0.5f) { 
			MainAnimationScriptObject.SetActive (true);
		}			
		else 
			transform.position = Vector3.MoveTowards(transform.position, PlaceAsteroidButton.position, Time.deltaTime * BulletSpeed);
	}
}
