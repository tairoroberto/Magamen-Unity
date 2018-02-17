using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoScript : MonoBehaviour {

	public int vidas;
	public GameObject peixePrefab;
	public Transform gerarPeixes;
	public float intervalo;

	// Use this for initialization
	IEnumerator Start () {

		//Gera os peixes que sairam da boca do inimigo
		Instantiate (peixePrefab, gerarPeixes.transform.position, gerarPeixes.transform.rotation);
		yield return  new WaitForSeconds (intervalo);
		StartCoroutine (Start());
	}

	private void OnCollisionEnter2D(Collision2D collision2D) {
		if(collision2D.gameObject.tag == "Projetil"){
			vidas--;

			//Deleta o inimigo quando encerrar as vidas
			if(vidas <= 0){
				Destroy (gameObject);
			}
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
