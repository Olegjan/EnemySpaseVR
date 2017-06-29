using UnityEngine;
using System.Collections;

public class MainMenuRusAllPhone : MonoBehaviour {

	public int window;

	private float screenW;
	public float posx;
	private float screenH;
	public float posy;

	public float widt;
	public float height;

	public GUIStyle Skin;//Стиль для первой кнопки
	public GUIStyle SkinWindow2;//стиль для заголовков в окнах Меню 
	public GUIStyle SkinForTwoButton;//Стиль для второй кнопки
	public GUIStyle SkinForTreeButton;//Стиль для описания для Автора
	public GameObject Loading;

	void Update () {
		screenW = Screen.width;
		screenH = Screen.height;
	}

	void OnGUI () { 
		GUI.BeginGroup (new Rect (Screen.width / 2 - 380, Screen.height / 2 - 380, 720, 720)); //Создание Установка положения и установка размера Блока Меню
		if (window == 1) { //первое окно меню
			//создаёться прямоугольная кнопка с отсупом от левого края блока меню 0px, от верхнего края 30px, с шириной 720px и высотой 120px, на который влияет стиль Sken
			if(GUI.Button (new Rect (0, 100,720,120), "Начать игру", Skin)) { 
				window = 2;  // При нажатии на эту кнопку мы перейдём в это окно Меню 
			} 
			//создаёться прямоугольная кнопка с отсупом от левого края блока меню 0px, от верхнего края 160px, с шириной 720px и высотой 120px, на который влияет стиль SkenForTwoButton
			if(GUI.Button (new Rect (0, 230,720,120), "Автор игры", SkinForTwoButton)) { 
				window = 3; // При нажатии на эту кнопку мы перейдём в это окно Меню 
			} 
			//перемешка разных стилей делает так чтобы не выделялись все кнопки при нажатии на самую нижнюю 
			//создаёться прямоугольная кнопка с отсупом от левого края блока меню 10px, от верхнего края 290px, с шириной 720px и высотой 120px, на который влияет стиль SkenForTwoButton
			if(GUI.Button (new Rect (0, 360,720,120), "Выход", Skin)) { 
				window = 4; // При нажатии на эту кнопку мы перейдём в это окно Меню 
			} 
		} 

		if(window == 2) { //второе окно меню
			Loading.SetActiveRecursively (true);
			Debug.Log("Загрузка"); 
			Application.LoadLevel(3); // При нажатии на эту кнопку мы перейдём в эту сцену
		}

		if(window == 3) { //Третье окно меню
			GUI.Label(new Rect(0,10,0,0), "Автор игры", SkinWindow2);   
			GUI.Label(new Rect(0,100,0, 0), "Голота Олег Владимирович\r\n" +//для переноса строк на новую строку
				" Компания Online Univer \r\n" +
				" Контакты: oleg-golota@yandex.ru", SkinForTreeButton); 
			if(GUI.Button (new Rect (0, 250, 720,120), "Назад", SkinForTwoButton)) {
				Debug.Log("Назад");
				window = 1;
			}   
		} 

		if(window == 4) { 
			GUI.Label(new Rect(0, 10, 0, 0), "Выйти из игры?", SkinWindow2);   
			if(GUI.Button (new Rect (0,100,720,120), "Да", Skin)) { 
				Application.Quit(); 
			} 
			if(GUI.Button (new Rect (0,230,720,120), "Нет", SkinForTwoButton)) { 
				Debug.Log("Назад");
				window = 1;
			} 
		} 

		GUI.EndGroup (); //это необходимо чтобы не выдавалась ошибка
	} 
}
