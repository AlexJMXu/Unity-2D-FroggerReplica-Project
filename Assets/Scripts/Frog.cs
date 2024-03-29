﻿using UnityEngine;
using UnityEngine.SceneManagement;

public class Frog : MonoBehaviour {

	public Rigidbody2D rb;

	void Update() {
		if (Input.GetKeyDown(KeyCode.RightArrow)) {
			rb.MovePosition(rb.position + Vector2.right);
		} else if (Input.GetKeyDown(KeyCode.LeftArrow)) {
			rb.MovePosition(rb.position + Vector2.left);
		} else if (Input.GetKeyDown(KeyCode.UpArrow)) {
			rb.MovePosition(rb.position + Vector2.up);
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			rb.MovePosition(rb.position + Vector2.down);
		}

		transform.position = new Vector3(Mathf.Clamp(rb.position.x, -4f, 4f), 
										 Mathf.Clamp(rb.position.y, -4f, 4f), 
										 transform.position.z);
	}

	void OnTriggerEnter2D (Collider2D col) {
		if (col.tag == "Car") {
			Debug.Log("SPLAT!");
			Score.CurrentScore = 0;
			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
		}
	}
}
