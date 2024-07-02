using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class Boss : MonoBehaviour, IDamageable
{
    bool isAlive = true;
    Collider2D physisCollider;

    public float Health
    {
        set
        {
            if(value < _health)
            {
                animator.SetTrigger("hit");
            }

            _health = value;

            if (_health <= 0)
            {
                DestroySelf();
                OnBossDeath?.Invoke();
            }
        }
        get
        {
            return _health;
        }
    }

    public bool Targetable 
    { 
        get 
        {
            return _targetable;
        }
        set 
        {
            _targetable = value;
            rb.simulated = false;
            physisCollider.enabled = value;
        } 
    }

    public float _maxHealth = 5;
    private float _health;
    public float damage = 1;
    public float knockbackForce = 300f;
    public float moveSpeed = 150f;
    public bool _targetable = true;
    public static event Action OnBossDeath;

    public HealthBar healthBar;
    public DetectionZone detectionZone;

    Animator animator;
    Rigidbody2D rb;

    public void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("isAlive", isAlive);
        rb = GetComponent<Rigidbody2D>();
        _health = _maxHealth;
    }
    private void FixedUpdate()
    {
        if (detectionZone.detectedObjects.Count > 0)
        {
            Vector2 direction = (detectionZone.detectedObjects[0].transform.position - transform.position).normalized;
            rb.AddForce(direction * moveSpeed * Time.deltaTime);
        }
    }

    public void OnHit(float damage, Vector2 knockback)
    {
        rb.AddForce(knockback, ForceMode2D.Impulse);
        Debug.Log("Force" + knockback);

        Health -= damage;
        healthBar.updateHealthBar(_health, _maxHealth);

    }

    public void OnHit(float damage)
    {
        Health -= damage;
        healthBar.updateHealthBar(_health, _maxHealth);
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
    public void DestroySelf()
    {
        Destroy(gameObject);
    }
}
