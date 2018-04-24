using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deanslight : MonoBehaviour
{
    private float time = 0;
    private float speed = 3;
    GameObject clone;
    public GameObject self;
    bool ting = true;
    int A = 1;

    void Start()
    {

    }



    void Update()
    {

        if (A == 1)
        {
            this.transform.Translate(Vector3.up * speed * Time.deltaTime);
            if (ting == true)
            {
                clone = Instantiate(self, transform.position, transform.rotation);
            }

        }
        if (A == 0)
        {
            this.transform.Translate(Vector3.right * speed * Time.deltaTime);
            if (ting == true)
            {
                clone = Instantiate(self, transform.position, transform.rotation);
            }
        }



    }
    void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.collider.tag == "stp" || collision.collider.tag == "trigger")
        {
            speed = 0f;
            ting = false;



        }
        if (collision.collider.tag == "turn")
        {
            A = 0;
        }


    }


}