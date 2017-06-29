using UnityEngine;// Скрипт с помощью которого происходит переход в указанную сцену
using System.Collections;
using UnityEngine.UI;

public class MyChangeScene : MonoBehaviour {
	//public GameObject FadeInScene;// Объект который создаёт затенение сцены
	//public GameObject AnimLoad;// Объект на котором находиться анимация слова Louding
	public string sceneName; // иногда здесь можно указать название сцены и мы перейдём к этой сцене

	public void ChangeScene(string sceneName) {
		//FadeInScene.SetActive (true);//Активация объекта который создаёт затенение сцены
		//AnimLoad.SetActive (true);//Активация объекта на котором находиться анимация слова Louding
		Application.LoadLevel(sceneName);//сцена куда мы будем перенаправлены
	}
}
