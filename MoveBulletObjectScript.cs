using UnityEngine;
using System.Collections;
//Этот скрипт перемещает Снаряд в место расположения Астероида, и после их столкновения уничтожает Астероид или Button, сам снаряд и Canvas Астероида.
public class MoveBulletObjectScript : MonoBehaviour {
	
	public Transform PlaceAsteroidButton; // Место положения текстуры или кнопки Button в Астероиде
	public float BulletSpeed; //Скорость с которой снаряд двигаеться к Астероиду
	public GameObject MainAnimationScriptObject; // Объект на котором весит Основной скрипт для утановки видимости и позиций объектов

	void Start () {
	}

	void Update () {
		//если между Снарядом и Астероидом будет такое растояние,то оба эти объекта будут уничтожены 
		if (Vector3.Distance(transform.position, PlaceAsteroidButton.position) < 0.5f) { 
			MainAnimationScriptObject.SetActive (true);
		}			
		else 
			transform.position = Vector3.MoveTowards(transform.position, PlaceAsteroidButton.position, Time.deltaTime * BulletSpeed);
	}
}
