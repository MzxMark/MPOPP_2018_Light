using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
    private Animator m_animator;
    public Canvas death;
    // Use this for initialization
    public float preparetime;
    float tempTime = 0f;
    void Start () {
        death.enabled = false;
        float time = Time.time;
        tempTime = time;
        m_animator = GetComponent<Animator>();
    }
	public int directions;
    // Update is called once per frame
    void Update()
    {
        var idle = false;
        var up = false;
        var left = false;
        var right = false;
        float time = Time.time;
        if ((time - tempTime > preparetime) && (GM.isActive))
        {
            switch (directions) {
                case 0:
                    gameObject.transform.Translate(Vector2.up * 3 * Time.deltaTime);
                    up = true;
                    break;
                case 1:
                    gameObject.transform.Translate(Vector2.down * 3 * Time.deltaTime);

                    break;
                case 2:
                    gameObject.transform.Translate(Vector2.left * 3 * Time.deltaTime);
                    left = true;
                    break;
                default:
                    gameObject.transform.Translate(Vector2.right * 3 * Time.deltaTime);
                    right = true;
                    break;
            }
        }
        m_animator.SetBool("idle", idle);
        m_animator.SetBool("up", up);
        m_animator.SetBool("left", left);
        m_animator.SetBool("right", right);
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    private void OnTriggerEnter2D(Collider2D collision)
    {
        transform.position = collision.transform.position;
        if (collision.gameObject.tag == "up")
        {
			directions = 0;
           
        } 
		if (collision.gameObject.tag == "down")
		{
			directions = 1;
		} 
		if (collision.gameObject.tag == "left")
		{
			directions = 2; 
        } 
		if (collision.gameObject.tag == "right")
		{
			directions = 3;
		}
        if (collision.gameObject.tag == "light" )
        {
            GM.isActive = false;
            death.enabled = true;
        }
    }
}
