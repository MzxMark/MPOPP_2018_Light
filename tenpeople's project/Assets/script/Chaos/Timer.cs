using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Timer : MonoBehaviour {
	[SerializeField]
	Text text;
	// Use this for initialization

	// Update is called once per frame
	void Update () {
		text.text = RecordBurger.Time.ToString ("f0");
	}
}
