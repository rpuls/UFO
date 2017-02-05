using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour {

    public float speed;             //Floating point variable to store the player's movement speed.
    private Rigidbody2D rb2d;       //Store a reference to the Rigidbody2D component required to use 2D Physics.
	private int pickupCount;
	public Text scoreText;
	public Text winText;
	
	
    // Use this for initialization
    void Start() {
        rb2d = GetComponent<Rigidbody2D> ();
		pickupCount = 0;
		winText.text = "";
		SetCountText();
    }

    void FixedUpdate() {
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");
        Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
        rb2d.AddForce (movement * speed);
    }
	
	void OnTriggerEnter2D(Collider2D other)  {
        if (other.gameObject.CompareTag("PickUp")){
			other.gameObject.SetActive(false);
			pickupCount = pickupCount + 1;
			SetCountText();
		}
    }
	
	void SetCountText(){
        scoreText.text = "Score: " + pickupCount.ToString();
        if (pickupCount >= 11)
            winText.text = "Hunger & Thirst Eliminated";
    }
}

