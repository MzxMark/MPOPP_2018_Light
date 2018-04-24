using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RecordBurger : MonoBehaviour
{
	
	static RecordBurger _instance;
	static RecordBurger Instance1
	{
		get
		{
			if (_instance)
				return _instance;
			
			_instance = FindObjectOfType<RecordBurger> ();
			if (_instance)
				return _instance;
			
			_instance = new GameObject ("RecordBurger").AddComponent<RecordBurger>();
			return _instance;
		}
	}


	float time = 15;

	[SerializeField]
	Text text;

	public static Vector3 PreviousPosition { get; set;}

	public static float Time
	{
		get { return Instance1.time;}
		set { Instance1.time = value; 
			print (Instance1.time);}
	}

	// Use this for initialization
	void Awake () {
		DontDestroyOnLoad (this.gameObject);
		StartCoroutine (Timer1 (Instance1.time));
	}

	public IEnumerator Timer1(float time){
		while(Instance1.time>0){
			yield return new WaitForSeconds (1);
			print(Instance1.time);
			Instance1.time--;

		}
	}

}