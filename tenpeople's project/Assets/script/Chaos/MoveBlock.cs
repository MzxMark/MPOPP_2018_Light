using UnityEngine; 
using System.Collections;  

public class MoveBlock : MonoBehaviour {  

	// Use this for initialization  
	void Start () {  

	}  
	void Update () {  

	}  
	IEnumerator OnMouseDown()  
	{  
		Vector3 ScreenSpace = Camera.main.WorldToScreenPoint(transform.position);  
		Vector3 offset = transform.position-Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,ScreenSpace.z));  
		Debug.Log("down");  
		while(Input.GetMouseButton(0))  
		{  
			Vector3 curScreenSpace =  new Vector3(Input.mousePosition.x,Input.mousePosition.y,ScreenSpace.z);     
	
			Vector3 CurPosition = Camera.main.ScreenToWorldPoint(curScreenSpace)+offset;          

			transform.position = CurPosition;  

			yield return new WaitForFixedUpdate();  
		}  


	}  
}  