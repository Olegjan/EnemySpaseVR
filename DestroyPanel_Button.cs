using UnityEngine; //Скрипт для маштабирования и вращения Астероида, генерирования Снаряда или Bullet, перенаправления игрока на другую сцену при поражении 
using System.Collections; //и удаления этого объекта Button, при соприкосновении с Снарядом Bullet.  Основной скрипт VR игры. 
using UnityEngine.UI;//Так же этот скрипт запускает анимацию взырва Противоастероидной станци

public class DestroyPanel_Button : MonoBehaviour {
	public GameObject PanelOrButton;//объект на котором кликает VR тригер и который потом удаляеться(в нашем случае это Panel и Button)
	public GameObject Panel; // Объект Panel текущего Астероида
	public GameObject SphereBullet; // Объект снаряда 
	public GameObject ExplosionSpaceStation;// объкект взрыва космической станции
	public float SpawnTime = 0.01f;//время через которое появляеться Снаряд или Bullet
	//public float SizeSpeed = 2f;// за это время при появлении Астероида будет происходить увеличение его размера
	public float RotateSpeed = 1f;// за это время будет происходить вращение Астероида

	//Vector3 _newSize; //переменная с помощью которой мы устанавливаем увеличение размера Астероида

	void Start(){
		//_newSize = new Vector3(transform.localScale.x * 8, transform.localScale.y * 8, transform.localScale.z * 8); //Увеличение размера астероида в 2 раза
	}

	public void SelectedShape(GameObject g) {//код с помощью которого производиться выделение объекта указаного нами в public GameObject PanelOrButton
		PanelOrButton = g;
	}
	//этот блок активирует объект Снаряда который при столкновении с Астероидом девктивирует Астероид и Снаряд, создаёт взрыв, и деактивирует взрыв
	public void DestroyShape() { 
		if (PanelOrButton != null){
			SphereBullet.SetActive (true);
		}
		// с помощью этого условия производиться еденичный вызов объекта на котором находиться анимация взрыва!!!
		//if ((PanelOrButton != null) && !IsInvoking("LaunchProjectile"))
		//	Invoke("LaunchProjectile", 0.1f);
	}
	//здесь установлена загрузка анимации взрыва из префаба, в месте где находиться объект с этим кодом, и с поворотом по оси Z 90 градусов!!!
	void LaunchProjectile() { 
		//GameObject Explosion = Instantiate(Resources.Load("ExplosionQuad"), transform.position, transform.rotation) as GameObject;
	}
	void Update () {
		//transform.localScale = Vector3.MoveTowards(transform.localScale, _newSize, Time.deltaTime * SizeSpeed);//строка реализует увеличение астероида, при его движении
		transform.Rotate (0, 0, RotateSpeed); //Строка реализует вращение Астероида по оси Z
		if (Vector3.Distance(transform.position, new Vector3(0, 0, 0)) < 0.2f) { //код с помощью которого игрок при поражении в игре переходит на другую сцену, например(Game Over)
			StartCoroutine ("TestTimer");
		}
	}
	//с помощью этого блока кода происходит деактивация объекта Panel текущего астероиди и активация взрыва Противоастероидной станци
	IEnumerator TestTimer() {
		Debug.Log ("Go my test");
		Panel.SetActive (false);//деактивация объекта Panel
		ExplosionSpaceStation.SetActive (true);// при столкновении сатероида с космической станцией будет активироваться этот взрыв
		yield return new WaitForSeconds (1f);
		Debug.Log ("Stop my test");
	}
	void OnDisable(){

	}
}
