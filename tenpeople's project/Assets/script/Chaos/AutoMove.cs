using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMove : MonoBehaviour {
	public Transform[] wayPoints;
	public float speed=2;
	public Collider2D collider,colliderother;
	int targetPointIndex;
	bool touched;
	float times;
	void OnDrawGizmos()
	{
		var last = wayPoints.Last ();
		foreach (var t in wayPoints) {
			Gizmos.color = Color.green;
			Gizmos.DrawLine (last.position, t.position);
			Gizmos.color = Color.red;
			Gizmos.DrawSphere (t.position, 0.1f);
			last = t;
		}
	}

	void Update(){
		// 1. Move this object toward target point;
		// 2. If this object reached target point:
		// 2.1 target point changes to next point in wayPoint array.
		if (Physics2D.IsTouching (collider, colliderother)) {
			Debug.Log ("Stop");
			return;

		}
		times = (wayPoints [targetPointIndex].position - transform.position).magnitude;
		Debug.Log("The distace:"+ times);
		transform.position = Vector3.Lerp(transform.position,wayPoints[targetPointIndex].position,speed*Time.deltaTime);
		if (transform.position == wayPoints [targetPointIndex].position) {
			targetPointIndex++;
			targetPointIndex = targetPointIndex >= wayPoints.Length ? 0 : targetPointIndex;
		}
		//wayPoints.Length;
		//transform.position;
		//wayPoints [targetPointIndex].position;
		//Vector3.Lerp ();
	}
}
