using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;

public class DamageableCharacter : MonoBehaviour, IDamageable
{

    public float Health
    {
        set
        {
            _health = value;

            if (_health <= 0)
            {
                Destroy(gameObject);
                if (gameObject.CompareTag("Player"))
                {
                    OnPlayerDeath?.Invoke();
                }
            }
        }
        get
        {
            return _health;
        }
    }

    public float _maxHealth = 1;
    private float _health ;

    public HealthBar healthBar;
    public static event Action OnPlayerDeath;

    Animator animator;
    Rigidbody2D rb;

    public void Start()
    {
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        _health = _maxHealth;
    }

    public void OnHit(float damage, Vector2 knockback)
    {
        rb.AddForce(knockback,ForceMode2D.Impulse);
        Debug.Log("Force" + knockback);

        Health -= damage;
        healthBar.updateHealthBar(_health, _maxHealth);

    }

    public void OnHit(float damage)
    {
        Health -= damage;
        healthBar.updateHealthBar(_health, _maxHealth);
    }

}
