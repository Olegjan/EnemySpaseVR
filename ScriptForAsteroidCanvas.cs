using UnityEngine;
using System.Collections;

public class ScriptForAsteroidCanvas : MonoBehaviour {
	public float AsteroidSpeed1 = 2f; // скорость приближения Canvas и Астероида к земле


	void Start () {
		Destroy (gameObject, 150f);
	}

	void Update () {
		if (Vector3.Distance(transform.position, new Vector3(0, 0, 0)) < 0.19f)//Условие которое сработает когда до объекта в public GameObject Bullet будет меньше чем 0.03f
		{
		//	Destroy (gameObject);
		}

		else // с помощью этого условия данный объект или Астероид движиться к Земле или EarthEndPoint с определённой скоростью, которая указана в AsteroidSpeed
			transform.position = Vector3.MoveTowards(transform.position, new Vector3(0, 0, 0), Time.deltaTime * AsteroidSpeed1); 	
	}

}
