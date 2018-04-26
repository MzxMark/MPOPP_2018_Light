using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap : MonoBehaviour {
    public GameObject trigger;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
       

    }
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.tag == "light")
        {

            GameObject.Destroy(trigger.gameObject);
          //  trigger.gameObject.SetActive(false);
        }
      


    }
}
