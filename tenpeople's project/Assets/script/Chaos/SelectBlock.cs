using UnityEngine;  
using System.Collections;  

public class SelectBlock : MonoBehaviour {  
	private bool roate;  
	private float RoatedSpeed = 1000.0F;  
	void Start () {  
		roate = false;  
	}  

	// Update is called once per frame  
	void Update () {  

		if((Input.GetMouseButton(1))&&(GM.isActive = false) ) 
		{  
			float z = 0;  

			z = Input.GetAxis("Mouse X")*RoatedSpeed*Time.deltaTime;  
			if(roate)  
			{  
				gameObject.transform.Rotate(new Vector3(0,0,z));  

			}  

		}  

	}  
	void OnMouseDown()  
	{  

		roate =false;  
		Debug.Log("collider");  
	}  
	void OnMouseUp()  
	{  
		roate = true;  
		Debug.Log("Out of collider");  
	}  

}  