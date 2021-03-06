﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjetilScript : MonoBehaviour {

	public float velocidade;

	// Use this for initialization
	void Start () {

		//Destroi caso projetil não acerte nada 
		Destroy (gameObject, 3.0f);
	}

	private void OnCollisionEnter2D(Collision2D collision2D) {
		//Destroi projetil por colisão
		Destroy (gameObject);
	}

	private void OnTriggerEnter2D(Collider2D collider2D) {
		if(collider2D.tag == "SubInimigo"){
			Destroy (collider2D.gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
		//Mover projetil
		transform.Translate (Vector2.right * velocidade * Time.deltaTime);
	}
}
