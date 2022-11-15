using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopLevel : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.transform.position = new Vector3(-5f, 8f, 0f);
        }
    }
}
