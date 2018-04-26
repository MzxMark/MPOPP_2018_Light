using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControl : MonoBehaviour {


	// Use this for initialization

	float time;

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (time<= 5 )
		{
			time = time + 1;
			gameObject.transform.localScale = new Vector3(1.0f, 2.0f * time, 0.0f);
		}
	}
	public void StopGrew(){
		time = 7;
	}
}
