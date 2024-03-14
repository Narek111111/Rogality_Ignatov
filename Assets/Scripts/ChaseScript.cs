using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class ChaseScript : MonoBehaviour
{
    public Transform player;
    public Vector2 chaseVelocity;
    private Rigidbody2D rb;
        void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    void FixedUpdate()
    {
        var direction = player.position - transform.position;
        direction.Normalize();
        rb.velocity = chaseVelocity * direction;
    }
}