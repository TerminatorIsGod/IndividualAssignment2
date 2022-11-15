using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoopLevel : MonoBehaviour
{
    public GameObject Player;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.transform.position = new Vector3(Player.transform.position.x, 8f, 0f);
        }
    }
}
