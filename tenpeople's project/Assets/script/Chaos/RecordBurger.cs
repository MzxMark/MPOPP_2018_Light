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

	[SerializeField]
	float record;
	float record1;
	float record2;
	float record3;
	float record4;
	float record5;
	float record6;
	float record7;
	float record8;
	float time = 120;
	float second=0;

	[SerializeField]
	Text text;

	public static Vector3 PreviousPosition { get; set;}

	public static float Time
	{
		get { return Instance1.time;}
		set { Instance1.time = value; 
			print (Instance1.time);}
	}
	public static float Second
	{
		get { return Instance1.second;}
		set { Instance1.second = value; 
			print (Instance1.second);}
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
			if (RecordBurger.Time == 0) {
				Application.LoadLevel (1);
			}
		}
	}

	public static float Record
	{
		get { return Instance1.record; }
		set { Instance1.record = value; 
			print (Instance1.record);}
	}
	public static float Record1
	{
		get { return Instance1.record1; }
		set { Instance1.record1 = value; 
			print (Instance1.record1);}
	}
	public static float Record2
	{
		get { return Instance1.record2; }
		set { Instance1.record2 = value; 
			print (Instance1.record2);}
	}
	public static float Record3
	{
		get { return Instance1.record3; }
		set { Instance1.record3 = value; 
			print (Instance1.record3);}
	}
	public static float Record4
	{
		get { return Instance1.record4; }
		set { Instance1.record4 = value; 
			print (Instance1.record4);}
	}
	public static float Record5
	{
		get { return Instance1.record5; }
		set { Instance1.record5 = value; 
			print (Instance1.record5);}
	}
	public static float Record6
	{
		get { return Instance1.record6; }
		set { Instance1.record6 = value; 
			print (Instance1.record6);}
	}
	public static float Record7
	{
		get { return Instance1.record7; }
		set { Instance1.record7 = value; 
			print (Instance1.record7);}
	}
	public static float Record8
	{
		get { return Instance1.record8; }
		set { Instance1.record8 = value; 
			print (Instance1.record8);}
	}

}
