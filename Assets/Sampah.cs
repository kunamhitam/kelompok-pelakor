using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sampah : MonoBehaviour {
	public float delay = 0.1f;
	public GameObject sampah;

	// Use this for initialization
	void Start () {
		InvokeRepeating("Spawn",delay,delay);
	}
	
	// Update is called once per frame
	void Spawn () {
		Instantiate(sampah,new Vector3(Random.Range(-20,20),10,0),Quaternion.identity);
	}

}
