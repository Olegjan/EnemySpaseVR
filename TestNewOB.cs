using UnityEngine;//Это ключевой скрипт текущей игры
using System.Collections;

public class TestNewOB : MonoBehaviour {
	public GameObject AsteroidCanvas; // Объект 
	public GameObject AnimationExplosion; // Объект на котором висит анимация взрыва
	public GameObject MainAnimationScriptObject; // Объект на котором весит Основной скрипт для утановки видимости и позиций объектов
	public GameObject PanelButton; // Объект на котором висит текстура Астероида
	public GameObject SphereBullet; // Объет Снаряда
	public GameObject NextCreateAsteroid; //следующий астероид который будет активирован после деактивации текощего создателя астероидов
	public GameObject NextAsteroidCreateForCopyNew;
	public GameObject LifeTimer;
	public Transform PlaceAsteroidCanvas; // Место расположение Канваса Астероида
	public Transform PlaceCreateAsteroid; // Место создания первого Астероида
	public Transform PlaceCamera; // Место расположения камеры 
	public Transform PlaceSphereBullet; // Место расположения Снаряда

	void OnEnable(){
		StartCoroutine ("TestTimer");
	}
	IEnumerator TestTimer() {
		Debug.Log ("Go my test");
		SphereBullet.SetActive (false); // с помощью этой строки деактивируеться объект Снаряда
		PanelButton.SetActive (false); // с помощью этой строки деактивируеться объект Panel или Панель астероида
		AnimationExplosion.SetActive (true); // с помощью этой строки активируеться объект взрыва астероида
		yield return new WaitForSeconds (0.1f);
		PlaceSphereBullet.position = PlaceCamera.position; //с помощью этой строки Снаряд перемещаеться в месторасположения камеры
		yield return new WaitForSeconds (2f);
		AsteroidCanvas.SetActive (false); // с помощью этой строки Астероид становиться невидимым
		yield return new WaitForSeconds (0.1f);
		PlaceAsteroidCanvas.position = PlaceCreateAsteroid.position; // с помощью этой строки астероид перемещаеться в место создания Астероидов
		if (LifeTimer !=null){
		MainAnimationScriptObject.SetActive (false); // с помощью этой строки деактивируеться объект скрипта и сам этот скрипт
		}
		yield return new WaitForSeconds (0.2f);
		Debug.Log ("Stop my test");
	}
	void OnDisable(){
		AnimationExplosion.SetActive (false); // с помощью этой строки активируеться объект взрыва астероида
		PanelButton.SetActive (true); // с помощью этой строки активируеться объект Panel или Панель астероида
		NextCreateAsteroid.SetActive (true);
		NextAsteroidCreateForCopyNew.SetActive (true);
	}
}
