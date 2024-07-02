using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float damage = 1;
    public float knockbackForce = 300f;
    public float moveSpeed = 150f;
    
    public DetectionZone detectionZone;
    
    Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (detectionZone.detectedObjects.Count > 0)
        {
            Vector2 direction = (detectionZone.detectedObjects[0].transform.position - transform.position).normalized;
            rb.AddForce(direction * moveSpeed * Time.deltaTime);
        }
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        Collider2D collider = col.collider;
        IDamageable damageable = col.collider.GetComponent<IDamageable>();

        if (damageable != null)
        {
            Vector2 direction = (collider.transform.position - transform.position).normalized;
            Vector2 knockback = direction * knockbackForce;

            damageable.OnHit(damage, knockback);
        }
    }
}
