using UnityEngine;//Этот скрипт через указаное время создаёт затемнение сцены перед переходом в другую сцену, 
using System.Collections;// запускает анимацию слова louding и загружает Следующюю сцену для Выигравшего игрока

public class ActivatorWinerText : MonoBehaviour {
	public float ActivatorTime = 160f; // время через которое начнёт выполняться данный скрипт
	public string sceneName; // иногда здесь можно указать название сцены и мы перейдём к этой сцене
	public GameObject FadeInScene; // Объект который создаёт затемнение в сцене перед переходом в другую сцену
	public GameObject AnimLoad; // Объект который отвечает за анимацию слова Louding

	void Start () {
		StartCoroutine ("TestTimer");//функция запускающяя таймер
	}

	IEnumerator TestTimer(){
		Debug.Log ("Go my test");
		yield return new WaitForSeconds (ActivatorTime);
		FadeInScene.SetActive (true);//Активация объекта который создаёт затемнение в сцене перед переходом в другую сцену
		yield return new WaitForSeconds (2f);
		AnimLoad.SetActive (true);//Активация объекта который отвечает за анимацию слова Louding
		Application.LoadLevel(sceneName); //Переход в указаную сцену
		Debug.Log ("Stop my test");
	}
}
