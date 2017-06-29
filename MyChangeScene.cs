using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MyChangeScene : MonoBehaviour {
	public string sceneName;

	public void ChangeScene(string sceneName) {
		Application.LoadLevel(sceneName);
	}
}
