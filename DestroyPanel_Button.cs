using UnityEngine;
using System.Collections;  
using UnityEngine.UI;

public class DestroyPanel_Button : MonoBehaviour {
	public GameObject PanelOrButton;
	public GameObject Panel;
	public GameObject SphereBullet;
	public GameObject ExplosionSpaceStation;
	public float SpawnTime = 0.01f;
	public float RotateSpeed = 1f;

	public void SelectedShape(GameObject g) {
		PanelOrButton = g;
	}
	
	public void DestroyShape() { 
		if (PanelOrButton != null){
			SphereBullet.SetActive (true);
		}
	}
	void Update () {
		transform.Rotate (0, 0, RotateSpeed); 
		if (Vector3.Distance(transform.position, new Vector3(0, 0, 0)) < 0.2f) {
			StartCoroutine ("TestTimer");
		}
	}
	IEnumerator TestTimer() {
		Debug.Log ("Go my test");
		Panel.SetActive (false);
		ExplosionSpaceStation.SetActive (true);
		yield return new WaitForSeconds (1f);
		Debug.Log ("Stop my test");
	}
}
