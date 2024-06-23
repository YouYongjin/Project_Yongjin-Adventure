using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadZone : MonoBehaviour
{
    public GameObject spawnPoint;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.transform.tag == "Player")
        {
            Debug.Log("����");
            collision.transform.position = spawnPoint.transform.position;
        }
        
    }
}
