using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {

    // Use this for initialization
    public float preparetime;
    float tempTime = 0f;
    int A=1;
    void Start () {
        float time = Time.time;
        tempTime = time;
    }
	public int directions;
	// Update is called once per frame
	void Update ()
    {
        float time = Time.time;
        if ((time - tempTime > preparetime) && (A==1))
        {
			switch (directions) {
			case 0:
				gameObject.transform.Translate (Vector2.up * 3 * Time.deltaTime);
				break;
			case 1:
				gameObject.transform.Translate (Vector2.down * 3 * Time.deltaTime);
				break;
			case 2:
				gameObject.transform.Translate (Vector2.left * 3 * Time.deltaTime);
				break;
			default:
				gameObject.transform.Translate (Vector2.right * 3 * Time.deltaTime);
				break;
			}
        }
        if (A == 0)
        {
            gameObject.transform.Translate(Vector2.left * 3 * Time.deltaTime);
            Debug.Log("1");
        }
        if(A ==2 )
        {
            gameObject.transform.Translate(Vector2.right * 3 * Time.deltaTime);
        }
        if (A == 3)
        {
            gameObject.transform.Translate(Vector2.up * 3 * Time.deltaTime);
        }
        if (A == 4)
        {
            gameObject.transform.Translate(Vector2.down * 3 * Time.deltaTime);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "left")
        {
            A = 0;
        } 
        if (collision.gameObject.tag == "right")
        {
            A = 2;
        }
        if (collision.gameObject.tag == "up")
        {
            A = 3;
        }
        if (collision.gameObject.tag == "down")
        {
            A = 4;
        }
    }
}
