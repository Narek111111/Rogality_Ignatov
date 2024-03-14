using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class DestroyOnCollision : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        void OnCollisionEnter2D(Collision2D collision)
        {
            if (collision.gameObject.tag == "Player")
            {
                Destroy(gameObject);
                Debug.Log("BOM");
            }
            else
            {
                Debug.Log("BEZ_BOM");
            }
        }
    }
}