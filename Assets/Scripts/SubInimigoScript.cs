using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubInimigoScript : MonoBehaviour {

	public GameObject alvo;
	public float velocidade;
	SpriteRenderer spriteRenderer;


	// Use this for initialization
	void Start () {
		//Atribui o alvo a ser perseguido
		alvo = GameObject.FindGameObjectWithTag("Player");
		spriteRenderer = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		//Persegue o alvo
		transform.position = Vector2.Lerp(transform.position, alvo.transform.position, velocidade * Time.deltaTime);

		if(alvo.transform.position.x > transform.position.x) {
			spriteRenderer.flipX = true;
		}else if(alvo.transform.position.x < transform.position.x) {
			spriteRenderer.flipX = false;
		}
	}
}
