using UnityEngine; 
using System.Collections;
using System;
public class MoveBlock : MonoBehaviour {
    private bool nm = true;
	// Use this for initialization  
	void Start () {  

	}  
	void Update () {
        if (GM.isActive)
        {
            nm = false;
        }

	}  
	IEnumerator OnMouseDown()  
	{  if(nm == true)
        {
            Vector3 ScreenSpace = Camera.main.WorldToScreenPoint(transform.position);
            Vector3 offset = transform.position - Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, ScreenSpace.z));
            Debug.Log("down");
            while (Input.GetMouseButton(0))
            {
                Vector3 curScreenSpace = new Vector3(Input.mousePosition.x, Input.mousePosition.y, ScreenSpace.z);

                Vector3 CurPosition = Camera.main.ScreenToWorldPoint(curScreenSpace) + offset;

                transform.position = CurPosition;

                yield return new WaitForFixedUpdate();
            }
            double x = transform.position.x;
            Debug.Log("The x1: " + x);
            double y = transform.position.y;
            Debug.Log("The y1: " + y);
            if (x < 0)
            {
                x = System.Math.Abs(x);
                x = Math.Round(x, 0);
                x = x + 0.5;
                x = -x;
            }
            if (x > 0)
            {
                x = System.Math.Abs(x);
                x = Math.Round(x, 0);
                x = x + 0.5;
            }
            if (y < 0)
            {
                y = System.Math.Abs(y);
                y = Math.Round(y, 0);
                y = y + 0.5;
                y = -y;
            }
            if (y > 0)
            {
                y = System.Math.Abs(y);
                y = Math.Round(y, 0);
                y = y + 0.5;
            }

            transform.position = new Vector3((float)x, (float)y, 0);
        }
		


	}
    public static double Round(double value, int digit)
    {
        double vt = Math.Pow(10, digit);
        //1.乘以倍数 + 0.5
        double vx = value * vt + 0.4;
        //2.向下取整
        double temp = Math.Floor(vx);
        //3.再除以倍数
        return (temp / vt);
    }
}  