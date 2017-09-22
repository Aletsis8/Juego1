using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour {

	public float speed=15;                   
	public Text contText;
	private int contador;
	[SerializeField] Transform charmander;
	Vector2 ori;

	// Use this for initialization
	void Start()
	{
		contador = 0;
		contText.text = "Candy: " + contador.ToString ();
	}

	void Update(){
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (Vector2.up * Time.deltaTime * speed); 
		}
	if (Input.GetKey (KeyCode.S)) {
		transform.Translate (Vector2.down * Time.deltaTime * speed);
	}
	if (Input.GetKey (KeyCode.A)) {
		transform.Translate (Vector2.left * Time.deltaTime * speed);
	}
	if (Input.GetKey (KeyCode.D)) {
		transform.Translate (Vector2.right * Time.deltaTime * speed);
	}
		if (contador == 10) {
			print ("You win");
			contText.text = "YOU WIN";
			speed = 0;
			charmander.transform.position = ori;
		}
}

	void OnTriggerEnter2D (Collider2D colectible){

		if (colectible.gameObject.CompareTag ("Player")) {

			colectible.gameObject.SetActive (false);
			contador += 1;
			contText.text = "Candy: " + contador.ToString ();
		

	}


}
}