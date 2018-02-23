using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {
	private float score;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.D)) {
			GoRight();
		}
		if (Input.GetKey (KeyCode.A)) {
			GoLeft();
		}

	}
	private void GoRight() {
		transform.Translate (Vector3.right * 5f * Time.deltaTime);
	}
	private void GoLeft() {
		transform.Translate (Vector3.left * 5f * Time.deltaTime);
	}



	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name == "Sphere(Clone)")
		{
			score++;
			Destroy(col.gameObject);
			Debug.Log(score);
		}
	}

}
