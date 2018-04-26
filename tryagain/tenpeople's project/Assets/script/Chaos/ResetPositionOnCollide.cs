using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetPositionOnCollide : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        print(other.name + "Enter");
        if (other.tag != "Player") return;

        other.transform.position = transform.position;
    }
}
