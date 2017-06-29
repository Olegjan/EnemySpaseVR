using UnityEngine;// Скрипт с помощью которого происходит переход в указанную сцену
using System.Collections;
using UnityEngine.UI;

public class MyChangeScene : MonoBehaviour {
	public string sceneName; // иногда здесь можно указать название сцены и мы перейдём к этой сцене

	public void ChangeScene(string sceneName) {
		Application.LoadLevel(sceneName);//сцена куда мы будем перенаправлены
	}
}
