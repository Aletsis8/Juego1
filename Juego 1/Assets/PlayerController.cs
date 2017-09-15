using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PlayerController : MonoBehaviour {

	public float speed;             

	private Rigidbody2D rb2d;       
	public Text contText;
	private int contador;

	// Use this for initialization
	void Start()
	{
		rb2d = GetComponent<Rigidbody2D> ();
		contador = 0;
		contText.text = "Candy: " + contador.ToString ();
	}

	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");

		float moveVertical = Input.GetAxis ("Vertical");

		Vector2 movement = new Vector2 (moveHorizontal, moveVertical);

		rb2d.AddForce (movement * speed);
	}

	void OnTriggerEnter2D (Collider2D colectible){

		if (colectible.gameObject.CompareTag ("Player")) {

			colectible.gameObject.SetActive (false);
			contador += 1;
			contText.text = "Candy: " + contador.ToString ();


		
		}
	}

}