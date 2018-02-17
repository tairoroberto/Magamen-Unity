using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityStandardAssets.CrossPlatformInput;

public class ControleTouch : MonoBehaviour {

	public float velocidade;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float mover_x = CrossPlatformInputManager.GetAxisRaw ("Horizontal") * velocidade * Time.deltaTime;
		float mover_y = CrossPlatformInputManager.GetAxisRaw ("Vertical") * velocidade * Time.deltaTime;

		transform.Translate (mover_x, mover_y, 0.0f);
	}
}
